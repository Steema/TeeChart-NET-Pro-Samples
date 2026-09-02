using Steema.TeeChart;
using Steema.TeeChart.Styles;
using Steema.TeeChart.Tools;
using System.Text;

namespace TeeChart.Maui.TEST
{
    public partial class MainPage : ContentPage
    {
        public static readonly string[] SeriesTypes = SeriesDemoCatalog.All.Select(x => x.Id).ToArray();
        private bool updatingProperties;
        private LegendAlignments lastLegendAlignment = LegendAlignments.Bottom;
        private int globalFontSize = 10;
        private string selectedToolType = string.Empty;
        public MainPage()
        {
            InitializeComponent();
            BuildSeriesMenu();
            BuildToolMenu();
            legendAlignmentPicker.ItemsSource = new[] { "None", "Left", "Right", "Top", "Bottom" };
            globalFontSizeStepper.Value = globalFontSize;
            SetupChart("Bar");
            SyncPropertyControls();
        }

        private void BuildSeriesMenu()
        {
            string currentCategory = string.Empty;
            foreach (SeriesDemo demo in SeriesDemoCatalog.All)
            {
                if (!string.Equals(currentCategory, demo.Category, StringComparison.Ordinal))
                {
                    currentCategory = demo.Category;
                    menuItemsLayout.Children.Add(new Label
                    {
                        Text = currentCategory,
                        FontSize = 11,
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.FromArgb("#667085"),
                        Margin = new Thickness(8, menuItemsLayout.Children.Count == 0 ? 8 : 14, 0, 4)
                    });
                }

                var item = new SeriesMenuItem { Text = demo.Name, SeriesType = demo.Id };
                item.Clicked += OnMenuSeriesClicked;
                menuItemsLayout.Children.Add(item);
            }
        }

        private void BuildToolMenu()
        {
            string currentCategory = string.Empty;
            foreach (ToolDemo demo in ToolDemoCatalog.All)
            {
                if (!string.Equals(currentCategory, demo.Category, StringComparison.Ordinal))
                {
                    currentCategory = demo.Category;
                    toolMenuItemsLayout.Children.Add(new Label
                    {
                        Text = currentCategory,
                        FontSize = 11,
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.FromArgb("#667085"),
                        Margin = new Thickness(8, toolMenuItemsLayout.Children.Count == 0 ? 8 : 14, 0, 4)
                    });
                }

                var item = new ToolMenuItem { Text = demo.Name, ToolType = demo.Id };
                item.Clicked += OnMenuToolClicked;
                toolMenuItemsLayout.Children.Add(item);
            }
        }

        private void OnToggleSeriesMenu(object sender, EventArgs e)
        {
            bool visible = sideMenuPanel.IsVisible;
            sideMenuPanel.IsVisible = !visible;
            sideMenuColumn.Width = visible ? new GridLength(0) : new GridLength(285);
            openMenuButton.IsVisible = visible;
            chart1.InvalidateMeasure();
            chart1.InvalidateChart();
        }

        private void OnChartSizeChanged(object sender, EventArgs e)
        {
            if (chart1.Width > 0 && chart1.Height > 0)
                chart1.InvalidateChart();
        }

        private void OnMenuSeriesClicked(object sender, EventArgs e)
        {
            if (sender is not SeriesMenuItem item || string.IsNullOrWhiteSpace(item.SeriesType))
                return;

            SetupChart(item.SeriesType);
        }

        private void OnMenuToolClicked(object sender, EventArgs e)
        {
            if (sender is ToolMenuItem item && !string.IsNullOrWhiteSpace(item.ToolType))
                SetupTool(item.ToolType);
        }

        private void UpdateSelectedSeriesMenu(string seriesType)
        {
            foreach (var child in menuItemsLayout.Children)
            {
                if (child is not SeriesMenuItem item)
                    continue;

                item.IsSelected = string.Equals(item.SeriesType, seriesType, StringComparison.Ordinal);
            }
        }

        private void UpdateSelectedToolMenu(string toolType)
        {
            selectedToolType = toolType ?? string.Empty;
            foreach (var child in toolMenuItemsLayout.Children)
            {
                if (child is ToolMenuItem item)
                    item.IsSelected = string.Equals(item.ToolType, selectedToolType, StringComparison.Ordinal);
            }
        }

        private void SetupTool(string toolType)
        {
            ToolDemo? demo = ToolDemoCatalog.Find(toolType);
            if (demo is null)
                return;

            SetupChart(demo.SeriesType);
            UpdateSelectedToolMenu(toolType);
            UpdateSelectedSeriesMenu(string.Empty);

            // GanttTool owns the gesture while a bar is dragged. Disable the
            // chart-level navigation modes for this demo so a finger drag is
            // not consumed by zoom/panning before the tool can update the bar.
            if (demo.TypeName == "GanttTool")
            {
                chart1.TouchZoomEnabled = false;
                chart1.Chart.Zoom.Active = false;
                chart1.Chart.Zoom.Allow = false;
                chart1.Chart.Panning.Active = false;
                chart1.Chart.Panning.Allow = ScrollModes.None;
            }
            else if (demo.TypeName == "Rotate")
            {
                // RotateTool owns the horizontal and vertical drag.  Do not
                // let chart-level navigation consume the same touch gesture.
                chart1.TouchZoomEnabled = false;
                chart1.Chart.Zoom.Active = false;
                chart1.Chart.Zoom.Allow = false;
                chart1.Chart.Panning.Active = false;
                chart1.Chart.Panning.Allow = ScrollModes.None;
            }

            Tool? tool = CreateTool(demo);
            chartTitleLabel.Text = $"Tool · {demo.Name}";
            chartSubtitleLabel.Text = tool is null
                ? $"{demo.Description} (no disponible en este target)"
                : $"{demo.Description} · Serie recomendada: {demo.SeriesType}";
            chart1.Chart.Header.Text = $"TeeChart MAUI - Tool: {demo.Name}";
            chart1.Chart.Header.Visible = true;
            chart1.InvalidateChart();
        }

        private Tool? CreateTool(ToolDemo demo)
        {
            try
            {
                Type? toolType = typeof(Chart).Assembly.GetType($"Steema.TeeChart.Tools.{demo.TypeName}");
                if (toolType is null)
                    return null;

                if (Activator.CreateInstance(toolType, chart1.Chart) is not Tool tool)
                    return null;

                Steema.TeeChart.Styles.Series? series = chart1.Chart.Series.Count > 0
                    ? chart1.Chart.Series[0] : null;
                if (tool is ToolSeries toolSeries)
                    toolSeries.Series = series;
                if (tool is GanttTool ganttTool && series is Gantt gantt)
                    ganttTool.Gantt = gantt;
                if (tool is ToolAxis toolAxis)
                    toolAxis.Axis = chart1.Chart.Axes.Left;

                ConfigureTool(tool, demo);
                ConfigureTouchTool(tool, demo);
                return tool;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Unable to create TeeChart tool {demo.TypeName}: {ex}");
                return null;
            }
        }

        private static void ConfigureTool(Tool tool, ToolDemo demo)
        {
            SetToolProperty(tool, "Active", true);
            SetToolProperty(tool, "Text", demo.Description);
            SetToolProperty(tool, "AllowDrag", true);
            SetToolProperty(tool, "DrawHandles", true);
            SetToolProperty(tool, "FastCursor", true);
            SetToolProperty(tool, "Steps", 32);
            SetToolProperty(tool, "DrawEvery", 1);
            SetToolProperty(tool, "Speed", 35);

            if (demo.TypeName is "Annotation" or "BannerTool")
            {
                SetToolProperty(tool, "Text", demo.Name + " · " + demo.Description);
                SetToolProperty(tool, "Position", "RightTop");
            }
            else if (demo.TypeName == "PageNumber")
            {
                SetToolProperty(tool, "Text", "Página 1");
            }
            else if (demo.TypeName == "ColorBand")
            {
                SetToolProperty(tool, "Start", 1500d);
                SetToolProperty(tool, "End", 2100d);
                SetToolProperty(tool, "Color", System.Drawing.Color.FromArgb(50, 80, 140, 220));
            }
            else if (demo.TypeName == "SeriesBandTool")
            {
                SetToolProperty(tool, "BoundValue", 1800d);
            }
            else if (demo.TypeName == "SeriesAnimation")
            {
                SetToolProperty(tool, "StartValue", 0d);
            }
            else if (demo.TypeName == "MarksTip")
            {
                SetToolProperty(tool, "Text", "Valor: {value}");
            }
        }

        private void ConfigureTouchTool(Tool tool, ToolDemo demo)
        {
            // TChart translates a single-finger gesture to a left-button
            // mouse event on every MAUI platform. Explicitly selecting the
            // same button keeps tool demos consistent with touch input.
            var leftButton = Steema.TeeChart.Drawing.MouseButtons.Left;
            SetToolProperty(tool, "Button", leftButton);
            SetToolProperty(tool, "MouseButton", leftButton);

            if (demo.TypeName == "Rotate")
            {
                chart1.Chart.Aspect.View3D = true;
                chart1.Chart.Aspect.Orthogonal = false;
                SetToolProperty(tool, "Inverted", false);
            }
            else if (demo.TypeName == "DragPoint")
            {
                SetToolProperty(tool, "Style", "Both");
                if (chart1.Chart.Series.Count > 0)
                {
                    var series = chart1.Chart.Series[0];
                    var pointer = series.GetType().GetProperty("Pointer")?.GetValue(series);
                    if (pointer is not null)
                        SetToolProperty(pointer, "Visible", true);
                }
            }
            else if (demo.TypeName == "GanttTool")
            {
                SetToolProperty(tool, "AllowDrag", true);
                SetToolProperty(tool, "AllowResize", true);
            }
        }

        private static void SetToolProperty(object target, string name, object value)
        {
            var property = target.GetType().GetProperty(name);
            if (property?.CanWrite != true || value is null)
                return;

            try
            {
                if (property.PropertyType.IsInstanceOfType(value))
                    property.SetValue(target, value);
                else if (property.PropertyType.IsEnum)
                    property.SetValue(target, Enum.Parse(property.PropertyType, value.ToString()!, true));
                else
                    property.SetValue(target, Convert.ChangeType(value, property.PropertyType));
            }
            catch
            {
                // Tool options vary slightly between TeeChart targets.
            }
        }

        private void OnToggleProperties(object sender, EventArgs e)
        {
            propertiesPanel.IsVisible = !propertiesPanel.IsVisible;
            togglePropertiesButton.Text = propertiesPanel.IsVisible
                ? "Ocultar opciones" : "⚙ Opciones";
            if (propertiesPanel.IsVisible) SyncPropertyControls();
        }

        private void SyncPropertyControls()
        {
            updatingProperties = true;
            view3DSwitch.IsToggled = chart1.Chart.Aspect.View3D;
            clipPointsSwitch.IsToggled = chart1.Chart.Aspect.ClipPoints;
            touchZoomSwitch.IsToggled = chart1.TouchZoomEnabled;
            axesVisibleSwitch.IsToggled = chart1.Chart.Axes.Visible;
            wallsVisibleSwitch.IsToggled = chart1.Chart.Walls.Visible;
            leftGridVisibleSwitch.IsToggled = chart1.Chart.Axes.Left.Grid.Visible;
            colorEachSwitch.IsToggled = chart1.Chart.Series.Count > 0 && chart1.Chart.Series[0].ColorEach;
            marksVisibleSwitch.IsToggled = chart1.Chart.Series.Count > 0 && chart1.Chart.Series[0].Marks.Visible;
            legendVisibleSwitch.IsToggled = chart1.Chart.Legend.Visible;
            legendAlignmentPicker.SelectedIndex = chart1.Chart.Legend.Visible
                ? chart1.Chart.Legend.Alignment switch
                {
                    LegendAlignments.Left => 1,
                    LegendAlignments.Right => 2,
                    LegendAlignments.Top => 3,
                    _ => 4
                }
                : 0;
            globalFontSizeStepper.Value = globalFontSize;
            globalFontSizeLabel.Text = $"{globalFontSize} pt";
            panelColorLabel.Text = chart1.Chart.Panel.Color.ToString();
            updatingProperties = false;
        }

        private void OnView3DToggled(object sender, ToggledEventArgs e)
        {
            if (updatingProperties) return;
            chart1.Chart.Aspect.View3D = e.Value;
            chart1.InvalidateChart();
        }

        private void OnClipPointsToggled(object sender, ToggledEventArgs e)
        {
            if (updatingProperties) return;
            chart1.Chart.Aspect.ClipPoints = e.Value;
            chart1.InvalidateChart();
        }

        private void OnTouchZoomToggled(object sender, ToggledEventArgs e)
        {
            if (updatingProperties) return;

            // A touch drag pans by default. With this switch enabled the
            // same gesture is routed to TeeChart's rectangular zoom engine.
            chart1.TouchZoomEnabled = e.Value;
            chart1.InvalidateChart();
        }

        private void OnAxesVisibleToggled(object sender, ToggledEventArgs e)
        {
            if (updatingProperties) return;
            chart1.Chart.Axes.Visible = e.Value;
            chart1.InvalidateChart();
        }

        private void OnWallsVisibleToggled(object sender, ToggledEventArgs e)
        {
            if (updatingProperties) return;
            chart1.Chart.Walls.Visible = e.Value;
            chart1.InvalidateChart();
        }

        private void OnLeftGridVisibleToggled(object sender, ToggledEventArgs e)
        {
            if (updatingProperties) return;
            chart1.Chart.Axes.Left.Grid.Visible = e.Value;
            chart1.InvalidateChart();
        }

        private void OnColorEachToggled(object sender, ToggledEventArgs e)
        {
            if (updatingProperties) return;
            foreach (Steema.TeeChart.Styles.Series series in chart1.Chart.Series)
                series.ColorEach = e.Value;
            chart1.InvalidateChart();
        }

        private void OnMarksVisibleToggled(object sender, ToggledEventArgs e)
        {
            if (updatingProperties) return;
            foreach (Steema.TeeChart.Styles.Series series in chart1.Chart.Series)
                series.Marks.Visible = e.Value;
            chart1.InvalidateChart();
        }

        private void OnLegendVisibleToggled(object sender, ToggledEventArgs e)
        {
            if (updatingProperties) return;
            chart1.Chart.Legend.Visible = e.Value;
            if (e.Value)
                chart1.Chart.Legend.Alignment = lastLegendAlignment;

            updatingProperties = true;
            legendAlignmentPicker.SelectedIndex = e.Value
                ? lastLegendAlignment switch
                {
                    LegendAlignments.Left => 1,
                    LegendAlignments.Right => 2,
                    LegendAlignments.Top => 3,
                    _ => 4
                }
                : 0;
            updatingProperties = false;
            chart1.InvalidateChart();
        }

        private void OnLegendAlignmentChanged(object sender, EventArgs e)
        {
            if (updatingProperties || legendAlignmentPicker.SelectedIndex < 0) return;

            if (legendAlignmentPicker.SelectedIndex == 0)
            {
                chart1.Chart.Legend.Visible = false;
            }
            else
            {
                lastLegendAlignment = legendAlignmentPicker.SelectedIndex switch
                {
                    1 => LegendAlignments.Left,
                    2 => LegendAlignments.Right,
                    3 => LegendAlignments.Top,
                    _ => LegendAlignments.Bottom
                };
                chart1.Chart.Legend.Alignment = lastLegendAlignment;
                chart1.Chart.Legend.Visible = true;
            }

            updatingProperties = true;
            legendVisibleSwitch.IsToggled = chart1.Chart.Legend.Visible;
            updatingProperties = false;
            chart1.InvalidateChart();
        }

        private void OnGlobalFontSizeChanged(object sender, ValueChangedEventArgs e)
        {
            if (updatingProperties) return;
            globalFontSize = System.Math.Clamp((int)System.Math.Round(e.NewValue), 6, 24);
            ApplyGlobalFontSize();
            globalFontSizeLabel.Text = $"{globalFontSize} pt";
            chart1.InvalidateChart();
        }

        private void ApplyGlobalFontSize()
        {
            int size = globalFontSize;

            chart1.Chart.Header.Font.Size = size + 4;
            chart1.Chart.SubHeader.Font.Size = size + 1;
            chart1.Chart.Footer.Font.Size = size;
            chart1.Chart.SubFooter.Font.Size = size;
            chart1.Chart.Legend.Font.Size = size;
            chart1.Chart.Legend.Title.Font.Size = size + 1;

            for (int i = 0; i < chart1.Chart.Axes.Count; i++)
            {
                Axis axis = chart1.Chart.Axes[i];
                if (axis == null) continue;
                axis.Labels.Font.Size = size;
                axis.Title.Font.Size = size;

                foreach (AxisLabelItem item in axis.Labels.Items)
                    item.Font.Size = size;
            }

            foreach (Steema.TeeChart.Styles.Series series in chart1.Chart.Series)
                series.Marks.Font.Size = size;
        }

        private void OnWhitePanel(object sender, EventArgs e) => SetPanelColor(System.Drawing.Color.White);
        private void OnLightBluePanel(object sender, EventArgs e) => SetPanelColor(System.Drawing.Color.LightBlue);

        private void SetPanelColor(System.Drawing.Color color)
        {
            chart1.Chart.Panel.Color = color;
            panelColorLabel.Text = color.ToString();
            chart1.InvalidateChart();
        }

        private void SetupChart(string seriesType)
        {
            chart1.ResetChart();
            UpdateSelectedSeriesMenu(seriesType);
            UpdateSelectedToolMenu(string.Empty);
            var values = new[] { 1250, 1580, 2100, 1890, 2340, 2580 };
            var labels = new[] { "Ene", "Feb", "Mar", "Abr", "May", "Jun" };
            Steema.TeeChart.Styles.Series series = seriesType switch
            {
                "Line" => new Line(chart1.Chart),
                "Pie" => new Pie(chart1.Chart),
                "Area" => new Area(chart1.Chart),
                "FastLine" => new FastLine(chart1.Chart),
                "Point" => new Points(chart1.Chart),
                "HorizontalBar" => new HorizBar(chart1.Chart),
                "Candle" => new Candle(chart1.Chart),
                "Donut" => new Donut(chart1.Chart),
                "HorizontalArea" => new HorizArea(chart1.Chart),
                "Bar3D" => new Bar3D(chart1.Chart),
                "Bubble" => new Bubble(chart1.Chart),
                "Histogram" => new Histogram(chart1.Chart),
                "Volume" => new Volume(chart1.Chart),
                "Radar" => new Radar(chart1.Chart),
                "Polar" => new Polar(chart1.Chart),
                "HighLow" => new HighLow(chart1.Chart),
                "Error" => new Error(chart1.Chart),
                "Gantt" => new Gantt(chart1.Chart),
                "BarJoin" => new BarJoin(chart1.Chart),
                "Equalizer" => new Equalizer(chart1.Chart),
                "HorizontalHistogram" => new HorizHistogram(chart1.Chart),
                "HorizontalLine" => new HorizLine(chart1.Chart),
                "LinePoint" => new LinePoint(chart1.Chart),
                "Points3D" => new Points3D(chart1.Chart),
                "Tornado" => new Tornado(chart1.Chart),
                "ImageBar" => new ImageBar(chart1.Chart),
                "Vector3D" => new Vector3D(chart1.Chart),
                _ => CreateCatalogSeries(seriesType)
            };
            if (series is CircularGauge circularGauge)
            {
                ConfigureCircularGaugeDemo(circularGauge);
            }
            else if (series is ActivityGauge activityGauge)
            {
                ConfigureActivityGaugeDemo(activityGauge);
            }
            else if (series is EquiVolume equiVolume)
            {
                DateTime firstDay = DateTime.Today.AddDays(-23);
                double close = 102.0;
                for (int i = 0; i < 24; i++)
                {
                    double open = close;
                    double drift = (i % 5 == 0 ? 2.4 : 0.9) * (i % 3 == 0 ? -1 : 1);
                    close = open + drift;
                    double high = System.Math.Max(open, close) + 1.8 + (i % 4) * 0.35;
                    double low = System.Math.Min(open, close) - 1.4 - (i % 3) * 0.25;
                    double volume = 380 + ((i * 97) % 620) + (i % 6 == 0 ? 420 : 0);
                    equiVolume.Add(firstDay.AddDays(i), volume, open, high, low, close);
                }

                equiVolume.BoxFillStyle = EquiVolume.BoxFillType.FillToClose;
                equiVolume.PointGap = 2;
                equiVolume.VolumePointer.Visible = false;
                equiVolume.Marks.Visible = false;
                equiVolume.Pen.Visible = true;
                equiVolume.Pen.Width = 1;
                equiVolume.CalcUnitSize(equiVolume.XValues.Minimum, equiVolume.XValues.Maximum);
            }
            else if (series is Tornado tornado)
            {
                string[] factors =
                    { "Precio", "Disponibilidad", "Entrega", "Calidad", "Soporte", "Marca" };
                double[] leftImpact = { 18, 24, 31, 28, 21, 16 };
                double[] rightImpact = { 86, 74, 68, 63, 57, 49 };

                for (int i = 0; i < factors.Length; i++)
                    tornado.Add(leftImpact[i], rightImpact[i], factors[i]);

                tornado.ColorEach = false;
                tornado.LeftColor = System.Drawing.Color.FromArgb(79, 129, 189);
                tornado.Color = System.Drawing.Color.FromArgb(244, 185, 66);
                tornado.Pen.Visible = true;
                tornado.Pen.Width = 1;
                tornado.Pen.Color = System.Drawing.Color.FromArgb(61, 72, 91);
                tornado.SortBy = TornadoSortBy.Sum;
                tornado.SortOrder = ValueListOrder.Descending;
                tornado.Marks.Visible = true;
            }
            else if (series is CustomViolin violin)
            {
                ConfigureViolinDemo(violin, series is HorizViolin);
            }
            else if (series is Steema.TeeChart.Styles.Pyramid pyramid)
            {
                string[] funnelStages =
                    { "Visitas", "Interés", "Evaluación", "Propuesta", "Clientes" };
                double[] stageVolumes = { 4200, 2850, 1760, 940, 510 };
                for (int i = 0; i < stageVolumes.Length; i++)
                    pyramid.Add(stageVolumes[i], funnelStages[i]);

                pyramid.SizePercent = 72;
                pyramid.ColorEach = true;
                pyramid.Pen.Visible = true;
                pyramid.Pen.Width = 1;
                pyramid.Pen.Color = System.Drawing.Color.FromArgb(62, 73, 92);
            }
            else if (series is Steema.TeeChart.Styles.Arrow arrow)
            {
                // Flujo mensual de demanda: cada vector parte del valor previsto y
                // termina en la revisión del mes siguiente.
                double[] revisedValues = { 3320, 3710, 3540, 4210, 4480, 4740 };
                for (int i = 0; i < values.Length; i++)
                    arrow.Add(i, values[i], i + 0.72, revisedValues[i], labels[i]);

                arrow.ArrowWidth = 14;
                arrow.ArrowHeight = 20;
                arrow.Pointer.Pen.Visible = true;
                arrow.Pointer.Pen.Width = 2;
                arrow.Pointer.Brush.Visible = true;
            }
            else if (series is Candle candle)
            {
                var date = DateTime.Today.AddDays(-23);
                double close = 1250;
                for (int i = 0; i < 24; i++)
                {
                    double open = close;
                    close = open + ((i % 4 == 0 ? 145 : 82) * (i % 3 == 0 ? -1 : 1));
                    candle.Add(date.AddDays(i), open, System.Math.Max(open, close) + 140,
                        System.Math.Min(open, close) - 110, close);
                }
            }
            else if (series is Equalizer equalizer)
            {
                for (int i = 0; i < 18; i++)
                {
                    double value = 420 + (i * 47) + ((i % 4) * 115);
                    equalizer.Add(i, value);
                }
            }
            else if (series is Volume volume)
            {
                for (int i = 0; i < 24; i++)
                {
                    double value = 260 + ((i * 83) % 520) + (i % 5 == 0 ? 300 : 0);
                    volume.Add(i, value);
                }
            }
            else if (series is Bubble bubble)
            {
                for (int i = 0; i < values.Length; i++)
                    bubble.Add(i, values[i], 10 + i * 3, labels[i]);
            }
            else if (series is HighLow highLow)
            {
                for (int i = 0; i < values.Length; i++)
                    highLow.Add(i, values[i] + 220, values[i] - 180, labels[i]);
            }
            else if (series is Error error)
            {
                for (int i = 0; i < values.Length; i++)
                    error.Add(i, values[i], 120 + i * 15, labels[i]);
            }
            else if (series is Gantt gantt)
            {
                DateTime start = DateTime.Today;
                for (int i = 0; i < values.Length; i++)
                    gantt.Add(start.AddDays(i * 2), start.AddDays(i * 2 + 3), i, labels[i]);
            }
            else if (series is Polar polar)
            {
                for (int i = 0; i < values.Length; i++)
                    polar.Add(i * 60, values[i], labels[i]);
            }
            else if (series is Radar radar)
            {
                for (int i = 0; i < values.Length; i++)
                    radar.Add(i * 60, values[i], labels[i]);
            }
            else if (series is Vector3D vector3D)
            {
                for (int i = 0; i < values.Length - 1; i++)
                    vector3D.Add(i, values[i] / 100.0, i * 2,
                        i + 1, values[i + 1] / 100.0, (i + 1) * 2);
            }
            else if (IsNativeSampleSeries(seriesType))
            {
                series.FillSampleValues(GetNativeSampleCount(seriesType));
            }
            else
                for (int i = 0; i < values.Length; i++) series.Add(values[i], labels[i]);

            if (series is Circular circular)
                circular.Circled = true;

            series.Title = SeriesDemoCatalog.Find(seriesType)?.Name ?? seriesType;

            chart1.Chart.Header.Text = $"TeeChart MAUI - {GetScenarioTitle(seriesType)}";
            chart1.Chart.Header.Visible = true;
            chartTitleLabel.Text = GetScenarioTitle(seriesType);
            chartSubtitleLabel.Text = GetScenarioSubtitle(seriesType);

            bool isViolinDemo = series is CustomViolin;
            bool isTornadoDemo = series is Tornado;
            bool isGaugeDemo = series is CircularGauge or ActivityGauge;
            bool is3DDemo = Is3DDemo(seriesType);
            chart1.Chart.Aspect.View3D = is3DDemo;
            if (!isViolinDemo && !isTornadoDemo)
                series.Color = System.Drawing.Color.FromArgb(79, 129, 189);
            bool isOrganizationDemoWithoutGantt = seriesType is
                "Calendar" or "OrgSeries" or "TreeMap" or "SquarifiedMap" or "Sankey" or "TagCloud";
            bool hideDemoMarks = isViolinDemo || isGaugeDemo || is3DDemo ||
                seriesType is "Pie" or "Donut" or "PolarGrid" or "EquiVolume"
                || isOrganizationDemoWithoutGantt;
            series.Marks.Visible = !hideDemoMarks;

            chart1.Chart.Axes.Left.Title.Text = "Ventas ($)";
            chart1.Chart.Axes.Bottom.Title.Text = "Mes";
            // Keep category labels horizontal in every gallery sample. This
            // avoids clipped labels on narrow MAUI windows.
            chart1.Chart.Axes.Bottom.Labels.Angle = 0;
            chart1.Chart.Axes.Left.Grid.Visible = true;
            chart1.Chart.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(185, 195, 210);
            chart1.Chart.Axes.Left.Grid.Width = 1;
            chart1.Chart.Axes.Left.Grid.Style = Steema.TeeChart.Drawing.DashStyle.Dot;

            chart1.Chart.Legend.Visible = !isViolinDemo && !isGaugeDemo;
            chart1.Chart.Legend.Alignment = LegendAlignments.Bottom;
            lastLegendAlignment = chart1.Chart.Legend.Alignment;
            chart1.Chart.Legend.Transparent = false;
            chart1.Chart.Legend.Color = System.Drawing.Color.White;
            chart1.Chart.Legend.BorderRound = 8;
            chart1.Chart.Legend.Pen.Visible = true;
            chart1.Chart.Legend.Pen.Color = System.Drawing.Color.FromArgb(176, 188, 204);
            chart1.Chart.Legend.Pen.Width = 1;
            chart1.Chart.Legend.Pen.Style = Steema.TeeChart.Drawing.DashStyle.Solid;
            chart1.Chart.Legend.Symbol.DefaultPen = false;
            chart1.Chart.Legend.Symbol.Pen.Visible = true;
            chart1.Chart.Legend.Symbol.Pen.Color = System.Drawing.Color.FromArgb(70, 82, 99);
            chart1.Chart.Legend.Symbol.Pen.Width = 1;
            chart1.Chart.Legend.Symbol.Pen.Style = Steema.TeeChart.Drawing.DashStyle.Solid;
            chart1.Chart.Legend.Font.Color = System.Drawing.Color.FromArgb(52, 64, 84);

            if (isViolinDemo)
                ConfigureViolinAxes(series is HorizViolin);
            else if (isTornadoDemo)
            {
                chart1.Chart.Axes.Left.Title.Text = "Factor de decisión";
                chart1.Chart.Axes.Bottom.Title.Text = "Impacto relativo (%)";
            }

            ApplyGlobalFontSize();

            chart1.InvalidateChart();
            codeLabel.Text = BuildChartCode(seriesType, series);
            SyncPropertyControls();
        }

        private string BuildChartCode(string seriesType,
            Steema.TeeChart.Styles.Series series)
        {
            var code = new StringBuilder();
            string className = series.GetType().Name;
            code.AppendLine("// TeeChart MAUI · configuración esencial");
            code.AppendLine("var chart = new TChart();");
            code.AppendLine("chart.Chart.Series.RemoveAllSeries();");
            code.AppendLine($"var series = new {className}(chart.Chart);");

            if (series is CircularGauge gauge)
            {
                code.AppendLine("series.Minimum = 0;");
                code.AppendLine("series.Maximum = 100;");
                code.AppendLine($"series.Value = {gauge.Value:0.##};");
                code.AppendLine("series.TotalAngle = 360;");
                code.AppendLine("series.Axis.Labels.Visible = true;");
            }
            else if (series is ActivityGauge activityGauge)
            {
                double activityValue = activityGauge.Count > 0 ? activityGauge.YValues[0] : 68;
                code.AppendLine($"series.Add({activityValue:0.##});");
                code.AppendLine("series.TotalAngle = 360;");
            }
            else
            {
                code.AppendLine("series.FillSampleValues();");
            }

            code.AppendLine("series.Marks.Visible = " + series.Marks.Visible.ToString().ToLowerInvariant() + ";");
            code.AppendLine("series.ColorEach = " + series.ColorEach.ToString().ToLowerInvariant() + ";");
            var pen = series.GetType().GetProperty("Pen")?.GetValue(series)
                as Steema.TeeChart.Drawing.IChartPen;
            code.AppendLine("series.Pen.Visible = " + (pen?.Visible ?? true).ToString().ToLowerInvariant() + ";");
            code.AppendLine("chart.Chart.Axes.Bottom.Labels.Angle = 0;");
            code.AppendLine("chart.Chart.Axes.Left.Grid.Visible = true;");
            code.AppendLine("chart.Chart.Aspect.ClipPoints = " + chart1.Chart.Aspect.ClipPoints.ToString().ToLowerInvariant() + ";");
            code.AppendLine("chart.Chart.Legend.Visible = " + chart1.Chart.Legend.Visible.ToString().ToLowerInvariant() + ";");
            code.AppendLine("chart.Chart.Header.Visible = true;");
            code.AppendLine("chart.TouchZoomEnabled = " + chart1.TouchZoomEnabled.ToString().ToLowerInvariant() + ";");
            code.AppendLine("chart.InvalidateChart();");
            return code.ToString();
        }

        private void OnChartTabClicked(object sender, EventArgs e) => ShowChartTab(true);

        private void OnCodeTabClicked(object sender, EventArgs e) => ShowChartTab(false);

        private void ShowChartTab(bool showChart)
        {
            chartTabContent.IsVisible = showChart;
            codeTabContent.IsVisible = !showChart;
            chartTabButton.BackgroundColor = showChart
                ? Color.FromArgb("#E8F0FF") : Colors.Transparent;
            chartTabButton.TextColor = showChart
                ? Color.FromArgb("#1D4ED8") : Color.FromArgb("#667085");
            codeTabButton.BackgroundColor = showChart
                ? Colors.Transparent : Color.FromArgb("#E8F0FF");
            codeTabButton.TextColor = showChart
                ? Color.FromArgb("#667085") : Color.FromArgb("#1D4ED8");
        }

        private static void ConfigureCircularGaugeDemo(CircularGauge gauge)
        {
            // Gauges are value-driven series. FillSampleValues() is intended
            // for point series and leaves the gauge without a stable hand or
            // useful scale on MAUI.
            gauge.Minimum = 0;
            gauge.Maximum = 100;
            gauge.Value = 74;
            // Use a complete circular gauge in the MAUI gallery.  A value
            // below 360 intentionally paints the complementary sector as a
            // wedge (useful for semi-circular gauges, but misleading here).
            gauge.TotalAngle = 360;
            gauge.RotationAngle = 0;
            gauge.DisplayTotalAngle = 360;
            gauge.DisplayRotationAngle = 0;
            gauge.Frame.TotalAngle = 360;
            gauge.Frame.RotationAngle = 0;
            gauge.Axis.Visible = true;
            gauge.Axis.Labels.Visible = true;
            gauge.Axis.Increment = 10;
            gauge.Ticks.Visible = true;
            gauge.RotateLabels = false;
            gauge.Marks.Visible = false;
            gauge.Legend.Visible = false;
            gauge.Frame.Visible = true;
            gauge.Hand.Visible = true;
            gauge.Hand.Pen.Visible = true;
            gauge.Hand.Brush.Visible = true;
            gauge.Hand.Pen.Width = 2;
            gauge.Center.Visible = true;
            gauge.Center.VertSize = 6;
            gauge.Center.HorizSize = 6;
            gauge.FaceBrush.Visible = true;
        }

        private static void ConfigureActivityGaugeDemo(ActivityGauge gauge)
        {
            // ActivityGauge builds its background ring internally from Add().
            // Adding ordinary sample values creates invalid donut indexes and
            // is the reason this demo used to appear empty or throw.
            gauge.Clear();
            gauge.BackColor = System.Drawing.Color.FromArgb(235, 240, 247);
            gauge.Add(68);
            gauge.TotalAngle = 360;
            gauge.CenterText.Text = "68%";
            gauge.CenterText.Shape.Visible = true;
            gauge.CenterText.Shape.Transparent = true;
            gauge.CenterText.Shape.Font.Size = 18;
            gauge.CenterText.Shape.Font.Bold = true;
            gauge.CenterText.Shape.Font.Color = System.Drawing.Color.FromArgb(39, 58, 86);
            gauge.Legend.Visible = false;
            gauge.Marks.Visible = false;
        }

        private void ConfigureViolinDemo(CustomViolin primary, bool horizontal)
        {
            string[] channels = { "Chat", "Web", "Teléfono" };
            System.Drawing.Color[] colors =
            {
                System.Drawing.Color.FromArgb(54, 162, 154),
                System.Drawing.Color.FromArgb(74, 118, 210),
                System.Drawing.Color.FromArgb(236, 146, 68)
            };
            double[][] samples =
            {
                new double[] { 7, 8, 8, 9, 9, 10, 10, 10, 11, 11, 11, 12, 12, 12,
                    13, 13, 13, 14, 14, 15, 15, 16, 17, 18, 19, 21, 23, 26 },
                new double[] { 10, 11, 12, 13, 14, 14, 15, 16, 16, 17, 18, 18, 19, 20,
                    20, 21, 22, 23, 24, 25, 27, 29, 31, 34, 37, 41, 46, 52 },
                new double[] { 15, 17, 18, 20, 21, 22, 24, 25, 27, 28, 29, 30, 31, 32,
                    33, 34, 35, 37, 39, 41, 44, 47, 51, 55, 59, 64, 70, 78 }
            };

            for (int group = 0; group < samples.Length; group++)
            {
                var violin = group == 0
                    ? primary
                    : (CustomViolin)Steema.TeeChart.Styles.Series.CreateNewSeries(
                        chart1.Chart, horizontal ? typeof(HorizViolin) : typeof(Violin), null, 0);

                violin.Position = group + 1;
                violin.Title = channels[group];
                violin.Color = colors[group];
                violin.KDE.Options.Resolution = 140;
                violin.KDE.Options.Bandwidth = 7;
                violin.KDE.Scale = 6.2;
                violin.Pointer.Visible = false;
                violin.Marks.Visible = false;
                violin.Legend.Visible = false;
                violin.LinePen.Visible = true;
                violin.LinePen.Width = 2;
                violin.LinePen.Color = System.Drawing.Color.FromArgb(
                    220,
                    System.Math.Max(0, colors[group].R - 38),
                    System.Math.Max(0, colors[group].G - 38),
                    System.Math.Max(0, colors[group].B - 38));

                foreach (double sample in samples[group])
                    violin.Add(sample);

                violin.Update(horizontal ? violin.XValues : violin.YValues);
            }
        }

        private void ConfigureViolinAxes(bool horizontal)
        {
            Axis categoryAxis = horizontal ? chart1.Chart.Axes.Left : chart1.Chart.Axes.Bottom;
            Axis valueAxis = horizontal ? chart1.Chart.Axes.Bottom : chart1.Chart.Axes.Left;

            categoryAxis.Labels.Items.Clear();
            categoryAxis.Labels.Items.Add(1, "Chat");
            categoryAxis.Labels.Items.Add(2, "Web");
            categoryAxis.Labels.Items.Add(3, "Teléfono");
            categoryAxis.Labels.Angle = 0;
            categoryAxis.Increment = 1;
            categoryAxis.Grid.Visible = false;
            categoryAxis.Title.Text = "Canal de soporte";

            valueAxis.Title.Text = "Tiempo de resolución (min)";
            valueAxis.Grid.Visible = true;

            chart1.Chart.Legend.Visible = false;
            foreach (Steema.TeeChart.Styles.Series item in chart1.Chart.Series)
            {
                item.Marks.Visible = false;
                item.Legend.Visible = false;
            }
        }

        private Steema.TeeChart.Styles.Series CreateCatalogSeries(string seriesType)
        {
            SeriesDemo demo = SeriesDemoCatalog.Find(seriesType)
                ?? throw new InvalidOperationException($"Tipo de serie no registrado: {seriesType}");

            return Steema.TeeChart.Styles.Series.CreateNewSeries(
                chart1.Chart, demo.SeriesType, null, 0);
        }

        private static bool Is3DDemo(string seriesType) => seriesType is
            "Bar3D" or "Points3D" or "Vector3D" or "Surface" or "Contour" or
            "ColorGrid" or "Tower" or "TriSurface" or "IsoSurface" or
            "Map" or "World" or "Waterfall" or "VolumePipe" or "ErrorPoint3D";

        private static bool IsNativeSampleSeries(string seriesType) => seriesType is
            "ActivityGauge" or "Arrow" or "Bezier" or "BubbleCloud" or "Calendar" or
            "Box" or "HorizBox" or "Violin" or "HorizViolin" or "BeeSwarm" or "HorizBeeSwarm" or
            "CircularGauge" or "Clock" or "ClockGauge" or "ColorGrid" or "Contour" or
            "Darvas" or "EquiVolume" or "ErrorBar" or "ErrorPoint" or "ErrorPoint3D" or
            "Funnel" or "Gauges" or "ImagePoint" or "IsoSurface" or "Kagi" or "KnobGauge" or
            "LinearGauge" or "VerticalLinearGauge" or "Map" or "NumericGauge" or "OrgSeries" or
            "PointFigure" or "PolarBar" or "Rose" or "PolarGrid" or "Pyramid" or "Renko" or
            "RenkoBar" or "Sankey" or "Shape" or "Slope" or "Smith" or "SquarifiedMap" or
            "Surface" or "TagCloud" or "Ternary" or "Tower" or "TreeMap" or "TriSurface" or
            "VolumePipe" or "Waterfall" or "WindRose" or "World";

        private static int GetNativeSampleCount(string seriesType) => seriesType switch
        {
            "Candle" or "Equalizer" or "Volume" or "Renko" or "RenkoBar" => 24,
            "Surface" or "Contour" or "ColorGrid" or "Tower" or "Waterfall" or "IsoSurface" => 12,
            "TagCloud" or "BubbleCloud" or "BeeSwarm" or "HorizBeeSwarm" => 18,
            "Calendar" or "Clock" or "ClockGauge" or "NumericGauge" => 1,
            _ => 8
        };

        private static string GetScenarioTitle(string seriesType) => seriesType switch
        {
            "Violin" or "HorizViolin" => "Tiempos de resolución por canal",
            "Tornado" => "Factores que impulsan la compra",
            "Candle" or "HighLow" or "Volume" => "Evolución del mercado",
            "Gantt" => "Planificación de proyecto",
            "Bubble" => "Rendimiento por segmento",
            "Pie" or "Donut" => "Distribución de ingresos",
            "Polar" or "Radar" => "Indicadores de rendimiento",
            "Error" => "Mediciones con incertidumbre",
            "Vector3D" or "Points3D" or "Bar3D" => "Análisis tridimensional",
            "Histogram" or "HorizontalHistogram" or "Box" or "HorizBox" or "Violin" or "HorizViolin" or "BeeSwarm" or "HorizBeeSwarm" => "Distribución de resultados",
            "Surface" or "Contour" or "ColorGrid" or "Tower" or "TriSurface" or "IsoSurface" or "Waterfall" => "Modelo topográfico",
            "Map" or "World" => "Indicadores por región",
            "OrgSeries" or "TreeMap" or "SquarifiedMap" or "Sankey" => "Estructura y flujo de recursos",
            "CircularGauge" or "ActivityGauge" or "KnobGauge" or "LinearGauge" or "VerticalLinearGauge" or "NumericGauge" or "Gauges" => "Panel de indicadores",
            "Calendar" or "Clock" or "ClockGauge" => "Planificación temporal",
            "TagCloud" => "Tendencias de producto",
            _ => SeriesDemoCatalog.Find(seriesType)?.Name ?? "Ventas mensuales"
        };

        private static string GetScenarioSubtitle(string seriesType) => seriesType switch
        {
            "Violin" or "HorizViolin" => "Densidad y dispersión de incidencias resueltas en Chat, Web y Teléfono",
            "Tornado" => "Comparativa del impacto percibido: segmento amarillo con mayor peso relativo",
            "Candle" or "HighLow" or "Volume" => "Datos diarios de apertura, máximo, mínimo y cierre",
            "Gantt" => "Calendario de tareas y entregas del proyecto",
            "Bubble" => "Comparativa de volumen, valor y tamaño de mercado",
            "Pie" or "Donut" => "Peso relativo de cada línea de negocio",
            "Polar" or "Radar" => "Comparativa de métricas normalizadas",
            "Error" or "ErrorBar" or "ErrorPoint" or "ErrorPoint3D" => "Valores observados con margen de error",
            "Surface" or "Contour" or "ColorGrid" or "Tower" or "TriSurface" or "IsoSurface" or "Waterfall" => "Elevación y variación sobre una malla de observaciones",
            "Map" or "World" => "Comparación geográfica de actividad y crecimiento",
            "OrgSeries" or "TreeMap" or "SquarifiedMap" => "Distribución jerárquica de equipos y presupuesto",
            "Sankey" => "Flujo de recursos desde origen hasta destino",
            "CircularGauge" or "ActivityGauge" or "KnobGauge" or "LinearGauge" or "VerticalLinearGauge" or "NumericGauge" or "Gauges" => "Estado actual frente al objetivo operativo",
            "Box" or "HorizBox" or "Violin" or "HorizViolin" or "BeeSwarm" or "HorizBeeSwarm" => "Distribución de una muestra de mediciones",
            "Calendar" => "Actividad diaria del calendario",
            "Clock" or "ClockGauge" => "Hora y progreso de la jornada",
            "TagCloud" => "Popularidad relativa de conceptos y productos",
            _ => $"Ejemplo profesional de serie {seriesType}"
        };
    }
}
