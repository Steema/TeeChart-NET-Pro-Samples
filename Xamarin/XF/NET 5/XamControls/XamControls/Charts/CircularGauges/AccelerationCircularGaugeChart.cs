using Steema.TeeChart;
using Steema.TeeChart.Styles;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamControls.Charts.CircularGauges
{
    public class AccelerationCircularGaugeChart
    {

        private ChartView BaseChart;
        private CircularGauge circularGauge;

        public AccelerationCircularGaugeChart(ChartView BaseChart)
        {

            this.BaseChart = BaseChart;
            circularGauge = InitializeGauge();

            BaseChart.Chart.Header.Text = "Accelerometer Circular Gauge";
            // TODO PEP BaseChart.Chart.Header.Alignment = TextAlignment.Center;
            // TODO PEP BaseChart.Chart.Header.TextAlign = TextAlignment.End;
            BaseChart.Chart.SubHeader.Text = "X Axis";
            BaseChart.Chart.SubHeader.Visible = true;
            BaseChart.Chart.SubHeader.Font.Size += 6;
            BaseChart.Chart.Header.Font.Size += 6;
            BaseChart.Chart.Header.Font.Bold = true;
            BaseChart.Chart.Axes.Left.Increment = 0.2;
            BaseChart.Chart.Axes.Left.Labels.Font.Color = Color.FromRgb(110, 110, 110);
            BaseChart.Chart.Axes.Left.Labels.Font.Size += 7;
            BaseChart.HorizontalOptions = LayoutOptions.FillAndExpand;
            BaseChart.VerticalOptions = LayoutOptions.FillAndExpand;

            if (Device.RuntimePlatform != Device.UWP)
            {
                InitializeAccelerometer();
            }

            BaseChart.Chart.Series.Add(circularGauge);

        }

        private CircularGauge InitializeGauge()
        {

            CircularGauge gauge = new CircularGauge();

            gauge.Title = "Accelerometer Circular Gauge";
            gauge.Maximum = 1;
            gauge.Minimum = -1;
            gauge.GreenLine.Visible = false;
            gauge.RedLine.Visible = false;
            gauge.Frame.Width = 1;
            gauge.Hand.Gradient.Visible = false;
            gauge.Hand.Color = Color.FromRgb(170, 170, 170);
            gauge.HandOffset = 0;
            gauge.Hand.Style = PointerStyles.DownTriangle;
            gauge.Hand.HorizSize += 10;
            gauge.Center.Gradient.Visible = false;
            gauge.Center.Color = Color.FromRgb(170, 170, 170);
            gauge.Center.Shadow.Visible = false;
            gauge.Center.HorizSize += 10;
            gauge.Center.VertSize += 10;
            gauge.FaceBrush.Color = Color.White;
            gauge.FaceBrush.Gradient.Visible = false;
            gauge.Hand.HorizSize += 4;
            gauge.Hand.VertSize += 4;
            gauge.Ticks.VertSize = 10;
            gauge.Ticks.HorizSize = 2;
            gauge.MinorTicks.Visible = true;
            gauge.MinorTickDistance = 3;
            gauge.MinorTicks.HorizSize = 1;
            gauge.MinorTicks.VertSize = 5;
            gauge.Ticks.Pen.Visible = false;
            gauge.Ticks.Color = Color.FromRgb(140, 140, 140);
            gauge.RotateLabels = false;
            gauge.Frame.OuterBand.Visible = false;
            gauge.Frame.MiddleBand.Visible = false;
            gauge.Frame.InnerBand.Visible = true;
            gauge.Frame.InnerBand.Gradient.Visible = false;
            gauge.Frame.InnerBand.Color = Color.FromRgb(120, 120, 120);

            return gauge;

        }

        private void InitializeAccelerometer()
        {
            try
            {
                Accelerometer.Start(SensorSpeed.Default);
                Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;
            }

            catch (FeatureNotSupportedException) { //BaseChart.Parent//DisplayAlert("Alert", "Accelerometer Unavailable", "OK"); 
            }
        }

        private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {

                circularGauge.Value = e.Reading.Acceleration.X;

            });
        }

        public void RemoveEvent()
        {
            if (Device.RuntimePlatform != Device.UWP)
            {
                Accelerometer.ReadingChanged -= Accelerometer_ReadingChanged;
                Accelerometer.Stop();
            }
        }

    }
}
