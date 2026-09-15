using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Steema.TeeChart;
using Steema.TeeChart.Styles;
using Steema.TeeChart.Tools;

namespace NewTeeChartNETDemos
{
    public partial class ThresholdLineChart : Form
    {
        private const double ThresholdBadY = -30000;
        private const double ThresholdGoodY = 10000;
        private readonly Random random;

        public ThresholdLineChart()
        {
            InitializeComponent();
            random = new Random();
        }

        private void ThresholdLineChart_Load(object sender, EventArgs e)
        {
            ConfigureChart();
            CreateThresholdLines();
            CreateSegmentedSeries();
        }

        private void ConfigureChart()
        {
            tChart1.Aspect.View3D = false;
            tChart1.Panel.Color = Color.FromArgb(24, 24, 24);
            tChart1.Panel.Gradient.Visible = false;
            tChart1.Legend.Visible = false;
            tChart1.Header.Text = "Line Chart with dynamic good/bad values highlighting";
            tChart1.Header.Font.Color = Color.White;
            tChart1.Header.Font.Size = 12;

            Axis axisX = tChart1.Axes.Bottom;
            axisX.Title.Text = "Sample";
            axisX.Title.Font.Color = Color.White;
            axisX.Labels.Font.Color = Color.White;
            axisX.AxisPen.Color = Color.Gray;
            axisX.Grid.Color = Color.FromArgb(45, 45, 45);

            Axis axisY = tChart1.Axes.Left;
            axisY.Title.Text = "Value";
            axisY.Title.Font.Color = Color.White;
            axisY.Labels.Font.Color = Color.White;
            axisY.AxisPen.Color = Color.Gray;
            axisY.Grid.Color = Color.FromArgb(45, 45, 45);
        }

        private void CreateThresholdLines()
        {
            var badLine = new ColorLine(tChart1.Chart)
            {
                Axis = tChart1.Axes.Left,
                Value = ThresholdBadY
            };
            badLine.Pen.Color = Color.FromArgb(160, 255, 0, 0);
            badLine.Pen.Width = 2;
            tChart1.Tools.Add(badLine);

            var goodLine = new ColorLine(tChart1.Chart)
            {
                Axis = tChart1.Axes.Left,
                Value = ThresholdGoodY
            };
            goodLine.Pen.Color = Color.FromArgb(160, 0, 255, 0);
            goodLine.Pen.Width = 2;
            tChart1.Tools.Add(goodLine);
        }

        private void CreateSegmentedSeries()
        {
            double[] values = GenerateValues(400);
            List<Line> segments = new List<Line>();
            Line? currentSeries = null;
            ZoneType? currentZone = null;

            for (int i = 0; i < values.Length; i++)
            {
                ZoneType zone = GetZone(values[i]);

                if (currentSeries == null || currentZone != zone)
                {
                    currentSeries = CreateLineSeries(GetZoneColor(zone));
                    segments.Add(currentSeries);
                    tChart1.Series.Add(currentSeries);
                    currentZone = zone;

                    if (i > 0)
                    {
                        currentSeries.Add(i - 1, values[i - 1]);
                    }
                }

                currentSeries.Add(i, values[i]);
            }
        }

        private Line CreateLineSeries(Color color)
        {
            var series = new Line(tChart1.Chart)
            {
                Color = color,
                Marks = { Visible = false }
            };

            series.LinePen.Color = color;
            series.LinePen.Width = 2;
            series.Pointer.Visible = false;
            return series;
        }

        private double[] GenerateValues(int count)
        {
            double[] values = new double[count];
            double current = -5000;

            for (int i = 0; i < count; i++)
            {
                double wave = Math.Sin(i * 0.08) * 18000 + Math.Cos(i * 0.03) * 12000;
                double noise = (random.NextDouble() - 0.5) * 12000;
                current = wave + noise;
                values[i] = current;
            }

            return values;
        }

        private ZoneType GetZone(double y)
        {
            if (y <= ThresholdBadY)
                return ZoneType.Bad;
            if (y >= ThresholdGoodY)
                return ZoneType.Good;
            return ZoneType.Normal;
        }

        private Color GetZoneColor(ZoneType zone)
        {
            return zone switch
            {
                ZoneType.Bad => Color.FromArgb(255, 0, 0),
                ZoneType.Good => Color.FromArgb(0, 255, 0),
                _ => Color.FromArgb(255, 215, 0)
            };
        }

        private enum ZoneType
        {
            Bad,
            Normal,
            Good
        }
    }
}
