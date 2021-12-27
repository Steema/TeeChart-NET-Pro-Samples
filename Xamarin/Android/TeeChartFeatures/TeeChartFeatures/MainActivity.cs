using System;
using Android;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.Transitions;
using Android.Support.V4.Content;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using TeeChartFeatures.Model;
using TeeChartFeatures.ViewModel;

namespace TeeChartFeatures
{
    [Activity(Label = "@string/app_name", Icon = "@drawable/iconBaseSteema", RoundIcon = "@drawable/icon_rounded2_steema_weather", Theme = "@style/AppTheme.NoActionBar", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class MainActivity : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {

        #region APP INFO

        public static int deviceWidth;
        public static int deviceHeight;

        #endregion

        #region EXTRA BUNDLE

        public const string CHART_TYPE = "1000";

        #endregion

        MainItemsViewModel groupStyles;
        MainItemsAdapter groupStylesAdapter;
        RecyclerView vRecyclerViewer;
        LinearLayoutManager linearLayoutManager;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var metrics = Resources.DisplayMetrics;
            deviceWidth = metrics.WidthPixels;
            deviceHeight = metrics.HeightPixels;
            // RecyclerViewer items
            groupStyles = new MainItemsViewModel();

            SetContentView(Resource.Layout.activity_main);

            // Get RecyclerViewer view
            vRecyclerViewer = (RecyclerView)FindViewById(Resource.Id.homeRecyclerView);

            // Get toolbar and setActionBar
            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            AppBarLayout appBarLayout = FindViewById<AppBarLayout>(Resource.Id.topbarLayout);

            vRecyclerViewer.AddOnScrollListener(new MainItemsScroll(appBarLayout));

            // Set layoutManager to RecyclerViewer  
            linearLayoutManager = new LinearLayoutManager(this);
            vRecyclerViewer.SetLayoutManager(linearLayoutManager);

            // RecyclerViewer adapter and setAdapter
            groupStylesAdapter = new MainItemsAdapter(groupStyles);
            groupStylesAdapter.ItemClick += OnItemClick;
            vRecyclerViewer.SetAdapter(groupStylesAdapter);


            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(this, drawer, toolbar, Resource.String.navigation_drawer_open, Resource.String.navigation_drawer_close);
            drawer.AddDrawerListener(toggle);
            toggle.SyncState();

            NavigationView navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            navigationView.SetNavigationItemSelectedListener(this);
            navigationView.Menu.GetItem(0).SetChecked(true);

            Window.SetStatusBarColor(Utils.GetResources.GetColor(this, Resource.Color.colorPrimaryOver));

        }

        public override void OnBackPressed()
        {
            Android.Support.V4.Widget.DrawerLayout drawer = FindViewById<Android.Support.V4.Widget.DrawerLayout>(Resource.Id.drawer_layout);
            if(drawer.IsDrawerOpen(GravityCompat.Start))
            {
                drawer.CloseDrawer(GravityCompat.Start);
            }
            else
            {
                base.OnBackPressed();
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (itemSelected) return false;
            int id = item.ItemId;
            itemSelected = true;
            if (id == Resource.Id.search_toolbar_item)
            {
                Android.Content.Intent intent = new Android.Content.Intent(this, typeof(ActivitySearch));
                StartActivity(intent);
                OverridePendingTransition(Resource.Animation.abc_slide_in_bottom, Resource.Animation.fade_out);
            }

            return base.OnOptionsItemSelected(item);
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            if (itemSelected) return false;
            int id = item.ItemId;
            itemSelected = true;

            if (id == Resource.Id.nav_home)
            {
                return false;
            }
            else if(id == Resource.Id.nav_web)
            {
                Android.Net.Uri uri = Android.Net.Uri.Parse("https://www.steema.com");
                Intent intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);
            }
            else if (id == Resource.Id.nav_github)
            {
                Android.Net.Uri uri = Android.Net.Uri.Parse("https://github.com/Steema");
                Intent intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);
            }
            else if (id == Resource.Id.nav_documentation)
            {
                Android.Net.Uri uri = Android.Net.Uri.Parse("http://www.teechart.net/docs/TeeChartNETAndroidTutorials.htm");
                Intent intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);
            }
            else if (id == Resource.Id.nav_aboutus)
            {
                Intent intent = new Intent(this, typeof(ActivityAboutUs));
                StartActivity(intent);
            }

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            drawer.CloseDrawer(GravityCompat.Start);
            return true;
        }

        private bool itemSelected = false;
        void OnItemClick(object sender, int position)
        {
            if(!itemSelected)
            {
                itemSelected = true;
                int nElement = position + 1;
                Intent intent = new Intent(this, typeof(ActivityCharts));
                intent.PutExtra(CHART_TYPE, GetChartGroupEnum(nElement).ToString());
                StartActivity(intent);
            }            
        }

        private Enums.ChartGroupEnum GetChartGroupEnum(int position)
        {
            Enums.ChartGroupEnum chartGroupEnum = default(Enums.ChartGroupEnum);
            switch(position)
            {
                case 1:
                    chartGroupEnum = Enums.ChartGroupEnum.StandardCharts;
                    break;
                case 2:
                    chartGroupEnum = Enums.ChartGroupEnum.ProCharts;
                    break;
                case 3:
                    chartGroupEnum = Enums.ChartGroupEnum.CircularGauge;
                    break;
                case 4:
                    chartGroupEnum = Enums.ChartGroupEnum.Maps;
                    break;
                    /*
                case 5:
                    chartGroupEnum = Enums.ChartGroupEnum.TreeMap;
                    break;
                    */
                case 5:
                    chartGroupEnum = Enums.ChartGroupEnum.KnobGauge;
                    break;
                case 6:
                    chartGroupEnum = Enums.ChartGroupEnum.Clock;
                    break;
                case 7:
                    chartGroupEnum = Enums.ChartGroupEnum.Organizational;
                    break;
                case 8:
                    chartGroupEnum = Enums.ChartGroupEnum.NumericGauge;
                    break;
                case 9:
                    chartGroupEnum = Enums.ChartGroupEnum.LinearGauge;
                    break;
                case 10:
                    chartGroupEnum = Enums.ChartGroupEnum.Calendar;
                    break;
                case 11:
                    chartGroupEnum = Enums.ChartGroupEnum.TagCloud;
                    break;
                case 12:
                    chartGroupEnum = Enums.ChartGroupEnum.StandardFunctions;
                    break;
            }
            return chartGroupEnum;
        }

        protected override void OnStart()
        {
            base.OnStart();
            itemSelected = false;
        }

        #region RECVIEW EXTENSIONS

        /// <summary>
        /// Main class adapter for recyclerView
        /// </summary>
        private class MainItemsAdapter : Android.Support.V7.Widget.RecyclerView.Adapter
        {

            private MainItemsViewModel _groupStyles;
            public event EventHandler<int> ItemClick;

            public MainItemsAdapter(MainItemsViewModel groupStyles)
            {

                _groupStyles = groupStyles;

            }

            public override int ItemCount => _groupStyles.Items.Length;

            public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
            {
                MainItemsHolder viewHolder = holder as MainItemsHolder;
                viewHolder.Image.SetImageResource(_groupStyles.Items[position].Image);
                viewHolder.Title.Text = _groupStyles.Items[position].Title;
                viewHolder.Description.Text = _groupStyles.Items[position].Description;
            }

            public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
            {
                View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.items_main_layout, parent, false);
                MainItemsHolder holder = new MainItemsHolder(itemView, OnClick);
                return holder;
            }

            void OnClick(int position)
            {
                if (ItemClick != null)
                    ItemClick(this, position);
            }

        }

        /// <summary>
        /// Main class holder for recyclerView
        /// </summary>
        private class MainItemsHolder : Android.Support.V7.Widget.RecyclerView.ViewHolder
        {

            public ImageView Image { get; set; }
            public TextView Title { get; set; }
            public TextView Description { get; set; }

            private Action<int> _listener;
            private Android.Support.V7.Widget.CardView _itemView;

            public MainItemsHolder(View itemView, Action<int> listener) : base(itemView)
            {

                Image = itemView.FindViewById<ImageView>(Resource.Id.cardViewImage);
                Title = itemView.FindViewById<TextView>(Resource.Id.cardViewTitle);
                Description = itemView.FindViewById<TextView>(Resource.Id.cardViewDescription);

                //itemView.Click += (sender, e) => listener(base.LayoutPosition);

                itemView.Click += OnClick;

                _listener = listener;
                _itemView = (Android.Support.V7.Widget.CardView)itemView.FindViewById(Resource.Id.cardViewGroupStyles);

            }

            void OnClick(object sender, EventArgs e)
            {
                _listener(base.LayoutPosition);
            }

        }

        /// <summary>
        /// Main class scrollListener for recyclerView
        /// </summary>
        private class MainItemsScroll : Android.Support.V7.Widget.RecyclerView.OnScrollListener
        {

            private static int SCROLL_DIRECTION_UP = -1;
            private Android.Support.Design.Widget.AppBarLayout _appBarLayout;

            public MainItemsScroll(Android.Support.Design.Widget.AppBarLayout barLayout)
            {
                _appBarLayout = barLayout;
            }

            public override void OnScrolled(RecyclerView recyclerView, int dx, int dy)
            {

                if (recyclerView.CanScrollVertically(SCROLL_DIRECTION_UP))
                {
                    _appBarLayout.Elevation = 8;
                }
                else
                {
                    _appBarLayout.Elevation = 0;
                }

            }

        }

        #endregion

    }
}

