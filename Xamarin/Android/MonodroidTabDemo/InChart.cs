using System;

using Android.App;
using Android.OS;

namespace TeeChartAndMonoAndroid1
{
  [Activity(Label = "My Activity")]
  public class Classic : Activity
  {
    protected override void OnCreate(Bundle bundle)
    {
      base.OnCreate(bundle);
      InitializeChart();
    }

    void InitializeChart()
    {
      var tChart1 = new Steema.TeeChart.TChart (ApplicationContext);

      tChart1.Aspect.View3D = false;
      tChart1.Header.Text = "Zoom the chart!";
      //tChart1.Zoom.Style = Steema.TeeChart.ZoomStyles.InChart;
      tChart1.ContentDescription = "Classic";

      var myTheme = new Steema.TeeChart.Themes.BlackIsBackTheme(tChart1.Chart);
      myTheme.Apply();

      tChart1.Series.Add(new Steema.TeeChart.Styles.Area()).FillSampleValues();

      SetContentView(tChart1);
    }

    protected override void OnDestroy()
    {
      base.OnDestroy();
      GC.Collect();
    }
  }
}