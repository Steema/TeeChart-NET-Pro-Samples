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
using TeeChartFeatures.Chart;
using TeeChartFeatures.Enums;

namespace TeeChartFeatures.Model
{
    public class ChartTabModel : Java.Lang.Object, Java.IO.ISerializable
    {

        private ChartGroupEnum _chartGroup;
        private ChartTypeEnum _chartType;
        private ChartTypeEnum[] _extraCharts;
        private Steema.TeeChart.TChart _tChart;
        private string _title;

        public ChartTabModel() : this(default(ChartGroupEnum), default(ChartTypeEnum)) { }
        public ChartTabModel(ChartGroupEnum chartGroup, ChartTypeEnum chartType)
        {
            _chartGroup = chartGroup;
            _chartType = chartType;
            SetInternalTitle();
            InternalHaveExtraCharts();
        }

        public void InitializeChartView()
        {
            _tChart = new ChartView(_chartGroup, _chartType).TChart;
        }

        private void SetInternalTitle()
        {
            switch (_chartType)
            {
                case ChartTypeEnum.Line:
                case ChartTypeEnum.Area:
                case ChartTypeEnum.Pie:
                case ChartTypeEnum.Donut:
                case ChartTypeEnum.Bubble:
                case ChartTypeEnum.Gantt:
                case ChartTypeEnum.Shape:
                case ChartTypeEnum.Arrow:
                case ChartTypeEnum.Polar:
                case ChartTypeEnum.Radar:
                case ChartTypeEnum.Pyramid:
                case ChartTypeEnum.Candle:
                case ChartTypeEnum.Histogram:
                case ChartTypeEnum.Error:
                case ChartTypeEnum.Funnel:
                case ChartTypeEnum.Smith:
                case ChartTypeEnum.Bezier:
                case ChartTypeEnum.HighLow:
                case ChartTypeEnum.Waterfall:
                case ChartTypeEnum.Volume:
                case ChartTypeEnum.TreeMap:
                case ChartTypeEnum.TagCloud:
                    _title = Enum.GetName(typeof(ChartTypeEnum), _chartType);
                    break;
                case ChartTypeEnum.ColumnBar:
                    _title = "Bar";
                    break;
                case ChartTypeEnum.FastLine:
                    _title = "Fast Line";
                    break;
                case ChartTypeEnum.HorizontalArea:
                    _title = "Horizontal Area";
                    break;
                case ChartTypeEnum.HorizontalBar:
                    _title = "Horizontal Bar";
                    break;
                case ChartTypeEnum.HorizontalLine:
                    _title = "Horizontal Line";
                    break;
                case ChartTypeEnum.PointScatter:
                    _title = "Point/Scatter";
                    break;
                case ChartTypeEnum.InterpolatingLine:
                    _title = "Interpolating Line";
                    break;
                case ChartTypeEnum.BarStyles:
                    _title = "Bar Styles";
                    break;
                case ChartTypeEnum.BarGradient:
                    _title = "Bar Gradient";
                    break;
                case ChartTypeEnum.BubbleTransparent:
                    _title = "Bubble Transparent";
                    break;
                case ChartTypeEnum.RealTime:
                    _title = "Real Time";
                    break;
                case ChartTypeEnum.StackArea:
                    _title = "Stack Area";
                    break;
                case ChartTypeEnum.MultiplePies:
                    _title = "Multiple Pies";
                    break;
                case ChartTypeEnum.SemiPie:
                    _title = "Semi-Pie";
                    break;
                case ChartTypeEnum.SemiDonut:
                    _title = "Semi-Donut";
                    break;
                case ChartTypeEnum.ErrorBar:
                    _title = "Error Bar";
                    break;
                case ChartTypeEnum.SpeedTime:
                    _title = "Speed Time";
                    break;
                case ChartTypeEnum.ColorGrid:
                    _title = "Color Grid";
                    break;
                case ChartTypeEnum.PolarBar:
                    _title = "Polar Bar";
                    break;
                case ChartTypeEnum.InvertedPyramid:
                    _title = "Inverted Pyramid";
                    break;
                case ChartTypeEnum.HorizontalHistogram:
                    _title = "Horizontal Histogram";
                    break;
                case ChartTypeEnum.BasicCircGauge:
                    _title = "Circular Gauge";
                    break;
                case ChartTypeEnum.CarFuelCircGauge:
                    _title = "Car Fuel";
                    break;
                case ChartTypeEnum.CustomHandCircGauge:
                    _title = "Custom Hand";
                    break;
                case ChartTypeEnum.AccelerationCircGauge:
                    _title = "Acceleration Gauge";
                    break;
                case ChartTypeEnum.MapGIS:
                    _title = "Map GIS";
                    break;
                case ChartTypeEnum.WorldMap:
                    _title = "World Map";
                    break;
                case ChartTypeEnum.BasicKnobGauge:
                    _title = "Basic Knob Gauge";
                    break;
                case ChartTypeEnum.TemperatureKnobGauge:
                    _title = "Temperature Knob Gauge";
                    break;
                case ChartTypeEnum.BasicClock:
                    _title = "Basic Clock";
                    break;
                case ChartTypeEnum.CustomClock:
                    _title = "Custom Clock";
                    break;
                case ChartTypeEnum.CompassKnobGauge:
                    _title = "Compass Knob Gauge";
                    break;
                case ChartTypeEnum.Organizational:
                    _title = "Organizational Chart";
                    break;
                case ChartTypeEnum.NumericGauge:
                    _title = "Numeric Gauge";
                    break;
                case ChartTypeEnum.BasicLinGauge:
                    _title = "Basic Linear Gauge";
                    break;
                case ChartTypeEnum.ScalesLinGauge:
                    _title = "Scales";
                    break;
                case ChartTypeEnum.SublinesLinGauge:
                    _title = "SubLines";
                    break;
                case ChartTypeEnum.MobileBatteryLinGauge:
                    _title = "Mobile Battery";
                    break;
                case ChartTypeEnum.BasicCalendar:
                    _title = "Basic Calendar";
                    break;
                case ChartTypeEnum.SpecialDates:
                    _title = "Special Dates Calendar";
                    break;
                case ChartTypeEnum.AddStdFunc:
                    _title = "Add";
                    break;
                case ChartTypeEnum.SubstractStdFunc:
                    _title = "Substract";
                    break;
                case ChartTypeEnum.MultiplyStdFunc:
                    _title = "Multiply";
                    break;
                case ChartTypeEnum.DivideStdFunc:
                    _title = "Divide";
                    break;
                case ChartTypeEnum.CountStdFunc:
                    _title = "Count";
                    break;
                case ChartTypeEnum.AverageStdFunc:
                    _title = "Average";
                    break;
                case ChartTypeEnum.HighStdFunc:
                    _title = "High";
                    break;
                case ChartTypeEnum.LowStdFunc:
                    _title = "Low";
                    break;
                case ChartTypeEnum.MedianStdFunc:
                    _title = "Median Function";
                    break;
                case ChartTypeEnum.PercentChangeStdFunc:
                    _title = "Percent Change";
                    break;

            }
        }
        private void InternalHaveExtraCharts()
        {
            switch(_chartType)
            {
                case ChartTypeEnum.Line:
                    _extraCharts = new ChartTypeEnum[2] { ChartTypeEnum.Line, ChartTypeEnum.InterpolatingLine };
                    break;
                case ChartTypeEnum.ColumnBar:
                    _extraCharts = new ChartTypeEnum[3] { ChartTypeEnum.ColumnBar, ChartTypeEnum.BarStyles, ChartTypeEnum.BarGradient };
                    break;
                case ChartTypeEnum.Area:
                    _extraCharts = new ChartTypeEnum[2] { ChartTypeEnum.Area, ChartTypeEnum.StackArea };
                    break;
                case ChartTypeEnum.Pie:
                    _extraCharts = new ChartTypeEnum[3] { ChartTypeEnum.Pie, ChartTypeEnum.MultiplePies, ChartTypeEnum.SemiPie };
                    break;
                case ChartTypeEnum.FastLine:
                    _extraCharts = new ChartTypeEnum[2] { ChartTypeEnum.FastLine, ChartTypeEnum.RealTime };
                    break;
                case ChartTypeEnum.Donut:
                    _extraCharts = new ChartTypeEnum[2] { ChartTypeEnum.Donut, ChartTypeEnum.SemiDonut };
                    break;
                case ChartTypeEnum.Bubble:
                    _extraCharts = new ChartTypeEnum[2] { ChartTypeEnum.Bubble, ChartTypeEnum.BubbleTransparent };
                    break;
                case ChartTypeEnum.Polar:
                    _extraCharts = new ChartTypeEnum[2] { ChartTypeEnum.Polar, ChartTypeEnum.PolarBar };
                    break;
                case ChartTypeEnum.Pyramid:
                    _extraCharts = new ChartTypeEnum[2] { ChartTypeEnum.Pyramid, ChartTypeEnum.InvertedPyramid };
                    break;
                case ChartTypeEnum.Histogram:
                    _extraCharts = new ChartTypeEnum[2] { ChartTypeEnum.Histogram, ChartTypeEnum.HorizontalHistogram };
                    break;
            }
        }

        public void UpdateChartViewSeries(ChartTypeEnum chartType)
        {
            _chartType = chartType;
            SetInternalTitle();
            if (_tChart == null) InitializeChartView();
            LinearLayout parentChart = _tChart.Parent as LinearLayout;
            InitializeChartView();
            if (parentChart != null)
            {
                parentChart.RemoveAllViews();
                parentChart.AddView(_tChart);
            }
            _tChart.Draw();
        }

        public ChartGroupEnum ChartGroup => _chartGroup;
        public ChartTypeEnum ChartType => _chartType;
        public Steema.TeeChart.TChart TChart { get => _tChart; set => _tChart = value; }
        public String Title => _title;
        public bool HaveExtraCharts => _extraCharts != null;
        public ChartTypeEnum[] ExtraCharts => _extraCharts;

    }
}