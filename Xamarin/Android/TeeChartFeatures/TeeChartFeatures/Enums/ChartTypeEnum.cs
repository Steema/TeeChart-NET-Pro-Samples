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

namespace TeeChartFeatures.Enums
{
    public enum ChartTypeEnum
    {
        // Standard Charts
        Line,
        ColumnBar,
        Area,
        Pie,
        FastLine,
        HorizontalArea,
        HorizontalBar,
        HorizontalLine,
        Donut,
        Bubble,
        Gantt,
        Shape,
        PointScatter,
        InterpolatingLine,
        BarStyles,
        BarGradient,
        BubbleTransparent,
        RealTime,
        StackArea,
        MultiplePies,
        SemiPie,
        SemiDonut,
        
        // Pro Charts
        Arrow,
        Polar,
        Radar,
        Pyramid,
        Candle,
        Histogram,
        Error,
        ErrorBar,
        Funnel,
        Smith,
        Bezier,
        HighLow,
        SpeedTime,
        Waterfall,
        Volume,
        ColorGrid,
        PolarBar,
        InvertedPyramid,
        HorizontalHistogram,

        // Circular Gauge
        BasicCircGauge,
        CarFuelCircGauge,
        CustomHandCircGauge,
        AccelerationCircGauge,

        // Maps
        MapGIS,
        WorldMap,

        // TreeMap
        TreeMap,

        // KnobGauge
        BasicKnobGauge,
        TemperatureKnobGauge,
        CompassKnobGauge,

        // Clock
        BasicClock,
        CustomClock,

        // Organizational
        Organizational,

        // Numeric Gauge
        NumericGauge,

        // Linear Gauge
        BasicLinGauge,
        ScalesLinGauge,
        SublinesLinGauge,
        MobileBatteryLinGauge,

        // Calendar
        BasicCalendar,
        SpecialDates,

        // TagCloud
        TagCloud,

        // Standard Functions
        AddStdFunc,
        SubstractStdFunc,
        MultiplyStdFunc,
        DivideStdFunc,
        CountStdFunc,
        AverageStdFunc,
        HighStdFunc,
        LowStdFunc,
        MedianStdFunc,
        PercentChangeStdFunc,

    }
}