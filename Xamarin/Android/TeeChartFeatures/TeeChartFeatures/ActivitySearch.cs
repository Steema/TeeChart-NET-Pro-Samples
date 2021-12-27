using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TeeChartFeatures.ViewModel;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;
using Android.Text;
using Android.Views.InputMethods;
using Java.Lang;
using TeeChartFeatures.Model;
using TeeChartFeatures.Utils;

namespace TeeChartFeatures
{
    [Activity(Theme = "@style/AppTheme.NoActionBar", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class ActivitySearch : AppCompatActivity
    {

        #region EXTRA BUNDLE

        public const string CHART_NAME = "2000";

        #endregion

        private SearchItemsViewModel _searchViewModel;
        private SearchItemsAdapter _searchItemsAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_search);
            // Set statusBarColor
            Window.SetStatusBarColor(Utils.GetResources.GetColor(this, Resource.Color.colorPrimaryOver));
            // Get layoutManager, RecyclerViewer and initializeItems
            LinearLayoutManager linearLayoutManager = new LinearLayoutManager(this);
            RecyclerView recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerViewSearch);
            _searchViewModel = new SearchItemsViewModel(Application.Context);
            // Set layoutManager and adapter
            recyclerView.SetLayoutManager(linearLayoutManager);
            _searchItemsAdapter = new SearchItemsAdapter(Application.Context, _searchViewModel);
            recyclerView.SetAdapter(_searchItemsAdapter);
            // BackButton click onBackButtonPressed
            ImageButton backButton = FindViewById<ImageButton>(Resource.Id.backButton);
            backButton.Click += BackButton_Click;
            // ImageButton clear editText
            ImageButton cancelSearchButton = FindViewById<ImageButton>(Resource.Id.search_clear_text);
            cancelSearchButton.Click += CancelSearchButton_Click;
            // EditText search action
            EditText editText = FindViewById<EditText>(Resource.Id.edt_search_chart);
            editText.SetOnEditorActionListener(new ExtendOnEditorActionListener());
            editText.AddTextChangedListener(new ExtendOnTextChangedListener(_searchItemsAdapter, _searchViewModel.Items, cancelSearchButton));
        }

        /// <summary>
        /// Volver a la pantalla anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            OnBackPressed();
        }
        /// <summary>
        /// Eliminar el texto del editText
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelSearchButton_Click(object sender, EventArgs e)
        {
            EditText editText = FindViewById<EditText>(Resource.Id.edt_search_chart);
            editText.Text = "";
        }
        /// <summary>
        /// Animación cuando vuelves a la actividad anterior
        /// </summary>
        public override void OnBackPressed()
        {
            base.OnBackPressed();
            OverridePendingTransition(Resource.Animation.fade_in, Resource.Animation.abc_slide_out_bottom);
        }

        private class SearchItemsAdapter : RecyclerView.Adapter
        {

            private SearchItemsViewModel _items;
            private Context _context;

            public SearchItemsAdapter(Context context, SearchItemsViewModel items)
            {
                _items = items;
                _context = context;
            }

            public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
            {
                SearchItemsHolder searchItemsHolder = holder as SearchItemsHolder;
                SearchItemsModel item = _items.Items[position];
                searchItemsHolder.Name.Text = item.Name;
                searchItemsHolder.GroupStyles.Text = item.Group;
            }

            public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
            {
                View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.items_search_layout, parent, false);
                SearchItemsHolder holder = new SearchItemsHolder(itemView);
                itemView.SetOnClickListener(new ExtendOnViewItemClickListener(_context));
                return holder;
            }

            public void FilterItems(List<SearchItemsModel> items)
            {
                _items.Items = items;
                NotifyDataSetChanged();
            }

            public override int ItemCount => _items.ItemsCount;
        }

        private class SearchItemsHolder : RecyclerView.ViewHolder
        {

            public TextView Name;
            public TextView GroupStyles;
            public View View;

            public SearchItemsHolder(View itemView) : base(itemView)
            {
                Name = itemView.FindViewById<TextView>(Resource.Id.titleItemSearch);
                GroupStyles = itemView.FindViewById<TextView>(Resource.Id.groupTitleItemSearch);
            }

        }

        private class ExtendOnViewItemClickListener : Java.Lang.Object, View.IOnClickListener
        {
            private string _titleItem;
            private string _groupItem;
            private Context _context;
            public ExtendOnViewItemClickListener(Context context)
            {
                this._context = context;
            }
            public void OnClick(View v)
            {
                _titleItem = v.FindViewById<TextView>(Resource.Id.titleItemSearch).Text;
                _groupItem = v.FindViewById<TextView>(Resource.Id.groupTitleItemSearch).Text;
                Intent intent = new Intent(_context, typeof(ActivitySoloChart));
                intent.PutExtra(ActivitySearch.CHART_NAME, _titleItem);
                _context.StartActivity(intent);
            }

            private Enums.ChartGroupEnum GetGroupStyles(string groupItem)
            {
                Enums.ChartGroupEnum chartGroupEnum = default(Enums.ChartGroupEnum);
                if(groupItem == GetResources.GetString(Resource.String.titleStdCharts))
                    chartGroupEnum = Enums.ChartGroupEnum.StandardCharts;
                else if(groupItem == GetResources.GetString(Resource.String.titleProCharts))
                    chartGroupEnum = Enums.ChartGroupEnum.ProCharts;
                else if (groupItem == GetResources.GetString(Resource.String.titleCircularGauge))
                    chartGroupEnum = Enums.ChartGroupEnum.CircularGauge;
                else if (groupItem == GetResources.GetString(Resource.String.titleMaps))
                    chartGroupEnum = Enums.ChartGroupEnum.Maps;
                else if (groupItem == GetResources.GetString(Resource.String.titleTreeMap))
                    chartGroupEnum = Enums.ChartGroupEnum.TreeMap;
                else if (groupItem == GetResources.GetString(Resource.String.titleKnobGauge))
                    chartGroupEnum = Enums.ChartGroupEnum.KnobGauge;
                else if (groupItem == GetResources.GetString(Resource.String.titleClock))
                    chartGroupEnum = Enums.ChartGroupEnum.Clock;
                else if (groupItem == GetResources.GetString(Resource.String.titleOrganizational))
                    chartGroupEnum = Enums.ChartGroupEnum.Organizational;
                else if (groupItem == GetResources.GetString(Resource.String.titleNumericGauge))
                    chartGroupEnum = Enums.ChartGroupEnum.NumericGauge;
                else if (groupItem == GetResources.GetString(Resource.String.titleLinearGauge))
                    chartGroupEnum = Enums.ChartGroupEnum.LinearGauge;
                else if (groupItem == GetResources.GetString(Resource.String.titleCalendar))
                    chartGroupEnum = Enums.ChartGroupEnum.Calendar;
                else if (groupItem == GetResources.GetString(Resource.String.titleTagCloud))
                    chartGroupEnum = Enums.ChartGroupEnum.TagCloud;
                else
                    chartGroupEnum = Enums.ChartGroupEnum.StandardFunctions;

                return chartGroupEnum;
            }
        }

        private class ExtendOnEditorActionListener : Java.Lang.Object, TextView.IOnEditorActionListener
        {
            public bool OnEditorAction(TextView v, [GeneratedEnum] ImeAction actionId, KeyEvent e)
            {
                if (actionId == ImeAction.Search)
                {
                    //performSearch();
                    return true;
                }
                return false;
            }
        }

        private class ExtendOnTextChangedListener : Java.Lang.Object, ITextWatcher
        {

            private SearchItemsAdapter _adapter;
            private List<SearchItemsModel> _items;
            private ImageButton _cancelButton;

            public ExtendOnTextChangedListener(SearchItemsAdapter adapter, List<SearchItemsModel> items, ImageButton cancelButton)
            {
                _adapter = adapter;
                _items = items;
                _cancelButton = cancelButton;
            }

            public void AfterTextChanged(IEditable s)
            {
                _cancelButton.Visibility = (s.ToString() == "") ?  ViewStates.Gone : ViewStates.Visible;
            }

            public void BeforeTextChanged(ICharSequence s, int start, int count, int after)
            {
                
            }

            public void OnTextChanged(ICharSequence s, int start, int before, int count)
            {
                Filter(s.ToString());
            }

            private void Filter(string searchText)
            {
                List<SearchItemsModel> searchItems = new List<SearchItemsModel>();
                foreach(SearchItemsModel item in _items)
                {
                    if (item.Name.ToLower().Contains(searchText.ToLower())) searchItems.Add(item);
                }
                _adapter.FilterItems(searchItems);
            }

        }

    }
}