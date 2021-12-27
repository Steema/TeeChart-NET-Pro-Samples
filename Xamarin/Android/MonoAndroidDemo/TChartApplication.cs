using System;

using Android.App;
using Android.Runtime;

using Steema.TeeChart;

namespace MonoAndroidDemo
{
  [Application]
  public class TChartApplication : Application
  {
    public TChart Chart { get; set; }

    public TChartApplication(IntPtr handle, JniHandleOwnership transfer)
      : base(handle, transfer)
    {
    }

    public override void OnCreate()
    {
      base.OnCreate();

      Chart = new TChart(this);
    }
  }
}