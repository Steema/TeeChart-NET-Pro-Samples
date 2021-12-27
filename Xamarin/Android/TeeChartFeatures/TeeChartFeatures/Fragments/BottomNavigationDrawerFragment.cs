using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using TeeChartFeatures.Enums;
using TeeChartFeatures.Model;

namespace TeeChartFeatures.Fragments
{
    public class BottomNavigationDrawerFragment : BottomSheetDialogFragment
    {

        public ChartTabModel ChartTabModel { get; set; }

        public static BottomSheetDialogFragment NewInstance(ChartTabModel chartTabModel)
        {
            Bundle bundle = new Bundle();
            BottomNavigationDrawerFragment fragmentBottomSheet = new BottomNavigationDrawerFragment();
            fragmentBottomSheet.ChartTabModel = chartTabModel;
            fragmentBottomSheet.Arguments = bundle;
            return fragmentBottomSheet;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            LinearLayout layout = (LinearLayout)LayoutInflater.Inflate(Resource.Layout.fragment_bottom_sheet, container, false);
            if (ChartTabModel.HaveExtraCharts)
            {
                int cantidadCharts = ChartTabModel.ExtraCharts.Length;
                for (int i = 0; i < cantidadCharts; i++)
                {
                    LinearLayout itemLayout = (LinearLayout)inflater.Inflate(Resource.Layout.item_layout_bottom_sheet, null, false);
                    (layout.GetChildAt(0) as LinearLayout).AddView(itemLayout);
                    Button btnTitleItem = itemLayout.FindViewById<Button>(Resource.Id.txtViewTitleItem);
                    btnTitleItem.Text = Enum.GetName(typeof(ChartTypeEnum), ChartTabModel.ExtraCharts[i]);
                    btnTitleItem.Click += BtnTitleItem_Click;
                }
            }
            return layout;
        }

        private void BtnTitleItem_Click(object sender, EventArgs e)
        {
            ChartTabModel.UpdateChartViewSeries((ChartTypeEnum)Enum.Parse(typeof(ChartTypeEnum), (sender as Button).Text));
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
        }

    }
}