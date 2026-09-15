using System;
using System.Drawing;
using System.Windows.Forms;
using Steema.TeeChart;

namespace NewTeeChartNETDemos
{
public abstract class AttentionChartDemoBase : Form
    {
        protected TChart TeeChart { get; }
        private System.Windows.Forms.Timer? animationTimer;
        private double animationPhase;

        protected AttentionChartDemoBase(string title)
        {
            Text = title;
            Width = 1200;
            Height = 800;
            BackColor = Color.FromArgb(25, 25, 25);

            TeeChart = new TChart
            {
                Dock = DockStyle.Fill
            };

            Controls.Add(TeeChart);

            TeeChart.Header.Text = title;
            TeeChart.Header.Font.Color = Color.White;
            TeeChart.Panel.Gradient.Visible = false;
            TeeChart.Panel.Color = Color.FromArgb(25, 25, 25);
            TeeChart.Legend.Font.Color = Color.White;
            TeeChart.Aspect.View3D = false;
            ConfigureSoftGrids();

            FormClosed += (_, _) =>
            {
                animationTimer?.Stop();
                animationTimer?.Dispose();
            };
        }

        protected void StartValueAnimation(Action<double> updateValues)
        {
            animationTimer = new System.Windows.Forms.Timer { Interval = 90 };
            animationTimer.Tick += (_, _) =>
            {
                if (IsDisposed || Disposing)
                {
                    animationTimer?.Stop();
                    return;
                }

                animationPhase += 0.12;
                updateValues(animationPhase);
                TeeChart.Invalidate();
            };
            animationTimer.Start();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                animationTimer?.Stop();
                animationTimer?.Dispose();
                animationTimer = null;
            }

            base.Dispose(disposing);
        }

        protected static double AnimatedEmission(int index, double phase, double amplitude = 0.12)
        {
            double source = AttentionChartData.Emissions[index];
            double variation = amplitude * Math.Sin(phase + index * 0.57)
                + 0.035 * Math.Cos((phase * 1.7) + index * 0.31);
            return Math.Max(1, source * (1 + variation));
        }

        private void ConfigureSoftGrids()
        {
            Axis[] axes =
            {
                TeeChart.Axes.Top, TeeChart.Axes.Bottom,
                TeeChart.Axes.Left, TeeChart.Axes.Right
            };

            foreach (Axis axis in axes)
            {
                axis.Grid.Visible = true;
                axis.Grid.Color = Color.FromArgb(125, 170, 190);
                axis.Grid.Transparency = 78;
                axis.MinorGrid.Visible = false;
                axis.AxisPen.Transparency = 68;
                axis.Ticks.Transparency = 65;
                axis.MinorTicks.Transparency = 80;
            }
        }

        protected void HideCartesianAxes()
        {
            HideAxis(TeeChart.Axes.Bottom);
            HideAxis(TeeChart.Axes.Left);
        }

        private static void HideAxis(Steema.TeeChart.Axis axis)
        {
            axis.Labels.Visible = false;
            axis.AxisPen.Visible = false;
            axis.Grid.Visible = false;
            axis.Ticks.Visible = false;
            axis.MinorTicks.Visible = false;
        }
    }

    internal static class AttentionChartData
    {
        public static readonly string[] Countries =
        {
            "United States", "Japan", "Germany", "France", "United Kingdom",
            "Italy", "Russia", "Spain", "Brazil", "Canada", "India", "Australia"
        };

        // Approximate 2018 CO2 emissions in MTCO2e, matching the article's example range.
        public static readonly double[] Emissions =
        {
            498, 1080, 753, 322, 367, 321, 1550, 283, 451, 573, 2416, 535
        };

        public static Color ColorFor(int index)
        {
            Color[] palette =
            {
                Color.FromArgb(68, 1, 84), Color.FromArgb(71, 44, 122),
                Color.FromArgb(59, 82, 139), Color.FromArgb(44, 113, 142),
                Color.FromArgb(33, 144, 141), Color.FromArgb(39, 173, 129),
                Color.FromArgb(92, 200, 99), Color.FromArgb(170, 220, 50),
                Color.FromArgb(253, 231, 37), Color.FromArgb(255, 180, 70),
                Color.FromArgb(245, 120, 60), Color.FromArgb(210, 55, 80)
            };

            return palette[index % palette.Length];
        }
    }
}
