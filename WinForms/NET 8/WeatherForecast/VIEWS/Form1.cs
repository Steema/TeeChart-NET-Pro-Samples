using System.Net;
using MeteoApp.CONTROLLERS;
using MeteoApp.MODELS;
using Steema.TeeChart.Styles;
using Steema.TeeChart.Tools;
using Steema.TeeChart;
using MeteoApp.LANGUAGES;
using PdfSharp.Pdf.Annotations;
using Steema.TeeChart.Editors.Tools;
using Steema.TeeChart.Languages;
using System;
using System.Globalization;
using Steema.TeeChart.WPF.Drawing;
using Steema.TeeChart.Drawing;
using System.Diagnostics;

namespace MeteoApp
{
    public partial class Form1 : Form
    {
        #region PRIVATE FIELDS
        // Controllerss
        private WeatherController weatherController;

        // Weather Respones
        private WeatherResponse currentTemperature;
        private Forecast allTemperatures;

        // Lists
        List<string> lstIconUrls = new List<string>();
        private List<double> verticalLinePositions = new List<double>();
        private List<string> recentCities = new List<string>();
        private const int MAX_RECENT_CITIES = 10;

        // Chart Tools
        NearestPoint toolNPTemp = null;
        NearestPoint toolNPHumidity = null;
        Annotation annotation;
        Axis vertAxis, horizAxis;

        // Dictionaries
        private Dictionary<DateTime, string> daysWithDates = new Dictionary<DateTime, string>();
        private Dictionary<double, string> hoursWithDates = new Dictionary<double, string>();
        private Dictionary<string, List<string>> iconsForDay = new Dictionary<string, List<string>>();
        private Dictionary<string, Bitmap> imageCache = new Dictionary<string, Bitmap>();
        private Dictionary<string, Tuple<double, double>> rankDays = new Dictionary<string, Tuple<double, double>>();

        // Other  Variables
        private bool eventAdded = false;
        private double? firstBarXNextDay = null;
        private double? lastBarX;
        public string currentCity;
        public bool btnDay = false;
        private bool isUpdatingComboBox;

        //SuggestionCities
        private System.Timers.Timer searchTimer;
        private List<Location> currentSuggestions = new List<Location>();
        private bool isSelectingSuggestion = false;
        #endregion


        public Form1()
        {
            InitializeComponent();
            InitializeSearchTimer();

            weatherController = new WeatherController();
            currentTemperature = new WeatherResponse();
            Update();
            Language.UpdateMenuStrip(languageMenuStrip);

            cmbDays.Visible = false;
            tChart1.Panning.Allow = ScrollModes.None;
            tChart1.Legend.Visible = false;
            tChart2.Panning.Allow = ScrollModes.None;
            tChart1.Zoom.Allow = false;
            tChart2.Zoom.Allow = false;

            #region RECENT CITIES
            LoadRecentCities();
            UpdateRecentCitiesList();
            #endregion

            #region CHART STYLE CONFIGURATION
            tChart1.Panel.Gradient.Visible = true;
            tChart1.Panel.Gradient.StartColor = Color.FromArgb(255, 255, 255);
            tChart1.Panel.Gradient.EndColor = Color.FromArgb(250, 252, 255);
            tChart1.Panel.Gradient.Direction = Steema.TeeChart.Drawing.LinearGradientMode.Vertical;

            tChart1.Axes.Bottom.Grid.Visible = false;
            tChart1.Axes.Bottom.Labels.Font.Size = 8;
            tChart1.Axes.Bottom.Labels.Font.Bold = true;
            tChart1.Axes.Bottom.Labels.Font.Color = Color.FromArgb(80, 102, 120);
            #endregion

            #region CONFIGURATION OF THE CHART TITLE
            tChart1.Header.Font.Size = 14;
            tChart1.Header.Font.Bold = true;
            tChart1.Header.Font.Color = Color.FromArgb(80, 102, 120);
            tChart1.Header.Font.Name = "Segoe UI";
            tChart1.Header.Transparent = true;

            tChart2.Header.Font.Size = 14;
            tChart2.Header.Font.Bold = true;
            tChart2.Header.Font.Color = Color.FromArgb(80, 102, 120);
            tChart2.Header.Font.Name = "Segoe UI";
            tChart2.Header.Transparent = true;
            #endregion
        }

        private void LoadRecentCities()
        {
            try
            {
                string savedCities = Properties.Settings.Default.RecentCities;
                if (!string.IsNullOrEmpty(savedCities))
                {
                    recentCities = savedCities.Split('|').ToList();
                    UpdateRecentCitiesList();
                }
            }
            catch (Exception ex)
            {
                // Log error if needed
                recentCities = new List<string>();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
            this.AcceptButton = btnSearch;
        }


        #region UPDATE METHODS
        /// <summary>
        /// Updates the controllers and the UI elements such as the menu.
        /// </summary>
        public void Update()
        {
            Language.Controllers(this);
        }


        /// <summary>
        /// Updates the annotations on the chart, adding labels for each vertical line.
        /// </summary>
        public void UpdateAnnotations()
        {
            // Remove previous annotations to avoid duplicates
            for (int i = tChart1.Tools.Count - 1; i >= 0; i--)
            {
                if (tChart1.Tools[i] is Annotation)
                {
                    tChart1.Tools.RemoveAt(i);
                }
            }

            foreach (var verticalLineX in verticalLinePositions)
            {
                // Draw the vertical line
                int pixelX = tChart1.Axes.Bottom.CalcXPosValue(verticalLineX);

                DateTime dateFrom = DateTime.FromOADate(verticalLineX);
                DateTime dateTo = dateFrom.AddDays(1);


                string day1 = daysWithDates.FirstOrDefault(d => d.Key.Date == dateFrom.Date).Value;
                string day2 = daysWithDates.FirstOrDefault(d => d.Key.Date == dateTo.Date).Value;

                day1 = day1?.Trim();
                day2 = day2?.Trim();

                if (day2 != null)
                {

                    day1 = Language.info.ContainsKey(day1) ? Language.info[day1] : day1;
                    day2 = Language.info.ContainsKey(day2) ? Language.info[day2] : day2;
                }

                // Annotation of the first day 
                Annotation annotationLeft = new Annotation(tChart1.Chart);
                annotationLeft.Text = day1;
                annotationLeft.Left = pixelX - 95 - 40;
                annotationLeft.Top = tChart1.Axes.Left.IStartPos + 10;
                annotationLeft.Shape.Transparent = true;
                tChart1.Tools.Add(annotationLeft);


                if (day2 != null)
                {
                    Annotation annotationRight = new Annotation(tChart1.Chart);
                    annotationRight.Text = day2;
                    annotationRight.Left = pixelX + 24;
                    annotationRight.Top = tChart1.Axes.Left.IStartPos + 10;
                    annotationRight.Shape.Transparent = true;
                    tChart1.Tools.Add(annotationRight);
                }
            }
        }


        /// <summary>
        /// Adds the days of the week in a cmbBox and updates depending on the chosen language.
        /// </summary>
        public void UpdateAndLoadForecastDays()
        {
            if (allTemperatures == null || allTemperatures.forecastday.Count < 3)
            {
                return;
            }

            int selectedIndex = cmbDays.SelectedIndex; // Save current selection
            string selectedDay = (cmbDays.SelectedItem != null) ? cmbDays.SelectedItem.ToString() : "";

            cmbDays.Items.Clear();

            for (int i = 0; i < 3; i++)
            {
                DateTime date = DateTime.Parse(allTemperatures.forecastday[i].date);
                string dayOfTheWeek = date.ToString("dddd");


                if (Language.info.ContainsKey(dayOfTheWeek))
                {
                    dayOfTheWeek = Language.info[dayOfTheWeek];
                }

                string dayFormatted = $"{dayOfTheWeek} ({date:dd/MM})";
                string dateKey = date.ToString("yyyy-MM-dd");

                daysWithDates[date] = dayFormatted;
                cmbDays.Items.Add(dayFormatted);
            }

            // Restore previous selection if it still exists
            if (!string.IsNullOrEmpty(selectedDay) && cmbDays.Items.Contains(selectedDay))
            {
                cmbDays.SelectedItem = selectedDay;
            }
            else if (cmbDays.Items.Count > 0)
            {
                cmbDays.SelectedIndex = selectedIndex >= 0 && selectedIndex < cmbDays.Items.Count ? selectedIndex : 0;
            }
        }


        /// <summary>
        /// Updates the language of the chart headers and series titles in the `tChart2` chart.
        /// It translates the evolution of the day, temperature, and humidity texts based on the selected language.
        /// If translations are not available, it uses default values.
        /// </summary>
        public void UpdateChartLanguage()
        {
            if (allTemperatures != null && allTemperatures.forecastday.Count > 0)
            {
                string headerTxt = Language.info.ContainsKey("Forecast_by_hour") ? Language.info["Forecast_by_hour"] : "FORECAST BY HOUR";
                tChart1.Header.Text = headerTxt;

                // Get translations
                string evolutionText = Language.info.ContainsKey("EVOLUTION_OF_DAY") ? Language.info["EVOLUTION_OF_DAY"] : "EVOLUTION OF DAY";
                string tempHumText = Language.info.ContainsKey("TEMP_HUMIDITY") ? Language.info["TEMP_HUMIDITY"] : "Temperatura / Humitat relativa";

                // Update chart headers without modifying the data
                tChart2.Header.Text = $"{evolutionText}: {allTemperatures.forecastday[0].date}";
                tChart2.SubHeader.Text = tempHumText;

                tChart2.Refresh();
            }

            if (tChart2.Series.Count >= 2)
            {
                string tempText = Language.info.ContainsKey("TemperatureTchart2") ? Language.info["TemperatureTchart2"] : "Temperature (ºC)";
                string humText = Language.info.ContainsKey("HumidityTchart2") ? Language.info["HumidityTchart2"] : "Humidity (%)";

                tChart2.Series[0].Title = tempText;
                tChart2.Series[1].Title = humText;

                tChart2.Refresh();
            }
        }
        #endregion


        #region TEMPERATURE METHODS
        /// <summary>
        ///  Gets the current temperature of the specified city and updates the UI elements.
        /// </summary>
        /// <param name="city">The city for which to get the temperature</param>}
        private async Task<bool> GetCurrentTemperatureAsync(string city)
        {
            currentTemperature = await weatherController.GetCurrentTemperatura(city);

            if (currentTemperature != null)
            {
                txtTemperature.Text = Math.Truncate(currentTemperature.Current.temp_c).ToString() + "ºC";
                txtCity.Text = currentTemperature.Location.Name;
                txtRegion.Text = $"{currentTemperature.Location.Region}, {currentTemperature.Location.Country}";
                string iconUrl = $"https:{currentTemperature.Current.condition.Icon}";
                imgWeatherIcon.Load($"https:{currentTemperature.Current.condition.Icon}");
                return true;
            }
            else
            {
                txtTemperature.Text = "--°C";
                txtCity.Text = "City not found";
                txtRegion.Text = "";
                imgWeatherIcon = null;
                return false;
            }
        }


        /// <summary>
        /// Retrieves the hourly weather evolution for the specified city and displays it in a bar chart.
        /// </summary>
        /// <param name="city">The name of the city to fetch the weather evolution for.</param>
        public async void GetAllTemperatures(string city)
        {
            Bar barSeries;

            scrollBarChart.Visible = true;
            cmbDays.Visible = true;


            tChart1.Axes.Bottom.Labels.Separation = 90;

            btnDay = false;

            verticalLinePositions.Clear();

            if (tChart1.Series.Count == 0)
            {
                barSeries = new Bar();
                tChart1.Series.Add(barSeries);
                tChart1.Legend.Visible = false;
                tChart1.Series[0].Marks.Visible = false;
            }
            else
            {
                while (tChart1.Series.Count > 1)
                {
                    tChart1.Series.RemoveAt(1);
                }

                barSeries = (Bar)tChart1.Series[0];
                barSeries.Clear();
            }

            tChart1.Axes.Left.Labels.Visible = false;

            #region BAR SERIES CONFIGURATION
            barSeries.ColorEach = false;
            barSeries.OffsetPercent = 0;
            barSeries.Color = Color.FromArgb(52, 152, 219);
            barSeries.Gradient.Visible = true;
            barSeries.Gradient.StartColor = Color.LightBlue;
            barSeries.Gradient.EndColor = Color.FromArgb(136, 193, 231);
            barSeries.Gradient.Direction = Steema.TeeChart.Drawing.LinearGradientMode.ForwardDiagonal;
            barSeries.Transparency = 20;
            barSeries.Pen.Visible = true;
            barSeries.Pen.Width = 1;
            barSeries.BarWidthPercent = 80;
            barSeries.BarStyle = BarStyles.RectGradient;
            #endregion

            if (tChart1.Series.Count > 0)
            {
                tChart1.Series[0].Clear();
                iconsForDay.Clear();
                daysWithDates.Clear();
                hoursWithDates.Clear();
            }


            string headerTxt = Language.info.ContainsKey("Forecast_by_hour") ?
                Language.info["Forecast_by_hour"] : "FORECAST BY HOUR";
            tChart1.Header.Text = headerTxt;

            if (city == null)
                return;

            allTemperatures = await weatherController.GetEvolutionOfWeatherByCity(city);

            if (allTemperatures != null && allTemperatures.forecastday.Count > 0)
            {
                double? firstBarX = null;
                DateTime? lastBarTime = null;
                double? lastBarX = null;
                double? firstBarXNextDay = null;

                foreach (Forecastday dia in allTemperatures.forecastday)
                {
                    DateTime date = DateTime.Parse(dia.date);
                    string dateKey = date.ToString("yyyy-MM-dd");
                    daysWithDates[date] = date.ToString("dddd");

                    List<string> tempIcons = new List<string>();
                    firstBarX = null; // Reset para cada día

                    foreach (var hora in dia.hour)
                    {
                        DateTime fechaHora = DateTime.Parse(hora.time.ToString());

                        if (fechaHora < DateTime.Now)
                            continue;

                        double hourValue = fechaHora.ToOADate();
                        barSeries.Add(hourValue, hora.temp_c, fechaHora.ToString("HH:mm"));
                        hoursWithDates[hourValue] = dateKey;
                        tempIcons.Add($"https:{hora.condition.Icon}");


                        if (firstBarX == null)
                            firstBarX = hourValue;

                        lastBarTime = fechaHora;
                        lastBarX = hourValue;

                        rankDays[dateKey] = new Tuple<double, double>(firstBarX ?? 0, lastBarX ?? 0);
                    }

                    if (tempIcons.Count > 0)
                        iconsForDay[dateKey] = tempIcons;

                    if (firstBarX != null)
                        firstBarXNextDay = firstBarX;

                    if (lastBarTime != null && firstBarXNextDay != null)
                    {
                        DateTime date23 = date.AddHours(23);
                        DateTime date00 = date.AddDays(1).AddHours(0);

                        double x23 = date23.ToOADate();
                        double x00 = date00.ToOADate();

                        double verticalLineX = (x23 + x00) / 2;
                        verticalLinePositions.Add(verticalLineX);
                    }
                }

                tChart1.Page.MaxPointsPerPage = 11;
                tChart1.Page.Current = 1;

                await Task.Delay(100);

                if (barSeries.Count > 0)
                {
                    double minX = barSeries.MinXValue();
                    double maxX = barSeries.MaxXValue();

                    if (maxX - minX < 10)
                    {
                        maxX = minX + 10;
                    }

                    double visibleRange = (maxX - minX) / 20;


                    scrollBarChart.Minimum = 0;
                    scrollBarChart.Maximum = 990;
                    scrollBarChart.Value = 0;
                    scrollBarChart.LargeChange = 10;


                    double initialMax = minX + visibleRange;
                    tChart1.Axes.Bottom.SetMinMax(minX, initialMax);

                    double minY = barSeries.MinYValue();
                    double maxY = barSeries.MaxYValue();

                    double margenY = (maxY - minY) * 0.15;
                    if (minY > 0 && minY < 5)
                    {
                        minY = 0;
                    }
                    else
                    {
                        minY = minY - margenY;
                    }

                    tChart1.Axes.Left.SetMinMax(minY, maxY + margenY);

                    if (minY < 0 && maxY > 0)
                        tChart1.Axes.Left.Grid.Centered = true;
                }
                else
                {
                    MessageBox.Show("No data were found to display in the graph.");
                }

                UpdateAndLoadForecastDays();
                UpdateAnnotations();

                tChart1.Refresh();
                tChart1.Invalidate();
            }
        }



        /// <summary>
        /// Retrieves the 7-day weather forecast for the specified city and displays it in a bar chart.
        /// </summary>
        /// <param name="city">The name of the city to fetch the weather forecast for</param>
        /// 
        public async void GetAllTemperaturesByDays(string city)
        {
            cmbDays.Visible = false;
            Bar barSeries = (tChart1.Series.Count == 0) ? new Bar() : (Bar)tChart1.Series[0];
            tChart1.Aspect.View3D = false;


            if (tChart1.Series.Count == 0)
            {
                barSeries.Transparency = 85;
                barSeries.ColorEach = false;
                tChart1.Series.Add(barSeries);
                ((Bar)tChart1.Series[0]).Marks.Visible = false;
                tChart1.Axes.Left.Labels.Visible = false;

            }

            scrollBarChart.Visible = false;
            btnDay = true;
            currentCity = city;

            barSeries.Clear();
            iconsForDay.Clear();
            daysWithDates.Clear();

            #region CONFIGURACION BAR SERIES
            barSeries.ColorEach = false;
            barSeries.Color = Color.FromArgb(52, 152, 219);
            barSeries.Gradient.Visible = true;
            barSeries.Gradient.StartColor = Color.LightBlue;
            barSeries.Gradient.EndColor = Color.FromArgb(136, 193, 231);
            barSeries.Gradient.Direction = Steema.TeeChart.Drawing.LinearGradientMode.ForwardDiagonal;
            barSeries.BarWidthPercent = 60;
            barSeries.BarStyle = BarStyles.RectGradient;
            barSeries.Pen.Visible = true;
            barSeries.Pen.Width = 1;
            barSeries.Transparency = 20;
            #endregion

            // Delete previous annotations (Only annotation type tools!)
            for (int i = tChart1.Tools.Count - 1; i >= 0; i--)
            {
                if (tChart1.Tools[i] is Annotation)
                {
                    tChart1.Tools.RemoveAt(i);
                }
            }

            allTemperatures = await weatherController.GetPrevisionBy10Days(city);

            if (allTemperatures != null && allTemperatures.forecastday.Count > 0)
            {
                tChart1.Header.Text = Language.info.ContainsKey("FORECAST_7_DAYS")
                                    ? Language.info["FORECAST_7_DAYS"]
                                    : "FORECAST (7 days)";

                foreach (Forecastday day in allTemperatures.forecastday)
                {
                    DateTime date = DateTime.Parse(day.date);
                    string dayOfTheWeek = date.ToString("dddd");


                    if (Language.info.ContainsKey(dayOfTheWeek))
                    {
                        dayOfTheWeek = Language.info[dayOfTheWeek];
                    }

                    string dateKey = date.ToString("yyyy-MM-dd");

                    daysWithDates[date] = dayOfTheWeek;

                    barSeries.Add(day.day.maxtemp_c, dayOfTheWeek);

                    string urlIcon = $"https:{day.day.condition.Icon}";
                    iconsForDay[dateKey] = new List<string> { urlIcon };
                }
            }

            // Force chart update
            tChart1.Axes.Bottom.Automatic = true;
            tChart1.Axes.Left.Automatic = true;

            barSeries.CustomBarWidth = 120;
            barSeries.BarWidthPercent = 60;
        }


        /// <summary>
        /// Obtains and displays the evolution of the temperature and relative humidity of a city on a graph.
        /// </summary>
        /// <param name="city">The city for which you wish to obtain temperature and humidity data</param>
        public async void GetTemperatureAndHumidity(string city)
        {
            if (tChart2?.Chart == null)
                return;

            SetupChartAppearance();

            tChart2.Series.Clear();

            for (int i = tChart2.Tools.Count - 1; i >= 0; i--)
            {
                if (tChart2.Tools[i] is NearestPoint)
                    tChart2.Tools.RemoveAt(i);
            }

            toolNPHumidity = null;
            toolNPTemp = null;


            Line lineTemperature = CreateTemperatureSeries();
            Line lineHumidity = CreateHumiditySeries();

            Color tempColor = lineTemperature.Color;

            lineTemperature.Color = lineHumidity.Color;
            lineHumidity.Color = tempColor;

            tChart2.Series.Add(lineTemperature);
            tChart2.Series.Add(lineHumidity);

            if (toolNPHumidity == null)
            {
                toolNPHumidity = new NearestPoint(tChart2.Chart)
                {
                    Series = lineHumidity,
                    Style = NearestPointStyles.Rectangle,
                    Size = 5,
                    Brush = { Color = lineHumidity.Color }
                };

                toolNPHumidity.Pen.Visible = true;
                toolNPHumidity.Pen.Color = Color.Black;
                toolNPHumidity.Pen.Width = 2;
                toolNPHumidity.DrawLine = false;
                toolNPHumidity.Pen.Style = Steema.TeeChart.Drawing.DashStyle.Solid;
                tChart2.Tools.Add(toolNPHumidity);

                toolNPHumidity.Change += ToolNPHumidity_Change;
            }
            if (toolNPTemp == null)
            {
                toolNPTemp = new NearestPoint(tChart2.Chart)
                {
                    Series = lineTemperature,
                    Style = NearestPointStyles.Circle,
                    Size = 5,
                    Brush = { Color = lineTemperature.Color }

                };

                toolNPTemp.Pen.Visible = true;
                toolNPTemp.Pen.Color = Color.Black;
                toolNPTemp.Pen.Width = 2;
                toolNPTemp.DrawLine = false;
                toolNPTemp.Pen.Style = Steema.TeeChart.Drawing.DashStyle.Solid;
                tChart2.Tools.Add(toolNPTemp);
            }

            allTemperatures = await weatherController.GetEvolutionOfHumidityAndTemperatureByCity(city);

            ConfigureAnottation();

            if (allTemperatures != null)
            {
                foreach (Forecastday day in allTemperatures.forecastday)
                {
                    string evolutionText = Language.info.ContainsKey("EVOLUTION_OF_DAY") ? Language.info["EVOLUTION_OF_DAY"] : "EVOLUTION OF THE DAY";
                    string tempHumText = Language.info.ContainsKey("TEMP_HUMIDITY") ? Language.info["TEMP_HUMIDITY"] : "Temperatura / Humitat relativa";

                    tChart2.Header.Text = $"{evolutionText}: {allTemperatures.forecastday[0].date}";
                    tChart2.SubHeader.Text = tempHumText;

                    foreach (var hour in day.hour)
                    {
                        DateTime dateHour = DateTime.Parse(hour.time.ToString());
                        if (dateHour.Hour >= 0 && dateHour.Hour <= 9 && (dateHour.Minute == 0 || dateHour.Minute == 30))
                        {
                            double hourValue = dateHour.ToOADate();

                            lineTemperature.XValues.DateTime = true;
                            lineHumidity.XValues.DateTime = true;

                            lineTemperature.Add(hourValue, hour.temp_c);
                            lineHumidity.Add(hourValue, hour.humidity);

                            string iconUrl = $"https:{hour.condition.Icon}";
                            lstIconUrls.Add(iconUrl);
                        }
                    }
                }
            }
            ConfigureAxes();

            tChart2.Axes.Bottom.SetMinMax(0, 0);
            tChart2.Axes.Bottom.Automatic = true;
            tChart2.Invalidate();
        }

        private Line CreateHumiditySeries()
        {
            string titleHum = Language.info.ContainsKey("HumidityTchart2") ? Language.info["HumidityTchart2"] : "Humidity (%)";
            Line lineHumidity = new Line(tChart2.Chart)
            {
                Title = titleHum,
                Smoothed = false,
                Stairs = false,
                VertAxis = VerticalAxis.Right
            };

            lineHumidity.Pointer.Visible = true;
            lineHumidity.Pointer.Style = PointerStyles.Rectangle;
            lineHumidity.Pointer.HorizSize = 6;
            lineHumidity.Pointer.VertSize = 6;
            lineHumidity.Pointer.Brush.Gradient.Visible = true;
            lineHumidity.Pointer.Brush.Gradient.StartColor = Color.White;
            lineHumidity.Pointer.Brush.Gradient.EndColor = Color.FromArgb(0, 123, 255);
            //lineHumidity.Pointer.Brush.Gradient.Direction = (Steema.TeeChart.Drawing.LinearGradientMode)GradientDirection.Radial;

            // Configure line appearance
            lineHumidity.LinePen.Width = 3;
            lineHumidity.LinePen.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
            lineHumidity.LinePen.EndCap = (Steema.TeeChart.Drawing.LineCap)System.Drawing.Drawing2D.LineCap.Round;

            lineHumidity.Marks.Visible = false;
            lineHumidity.Marks.Arrow.Visible = false;
            lineHumidity.Marks.Transparent = true;

            return lineHumidity;
        }

        private Line CreateTemperatureSeries()
        {
            string titleTemp = Language.info.ContainsKey("TemperatureTchart2") ? Language.info["TemperatureTchart2"] : "Temperature (ºC)";
            Line lineTemperature = new Line(tChart2.Chart)
            {
                Title = titleTemp,
                Smoothed = false,
                Stairs = false,
                VertAxis = VerticalAxis.Left
            };

            lineTemperature.Pointer.Visible = true;
            lineTemperature.Pointer.Style = PointerStyles.Circle;
            lineTemperature.Pointer.HorizSize = 6;
            lineTemperature.Pointer.VertSize = 6;
            lineTemperature.Pointer.Gradient.Visible = true;
            lineTemperature.Pointer.Brush.Gradient.StartColor = Color.White;
            lineTemperature.Pointer.Brush.Gradient.EndColor = Color.FromArgb(220, 53, 69);
            //lineTemperature.Pointer.Brush.Gradient.Direction = Steema.TeeChart.Drawing.LinearGradientMode.Vertical;

            lineTemperature.LinePen.Width = 3;
            lineTemperature.LinePen.EndCap = (Steema.TeeChart.Drawing.LineCap)System.Drawing.Drawing2D.LineCap.Round;

            // Add marks at the points
            lineTemperature.Marks.Visible = false;
            lineTemperature.Marks.Arrow.Visible = false;
            lineTemperature.Marks.Transparent = true;
            return lineTemperature;
        }

        private void SetupChartAppearance()
        {
            tChart2.Legend.Alignment = LegendAlignments.Bottom;
            tChart2.Legend.Font.Size = 10;
            tChart2.Legend.Font.Bold = true;

            tChart2.Panel.Gradient.Visible = true;
            tChart2.Panel.Gradient.StartColor = Color.White;
            tChart2.Panel.Gradient.EndColor = Color.FromArgb(245, 245, 245);
            tChart2.Panel.Gradient.Direction = Steema.TeeChart.Drawing.LinearGradientMode.Vertical;
            tChart2.Panel.Bevel.Inner = BevelStyles.None;
            tChart2.Panel.Bevel.Outer = BevelStyles.None;
            tChart2.Panel.BorderRound = 10;

            tChart2.SubHeader.Font.Size = 10;
            tChart2.SubHeader.Font.Color = Color.FromArgb(100, 100, 100);
        }

        private void ConfigureAnottation()
        {
            annotation = new Steema.TeeChart.Tools.Annotation(tChart2.Chart);

            annotation.Shape.Font.Size = 9;
            annotation.Shape.Font.Bold = false;
            annotation.Shape.Font.Name = "Segoe UI";
            annotation.Shape.Transparent = true;
            annotation.Shape.Shadow.Visible = true;
            annotation.Shape.Shadow.Transparency = 70;

            vertAxis = tChart2.Axes.Left;
            horizAxis = tChart2.Axes.Bottom;

            tChart2.MouseMove += TChart2_MouseMove;
        }

        public void ConfigureAxes()
        {

            tChart2.Axes.Bottom.Labels.Style = AxisLabelStyle.Value;
            tChart2.Axes.Bottom.Labels.ValueFormat = "HH:mm";
            tChart2.Axes.Bottom.Labels.DateTimeFormat = "HH:mm";
            tChart2.Axes.Bottom.Labels.Font.Size = 9;
            tChart2.Axes.Bottom.Labels.Font.Bold = true;
            tChart2.Axes.Bottom.Labels.Angle = 45;
            tChart2.Axes.Bottom.Title.Font.Size = 10;
            tChart2.Axes.Bottom.Title.Font.Bold = true;
            tChart2.Axes.Bottom.Grid.Color = Color.FromArgb(230, 230, 230);

            tChart2.Axes.Bottom.Increment = 1.0 / 24.0;  // Increment by 1 hour

            tChart2.Axes.Left.SetMinMax(0, 20);
            tChart2.Axes.Left.Increment = 5;
            tChart2.Axes.Left.Automatic = false;
            string tempText = Language.info.ContainsKey("TemperatureTchart2") ? Language.info["TemperatureTchart2"] : "Temperature (ºC)";
            tChart2.Axes.Left.Title.Text = tempText;
            tChart2.Axes.Left.Title.Font.Size = 10;
            tChart2.Axes.Left.Title.Font.Bold = true;

            tChart2.Axes.Right.SetMinMax(0, 100);
            tChart2.Axes.Right.Increment = 50;
            tChart2.Axes.Right.Automatic = false;
            string humText = Language.info.ContainsKey("HumidityTchart2") ? Language.info["HumidityTchart2"] : "Humidity (%)";
            tChart2.Axes.Right.Title.Text = humText;
            tChart2.Axes.Right.Title.Font.Size = 10;
            tChart2.Axes.Right.Title.Font.Bold = true;


            tChart2.Axes.Bottom.Labels.ExactDateTime = true;

            tChart2.Axes.Bottom.Maximum = 10;

            tChart2.Invalidate();
        }

        #endregion


        #region EVENT HANDLERS
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await SearchWeather();
        }

        private async Task SearchWeather()
        {
            Location selectedLocation = txtSearch.Tag as Location;
            string searchQuery;
            string displayName;

            if (selectedLocation != null)
            {
                // Usar coordenadas para mayor precisión
                searchQuery = selectedLocation.SearchQuery;
                displayName = selectedLocation.DisplayName;
            }
            else
            {
                searchQuery = txtSearch.Text?.Trim();
                displayName = searchQuery;
            }

            if (!string.IsNullOrEmpty(searchQuery))
            {
                try
                {
                    bool cityFound = await GetCurrentTemperatureAsync(searchQuery);
                    if (cityFound)
                    {
                        AddToRecentCities(displayName);
                        GetAllTemperaturesByDays(searchQuery);
                        GetTemperatureAndHumidity(searchQuery);
                    }
                    else
                    {
                        MessageBox.Show("The specified city was not found.", "City not found",
                            MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error when searching for the weather: {ex.Message}", "Error",
                         MessageBoxButtons.OK);
                }
            }
        }

        private void AddToRecentCities(string? cityName)
        {
            if (string.IsNullOrWhiteSpace(cityName)) return;

            cityName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cityName.ToLower());

            recentCities.Remove(cityName);

            recentCities.Insert(0, cityName);

            // Keep only the latest MAX_RECENT_CITIES cities
            if (recentCities.Count > MAX_RECENT_CITIES)
            {
                recentCities = recentCities.Take(MAX_RECENT_CITIES).ToList();
            }

            UpdateRecentCitiesList();
            SaveRecentCities();
        }

        private void SaveRecentCities()
        {
            try
            {
                Properties.Settings.Default.RecentCities = string.Join("|", recentCities);
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                // Log error if needed
            }
        }

        private void UpdateRecentCitiesList()
        {
            lstCities.Items.Clear();

            foreach (string city in recentCities)
            {
                lstCities.Items.Add(city);
            }
        }



        // Button to display temperatures per day (loads the temperature graph for each day of the week)
        private void btnDays_Click(object sender, EventArgs e)
        {
            btnDay = true;
            string city = txtSearch.Text;

            if (!string.IsNullOrEmpty(city))
            {
                GetAllTemperaturesByDays(city);

                if (tChart1.Series.Count > 0 && tChart1.Series[0] is Bar barSeries)
                {
                    barSeries.BarWidthPercent = 80;
                    barSeries.BarStyle = BarStyles.RectGradient;
                    tChart1.Invalidate();
                    tChart1.Update();
                }
            }
        }

        // Button for displaying hourly temperatures (loads the 3-day graph but displays each day's temperature by hour)
        private void btnHours_Click(object sender, EventArgs e)
        {
            string city = txtSearch.Text.Trim();

            if (!eventAdded)
            {
                tChart1.AfterDraw += TChart1_AfterDraw1;
                eventAdded = true;
            }

            if (!string.IsNullOrEmpty(city))
            {
                GetCurrentTemperatureAsync(city);
                GetAllTemperatures(city);
                GetTemperatureAndHumidity(city);

                if (tChart1.Series.Count > 0 && tChart1.Series[0] is Bar barSeries)
                {
                    barSeries.BarWidthPercent = 60;
                    barSeries.BarStyle = BarStyles.RectGradient;
                    tChart1.Invalidate();
                }
            }

        }

        private void englishToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Language.ChangeLenguage("en.txt");
            Update();
            Language.UpdateMenuStrip(languageMenuStrip);

        }

        private void catalanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Language.ChangeLenguage("ca.txt");
            Update();
            Language.UpdateMenuStrip(languageMenuStrip);

        }

        private void spanishToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Language.ChangeLenguage("es.txt");
            Update();
            Language.UpdateMenuStrip(languageMenuStrip);
        }

        #endregion


        #region TChart DRAWING HANDLERS


        /// <summary>
        ///  Draw the images on the graph for the temperatures per day, and also for the temperatures per hour.
        /// </summary>
        private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
        {
            // Removes any previous clipping regions that may have been configured
            tChart1.Graphics3D.ClearClipRegions();

            // Creates a rectangle that respects the horizontal boundaries of the chart (X and Width)
            // but extends from the top of the screen (Y=0) to the bottom of the chart
            Rectangle openTopRect = new Rectangle(
                                    tChart1.Chart.ChartRect.X,
                                    0, tChart1.Chart.ChartRect.Width,
                                    tChart1.Chart.ChartRect.Height +
                                    tChart1.Chart.ChartRect.Y
            );

            // Set this rectangle as the clipping region.
            // Anything drawn outside this region will be clipped (not visible).
            tChart1.Graphics3D.ClipRectangle(openTopRect);

            foreach (Series s in tChart1.Series)
            {
                if (!(s is Bar)) continue;

                Dictionary<string, List<int>> dataGroups = new Dictionary<string, List<int>>();

                for (int i = 0; i < s.Count; i++)
                {
                    string dateKey;

                    // Case 1: Data represents hours (GetAllTemperatures)
                    if (hoursWithDates.ContainsKey(s.XValues[i]))
                    {
                        dateKey = hoursWithDates[s.XValues[i]];
                    }
                    // Case 2: Data represents days (GetAllTemperaturesByDays)
                    else if (daysWithDates.ContainsValue(s.Labels[i]))
                    {
                        dateKey = daysWithDates.FirstOrDefault(x => x.Value == s.Labels[i]).Key.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        continue;
                    }

                    if (!dataGroups.ContainsKey(dateKey))
                        dataGroups[dateKey] = new List<int>();

                    dataGroups[dateKey].Add(i);
                }

                foreach (var group in dataGroups)
                {
                    int p = 0;
                    string dateKey = group.Key;

                    if (!iconsForDay.ContainsKey(dateKey) || iconsForDay[dateKey].Count == 0)
                        continue;

                    foreach (int index in group.Value)
                    {
                        Bitmap objBitmap;
                        if (s.Labels[index].Contains(":"))
                        {
                            int iconIndex = p % iconsForDay[dateKey].Count;
                            objBitmap = LoadBitmapFromUrl(iconsForDay[dateKey][iconIndex]);
                        }
                        else
                        {
                            objBitmap = LoadBitmapFromUrl(iconsForDay[dateKey][0]);
                        }

                        Steema.TeeChart.Drawing.TImage tChartImage = new Steema.TeeChart.Drawing.TImage(objBitmap);

                        int iconWidth = objBitmap.Width;
                        int iconHeight = objBitmap.Height;
                        int xPos = (int)tChart1.Axes.Bottom.CalcPosValue(s.XValues[index]) - (iconWidth / 2);
                        int yPos = (int)tChart1.Axes.Left.CalcPosValue(s.YValues[index]) - (iconHeight / 2);

                        g.Draw(xPos, yPos, tChartImage);

                        string txt = $"{s.YValues[index]}ºC";
                        int textWidth = (int)(g.TextWidth(txt) / 2);
                        int textYPos = yPos + iconHeight + 5;
                        int textXPos = xPos + (iconWidth / 2) - textWidth;

                        g.TextOut(textXPos, textYPos, txt);

                        p++;
                    }
                }
            }

            tChart1.Graphics3D.ClearClipRegions();
        }
        #endregion


        private void ToolNPHumidity_Change(object? sender, EventArgs e)
        {
            Line graphLineTemperature = (Line)tChart2.Series[0];
            Line graphLineHumidity = (Line)tChart2.Series[1];

            string tempText = Language.info.ContainsKey("Temperature") ? Language.info["Temperature"] : "Temperature";
            string humText = Language.info.ContainsKey("Humidity") ? Language.info["Humidity"] : "Humidity";

            int tempPoint = toolNPTemp.Point;
            int humPoint = toolNPHumidity.Point;

            // Validar que los índices sean válidos antes de acceder
            if (tempPoint >= 0 && tempPoint < graphLineTemperature.Count &&
                humPoint >= 0 && humPoint < graphLineHumidity.Count)
            {
                annotation.Text = $"{tempText}: {graphLineTemperature.YValues[tempPoint]}ºC \n " +
                                  $"{humText}: {graphLineHumidity.YValues[humPoint]}%";
            }
            else
            {
                annotation.Text = $"{tempText}: - \n {humText}: -";
            }
        }


        private void TChart2_MouseMove(object? sender, System.Windows.Forms.MouseEventArgs e)
        {
            toolNPHumidity.Active = e.X >= horizAxis.IStartPos && e.X <= horizAxis.IEndPos &&
            e.Y >= vertAxis.IStartPos && e.Y <= vertAxis.IEndPos;

            toolNPTemp.Active = e.X >= horizAxis.IStartPos && e.X <= horizAxis.IEndPos &&
            e.Y >= vertAxis.IStartPos && e.Y <= vertAxis.IEndPos;

            // Activate annotation if at least one of the tools is active
            annotation.Active = toolNPHumidity.Active || toolNPTemp.Active;
        }

        /// <summary>
        /// Downloads an image from a given URL and returns it as a BitmapImage for use in WPF.
        /// Utilizes a cache to avoid repeated downloads of the same image.
        /// </summary>
        /// <param name="url">The URL of the image to download.</param>
        /// <returns>A BitmapImage loaded from the specified URL.</returns>
        private Bitmap LoadBitmapFromUrl(string url)
        {
            if (imageCache.ContainsKey(url))
            {
                return imageCache[url];
            }

            using (WebClient client = new WebClient())
            {
                byte[] imageBytes = client.DownloadData(url);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Bitmap bitmap = new Bitmap(Image.FromStream(ms));
                    imageCache[url] = bitmap;
                    return bitmap;
                }
            }
        }

        private async void lstCities_SelectionChanged(object sender, EventArgs e)
        {
            if (lstCities.SelectedItem != null)
            {
                txtSearch.Text = lstCities.SelectedItem.ToString();
                txtSearch.Focus();
                txtSearch.SelectionStart = txtSearch.Text.Length;
            }

            string city = txtSearch.Text.Trim();

            if (!eventAdded)
            {
                tChart1.AfterDraw += TChart1_AfterDraw1; ;
                eventAdded = true;
            }

            if (!string.IsNullOrEmpty(city))
            {
                bool cityFound = await GetCurrentTemperatureAsync(city);

                if (cityFound)
                {
                    GetAllTemperaturesByDays(city);
                    GetTemperatureAndHumidity(city);
                }

            }
        }

        private void cmbDays_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (!isUpdatingComboBox &&
                    cmbDays.SelectedItem != null &&
                    cmbDays.SelectedIndex >= 0)
                {
                    string selectedDay = cmbDays.SelectedItem.ToString();

                    if (!string.IsNullOrWhiteSpace(selectedDay))
                    {
                        string fechaStr = selectedDay.Split('(')[1].Split(')')[0];

                        if (DateTime.TryParseExact(fechaStr, "dd/MM", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                        {
                            int currentYear = DateTime.Now.Year;
                            DateTime fullDate = new DateTime(currentYear, parsedDate.Month, parsedDate.Day);
                            string dateKey = fullDate.ToString("yyyy-MM-dd");

                            if (rankDays.ContainsKey(dateKey))
                            {
                                double minX = rankDays[dateKey].Item1;
                                double maxX = rankDays[dateKey].Item2;

                                if (minX >= 0 && maxX > minX)
                                {
                                    tChart1.Axes.Bottom.SetMinMax(minX, maxX);

                                    if (tChart1.Series.Count > 0 && tChart1.Series[0].Count > 0)
                                    {
                                        double globalMinX = tChart1.Series[0].MinXValue();
                                        double globalMaxX = tChart1.Series[0].MaxXValue();
                                        double totalRange = globalMaxX - globalMinX;

                                        if (totalRange > 0)
                                        {
                                            double selectedRange = minX - globalMinX;
                                            int sliderValue = (int)((selectedRange / totalRange) * scrollBarChart.Maximum);

                                            if (sliderValue >= scrollBarChart.Minimum && sliderValue <= scrollBarChart.Maximum)
                                            {
                                                scrollBarChart.Value = sliderValue;
                                            }
                                        }
                                    }

                                    tChart1.Invalidate();
                                    UpdateAnnotations();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing the selected day:\n" + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Draws vertical lines on the chart at specified X-axis positions after the chart is rendered.
        /// </summary>
        private void TChart1_AfterDraw1(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
        {
            int offsetX = 34;
            foreach (var verticalLineX in verticalLinePositions)
            {
                int pixelX = tChart1.Axes.Bottom.CalcXPosValue(verticalLineX);
                g.Line(pixelX, tChart1.Axes.Left.IStartPos, pixelX, tChart1.Axes.Left.IEndPos);
            }
        }

        private void InitializeSearchTimer()
        {
            searchTimer = new System.Timers.Timer(500); // 500ms delay
            searchTimer.Elapsed += async (s, e) => await SearchLocationsAsync();
            searchTimer.AutoReset = false;
        }

        private async Task SearchLocationsAsync()
        {
            try
            {
                string query = txtSearch.Text.Trim();
                if (!string.IsNullOrEmpty(query) && query.Length >= 3)
                {
                    var suggestions = await weatherController.GetLocationSuggestionsAsync(query);
                    currentSuggestions = suggestions;
                    this.Invoke((MethodInvoker)delegate
                    {
                        if (suggestions.Any())
                        {
                            suggestionsListBox.DisplayMember = "DisplayName";
                            suggestionsListBox.DataSource = suggestions;

                            // Find the absolute position of the txtSearch in the form
                            Point absoluteLocation = GetAbsoluteLocation(txtSearch);
                            suggestionsListBox.Location = new Point(absoluteLocation.X, absoluteLocation.Y + txtSearch.Height);


                            suggestionsListBox.Width = txtSearch.Width;

                            int itemHeight = suggestionsListBox.ItemHeight;
                            int maxItems = Math.Min(suggestions.Count(), 8);
                            suggestionsListBox.Height = (itemHeight * maxItems) + 4;

                            // Ensure that the ListBox is in the correct container
                            if (suggestionsListBox.Parent != this)
                            {
                                this.Controls.Add(suggestionsListBox);
                            }

                            suggestionsListBox.BringToFront();
                            suggestionsListBox.Visible = true;
                        }
                        else
                        {
                            suggestionsListBox.Visible = false;
                        }
                    });
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        suggestionsListBox.Visible = false;
                    });
                }
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    suggestionsListBox.Visible = false;
                });
            }
        }

        // Auxiliary method to obtain the absolute position of a control
        private Point GetAbsoluteLocation(Control control)
        {
            Point location = control.Location;
            Control parent = control.Parent;

            while (parent != null && parent != this)
            {
                location.X += parent.Location.X;
                location.Y += parent.Location.Y;
                parent = parent.Parent;
            }

            return location;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (isSelectingSuggestion) return;

            string query = txtSearch.Text?.Trim();

            if (string.IsNullOrEmpty(query) || query.Length < 3)
            {
                suggestionsListBox.Visible = false;
                return;
            }


            searchTimer?.Stop();
            searchTimer?.Start();
        }

        private async void txtSearch_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                await SearchWeather();
            }
        }

        private void txtSearch_LostFocus(object sender, EventArgs e)
        {
            Task.Delay(150).ContinueWith(_ =>
            {
                if (this.IsHandleCreated && !this.IsDisposed)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        suggestionsListBox.Visible = false;
                    });
                }
            });
        }


        private void BtnVisitWebsite_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.weatherapi.com/",
                UseShellExecute = true
            };

            Process.Start(psi);
        }

        private void scrollBarChart_Scroll(object sender, ScrollEventArgs e)
        {
            tChart1.Axes.Bottom.Automatic = false;

            if (tChart1.Series.Count == 0 || tChart1.Series[0].Count == 0)
                return;

            // Get the minimum and maximum value of the X-axis according to the position of the ScrollBar
            Bar barSeries = (Bar)tChart1.Series[0];
            double minX = barSeries.MinXValue();
            double maxX = barSeries.MaxXValue();
            double visibleRange = (maxX - minX) / 7;

            // Calculate the new display range on the chart
            double newMin = minX + e.NewValue * (maxX - minX - visibleRange) / scrollBarChart.Maximum;
            double newMax = newMin + visibleRange;

            // Prevent the range from going out of bounds
            if (newMax > maxX)
            {
                newMax = maxX;
                newMin = newMax - visibleRange;
            }

            // Avoid out-of-range values
            if (newMin < minX)
            {
                newMin = minX;
                newMax = newMin + visibleRange;
            }

            tChart1.Axes.Bottom.SetMinMax(newMin, newMax);
            UpdateAnnotations();

            isUpdatingComboBox = true;

            try
            {
                foreach (var kvp in rankDays)
                {
                    double minDay = kvp.Value.Item1;
                    double maxDay = kvp.Value.Item2;

                    // Check if the visible range intersects with the day's range
                    if ((newMin >= minDay && newMin <= maxDay) ||
                        (newMax >= minDay && newMax <= maxDay) ||
                        (newMin <= minDay && newMax >= maxDay))
                    {
                        DateTime dateKey = DateTime.Parse(kvp.Key);
                        string formattedDay = daysWithDates.ContainsKey(dateKey) ? daysWithDates[dateKey] : dateKey.ToString("dddd");

                        string fullDayText = null;
                        foreach (var item in cmbDays.Items)
                        {
                            if (item.ToString().StartsWith(formattedDay))
                            {
                                fullDayText = item.ToString();
                                break;
                            }
                        }

                        if (fullDayText != null)
                        {
                            int index = cmbDays.Items.IndexOf(fullDayText);
                            if (index != -1 && cmbDays.SelectedIndex != index)
                            {
                                cmbDays.SelectedIndex = index;
                            }
                        }
                        break;
                    }
                }
            }
            finally
            {
                isUpdatingComboBox = false;
            }
        }


        private void suggestionsList_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
           
            if (suggestionsListBox.SelectedItem is Location selected)
            {
                SelectSuggestion(selected);
            }
        }

        private void SelectSuggestion(Location selected)
        {
            isSelectingSuggestion = true;

            txtSearch.Text = selected.DisplayName;
            txtSearch.Tag = selected;

            suggestionsListBox.Visible = false;
            isSelectingSuggestion = false;

            txtSearch.SelectionStart = txtSearch.Text.Length;
            txtSearch.SelectionLength = 0;
        }


        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (btnDay) return;

            tChart1.Axes.Bottom.Automatic = false;

            if (tChart1.Series.Count == 0 || tChart1.Series[0].Count == 0)
                return;

            // Get the minimum and maximum value of the X-axis according to the position of the ScrollBar
            Bar barSeries = (Bar)tChart1.Series[0];
            double minX = barSeries.MinXValue();
            double maxX = barSeries.MaxXValue();
            double visibleRange = (maxX - minX) / 7;

            // Calculate the new display range on the chart
            double newMin = minX + e.NewValue * (maxX - minX - visibleRange) / scrollBarChart.Maximum;
            double newMax = newMin + visibleRange;


            if (newMax > maxX)
            {
                newMax = maxX;
                newMin = newMax - visibleRange;
            }

            if (newMin < minX)
            {
                newMin = minX;
                newMax = newMin + visibleRange;
            }

            tChart1.Axes.Bottom.SetMinMax(newMin, newMax);
            UpdateAnnotations();

            // PART OF THE CMBOX:
            foreach (var kvp in rankDays)
            {
                // Gets the minimum and maximum values for the selected day in the dictionary.
                double minDay = kvp.Value.Item1;
                double maxDay = kvp.Value.Item2;

                if (newMin >= minDay && newMin <= maxDay)
                {

                    string formattedDay = daysWithDates[DateTime.Parse(kvp.Key)];


                    int index = cmbDays.Items.IndexOf(formattedDay);

                    if (index != -1 && cmbDays.SelectedIndex != index)
                    {
                        cmbDays.SelectedIndex = index;
                    }
                    break;
                }
            }
        }

        // Synchronise the ScrollBar with the current page
        private void tChart1_Scroll(object sender, EventArgs e)
        {
            if (tChart1.Page.Current >= scrollBarChart.Minimum && tChart1.Page.Current <= scrollBarChart.Maximum)
                scrollBarChart.Value = tChart1.Page.Current - 1;
        }

        private void cmbBoxDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDays.SelectedItem == null) return;

            string selectedDay = cmbDays.SelectedItem.ToString();
            string dateStr = selectedDay.Split('(')[1].Split(')')[0];


            if (DateTime.TryParseExact(dateStr, "dd/MM", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                string dateKey = parsedDate.ToString("yyyy-MM-dd");

                if (rankDays.ContainsKey(dateKey))
                {
                    double minX = rankDays[dateKey].Item1;
                    double maxX = rankDays[dateKey].Item2;

                    tChart1.Axes.Bottom.SetMinMax(minX, maxX);

                    double globalMinX = tChart1.Series[0].MinXValue();
                    double globalMaxX = tChart1.Series[0].MaxXValue();
                    double totalRange = globalMaxX - globalMinX;

                    double selectedRange = minX - globalMinX;
                    int sliderValue = (int)((selectedRange / totalRange) * scrollBarChart.Maximum);

                    if (sliderValue >= scrollBarChart.Minimum && sliderValue <= scrollBarChart.Maximum)
                    {
                        scrollBarChart.Value = sliderValue;
                    }

                    // FORCE REDRAW AND UPDATE ANNOTATIONS
                    tChart1.Refresh();
                    UpdateAnnotations();
                }
            }
            else
            {
                MessageBox.Show("No data found!");
            }
        }

        private void tChart1_AfterDraw_1(object sender, IGraphics3D g)
        {
            // Removes any previous clipping regions that may have been configured
            tChart1.Graphics3D.ClearClipRegions();

            // Creates a rectangle that respects the horizontal boundaries of the chart (X and Width)
            // but extends from the top of the screen (Y=0) to the bottom of the chart
            Rectangle openTopRect = new Rectangle(
                                    tChart1.Chart.ChartRect.X,
                                    0, tChart1.Chart.ChartRect.Width,
                                    tChart1.Chart.ChartRect.Height +
                                    tChart1.Chart.ChartRect.Y
            );

            // Set this rectangle as the clipping region.
            // Anything drawn outside this region will be clipped (not visible).
            tChart1.Graphics3D.ClipRectangle(openTopRect);

            foreach (Series s in tChart1.Series)
            {
                if (!(s is Bar)) continue;

                Dictionary<string, List<int>> dataGroups = new Dictionary<string, List<int>>();

                for (int i = 0; i < s.Count; i++)
                {
                    string dateKey;

                    // Case 1: Data represents hours (GetAllTemperatures)
                    if (hoursWithDates.ContainsKey(s.XValues[i]))
                    {
                        dateKey = hoursWithDates[s.XValues[i]];
                    }
                    // Case 2: Data represents days (GetAllTemperaturesByDays)
                    else if (daysWithDates.ContainsValue(s.Labels[i]))
                    {
                        dateKey = daysWithDates.FirstOrDefault(x => x.Value == s.Labels[i]).Key.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        continue;
                    }

                    if (!dataGroups.ContainsKey(dateKey))
                        dataGroups[dateKey] = new List<int>();

                    dataGroups[dateKey].Add(i);
                }

                foreach (var group in dataGroups)
                {
                    int p = 0;
                    string dateKey = group.Key;

                    if (!iconsForDay.ContainsKey(dateKey) || iconsForDay[dateKey].Count == 0)
                        continue;

                    foreach (int index in group.Value)
                    {
                        Bitmap objBitmap;
                        if (s.Labels[index].Contains(":"))
                        {
                            int iconIndex = p % iconsForDay[dateKey].Count;
                            objBitmap = LoadBitmapFromUrl(iconsForDay[dateKey][iconIndex]);
                        }
                        else
                        {
                            objBitmap = LoadBitmapFromUrl(iconsForDay[dateKey][0]);
                        }

                        Steema.TeeChart.Drawing.TImage tChartImage = new Steema.TeeChart.Drawing.TImage(objBitmap);

                        int iconWidth = objBitmap.Width;
                        int iconHeight = objBitmap.Height;
                        int xPos = (int)tChart1.Axes.Bottom.CalcPosValue(s.XValues[index]) - (iconWidth / 2);
                        int yPos = (int)tChart1.Axes.Left.CalcPosValue(s.YValues[index]) - (iconHeight / 2);

                        g.Draw(xPos, yPos, tChartImage);

                        string txt = $"{s.YValues[index]}ºC";
                        int textWidth = (int)(g.TextWidth(txt) / 2);
                        int textYPos = yPos + iconHeight + 5;
                        int textXPos = xPos + (iconWidth / 2) - textWidth;

                        g.TextOut(textXPos, textYPos, txt);

                        p++;
                    }
                }
            }

            tChart1.Graphics3D.ClearClipRegions();
        }

        private void tChart1_BeforeDrawSeries(object sender, IGraphics3D g)
        {
            if (tChart1.Series.Count > 0 && tChart1.Series[0] is Bar barSeries)
            {
                // Comprobar que LastVisibleIndex y FirstVisibleIndex están dentro de rango
                int lastIndex = tChart1.Series[0].LastVisibleIndex;
                int firstIndex = tChart1.Series[0].FirstVisibleIndex;

                if (lastIndex >= 0 && firstIndex >= 0 && (lastIndex - firstIndex) > 10)
                {
                    barSeries.CustomBarWidth = 45;
                }
                else
                {
                    barSeries.CustomBarWidth = 0;
                }
            }
        }

        private void suggestionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
