using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using TeeChartFeatures.Enums;
using TeeChartFeatures.Model;

namespace TeeChartFeatures.ViewModel
{
    public class ChartTabViewModel
    {

        private List<ChartTabModel> _chartTabModels;
        private string _titleGroup;

        public ChartTabViewModel(ChartGroupEnum chartGroup)
        {
            switch(chartGroup)
            {
                case ChartGroupEnum.StandardCharts:
                    _chartTabModels = new List<ChartTabModel>()
                    {
                        new ChartTabModel(chartGroup, ChartTypeEnum.Line),
                        new ChartTabModel(chartGroup, ChartTypeEnum.ColumnBar),
                        new ChartTabModel(chartGroup, ChartTypeEnum.Area),
                        new ChartTabModel(chartGroup, ChartTypeEnum.Pie),
                        new ChartTabModel(chartGroup, ChartTypeEnum.FastLine),
                        new ChartTabModel(chartGroup, ChartTypeEnum.HorizontalArea),
                        new ChartTabModel(chartGroup, ChartTypeEnum.HorizontalBar),
                        new ChartTabModel(chartGroup, ChartTypeEnum.HorizontalLine),
                        new ChartTabModel(chartGroup, ChartTypeEnum.Donut),
                        new ChartTabModel(chartGroup, ChartTypeEnum.Bubble),
                        new ChartTabModel(chartGroup, ChartTypeEnum.Gantt),
                        new ChartTabModel(chartGroup, ChartTypeEnum.Shape),
                        new ChartTabModel(chartGroup, ChartTypeEnum.PointScatter),
                    };
                    _titleGroup = "Standard Charts";
                    break;
                case ChartGroupEnum.ProCharts:
                    _chartTabModels = new List<ChartTabModel>()
                    {
                        new ChartTabModel(chartGroup, ChartTypeEnum.Arrow),
                        new ChartTabModel(chartGroup, ChartTypeEnum.Polar),
                        new ChartTabModel(chartGroup, ChartTypeEnum.Radar),
                        new ChartTabModel(chartGroup, ChartTypeEnum.Pyramid),
                        new ChartTabModel(chartGroup, ChartTypeEnum.Candle),
                        new ChartTabModel(chartGroup, ChartTypeEnum.Histogram),
                        new ChartTabModel(chartGroup, ChartTypeEnum.Error),
                        new ChartTabModel(chartGroup, ChartTypeEnum.ErrorBar),
                        new ChartTabModel(chartGroup, ChartTypeEnum.Funnel),
                        new ChartTabModel(chartGroup, ChartTypeEnum.Smith),
                        new ChartTabModel(chartGroup, ChartTypeEnum.Bezier),
                        new ChartTabModel(chartGroup, ChartTypeEnum.HighLow),
                        new ChartTabModel(chartGroup, ChartTypeEnum.SpeedTime),
                        new ChartTabModel(chartGroup, ChartTypeEnum.Waterfall),
                        new ChartTabModel(chartGroup, ChartTypeEnum.Volume),
                        new ChartTabModel(chartGroup, ChartTypeEnum.ColorGrid),
                    };
                    _titleGroup = "Pro Charts";
                    break;
                case ChartGroupEnum.CircularGauge:
                    _chartTabModels = new List<ChartTabModel>()
                    {
                        new ChartTabModel(chartGroup, ChartTypeEnum.BasicCircGauge),
                        new ChartTabModel(chartGroup, ChartTypeEnum.CarFuelCircGauge),
                        new ChartTabModel(chartGroup, ChartTypeEnum.CustomHandCircGauge),
                        new ChartTabModel(chartGroup, ChartTypeEnum.AccelerationCircGauge),
                    };
                    _titleGroup = "Circular Gauge";
                    break;
                case ChartGroupEnum.Maps:
                    _chartTabModels = new List<ChartTabModel>()
                    {
                        new ChartTabModel(chartGroup, ChartTypeEnum.MapGIS),
                        //new ChartTabModel(chartGroup, ChartTypeEnum.WorldMap),
                    };
                    _titleGroup = "Maps";
                    break;
                /*case ChartGroupEnum.TreeMap:
                    _chartTabModels = new List<ChartTabModel>()
                    {
                        new ChartTabModel(chartGroup, ChartTypeEnum.TreeMap),
                    };
                    _titleGroup = "TreeMap";
                    break;
                */
                case ChartGroupEnum.KnobGauge:
                    _chartTabModels = new List<ChartTabModel>()
                    {
                        new ChartTabModel(chartGroup, ChartTypeEnum.BasicKnobGauge),
                        new ChartTabModel(chartGroup, ChartTypeEnum.TemperatureKnobGauge),
                        new ChartTabModel(chartGroup, ChartTypeEnum.CompassKnobGauge),
                    };
                    _titleGroup = "Knob Gauge";
                    break;
                case ChartGroupEnum.Clock:
                    _chartTabModels = new List<ChartTabModel>()
                    {
                        new ChartTabModel(chartGroup, ChartTypeEnum.BasicClock),
                        new ChartTabModel(chartGroup, ChartTypeEnum.CustomClock),
                    };
                    _titleGroup = "Clock";
                    break;
                case ChartGroupEnum.Organizational:
                    _chartTabModels = new List<ChartTabModel>()
                    {
                        new ChartTabModel(chartGroup, ChartTypeEnum.Organizational),
                    };
                    _titleGroup = "Organizational";
                    break;
                case ChartGroupEnum.NumericGauge:
                    _chartTabModels = new List<ChartTabModel>()
                    {
                        new ChartTabModel(chartGroup, ChartTypeEnum.NumericGauge),
                    };
                    _titleGroup = "Numeric Gauge";
                    break;
                case ChartGroupEnum.LinearGauge:
                    _chartTabModels = new List<ChartTabModel>()
                    {
                        new ChartTabModel(chartGroup, ChartTypeEnum.BasicLinGauge),
                        new ChartTabModel(chartGroup, ChartTypeEnum.ScalesLinGauge),
                        new ChartTabModel(chartGroup, ChartTypeEnum.SublinesLinGauge),
                        new ChartTabModel(chartGroup, ChartTypeEnum.MobileBatteryLinGauge),
                    };
                    _titleGroup = "Linear Gauge";
                    break;
                case ChartGroupEnum.Calendar:
                    _chartTabModels = new List<ChartTabModel>()
                    {
                        new ChartTabModel(chartGroup, ChartTypeEnum.BasicCalendar),
                        new ChartTabModel(chartGroup, ChartTypeEnum.SpecialDates),
                    };
                    _titleGroup = "Calendar";
                    break;
                case ChartGroupEnum.TagCloud:
                    _chartTabModels = new List<ChartTabModel>()
                    {
                        new ChartTabModel(chartGroup, ChartTypeEnum.TagCloud),
                    };
                    _titleGroup = "TagCloud";
                    break;
                case ChartGroupEnum.StandardFunctions:
                    _chartTabModels = new List<ChartTabModel>()
                    {
                        new ChartTabModel(chartGroup, ChartTypeEnum.AddStdFunc),
                        new ChartTabModel(chartGroup, ChartTypeEnum.SubstractStdFunc),
                        new ChartTabModel(chartGroup, ChartTypeEnum.MultiplyStdFunc),
                        new ChartTabModel(chartGroup, ChartTypeEnum.DivideStdFunc),
                        new ChartTabModel(chartGroup, ChartTypeEnum.CountStdFunc),
                        new ChartTabModel(chartGroup, ChartTypeEnum.AverageStdFunc),
                        new ChartTabModel(chartGroup, ChartTypeEnum.HighStdFunc),
                        new ChartTabModel(chartGroup, ChartTypeEnum.LowStdFunc),
                        new ChartTabModel(chartGroup, ChartTypeEnum.MedianStdFunc),
                        new ChartTabModel(chartGroup, ChartTypeEnum.PercentChangeStdFunc),
                    };
                    _titleGroup = "Standard Functions";
                    break;
            }
        }
        public Steema.TeeChart.TChart FindChartByEnum(ChartTypeEnum chartTypeEnum)
        {
            int posicioActual = 0;
            bool trobat = false;

            while(!trobat && posicioActual < Items.Count)
            {
                trobat = Items[posicioActual].ChartType.Equals(chartTypeEnum);
                posicioActual++;
            }
            if(trobat)
            {
                Items[posicioActual - 1].InitializeChartView();
                return Items[posicioActual - 1].TChart;
            }
            return null;
        }

        public List<ChartTabModel> Items => _chartTabModels;
        public ChartTabModel this[int index]
        {
            get => Items[index];
        } 
        public int Count => _chartTabModels.Count;
        public String TitleGroup => _titleGroup;

    }
}