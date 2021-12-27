using System;
using System.Drawing;

using Android.App;
using Android.Content;
using Android.OS;

namespace TeeChartAndMonoAndroid1
{
  [Activity(Label = "My Activity")]
  public class BatteryGauge : Activity
  {
    protected override void OnCreate(Bundle bundle)
    {
      base.OnCreate(bundle);

      var batteryIntent = ApplicationContext.RegisterReceiver (null,
        new IntentFilter(Intent.ActionBatteryChanged));
      int rawlevel = batteryIntent.GetIntExtra("level", -1);
      double scale = batteryIntent.GetIntExtra("scale", -1);
      double level = -1;
      if (rawlevel >= 0 && scale > 0)
      {
        level = (rawlevel / scale);
      }

      InitializeChart(level);
    }

    Steema.TeeChart.TChart tChart1;

    void InitializeChart(double level)
    {
      tChart1 = new Steema.TeeChart.TChart (ApplicationContext);

      tChart1.Header.Visible = true;
      tChart1.Header.Text = "Battery Level";
      tChart1.Header.Font.Size = 20;
      tChart1.Header.Font.Color = Color.LightGray;

      tChart1.Panel.Visible = false;

      var circularGauge1 = new Steema.TeeChart.Styles.CircularGauge(tChart1.Chart);

      circularGauge1.Value = level * 100;
      circularGauge1.NumericGauge.Visible = true;
      circularGauge1.NumericGauge.ValueFormat = "###.0";
      circularGauge1.NumericGauge.ValueMarker.Shape.Font.Size = 25;
      circularGauge1.TotalAngle = 240;
      circularGauge1.RedLine.Visible = false;
      circularGauge1.GreenLineStartValue = 0;
      circularGauge1.GreenLineEndValue = 100;
      circularGauge1.GreenLine.Gradient.Direction = Steema.TeeChart.Drawing.GradientDirection.RightLeft;
      circularGauge1.GreenLine.Gradient.UseMiddle = true;
      circularGauge1.GreenLine.Gradient.StartColor = Color.Red;
      circularGauge1.GreenLine.Gradient.MiddleColor = Color.Yellow;
      circularGauge1.GreenLine.Gradient.EndColor = Color.Green;
      circularGauge1.Axis.Labels.Font.Color = Color.LightGray;
      circularGauge1.Axis.Labels.Font.Size = 15;
      circularGauge1.MinorTicks.Visible = true;
      circularGauge1.MinorTicks.VertSize = 2;
      circularGauge1.MinorTicks.HorizSize = 2;
      circularGauge1.Axis.MinorTickCount = 4;

      SetContentView(tChart1);
    }

    protected override void OnDestroy()
    {
      base.OnDestroy();
      GC.Collect();
    }
  }
}