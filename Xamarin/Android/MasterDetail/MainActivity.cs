using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Steema.TeeChart;
using Steema.TeeChart.Styles;

namespace MasterDetail
{
  [Activity(Label = "MasterDetail", MainLauncher = true, Icon = "@drawable/icon")]
  public class MainActivity : Activity
  {

    TChart tChart1;
    TChart tChart2;
    Series master;

    protected override void OnCreate(Bundle bundle)
    {
      base.OnCreate(bundle);

      // Set our view from the "main" layout resource
      SetContentView(Resource.Layout.Main);

      tChart1 = new TChart(this);
      tChart2 = new TChart(this);

      tChart1.ClickSeries += TChart1_ClickSeries;
      tChart1.Aspect.View3D = false;
      tChart1.Panning.Allow = ScrollModes.None;
      tChart2.Panning.Allow = ScrollModes.None;

      tChart2.Aspect.View3D = false;

      master = new Bar(tChart1.Chart);
      master.Title = "Sample";
      master.ColorEach = true;

      master.Detail.Aggregate = DetailAggregate.Sum;
      master.BeginUpdate();

      master.Add("Cars", System.Drawing.Color.Empty, 21, 14, 59, 8);
      master.Add("Lamps", System.Drawing.Color.Empty, 5, 10, 20, 7);
      master.Add("Tables", System.Drawing.Color.Empty, 17, 20, 6, 12);

      master.Detail[0].Labels[1] = "Ford";
      master.Detail[2].Labels[2] = "Wood";

      master.EndUpdate();

      LinearLayout linearLayout = FindViewById<LinearLayout>(Resource.Id.linearLayout1);

      tChart1.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent, 1);
      tChart2.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent, 1);

      linearLayout.AddView(tChart1);
      linearLayout.AddView(tChart2);
    }

    void TChart1_ClickSeries(object sender, Series s, int valueIndex, MotionEvent e)
    {
      SelectDetail(valueIndex);
    }

    void SelectDetail(int valueIndex)
    {
      tChart2.Series.Clear();

      if (master.Detail.Count > valueIndex)
      {
        master.Detail[valueIndex].Color = master.ValueColor(valueIndex);
        master.Detail[valueIndex].Chart = tChart2.Chart;
        tChart2.Header.Text = master.Detail[valueIndex].Title;
      }
    }
  }
}

