using System;

using Android.App;
using Android.OS;
using Android.Widget;

using Steema.TeeChart;

namespace MonoAndroidDemo
{
  [Activity(Label = "Chart settings")]
  public class ChartEditor : Activity
  {
    TChart tChart;

    protected override void OnCreate(Bundle savedInstanceState)
    {
      base.OnCreate(savedInstanceState);

      SetContentView(Resource.Layout.Editor);

      tChart = ((TChartApplication)Application).Chart;

      CheckBox cb3D = FindViewById<CheckBox>(Resource.Id.cb3D);
      cb3D.Checked = tChart.Aspect.View3D;
      cb3D.Click += new EventHandler(cb3D_Click);

      Spinner spinnerZoom = FindViewById<Spinner>(Resource.Id.spinnerZoomStyle);
      spinnerZoom.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinnerZoom_ItemSelected);

      var adapterZoom = ArrayAdapter.CreateFromResource(
          this, Resource.Array.zoom_styles, Android.Resource.Layout.SimpleSpinnerItem);

      adapterZoom.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
      spinnerZoom.Adapter = adapterZoom;
      int pos = 2-(int)tChart.Zoom.Style; //inverted order defined by ZoomStyles enum
      spinnerZoom.SetSelection(pos, false);
    }

    void spinnerZoom_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
    {
      switch (e.Position)
      {
        case 0:
          tChart.Zoom.Style = ZoomStyles.Classic;
          break;
        case 1:
          tChart.Zoom.Style = ZoomStyles.FullChart;
          break;
        case 2:
          tChart.Zoom.Style = ZoomStyles.InChart;
          break;
        default:
          tChart.Zoom.Style = ZoomStyles.Classic;
          break;
      }
    }

    void cb3D_Click(object sender, EventArgs e)
    {
      tChart.Aspect.View3D = (sender as CheckBox).Checked;
    }
  }
}