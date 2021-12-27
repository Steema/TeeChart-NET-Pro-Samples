using System;

using Android.App;
using Android.OS;

namespace TeeChartAndMonoAndroid1
{
  [Activity(Label = "My Activity")]
  public class Pie2D : Activity
  {
    protected override void OnCreate(Bundle bundle)
    {
      base.OnCreate(bundle);

      InitializeChart();
    }

    Steema.TeeChart.TChart tChart1;

    void InitializeChart()
    {
      tChart1 = new Steema.TeeChart.TChart (ApplicationContext);

      tChart1.Aspect.View3D = false;
      tChart1.Zoom.Style = Steema.TeeChart.ZoomStyles.InChart;
      tChart1.Legend.Visible = false;
      tChart1.Header.Text = "Chart created using Xamarin.Android";
      tChart1.Header.Font.Size = 24;
      tChart1.Header.Font.Color = System.Drawing.Color.Black;
      tChart1.ContentDescription = "Pie2D";

      var pie1 = new Steema.TeeChart.Styles.Pie(tChart1.Chart);
      pie1.FillSampleValues(4);
      pie1.Circled = true;
      pie1.Marks.Transparent = true;
      pie1.Marks.Arrow.Visible = false;
      pie1.Marks.Font.Size = 24;
      pie1.Pen.Width = 8;
      pie1.Pen.Color = System.Drawing.Color.FromArgb(60, 60, 60);
      pie1.Pen.EndCap = Android.Graphics.Paint.Cap.Round;
      pie1.ExplodeBiggest = 15;

      pie1.ColorEach = false;
      for (int i = 0; i < pie1.Count; i++)
      {
        pie1.Colors[i] = Steema.TeeChart.Themes.Theme.OnBlackPalette [i];
      }

      SetContentView(tChart1);
    }

    protected override void OnDestroy()
    {
      base.OnDestroy();
      GC.Collect();
    }
  }
}