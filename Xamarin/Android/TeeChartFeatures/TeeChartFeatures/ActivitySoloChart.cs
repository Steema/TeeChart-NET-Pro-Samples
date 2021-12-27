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
using Steema.TeeChart;
using TeeChartFeatures.Utils;
using TeeChartFeatures.ViewModel;

namespace TeeChartFeatures
{
    [Activity(ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class ActivitySoloChart : AppCompatActivity
    {
        private TChart _tChart;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            string chartName = Intent.GetStringExtra(ActivitySearch.CHART_NAME);

            SetContentView(Resource.Layout.activity_solo_chart);
            SupportActionBar.Title = chartName;

            // Set HomeBack Enabled
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);

            InitializeChartView(chartName);
        }

        private void InitializeChartView(string chartName)
        {
            if (chartName == GetResources.GetString(Resource.String.lineChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardCharts).FindChartByEnum(Enums.ChartTypeEnum.Line);
            else if (chartName == GetResources.GetString(Resource.String.interpolatingLineChartName))
            {
                ChartTabViewModel chartTabViewModel = new ChartTabViewModel(Enums.ChartGroupEnum.StandardCharts);
                chartTabViewModel.Items[0].UpdateChartViewSeries(Enums.ChartTypeEnum.InterpolatingLine);
                _tChart = chartTabViewModel.Items[0].TChart;
            }

            else if (chartName == GetResources.GetString(Resource.String.columnbarChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardCharts).FindChartByEnum(Enums.ChartTypeEnum.ColumnBar);
            else if (chartName == GetResources.GetString(Resource.String.barStylesChartName))
            {
                ChartTabViewModel chartTabViewModel = new ChartTabViewModel(Enums.ChartGroupEnum.StandardCharts);
                chartTabViewModel.Items[1].UpdateChartViewSeries(Enums.ChartTypeEnum.BarStyles);
                _tChart = chartTabViewModel.Items[1].TChart;
            }
            else if (chartName == GetResources.GetString(Resource.String.barGradientChartName))
            {
                ChartTabViewModel chartTabViewModel = new ChartTabViewModel(Enums.ChartGroupEnum.StandardCharts);
                chartTabViewModel.Items[1].UpdateChartViewSeries(Enums.ChartTypeEnum.BarGradient);
                _tChart = chartTabViewModel.Items[1].TChart;
            }
            else if (chartName == GetResources.GetString(Resource.String.areaChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardCharts).FindChartByEnum(Enums.ChartTypeEnum.Area);
            else if (chartName == GetResources.GetString(Resource.String.stackAreaChartName))
            {
                ChartTabViewModel chartTabViewModel = new ChartTabViewModel(Enums.ChartGroupEnum.StandardCharts);
                chartTabViewModel.Items[2].UpdateChartViewSeries(Enums.ChartTypeEnum.StackArea);
                _tChart = chartTabViewModel.Items[2].TChart;
            }
            else if (chartName == GetResources.GetString(Resource.String.pieChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardCharts).FindChartByEnum(Enums.ChartTypeEnum.Pie);
            else if (chartName == GetResources.GetString(Resource.String.multiPiesChartName))
            {
                ChartTabViewModel chartTabViewModel = new ChartTabViewModel(Enums.ChartGroupEnum.StandardCharts);
                chartTabViewModel.Items[3].UpdateChartViewSeries(Enums.ChartTypeEnum.MultiplePies);
                _tChart = chartTabViewModel.Items[3].TChart;
            }
            else if (chartName == GetResources.GetString(Resource.String.semiPieChartName))
            {
                ChartTabViewModel chartTabViewModel = new ChartTabViewModel(Enums.ChartGroupEnum.StandardCharts);
                chartTabViewModel.Items[3].UpdateChartViewSeries(Enums.ChartTypeEnum.SemiPie);
                _tChart = chartTabViewModel.Items[3].TChart;
            }
            else if (chartName == GetResources.GetString(Resource.String.fstlineChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardCharts).FindChartByEnum(Enums.ChartTypeEnum.FastLine);
            else if (chartName == GetResources.GetString(Resource.String.realTimeChartName))
            {
                ChartTabViewModel chartTabViewModel = new ChartTabViewModel(Enums.ChartGroupEnum.StandardCharts);
                chartTabViewModel.Items[4].UpdateChartViewSeries(Enums.ChartTypeEnum.RealTime);
                _tChart = chartTabViewModel.Items[4].TChart;
            }
            else if (chartName == GetResources.GetString(Resource.String.hAreaChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardCharts).FindChartByEnum(Enums.ChartTypeEnum.HorizontalArea);
            else if (chartName == GetResources.GetString(Resource.String.hBarChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardCharts).FindChartByEnum(Enums.ChartTypeEnum.HorizontalBar);
            else if (chartName == GetResources.GetString(Resource.String.hLineChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardCharts).FindChartByEnum(Enums.ChartTypeEnum.HorizontalLine);
            else if (chartName == GetResources.GetString(Resource.String.donutChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardCharts).FindChartByEnum(Enums.ChartTypeEnum.Donut);
            else if (chartName == GetResources.GetString(Resource.String.semiDonutChartName))
            {
                ChartTabViewModel chartTabViewModel = new ChartTabViewModel(Enums.ChartGroupEnum.StandardCharts);
                chartTabViewModel.Items[8].UpdateChartViewSeries(Enums.ChartTypeEnum.SemiDonut);
                _tChart = chartTabViewModel.Items[8].TChart;
            }
            else if (chartName == GetResources.GetString(Resource.String.bubbleChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardCharts).FindChartByEnum(Enums.ChartTypeEnum.Bubble);
            else if (chartName == GetResources.GetString(Resource.String.transBubbleChartName))
            {
                ChartTabViewModel chartTabViewModel = new ChartTabViewModel(Enums.ChartGroupEnum.StandardCharts);
                chartTabViewModel.Items[9].UpdateChartViewSeries(Enums.ChartTypeEnum.BubbleTransparent);
                _tChart = chartTabViewModel.Items[9].TChart;
            }
            else if (chartName == GetResources.GetString(Resource.String.ganttChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardCharts).FindChartByEnum(Enums.ChartTypeEnum.Gantt);
            else if (chartName == GetResources.GetString(Resource.String.shapeChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardCharts).FindChartByEnum(Enums.ChartTypeEnum.Shape);
            else if (chartName == GetResources.GetString(Resource.String.pointscatterChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardCharts).FindChartByEnum(Enums.ChartTypeEnum.PointScatter);
            else if (chartName == GetResources.GetString(Resource.String.arrowChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.ProCharts).FindChartByEnum(Enums.ChartTypeEnum.Arrow);
            else if (chartName == GetResources.GetString(Resource.String.polarChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.ProCharts).FindChartByEnum(Enums.ChartTypeEnum.Polar);
            else if (chartName == GetResources.GetString(Resource.String.polarBarChartName))
            {
                ChartTabViewModel chartTabViewModel = new ChartTabViewModel(Enums.ChartGroupEnum.ProCharts);
                chartTabViewModel.Items[1].UpdateChartViewSeries(Enums.ChartTypeEnum.PolarBar);
                _tChart = chartTabViewModel.Items[1].TChart;
            }
            else if (chartName == GetResources.GetString(Resource.String.radarChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.ProCharts).FindChartByEnum(Enums.ChartTypeEnum.Radar);
            else if (chartName == GetResources.GetString(Resource.String.pyramidChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.ProCharts).FindChartByEnum(Enums.ChartTypeEnum.Pyramid);
            else if (chartName == GetResources.GetString(Resource.String.invertedPyramidChartName))
            {
                ChartTabViewModel chartTabViewModel = new ChartTabViewModel(Enums.ChartGroupEnum.ProCharts);
                chartTabViewModel.Items[3].UpdateChartViewSeries(Enums.ChartTypeEnum.InvertedPyramid);
                _tChart = chartTabViewModel.Items[3].TChart;
            }
            else if (chartName == GetResources.GetString(Resource.String.candleChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.ProCharts).FindChartByEnum(Enums.ChartTypeEnum.Candle);
            else if (chartName == GetResources.GetString(Resource.String.histogramChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.ProCharts).FindChartByEnum(Enums.ChartTypeEnum.Histogram);
            else if (chartName == GetResources.GetString(Resource.String.horizHistogramChartName))
            {
                ChartTabViewModel chartTabViewModel = new ChartTabViewModel(Enums.ChartGroupEnum.ProCharts);
                chartTabViewModel.Items[5].UpdateChartViewSeries(Enums.ChartTypeEnum.HorizontalHistogram);
                _tChart = chartTabViewModel.Items[5].TChart;
            }
            else if (chartName == GetResources.GetString(Resource.String.errorChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.ProCharts).FindChartByEnum(Enums.ChartTypeEnum.Error);
            else if (chartName == GetResources.GetString(Resource.String.errorBarChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.ProCharts).FindChartByEnum(Enums.ChartTypeEnum.ErrorBar);
            else if (chartName == GetResources.GetString(Resource.String.funnelChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.ProCharts).FindChartByEnum(Enums.ChartTypeEnum.Funnel);
            else if (chartName == GetResources.GetString(Resource.String.smithChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.ProCharts).FindChartByEnum(Enums.ChartTypeEnum.Smith);
            else if (chartName == GetResources.GetString(Resource.String.bezierChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.ProCharts).FindChartByEnum(Enums.ChartTypeEnum.Bezier);
            else if (chartName == GetResources.GetString(Resource.String.highLowChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.ProCharts).FindChartByEnum(Enums.ChartTypeEnum.HighLow);
            else if (chartName == GetResources.GetString(Resource.String.speedTimeChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.ProCharts).FindChartByEnum(Enums.ChartTypeEnum.SpeedTime);
            else if (chartName == GetResources.GetString(Resource.String.waterfallChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.ProCharts).FindChartByEnum(Enums.ChartTypeEnum.Waterfall);
            else if (chartName == GetResources.GetString(Resource.String.volumeChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.ProCharts).FindChartByEnum(Enums.ChartTypeEnum.Volume);
            else if (chartName == GetResources.GetString(Resource.String.colorGridChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.ProCharts).FindChartByEnum(Enums.ChartTypeEnum.ColorGrid);
            else if (chartName == GetResources.GetString(Resource.String.circularGaugeChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.CircularGauge).FindChartByEnum(Enums.ChartTypeEnum.BasicCircGauge);
            else if (chartName == GetResources.GetString(Resource.String.carFuelChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.CircularGauge).FindChartByEnum(Enums.ChartTypeEnum.CarFuelCircGauge);
            else if (chartName == GetResources.GetString(Resource.String.customHandChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.CircularGauge).FindChartByEnum(Enums.ChartTypeEnum.CustomHandCircGauge);
            else if (chartName == GetResources.GetString(Resource.String.accelerationChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.CircularGauge).FindChartByEnum(Enums.ChartTypeEnum.AccelerationCircGauge);
            else if (chartName == GetResources.GetString(Resource.String.mapGISChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.Maps).FindChartByEnum(Enums.ChartTypeEnum.MapGIS);
            else if (chartName == GetResources.GetString(Resource.String.worldMapChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.Maps).FindChartByEnum(Enums.ChartTypeEnum.WorldMap);
            else if (chartName == GetResources.GetString(Resource.String.treeMapChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.TreeMap).FindChartByEnum(Enums.ChartTypeEnum.TreeMap);
            else if (chartName == GetResources.GetString(Resource.String.knobGaugeChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.KnobGauge).FindChartByEnum(Enums.ChartTypeEnum.BasicKnobGauge);
            else if (chartName == GetResources.GetString(Resource.String.temperaturaKnobChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.KnobGauge).FindChartByEnum(Enums.ChartTypeEnum.TemperatureKnobGauge);
            else if (chartName == GetResources.GetString(Resource.String.compassChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.KnobGauge).FindChartByEnum(Enums.ChartTypeEnum.CompassKnobGauge);
            else if (chartName == GetResources.GetString(Resource.String.basicClockChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.Clock).FindChartByEnum(Enums.ChartTypeEnum.BasicClock);
            else if (chartName == GetResources.GetString(Resource.String.customClockChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.Clock).FindChartByEnum(Enums.ChartTypeEnum.CustomClock);
            else if (chartName == GetResources.GetString(Resource.String.organizationalChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.Organizational).FindChartByEnum(Enums.ChartTypeEnum.Organizational);
            else if (chartName == GetResources.GetString(Resource.String.numericGaugeChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.NumericGauge).FindChartByEnum(Enums.ChartTypeEnum.NumericGauge);
            else if (chartName == GetResources.GetString(Resource.String.linearGaugeChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.LinearGauge).FindChartByEnum(Enums.ChartTypeEnum.BasicLinGauge);
            else if (chartName == GetResources.GetString(Resource.String.scalesChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.LinearGauge).FindChartByEnum(Enums.ChartTypeEnum.ScalesLinGauge);
            else if (chartName == GetResources.GetString(Resource.String.sublinesChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.LinearGauge).FindChartByEnum(Enums.ChartTypeEnum.SublinesLinGauge);
            else if (chartName == GetResources.GetString(Resource.String.mobileBatteryChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.LinearGauge).FindChartByEnum(Enums.ChartTypeEnum.MobileBatteryLinGauge);
            else if (chartName == GetResources.GetString(Resource.String.calendarChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.Calendar).FindChartByEnum(Enums.ChartTypeEnum.BasicCalendar);
            else if (chartName == GetResources.GetString(Resource.String.specialDatesChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.Calendar).FindChartByEnum(Enums.ChartTypeEnum.SpecialDates);
            else if (chartName == GetResources.GetString(Resource.String.tagCloudChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.TagCloud).FindChartByEnum(Enums.ChartTypeEnum.TagCloud);
            else if (chartName == GetResources.GetString(Resource.String.addFuncChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardFunctions).FindChartByEnum(Enums.ChartTypeEnum.AddStdFunc);
            else if (chartName == GetResources.GetString(Resource.String.substractFuncChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardFunctions).FindChartByEnum(Enums.ChartTypeEnum.SubstractStdFunc);
            else if (chartName == GetResources.GetString(Resource.String.multiplyFuncChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardFunctions).FindChartByEnum(Enums.ChartTypeEnum.MultiplyStdFunc);
            else if (chartName == GetResources.GetString(Resource.String.divideFuncChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardFunctions).FindChartByEnum(Enums.ChartTypeEnum.DivideStdFunc);
            else if (chartName == GetResources.GetString(Resource.String.countFuncChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardFunctions).FindChartByEnum(Enums.ChartTypeEnum.CountStdFunc);
            else if (chartName == GetResources.GetString(Resource.String.averageFuncChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardFunctions).FindChartByEnum(Enums.ChartTypeEnum.AverageStdFunc);
            else if (chartName == GetResources.GetString(Resource.String.highFuncChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardFunctions).FindChartByEnum(Enums.ChartTypeEnum.HighStdFunc);
            else if (chartName == GetResources.GetString(Resource.String.lowFuncChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardFunctions).FindChartByEnum(Enums.ChartTypeEnum.LowStdFunc);
            else if (chartName == GetResources.GetString(Resource.String.medianFuncChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardFunctions).FindChartByEnum(Enums.ChartTypeEnum.MedianStdFunc);
            else if (chartName == GetResources.GetString(Resource.String.percentChangeFuncChartName))
                _tChart = new ChartTabViewModel(Enums.ChartGroupEnum.StandardFunctions).FindChartByEnum(Enums.ChartTypeEnum.PercentChangeStdFunc);


            LinearLayout chartViewLayout = FindViewById<LinearLayout>(Resource.Id.chartViewLayout);
            chartViewLayout.AddView(_tChart);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (item.ItemId == Android.Resource.Id.Home) base.OnBackPressed(); return true;
        }

    }
}