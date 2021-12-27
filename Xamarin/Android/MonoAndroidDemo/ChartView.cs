using System.IO;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;

namespace MonoAndroidDemo
{
  [Activity(Label = "My Chart", ParentActivity = typeof(Activity1))]
  [MetaData("android.support.PARENT_ACTIVITY", Value = "com.steema.teechart.xamarin.android.Activity1")]
  public class ChartView : BaseActivity
  {
    Steema.TeeChart.TChart chart;
    protected override int LayoutResource
    {
      get
      {
        return Resource.Layout.Chart;
      }
    }

    protected override void OnCreate(Bundle savedInstanceState)
    {
      base.OnCreate(savedInstanceState);

      chart = new Steema.TeeChart.TChart (ApplicationContext);

      chart.Zoom.Style = Steema.TeeChart.ZoomStyles.Classic;

      Bundle extras = Intent.Extras;
      var seriesType = extras.GetInt("SeriesPosition");

      var tmp = Steema.TeeChart.Utils.SeriesTypesOf [seriesType];
      Steema.TeeChart.Styles.Series series;

      Title = tmp.ToString().Replace("Steema.TeeChart.Styles.", "");

      //Some series can not work without a parent chart due to internal structure.
      if (tmp.Name == "TreeMap")
      {
        series = new Steema.TeeChart.Styles.TreeMap(chart.Chart);
      }
      else if (tmp.Name == "PolarGrid")
      {
        series = new Steema.TeeChart.Styles.PolarGrid(chart.Chart);
      }
      else
      {
        series = chart.Series.Add(tmp); 
      }

      series.FillSampleValues();

      chart.Aspect.View3D = Needs3D(chart[0]);
      //chart.Panel.Transparent = true;

      if (chart[0] is Steema.TeeChart.Styles.Circular)
      {
        (chart[0] as Steema.TeeChart.Styles.Circular).Circled = true;
      }

      if (chart[0] is Steema.TeeChart.Styles.Pie)
      {
        var pie = (Steema.TeeChart.Styles.Pie)chart[0];
        
        pie.BevelPercent = 25;
        pie.Pen.Visible = false;
        pie.EdgeStyle = Steema.TeeChart.Drawing.EdgeStyles.Flat;
        pie.Circled = true;
        pie.FillSampleValues(6);
        chart.Legend.Visible = true;
        chart.Legend.Font.Size = 15;
        chart.Legend.Transparency = 30;
        chart.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
        chart.Aspect.View3D = true;
        chart.Aspect.VertOffset = -20;
        chart.Aspect.Elevation = 300;

        if (!(pie is Steema.TeeChart.Styles.Donut))
        {
          chart.Aspect.Chart3DPercent = 30;
          pie.BevelPercent = 15;
          chart.Legend.Transparent = true;
          chart.Legend.Font.Size = 16;
        }

        chart.Header.Text = "Touch a slice to explode it";
      }

      if (chart[0] is Steema.TeeChart.Styles.Gantt || chart[0] is Steema.TeeChart.Styles.Funnel)
      {
        chart.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
      }

      if (chart[0] is Steema.TeeChart.Styles.Custom3DPalette)
      {
        if (!(chart[0] is Steema.TeeChart.Styles.Contour) &&
            !(chart[0] is Steema.TeeChart.Styles.ColorGrid) &&
            !(chart[0] is Steema.TeeChart.Styles.Ternary) &&
            !(chart[0] is Steema.TeeChart.Styles.BubbleCloud))
        {
          chart.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
          chart.Legend.Font.Size = 30;
          chart.Legend.Visible = false;
          chart.Header.Text = "Drag to rotate";
          chart.Header.Font.Size = 30;
          chart.Walls.Visible = false;

          if (chart[0] is Steema.TeeChart.Styles.TriSurface)
          {
            chart.Aspect.Chart3DPercent = 30;
          }
          else
          {
            chart.Axes.Bottom.Increment = 1;

            chart.Aspect.Orthogonal = false;
            chart.Aspect.Chart3DPercent = 70;
            chart.Aspect.Rotation = 310;
            chart.Aspect.Zoom = 70;
            chart.Aspect.Perspective = 100;
          }

          chart.Tools.Add(new Steema.TeeChart.Tools.Rotate()); 
        }
        else if (chart[0] is Steema.TeeChart.Styles.Contour)
        {
          ((Steema.TeeChart.Styles.Custom3DPalette)chart[0]).Pen.Width = 3;
          ((Steema.TeeChart.Styles.Contour)chart[0]).FillLevels = true;
        }
        else if (chart[0] is Steema.TeeChart.Styles.BubbleCloud)
        {
          chart.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
        }

        ((Steema.TeeChart.Styles.Custom3DPalette)chart[0]).UseColorRange = false;
        ((Steema.TeeChart.Styles.Custom3DPalette)chart[0]).UsePalette = true;
        ((Steema.TeeChart.Styles.Custom3DPalette)chart[0]).PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Strong;
      }

      if ((chart[0] is Steema.TeeChart.Styles.Pie) ||
          (chart[0] is Steema.TeeChart.Styles.CircularGauge) || 
          (chart[0] is Steema.TeeChart.Styles.CustomGauge))
      {
        chart.ClickSeries += chart_ClickSeries;
      }
      else
      {
        chart.ClickSeries -= chart_ClickSeries;
      }

      //if (((chart[0] is Steema.TeeChart.Styles.Line) || (chart[0] is Steema.TeeChart.Styles.Points))
      //    && !(chart[0] is Steema.TeeChart.Styles.Bubble))
      //{
      //  chart.Header.Text = "Touch series for tool tip"; 
      //  chart.ClickSeries += chart_ClickSeries;
      //}
      //else
      //{
      //  chart.ClickSeries -= chart_ClickSeries;
      //}

      var chartLayout = FindViewById<LinearLayout>(Resource.Id.chart_layout);
      chartLayout.AddView(chart, ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);

      SupportActionBar.Title = Title;
    }

    void chart_ClickSeries(object sender, Steema.TeeChart.Styles.Series s, int valueIndex, MotionEvent e)
    {
      if (s is Steema.TeeChart.Styles.Pie)
      {
        var pie = (Steema.TeeChart.Styles.Pie)s;
        pie.ExplodedSlice[valueIndex] = (pie.ExplodedSlice[valueIndex] > 0) ? 0 : 15;
      }

      if ((chart[0] is Steema.TeeChart.Styles.Line) || (chart[0] is Steema.TeeChart.Styles.Points))
      {
        string text = (valueIndex != -1) ? "point index " + valueIndex : "no point clicked";
        ShowToast(text);
      }

      if ((s is Steema.TeeChart.Styles.CircularGauge) || (s is Steema.TeeChart.Styles.CustomGauge))
      {
        //To-Do
      }
    }

    void ShowToast(string text)
    {
      Toast
          .MakeText(this, text, ToastLength.Short)
          .Show();
    }

    bool Needs3D(Steema.TeeChart.Styles.Series series)
    {
      return (((series is Steema.TeeChart.Styles.Custom3D) && !((series is Steema.TeeChart.Styles.ColorGrid)   
                                                            || (series is Steema.TeeChart.Styles.Contour)
                                                            || (series is Steema.TeeChart.Styles.Map)
                                                            || (series is Steema.TeeChart.Styles.Ternary))) 
                                                            || (series is Steema.TeeChart.Styles.Pie));
    }

    public override bool OnCreateOptionsMenu(IMenu menu)
    {
      menu.Add(Menu.None, 0, Menu.None, "Settings").SetIcon(Android.Resource.Drawable.IcMenuManage);
      menu.Add(Menu.None, 1, Menu.None, "Theme").SetIcon(Android.Resource.Drawable.IcMenuGallery);
      menu.Add(Menu.None, 2, Menu.None, "Share").SetIcon(Android.Resource.Drawable.IcMenuShare);

      return true;// base.OnCreateOptionsMenu(menu);
    }

    public override bool OnOptionsItemSelected(IMenuItem item)
    {
      switch (item.ItemId)
      {
        case 0:
          ((TChartApplication)Application).Chart = chart;
          var editorIntent = new Intent(ApplicationContext, typeof(ChartEditor));
          StartActivityForResult(editorIntent, 1);
          return true;
        case 1:
          var themes = new ThemesEditor(chart, (int)chart.CurrentTheme);
          themes.Choose(this);
          return true;
        case 2:
          Java.IO.File cache = ExternalCacheDir;
          if ((cache == null) || (!cache.CanWrite()))
          {
            // no external cache
            cache = CacheDir;
          }

          Android.Graphics.Bitmap _currentBitmap = chart.Bitmap;

          var tempFile = new Java.IO.File(cache, "temp.jpg");
          using (FileStream fileStream = File.OpenWrite(tempFile.AbsolutePath))
          {
            _currentBitmap.Compress(Android.Graphics.Bitmap.CompressFormat.Jpeg, 85, fileStream);
          }

          var shareIntent = new Intent(Intent.ActionSend);
          shareIntent.PutExtra(Intent.ExtraStream, Android.Net.Uri.FromFile(tempFile));
          shareIntent.PutExtra(Intent.ExtraText, "Chart created with TeeChart for Xamarin.Android by www.steema.com");//"Some text - appears in tweets, not on facebook");
          shareIntent.SetType("image/jpeg");

          StartActivity(Intent.CreateChooser(shareIntent, "Share Image"));

          return true;
        case Android.Resource.Id.Home:
          NavUtils.NavigateUpFromSameTask(this);
          break;
      }

      return base.OnOptionsItemSelected(item);      
    }
    
    void DoExport()
    {
      ////TO-DO
      //Intent sendIntent = new Intent(Intent.ActionSend);

      ////Export implementation missing
      //var image = chart.getExport().getImage()
      //    .image(chart.Width, chart.Height);

      //var file = new Java.IO.File("/sdcard/teechart.png");
      //var stream = new Java.IO.FileOutputStream(file);



      //image.Save(stream);
      //stream.Flush();
      //stream.Close();

      //sendIntent.Type = "image/png";
      //sendIntent.PutExtra(Intent.ExtraStream, Uri.parse("file:///sdcard/teechart.png"));

      //StartActivity(Intent.CreateChooser(sendIntent, "Export"));
    }

    void toast(string text)
    {
      Toast
          .MakeText(this, text, ToastLength.Short)
          .Show();
    }
  }
}