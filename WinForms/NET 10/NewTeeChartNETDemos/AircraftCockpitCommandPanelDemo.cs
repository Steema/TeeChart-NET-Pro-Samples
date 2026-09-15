using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Steema.TeeChart;
using Steema.TeeChart.Styles;
using WinFormsPanel = System.Windows.Forms.Panel;

namespace NewTeeChartNETDemos
{
    public sealed class AircraftCockpitCommandPanelDemo : AttentionChartDemoBase
    {
        private const int ProfileLength = 60;
        private const double InitialAltitude = 32000;

        private Line altitudeSeries = null!;
        private Area altitudeArea = null!;
        private CircularGauge airspeedGauge = null!;
        private CircularGauge altitudeGauge = null!;
        private CircularGauge headingGauge = null!;
        private Bar systemsSeries = null!;
        private Radar navigationSeries = null!;
        private Polar windSeries = null!;
        private Label statusLabel = null!;
        private Label flightDataLabel = null!;
        private Image? cockpitImage;
        private WinFormsPanel cockpitSurface = null!;
        private WinFormsPanel instrumentOverlay = null!;
        private WinFormsPanel headerPanel = null!;
        private TChart airspeedChart = null!;
        private TChart altitudeChart = null!;
        private TChart navigationChart = null!;
        private TChart systemsChart = null!;
        private TChart headingChart = null!;
        private TChart windChart = null!;

        private const float CockpitImageWidth = 1680f;
        private const float CockpitImageHeight = 945f;

        public AircraftCockpitCommandPanelDemo() : base("Aircraft Cockpit Command Panel")
        {
            Text = "TeeChart - Aircraft Cockpit Command Panel";
            Width = 1500;
            Height = 950;

            BuildCockpitLayout();
            ConfigurePrimaryFlightDisplay();
            ConfigureGaugeInstruments();
            ConfigureSystemsChart();
            ConfigureNavigationRadar();
            ConfigureWindPolar();
            StartValueAnimation(UpdateFlightInstruments);
        }

        private void BuildCockpitLayout()
        {
            Controls.Remove(TeeChart);

            cockpitSurface = new WinFormsPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(5, 12, 18),
                BackgroundImageLayout = ImageLayout.Zoom
            };
            string imagePath = Path.Combine(AppContext.BaseDirectory, "Assets", "aircraft-cockpit-background.png");
            if (File.Exists(imagePath))
            {
                cockpitImage = Image.FromFile(imagePath);
                cockpitSurface.BackgroundImage = cockpitImage;
            }

            instrumentOverlay = new WinFormsPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent
            };

            headerPanel = new WinFormsPanel
            {
                BackColor = Color.FromArgb(190, 7, 18, 27),
                Padding = new Padding(14, 7, 14, 5)
            };
            var titleLabel = new Label
            {
                Dock = DockStyle.Top,
                Height = 25,
                Text = "AIRCRAFT COMMAND PANEL",
                ForeColor = Color.FromArgb(135, 225, 255),
                Font = new Font("Segoe UI", 13, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };
            statusLabel = new Label
            {
                Dock = DockStyle.Left,
                Width = 430,
                Text = "● SIMULATION LIVE · AUTOPILOT ON",
                ForeColor = Color.FromArgb(80, 225, 160),
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };
            flightDataLabel = new Label
            {
                Text = "FLIGHT LEVEL 320 · CRUISE · ROUTE TRAINING",
                ForeColor = Color.FromArgb(175, 200, 211),
                Font = new Font("Segoe UI", 8),
                TextAlign = ContentAlignment.MiddleRight
            };
            headerPanel.Controls.Add(flightDataLabel);
            headerPanel.Controls.Add(statusLabel);
            headerPanel.Controls.Add(titleLabel);

            airspeedChart = CreateInstrumentChart("AIRSPEED", Color.FromArgb(74, 197, 255));
            altitudeChart = CreateInstrumentChart("ALTITUDE", Color.FromArgb(75, 220, 155));
            navigationChart = CreateInstrumentChart("NAVIGATION / THREAT RADAR", Color.FromArgb(255, 196, 79));
            systemsChart = CreateInstrumentChart("ENGINE / SYSTEMS", Color.FromArgb(255, 135, 95));
            headingChart = CreateInstrumentChart("HEADING", Color.FromArgb(211, 128, 255));
            windChart = CreateInstrumentChart("WIND VECTOR", Color.FromArgb(120, 205, 255));

            instrumentOverlay.Controls.Add(headerPanel);
            instrumentOverlay.Controls.Add(TeeChart);
            instrumentOverlay.Controls.Add(airspeedChart);
            instrumentOverlay.Controls.Add(altitudeChart);
            instrumentOverlay.Controls.Add(navigationChart);
            instrumentOverlay.Controls.Add(systemsChart);
            instrumentOverlay.Controls.Add(headingChart);
            instrumentOverlay.Controls.Add(windChart);
            cockpitSurface.Controls.Add(instrumentOverlay);
            Controls.Add(cockpitSurface);

            // The cockpit uses image-relative coordinates, so these charts must not be
            // re-laid out by WinForms docking after their bounds are calculated.
            TeeChart.Dock = DockStyle.None;
            airspeedChart.Dock = DockStyle.None;
            altitudeChart.Dock = DockStyle.None;
            navigationChart.Dock = DockStyle.None;
            systemsChart.Dock = DockStyle.None;
            headingChart.Dock = DockStyle.None;
            windChart.Dock = DockStyle.None;

            instrumentOverlay.Resize += (_, _) => LayoutCockpitInstruments();
            LayoutCockpitInstruments();
        }

        private void LayoutCockpitInstruments()
        {
            if (instrumentOverlay.ClientSize.Width <= 0 || instrumentOverlay.ClientSize.Height <= 0)
                return;

            float scale = Math.Min(
                instrumentOverlay.ClientSize.Width / CockpitImageWidth,
                instrumentOverlay.ClientSize.Height / CockpitImageHeight);
            float offsetX = (instrumentOverlay.ClientSize.Width - CockpitImageWidth * scale) / 2f;
            float offsetY = (instrumentOverlay.ClientSize.Height - CockpitImageHeight * scale) / 2f;

            static Rectangle ToRectangle(float x, float y, float width, float height, float scale, float offsetX, float offsetY)
            {
                return Rectangle.Round(new RectangleF(
                    offsetX + x * scale,
                    offsetY + y * scale,
                    width * scale,
                    height * scale));
            }

            // These rectangles match the actual instrument screens in the generated cockpit image.
            headerPanel.Bounds = ToRectangle(520, 352, 640, 42, scale, offsetX, offsetY);
            TeeChart.Bounds = ToRectangle(520, 395, 640, 238, scale, offsetX, offsetY);
            airspeedChart.Bounds = ToRectangle(205, 528, 142, 145, scale, offsetX, offsetY);
            altitudeChart.Bounds = ToRectangle(362, 528, 142, 145, scale, offsetX, offsetY);
            navigationChart.Bounds = ToRectangle(1178, 528, 142, 145, scale, offsetX, offsetY);
            systemsChart.Bounds = ToRectangle(1330, 528, 142, 145, scale, offsetX, offsetY);
            headingChart.Bounds = ToRectangle(535, 644, 292, 104, scale, offsetX, offsetY);
            windChart.Bounds = ToRectangle(850, 644, 292, 104, scale, offsetX, offsetY);
        }

        private static TChart CreateInstrumentChart(string title, Color accent)
        {
            var chart = new TChart
            {
                Dock = DockStyle.None,
                BackColor = Color.Transparent
            };
            chart.Panel.Gradient.Visible = false;
            chart.Panel.Transparent = true;
            chart.Panel.Color = Color.Transparent;
            chart.Panel.Brush.Visible = false;
            chart.Panel.Brush.Transparency = 100;
            chart.Walls.Visible = false;
            chart.Header.Text = title;
            chart.Header.Font.Color = accent;
            chart.Header.Font.Size = 7;
            chart.Header.Font.Bold = true;
            chart.Header.Transparency = 100;
            chart.Header.Pen.Visible = false;
            chart.Header.Shadow.Visible = false;
            chart.Legend.Visible = false;
            chart.Aspect.View3D = false;

            Axis[] axes = { chart.Axes.Bottom, chart.Axes.Left };
            foreach (Axis axis in axes)
            {
                axis.Labels.Font.Color = Color.FromArgb(175, 204, 215);
                axis.Title.Font.Color = Color.FromArgb(145, 177, 190);
                axis.Grid.Color = Color.FromArgb(100, 155, 175);
                axis.Grid.Transparency = 84;
                axis.AxisPen.Transparency = 68;
                axis.Ticks.Transparency = 70;
            }

            return chart;
        }

        private void ConfigurePrimaryFlightDisplay()
        {
            TeeChart.BackColor = Color.Transparent;
            TeeChart.Panel.Transparent = true;
            TeeChart.Panel.Color = Color.Transparent;
            TeeChart.Panel.Brush.Visible = false;
            TeeChart.Panel.Brush.Transparency = 100;
            TeeChart.Walls.Visible = false;
            TeeChart.Header.Text = "PRIMARY FLIGHT DISPLAY · ALTITUDE PROFILE";
            TeeChart.Header.Font.Color = Color.FromArgb(135, 225, 255);
            TeeChart.Header.Font.Size = 8;
            TeeChart.Header.Transparency = 100;
            TeeChart.Header.Pen.Visible = false;
            TeeChart.Header.Shadow.Visible = false;
            TeeChart.Legend.Visible = false;
            TeeChart.Aspect.View3D = false;

            altitudeArea = new Area(TeeChart.Chart)
            {
                Title = "Altitude envelope",
                Color = Color.FromArgb(47, 142, 183)
            };
            altitudeArea.AreaBrush.Color = Color.FromArgb(47, 142, 183);
            altitudeArea.AreaBrush.Transparency = 90;
            altitudeArea.LinePen.Visible = false;

            altitudeSeries = new Line(TeeChart.Chart)
            {
                Title = "Altitude",
                Color = Color.FromArgb(135, 225, 255)
            };
            altitudeSeries.LinePen.Width = 2;
            altitudeSeries.Pointer.Visible = false;

            for (int i = 0; i < ProfileLength; i++)
            {
                double altitude = InitialAltitude
                    + 600 * Math.Sin(i * 0.15)
                    + 180 * Math.Sin(i * 0.48);
                altitudeArea.Add(i, altitude);
                altitudeSeries.Add(i, altitude);
            }

            TeeChart.Axes.Bottom.SetMinMax(0, ProfileLength - 1);
            TeeChart.Axes.Bottom.Labels.Visible = false;
            TeeChart.Axes.Bottom.Grid.Transparency = 88;
            TeeChart.Axes.Left.SetMinMax(28000, 36000);
            TeeChart.Axes.Left.Increment = 1000;
            TeeChart.Axes.Left.Title.Text = "Altitude (ft)";
            TeeChart.Axes.Left.Labels.ValueFormat = "#,##0";
            TeeChart.Axes.Left.Labels.Font.Color = Color.FromArgb(190, 220, 230);
        }

        private void ConfigureGaugeInstruments()
        {
            airspeedGauge = AddGauge(airspeedChart, "Airspeed (kt)", 0, 360, 248, Color.FromArgb(74, 197, 255));
            altitudeGauge = AddGauge(altitudeChart, "Altitude (ft)", 0, 42000, InitialAltitude, Color.FromArgb(75, 220, 155));
            headingGauge = AddGauge(headingChart, "Heading (°)", 0, 360, 278, Color.FromArgb(211, 128, 255));
        }

        private static CircularGauge AddGauge(TChart chart, string axisTitle, double minimum, double maximum, double value, Color accent)
        {
            var gauge = new CircularGauge(chart.Chart)
            {
                Minimum = minimum,
                Maximum = maximum,
                Value = value
            };
            chart.Series.Add(gauge);
            gauge.Axis.Labels.Font.Color = Color.FromArgb(205, 225, 232);
            gauge.Axis.Labels.Font.Size = 7;
            gauge.Axis.Labels.ValueFormat = maximum > 1000 ? "#,##0" : "0";
            gauge.Axis.AxisPen.Color = accent;
            gauge.Axis.Grid.Visible = false;
            chart.Axes.Bottom.Visible = false;
            chart.Axes.Left.Visible = false;
            return gauge;
        }

        private void ConfigureSystemsChart()
        {
            TChart chart = systemsChart;
            systemsSeries = new Bar(chart.Chart)
            {
                Title = "System status",
                ColorEach = true
            };
            systemsSeries.Marks.Visible = true;
            systemsSeries.Marks.Style = MarksStyles.Value;
            systemsSeries.Marks.Transparent = true;
            systemsSeries.Marks.Font.Color = Color.FromArgb(220, 235, 240);
            systemsSeries.Marks.Font.Size = 7;
            systemsSeries.Add(86, "ENG 1", Color.FromArgb(75, 220, 155));
            systemsSeries.Add(85, "ENG 2", Color.FromArgb(75, 220, 155));
            systemsSeries.Add(74, "FUEL", Color.FromArgb(255, 196, 79));
            systemsSeries.Add(100, "CABIN", Color.FromArgb(120, 205, 255));

            chart.Axes.Bottom.Labels.Font.Color = Color.FromArgb(180, 210, 220);
            chart.Axes.Left.SetMinMax(0, 110);
            chart.Axes.Left.Increment = 20;
            chart.Axes.Left.Labels.ValueFormat = "0";
            chart.Axes.Left.Title.Text = "% / load";
            chart.Axes.Left.Grid.Transparency = 86;
        }

        private void ConfigureNavigationRadar()
        {
            TChart chart = navigationChart;
            navigationSeries = new Radar(chart.Chart)
            {
                Title = "Traffic envelope",
                Color = Color.FromArgb(255, 196, 79),
                Circled = true,
                CloseCircle = true,
                CircleLabels = true,
                AutoCircleResize = false
            };
            string[] sectors = { "N", "NE", "E", "SE", "S", "SW", "W", "NW" };
            double[] values = { 32, 48, 70, 56, 38, 64, 44, 28 };
            for (int i = 0; i < sectors.Length; i++)
                navigationSeries.Add(values[i], sectors[i], Color.FromArgb(255, 196, 79));

            navigationSeries.GetVertAxis.SetMinMax(0, 100);
            navigationSeries.GetVertAxis.Increment = 20;
            navigationSeries.GetHorizAxis.SetMinMax(0, 360);
            navigationSeries.GetHorizAxis.Increment = 45;
            chart.Axes.Bottom.Visible = false;
            chart.Axes.Left.Visible = false;
        }

        private void ConfigureWindPolar()
        {
            TChart chart = windChart;
            windSeries = new Polar(chart.Chart)
            {
                Title = "Wind speed",
                Color = Color.FromArgb(120, 205, 255),
                Circled = true,
                CloseCircle = true,
                CircleLabels = true,
                AutoCircleResize = false
            };
            for (int i = 0; i < 16; i++)
            {
                double angle = i * 22.5;
                double speed = 18 + 7 * Math.Sin(i * 0.7) + 3 * Math.Cos(i * 0.25);
                windSeries.Add(angle, speed);
            }

            windSeries.GetVertAxis.SetMinMax(0, 40);
            windSeries.GetVertAxis.Increment = 10;
            windSeries.GetHorizAxis.SetMinMax(0, 360);
            windSeries.GetHorizAxis.Increment = 90;
            chart.Axes.Bottom.Visible = false;
            chart.Axes.Left.Visible = false;
        }

        private void UpdateFlightInstruments(double phase)
        {
            double altitude = InitialAltitude
                + 900 * Math.Sin(phase * 0.34)
                + 240 * Math.Sin(phase * 1.05);
            double airspeed = 248
                + 18 * Math.Sin(phase * 0.62)
                + 6 * Math.Cos(phase * 1.8);
            double heading = NormalizeDegrees(278 + 22 * Math.Sin(phase * 0.28) + 5 * Math.Sin(phase * 1.2));

            altitudeGauge.Value = altitude;
            airspeedGauge.Value = airspeed;
            headingGauge.Value = heading;
            ShiftSeries(altitudeArea, altitude);
            ShiftSeries(altitudeSeries, altitude);

            systemsSeries.YValues[0] = 86 + 4 * Math.Sin(phase * 0.8);
            systemsSeries.YValues[1] = 85 + 3 * Math.Sin(phase * 0.8 + 0.5);
            systemsSeries.YValues[2] = 74 - 0.03 * phase;
            systemsSeries.YValues[3] = 100 + 1.5 * Math.Sin(phase * 0.25);

            for (int i = 0; i < navigationSeries.Count; i++)
            {
                double baseValue = navigationSeries.YValues[i];
                navigationSeries.YValues[i] = Math.Max(15, Math.Min(95,
                    baseValue + 5 * Math.Sin(phase * 0.45 + i * 0.8)));
            }

            for (int i = 0; i < windSeries.Count; i++)
                windSeries.YValues[i] = Math.Max(8, Math.Min(38, 20 + 8 * Math.Sin(phase * 0.3 + i * 0.7)));

            statusLabel.Text = $"● SIMULATION LIVE · AUTOPILOT ON · {airspeed:F0} KT";
            flightDataLabel.Text = $"FLIGHT LEVEL {altitude / 100:000} · HEADING {heading:000}° · WIND {18 + 4 * Math.Sin(phase):00} KT";
        }

        private static void ShiftSeries(Series series, double value)
        {
            for (int i = 0; i < series.Count - 1; i++)
            {
                series.XValues[i] = i;
                series.YValues[i] = series.YValues[i + 1];
            }

            int last = series.Count - 1;
            series.XValues[last] = last;
            series.YValues[last] = value;
        }

        private static double NormalizeDegrees(double value)
        {
            double result = value % 360;
            return result < 0 ? result + 360 : result;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                cockpitImage?.Dispose();

            base.Dispose(disposing);
        }
    }
}
