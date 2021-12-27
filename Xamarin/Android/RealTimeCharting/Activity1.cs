using System;

using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace RealTimeCharting
{
  [Activity(Label = "RealTimeCharting", MainLauncher = true, Icon = "@drawable/icon")]
  public class Activity1 : Activity
  {
    Steema.TeeChart.TChart tChart1;
    const int NumPoints = 50;
    const int MinValue = 0;
    const int MaxValue = 1000;
    System.Timers.Timer timer1;

    protected override void OnCreate(Bundle bundle)
    {
      base.OnCreate(bundle);

      // Set our view from the "main" layout resource
      SetContentView(Resource.Layout.Main);

      // Get our button from the layout resource,
      // and attach an event to it
      Button button = FindViewById<Button>(Resource.Id.MyButton);

      button.Click += delegate 
      {
        timer1.Enabled = !timer1.Enabled;
        button.Text = (timer1.Enabled) ? Resources.GetString(Resource.String.Stop) : Resources.GetString(Resource.String.Start);
      };

      //Add the chart
      tChart1 = new Steema.TeeChart.TChart(this);
      tChart1.Aspect.View3D = false;
      tChart1.Zoom.Style = Steema.TeeChart.ZoomStyles.None;
      tChart1.Legend.Visible = false;
      tChart1.Panel.Gradient.Visible = false;
      tChart1.Walls.Back.Gradient.Visible = false;
      tChart1.Walls.Back.Visible = false;
      tChart1.Axes.Left.Grid.Visible = false;
      tChart1.Axes.Bottom.Grid.Visible = false;
      tChart1.Axes.Left.Automatic = false;
      tChart1.Axes.Bottom.Automatic = false;
      tChart1.Axes.Left.SetMinMax(MinValue, MaxValue);      
      tChart1.Axes.Bottom.SetMinMax(0, NumPoints);
      tChart1.ClickSeries += tChart1_ClickSeries;
      
      //Left axis disabled for performance purposes.
      tChart1.Axes.Left.Visible = false;

      var fastLine1 = new Steema.TeeChart.Styles.FastLine(tChart1.Chart);
      fastLine1.FillSampleValues(NumPoints);
      fastLine1.DrawAllPoints = false;

      LinearLayout layout = FindViewById<LinearLayout>(Resource.Id.linearLayout1);
      layout.AddView(tChart1, new ViewGroup.LayoutParams(ViewGroup.LayoutParams.FillParent, 400));

      timer1 = new System.Timers.Timer();
      timer1.Elapsed += new System.Timers.ElapsedEventHandler(timer1_Elapsed);
      timer1.Interval = 100;
      timer1.Start();
    }

    void tChart1_ClickSeries(object sender, Steema.TeeChart.Styles.Series s, int valueIndex, MotionEvent e)
    {
      Toast
          .MakeText(this, "point " + valueIndex, ToastLength.Short)
          .Show();
    }    

    void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
    {
      RunOnUiThread(delegate
      {
        AnimateSeries(tChart1);
      });
    }

    void AnimateSeries(Steema.TeeChart.TChart chart)
    {
      var rnd = new Random();
      double newX, newY;

      tChart1.AutoRepaint = false;

      foreach (Steema.TeeChart.Styles.Series s in chart.Series)
      {
        // show only 50 points - delete the rest
        while (s.Count > NumPoints) s.Delete(0);
        if (s.Count > NumPoints) s.Delete(0);
        newX = s.XValues.Last + 1;
        newY = rnd.Next(MaxValue);
        if ((Math.Abs(newY) > MaxValue) || (Math.Abs(newY) < MinValue)) newY = 0.0;
        s.Add(newX, newY);
      }

      tChart1.Axes.Bottom.SetMinMax(tChart1.Axes.Bottom.Minimum + 1, tChart1.Axes.Bottom.Maximum + 1);
      
      tChart1.AutoRepaint = true;
      tChart1.Chart.Invalidate();
    }
  }

}

