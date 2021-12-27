using Android.App;
using Android.Content;
using Android.Net;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Widget;

namespace MonoAndroidDemo
{
  [Activity(Name = "com.steema.teechart.xamarin.android.Activity1", Label = "Xamarin.Android Demo", MainLauncher = true, Icon = "@drawable/icon")]
  public class Activity1 : BaseActivity
  {

    DrawerLayout drawerLayout;
    NavigationView navigationView;

    protected override int LayoutResource
    {
      get
      {
        return Resource.Layout.Main;
      }
    }

    protected override void OnCreate(Bundle savedInstanceState)
    {
      base.OnCreate(savedInstanceState);

      SupportActionBar.Title = "TeeChart";

      drawerLayout = this.FindViewById<DrawerLayout>(Resource.Id.drawer_layout);

      //Set hamburger items menu
      SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.ic_menu);

      //setup navigation view
      navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);

      //handle navigation
      navigationView.NavigationItemSelected += (sender, e) =>
      {
        switch (e.MenuItem.ItemId)
        {
          case Resource.Id.nav_newChart:
            //To-Do
            break;
          case Resource.Id.nav_openChart:
            //To-Do
            break;
          case Resource.Id.nav_web:
            StartActivity(new Intent(Intent.ActionView, Uri.Parse("https://www.steema.com/")));
            break;
          case Resource.Id.nav_about:
            StartActivity(new Intent(this, typeof(About)));
            break;
          case Resource.Id.nav_mail:
            StartActivity(new Intent(Intent.ActionView, Uri.Parse("mailto:info@steema.com")));
            break;
          case Resource.Id.nav_call:
            StartActivity(new Intent(Intent.ActionView, Uri.Parse("tel:+34 972 218 797")));
            break;
        }

        drawerLayout.CloseDrawers();
      };

      var seriesAdapter = new SeriesAdapter(this);
      var seriesListView = FindViewById<ListView>(Resource.Id.seriesListView);
      seriesListView.DrawingCacheEnabled = false;
      seriesListView.Adapter = seriesAdapter;
      //seriesListView.ItemClick += new EventHandler<ItemEventArgs>(seriesListView_ItemClick); //4.0.6
      seriesListView.ItemClick += seriesListView_ItemClick;  //4.1.1
    }

    //void seriesListView_ItemClick(object sender, ItemEventArgs e) //4.0.6
    void seriesListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)  //4.1.1
    {      
      var myIntent = new Intent(e.View.Context, typeof(ChartView));
		  myIntent.PutExtra("SeriesPosition", e.Position);
      StartActivityForResult(myIntent, 1);      
    }

    public override bool OnOptionsItemSelected(IMenuItem item)
    {
      switch (item.ItemId)
      {
        case Android.Resource.Id.Home:
          drawerLayout.OpenDrawer(Android.Support.V4.View.GravityCompat.Start);
          return true;
      }
      return base.OnOptionsItemSelected(item);
    }
  }
}

