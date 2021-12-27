using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steema.TeeChart;
using TeeChartFeatures.Enums;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using TeeChartFeatures.TeeChart;

namespace TeeChartFeatures.Chart
{
    public class ChartView
    {

        public TChart _tChart;
        private SeriesModel _seriesModel;
        private ChartGroupEnum _chartGroup;

        public ChartView() : this(default(ChartGroupEnum), default(ChartTypeEnum))
        {
            
        }
        public ChartView(ChartGroupEnum chartGroup, ChartTypeEnum chartType)
        {
            _chartGroup = chartGroup;
            _tChart = new TChart(Application.Context);
            _seriesModel = new SeriesModel(_tChart, chartGroup, chartType);
        }

        public TChart TChart => _tChart;

    }
}