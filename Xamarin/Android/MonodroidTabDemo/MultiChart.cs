using System;

using Android.App;
using Android.OS;

namespace TeeChartAndMonoAndroid1
{
  [Activity(Label = "My Activity")]
  public class MultiChart : Activity
  {
    protected override void OnCreate(Bundle bundle)
    {
      base.OnCreate(bundle);

      var tChart1 = new Steema.TeeChart.TChart (ApplicationContext);

      tChart1.Panel.Transparent = true;
      tChart1.Header.Text = "Multiple series made with Xamarin.Android";
      tChart1.Zoom.Style = Steema.TeeChart.ZoomStyles.FullChart;
      tChart1.Axes.Top.Visible = false;
      tChart1.ContentDescription = "MultiChart";

      var myTheme = new Steema.TeeChart.Themes.BlackIsBackTheme(tChart1.Chart);
      myTheme.Apply();

      var area1 = new Steema.TeeChart.Styles.Area(tChart1.Chart);
      area1.FillSampleValues();
      area1.Gradient.Visible = true;
      area1.Gradient.StartColor = area1.Color;
      area1.Gradient.Transparency = 40;
      area1.Transparency = area1.Gradient.Transparency;

      var bar1 = new Steema.TeeChart.Styles.Bar(tChart1.Chart);
      bar1.FillSampleValues();
      bar1.Brush.Transparency = 30;
      bar1.Marks.Visible = false;
      bar1.Color = Steema.TeeChart.Themes.Theme.OnBlackPalette[1];
      bar1.HorizAxis = Steema.TeeChart.Styles.HorizontalAxis.Top;

      var line1 = new Steema.TeeChart.Styles.Line(tChart1.Chart);
      line1.FillSampleValues();
      line1.Color = Steema.TeeChart.Themes.Theme.OnBlackPalette[3];

      SetContentView(tChart1);
    }

    protected override void OnDestroy()
    {
      base.OnDestroy();
      GC.Collect();
    }
  }
}