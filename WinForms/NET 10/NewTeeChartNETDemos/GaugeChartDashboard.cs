using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Steema.TeeChart;
using Steema.TeeChart.Styles;
using WFPanel = System.Windows.Forms.Panel;
using TChart = Steema.TeeChart.TChart;

namespace NewTeeChartNETDemos
{
    public partial class GaugeChartDashboard : Form
    {
        private const int NUM_CHANNELS = 4;
        private const int DATA_POINT_LIMIT = 10_000;
        private const int UPDATE_INTERVAL_MS = 17; // ~60 FPS

        private readonly List<double> currentChannelValues;
        private readonly List<Line> lineSeries;
        private readonly List<CircularGauge> gaugeCharts;
        private readonly Random random;
        private System.Windows.Forms.Timer updateTimer;
        private double timeCounter = 0;

        public GaugeChartDashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.ClientSize = new Size(1200, 800);

            currentChannelValues = new List<double>();
            lineSeries = new List<Line>();
            gaugeCharts = new List<CircularGauge>();
            random = new Random();

            for (int i = 0; i < NUM_CHANNELS; i++)
            {
                currentChannelValues.Add(random.NextDouble() * 100);
            }
        }

        private void GaugeChartDashboard_Load(object sender, EventArgs e)
        {
            InitializeXYChart();
            InitializeGauges();
            StartDataUpdates();
        }

        private void InitializeXYChart()
        {
            tChartXY.Aspect.View3D = false;
            tChartXY.BackColor = Color.FromArgb(45, 45, 48);
            tChartXY.Panel.Color = Color.FromArgb(45, 45, 48);
            tChartXY.Legend.Visible = false;
            tChartXY.Header.Visible = false;

            // Configure default X-axis
            Axis defaultAxisX = tChartXY.Axes.Bottom;
            defaultAxisX.Title.Text = "Time (s)";
            defaultAxisX.Title.Font.Color = Color.White;
            defaultAxisX.Labels.Font.Color = Color.White;
            defaultAxisX.AxisPen.Color = Color.FromArgb(100, 100, 100);
            defaultAxisX.Grid.Color = Color.FromArgb(45, 45, 45);

            // Remove default Y-axis
            tChartXY.Axes.Left.Visible = false;

            // Create 4 channels with individual Y-axes
            Color[] channelColors = new Color[]
            {
                Color.FromArgb(0, 200, 100),      // Green
                Color.FromArgb(0, 150, 200),      // Blue
                Color.FromArgb(255, 150, 0),      // Orange
                Color.FromArgb(200, 100, 200)     // Purple
            };

            for (int iCh = 0; iCh < NUM_CHANNELS; iCh++)
            {
                // Create custom Y-axis for this channel
                Axis axisY = new Axis(tChartXY.Chart);
                axisY.Title.Text = $"Channel {iCh + 1}";
                axisY.Title.Font.Color = Color.White;
                axisY.Labels.Font.Color = Color.White;
                axisY.Labels.Font.Size = 10;
                axisY.AxisPen.Color = channelColors[iCh];
                axisY.AxisPen.Width = 2;
                axisY.Ticks.Color = channelColors[iCh];
                axisY.Grid.Visible = true;
                axisY.Grid.Color = Color.FromArgb(60, 60, 65);
                axisY.SetMinMax(0, 100);
                axisY.AutomaticMinimum = false;
                axisY.AutomaticMaximum = false;

                // Position each axis on the left side
                int channelPosition = NUM_CHANNELS - iCh;
                axisY.StartPosition = (100 * (channelPosition - 1)) / NUM_CHANNELS;
                axisY.EndPosition = (100 * channelPosition) / NUM_CHANNELS;

                // Add axis to chart
                tChartXY.Chart.Axes.Custom.Add(axisY);

                // Create line series for this channel
                Line lineSeries = new Line(tChartXY.Chart);
                lineSeries.Color = channelColors[iCh];
                lineSeries.VertAxis = VerticalAxis.Custom;
                lineSeries.CustomVertAxis = axisY;
                lineSeries.Title = $"Channel {iCh + 1}";
                lineSeries.LinePen.Width = 2;
                lineSeries.Pointer.Visible = false;

                this.lineSeries.Add(lineSeries);
                tChartXY.Series.Add(lineSeries);
            }

            tChartXY.AutoRepaint = true;
        }

        private void InitializeGauges()
        {
            gaugesPanelContainer.Controls.Clear();
            gaugesPanelContainer.AutoSize = false;
            gaugesPanelContainer.Height = splitContainerMain.Panel1.Height;            

            Color[] gaugeColors = new Color[]
            {
                Color.FromArgb(0, 200, 100),      // Green
                Color.FromArgb(0, 150, 200),      // Blue
                Color.FromArgb(255, 150, 0),      // Orange
                Color.FromArgb(200, 100, 200)     // Purple
            };

            for (int iCh = 0; iCh < NUM_CHANNELS; iCh++)
            {
                // Create a Panel for each gauge
                WFPanel gaugePanel = new WFPanel();
                gaugePanel.Name = $"gaugePanel{iCh}";
                gaugePanel.Height = gaugesPanelContainer.Height / NUM_CHANNELS;
                gaugePanel.Width = gaugesPanelContainer.Width;
                gaugePanel.Dock = DockStyle.Top;
                gaugePanel.BackColor = Color.FromArgb(45, 45, 48);
                gaugesPanelContainer.Controls.Add(gaugePanel);

                // Create TChart for gauge
                TChart gaugeChart = new TChart();
                gaugeChart.Name = $"gaugeChart{iCh}";
                gaugeChart.Dock = DockStyle.Fill;
                gaugeChart.Parent = gaugePanel;
                gaugeChart.BackColor = Color.FromArgb(45, 45, 48);
                gaugeChart.Panel.Color = Color.FromArgb(45, 45, 48);
                gaugeChart.Aspect.View3D = false;
                gaugeChart.Legend.Visible = false;
                gaugeChart.Header.Visible = true;
                gaugeChart.Header.Text = $"Channel {iCh + 1}";
                gaugeChart.Header.Font.Color = gaugeColors[iCh];
                gaugeChart.Header.Font.Size = 14;
                gaugeChart.Header.Font.Bold = true;                  

                // Create circular gauge chart
                CircularGauge gauge = new CircularGauge(gaugeChart.Chart);
                gauge.Value = currentChannelValues[iCh];
                gauge.Maximum = 100;
                gauge.Minimum = 0;
                gauge.Axis.Labels.Font.Size = 6;
                gauge.Axis.Labels.Font.Color = Color.White;

                gaugeChart.Series.Add(gauge);
                gaugeCharts.Add(gauge);
            }
        }

        private void StartDataUpdates()
        {
            updateTimer = new System.Windows.Forms.Timer();
            updateTimer.Interval = UPDATE_INTERVAL_MS;
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Start();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            timeCounter += (UPDATE_INTERVAL_MS / 1000.0);

            for (int iCh = 0; iCh < NUM_CHANNELS; iCh++)
            {
                // Generate new value with small random change
                double prev = currentChannelValues[iCh];
                double change = 5.0 * (random.NextDouble() * 2.0 - 1.0);
                double newValue = Math.Max(0, Math.Min(100, prev + change));

                currentChannelValues[iCh] = newValue;

                // Update line series
                lineSeries[iCh].Add(timeCounter, newValue);

                // Limit data points
                if (lineSeries[iCh].Count > DATA_POINT_LIMIT)
                {
                    lineSeries[iCh].Delete(0);
                }

                // Update gauge
                gaugeCharts[iCh].Value = newValue;
            }

            tChartXY.Invalidate();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            // Clear all data
            foreach (var line in lineSeries)
            {
                line.Clear();
            }

            // Reset values
            for (int i = 0; i < NUM_CHANNELS; i++)
            {
                currentChannelValues[i] = random.NextDouble() * 100;
                gaugeCharts[i].Value = currentChannelValues[i];
            }

            timeCounter = 0;
            tChartXY.Invalidate();
            lblStatus.Text = "Data reset";
        }

        private void GaugeChartDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (updateTimer != null)
            {
                updateTimer.Stop();
                updateTimer.Dispose();
            }
        }
    }
}
