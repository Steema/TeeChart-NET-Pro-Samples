using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Hardware;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Util;
using Android.Views;
using Android.Widget;
using Java.Lang;
using TeeChartFeatures.Enums;
using TeeChartFeatures.Fragments;
using TeeChartFeatures.Model;
using TeeChartFeatures.Utils;
using TeeChartFeatures.ViewModel;

namespace TeeChartFeatures
{
    [Activity(Theme = "@style/AppTheme.NoActionBar", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class ActivityCharts : AppCompatActivity
    {

        private TabLayout tabLayout;
        private BottomSheetDialogFragment bottomNavDrawerFragment;
        public ChartGroupEnum chartGroup;
        private ChartTabViewModel chartTabViewModel;
        ViewPager viewPager;
        private IMenu menu;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_display_chart);

            // GetExtra Bundle
            System.Enum.TryParse(Intent.GetStringExtra(MainActivity.CHART_TYPE), out ChartGroupEnum chartGroup);
            this.chartGroup = chartGroup;

            // Create ChartTabViewModel for data
            chartTabViewModel = new ChartTabViewModel(chartGroup);

            // Set toolbar
            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = chartTabViewModel.TitleGroup;

            // Set HomeBack Enabled
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);

            // TabLayout, Control ViewPager and adapter
            LinearLayout parentViewPagerLayout = FindViewById<LinearLayout>(Resource.Id.parentViewPagerLayout);
            viewPager = new ExtendViewPager(this);
            ViewPagerAdapter viewPagerAdapter = new ViewPagerAdapter(SupportFragmentManager, chartTabViewModel);
            viewPager.Adapter = viewPagerAdapter;
            viewPager.AddOnPageChangeListener(new ExtendOnChangedPageViewPager(this));
            parentViewPagerLayout.AddView(viewPager);

            tabLayout = (Android.Support.Design.Widget.TabLayout)FindViewById(Resource.Id.tabLayout);
            tabLayout.SetupWithViewPager(viewPager);
            
            // Status Window TopColor
            Window.SetStatusBarColor(Utils.GetResources.GetColor(this, Resource.Color.colorPrimaryOver));
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (item.ItemId == Android.Resource.Id.Home) { base.OnBackPressed(); return true; }
            else if (item.ItemId == Resource.Id.action_show_tcharts)
            {
                bottomNavDrawerFragment = BottomNavigationDrawerFragment.NewInstance(chartTabViewModel.Items[viewPager.CurrentItem]);
                bottomNavDrawerFragment.Show(SupportFragmentManager, "");
                return true;
            }
            return base.OnOptionsItemSelected(item);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            this.menu = menu;
            this.MenuInflater.Inflate(Resource.Menu.menu_charts, menu);
            if (chartTabViewModel.Items[0].HaveExtraCharts) menu.SetGroupVisible(0, true);
            else menu.SetGroupVisible(0, false);
            return true; 
        }

        private class ExtendViewPager : ViewPager
        {
            public ExtendViewPager(Context context) : base(context)
            {
                LinearLayout.LayoutParams layoutParams = new LinearLayout.LayoutParams(
                    LayoutParams.MatchParent,
                    LayoutParams.WrapContent,
                    1);
                Id = Resource.Id.viewPager;
                /*CoordinatorLayout.LayoutParams cLayoutParams =
                            (CoordinatorLayout.LayoutParams)LayoutParameters;
                cLayoutParams.Behavior = new AppBarLayout.ScrollingViewBehavior();
                */
                this.RequestLayout();
                
            }

            public override bool OnTouchEvent(MotionEvent e)
            {
                return false;
            }

            public override bool OnInterceptTouchEvent(MotionEvent ev)
            {
                return false;
            }

        }

        private class ExtendOnChangedPageViewPager : Java.Lang.Object, ViewPager.IOnPageChangeListener
        {
            ActivityCharts activity;
            public ExtendOnChangedPageViewPager(ActivityCharts activity)
            {
                this.activity = activity;
            }

            public void OnPageScrolled(int position, float positionOffset, int positionOffsetPixels)
            {
                
            }

            public void OnPageScrollStateChanged(int state)
            {
                
            }

            public void OnPageSelected(int position)
            {
                if(activity.chartTabViewModel.Items[position].HaveExtraCharts) activity.menu.SetGroupVisible(0, true);
                else activity.menu.SetGroupVisible(0, false);
                if(activity.chartTabViewModel.Items[position].ChartGroup == ChartGroupEnum.ProCharts && activity.chartTabViewModel.Items[position].ChartType == ChartTypeEnum.SpeedTime)
                {
                    activity.chartTabViewModel.Items[position].TChart = null;
                }
            }

        }

        private class ViewPagerAdapter : FragmentPagerAdapter
        {
            Android.Support.V4.App.FragmentManager _fragmentManager;
            ChartTabViewModel _chartTabViewModel;
            public ViewPagerAdapter(Android.Support.V4.App.FragmentManager fragmentManager, ChartTabViewModel dades) : base(fragmentManager)
            {
                _fragmentManager = fragmentManager;
                _chartTabViewModel = dades;
            }
            public override int Count
            {
                get { return _chartTabViewModel.Count; }
            }

            public override Android.Support.V4.App.Fragment GetItem(int position)
            {
                Android.Support.V4.App.Fragment chartTabFragment = ChartTabFragment.NewInstance(_chartTabViewModel[position]);

                return chartTabFragment;
            }

            public override ICharSequence GetPageTitleFormatted(int position)
            {
                ICharSequence text = new Java.Lang.String(_chartTabViewModel.Items[position].Title);
                return text;
            }

        }

    }

        /*
        public class ExtendOnScrollSheet : Java.Lang.Object, NestedScrollView.IOnScrollChangeListener
        {

            AppCompatActivity _context;

            public ExtendOnScrollSheet(AppCompatActivity context) { _context = context; }

            public void OnScrollChange(NestedScrollView v, int scrollX, int scrollY, int oldScrollX, int oldScrollY)
            {
                if (scrollY == v.GetChildAt(0).MeasuredHeight - v.MeasuredHeight)
                {

                    BottomNavigationDrawerFragment bottomNavDrawerFragment = new BottomNavigationDrawerFragment();
                    bottomNavDrawerFragment.Show(_context.SupportFragmentManager, bottomNavDrawerFragment.Tag);

                }
            }
        }
        */
}