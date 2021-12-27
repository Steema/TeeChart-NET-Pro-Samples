using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using TeeChartFeatures.Model;

namespace TeeChartFeatures.Fragments
{
    public class ChartTabFragment : Android.Support.V4.App.Fragment
    {

        #region EXTRA BUNDLE

        public const string CHART_TAB_MODEL = "2000";

        #endregion

        ChartTabModel chartTabModel;
        public ChartTabFragment() { }

        public static Android.Support.V4.App.Fragment NewInstance(ChartTabModel chartTabModel)
        {
            Bundle bundle = new Bundle();
            bundle.PutSerializable(CHART_TAB_MODEL, chartTabModel);
            ChartTabFragment tabChartFragment = new ChartTabFragment();
            tabChartFragment.Arguments = bundle;
            return tabChartFragment;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            chartTabModel = (ChartTabModel)Arguments.GetSerializable(CHART_TAB_MODEL);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            LinearLayout chartviewLayout = (LinearLayout)LayoutInflater.Inflate(Resource.Layout.chartview_layout, null);
            chartTabModel.InitializeChartView();
            chartviewLayout.AddView(chartTabModel.TChart);
            return chartviewLayout;
        }

        public override void OnDestroyView()
        {
            chartTabModel.TChart = null;
            base.OnDestroyView();
        }

        public override void OnDestroy()
        {
            base.OnDestroy();
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
        }

    }
}