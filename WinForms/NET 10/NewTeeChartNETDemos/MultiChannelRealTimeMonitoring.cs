using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Steema.TeeChart;
using Steema.TeeChart.Styles;

namespace NewTeeChartNETDemos
{
    public partial class MultiChannelRealTimeMonitoring : Form
    {
        private const int CHANNEL_COUNT = 5;
        private const int DATA_POINTS_PER_SECOND = 1000; // 1000 Hz
        private const double DEFAULT_X_RANGE_MS = 30 * 1000; // 30 seconds
        private const int MAX_POINTS = 50000;

        private System.Windows.Forms.Timer? streamTimer;
        private Stopwatch? stopwatch;
        private Stopwatch? fpsStopwatch;

        private List<Line> channels = new List<Line>();
        private List<Axis> customAxes = new List<Axis>();
        private int dataPointIndex = 0;
        private int framesCount = 0;
        private double currentFPS = 0;

        // Data generators for each channel
        private readonly double[][] generatedData = new double[CHANNEL_COUNT][];

        public MultiChannelRealTimeMonitoring()
        {
            InitializeComponent();
        }

        private void MultiChannelRealTimeMonitoring_Load(object sender, EventArgs e)
        {
            Text = $"TeeChart - Multi-channel Real-Time Monitoring ({CHANNEL_COUNT} channels, {DATA_POINTS_PER_SECOND} Hz)";
            Width = 1200;
            Height = 800;

            stopwatch = new Stopwatch();
            fpsStopwatch = new Stopwatch();

            streamTimer = new System.Windows.Forms.Timer
            {
                Interval = 25 // ~40 FPS update rate
            };

            streamTimer.Tick += StreamTimer_Tick;

            // Generate synthetic data for each channel
            GenerateChannelData();

            ConfigureChart();
            CreateChannels();

            stopwatch.Start();
            fpsStopwatch.Start();
            streamTimer.Start();
        }

        private void GenerateChannelData()
        {
            // Generate different wave patterns for each channel
            // Channel 1: Sin wave
            generatedData[0] = GenerateSinWave(400 * Math.PI, (x) => 8 * Math.Sin(x / 200));

            // Channel 2: Slow Sin wave
            generatedData[1] = GenerateSinWave(3200 * Math.PI, (x) => 7 * Math.Sin(x / 1600));

            // Channel 3: Combined wave
            generatedData[2] = GenerateSinWave(800 * Math.PI, (x) => 4 * (Math.Cos(x / 400) + Math.Sin(x / 200)));

            // Channel 4: Complex wave
            generatedData[3] = GenerateSinWave(800 * Math.PI, (x) => 6 * Math.Sin(x / 100) + Math.Cos(x / 400));

            // Channel 5: Cos wave
            generatedData[4] = GenerateSinWave(1800 * Math.PI, (x) => 8 * Math.Cos(x / 900));
        }

        private double[] GenerateSinWave(double length, Func<double, double> func)
        {
            int dataLength = (int)Math.Ceiling(length);
            double[] data = new double[dataLength];

            for (int i = 0; i < dataLength; i++)
            {
                data[i] = func(i);
            }

            return data;
        }

        private void ConfigureChart()
        {
            tChart1.Series.Clear();

            tChart1.Header.Text = $"Multi-channel Real-Time Monitoring ({CHANNEL_COUNT} channels, {DATA_POINTS_PER_SECOND} Hz)";
            tChart1.Header.Font.Color = Color.White;
            tChart1.Header.Font.Size = 12;

            tChart1.Panel.Gradient.Visible = false;
            tChart1.Panel.Color = Color.FromArgb(24, 24, 24);

            tChart1.Aspect.View3D = false;

            // Configure X Axis
            Axis axisX = tChart1.Axes.Bottom;
            axisX.Title.Text = "Time (ms)";
            axisX.Title.Font.Color = Color.White;
            axisX.Labels.Font.Color = Color.White;
            axisX.AxisPen.Color = Color.FromArgb(100, 100, 100);
            axisX.Grid.Color = Color.FromArgb(45, 45, 45);
            //axisX.Labels.DateTimeFormat = "hh:mm:ss";

            // Configure Left Y Axis (used by first channel)
            Axis axisY = tChart1.Axes.Left;
            axisY.Title.Text = "Ch 1";
            axisY.Title.Font.Color = Color.White;
            axisY.Title.Visible = true;

            axisY.Labels.Font.Color = Color.White;
            axisY.Labels.Visible = true;

            axisY.AxisPen.Color = GetChannelColor(0);
            axisY.AxisPen.Visible = true;

            axisY.Grid.Color = Color.FromArgb(45, 45, 45);
            axisY.Grid.Visible = true;

            axisY.Ticks.Visible = true;

            // Keep CH1 in the same top band as the custom axes below it.
            // StartPosition must be lower than EndPosition; the previous
            // reversed values caused the CH1 left axis to render incorrectly.
            axisY.StartPosition = 100 - (100 / CHANNEL_COUNT);
            axisY.EndPosition = 100;

            tChart1.Legend.Visible = true;
            tChart1.Legend.Font.Color = Color.White;
            tChart1.Legend.Alignment = LegendAlignments.Right;
            tChart1.Legend.Transparency = 0;
        }

        private void CreateChannels()
        {
            // Create a line series for each channel
            for (int i = 0; i < CHANNEL_COUNT; i++)
            {
                Line series = new Line(tChart1.Chart)
                {
                    Title = $"Channel {i + 1}"
                };

                series.Marks.Visible = false;
                series.Color = GetChannelColor(i);
                series.XValues.DateTime = true;

                // First series uses default Left axis
                if (i == 0)
                {
                    // First channel uses default left axis
                    series.VertAxis = VerticalAxis.Left;
                }
                else
                {
                    // Create a custom left axis for channels 2-5
                    Axis customAxis = new Axis(tChart1.Chart);
                    customAxis.Title.Text = $"Ch {i + 1}";
                    customAxis.Title.Font.Color = Color.White;
                    customAxis.Title.Visible = true;

                    customAxis.Labels.Font.Color = Color.White;
                    customAxis.Labels.Visible = true;

                    customAxis.AxisPen.Color = GetChannelColor(i);
                    customAxis.AxisPen.Visible = true;

                    customAxis.Grid.Color = Color.FromArgb(45, 45, 45);
                    customAxis.Grid.Visible = true;

                    customAxis.Ticks.Visible = true;

                    // Distribute custom axes in the left side
                    // Channel 2: 80-100%
                    // Channel 3: 60-80%
                    // Channel 4: 40-60%
                    // Channel 5: 20-40%
                    int channelPosition = CHANNEL_COUNT - i;
                    customAxis.StartPosition = (100 * (channelPosition - 1)) / CHANNEL_COUNT;
                    customAxis.EndPosition = (100 * channelPosition) / CHANNEL_COUNT;

                    // Add custom axis to chart
                    tChart1.Chart.Axes.Custom.Add(customAxis);

                    // Assign custom axis to series
                    series.VertAxis = VerticalAxis.Custom;
                    series.CustomVertAxis = customAxis;

                    customAxes.Add(customAxis);
                }

                channels.Add(series);
            }
        }

        private Color GetChannelColor(int channelIndex)
        {
            Color[] colors = new Color[]
            {
                Color.FromArgb(255, 100, 100),   // Red
                Color.FromArgb(100, 255, 100),   // Green
                Color.FromArgb(100, 150, 255),   // Blue
                Color.FromArgb(255, 200, 100),   // Orange
                Color.FromArgb(200, 100, 255)    // Purple
            };

            return colors[channelIndex % colors.Length];
        }

        private void StreamTimer_Tick(object? sender, EventArgs e)
        {
            if (stopwatch == null || fpsStopwatch == null)
                return;

            // Calculate how many data points to add based on elapsed time
            long elapsedMs = stopwatch.ElapsedMilliseconds;
            int targetDataPoints = (int)((DATA_POINTS_PER_SECOND * elapsedMs) / 1000);
            int pointsToAdd = Math.Min(targetDataPoints - dataPointIndex, 1000); // Max 1000 per frame

            if (pointsToAdd > 0)
            {
                // Add points to each channel
                for (int ch = 0; ch < CHANNEL_COUNT; ch++)
                {
                    Line series = channels[ch];

                    for (int i = 0; i < pointsToAdd; i++)
                    {
                        double xValue = (double)((dataPointIndex + i) * 1000) / DATA_POINTS_PER_SECOND;
                        int dataIdx = (dataPointIndex + i) % generatedData[ch].Length;
                        double yValue = generatedData[ch][dataIdx];

                        if (series.Count >= MAX_POINTS)
                        {
                            series.Delete(0);
                        }

                        series.Add(xValue, yValue);
                    }
                }

                dataPointIndex += pointsToAdd;

                // Auto-scroll X axis to show last 30 seconds
                if (channels[0].Count > 0)
                {
                    double xMax = channels[0].XValues[channels[0].Count - 1];
                    double xMin = xMax - DEFAULT_X_RANGE_MS;

                    // Keep the streaming buffer bounded to the visible window.
                    // Without this cleanup, every channel retained the complete
                    // history and rendering became progressively slower.
                    TrimPointsOutsideVisibleWindow(xMin);
                    tChart1.Axes.Bottom.SetMinMax(xMin, xMax);
                }
            }

            // Update FPS counter
            framesCount++;
            if (fpsStopwatch.ElapsedMilliseconds >= 5000)
            {
                currentFPS = (framesCount * 1000.0) / fpsStopwatch.ElapsedMilliseconds;
                lblFPS.Text = $"FPS: {currentFPS:F1}";
                framesCount = 0;
                fpsStopwatch.Restart();
            }

            tChart1.Invalidate();
        }

        private void TrimPointsOutsideVisibleWindow(double xMin)
        {
            foreach (Line series in channels)
            {
                while (series.Count > 0 && series.XValues[0] < xMin)
                    series.Delete(0);

                // Safety cap in case the visible range is changed later.
                while (series.Count > MAX_POINTS)
                    series.Delete(0);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (channels.Count > 0 && channels[0].Count > 0)
            {
                // Reset view to show initial data range
                double xMax = channels[0].XValues[channels[0].Count - 1];
                tChart1.Axes.Bottom.SetMinMax(Math.Max(0, xMax - DEFAULT_X_RANGE_MS), xMax);

                // Auto-fit Y axis
                tChart1.Axes.Left.AutomaticMinimum = true;
                tChart1.Axes.Left.AutomaticMaximum = true;
            }
        }

        private void MultiChannelRealTimeMonitoring_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (streamTimer != null)
            {
                streamTimer.Stop();
                streamTimer.Dispose();
            }

            if (stopwatch != null)
            {
                stopwatch.Stop();
            }

            if (fpsStopwatch != null)
            {
                fpsStopwatch.Stop();
            }
        }
    }
}
