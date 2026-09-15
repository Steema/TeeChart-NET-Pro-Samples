using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Steema.TeeChart;
using Steema.TeeChart.Styles;

namespace NewTeeChartNETDemos
{
    public partial class CytometryVisualization : Form
    {
        private readonly Random random;
        private Points? cytometrySeries;

        public CytometryVisualization()
        {
            InitializeComponent();
            random = new Random();
        }

        private void CytometryVisualization_Load(object sender, EventArgs e)
        {
            ConfigureChart();
            CreateSeries();
            GenerateSyntheticCytometryData();
        }

        private void ConfigureChart()
        {
            tChart1.Aspect.View3D = false;
            tChart1.Panel.Color = Color.FromArgb(24, 24, 24);
            tChart1.Panel.Gradient.Visible = false;
            tChart1.Legend.Visible = false;
            tChart1.Header.Text = "Flow Cytometry Visualization";
            tChart1.Header.Font.Color = Color.White;
            tChart1.Header.Font.Size = 12;

            Axis axisX = tChart1.Axes.Bottom;
            axisX.Title.Text = "FSC-A (10⁶)";
            axisX.Title.Font.Color = Color.White;
            axisX.Labels.Font.Color = Color.White;
            axisX.AxisPen.Color = Color.Gray;
            axisX.Grid.Color = Color.FromArgb(45, 45, 45);
            axisX.SetMinMax(1.3, 10.0);
            axisX.Automatic = false;

            Axis axisY = tChart1.Axes.Left;
            axisY.Title.Text = "SSC-A (10⁶)";
            axisY.Title.Font.Color = Color.White;
            axisY.Labels.Font.Color = Color.White;
            axisY.AxisPen.Color = Color.Gray;
            axisY.Grid.Color = Color.FromArgb(45, 45, 45);
            axisY.SetMinMax(-0.2, 1.8);
            axisY.Automatic = false;
        }

        private void CreateSeries()
        {
            tChart1.Series.Clear();

            var series = new Points(tChart1.Chart)
            {
                Title = "Cells",
                ColorEach = true,
                Marks = { Visible = false }
            };

            series.Pointer.Style = PointerStyles.Circle;
            series.Pointer.HorizSize = 3;
            series.Pointer.VertSize = 3;
            series.Pointer.Pen.Visible = false;
            series.LinePen.Visible = false;

            cytometrySeries = series;
            tChart1.Series.Add(series);
        }

        private void GenerateSyntheticCytometryData()
        {
            if (cytometrySeries == null)
                return;

            cytometrySeries.Clear();

            AddCluster(3.2, 0.35, 3000, 0.35, 0.12, 8, 30);
            AddCluster(5.5, 0.75, 2600, 0.45, 0.18, 35, 70);
            AddCluster(7.4, 1.15, 2200, 0.55, 0.20, 75, 110);
            AddCluster(8.5, 1.45, 1400, 0.35, 0.12, 110, 150);
            AddDebris(1200);
        }

        private void AddCluster(double centerX, double centerY, int count, double spreadX, double spreadY, double minIntensity, double maxIntensity)
        {
            if (cytometrySeries == null)
                return;

            for (int i = 0; i < count; i++)
            {
                double x = centerX + NextGaussian() * spreadX;
                double y = centerY + NextGaussian() * spreadY;
                double intensity = minIntensity + random.NextDouble() * (maxIntensity - minIntensity);

                x = Math.Max(1.3, Math.Min(10.0, x));
                y = Math.Max(-0.2, Math.Min(1.8, y));

                int index = cytometrySeries.Add(x, y);
                cytometrySeries.Colors[index] = MapIntensityToColor(intensity);
            }
        }

        private void AddDebris(int count)
        {
            if (cytometrySeries == null)
                return;

            for (int i = 0; i < count; i++)
            {
                double x = 1.3 + random.NextDouble() * 8.7;
                double y = -0.2 + random.NextDouble() * 2.0;
                double intensity = random.NextDouble() * 12;

                int index = cytometrySeries.Add(x, y);
                cytometrySeries.Colors[index] = MapIntensityToColor(intensity);
            }
        }

        private double NextGaussian()
        {
            double u1 = 1.0 - random.NextDouble();
            double u2 = 1.0 - random.NextDouble();
            return Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
        }

        private Color MapIntensityToColor(double value)
        {
            if (value <= 1)
                return Color.FromArgb(20, 0, 0, 0);
            if (value <= 10)
                return Color.FromArgb(140, 0, 100, 255);
            if (value <= 50)
                return Color.FromArgb(160, 60, 180, 255);
            if (value <= 100)
                return Color.FromArgb(180, 0, 255, 0);
            if (value <= 150)
                return Color.FromArgb(220, 255, 255, 0);
            return Color.FromArgb(240, 255, 0, 0);
        }
    }
}
