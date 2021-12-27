
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace TeeChartAndMonoAndroid1
{
  [Activity(Label = "TeeChart for Xamarin.Android", MainLauncher = true, Icon = "@drawable/icon", Theme="@android:style/Theme.NoTitleBar")]
  public class Activity1 : TabActivity
  {    
    protected override void OnCreate(Bundle bundle)
    {
      base.OnCreate(bundle);
      SetContentView(Resource.Layout.Main);

      TabHost.TabSpec spec;     // Resusable TabSpec for each tab  
      Intent intent;            // Reusable Intent for each tab  

      // Create an Intent to launch an Activity for the tab (to be reused)  
      intent = new Intent(this, typeof(MultiChart));
      intent.AddFlags(ActivityFlags.NewTask);

      spec = TabHost.NewTabSpec("Combined chart");
      spec.SetIndicator("Multi-chart");
      // Initialize a TabSpec for each tab and add it to the TabHost  
      spec.SetContent(intent);
      TabHost.AddTab(spec);

      // Do the same for the other tabs  
      intent = new Intent(this, typeof(Classic));
      intent.AddFlags(ActivityFlags.NewTask);

      spec = TabHost.NewTabSpec("Classic zoom chart");
      spec.SetIndicator("Area series");
      spec.SetContent(intent);
      TabHost.AddTab(spec);
      
      intent = new Intent(this, typeof(Pie2D));
      intent.AddFlags(ActivityFlags.NewTask);

      spec = TabHost.NewTabSpec("2D Pie chart");
      spec.SetIndicator("2D Pie");
      spec.SetContent(intent);
      TabHost.AddTab(spec);

      intent = new Intent(this, typeof(BatteryGauge));
      intent.AddFlags(ActivityFlags.NewTask);

      spec = TabHost.NewTabSpec("Battery level");
      spec.SetIndicator("Battery");
      spec.SetContent(intent);
      TabHost.AddTab(spec);

      TabHost.CurrentTab = 0;
    }
  }
}

