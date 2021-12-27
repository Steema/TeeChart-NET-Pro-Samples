using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace TeeChartFeatures
{
    [Activity(ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait, Theme = "@style/AppTheme.NoActionBar")]
    public class ActivityAboutUs : AppCompatActivity
    {
        Android.Support.V7.Widget.Toolbar toolbar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_about_us);

            toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);

            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);

            TextView textViewTitle = FindViewById<TextView>(Resource.Id.txtViewTitleAboutUs);
            textViewTitle.Typeface = Android.Graphics.Typeface.CreateFromAsset(Assets, "GoogleSans-Medium.ttf");

            ScrollView scrollView = FindViewById<ScrollView>(Resource.Id.scrollView);
            scrollView.SetOnScrollChangeListener(new ExtendOnScrollChangeListener(FindViewById<Android.Support.V7.Widget.CardView>(Resource.Id.cardViewBarLayout)));

            Button btnFacebook = FindViewById<Button>(Resource.Id.btnFacebook);
            Button btnTwitter = FindViewById<Button>(Resource.Id.btnTwitter);
            Button btnGooglePlus = FindViewById<Button>(Resource.Id.btnGooglePlus);
            Button btnLinkedin = FindViewById<Button>(Resource.Id.btnLinkedin);
            //Button btnContactUs = FindViewById<Button>(Resource.Id.btnContactUs);

            btnFacebook.Click += BtnSocial_Click;
            btnTwitter.Click += BtnSocial_Click;
            btnGooglePlus.Click += BtnSocial_Click;
            btnLinkedin.Click += BtnSocial_Click;
            //btnContactUs.Click += BtnContactUs_Click;

            // Status Window TopColor
            Window.SetStatusBarColor(Utils.GetResources.GetColor(this, Resource.Color.colorPrimaryOver));
        }

        /*
        private void BtnContactUs_Click(object sender, EventArgs e)
        {
            Intent emailIntent = new Intent(Intent.ActionSend);

            emailIntent.SetData(Android.Net.Uri.Parse("mailto:"));
            emailIntent.SetType("");
            emailIntent.PutExtra(Intent.ExtraEmail, "info@steema.com");

            try
            {
                StartActivity(Intent.CreateChooser(emailIntent, "Send mail..."));
                Finish();
                Android.Util.Log.Info("Finished sending email...", "");
            }
            catch (Android.Content.ActivityNotFoundException ex)
            {
                Toast.MakeText(Application.Context, "Error, we can't open it.", ToastLength.Short).Show();
            }
        }
        */

        private void BtnSocial_Click(object sender, EventArgs e)
        {
            Button btnSocial = sender as Button;
            String url;
            Intent intent = new Intent(Intent.ActionView);
            
            switch (btnSocial.Id)
            {
                case Resource.Id.btnFacebook:
                    url = "https://www.facebook.com/SteemaSoftware";
                    break;
                case Resource.Id.btnTwitter:
                    url = "https://twitter.com/SteemaSoftware";
                    break;
                case Resource.Id.btnGooglePlus:
                    url = "https://plus.google.com/+Steema/posts";
                    break;
                default:
                    url = "https://www.linkedin.com/company/steema-software";
                    break;
            }
            intent.SetData(Android.Net.Uri.Parse(url));
            StartActivity(intent);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (item.ItemId == Android.Resource.Id.Home) { base.OnBackPressed(); return true; }
            return base.OnOptionsItemSelected(item);
        }

        private class ExtendOnScrollChangeListener : Java.Lang.Object, View.IOnScrollChangeListener
        {
            private static int SCROLL_DIRECTION_UP = -1;
            Android.Support.V7.Widget.CardView cardView;
            public ExtendOnScrollChangeListener(Android.Support.V7.Widget.CardView cardViewBarLayout)
            {
                cardView = cardViewBarLayout;
            }
            public void OnScrollChange(View v, int scrollX, int scrollY, int oldScrollX, int oldScrollY)
            {
                if (v.CanScrollVertically(SCROLL_DIRECTION_UP))
                {
                    cardView.Elevation = 8;
                }
                else
                {
                    cardView.Elevation = 0;
                }
            }
        }

    }

}