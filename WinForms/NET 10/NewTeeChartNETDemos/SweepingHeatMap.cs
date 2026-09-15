using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart;
using Steema.TeeChart.Styles;
using Steema.TeeChart.Tools;

namespace NewTeeChartNETDemos
{
    public partial class SweepingHeatMap : Form
    {
        private const int DataSampleSize = 1000;
        private const int SweepingHistory = 250;

        private System.Windows.Forms.Timer streamTimer;
        private Stopwatch stopwatch = new Stopwatch();

        private ColorGrid heatmap;
        private ColorLine sweepLine;

        private readonly int[,] pointIndex = new int[SweepingHistory, DataSampleSize];

        private int iSample = 0;
        private long dataAmount = 0;
        private long lastResetMs = 0;

        private readonly SpectrumGenerator generator = new SpectrumGenerator(DataSampleSize);

        public SweepingHeatMap()
        {
            InitializeComponent();
        }


        private void SweepingHeatMap_Load(object sender, EventArgs e)
        {

            Text = "TeeChart - Sweeping Heatmap Spectrogram";
            Width = 1200;
            Height = 800;


            streamTimer = new System.Windows.Forms.Timer
            {
                Interval = 25
            };

            streamTimer.Tick += StreamTimer_Tick;

            ConfigureChart();
            CreateHeatmap();

            stopwatch.Start();
            streamTimer.Start();
        }



        private void ConfigureChart()
        {
            tChart1.Series.Clear();
            tChart1.Tools.Clear();

            tChart1.Header.Text = "Sweeping Heatmap Spectrogram";
            tChart1.Header.Font.Color = Color.White;

            tChart1.Panel.Gradient.Visible = false;
            tChart1.Panel.Color = Color.FromArgb(24, 24, 24);

            tChart1.Aspect.View3D = false;

            tChart1.Legend.Visible = false;

            tChart1.Axes.Bottom.Title.Text = "Sweeping history";
            tChart1.Axes.Bottom.Title.Font.Color = Color.White;
            tChart1.Axes.Bottom.Labels.Font.Color = Color.White;
            tChart1.Axes.Bottom.AxisPen.Color = Color.FromArgb(100, 100, 100);
            tChart1.Axes.Bottom.Grid.Color = Color.FromArgb(45, 45, 45);
            tChart1.Axes.Bottom.SetMinMax(0, SweepingHistory);

            tChart1.Axes.Left.Title.Text = "Frequency (Hz)";
            tChart1.Axes.Left.Title.Font.Color = Color.White;
            tChart1.Axes.Left.Labels.Font.Color = Color.White;
            tChart1.Axes.Left.AxisPen.Color = Color.FromArgb(100, 100, 100);
            tChart1.Axes.Left.Grid.Color = Color.FromArgb(45, 45, 45);
            tChart1.Axes.Left.SetMinMax(0, DataSampleSize);
        }

        private void CreateHeatmap()
        {
            heatmap = new ColorGrid(tChart1.Chart)
            {
                Title = "Intensity",
                ColorEach = true,
                IrregularGrid = false,
                CenteredPoints = true
                //ShowInLegend = false
            };

            heatmap.Marks.Visible = false;
            heatmap.Pen.Visible = false;

            heatmap.BeginUpdate();

            try
            {
                for (int column = 0; column < SweepingHistory; column++)
                {
                    for (int row = 0; row < DataSampleSize; row++)
                    {
                        double intensity = 0;
                        Color color = GetSpectrogramColor(intensity);

                        // ColorGrid Add(x, y, z, color)
                        // X = time column
                        // Y = intensity value
                        // Z = frequency row
                        int index = heatmap.Add(column, intensity, row, color);

                        pointIndex[column, row] = index;
                    }
                }
            }
            finally
            {
                heatmap.EndUpdate();
            }

            // Equivalent visual marker for the sweeping update band.
            sweepLine = new ColorLine(tChart1.Chart)
            {
                Axis = tChart1.Axes.Bottom,
                Value = 0
            };

            sweepLine.Pen.Color = Color.FromArgb(230, 255, 255, 255);
            sweepLine.Pen.Width = 2;
        }

        private void StreamTimer_Tick(object sender, EventArgs e)
        {
            double[] sample = generator.NextSample(iSample);

            int column = iSample % SweepingHistory;

            heatmap.BeginUpdate();

            try
            {
                for (int row = 0; row < DataSampleSize; row++)
                {
                    int index = pointIndex[column, row];

                    double intensity = sample[row];

                    // Update intensity value.
                    heatmap.YValues[index] = intensity;

                    // Update color manually, equivalent to PalettedFill + LUT.
                    heatmap.Colors[index] = GetSpectrogramColor(intensity);
                }
            }
            finally
            {
                heatmap.EndUpdate();
            }

            sweepLine.Value = column;

            dataAmount += sample.Length;
            iSample++;

            UpdateTitlePps();

            tChart1.Refresh();
        }

        private void UpdateTitlePps()
        {
            long elapsedMs = stopwatch.ElapsedMilliseconds;

            if (elapsedMs <= 0)
                return;

            if (dataAmount > 0)
            {
                double pps = 1000.0 * dataAmount / Math.Max(1, elapsedMs - lastResetMs);
                tChart1.Header.Text = $"Sweeping Heatmap Spectrogram ({Math.Round(pps):N0} data points / s)";
            }

            if (elapsedMs - lastResetMs >= 5000)
            {
                lastResetMs = elapsedMs;
                dataAmount = 0;
            }
        }

        private struct LutStep
        {
            public double Value;
            public Color Color;

            public LutStep(double value, Color color)
            {
                Value = value;
                Color = color;
            }
        }

        private static readonly LutStep[] SpectrogramLut =
        {
        new LutStep(0,  Color.FromArgb(0, 0, 0)),
        new LutStep(10, Color.FromArgb(0, 0, 120)),
        new LutStep(20, Color.FromArgb(0, 70, 255)),
        new LutStep(35, Color.FromArgb(0, 220, 255)),
        new LutStep(50, Color.FromArgb(0, 255, 80)),
        new LutStep(60, Color.FromArgb(255, 255, 0)),
        new LutStep(70, Color.FromArgb(255, 120, 0)),
        new LutStep(80, Color.FromArgb(255, 0, 0))
    };

        private static Color GetSpectrogramColor(double value)
        {
            if (value <= SpectrogramLut[0].Value)
                return SpectrogramLut[0].Color;

            for (int i = 1; i < SpectrogramLut.Length; i++)
            {
                LutStep previous = SpectrogramLut[i - 1];
                LutStep next = SpectrogramLut[i];

                if (value <= next.Value)
                {
                    double t = (value - previous.Value) / (next.Value - previous.Value);
                    return InterpolateColor(previous.Color, next.Color, t);
                }
            }

            return SpectrogramLut[SpectrogramLut.Length - 1].Color;
        }

        private static Color InterpolateColor(Color a, Color b, double t)
        {
            t = Math.Max(0, Math.Min(1, t));

            int r = (int)Math.Round(a.R + (b.R - a.R) * t);
            int g = (int)Math.Round(a.G + (b.G - a.G) * t);
            int bl = (int)Math.Round(a.B + (b.B - a.B) * t);

            return Color.FromArgb(r, g, bl);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tChart1_DoubleClick(object sender, EventArgs e)
        {
            tChart1.ShowEditor();
        }
    }

    public class SpectrumGenerator
    {
        private readonly int sampleSize;
        private readonly Random random = new Random();

        public SpectrumGenerator(int sampleSize)
        {
            this.sampleSize = sampleSize;
        }

        public double[] NextSample(int sampleIndex)
        {
            double[] sample = new double[sampleSize];

            double t = sampleIndex * 0.05;

            double peak1 = 120 + 60 * Math.Sin(t * 0.7);
            double peak2 = 340 + 90 * Math.Sin(t * 0.31 + 1.5);
            double peak3 = 620 + 160 * Math.Sin(t * 0.17 + 2.4);
            double peak4 = 820 + 80 * Math.Sin(t * 0.43 + 3.2);

            for (int i = 0; i < sampleSize; i++)
            {
                double noise = random.NextDouble() * 6.0;

                double value =
                    noise +
                    Gaussian(i, peak1, 10, 55) +
                    Gaussian(i, peak2, 18, 65) +
                    Gaussian(i, peak3, 28, 48) +
                    Gaussian(i, peak4, 14, 72);

                sample[i] = Math.Max(0, Math.Min(80, value));
            }

            return sample;
        }

        private static double Gaussian(double x, double center, double width, double amplitude)
        {
            double d = x - center;
            return amplitude * Math.Exp(-(d * d) / (2 * width * width));
        }
    }
}
