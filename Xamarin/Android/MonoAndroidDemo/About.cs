using System;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace MonoAndroidDemo
{
  [Activity(Label = "About", ParentActivity = typeof(Activity1))]
  [MetaData("android.support.PARENT_ACTIVITY", Value = "com.steema.teechart.xamarin.android.Activity1")]
  public class About : BaseActivity
  {
    ImageView ivTwitter, ivFacebook, ivGooglePlus;

    protected override int LayoutResource
    {
      get
      {
        return Resource.Layout.about;
      }
    }
    protected override void OnCreate(Bundle savedInstanceState)
    {
      base.OnCreate(savedInstanceState);

      /*if (Toolbar != null)
      {
        SupportActionBar.Elevation = 0;
        SupportActionBar.SetTitle(Resource.String.itAbout);
      }*/

      ivFacebook = FindViewById<ImageView>(Resource.Id.ivFacebook);
      ivTwitter = FindViewById<ImageView>(Resource.Id.ivTwitter);
      ivGooglePlus = FindViewById<ImageView>(Resource.Id.ivGoolePlus);
      ivFacebook.Click += Image_Click;
      ivTwitter.Click += Image_Click;
    }

    void Image_Click(object sender, EventArgs e)
    {
      if (sender == ivFacebook)
      {
        StartActivity(new Intent(Intent.ActionView, Android.Net.Uri.Parse("https://www.facebook.com/SteemaSoftware")));
      }
      else if (sender == ivFacebook)
      {
        StartActivity(new Intent(Intent.ActionView, Android.Net.Uri.Parse("https://twitter.com/SteemaSoftware")));
      }
      else if (sender == ivGooglePlus)
      {
        StartActivity(new Intent(Intent.ActionView, Android.Net.Uri.Parse("https://plus.google.com/+Steema")));
      }
    }

    public override bool OnOptionsItemSelected(IMenuItem item)
    {
      switch (item.ItemId)
      {
        case Android.Resource.Id.Home:
          Android.Support.V4.App.NavUtils.NavigateUpFromSameTask(this);
          break;
      }

      return base.OnOptionsItemSelected(item);
    }
  }
}