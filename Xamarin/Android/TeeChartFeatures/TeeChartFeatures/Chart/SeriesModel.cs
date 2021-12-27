using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using Android.App;
using Android.Content;
using Android.Hardware;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Steema.TeeChart;
using Steema.TeeChart.Drawing;
using Steema.TeeChart.Styles;
using Steema.TeeChart.Tools;
using TeeChartFeatures.Chart;
using TeeChartFeatures.Enums;
using static Steema.TeeChart.Axis;

namespace TeeChartFeatures.TeeChart
{
    public class SeriesModel
    {

        public TChart _tChart;
        private ChartTypeEnum _chartType;

        public SeriesModel() : this(new ChartView(default(ChartGroupEnum), default(ChartTypeEnum)).TChart, default(ChartGroupEnum), default(ChartTypeEnum)) { }
        public SeriesModel(TChart chart, ChartGroupEnum chartGroup, ChartTypeEnum chartType)
        {
            _chartType = chartType;
            _tChart = chart;
            UpdateChartView();
            UpdateDefaultChart();
            InitializeSeries();
        }

        private void UpdateChartView()
        {
            _tChart.LayoutParameters = new ViewGroup.LayoutParams(200, 200);
            _tChart.LayoutParameters.Width = ViewGroup.LayoutParams.MatchParent;
            _tChart.LayoutParameters.Height = ViewGroup.LayoutParams.MatchParent; 
        }

        private void UpdateDefaultChart()
        {
            _tChart.Chart.Legend.Visible = true;
            _tChart.Chart.Legend.Alignment = LegendAlignments.Bottom;
            _tChart.Chart.Axes.Top.Visible = false;
            _tChart.Chart.Axes.Right.Visible = false;
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Bottom.Visible = true;
            _tChart.Chart.Panning.Active = false;
            _tChart.Chart.Panning.Allow = ScrollModes.Both;
            _tChart.Chart.Zoom.Active = false;
            _tChart.Chart.Zoom.Direction = ZoomDirections.Both;
        }

        private void InitializeSeries()
        {
            DisablePanningAndZoom();
            switch (_chartType)
            {
                case ChartTypeEnum.Line:
                    InitLineChart();
                    break;
                case ChartTypeEnum.ColumnBar:
                    InitColumnBarChart();
                    break;
                case ChartTypeEnum.Area:
                    InitAreaChart();
                    break;
                case ChartTypeEnum.Pie:
                    InitPieChart();
                    break;
                case ChartTypeEnum.FastLine:
                    InitFastLineChart();
                    break;
                case ChartTypeEnum.HorizontalArea:
                    InitHorizAreaChart();
                    break;
                case ChartTypeEnum.HorizontalBar:
                    InitHorizBarChart();
                    break;
                case ChartTypeEnum.HorizontalLine:
                    InitHorizLineChart();
                    break;
                case ChartTypeEnum.Donut:
                    InitDonutChart();
                    break;
                case ChartTypeEnum.Bubble:
                    InitBubbleChart();
                    break;
                case ChartTypeEnum.Gantt:
                    InitGanttChart();
                    break;
                case ChartTypeEnum.Shape:
                    InitShapeChart();
                    break;
                case ChartTypeEnum.PointScatter:
                    InitPointScatterChart();
                    break;
                case ChartTypeEnum.InterpolatingLine:
                    InitInterpolatingLineChart();
                    break;
                case ChartTypeEnum.BarStyles:
                    InitBarStylesChart();
                    break;
                case ChartTypeEnum.BarGradient:
                    InitBarGradientChart();
                    break;
                case ChartTypeEnum.BubbleTransparent:
                    InitBubbleTranspChart();
                    break;
                case ChartTypeEnum.RealTime:
                    InitRealTimeChart();
                    break;
                case ChartTypeEnum.StackArea:
                    InitStackAreaChart();
                    break;
                case ChartTypeEnum.MultiplePies:
                    InitMultPiesChart();
                    break;
                case ChartTypeEnum.SemiPie:
                    InitSemiPieChart();
                    break;
                case ChartTypeEnum.SemiDonut:
                    InitSemiDonutChart();
                    break;
                case ChartTypeEnum.Arrow:
                    InitArrowChart();
                    break;
                case ChartTypeEnum.Polar:
                    InitPolarChart();
                    break;
                case ChartTypeEnum.Radar:
                    InitRadarChart();
                    break;
                case ChartTypeEnum.Pyramid:
                    InitPyramidChart();
                    break;
                case ChartTypeEnum.Candle:
                    InitCandleChart();
                    break;
                case ChartTypeEnum.Histogram:
                    InitHistogramChart();
                    break;
                case ChartTypeEnum.Error:
                    InitErrorChart();
                    break;
                case ChartTypeEnum.ErrorBar:
                    InitErrorBarChart();
                    break;
                case ChartTypeEnum.Funnel:
                    InitFunnelChart();
                    break;
                case ChartTypeEnum.Smith:
                    InitSmithChart();
                    break;
                case ChartTypeEnum.Bezier:
                    InitBezierChart();
                    break;
                case ChartTypeEnum.HighLow:
                    InitHighLowChart();
                    break;
                case ChartTypeEnum.SpeedTime:
                    InitSpeedTimeChart();
                    break;
                case ChartTypeEnum.Waterfall:
                    InitWaterfallChart();
                    break;
                case ChartTypeEnum.Volume:
                    InitVolumeChart();
                    break;
                case ChartTypeEnum.ColorGrid:
                    InitColorGridChart();
                    break;
                case ChartTypeEnum.PolarBar:
                    InitPolarBarChart();
                    break;
                case ChartTypeEnum.InvertedPyramid:
                    InitInvertedPyramidChart();
                    break;
                case ChartTypeEnum.HorizontalHistogram:
                    InitHorizHistogramChart();
                    break;
                case ChartTypeEnum.BasicCircGauge:
                    InitBasicCircGaugeChart();
                    break;
                case ChartTypeEnum.CarFuelCircGauge:
                    InitCarFuelCircGaugeChart();
                    break;
                case ChartTypeEnum.CustomHandCircGauge:
                    InitCustomHandCircGaugeChart();
                    break;
                case ChartTypeEnum.AccelerationCircGauge:
                    InitAccelerationCircGaugeChart();
                    break;
                case ChartTypeEnum.MapGIS:
                    InitMapGISChart();
                    break;
                case ChartTypeEnum.WorldMap:
                    InitWorldMapChart();
                    break;
                case ChartTypeEnum.TreeMap:
                    InitTreeMapChart();
                    break;
                case ChartTypeEnum.BasicKnobGauge:
                    InitBasicKnobGaugeChart();
                    break;
                case ChartTypeEnum.TemperatureKnobGauge:
                    InitTemperatureKnobGaugeChart();
                    break;
                case ChartTypeEnum.CompassKnobGauge:
                    InitCompassKnobGaugeChart();
                    break;
                case ChartTypeEnum.BasicClock:
                    InitBasicClockChart();
                    break;
                case ChartTypeEnum.CustomClock:
                    InitCustomClockChart();
                    break;
                case ChartTypeEnum.Organizational:
                    InitOrganizationalChart();
                    break;
                case ChartTypeEnum.NumericGauge:
                    InitNumericGaugeChart();
                    break;
                case ChartTypeEnum.BasicLinGauge:
                    InitBasicLinearGaugeChart();
                    break;
                case ChartTypeEnum.ScalesLinGauge:
                    InitScalesLinearGaugeChart();
                    break;
                case ChartTypeEnum.SublinesLinGauge:
                    InitSublinesLinearGaugeChart();
                    break;
                case ChartTypeEnum.MobileBatteryLinGauge:
                    InitMobileBatteryLinearGaugeChart();
                    break;
                case ChartTypeEnum.BasicCalendar:
                    InitBasicCalendarChart();
                    break;
                case ChartTypeEnum.SpecialDates:
                    InitSpecialDatesChart();
                    break;
                case ChartTypeEnum.TagCloud:
                    InitTagCloudChart();
                    break;
                case ChartTypeEnum.AddStdFunc:
                    InitAddStdFuncChart();
                    break;
                case ChartTypeEnum.SubstractStdFunc:
                    InitSubstractStdFuncChart();
                    break;
                case ChartTypeEnum.MultiplyStdFunc:
                    InitMultiplyStdFuncChart();
                    break;
                case ChartTypeEnum.DivideStdFunc:
                    InitDivideStdFuncChart();
                    break;
                case ChartTypeEnum.CountStdFunc:
                    InitCountStdFuncChart();
                    break;
                case ChartTypeEnum.AverageStdFunc:
                    InitAverageStdFuncChart();
                    break;
                case ChartTypeEnum.HighStdFunc:
                    InitHighStdFuncChart();
                    break;
                case ChartTypeEnum.LowStdFunc:
                    InitLowStdFuncChart();
                    break;
                case ChartTypeEnum.MedianStdFunc:
                    InitMedianStdFuncChart();
                    break;
                case ChartTypeEnum.PercentChangeStdFunc:
                    InitPercentChangeStdFuncChart();
                    break;
            }
            DisablePanningAndZoom();
        }

        private void DisablePanningAndZoom()
        {
            switch (_chartType)
            {
                case ChartTypeEnum.InterpolatingLine:
                case ChartTypeEnum.RealTime:
                    _tChart.Zoom.Direction = ZoomDirections.Both;
                    _tChart.Panning.Allow = ScrollModes.Both;
                    _tChart.Panning.Active = true;
                    _tChart.Zoom.Active = true;
                    break;
                default:
                    _tChart.Zoom.Direction = ZoomDirections.None;
                    _tChart.Panning.Allow = ScrollModes.None;
                    _tChart.Panning.Active = false;
                    _tChart.Zoom.Active = false;
                    break;
            }
        }

        #region SERIES

        #region STANDARD CHARTS

        private void InitLineChart()
        {
            Line line1 = new Line(_tChart.Chart);
            Line line2 = new Line(_tChart.Chart);

            // Chart Properties
            _tChart.Chart.Header.Text = "Deaths and Births in Spain";

            // Line Properties
            line1.FillSampleValues();
            line2.FillSampleValues();

            line1.LinePen.Width = 6;
            line1.Pointer.InflateMargins = true;
            line1.Pointer.Visible = true;
            line1.Pointer.HorizSize = 11;
            line1.Pointer.VertSize = 11;
            line1.Pointer.Pen.EndCap = Android.Graphics.Paint.Cap.Round;
            line1.Pointer.Pen.Color = Color.White;
            line1.Pointer.Pen.Width = 5;
            line1.Pointer.Style = PointerStyles.Sphere;
            line1.Chart.Zoom.Direction = ZoomDirections.Both;
            line1.Chart.Panning.Allow = ScrollModes.None;
            line1.LineHeight = 25;
            line1.ClickableLine = true;
            line1.ClickTolerance = 30;
            line1.RecalcOptions = RecalcOptions.OnModify;
            line1.Title = "Births";
            line1.DefaultNullValue = 0;
            line1.VertAxis = VerticalAxis.Both;
            line1.HorizAxis = HorizontalAxis.Both;

            line2.LinePen.Width = 6;
            line2.Pointer.InflateMargins = true;
            line2.Pointer.Visible = true;
            line2.Pointer.HorizSize = 11;
            line2.Pointer.VertSize = 11;
            line2.Pointer.Pen.EndCap = Android.Graphics.Paint.Cap.Round;
            line2.Pointer.Pen.Color = Color.White;
            line2.Pointer.Pen.Width = 5;
            line2.Pointer.Style = PointerStyles.Sphere;
            line2.Chart.Zoom.Direction = ZoomDirections.Both;
            line2.Chart.Panning.Allow = ScrollModes.None;
            line2.LineHeight = 25;
            line2.ClickableLine = true;
            line2.ClickTolerance = 30;
            line2.RecalcOptions = RecalcOptions.OnModify;
            line2.Title = "Deaths";
            line2.VertAxis = VerticalAxis.Both;
            line2.HorizAxis = HorizontalAxis.Both;

            // Características de los ejes del "Chart" base
            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue - 10, _tChart.Chart.Axes.Left.MaxYValue + 10);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Left.Labels.ValueFormat = "0K";
            _tChart.Chart.Axes.Bottom.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Bottom.Increment = 1;
            _tChart.Chart.Axes.Left.Increment = 10;
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.Title = null;
            _tChart.Chart.Axes.Bottom.Title = null;
            _tChart.Chart.Axes.Left.AxisPen.Visible = false;
            _tChart.Chart.Axes.Left.Ticks.Visible = false;
            _tChart.Chart.Axes.Left.Grid.Visible = true;
            _tChart.Chart.Legend.LegendStyle = LegendStyles.Series;
            _tChart.Chart.Axes.Bottom.Grid.Visible = false;
            _tChart.Chart.Panel.MarginLeft = 5;
        }

        private void InitColumnBarChart()
        {
            Bar bar1;
            Bar bar2;
            Bar bar3;

            bar1 = new Bar();
            bar2 = new Bar();
            bar3 = new Bar();

            _tChart.Chart.Legend.Visible = true;
            _tChart.Chart.Header.Text = "Civil status of people in the bus";
            _tChart.Chart.Series.Add(bar1);
            _tChart.Chart.Series.Add(bar2);
            _tChart.Chart.Series.Add(bar3);

            bar1.RecalcOptions = RecalcOptions.OnModify;
            bar1.Title = "Bus 1";
            bar1.DefaultNullValue = 0;
            bar1.FillSampleValues(3);
            bar1.MarksOnBar = false;
            bar1.Marks.Style = MarksStyles.Value;
            bar1.BarWidthPercent = 80;
            bar1.VertAxis = VerticalAxis.Both;
            bar1.HorizAxis = HorizontalAxis.Both;

            bar2.RecalcOptions = RecalcOptions.OnModify;
            bar2.Title = "Bus 2";
            bar2.DefaultNullValue = 0;
            bar2.FillSampleValues(3);
            bar2.ZOrder = 0;
            bar2.MarksOnBar = false;
            bar2.Marks.Style = MarksStyles.Value;
            bar2.BarWidthPercent = 80;
            bar2.VertAxis = VerticalAxis.Both;
            bar2.HorizAxis = HorizontalAxis.Both;

            bar3.RecalcOptions = RecalcOptions.OnModify;
            bar3.Title = "Bus 3";
            bar3.DefaultNullValue = 0;
            bar3.FillSampleValues(3);
            bar3.MarksOnBar = false;
            bar3.Marks.Style = MarksStyles.Value;
            bar3.BarWidthPercent = 80;
            bar3.VertAxis = VerticalAxis.Both;
            bar3.HorizAxis = HorizontalAxis.Both;

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue, _tChart.Chart.Axes.Left.MaxYValue + 1);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Left.Title = null;
            _tChart.Chart.Axes.Bottom.Title = null;
            _tChart.Chart.Axes.Left.Visible = false;
            _tChart.Chart.Axes.Bottom.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Left.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Bottom.Grid.Visible = false;
            _tChart.Chart.Axes.Left.Increment = 2;
            _tChart.Chart.Legend.LegendStyle = LegendStyles.Series;
            _tChart.Chart.Axes.Left.Labels.CustomSize = 0;

            bar1.Marks.Pen.Visible = false;
            bar2.Marks.Pen.Visible = false;
            bar3.Marks.Pen.Visible = false;

            _tChart.Chart.Series[0].Marks.AutoSize = true;
            _tChart.Chart.Series[0].Marks.FollowSeriesColor = true;
            _tChart.Chart.Series[1].Marks.AutoSize = true;
            _tChart.Chart.Series[1].Marks.FollowSeriesColor = true;
            _tChart.Chart.Series[2].Marks.AutoSize = true;
            _tChart.Chart.Series[2].Marks.FollowSeriesColor = true;

        }

        private void InitAreaChart()
        {
            Area area1;
            Area area2;

            // Inicializar variables
            area1 = new Area();
            area2 = new Area();

            // Propiedades del "Chart" base
            _tChart.Chart.Series.Add(area1);
            _tChart.Chart.Series.Add(area2);
            _tChart.Chart.Legend.Visible = true;
            _tChart.Chart.Header.Text = "Mensual sells by two companies";
            _tChart.Chart.Axes.Bottom.LabelsOnAxis = true;

            // Propiedades de la "area1"
            area1.Title = "Company 1";
            area1.Chart.Panning.Allow = ScrollModes.None;
            area1.RecalcOptions = RecalcOptions.OnModify;
            area1.DefaultNullValue = 0;
            area1.ClickableLine = true;
            area1.AreaLines.Visible = false;
            area1.LinePen.Width = 5;
            area1.Pointer.Visible = true;
            area1.Pointer.Style = PointerStyles.Nothing;
            area1.Pointer.InflateMargins = false;
            area1.LinePen.Style = DashStyle.Solid;
            area1.LinePen.EndCap = Android.Graphics.Paint.Cap.Round;
            area1.ClickTolerance = 30;
            area1.FillSampleValues(7);
            area1.VertAxis = VerticalAxis.Both;
            area1.HorizAxis = HorizontalAxis.Both;

            // Propiedades de la "area2"
            area2.Title = "Company 2";
            area2.Chart.Panning.Allow = ScrollModes.None;
            area2.RecalcOptions = RecalcOptions.OnModify;
            area2.DefaultNullValue = 0;
            area2.ClickableLine = true;
            area2.ClickTolerance = 30;
            area2.Pointer.Visible = true;
            area2.Pointer.Style = PointerStyles.Nothing;
            area2.LinePen.Style = DashStyle.Solid;
            area2.LinePen.EndCap = Android.Graphics.Paint.Cap.Round;
            area2.AreaLines.Visible = false;
            area2.LinePen.Width = 5;
            area2.FillSampleValues(7);
            area2.VertAxis = VerticalAxis.Both;
            area2.HorizAxis = HorizontalAxis.Both;

            // Propieades de los ejes del "Chart" base
            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue, _tChart.Chart.Axes.Left.MaxYValue + 20);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Left.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Bottom.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Bottom.Labels.TextAlign = Android.Graphics.Paint.Align.Left;
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.Increment = 20;
            _tChart.Chart.Axes.Left.Title.Visible = false;
            _tChart.Chart.Axes.Left.Ticks = new Steema.TeeChart.Axis.TicksPen { Width = 2, Visible = true, Color = Color.FromArgb(200, 200, 200), EndCap = Android.Graphics.Paint.Cap.Round, Style = DashStyle.Solid, Length = 10 };
            _tChart.Chart.Axes.Left.LabelsOnAxis = true;

            _tChart.Chart.Axes.Left.Labels.CustomSize = 10;
            _tChart.Chart.Axes.Bottom.Title.Visible = false;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Bottom.Grid.Visible = false;
            _tChart.Chart.Legend.LegendStyle = LegendStyles.Series;
            _tChart.Chart.Panel.MarginRight = 5;
            _tChart.Chart.Panel.MarginLeft = 4;
        }

        private void InitPieChart()
        {
            Pie pie1;
            pie1 = new Pie();

            _tChart.Chart.Header.Text = "Percentage of animals in the zoo (%)";
            _tChart.Chart.Series.Add(pie1);
            _tChart.Chart.Legend.Visible = true;

            pie1.AutoCircleResize = true;
            pie1.RecalcOptions = RecalcOptions.OnModify;
            pie1.DefaultNullValue = 0;
            pie1.Circled = true;
            pie1.AutoPenColor = false;
            pie1.DarkPen = false;
            pie1.Pen.Width = 3;
            pie1.Pen.Style = DashStyle.Solid;
            pie1.Pen.Visible = true;
            pie1.Pen.Color = Color.White;
            pie1.VertAxis = VerticalAxis.Both;
            pie1.HorizAxis = HorizontalAxis.Both;

            pie1.CustomXRadius = (int)_tChart.Chart.Axes.Bottom.MaxXValue;
            pie1.FillSampleValues(5);

            pie1.Title = "pieAnimals";

            pie1.RotationAngle = 20;

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue, _tChart.Chart.Axes.Left.MaxYValue);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinYValue, _tChart.Chart.Axes.Bottom.MaxXValue);

            _tChart.Chart.Axes.Bottom.Increment = 5;
            _tChart.Chart.Axes.Left.Increment = 5;

            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Bottom.Visible = true;

            _tChart.Chart.Axes.Left.Title.Angle = 90;
            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Bottom.Grid.Visible = false;
            _tChart.Chart.Legend.LegendStyle = LegendStyles.Values;
            _tChart.Chart.Legend.Alignment = LegendAlignments.Bottom;
            _tChart.Chart.Legend.AutoSize = true;
            _tChart.Chart.Legend.ResizeChart = true;
            _tChart.Chart.Legend.TextAlign = Android.Graphics.Paint.Align.Center;
            _tChart.Chart.Legend.Font.Size = 13;

            pie1.Marks.Pen.Visible = false;
            pie1.Marks.Style = MarksStyles.Percent;
            pie1.AutoCircleResize = false;
            pie1.MarksPie.InsideSlice = true;
            _tChart.Chart.Panel.MarginLeft = 5;
            pie1.MarksPie.LegSize = 20;
            pie1.MarksPie.VertCenter = true;
        }

        private void InitFastLineChart()
        {
            FastLine fastLine1;
            FastLine fastLine2;
            fastLine1 = new FastLine();
            fastLine2 = new FastLine();

            _tChart.Chart.Header.Text = "Fast random picture";
            _tChart.Chart.Series.Add(fastLine1);
            _tChart.Chart.Series.Add(fastLine2);
            _tChart.Chart.Legend.Visible = false;

            fastLine1.RecalcOptions = RecalcOptions.OnModify;
            fastLine1.DefaultNullValue = 0;
            fastLine1.AutoRepaint = true;
            fastLine1.VertAxis = VerticalAxis.Both;
            fastLine1.HorizAxis = HorizontalAxis.Both;

            fastLine2.Title = "fastLine2";

            fastLine2.Chart.Panning.Allow = ScrollModes.None;
            fastLine2.AutoRepaint = true;
            fastLine2.RecalcOptions = RecalcOptions.OnModify;
            fastLine2.DefaultNullValue = 0;
            Random r = new Random();
            int tmprandom;
            for (int t = 1; t < 1000; t++)
            {
                tmprandom = r.Next(Math.Abs(500 - t)) - (Math.Abs(500 - t) / 2);
                fastLine1.Add(1000 - t + tmprandom);
                fastLine2.Add(t + tmprandom);
            }
            fastLine2.VertAxis = VerticalAxis.Both;
            fastLine2.HorizAxis = HorizontalAxis.Both;
            fastLine2.Title = "fastLine2";

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue - 5, _tChart.Chart.Axes.Left.MaxYValue + 5);
            _tChart.Chart.Axes.Bottom.SetMinMax(0, _tChart.Chart.Axes.Bottom.MaxXValue + 3);

            _tChart.Chart.Axes.Bottom.Increment = 5;
            _tChart.Chart.Axes.Left.Increment = 15;

            _tChart.Chart.Axes.Left.Labels.ValueFormat = "0K";
            _tChart.Chart.Axes.Bottom.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Left.Title.Pen = new ChartPen { Color = Color.Black, Width = 15 };

            _tChart.Chart.Axes.Left.Title.Visible = false;
            _tChart.Chart.Axes.Bottom.Title.Visible = false;

            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Ticks = new Steema.TeeChart.Axis.TicksPen { Width = 2, Visible = true, Color = Color.FromArgb(200, 200, 200), Style = DashStyle.Solid, Length = 10, };
            _tChart.Chart.Axes.Bottom.Visible = true;

            _tChart.Chart.Axes.Left.Title.Angle = 90;
            _tChart.Chart.Axes.Left.Grid.Visible = false;

            _tChart.Chart.Panel.MarginLeft = 5;
        }

        private void InitHorizAreaChart()
        {
            HorizArea horizArea1;

            horizArea1 = new HorizArea();

            _tChart.Chart.Header.Text = "People in different countries";
            _tChart.Chart.Series.Add(horizArea1);
            _tChart.Chart.Legend.Visible = false;

            horizArea1.RecalcOptions = RecalcOptions.OnModify;
            horizArea1.DefaultNullValue = 0;
            horizArea1.AreaLines.Visible = false;
            horizArea1.Pointer.Visible = true;
            horizArea1.ClickableLine = true;
            horizArea1.LinePen.Width = 5;

            horizArea1.Pointer.Style = PointerStyles.Nothing;
            horizArea1.Pointer.InflateMargins = false;
            horizArea1.ClickTolerance = 30;
            horizArea1.LinePen.Style = DashStyle.Solid;
            horizArea1.VertAxis = VerticalAxis.Both;
            horizArea1.HorizAxis = HorizontalAxis.Both;
            horizArea1.FillSampleValues(7);

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue - 0.001, _tChart.Chart.Axes.Left.MaxYValue + 0.01);

            _tChart.Chart.Axes.Left.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Bottom.Labels.ValueFormat = "0K";
            _tChart.Chart.Axes.Left.Title.Pen = new ChartPen { Color = Color.Black, Width = 15 };

            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Ticks = new Steema.TeeChart.Axis.TicksPen { Width = 2, Visible = true, Color = Color.FromArgb(200, 200, 200), Style = DashStyle.Solid, Length = 10, };
            _tChart.Chart.Axes.Bottom.Visible = true;

            _tChart.Chart.Axes.Left.Title.Angle = 90;
            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Bottom.Grid.Visible = false;
            _tChart.Chart.Axes.Left.Title.Text = "Countries";
            _tChart.Chart.Axes.Bottom.Title.Text = "People (K)";
            _tChart.Chart.Axes.Left.Title.Font.Size = 14;
            _tChart.Chart.Axes.Bottom.Title.Font.Size = 14;
            _tChart.Chart.Axes.Left.Title.CustomSize = 50;
            _tChart.Chart.Axes.Left.LabelsOnAxis = true;
            _tChart.Chart.Axes.Left.Labels.AutoSize = true;
            _tChart.Chart.Title.AutoSize = true;
            _tChart.Chart.Axes.Left.StartPosition = 1;
            _tChart.Chart.Panel.MarginLeft = 6;
            _tChart.Chart.Axes.Left.Title.Visible = false;
        }

        private void InitHorizBarChart()
        {
            HorizBar bar1;
            bar1 = new HorizBar();

            _tChart.Chart.Legend.Visible = true;
            _tChart.Chart.Header.Text = "Number of Museum Visitors (2008-2011)";
            _tChart.Chart.Series.Add(bar1);

            bar1.RecalcOptions = RecalcOptions.OnModify;
            bar1.Title = "National Gallery";
            bar1.DefaultNullValue = 0;
            bar1.FillSampleValues(5);
            bar1.MarksOnBar = true;
            bar1.Marks.Style = MarksStyles.Value;
            bar1.VertAxis = VerticalAxis.Both;
            bar1.HorizAxis = HorizontalAxis.Both;

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue, _tChart.Chart.Axes.Left.MaxYValue);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Left.Title.Visible = false;
            _tChart.Chart.Axes.Bottom.Title.Text = "Annual Visitors (M)";
            _tChart.Chart.Axes.Left.Visible = false;
            _tChart.Chart.Axes.Bottom.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Left.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Bottom.Increment = 1;
            _tChart.Chart.Axes.Left.Increment = 1;
            _tChart.Chart.Axes.Bottom.Grid.Visible = true;
            _tChart.Chart.Legend.Visible = true;
            _tChart.Chart.Legend.LegendStyle = LegendStyles.Series;
            _tChart.Chart.Axes.Left.Ticks = new Steema.TeeChart.Axis.TicksPen { Width = 2, Visible = true, Color = Color.White, Style = DashStyle.Solid, Length = 10, };
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.Labels.Visible = true;
            _tChart.Chart.Axes.Bottom.Title.Visible = true;
            _tChart.Chart.Axes.Left.Labels.Angle = 0;

            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Bottom.Grid.Visible = false;
            _tChart.Chart.Panel.MarginLeft = 5;

            bar1.Marks.Pen.Visible = false;
            bar1.Marks.TailStyle = MarksTail.None;
        }

        private void InitHorizLineChart()
        {
            HorizLine line1;
            HorizLine line2;

            line1 = new HorizLine();
            line2 = new HorizLine();

            // Modificación del "Chart" base
            _tChart.Chart.Legend.Visible = true;
            _tChart.Chart.Header.Text = "Bear population in two forests";
            _tChart.Chart.Series.Add(line1);
            _tChart.Chart.Series.Add(line2);

            line1.FillSampleValues(5);
            line2.FillSampleValues(5);

            // Propiedades de la "line1"
            line1.LinePen.Width = 6;
            line1.Pointer.InflateMargins = true;
            line1.Pointer.Visible = true;
            line1.Pointer.HorizSize = 11;
            line1.Pointer.VertSize = 11;
            line1.Pointer.Pen.Color = Color.White;
            line1.Pointer.Pen.Width = 5;
            line1.Pointer.Style = PointerStyles.Sphere;

            line1.Chart.Panning.Allow = ScrollModes.None;
            line1.LineHeight = 25;
            line1.ClickableLine = true;
            line1.ClickTolerance = 40;
            line1.RecalcOptions = RecalcOptions.OnModify;
            line1.Title = "Forest 1";
            line1.DefaultNullValue = 0;
            line1.VertAxis = VerticalAxis.Both;
            line1.HorizAxis = HorizontalAxis.Both;

            // Propiedades de la "line2"
            line2.Pointer = new SeriesPointer(_tChart.Chart, line2) { InflateMargins = true, HorizSize = 11, VertSize = 11, Pen = new ChartPen { Color = Color.White, Width = 5 }, Style = PointerStyles.Sphere };
            line2.LineHeight = 25;
            line2.LinePen.Width = 6;
            line2.ClickableLine = true;
            line2.ClickTolerance = 40;
            line2.RecalcOptions = RecalcOptions.OnModify;
            line2.Title = "Forest 2";
            line2.VertAxis = VerticalAxis.Both;
            line2.HorizAxis = HorizontalAxis.Both;

            // Características de los ejes del "Chart" base
            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue, _tChart.Chart.Axes.Left.MaxYValue);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Left.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Bottom.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Bottom.Increment = 20;
            _tChart.Chart.Axes.Left.Increment = 1;
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.Title = null;
            _tChart.Chart.Axes.Bottom.Title = null;
            _tChart.Chart.Axes.Left.AxisPen.Visible = false;
            _tChart.Chart.Axes.Left.Ticks.Visible = false;
            _tChart.Chart.Axes.Left.Grid.Visible = true;
            _tChart.Chart.Legend.LegendStyle = LegendStyles.Series;
            _tChart.Chart.Axes.Bottom.Grid.Visible = false;
            _tChart.Chart.Panel.MarginLeft = 5;
        }

        private void InitDonutChart()
        {
            Donut donut1;
            donut1 = new Donut();

            _tChart.Chart.Header.Text = "How old are the workers";
            _tChart.Chart.Series.Add(donut1);
            _tChart.Chart.Legend.Visible = true;

            donut1.AutoCircleResize = true;
            donut1.RecalcOptions = RecalcOptions.OnModify;
            donut1.DefaultNullValue = 0;
            donut1.Circled = true;
            donut1.AutoPenColor = false;
            donut1.DarkPen = false;
            donut1.Pen.Width = 3;
            donut1.Pen.Style = DashStyle.Solid;
            donut1.Pen.Visible = true;
            donut1.Pen.Color = Color.White;
            donut1.VertAxis = VerticalAxis.Both;
            donut1.HorizAxis = HorizontalAxis.Both;

            donut1.CustomXRadius = (int)_tChart.Chart.Axes.Bottom.MaxXValue;
            donut1.FillSampleValues(6);

            donut1.Title = "pieAnimals";

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue, _tChart.Chart.Axes.Left.MaxYValue);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinYValue, _tChart.Chart.Axes.Bottom.MaxXValue);

            _tChart.Chart.Axes.Bottom.Increment = 5;
            _tChart.Chart.Axes.Left.Increment = 5;

            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Ticks = new Steema.TeeChart.Axis.TicksPen { Width = 2, Visible = true, Color = Color.FromArgb(0, 200, 200, 200), Style = DashStyle.Solid, Length = 10, };
            _tChart.Chart.Axes.Bottom.Visible = true;

            _tChart.Chart.Axes.Left.Title.Angle = 90;
            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Bottom.Grid.Visible = false;
            _tChart.Chart.Panel.MarginLeft = 5;

            _tChart.Chart.Legend.LegendStyle = LegendStyles.Values;
            _tChart.Chart.Legend.Symbol.Position = LegendSymbolPosition.Right;

            donut1.Marks.Pen.Visible = false;
            donut1.Marks.Style = MarksStyles.Percent;
            donut1.MarksPie.VertCenter = true;
            donut1.MarksPie.InsideSlice = true;
        }

        private void InitBubbleChart()
        {
            Bubble bubble1;
            bubble1 = new Bubble();

            _tChart.Chart.Header.Text = "Market share study";
            _tChart.Chart.Series.Add(bubble1);
            _tChart.Chart.Legend.Visible = false;

            bubble1.RecalcOptions = RecalcOptions.OnModify;
            bubble1.DefaultNullValue = 0;
            bubble1.FillSampleValues(6);

            bubble1.Pointer.Brush.Color = Color.FromArgb(255, 255, 0, 0);
            bubble1.Pointer.InflateMargins = false;
            bubble1.Pointer.Style = PointerStyles.Circle;
            bubble1.Title = "bubble1";
            bubble1.VertAxis = VerticalAxis.Both;
            bubble1.HorizAxis = HorizontalAxis.Both;

            _tChart.Chart.Axes.Bottom.Increment = 5;
            _tChart.Chart.Axes.Left.Increment = 15;

            _tChart.Chart.Axes.Left.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Bottom.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Left.Title.AutoSize = true;
            _tChart.Chart.Axes.Left.Title.Font.Size = 14;
            _tChart.Chart.Axes.Bottom.Title.Font.Size = 14;
            _tChart.Chart.Axes.Left.Title.Alignment = Android.Graphics.Paint.Align.Center;

            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Ticks = new Steema.TeeChart.Axis.TicksPen { Width = 2, Visible = true, Color = Color.FromArgb(200, 200, 200), Style = DashStyle.Solid, Length = 10, };
            _tChart.Chart.Axes.Bottom.Visible = true;

            _tChart.Chart.Axes.Left.Title.Angle = 90;
            _tChart.Chart.Axes.Left.Grid.Visible = false;

            _tChart.Chart.Axes.Bottom.Title.Text = "Number of products";
            _tChart.Chart.Axes.Left.Title.Text = "Sales";

            bubble1.Marks.Visible = true;
            bubble1.Marks.FollowSeriesColor = true;
            bubble1.Marks.Pen.Width = 1;
            bubble1.Marks.Pen.Color = Color.White;
            bubble1.Marks.Frame.Color = Color.White;
        }

        private void InitGanttChart()
        {
            Gantt gantt1;
            gantt1 = new Gantt();

            // Modificación del "Chart" base
            _tChart.Chart.Legend.Visible = true;
            _tChart.Chart.Header.Text = "The development of the product";
            _tChart.Chart.Series.Add(gantt1);

            gantt1.FillSampleValues(7);

            // Propiedades de la "line1"
            gantt1.LinePen.Width = 6;
            gantt1.Pointer.InflateMargins = true;
            gantt1.Pointer.Visible = true;
            gantt1.Pointer.HorizSize = 11;
            gantt1.Pointer.VertSize = 11;
            gantt1.Pointer.Pen.Color = Color.White;
            gantt1.Pointer.Pen.Width = 1;
            gantt1.Pointer.Style = PointerStyles.Rectangle;
            gantt1.RecalcOptions = RecalcOptions.OnModify;
            gantt1.Title = "Product 1";
            gantt1.DefaultNullValue = 0;
            gantt1.ConnectingPen.Visible = true;
            gantt1.ConnectingPen.Color = Color.Black;
            gantt1.ConnectingPen.Width = 2;
            gantt1.NextTasks[0] = 1;
            gantt1.NextTasks[1] = 2;
            gantt1.NextTasks[2] = 5;
            gantt1.NextTasks[3] = 4;
            gantt1.NextTasks[4] = 6;

            gantt1.VertAxis = VerticalAxis.Both;
            gantt1.HorizAxis = HorizontalAxis.Both;

            // Características de los ejes del "Chart" base
            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue, _tChart.Chart.Axes.Left.MaxYValue + 1);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Left.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Bottom.Labels.DateTimeFormat = "dd/MM/yy";
            _tChart.Chart.Axes.Bottom.Increment = 15;
            _tChart.Chart.Axes.Left.Increment = 1;
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.Title = null;
            _tChart.Chart.Axes.Bottom.Title = null;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Ticks.Visible = false;
            _tChart.Chart.Axes.Left.Grid.Visible = true;
            _tChart.Chart.Legend.Visible = false;
            _tChart.Chart.Axes.Bottom.Grid.Visible = false;
            _tChart.Chart.Panel.MarginRight = 6;
            _tChart.Chart.Axes.Left.LabelsOnAxis = true;
            _tChart.Chart.Axes.Left.Ticks = new TicksPen { Width = 2, Visible = true, Color = Color.White, Style = DashStyle.Solid, Length = 10, };
        }

        private void InitShapeChart()
        {
            Steema.TeeChart.Styles.Shape shape1;
            Steema.TeeChart.Styles.Shape shape2;
            Steema.TeeChart.Styles.Shape shape3;
            Steema.TeeChart.Styles.Shape shape4;

            shape1 = new Steema.TeeChart.Styles.Shape();
            shape2 = new Steema.TeeChart.Styles.Shape();
            shape3 = new Steema.TeeChart.Styles.Shape();
            shape4 = new Steema.TeeChart.Styles.Shape();

            _tChart.Chart.Series.Add(shape4);
            _tChart.Chart.Series.Add(shape3);
            _tChart.Chart.Series.Add(shape2);
            _tChart.Chart.Series.Add(shape1);

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue, _tChart.Chart.Axes.Left.MaxYValue + 100);
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.Title.Visible = false;
            _tChart.Chart.Axes.Left.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Left.Increment = 10;
            _tChart.Chart.Axes.Left.AxisPen.Visible = false;
            _tChart.Chart.Axes.Left.Ticks.Visible = true;
            _tChart.Chart.Axes.Left.Ticks = new TicksPen { Width = 2, Visible = true, Color = Color.FromArgb(200, 200, 200), Style = DashStyle.Solid, Length = 10, };
            _tChart.Chart.Axes.Left.Grid.Visible = true;

            _tChart.Chart.Axes.Bottom.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue + 100);
            _tChart.Chart.Axes.Bottom.Title.Visible = false;
            _tChart.Chart.Axes.Left.Increment = 10;
            _tChart.Chart.Axes.Bottom.Grid.Visible = false;
            _tChart.Chart.Axes.Bottom.Visible = true;
            _tChart.Chart.Axes.Bottom.Ticks.Visible = true;
            _tChart.Chart.Axes.Left.Ticks = new TicksPen { Width = 2, Visible = true, Color = Color.FromArgb(200, 200, 200), Style = DashStyle.Solid, Length = 10, };

            _tChart.Chart.Header.Text = "Some shapes";

            _tChart.Chart.Legend.Visible = true;
            _tChart.Chart.Legend.LegendStyle = LegendStyles.Series;
            _tChart.Chart.Legend.TextSymbolGap = 30;

            _tChart.Chart.Panel.MarginLeft = 2;

            shape1.RecalcOptions = RecalcOptions.OnModify;
            shape1.Title = "Diamond";
            shape1.DefaultNullValue = 0;
            shape1.Style = ShapeStyles.Diamond;
            shape1.Visible = true;
            shape1.FillSampleValues();
            shape1.VertAxis = VerticalAxis.Both;
            shape1.HorizAxis = HorizontalAxis.Both;

            shape2.RecalcOptions = RecalcOptions.OnModify;
            shape2.Title = "Circle";
            shape2.DefaultNullValue = 0;
            shape2.Style = ShapeStyles.Circle;
            shape2.Visible = true;
            shape2.FillSampleValues();
            shape2.VertAxis = VerticalAxis.Both;
            shape2.HorizAxis = HorizontalAxis.Both;

            shape3.RecalcOptions = RecalcOptions.OnModify;
            shape3.Title = "Star";
            shape3.DefaultNullValue = 0;
            shape3.Style = ShapeStyles.Star;
            shape3.Visible = true;
            shape3.FillSampleValues();
            shape3.VertAxis = VerticalAxis.Both;
            shape3.HorizAxis = HorizontalAxis.Both;

            shape4.RecalcOptions = RecalcOptions.OnModify;
            shape4.Title = "Cube";
            shape4.DefaultNullValue = 0;
            shape4.Style = ShapeStyles.Cube;
            shape4.Visible = true;
            shape4.FillSampleValues();
            shape4.VertAxis = VerticalAxis.Both;
            shape4.HorizAxis = HorizontalAxis.Both;
        }

        private void InitPointScatterChart()
        {
            Points point1;
            Points point2;
            Points point3;
            Points point4;
            point1 = new Points();
            point2 = new Points();
            point3 = new Points();
            point4 = new Points();

            _tChart.Chart.Legend.Visible = true;
            _tChart.Chart.Header.Text = "Pointer Series";
            _tChart.Chart.Series.Add(point1);
            _tChart.Chart.Series.Add(point2);
            _tChart.Chart.Series.Add(point3);
            _tChart.Chart.Series.Add(point4);

            point1.FillSampleValues();
            point2.FillSampleValues();
            point3.FillSampleValues();
            point4.FillSampleValues();

            // Propiedades del "point1"
            point1.LinePen.Width = 6;
            point1.Pointer.InflateMargins = true;
            point1.Pointer.Visible = true;
            point1.Pointer.HorizSize = 11;
            point1.Pointer.VertSize = 11;
            point1.Pointer.Pen.Color = Color.White;
            point1.Pointer.Pen.Width = 5;
            point1.Pointer.Style = PointerStyles.Sphere;

            point1.Chart.Panning.Allow = ScrollModes.None;
            point1.RecalcOptions = RecalcOptions.OnModify;
            point1.Title = "Point1";
            point1.DefaultNullValue = 0;
            point1.VertAxis = VerticalAxis.Both;
            point1.HorizAxis = HorizontalAxis.Both;

            // Propiedades del "point2"
            point2.LinePen.Width = 6;
            point2.Pointer.InflateMargins = true;
            point2.Pointer.Visible = true;
            point2.Pointer.HorizSize = 11;
            point2.Pointer.VertSize = 11;
            point2.Pointer.Pen.Color = Color.White;
            point2.Pointer.Pen.Width = 5;
            point2.Pointer.Style = PointerStyles.Sphere;

            point2.Chart.Panning.Allow = ScrollModes.None;
            point2.RecalcOptions = RecalcOptions.OnModify;
            point2.Title = "Point2";
            point2.DefaultNullValue = 0;
            point2.VertAxis = VerticalAxis.Both;
            point2.HorizAxis = HorizontalAxis.Both;

            // Propiedades del "point3"
            point3.LinePen.Width = 6;
            point3.Pointer.InflateMargins = true;
            point3.Pointer.Visible = true;
            point3.Pointer.HorizSize = 11;
            point3.Pointer.VertSize = 11;
            point3.Pointer.Pen.Color = Color.White;
            point3.Pointer.Pen.Width = 5;
            point3.Pointer.Style = PointerStyles.Sphere;

            point3.Chart.Panning.Allow = ScrollModes.None;
            point3.RecalcOptions = RecalcOptions.OnModify;
            point3.Title = "Point3";
            point3.DefaultNullValue = 0;
            point3.VertAxis = VerticalAxis.Both;
            point3.HorizAxis = HorizontalAxis.Both;

            // Propiedades del "point4"
            point4.LinePen.Width = 6;
            point4.Pointer.InflateMargins = true;
            point4.Pointer.Visible = true;
            point4.Pointer.HorizSize = 11;
            point4.Pointer.VertSize = 11;
            point4.Pointer.Pen.Color = Color.White;
            point4.Pointer.Pen.Width = 5;
            point4.Pointer.Style = PointerStyles.Sphere;
        
            point4.Chart.Panning.Allow = ScrollModes.None;
            point4.RecalcOptions = RecalcOptions.OnModify;
            point4.Title = "Point4";
            point4.DefaultNullValue = 0;
            point4.VertAxis = VerticalAxis.Both;
            point4.HorizAxis = HorizontalAxis.Both;

            // Características de los ejes del "Chart" base
            _tChart.Chart.Axes.Left.SetMinMax(0, _tChart.Chart.Axes.Left.MaxYValue + 2);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Left.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Bottom.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Bottom.Increment = 1;
            _tChart.Chart.Axes.Left.Increment = 3;
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.Title = null;
            _tChart.Chart.Axes.Bottom.Title = null;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Grid.Visible = true;
            _tChart.Chart.Legend.LegendStyle = LegendStyles.Series;
            _tChart.Chart.Axes.Bottom.Grid.Visible = false;
            _tChart.Chart.Axes.Left.Ticks.Visible = true;
            _tChart.Chart.Panel.MarginLeft = 2;
        }

        private void InitSemiDonutChart()
        {
            Donut donut1;
            donut1 = new Donut();

            _tChart.Chart.Header.Text = "How old are the workers";
            _tChart.Chart.Series.Add(donut1);
            _tChart.Chart.Legend.Visible = true;

            donut1.AutoCircleResize = true;
            donut1.RecalcOptions = RecalcOptions.OnModify;
            donut1.DefaultNullValue = 0;
            donut1.Circled = true;
            donut1.AutoPenColor = false;
            donut1.DarkPen = false;
            donut1.Pen.Width = 3;
            donut1.Pen.Style = DashStyle.Solid;
            donut1.Pen.Visible = true;
            donut1.Pen.Color = Color.White;
            donut1.AngleSize = 180;
            donut1.VertAxis = VerticalAxis.Both;
            donut1.HorizAxis = HorizontalAxis.Both;

            donut1.CustomXRadius = (int)_tChart.Chart.Axes.Bottom.MaxXValue;
            donut1.FillSampleValues();

            donut1.Title = "pieAnimals";

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue, _tChart.Chart.Axes.Left.MaxYValue);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinYValue, _tChart.Chart.Axes.Bottom.MaxXValue);

            _tChart.Chart.Axes.Bottom.Increment = 5;
            _tChart.Chart.Axes.Left.Increment = 5;

            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Ticks = new Steema.TeeChart.Axis.TicksPen { Width = 2, Visible = true, Color = Color.FromArgb(0, 200, 200, 200), Style = DashStyle.Solid, Length = 10, };
            _tChart.Chart.Axes.Bottom.Visible = true;

            _tChart.Chart.Axes.Left.Title.Angle = 90;
            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Bottom.Grid.Visible = false;
            _tChart.Chart.Panel.MarginLeft = 5;

            _tChart.Chart.Legend.LegendStyle = LegendStyles.Values;
            _tChart.Chart.Legend.Symbol.Position = LegendSymbolPosition.Right;

            _tChart.Chart.SubHeader.Visible = true;
            _tChart.Chart.SubHeader.Text = "A";
            _tChart.Chart.SubHeader.Font.Size = 80;
            _tChart.Chart.SubHeader.Color = Color.White;
            _tChart.Chart.SubHeader.Transparency = 100;

            donut1.Marks.Visible = true;
            //donut1.Marks.Color = Color.Transparent;
            //donut1.Marks.BackColor = Color.Transparent;
            //donut1.MarksPie.VertCenter = true;
            //donut1.MarksPie.InsideSlice = true;
            //donut1.Marks.Pen.Color = Color.Transparent;
        }

        private void InitSemiPieChart()
        {
            Pie pie1;
            pie1 = new Pie();

            _tChart.Chart.Header.Text = "Percentage of animals in the zoo (%)";
            _tChart.Chart.Series.Add(pie1);
            _tChart.Chart.Legend.Visible = true;

            pie1.AutoCircleResize = true;
            pie1.RecalcOptions = RecalcOptions.OnModify;
            pie1.DefaultNullValue = 0;
            pie1.Circled = true;
            pie1.AutoPenColor = false;
            pie1.DarkPen = false;
            pie1.Pen.Width = 3;
            pie1.Pen.Style = DashStyle.Solid;
            pie1.Pen.Visible = true;
            pie1.Pen.Color = Color.White;
            pie1.AngleSize = 180;
            pie1.VertAxis = VerticalAxis.Both;
            pie1.HorizAxis = HorizontalAxis.Both;

            pie1.CustomXRadius = (int)_tChart.Chart.Axes.Bottom.MaxXValue;
            pie1.FillSampleValues();

            pie1.Title = "pieAnimals";

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue, _tChart.Chart.Axes.Left.MaxYValue);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinYValue, _tChart.Chart.Axes.Bottom.MaxXValue);

            _tChart.Chart.Axes.Bottom.Increment = 5;
            _tChart.Chart.Axes.Left.Increment = 5;

            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Ticks = new Steema.TeeChart.Axis.TicksPen { Width = 2, Visible = true, Color = Color.FromArgb(200, 200, 200), Style = DashStyle.Solid, Length = 10, };
            _tChart.Chart.Axes.Bottom.Visible = true;

            _tChart.Chart.Axes.Left.Title.Angle = 90;
            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Bottom.Grid.Visible = false;
            _tChart.Chart.Legend.LegendStyle = LegendStyles.Values;
            _tChart.Chart.Legend.Alignment = LegendAlignments.Bottom;
            _tChart.Chart.Legend.AutoSize = true;
            _tChart.Chart.Legend.ResizeChart = true;
            _tChart.Chart.Legend.TextAlign = Android.Graphics.Paint.Align.Center;
            _tChart.Chart.Legend.Font.Size = 13;

            _tChart.Chart.SubHeader.Visible = true;
            _tChart.Chart.SubHeader.Text = "A";
            _tChart.Chart.SubHeader.Font.Size = 80;
            _tChart.Chart.SubHeader.Color = Color.White;
            _tChart.Chart.SubHeader.Transparency = 100;

            _tChart.Chart.Legend.Symbol.Position = LegendSymbolPosition.Right;

            pie1.Marks.Visible = true;
            pie1.MarksPie.InsideSlice = true;
            _tChart.Chart.Panel.MarginLeft = 5;
            pie1.MarksPie.LegSize = 20;
            pie1.MarksPie.VertCenter = true;
            pie1.MarksPie.Rotated = true;
        }

        private void InitMultPiesChart()
        {
            Pie pie1;
            Pie pie2;
            Pie pie3;
            Pie pie4;

            pie1 = new Pie();
            pie2 = new Pie();
            pie3 = new Pie();
            pie4 = new Pie();
            Pie[] multiPie = new Pie[4] { pie1, pie2, pie3, pie4 };

            _tChart.Chart.Header.Text = "Objects in different house";
            _tChart.Chart.Legend.Visible = true;
            _tChart.Chart.Panel.MarginLeft = 3;

            for (int i = 0; i < 4; i++) { CrearPie(multiPie[i], i); }
            
            for (int i = 0; i < _tChart.Chart.Series.Count; i++) { _tChart.Chart.Series[i].Marks.Style = MarksStyles.Label; _tChart.Chart.Series[i].Marks.Font.Size = 12; }
            pie2.RotationAngle = 25;
            pie4.RotationAngle = 25;
        }

        private void MarksAplicar(Pie pie)
        {
            pie.Marks.Visible = true;
            pie.MarksPie.InsideSlice = true;
            pie.MarksPie.LegSize = 20;
            pie.MarksPie.VertCenter = true;        
        }

        private void CrearPie(Pie pie, int position)
        {
            _tChart.Chart.Series.Add(pie);

            pie.CustomXRadius = (MainActivity.deviceWidth / 2) - (MainActivity.deviceWidth / 3) + 20;
            pie.CustomYRadius = (MainActivity.deviceHeight / 2) - (MainActivity.deviceHeight / 3) - 50;
            if (MainActivity.deviceWidth < 600) pie.Marks.Font.Size = 15;
            else pie.Marks.Font.Size = 18;

            pie.MultiPie = MultiPies.Automatic;
            pie.MarksPie.InsideSlice = true;
            pie.MultiPie = MultiPies.Automatic;
            pie.AutoCircleResize = true;
            pie.RecalcOptions = RecalcOptions.OnModify;
            pie.DefaultNullValue = 0;
            pie.AutoPenColor = false;
            pie.DarkPen = false;
            pie.Pen.Width = 3;
            pie.Pen.Style = DashStyle.Solid;
            pie.Pen.Visible = true;
            pie.Pen.Color = Color.White;
            pie.DefaultNullValue = 0;
            pie.VertAxis = VerticalAxis.Both;
            pie.HorizAxis = HorizontalAxis.Both;
            pie.UniqueCustomRadius = true;

            pie.FillSampleValues(4);

            pie.Title = "House " + (position + 1);
            MarksAplicar(pie);
        }

        private void InitStackAreaChart()
        {
            Area area1;
            Area area2;
            // Inicializar variables
            area1 = new Area();
            area2 = new Area();

            // Propiedades del "Chart" base
            _tChart.Chart.Series.Add(area2);
            _tChart.Chart.Series.Add(area1);
            _tChart.Chart.Legend.Visible = true;
            _tChart.Chart.Header.Text = "Mensual sells by two companies";
            _tChart.Chart.Axes.Bottom.LabelsOnAxis = true;

            // Propiedades de la "area1"
            area1.Title = "Company 1";
            area1.RecalcOptions = RecalcOptions.OnModify;
            area1.DefaultNullValue = 0;
            area1.ClickableLine = true;
            area1.AreaLines.Visible = false;
            area1.LinePen.Width = 5;
            area1.Pointer.Visible = true;
            area1.Pointer.Style = PointerStyles.Nothing;
            area1.Pointer.InflateMargins = false;
            area1.LinePen.Style = DashStyle.Solid;
            area2.LinePen.Width = 5;
            area1.ClickTolerance = 30;
            area1.FillSampleValues(5);
            area1.VertAxis = VerticalAxis.Both;
            area1.HorizAxis = HorizontalAxis.Both;
            area1.Marks.OnTop = true;

            // Propiedades de la "area2"
            area2.Title = "Company 2";
            area2.RecalcOptions = RecalcOptions.OnModify;
            area2.DefaultNullValue = 0;
            area2.ClickableLine = true;
            area2.ClickTolerance = 30;
            area2.Pointer.Visible = true;
            area2.Pointer.Style = PointerStyles.Nothing;
            area2.LinePen.Style = DashStyle.Solid;
            area2.FillSampleValues();
            area2.AreaLines.Visible = false;
            area2.LinePen.Width = 5;
            area2.VertAxis = VerticalAxis.Both;
            area2.HorizAxis = HorizontalAxis.Both;
            area2.Marks.OnTop = true;

            area1.Stacked = CustomStack.Stack;
            area2.Stacked = CustomStack.Stack;
            area1.StackGroup = 1;
            area2.StackGroup = 1;

            // Propieades de los ejes del "Chart" base
            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue, _tChart.Chart.Axes.Left.MaxYValue + 20);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Left.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Bottom.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Bottom.Labels.TextAlign = Android.Graphics.Paint.Align.Left;
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.Increment = 20;
            _tChart.Chart.Axes.Left.Title.Visible = false;
            _tChart.Chart.Axes.Left.Ticks = new Steema.TeeChart.Axis.TicksPen { Width = 2, Visible = true, Color = Color.FromArgb(200, 200, 200), Style = DashStyle.Solid, Length = 10 };
            _tChart.Chart.Axes.Left.LabelsOnAxis = true;

            _tChart.Chart.Axes.Left.Labels.CustomSize = 10;
            _tChart.Chart.Axes.Bottom.Title.Visible = false;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Bottom.Grid.Visible = false;
            _tChart.Chart.Legend.LegendStyle = LegendStyles.Series;
            _tChart.Chart.Panel.MarginRight = 5;
            _tChart.Chart.Panel.MarginLeft = 4;
        }

        private void InitRealTimeChart()
        {
            FastLine fastLine1;
            FastLine fastLine2;
            Timer timer = new Timer();
            int tmprandom;

            fastLine1 = new FastLine();
            fastLine2 = new FastLine();
            pointsCreate = 0;

            _tChart.Chart.Header.Text = "Fast random picture";
            _tChart.Chart.Series.Add(fastLine1);
            _tChart.Chart.Series.Add(fastLine2);
            _tChart.Chart.Legend.Visible = false;

            fastLine1.RecalcOptions = RecalcOptions.OnModify;
            fastLine1.DefaultNullValue = 0;
            fastLine1.AutoRepaint = true;
            fastLine1.VertAxis = VerticalAxis.Both;
            fastLine1.HorizAxis = HorizontalAxis.Both;

            fastLine2.RecalcOptions = RecalcOptions.OnModify;
            fastLine2.DefaultNullValue = 0;
            fastLine2.AutoRepaint = true;
            fastLine2.VertAxis = VerticalAxis.Both;
            fastLine2.HorizAxis = HorizontalAxis.Both;

            Random r = new Random();
            for (int t = 1; t < 1000; t++)
            {
                tmprandom = r.Next(Math.Abs(500 - t)) - (Math.Abs(500 - t) / 2);
                fastLine1.Add(1000 - t + tmprandom);
                fastLine2.Add(t + tmprandom);
            }

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue - 100, _tChart.Chart.Axes.Left.MaxYValue + 100);
            _tChart.Chart.Axes.Bottom.SetMinMax(0, _tChart.Chart.Axes.Bottom.MaxXValue + 3);

            _tChart.Chart.Axes.Bottom.Increment = 5;
            _tChart.Chart.Axes.Left.Increment = 15;

            _tChart.Chart.Axes.Left.Labels.ValueFormat = "0K";
            _tChart.Chart.Axes.Bottom.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Left.Title.Pen = new ChartPen { Color = Color.Black, Width = 15 };

            _tChart.Chart.Axes.Left.Title.Visible = false;
            _tChart.Chart.Axes.Bottom.Title.Visible = false;

            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Ticks = new Steema.TeeChart.Axis.TicksPen { Width = 2, Visible = true, Color = Color.FromArgb(200, 200, 200), Style = DashStyle.Solid, Length = 10, };
            _tChart.Chart.Axes.Bottom.Visible = true;

            _tChart.Chart.Axes.Left.Title.Angle = 90;
            _tChart.Chart.Axes.Left.Grid.Visible = false;

            _tChart.Chart.Panel.MarginLeft = 5;
            timer.Interval = 200;
            timer.Elapsed += TimerFastLine_Elapsed;
            timer.Start();
        }

        Random randomFastLine = new Random();
        int color = 0;
        bool numMaxim = false;
        int numRepeat;
        int pointsCreate;
        private void TimerFastLine_Elapsed(object sender, ElapsedEventArgs e)
        {
            int tmprandom;
            FastLine fastLine1 = (FastLine)_tChart.Series[0];
            FastLine fastLine2 = (FastLine)_tChart.Series[1];
            if (fastLine1 != null && fastLine2 != null && numMaxim == false)
            {
                fastLine1.Clear();
                fastLine2.Clear();

                for (int t = 0; t < 1000; t++)
                {
                    tmprandom = randomFastLine.Next(Math.Abs(500 - t)) - (Math.Abs(500 - t) / 2);
                    fastLine1.Add(1000 - t + tmprandom);
                    fastLine2.Add(t + tmprandom);
                }

                color++;
                if (color == 8) { color = 0; }

                pointsCreate += 2000;

            }

            if (pointsCreate<Int32.MaxValue - 2000) { _tChart.Chart.Header.Text = pointsCreate.ToString() + " points created in " + (Math.Round((double)((pointsCreate / 6.20) / 1000), 0)).ToString() + " seconds"; }
            else { numMaxim = true; _tChart.Chart.Header.Text = "Finish"; }
        }

        private void InitBubbleTranspChart()
        {
            Bubble bubble1;
            bubble1 = new Bubble();

            _tChart.Chart.Header.Text = "Market share study";
            _tChart.Chart.Series.Add(bubble1);
            _tChart.Chart.Legend.Visible = false;

            bubble1.RecalcOptions = RecalcOptions.OnModify;
            bubble1.DefaultNullValue = 0;

            bubble1.FillSampleValues(5);

            bubble1.Pointer.Brush.Color = Color.FromArgb(255, 255, 0, 0);
            bubble1.Pointer.InflateMargins = false;
            bubble1.Pointer.Style = PointerStyles.Circle;
            bubble1.Title = "bubble1";

            bubble1.Transparency = 50;
            bubble1.VertAxis = VerticalAxis.Both;
            bubble1.HorizAxis = HorizontalAxis.Both;

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue - 5, _tChart.Chart.Axes.Left.MaxYValue + 5);
            _tChart.Chart.Axes.Bottom.SetMinMax(0, _tChart.Chart.Axes.Bottom.MaxXValue + 3);

            _tChart.Chart.Axes.Bottom.Increment = 5;
            _tChart.Chart.Axes.Left.Increment = 15;

            _tChart.Chart.Axes.Left.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Bottom.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Left.Title.AutoSize = true;
            _tChart.Chart.Axes.Left.Title.Font.Size = 14;
            _tChart.Chart.Axes.Bottom.Title.Font.Size = 14;
            _tChart.Chart.Axes.Left.Title.Alignment = Android.Graphics.Paint.Align.Center;

            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Ticks = new Steema.TeeChart.Axis.TicksPen { Width = 2, Visible = true, Color = Color.FromArgb(200, 200, 200), Style = DashStyle.Solid, Length = 10, };
            _tChart.Chart.Axes.Bottom.Visible = true;

            _tChart.Chart.Axes.Left.Title.Angle = 90;
            _tChart.Chart.Axes.Left.Grid.Visible = false;

            _tChart.Chart.Axes.Bottom.Title.Text = "Number of products";
            _tChart.Chart.Axes.Left.Title.Text = "Sales";

            bubble1.Marks.Visible = true;
        }

        private void InitBarGradientChart()
        {
            Bar bar1;
            Bar bar2;
            bar1 = new Bar();
            bar2 = new Bar();

            _tChart.Chart.Legend.Visible = true;
            _tChart.Chart.Header.Text = "Time spent on certain activities";
            _tChart.Chart.Series.Add(bar1);
            _tChart.Chart.Series.Add(bar2);

            bar1.RecalcOptions = RecalcOptions.OnModify;
            bar1.Title = "Man 1";
            bar1.DefaultNullValue = 0;
            bar1.FillSampleValues(4);
            bar1.MarksLocation = MarksLocation.Start;
            bar1.Marks.Style = MarksStyles.Value;
            bar1.BarWidthPercent = 80;
            bar1.Gradient.Visible = true;
            bar1.Gradient.Direction = GradientDirection.TopBottom;
            bar1.VertAxis = VerticalAxis.Both;
            bar1.HorizAxis = HorizontalAxis.Both;

            bar2.RecalcOptions = RecalcOptions.OnModify;
            bar2.Title = "Man 2";
            bar2.DefaultNullValue = 0;
            bar2.FillSampleValues(4);
            bar2.ZOrder = 0;
            bar2.Marks.Style = MarksStyles.Value;
            bar2.MarksLocation = MarksLocation.Start;
            bar2.BarWidthPercent = 80;
            bar2.Gradient.Visible = true;
            bar2.Gradient.Direction = GradientDirection.TopBottom;
            bar2.VertAxis = VerticalAxis.Both;
            bar2.HorizAxis = HorizontalAxis.Both;

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue, _tChart.Chart.Axes.Left.MaxYValue + 10);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Left.Title = null;
            _tChart.Chart.Axes.Bottom.Title = null;
            _tChart.Chart.Axes.Left.Visible = false;
            _tChart.Chart.Axes.Bottom.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Left.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Bottom.Grid.Visible = false;
            _tChart.Chart.Axes.Left.Increment = 2;
            _tChart.Chart.Legend.LegendStyle = LegendStyles.Series;
            //BaseChart.Chart.ClickSeries += Chart_ClickSeries;
            _tChart.Chart.Axes.Left.Labels.CustomSize = 0;
        }

        private void InitBarStylesChart()
        {
            Bar bar1;
            bar1 = new Bar();

            _tChart.Chart.Legend.Visible = true;
            _tChart.Chart.Header.Text = "Product sale";
            _tChart.Chart.Series.Add(bar1);

            bar1.RecalcOptions = RecalcOptions.OnModify;
            bar1.Title = "ConeBar1";
            bar1.DefaultNullValue = 0;
            bar1.FillSampleValues(5);
            bar1.MarksOnBar = false;
            bar1.Marks.Style = MarksStyles.Value;
            bar1.BarWidthPercent = 90;
            bar1.BarStyle = BarStyles.Arrow;
            bar1.VertAxis = VerticalAxis.Both;
            bar1.HorizAxis = HorizontalAxis.Both;

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue, _tChart.Chart.Axes.Left.MaxYValue);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Left.Ticks.Visible = false;
            _tChart.Chart.Axes.Left.Title = null;
            _tChart.Chart.Axes.Bottom.Title = null;
            _tChart.Chart.Axes.Left.Ticks.Visible = false;
            _tChart.Chart.Axes.Bottom.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Left.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Bottom.Grid.Visible = false;
            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Left.Increment = 2;
            _tChart.Chart.Legend.Visible = false;
            _tChart.Chart.Legend.LegendStyle = LegendStyles.Series;
            _tChart.Chart.Axes.Left.Labels.CustomSize = 0;
            _tChart.Chart.Axes.Bottom.LabelsOnAxis = true;
            _tChart.Chart.Footer.Visible = true;
            _tChart.Chart.Footer.Font.Size = 18;
            _tChart.Chart.Footer.Font.Color = Color.FromArgb(110, 110, 110);
            _tChart.Chart.Footer.Height = 110;

            _tChart.Chart.Axes.Left.Visible = false;
        }

        /*
        public class ToolInterpolatingLine
        {

            private Annotation annotation;
            private ColorLine colorLine;
            private TChart tChart;

            public ToolInterpolatingLine(TChart tChart)
            {
                annotation = new Annotation();
                colorLine = new ColorLine();
                this.tChart = tChart;
            }
            private void AddColorLineTool()
            {

                // Use of the Cursor Tool            
                colorLine = new ColorLine(tChart);
                colorLine.SnapChange += Cursor_SnapChange;
                colorLine.CursorClickTolerance = 1000;
                colorLine.Style = CursorToolStyles.Vertical;
                colorLine.Pen.Color = Xamarin.Forms.Color.Blue;
                colorLine.Snap = true;
                colorLine.Series = tChart.Chart.Series[0];
                colorLine.FollowMouse = false;
                //cursor.FastCursor = true;            
                // In the case to Active the CursorTool Panning ScrollMode has to be set to None            
                //tChart1.Panning.Allow = ScrollModes.None;            
                colorLine.Active = true;
                //cursor.Change += Cursor_Change;

            }

            public void RemCursorTool()
            {
                // Use of the Cursor Tool            
                annotation = null;
                tChart.Chart.Header.Text = "";
                tChart.Chart.Tools.Remove(colorLine);
            }

            public void Cursor_SnapChange(object sender, CursorChangeEventArgs e)
            {
                if (e.SnapPoint != -1)
                {
                    tChart.Chart.Header.Text = "Snap Point : " + e.SnapPoint.ToString();
                    annotation.Text = tChart.Chart.Series[0].YValues[e.SnapPoint].ToString();
                    annotation.Left = e.x - (annotation.Shape.Width / 2); annotation.Top = tChart.Chart.Series[0].CalcYPos(e.SnapPoint);
                }
            }

        }
        */

        private void InitInterpolatingLineChart()
        {
            Line line1;
            Annotation annotation = new Annotation();

            line1 = new Line();

            _tChart.Chart.Series.Add(line1);
            
            //_tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue, _tChart.Chart.Axes.Left.MaxYValue + 100);
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.Title.Visible = false;
            //_tChart.Chart.Axes.Left.Labels.ValueFormat = "0";
            //_tChart.Chart.Axes.Left.Increment = 10;
            _tChart.Chart.Axes.Left.AxisPen.Visible = false;
            _tChart.Chart.Axes.Left.Ticks.Visible = false;
            _tChart.Chart.Axes.Left.Grid.Visible = true;
            //_tChart.Chart.Axes.Bottom.Labels.ValueFormat = "0";
            //_tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Bottom.Title.Visible = false;
            //_tChart.Chart.Axes.Left.Increment = 10;
            _tChart.Chart.Axes.Bottom.Grid.Visible = false;
            _tChart.Chart.Axes.Bottom.Visible = true;
            _tChart.Chart.Axes.Bottom.Ticks.Visible = true;
            _tChart.Chart.Axes.Bottom.Ticks = new Steema.TeeChart.Axis.TicksPen { Width = 2, Visible = true, Color = Color.FromArgb(200, 200, 200), Style = DashStyle.Solid, Length = 10, };
            _tChart.Chart.Header.Text = "Interpolating Line";
            _tChart.Chart.Header.Font.Size += 4;
            _tChart.Chart.Legend.Visible = false;
            _tChart.Chart.Legend.LegendStyle = LegendStyles.Series;
            _tChart.Chart.Panel.MarginLeft = 4;

            line1.RecalcOptions = RecalcOptions.OnModify;
            line1.Title = "Line1";
            line1.ClickableLine = true;
            line1.DefaultNullValue = 0;
            line1.Visible = true;
            line1.FillSampleValues(16);
            line1.Pointer.Visible = true;
            line1.VertAxis = VerticalAxis.Both;
            line1.HorizAxis = HorizontalAxis.Both;
            line1.Color = Color.FromArgb(20, 120, 30);
            line1.Pointer.HorizSize += 4;
            line1.Pointer.VertSize += 4;

            AddColorLineTool();
        }

        private void AddColorLineTool()
        {
            ColorLine colorLine;         
            colorLine = new ColorLine(_tChart.Chart);
            colorLine.Axis = _tChart.Axes.Bottom;
            colorLine.Pen.Color = Color.Blue;
            colorLine.Value = _tChart.Axes.Bottom.MaxXValue / 2;
            colorLine.Pen.Width = 2;
            colorLine.ColorLineClickTolerance = 100;
            colorLine.DragRepaint = true;
            colorLine.AllowDrag = true;        
            colorLine.Active = true;
            colorLine.DragLine += ColorLine_DragLine;
            _tChart.Tools.Add(colorLine);
        }

        private void ColorLine_DragLine(object sender, EventArgs e)
        {
            ColorLine cLine = sender as ColorLine;
            
            int indexX = GetXIndexFromValue(_tChart.Series[0], cLine.Value);
            if (indexX != -1)
            {
                double valueY = _tChart.Series[0].YValues.Value[indexX];
                _tChart.Chart.Header.Text = "Snap Point --> X: " + Math.Round(cLine.Value, 0).ToString() + "  Y: " + valueY.ToString();
            }
            else
            {
                _tChart.Chart.Header.Text = "Interpolating Line";
            }
            //annotation.Text = BaseChart.Chart.Series[0].YValues[e.SnapPoint].ToString();
            //annotation.Left = e.x - (annotation.Shape.Width / 2); annotation.Top = BaseChart.Chart.Series[0].CalcYPos(e.SnapPoint);
        }

        #endregion

        #region PRO CHARTS

        private void InitHorizHistogramChart()
        {
            HorizHistogram horizHistoChart;

            horizHistoChart = new HorizHistogram();

            horizHistoChart.FillSampleValues(17);
            horizHistoChart.Marks.Visible = true;

            _tChart.Chart.Legend.Visible = false;
            _tChart.Chart.Axes.Left.MinorTicks.Transparency = 100;
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Left.Labels.Visible = true;
            _tChart.Chart.Title.Text = "Horiz. Histogram series";
            _tChart.Chart.Axes.Left.Automatic = true;
            _tChart.Chart.Axes.Bottom.Automatic = true;
            _tChart.Chart.Axes.Bottom.AxisPen.Transparency = 0;
            _tChart.Chart.Axes.Bottom.Visible = true;
            _tChart.Chart.Series.Add(horizHistoChart);

            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue + 75);
        }

        private void InitInvertedPyramidChart()
        {
            Pyramid pyramid1;
            pyramid1 = new Pyramid();

            _tChart.Chart.Header.Text = "Inverted Pyramid Series";
            _tChart.Chart.Series.Add(pyramid1);
            _tChart.Chart.Legend.Visible = true;
            _tChart.Chart.Walls.Left.Visible = false;
            _tChart.Chart.Walls.Left.Width = 5;

            pyramid1.DefaultNullValue = 0;
            pyramid1.Pen.Width = 3;
            pyramid1.Pen.Visible = true;
            pyramid1.Pen.Color = Color.White;
            pyramid1.Pen.Style = DashStyle.Solid;
            pyramid1.Pen.Transparency = 50;
            pyramid1.SizePercent = 80;
            pyramid1.ColorEach = false;

            pyramid1.FillSampleValues(6);

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue - 50, _tChart.Chart.Axes.Left.MaxYValue + 50);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinYValue + 0.5, _tChart.Chart.Axes.Bottom.MaxXValue - 0.5);

            _tChart.Chart.Axes.Bottom.Increment = 5;
            _tChart.Chart.Axes.Left.Increment = 5;

            _tChart.Chart.Axes.Left.Visible = false;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Ticks = new Steema.TeeChart.Axis.TicksPen { Width = 2, Visible = true, Color = Color.FromArgb(200, 200, 200), Style = DashStyle.Solid, Length = 10, };
            _tChart.Chart.Axes.Bottom.Visible = false;
            _tChart.Chart.Axes.Left.Inverted = true;

            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Bottom.Grid.Visible = false;
            _tChart.Chart.Legend.Visible = false;

            pyramid1.Marks.Style = MarksStyles.Label;
            pyramid1.Marks.Visible = false;
            pyramid1.Marks.DrawEvery = 1;
            pyramid1.Marks.AutoPosition = true;
            pyramid1.Marks.OnTop = true;
        }

        private void InitPolarBarChart()
        {
            PolarBar polarBar;
            polarBar = new PolarBar();

            polarBar.FillSampleValues(30);
            polarBar.Marks.Visible = false;
            polarBar.Circled = true;
            polarBar.CloseCircle = true;
            polarBar.Pen.Width = 5;
            polarBar.Pointer.Visible = false;
            polarBar.CircleLabelsInside = false;
            polarBar.CircleLabels = true;

            _tChart.Chart.Title.Text = "Polar Bar series";
            _tChart.Chart.Legend.Visible = false;
            _tChart.Chart.Axes.Left.MinorTicks.Transparency = 100;
            _tChart.Chart.Axes.Left.Visible = false;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Grid.Visible = true;
            _tChart.Chart.Axes.Left.Labels.Visible = true;
            _tChart.Chart.Axes.Left.Automatic = true;
            _tChart.Chart.Axes.Left.Increment = 10;
            _tChart.Chart.Axes.Bottom.Increment = 10;
            _tChart.Chart.Axes.Bottom.Automatic = true;
            _tChart.Chart.Series.Add(polarBar);
        }

        private void InitColorGridChart()
        {
            ColorGrid colorGrid;
            colorGrid = new ColorGrid();

            _tChart.Chart.Axes.Left.Automatic = true;
            _tChart.Chart.Axes.Bottom.Automatic = true;
            _tChart.Chart.Axes.Left.AxisPen.Transparency = 0;
            _tChart.Chart.Axes.Left.MinorTicks.Transparency = 0;
            _tChart.Chart.Legend.Visible = false;
            _tChart.Chart.Title.Text = "Color Grid series";

            colorGrid.FillSampleValues(20);

            colorGrid.UseColorRange = true;
            colorGrid.UsePalette = true;

            colorGrid.ColorEach = true;

            colorGrid.Pen.Color = Color.White;

            colorGrid.Marks.ArrowLength = 0;
            colorGrid.Marks.Symbol.Shadow.Height = 1;
            colorGrid.Marks.Symbol.Shadow.Visible = true;
            colorGrid.Marks.Symbol.Shadow.Width = 1;
            colorGrid.NumXValues = 25;
            colorGrid.NumZValues = 25;
            colorGrid.PaletteMin = 4;
            colorGrid.PaletteStep = 2;
            colorGrid.Title = "Color Grid";

            colorGrid.XValues.DataMember = "X";
            colorGrid.YValues.DataMember = "Y";
            colorGrid.ZValues.DataMember = "Z";

            _tChart.Chart.Series.Add(colorGrid);
        }

        private void InitVolumeChart()
        {
            Volume volume;
            volume = new Volume();

            volume.FillSampleValues(8);
            volume.LinePen.Width = 3;
            volume.Marks.Visible = true;
            volume.Marks.TailStyle = MarksTail.None;

            _tChart.Chart.Legend.Visible = false;
            _tChart.Chart.Axes.Left.MinorTicks.Transparency = 100;
            _tChart.Chart.Axes.Left.Visible = false;
            _tChart.Chart.Axes.Left.AxisPen.Visible = false;
            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Left.Labels.Visible = true;
            _tChart.Chart.Title.Text = "Volume series";
            _tChart.Chart.Axes.Left.Automatic = true;
            _tChart.Chart.Axes.Left.Increment = 10;
            _tChart.Chart.Axes.Bottom.Automatic = true;
            _tChart.Chart.Axes.Bottom.AxisPen.Visible = true;
            _tChart.Chart.Axes.Bottom.Visible = true;
            _tChart.Chart.Series.Add(volume);
        }

        private void InitWaterfallChart()
        {
            Waterfall waterfall;
            waterfall = new Waterfall();

            waterfall.FillSampleValues();

            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Bottom.Visible = true;
            _tChart.Chart.Panel.MarginLeft = 3;

            _tChart.Chart.Axes.Left.Automatic = true;
            _tChart.Chart.Axes.Left.Increment = 1;
            _tChart.Chart.Axes.Bottom.Automatic = true;
            _tChart.Chart.Axes.Left.Grid.Visible = true;

            _tChart.Chart.Title.Text = "Waterfall series";
            _tChart.Chart.Legend.Visible = false;

            _tChart.Chart.Series.Add(waterfall);
        }

        private void InitSpeedTimeChart()
        {
            Line line1;
            Line line2;
            Line line3;
            line1 = new Line();
            line2 = new Line();
            line3 = new Line();

            _tChart.Chart.Title.Text = "Real Time Charting";

            line1.FillSampleValues(2);
            line2.FillSampleValues(2);
            line3.FillSampleValues(2);

            line1.LinePen.Width = 3;
            line2.LinePen.Width = 3;
            line3.LinePen.Width = 3;
            line1.Title = "Line1";
            line2.Title = "Line2";
            line3.Title = "Line3";

            _tChart.Chart.Series.Add(line1);
            _tChart.Chart.Series.Add(line2);
            _tChart.Chart.Series.Add(line3);

            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Bottom.Visible = true;
            _tChart.Chart.Axes.Left.Grid.Visible = true;

            _tChart.Chart.Axes.Left.Ticks.Transparency = 100;
            _tChart.Chart.Axes.Left.Automatic = true;
            _tChart.Chart.Axes.Left.Increment = 100;
            _tChart.Chart.Axes.Bottom.Automatic = true;

            Timer timer = new Timer();
            timer.Interval = 200;
            timer.Elapsed += TimerRealTime_Elapsed;
            timer.Start();

        }
        Random randomRealTime = new Random();
        private void TimerRealTime_Elapsed(object sender, ElapsedEventArgs e)
        {
            Line line1 = (Line)_tChart.Series[0];
            Line line2 = (Line)_tChart.Series[1];
            Line line3 = (Line)_tChart.Series[2];
            line1.Add(randomRealTime.Next(0, Convert.ToInt32(line1.MaxYValue() / 2)));
            line2.Add(randomRealTime.Next(Convert.ToInt32(line2.MaxYValue() / 2), Convert.ToInt32(line2.MaxYValue())));
            line3.Add(randomRealTime.Next(Convert.ToInt32(line3.MaxYValue() / 3), Convert.ToInt32(line3.MaxYValue())));

            if (line1.Count > 15) { _tChart.Chart.Axes.Bottom.SetMinMax(line1.Count - 15, line1.Count); }
        }

        private void InitHighLowChart()
        {
            HighLow highLow;
            highLow = new HighLow();
            highLow.FillSampleValues(25);
            _tChart.Chart.Series.Add(highLow);

            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Bottom.Visible = true;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Bottom.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Bottom.Visible = true;
            _tChart.Chart.Axes.Left.Grid.Visible = true;

            _tChart.Chart.Legend.Visible = false;
            _tChart.Chart.Title.Text = "HighLow series";

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue, _tChart.Chart.Axes.Left.MaxYValue);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);
        }

        private void InitBezierChart()
        {
            Bezier bezier;
            bezier = new Bezier();

            _tChart.Chart.Title.Text = "Bezier series";

            bezier.FillSampleValues(10);

            bezier.LinePen.Visible = true;
            bezier.LinePen.Transparency = 0;
            bezier.LinePen.Width = 2;

            bezier.Smoothed = true;

            _tChart.Chart.Series.Add(bezier);

            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Bottom.Visible = true;

            _tChart.Chart.Axes.Left.Increment = 20;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Legend.Visible = false;
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Ticks.Transparency = 100;
            _tChart.Chart.Axes.Bottom.Visible = true;
            _tChart.Chart.Axes.Bottom.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Grid.Visible = true;

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue, _tChart.Chart.Axes.Left.MaxYValue);
            _tChart.Chart.Axes.Bottom.SetMinMax(0, _tChart.Chart.Axes.Bottom.MaxXValue);
        }

        private void InitSmithChart()
        {
            Smith smith;
            smith = new Smith();

            smith.GetHorizAxis = _tChart.Chart.Axes.Bottom;
            smith.GetVertAxis = _tChart.Chart.Axes.Left;

            _tChart.Chart.Title.Text = "Smith series";
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Bottom.Visible = true;
            _tChart.Chart.Axes.Left.Labels.Visible = true;
            _tChart.Chart.Axes.Bottom.Labels.Visible = true;
            _tChart.Chart.Axes.Left.Automatic = true;
            _tChart.Chart.Axes.Bottom.Automatic = true;
            _tChart.Chart.Axes.Left.Increment = 0.5;
            _tChart.Chart.Axes.Left.Grid.Visible = true;

            smith.GetHorizAxis = _tChart.Chart.Axes.Bottom;
            smith.GetVertAxis = _tChart.Chart.Axes.Left;

            smith.FillSampleValues();
            smith.Circled = true;
            smith.Pointer.Visible = true;
            smith.RLabels = true;
            smith.CLabels = true;
            smith.CLabelsFont.Size = 11;
            smith.RLabelsFont.Size = 11;

            _tChart.Chart.Series.Add(smith);
        }

        private void InitFunnelChart()
        {
            Funnel funnel;
            funnel = new Funnel();

            funnel.FillSampleValues(4);
            funnel.Marks.Visible = true;
            funnel.Marks.TailStyle = MarksTail.None;
            funnel.Marks.Color = Color.White;
            funnel.Marks.Font.Color = Color.Black;
            funnel.Marks.Font.Size = 14;

            funnel.DifferenceLimit = 50;

            _tChart.Chart.Series.Add(funnel);

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue, _tChart.Chart.Axes.Left.MaxYValue);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);

            _tChart.Chart.Axes.Left.Visible = false;
            _tChart.Chart.Axes.Bottom.Visible = false;

            _tChart.Chart.Title.Text = "Market quota";

            _tChart.Chart.Legend.LegendStyle = LegendStyles.Values;
            _tChart.Chart.Legend.TextAlign = Android.Graphics.Paint.Align.Left;
            _tChart.Chart.Legend.TextStyle = LegendTextStyles.Plain;
        }

        private void InitErrorBarChart()
        {
            ErrorBar errorBar;
            errorBar = new ErrorBar();

            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Bottom.Visible = true;

            errorBar.FillSampleValues();

            errorBar.ErrorPen.Width = 2;
            errorBar.ErrorPen.Color = Color.Black;

            _tChart.Chart.Series.Add(errorBar);

            _tChart.Chart.Header.Text = "Error Bar";

            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.Grid.Visible = true;
            _tChart.Chart.Axes.Left.Ticks.Transparency = 100;

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue, _tChart.Chart.Axes.Left.MaxYValue);
            _tChart.Chart.Axes.Bottom.SetMinMax(0, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Left.Increment = 50;

            _tChart.Chart.Legend.Visible = false;

            errorBar.Marks.Visible = false;
            errorBar.MarksOnBar = true;
            errorBar.MarksLocation = MarksLocation.End;
            errorBar.Marks.TailStyle = MarksTail.None;
            errorBar.Marks.Font.Size = 12;
            errorBar.Marks.Frame.Color = Color.Transparent;
            errorBar.Marks.Pen.Color = Color.Black;
            errorBar.Marks.Color = Color.White;
            errorBar.Marks.Height += 10;
            errorBar.Marks.Shadow.Visible = false;
        }

        private void InitErrorChart()
        {
            Error errorChart;
            errorChart = new Error();

            errorChart.FillSampleValues();

            _tChart.Chart.Series.Add(errorChart);

            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Bottom.Visible = true;

            _tChart.Chart.Header.Text = "Error";

            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.Ticks.Visible = true;
            _tChart.Chart.Axes.Left.Grid.Visible = true;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Increment = 20;
            _tChart.Chart.Axes.Left.Title.Visible = false;

            _tChart.Chart.Axes.Bottom.Visible = true;
            _tChart.Chart.Axes.Bottom.AxisPen.Visible = true;
            _tChart.Chart.Axes.Bottom.Grid.Visible = false;
            _tChart.Chart.Axes.Bottom.Title.Visible = false;

            errorChart.ErrorWidth = 80;
            errorChart.ErrorPen.Width = 6;
            errorChart.ErrorStyle = ErrorStyles.TopBottom;

            _tChart.Chart.Legend.Visible = false;

            _tChart.Chart.Axes.Left.SetMinMax(0, _tChart.Chart.Axes.Left.MaxYValue + 5);
            _tChart.Chart.Axes.Bottom.SetMinMax(0, _tChart.Chart.Axes.Bottom.MaxXValue);
        }

        private void InitHistogramChart()
        {
            Histogram histogram;
            histogram = new Histogram();

            _tChart.Chart.Title.Text = "Histogram";

            histogram.FillSampleValues(15);

            _tChart.Chart.Series.Add(histogram);
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Bottom.Visible = true;
            _tChart.Chart.Axes.Left.SetMinMax(0, _tChart.Chart.Axes.Left.MaxYValue + 5);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);

            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Ticks.Transparency = 100;
            _tChart.Chart.Axes.Left.Increment = 5;
            _tChart.Chart.Axes.Left.Grid.Visible = true;
            _tChart.Chart.Legend.Visible = false;

            histogram.Marks.TailParams.Align = TailAlignment.BottomCenter;
        }

        private void InitCandleChart()
        {
            Candle candle;
            candle = new Candle();

            //candle.Style = CandleStyles.CandleStick;
            //candle.CandleWidth = 8;
            _tChart.Chart.Series.Add(candle);
            _tChart.Chart.Title.Text = "Stock exchange about two companies";
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Bottom.Visible = true;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;

            candle.FillSampleValues(7);

            candle.Style = CandleStyles.CandleStick;
            candle.CandleWidth = 40;

            candle.HighLowPen.Width = 3;
            candle.Pen.Width = 3;

            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Bottom.Visible = true;
            _tChart.Chart.Axes.Visible = true;
            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue - 5, _tChart.Chart.Axes.Left.MaxYValue + 5);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue - 0.5, _tChart.Chart.Axes.Bottom.MaxXValue + 0.5);
            _tChart.Chart.Panel.MarginRight = 5;
            _tChart.Chart.Axes.Bottom.Increment = 1;
            _tChart.Chart.Axes.Bottom.Grid.Visible = true;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Ticks.Visible = true;
            _tChart.Chart.Axes.Left.Ticks.Transparency = 100;
            _tChart.Chart.Axes.Left.MinorTicks.Visible = false;
            _tChart.Chart.Axes.Left.Increment = 10;
            _tChart.Chart.Axes.Left.Grid.Visible = true;
            _tChart.Chart.Legend.Visible = false;

            _tChart.Chart.Axes.Left.Title.Visible = true;
            _tChart.Chart.Axes.Left.Title.Text = "Money ($)";
            _tChart.Chart.Axes.Bottom.Title.Visible = true;
            _tChart.Chart.Axes.Bottom.Title.Text = "Date";
            _tChart.Chart.Axes.Left.Title.Font.Size = 15;
            _tChart.Chart.Axes.Left.Title.Angle = 90;
            _tChart.Chart.Axes.Bottom.Title.Font.Size = 15;

            _tChart.Chart.Axes.Bottom.Labels.DateTimeFormat = "dd/MM";
        }

        private void InitPyramidChart()
        {
            Pyramid pyramid1;
            pyramid1 = new Pyramid();

            _tChart.Chart.Header.Text = "Pyramid Series";
            _tChart.Chart.Series.Add(pyramid1);
            _tChart.Chart.Legend.Visible = true;
            _tChart.Chart.Walls.Left.Visible = false;
            _tChart.Chart.Walls.Left.Width = 5;

            pyramid1.DefaultNullValue = 0;
            pyramid1.Pen.Width = 3;
            pyramid1.Pen.Visible = true;
            pyramid1.Pen.Color = Color.White;
            pyramid1.Pen.Style = DashStyle.Solid;
            pyramid1.Pen.Transparency = 50;
            pyramid1.SizePercent = 80;
            pyramid1.ColorEach = false;
            pyramid1.FillSampleValues(6);

            pyramid1.Title = "Feudal society";

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue - 50, _tChart.Chart.Axes.Left.MaxYValue + 50);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinYValue + 0.5, _tChart.Chart.Axes.Bottom.MaxXValue - 0.5);

            _tChart.Chart.Axes.Bottom.Increment = 5;
            _tChart.Chart.Axes.Left.Increment = 5;

            _tChart.Chart.Axes.Left.Visible = false;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Axes.Left.Ticks = new Steema.TeeChart.Axis.TicksPen { Width = 2, Visible = true, Style = DashStyle.Solid, Length = 10, };
            _tChart.Chart.Axes.Bottom.Visible = false;

            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Bottom.Grid.Visible = false;
            _tChart.Chart.Legend.Visible = false;

            _tChart.Chart.Series[0].Marks.Font.Size = 18;
            _tChart.Chart.Panel.MarginLeft = 5;
            pyramid1.Marks.Style = MarksStyles.Label;
            pyramid1.Marks.Visible = false;
            pyramid1.Marks.DrawEvery = 1;
            pyramid1.Marks.AutoPosition = true;
            pyramid1.Marks.OnTop = true;
        }

        private void InitRadarChart()
        {
            Radar radar1;
            Radar radar2;
            Radar radar3;
            radar1 = new Radar();
            radar2 = new Radar();
            radar3 = new Radar();

            _tChart.Chart.Title.Text = "Radar";
            _tChart.Chart.Legend.Visible = false;
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Bottom.Visible = true;
            _tChart.Chart.Axes.Left.Grid.Visible = true;
            _tChart.Chart.Axes.Bottom.Grid.Visible = true;
            _tChart.Chart.Axes.Left.Automatic = true;
            _tChart.Chart.Axes.Bottom.Automatic = true;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;

            _tChart.Chart.Axes.Bottom.Increment = 200;
            _tChart.Chart.Axes.Left.Increment = 200;

            InitializeRadarSerie(radar1, 0);
            InitializeRadarSerie(radar2, 1);
            InitializeRadarSerie(radar3, 2);

        }

        private void InitializeRadarSerie(Radar radar, int pos)
        {
            radar.FillSampleValues(5);
            radar.Circled = true;
            radar.CloseCircle = true;
            radar.CircleLabels = true;
            radar.Pen.Visible = true;
            radar.Pen.Color = Color.White;
            radar.Pen.Width += 1;
            radar.LabelsMargin += 1;
            radar.CircleLabelsFont.Size += 1;

            radar.Marks.Pen.Visible = false;
            radar.Marks.FollowSeriesColor = false;
            radar.Marks.Style = MarksStyles.Percent;
            radar.AutoCircleResize = false;
            radar.Marks.Brush.Transparency = 100;
            radar.Marks.Transparent = true;
            radar.Marks.Frame.Transparency = 100;

            _tChart.Chart.Series.Add(radar);
        }

        private void InitPolarChart()
        {
            Polar polar1;
            Polar polar2;
            polar1 = new Polar();
            polar2 = new Polar();

            polar1.FillSampleValues();
            polar2.FillSampleValues();

            polar1.Circled = true;
            polar2.Circled = true;
            polar1.CloseCircle = true;
            polar2.CloseCircle = true;
            polar1.Pen.Color = Color.White;
            polar2.Pen.Color = Color.White;
            polar1.CircleLabels = true;
            polar1.CircleLabelsInside = false;
            polar2.CircleLabels = true;
            polar2.CircleLabelsInside = false;

            _tChart.Chart.Series.Add(polar1);
            _tChart.Chart.Series.Add(polar2);

            _tChart.Chart.Title.Text = "Polar";
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.MinorTicks.Transparency = 100;
            _tChart.Chart.Axes.Bottom.MinorTicks.Transparency = 100;
            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue - 100, _tChart.Chart.Axes.Left.MaxYValue + 100);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinYValue - 100, _tChart.Chart.Axes.Bottom.MaxXValue + 100);

            _tChart.Chart.Axes.Bottom.Automatic = true;
            _tChart.Chart.Axes.Left.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Bottom.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Bottom.Increment = 1;
            _tChart.Chart.Axes.Left.Increment = 100;
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.Title = null;
            _tChart.Chart.Axes.Bottom.Title = null;
            _tChart.Chart.Axes.Left.AxisPen.Visible = false;
            _tChart.Chart.Axes.Left.Ticks.Visible = false;
            _tChart.Chart.Axes.Left.Grid.Visible = true;
            _tChart.Chart.Legend.LegendStyle = LegendStyles.Series;
            _tChart.Chart.Axes.Bottom.Grid.Visible = false;
            _tChart.Chart.Panel.MarginLeft = 5;
            _tChart.Chart.Axes.Bottom.AxisPen.Visible = true;
            _tChart.Chart.Axes.Bottom.Visible = true;
            _tChart.Chart.Axes.Left.Increment = 100;

            polar1.AngleIncrement = 30;
            polar2.AngleIncrement = 30;
            polar1.CircleLabelsFont.Size += 2;
            polar2.CircleLabelsFont.Size += 2;
            polar1.RadiusIncrement = 300;
            polar2.RadiusIncrement = 300;
        }

        private void InitArrowChart()
        {
            Arrow arrow1;
            arrow1 = new Arrow();

            // Modificación del "Chart" base
            _tChart.Chart.Legend.Visible = false;
            _tChart.Chart.Panning.Allow = ScrollModes.None;
            _tChart.Chart.Panning.Active = false;
            _tChart.Chart.Zoom.Active = false;
            _tChart.Chart.Zoom.Zoomed = false;
            _tChart.Chart.Header.Text = "A lot of Arrows";
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Bottom.Visible = true;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Series.Add(arrow1);

            // Propiedades de la "line1"
            arrow1.FillSampleValues(7);
            arrow1.LinePen.Width = 6;
            arrow1.Pointer.InflateMargins = true;
            arrow1.Pointer.Visible = true;
            arrow1.Pointer.HorizSize = 11;
            arrow1.Pointer.VertSize = 11;
            arrow1.Pointer.Pen.Color = Color.White;
            arrow1.Pointer.Pen.Width = 5;
            arrow1.Pointer.Style = PointerStyles.Sphere;

            arrow1.ClickTolerance = 40;
            arrow1.RecalcOptions = RecalcOptions.OnModify;
            arrow1.Title = "Births";
            arrow1.DefaultNullValue = 0;
            arrow1.VertAxis = VerticalAxis.Both;
            arrow1.HorizAxis = HorizontalAxis.Both;

            // Características de los ejes del "Chart" base
            _tChart.Chart.Axes.Bottom.Automatic = true;
            _tChart.Chart.Axes.Left.SetMinMax(0, _tChart.Chart.Axes.Left.MaxYValue + 50);
            _tChart.Chart.Axes.Bottom.SetMinMax(0, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Left.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Bottom.Labels.ValueFormat = "0";
            _tChart.Chart.Axes.Bottom.Increment = 1;
            _tChart.Chart.Axes.Left.Increment = 100;
            _tChart.Chart.Axes.Left.Visible = true;
            _tChart.Chart.Axes.Left.Title = null;
            _tChart.Chart.Axes.Bottom.Title = null;
            _tChart.Chart.Axes.Left.AxisPen.Visible = false;
            _tChart.Chart.Axes.Left.Ticks.Visible = false;
            _tChart.Chart.Axes.Left.Grid.Visible = true;
            _tChart.Chart.Legend.LegendStyle = LegendStyles.Series;
            _tChart.Chart.Axes.Bottom.Grid.Visible = false;
            _tChart.Chart.Panel.MarginLeft = 5;
            _tChart.Chart.Axes.Bottom.AxisPen.Visible = true;
            _tChart.Chart.Axes.Bottom.Visible = true;
            _tChart.Chart.Axes.Left.Increment = 100;
        }

        #endregion

        #region CIRCULAR GAUGES

        private void InitBasicCircGaugeChart()
        {
            CircularGauge circularGauge;
            circularGauge = new CircularGauge();

            _tChart.Chart.Series.Add(circularGauge);

            _tChart.Chart.Title.Visible = false;

            circularGauge.MinorTicks.Visible = false;
            circularGauge.Title = "Basic Circular Gauge";
            circularGauge.Ticks.Visible = false;
            circularGauge.HandDistance = 70;
            circularGauge.HandOffset = 0;
            circularGauge.Hand.HorizSize = 6;
            circularGauge.Hand.Draw3D = false;
            circularGauge.Hand.Pen.Visible = false;
            circularGauge.Hand.Gradient.Visible = false;
            circularGauge.Hand.Shadow.Visible = false;
            circularGauge.Center.Gradient.Visible = false;
            circularGauge.Center.HorizSize = 15;
            circularGauge.Center.VertSize = 15;
            circularGauge.Center.Draw3D = false;
            circularGauge.Center.Pen.Visible = false;
            circularGauge.Center.Shadow.Visible = false;
            circularGauge.FaceBrush.Color = Color.White;
            circularGauge.FaceBrush.Visible = true;
            circularGauge.FaceBrush.Solid = true;
            circularGauge.FaceBrush.Gradient.Visible = false;
            circularGauge.FaceBrush.ForegroundColor = Color.White;
            circularGauge.RotateLabels = false;
            circularGauge.RedLine.Visible = false;
            circularGauge.GreenLine.Visible = false;
            circularGauge.Frame.TotalAngle = 290;
            circularGauge.Frame.Visible = true;
            circularGauge.Frame.FrameElementPercents = new double[3] { 0, 100, 0 };
            circularGauge.Frame.MiddleBand.Color = Color.FromArgb(190, 190, 190);
            circularGauge.Frame.OuterBand.Visible = false;
            circularGauge.Frame.InnerBand.Visible = false;
            circularGauge.Frame.MiddleBand.Solid = true;
            circularGauge.Frame.MiddleBand.Gradient.Visible = false;
            circularGauge.Frame.RotationAngle = 305;
            circularGauge.Frame.Circled = true;
            circularGauge.Frame.Width = 2;
            circularGauge.CircleBackColor = Color.White;
            circularGauge.Color = Color.White;
            circularGauge.Axis.Labels.Font.Color = Color.Black;
            circularGauge.Value = 65;
            circularGauge.Maximum = 100;
            circularGauge.Axis.Increment = 10;
        }

        private void InitCarFuelCircGaugeChart()
        {
            CircularGauge circularGauge;
            circularGauge = new CircularGauge();

            _tChart.Chart.Series.Add(circularGauge);
            _tChart.Chart.Title.Visible = false;

            circularGauge.Title = "Car Fuel";
            circularGauge.MinorTicks.Visible = true;
            circularGauge.MinorTickDistance = 2;
            circularGauge.MinorTicks.Color = Color.White;
            circularGauge.MinorTicks.VertSize = 4;
            circularGauge.MinorTicks.HorizSize = 3;
            circularGauge.MinorTicks.Pen.Visible = false;
            circularGauge.Ticks.Visible = true;
            circularGauge.Ticks.Color = Color.White;

            circularGauge.HandDistance = 60;
            circularGauge.HandOffset = 0;
            circularGauge.Hand.HorizSize = 10;
            circularGauge.Hand.Color = Color.FromArgb(255, 220, 220, 220);
            circularGauge.Hand.Draw3D = false;
            circularGauge.Hand.Pen.Visible = false;
            circularGauge.Hand.Gradient.Visible = false;
            circularGauge.Hand.Shadow.Visible = true;
            circularGauge.Center.Color = Color.FromArgb(255, 220, 220, 220);
            circularGauge.Center.Gradient.Visible = true;
            circularGauge.Center.HorizSize = 25;
            circularGauge.Center.VertSize = 25;
            circularGauge.Center.Draw3D = false;
            circularGauge.Center.Pen.Visible = true;
            circularGauge.Center.Shadow.Visible = true;
            circularGauge.RotateLabels = false;
            circularGauge.RedLine.Visible = false;
            circularGauge.GreenLine.Visible = true;
            circularGauge.GreenLine.Gradient.Visible = true;
            circularGauge.GreenLine.Gradient.UseMiddle = true;
            circularGauge.GreenLine.Gradient.StartColor = Color.Red;
            circularGauge.GreenLine.Gradient.EndColor = Color.LightGreen;
            circularGauge.GreenLine.Gradient.Direction = GradientDirection.FromBottomLeft;
            circularGauge.GreenLineStartValue = 0;
            circularGauge.GreenLineEndValue = 1;
            circularGauge.GreenLine.InflateMargins = true;
            circularGauge.Frame.Visible = true;
            circularGauge.Frame.FrameElementPercents = new double[3] { 0, 60, 40 };
            circularGauge.Frame.MiddleBand.Color = Color.FromArgb(255, 190, 190, 190);
            circularGauge.Frame.OuterBand.Visible = false;
            circularGauge.Frame.InnerBand.Visible = true;
            circularGauge.Frame.InnerBand.Gradient.Visible = false;
            circularGauge.Frame.InnerBand.Solid = true;
            circularGauge.Frame.InnerBand.Color = Color.FromArgb(255, 120, 120, 120);
            circularGauge.Frame.MiddleBand.Visible = false;
            circularGauge.Frame.MiddleBand.Solid = true;
            circularGauge.Frame.MiddleBand.Gradient.Visible = true;
            circularGauge.Frame.MiddleBand.Gradient.StartColor = Color.FromArgb(255, 100, 100, 100);
            circularGauge.Frame.MiddleBand.Gradient.MiddleColor = Color.FromArgb(255, 50, 50, 50);
            circularGauge.Frame.MiddleBand.Gradient.EndColor = Color.FromArgb(255, 20, 20, 20);
            circularGauge.Frame.MiddleBand.Gradient.Direction = GradientDirection.DiagonalDown;
            circularGauge.Frame.RotationAngle = 0;
            circularGauge.Frame.Circled = true;
            circularGauge.Frame.Width = 2;
            circularGauge.CircleBackColor = Color.White;
            circularGauge.Axis.Labels.Font.Color = Color.White;
            circularGauge.Maximum = 1;
            circularGauge.Axis.Increment = 0.25;
            circularGauge.Value = 0.75;
            circularGauge.TotalAngle = 180;
            circularGauge.Hand.Style = PointerStyles.DownTriangle;
            circularGauge.FaceBrush.Visible = false;
            circularGauge.FaceBrush.Solid = false;
            circularGauge.FaceBrush.Gradient.Visible = false;
            circularGauge.DisplayTotalAngle = 180;
            circularGauge.CircleBackColor = Color.Black;
            circularGauge.Frame.TotalAngle = 180;

            _tChart.Chart.Axes.Bottom.Ticks.Transparency = 100;
        }

        private void InitCustomHandCircGaugeChart()
        {
            CircularGauge circularGauge;
            circularGauge = new CircularGauge();
            GaugeSeriesPointer pointer2;

            _tChart.Chart.Series.Add(circularGauge);
            _tChart.Chart.Title.Visible = false;
            _tChart.Chart.Panning.Active = true;
            _tChart.Chart.Panning.Allow = ScrollModes.Both;
            _tChart.Chart.Zoom.Active = true;

            pointer2 = new GaugeSeriesPointer(_tChart.Chart, _tChart.Chart.Series[0]);

            circularGauge.Title = "Custom Hand";
            circularGauge.MinorTicks.Visible = false;
            circularGauge.Ticks.Visible = false;

            circularGauge.Hand.HorizSize = 20;
            circularGauge.Hand.Color = Color.Red;
            circularGauge.Hand.Draw3D = false;
            circularGauge.Hand.Pen.Visible = false;
            circularGauge.Hand.Shadow.Visible = false;
            circularGauge.Hand.Style = PointerStyles.Arrow;
            circularGauge.Hand.Gradient.Visible = false;

            pointer2.HorizSize = 20;
            pointer2.Color = Color.FromArgb(30, 70, 230);
            pointer2.Draw3D = false;
            pointer2.Pen.Visible = false;
            pointer2.Gradient.Visible = false;
            pointer2.Shadow.Visible = false;
            pointer2.Style = PointerStyles.Arrow;
            pointer2.VertSize = 100;

            circularGauge.HandDistances.Add(80);
            circularGauge.HandOffsets.Add(0);
            circularGauge.HandOffset = 0;
            circularGauge.HandDistance = 80;

            circularGauge.Hands.Add(pointer2);
            circularGauge.Center.Color = Color.White;
            circularGauge.Center.Gradient.Visible = false;
            circularGauge.Center.HorizSize = 30;
            circularGauge.Center.VertSize = 30;
            circularGauge.Center.Pen.Color = Color.White;
            circularGauge.Center.Draw3D = false;
            circularGauge.Center.Pen.Visible = true;
            circularGauge.Center.Shadow.Visible = false;
            circularGauge.Center.Visible = true;
            circularGauge.FaceBrush.Visible = true;
            circularGauge.FaceBrush.Solid = true;
            circularGauge.FaceBrush.Gradient.Visible = false;
            circularGauge.FaceBrush.ForegroundColor = Color.White;
            circularGauge.FaceBrush.Color = Color.White;
            circularGauge.RotateLabels = false;
            circularGauge.RedLine.Visible = false;
            circularGauge.GreenLine.Visible = false;
            circularGauge.Frame.TotalAngle = 180;
            circularGauge.Frame.Visible = true;
            circularGauge.Frame.FrameElementPercents = new double[3] { 0, 100, 0 };
            circularGauge.Frame.MiddleBand.Color = Color.FromArgb(140, 140, 140);
            circularGauge.Frame.OuterBand.Visible = false;
            circularGauge.Frame.InnerBand.Visible = false;
            circularGauge.Frame.MiddleBand.Solid = true;
            circularGauge.Frame.MiddleBand.Gradient.Visible = false;
            circularGauge.Frame.MiddleBand.Gradient.Direction = GradientDirection.DiagonalUp;
            circularGauge.Frame.RotationAngle = 0;
            circularGauge.Frame.Circled = true;
            circularGauge.Frame.Width = 2;
            circularGauge.Color = Color.White;
            circularGauge.CircleBackColor = Color.White;
            circularGauge.Axis.Labels.Font.Color = Color.Black;
            circularGauge.Maximum = 10;
            circularGauge.Axis.Increment = 2;
            circularGauge.Value = 6;
            circularGauge.TotalAngle = 180;

            circularGauge.mandatory[0] = 7;
            circularGauge.mandatory[1] = 2;
        }

        private void InitAccelerationCircGaugeChart()
        {
            CircularGauge circularGauge;
            circularGauge = InitializeGauge();

            _tChart.Chart.Title.Text = "Accelerometer Circular Gauge";
            _tChart.Chart.Title.Alignment = Android.Graphics.Paint.Align.Center;
            _tChart.Chart.Title.TextAlign = Android.Graphics.Paint.Align.Right;
            _tChart.Chart.SubTitle.Text = "X Axis";
            _tChart.Chart.SubTitle.Visible = true;
            _tChart.Chart.SubTitle.Font.Size += 6;
            _tChart.Chart.Title.Font.Size += 6;
            _tChart.Chart.Title.Font.Bold = true;
            _tChart.Chart.Axes.Left.Increment = 0.2;
            _tChart.Chart.Axes.Left.Labels.Font.Color = Color.FromArgb(110, 110, 110);
            _tChart.Chart.Axes.Left.Labels.Font.Size += 7;

            InitializeAccelerometerSensor(circularGauge);

            _tChart.Chart.Series.Add(circularGauge);
        }

        private CircularGauge InitializeGauge()
        {
            CircularGauge gauge = new CircularGauge();

            gauge.Title = "Accelerometer Circular Gauge";
            gauge.Maximum = 2;
            gauge.Minimum = -2;
            gauge.GreenLine.Visible = false;
            gauge.RedLine.Visible = false;
            gauge.Frame.Width = 1;
            gauge.Hand.Gradient.Visible = false;
            gauge.Hand.Color = Color.FromArgb(170, 170, 170);
            gauge.HandOffset = 0;
            gauge.Hand.Style = PointerStyles.DownTriangle;
            gauge.Hand.HorizSize += 10;
            gauge.Center.Gradient.Visible = false;
            gauge.Center.Color = Color.FromArgb(170, 170, 170);
            gauge.Center.Shadow.Visible = false;
            gauge.Center.HorizSize += 10;
            gauge.Center.VertSize += 10;
            gauge.FaceBrush.Color = Color.White;
            gauge.FaceBrush.Gradient.Visible = false;
            gauge.Hand.HorizSize += 4;
            gauge.Hand.VertSize += 4;
            gauge.Ticks.VertSize = 10;
            gauge.Ticks.HorizSize = 2;
            gauge.MinorTicks.Visible = true;
            gauge.MinorTickDistance = 3;
            gauge.MinorTicks.HorizSize = 1;
            gauge.MinorTicks.VertSize = 5;
            gauge.Ticks.Pen.Visible = false;
            gauge.Ticks.Color = Color.FromArgb(140, 140, 140);
            gauge.RotateLabels = false;
            gauge.Frame.OuterBand.Visible = false;
            gauge.Frame.MiddleBand.Visible = false;
            gauge.Frame.InnerBand.Visible = true;
            gauge.Frame.InnerBand.Gradient.Visible = false;
            gauge.Frame.InnerBand.Color = Color.FromArgb(120, 120, 120);

            return gauge;
        }

        private class AccelerometerSensorExtension : Java.Lang.Object, ISensorEventListener
        {
            CircularGauge gauge;
            public AccelerometerSensorExtension(CircularGauge gauge)
            {
                this.gauge = gauge;
            }
            public void OnAccuracyChanged(Sensor sensor, [GeneratedEnum] SensorStatus accuracy)
            {
                
            }

            public void OnSensorChanged(SensorEvent e)
            {
                gauge.Value = e.Values[0];
            }
        }

        private void InitializeAccelerometerSensor(CircularGauge gauge)
        {

            try
            {
                SensorManager sensorManager = (SensorManager)Application.Context.GetSystemService(Context.SensorService);
                Sensor accelerometer = sensorManager.GetDefaultSensor(SensorType.Accelerometer);

                sensorManager.RegisterListener(new AccelerometerSensorExtension(gauge), accelerometer, SensorDelay.Normal);
            }

            catch (Exception e)
            {
                Toast.MakeText(Application.Context, "Accelerometer is unavailable", ToastLength.Long).Show();
            }

        }

        #endregion

        #region MAPS

        private void InitWorldMapChart()
        {
            /*
            Steema.TeeChart.Styles. world;
            world = new World();
            var = new Variables.Variables();

            world.UseColorRange = false;
            world.StartColor = var.GetPaletteBasic[0].AddLuminosity(0.14);
            world.MidColor = var.GetPaletteBasic[0].AddLuminosity(-0.05);
            world.EndColor = var.GetPaletteBasic[0].AddLuminosity(-0.26);
            world.UseColorRange = true;
            world.Shadow.Visible = false;

            world.FillSampleValues();

            world.Map = WorldMapType.Europe27;

            BaseChart.Chart.Series.Add(world);
            BaseChart.Chart.Axes.Left.Automatic = true;
            BaseChart.Chart.Axes.Bottom.Automatic = true;
            BaseChart.Chart.Axes.Left.Ticks.Transparency = 100;
            BaseChart.Chart.Axes.Left.Visible = false;
            BaseChart.Chart.Axes.Bottom.Visible = false;
            BaseChart.Chart.Legend.Visible = false;
            */
        }

        private void InitMapGISChart()
        {
            Map mapGSI;
            mapGSI = new Map();

            _tChart.Chart.Series.Add(mapGSI);
            mapGSI.FillSampleValues(10);

            mapGSI.VertAxis = VerticalAxis.Both;
            mapGSI.HorizAxis = HorizontalAxis.Both;
            mapGSI.Title = "Map GIS";
            mapGSI.UsePalette = false;
            mapGSI.Marks.AutoSize = true;
            mapGSI.MapMarks.AutoSize = false;
            mapGSI.MapMarks.UpperCase = true;
            mapGSI.MapMarks.Centroid = true;
            mapGSI.Marks.Font.Size += 8;
            mapGSI.Marks.Font.Bold = true;
            mapGSI.Marks.TailStyle = MarksTail.None;

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue - 2, _tChart.Chart.Axes.Left.MaxYValue + 2);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue - 1, _tChart.Chart.Axes.Bottom.MaxXValue + 1);

            _tChart.Chart.Axes.Left.Transparency = 0;
            _tChart.Chart.Axes.Bottom.Transparency = 0;
            _tChart.Chart.Legend.Visible = false;
            _tChart.Chart.Axes.Left.MinorTicks.Transparency = 100;
            _tChart.Chart.Axes.Left.Ticks.Transparency = 100;
            _tChart.Chart.Title.Text = "";
        }

        #endregion

        #region TREEMAP

        private void InitTreeMapChart()
        {
            /*
            Steema.TeeChart.Styles.TreeMap treeMap;
            treeMap = new Steema.TeeChart.Styles.TreeMap();

            treeMap.FillSampleValues(6);
            _tChart.Chart.Series.Add(treeMap);
            */
        }

        #endregion

        #region KNOB GAUGES

        private void InitBasicKnobGaugeChart()
        {
            KnobGauge knobGauge;
            knobGauge = new KnobGauge();

            knobGauge.FillSampleValues(4);

            _tChart.Chart.Series.Add(knobGauge);

            knobGauge.MinorTicks.Visible = false;
            knobGauge.Ticks.Visible = false;

            _tChart.Chart.Header.Visible = false;
            _tChart.Chart.Axes.Left.Labels.Visible = true;

            knobGauge.Axis.Increment = 10;
        }

        private void InitTemperatureKnobGaugeChart()
        {
            KnobGauge knobGauge;
            knobGauge = new KnobGauge();

            knobGauge.FillSampleValues(4);

            _tChart.Chart.Series.Add(knobGauge);

            knobGauge.MinorTicks.Visible = false;
            knobGauge.Ticks.Visible = false;
            _tChart.Chart.Header.Visible = false;
            _tChart.Chart.Axes.Left.Labels.Visible = false;

            knobGauge.FaceBrush.Gradient.Visible = false;
            knobGauge.FaceBrush.ForegroundColor = Color.White;
            knobGauge.GreenLineStartValue = 0;
            knobGauge.GreenLineEndValue = 0.5;
            knobGauge.RedLineStartValue = 0.5;
            knobGauge.RedLineEndValue = 1;
            knobGauge.RedLine.Gradient.Visible = true;
            knobGauge.RedLine.Gradient.Direction = Steema.TeeChart.Drawing.GradientDirection.TopBottom;
            knobGauge.RedLine.Gradient.StartColor = Color.FromArgb(255, 255, 0, 0);
            knobGauge.RedLine.Gradient.EndColor = Color.FromArgb(255, 255, 255, 192);
            knobGauge.RedLine.HorizSize = 10;
            knobGauge.GreenLine.Gradient.Visible = true;
            knobGauge.GreenLine.Gradient.Direction = Steema.TeeChart.Drawing.GradientDirection.BottomTop;
            knobGauge.GreenLine.Gradient.StartColor = Color.FromArgb(255, 192, 255, 255);
            knobGauge.GreenLine.Gradient.EndColor = Color.FromArgb(255, 0, 0, 255);
            knobGauge.GreenLine.HorizSize = 10;
            knobGauge.CircleBackColor = Color.White;
            knobGauge.Color = Color.White;
            knobGauge.FaceBrush.Color = Color.White;
            knobGauge.Axis.Labels.Font.Size = 17;
            knobGauge.LabelsInside = false;
            knobGauge.Axis.LabelsOnAxis = false;
            knobGauge.Value = 0.38;
            knobGauge.Center.SizeDouble = 40;
            knobGauge.Center.Color = Color.FromArgb(64, 64, 64);
            knobGauge.Center.Gradient.Visible = false;
            knobGauge.Axis.Increment = 1;
            knobGauge.Maximum = 1;

            if (knobGauge.Value < 0.25) { knobGauge.Hand.Color = knobGauge.GreenLine.Gradient.EndColor; }
            else if (knobGauge.Value < 0.5) { knobGauge.Hand.Color = knobGauge.GreenLine.Gradient.StartColor; }
            else if (knobGauge.Value == 0.5) { knobGauge.Hand.Color = Color.White; }
            else if (knobGauge.Value < 0.75) { knobGauge.Hand.Color = knobGauge.RedLine.Gradient.EndColor; }
            else { knobGauge.Hand.Color = knobGauge.RedLine.Gradient.StartColor; }
        }

        private void InitCompassKnobGaugeChart()
        {
            KnobGauge knobGauge;
            GaugeSeriesPointer backPointer;

            knobGauge = new KnobGauge();
            backPointer = new GaugeSeriesPointer(_tChart.Chart, knobGauge);

            knobGauge.FillSampleValues(4);

            _tChart.Chart.Series.Add(knobGauge);

            knobGauge.MinorTicks.Visible = false;
            knobGauge.Ticks.Visible = true;
            knobGauge.Ticks.Color = Color.FromArgb(120, 120, 120);
            knobGauge.Ticks.Pen.Visible = false;
            knobGauge.Ticks.VertSize = 7;
            knobGauge.Ticks.HorizSize = 2;
            knobGauge.AxisInside = true;
            _tChart.Chart.Header.Visible = false;
            _tChart.Chart.Axes.Left.Labels.Visible = true;

            knobGauge.FaceBrush.Gradient.Visible = true;
            knobGauge.FaceBrush.Gradient.UseMiddle = true;
            knobGauge.FaceBrush.Gradient.Direction = GradientDirection.Radial;
            knobGauge.FaceBrush.Gradient.StartColor = Color.FromArgb(255, 255, 255);
            knobGauge.FaceBrush.Gradient.MiddleColor = Color.FromArgb(240, 240, 240);
            knobGauge.FaceBrush.Gradient.EndColor = Color.FromArgb(220, 220, 220);
            knobGauge.RedLine.Visible = false;
            knobGauge.GreenLine.Visible = false;
            knobGauge.CircleBackColor = Color.White;
            knobGauge.Color = Color.White;
            knobGauge.Axis.Labels.Font.Size = 17;
            knobGauge.LabelsInside = true;
            knobGauge.Axis.LabelsOnAxis = false;
            knobGauge.Value = 1;
            knobGauge.Center.SizeDouble = 10;
            knobGauge.Center.Color = Color.FromArgb(64, 64, 64);
            knobGauge.Center.Gradient.Visible = false;
            knobGauge.Center.Shadow.Visible = false;
            knobGauge.Center.Visible = false;

            knobGauge.HighLightBrush.Visible = false;
            knobGauge.Axis.Increment = 45;
            knobGauge.Maximum = 360;
            knobGauge.Rotate(180);
            knobGauge.TotalAngle = 360;

            knobGauge.Frame.Visible = true;
            knobGauge.Frame.OuterBand.Visible = false;
            knobGauge.Frame.MiddleBand.Visible = false;
            knobGauge.Frame.InnerBand.Visible = true;
            knobGauge.Frame.InnerBand.Solid = true;
            knobGauge.Frame.InnerBand.Color = Color.FromArgb(170, 170, 170);
            knobGauge.Frame.Width = 2;
            knobGauge.Frame.FrameElementPercents = new double[3] { 0, 0, 100 };
            knobGauge.Frame.TotalAngle = 360;

            backPointer.VertSize = 100;
            backPointer.Visible = true;
            backPointer.Draw3D = false;
            backPointer.Pen.Visible = false;
            backPointer.Gradient.Visible = false;
            backPointer.Shadow.Visible = false;
            backPointer.Style = PointerStyles.DownTriangle;
            backPointer.Color = Color.FromArgb(150, 150, 150);
            backPointer.HorizSize = 49;

            knobGauge.Hands.Add(backPointer);

            knobGauge.HandDistances.Add(80);
            knobGauge.HandOffsets.Add(0);
            knobGauge.HandDistance = 80;
            knobGauge.HandOffset = 0;

            knobGauge.Active = true;

            knobGauge.Hand.Color = Color.Red;
            knobGauge.Hand.Style = PointerStyles.DownTriangle;
            knobGauge.Hand.Shadow.Visible = false;

            knobGauge.mandatory.Capacity = 2;
            knobGauge.mandatory.Count = 2;

            InitializeCompassSensor(knobGauge);
        }

        private void InitializeCompassSensor(KnobGauge gauge)
        {
            try
            {
                SensorManager sensorManager = (SensorManager)Application.Context.GetSystemService(Context.SensorService);
                Sensor orientation = sensorManager.GetDefaultSensor(SensorType.Orientation);

                sensorManager.RegisterListener(new OrientationSensorExtension(gauge), orientation, SensorDelay.Normal);
            }
            catch (Exception e)
            {
                Toast.MakeText(Application.Context, "Gyroscope unavailable", ToastLength.Long).Show();
            }
        }

        private class OrientationSensorExtension : Java.Lang.Object, ISensorEventListener
        {
            KnobGauge gauge;
            public OrientationSensorExtension(KnobGauge gauge)
            {
                this.gauge = gauge;
            }

            public void OnAccuracyChanged(Sensor sensor, [GeneratedEnum] SensorStatus accuracy)
            {
                
            }

            public void OnSensorChanged(SensorEvent e)
            {
                gauge.Value = e.Values[0];
                gauge.mandatory[1] = e.Values[0] + 180;
            }
        }

        #endregion

        #region CLOCK

        private void InitBasicClockChart()
        {
            Steema.TeeChart.Styles.Clock clock;
            clock = new Steema.TeeChart.Styles.Clock();

            clock.FillSampleValues();
            clock.Timer.Interval = 1;

            _tChart.Chart.Title.Visible = false;

            _tChart.Chart.Series.Add(clock);

            clock.Timer.BeginInit();
            clock.Timer.Start();
        }

        private void InitCustomClockChart()
        {
            Steema.TeeChart.Styles.Clock clock;
            clock = new Steema.TeeChart.Styles.Clock();

            clock.FillSampleValues();
            clock.Pointer.Color = Color.Black;
            clock.CircleLabelsInside = true;
            clock.ShowInLegend = false;
            clock.Pointer.Style = PointerStyles.Rectangle;
            clock.Pointer.Gradient.Visible = false;
            clock.Circled = true;
            clock.Style = ClockStyles.Decimal;
            clock.Pointer.HorizSize += 5;
            clock.Pointer.VertSize += 5;
            clock.Pointer.Pen.Visible = false;
            clock.Color = Color.Black;
            clock.Brush.Color = Color.Black;
            clock.Font.Size += 8;
            clock.LabelsMargin += 2;
            clock.PenSeconds.Color = Color.Red;
            clock.CircleLabelsFont.Size += 4;
            clock.Timer.Start();

            _tChart.Chart.Title.Visible = false;

            _tChart.Chart.Series.Add(clock);
        }

        #endregion

        #region ORGANIZATIONAL CHARTS

        private void InitOrganizationalChart()
        {
            OrgSeries organizationalChart;
            organizationalChart = new OrgSeries();
            organizationalChart.FillSampleValues();
            _tChart.Chart.Series.Add(organizationalChart);

            _tChart.Chart.Header.Transparency = 100;
            _tChart.Chart.Header.Font.Size = 120;

            organizationalChart.ItemSpacing = new Spacing() { Vertical = 70, Horizontal = 30 };
            organizationalChart.Pen.Width = 3;
        }

        #endregion

        #region NUMERIC GAUGES

        private void InitNumericGaugeChart()
        {
            NumericGauge numericGauge;

            numericGauge = new NumericGauge();

            numericGauge.FillSampleValues();

            _tChart.Chart.Series.Add(numericGauge);
            _tChart.Chart.Header.Visible = false;

            numericGauge.GaugeColorPalette = null;
            numericGauge.FaceBrush.Gradient.Visible = false;
            numericGauge.FaceBrush.ForegroundColor = Color.FromArgb(255, 8, 81, 137);
            numericGauge.FaceBrush.Color = Color.FromArgb(255, 8, 81, 137);
            numericGauge.FaceBrush.Solid = true;
            numericGauge.FaceBrush.Visible = true;
            numericGauge.Markers[0].Active = true;
            numericGauge.Markers[1].Active = true;
            numericGauge.Markers[2].Active = true;
            numericGauge.Markers[0].UsePalette = false;
            numericGauge.Markers[1].UsePalette = false;
            numericGauge.Markers[2].UsePalette = false;
            numericGauge.Markers[0].Shape.Color = Color.FromArgb(255, 8, 81, 137);
            numericGauge.Markers[1].Shape.Color = Color.FromArgb(255, 8, 81, 137);
            numericGauge.Markers[2].Shape.Color = Color.FromArgb(255, 8, 81, 137);
            numericGauge.Markers[0].Shape.Font.Color = Color.White;
            numericGauge.Markers[1].Shape.Font.Color = Color.White;
            numericGauge.Markers[2].Shape.Font.Color = Color.White;
            numericGauge.Markers[0].TextAlign = Android.Graphics.Paint.Align.Right;
            numericGauge.Markers[1].TextAlign = Android.Graphics.Paint.Align.Center;
            numericGauge.Markers[2].TextAlign = Android.Graphics.Paint.Align.Center;
            numericGauge.TextMarker.Shape.Font.Color = Color.White;
        }

        #endregion

        #region LINEAR GAUGES

        private void InitBasicLinearGaugeChart()
        {
            LinearGauge linearGauge;
            linearGauge = new LinearGauge();
            linearGauge.FillSampleValues();

            _tChart.Chart.Series.Add(linearGauge);
            _tChart.Chart.Header.Visible = false;
            _tChart.Rotation = 0;

            linearGauge.Value = 20;
            linearGauge.Axis.Increment = 10;
            linearGauge.Maximum = 100;
            linearGauge.Minimum = 0;

            linearGauge.FaceBrush.Color = Color.White;
            linearGauge.FaceBrush.ForegroundColor = Color.White;
            linearGauge.RedLine.Visible = false;
            linearGauge.GreenLine.Visible = false;
            linearGauge.Hand.Visible = false;
            linearGauge.FaceBrush.Visible = true;
            linearGauge.FaceBrush.Gradient.Visible = false;
            linearGauge.Maximum = 100;
            linearGauge.Minimum = 0;
            linearGauge.Hand.Visible = false;
            linearGauge.Ticks.Visible = true;
            linearGauge.Ticks.VertSize = 60;
            linearGauge.Ticks.HorizSize = 1;
            linearGauge.MinorTicks.Visible = false;
            linearGauge.MinorTickDistance = 0;
            linearGauge.MaxValueIndicator.VertSize = 10;
            linearGauge.MaxValueIndicator.HorizSize = 10;
            linearGauge.MaxValueIndicator.Visible = true;
        }

        private void InitScalesLinearGaugeChart()
        {
            LinearGauge linearGauge;
            linearGauge = new LinearGauge();

            _tChart.Chart.Series.Add(linearGauge);
            _tChart.Chart.Header.Visible = false;
            _tChart.Rotation = 0;

            linearGauge.Value = 70;
            linearGauge.Axis.Increment = 10;
            linearGauge.Maximum = 100;
            linearGauge.Minimum = 0;

            linearGauge.Hand.Gradient.Visible = true;
            linearGauge.Hand.Gradient.StartColor = Color.FromArgb(255, 0, 129, 206);
            linearGauge.Hand.Gradient.EndColor = Color.FromArgb(255, 40, 174, 225);
            linearGauge.Hand.Gradient.MiddleColor = Color.FromArgb(255, 0, 153, 244);
            linearGauge.Hand.Gradient.Direction = GradientDirection.BottomTop;
            linearGauge.GreenLine.Visible = false;
            linearGauge.RedLine.Visible = false;
            linearGauge.MinorTicks.Visible = false;
            linearGauge.Ticks.Visible = true;
            linearGauge.Ticks.VertSize = 70;
            linearGauge.Ticks.HorizSize = 1;
            linearGauge.Ticks.Color = Color.White;
            linearGauge.Ticks.Pen.Color = Color.White;
            linearGauge.MaxValueIndicator.Visible = true;
            linearGauge.MaxValueIndicator.VertSize = 12;
            linearGauge.MaxValueIndicator.HorizSize = 12;
            linearGauge.MaxValueIndicator.Color = Color.FromArgb(255, 0, 93, 160);
            linearGauge.FaceBrush.Gradient.Visible = false;
            linearGauge.FaceBrush.Color = Color.White;
            linearGauge.ValueAreaBrush.Visible = true;
            linearGauge.ValueAreaBrush.Color = Color.FromArgb(255, 170, 210, 240);
            linearGauge.IsoVertAxes = false;
            linearGauge.IsoHorizAxes = false;
        }

        private void InitSublinesLinearGaugeChart()
        {
            LinearGauge linearGauge;
            linearGauge = new LinearGauge();

            _tChart.Chart.Series.Add(linearGauge);
            _tChart.Chart.Header.Visible = false;

            linearGauge.Value = 6;
            linearGauge.Maximum = 10;
            linearGauge.Minimum = 0;

            linearGauge.Axis.AxisPen.Color = Color.Green;
            linearGauge.Axis.MinorGrid.Visible = false;
            linearGauge.Axis.Labels.Font.Size = 12;
            linearGauge.Axis.Labels.Color = Color.Blue;
            linearGauge.Axis.Ticks.Visible = true;
            linearGauge.Axis.Increment = 1;

            _tChart.Chart.Axes.Bottom.Labels.Font.Size = 12;
            _tChart.Chart.Axes.Bottom.Labels.Font.Color = Color.Green;
            _tChart.Chart.Axes.Bottom.MinorTicks.Visible = false;
            _tChart.Chart.Axes.Bottom.MinorTicks.Length = 20;
            _tChart.Chart.Axes.Bottom.MinorTicks.Width = 1;
            _tChart.Chart.Axes.Bottom.MinorTicks.Transparency = 100;
            _tChart.Chart.Axes.Bottom.Ticks.Visible = false;
            _tChart.Rotation = 0;

            linearGauge.Hand.Gradient.Visible = true;
            linearGauge.Hand.Gradient.StartColor = Color.FromArgb(255, 0, 209, 106);
            linearGauge.Hand.Gradient.MiddleColor = Color.FromArgb(255, 0, 187, 84);
            linearGauge.Hand.Gradient.EndColor = Color.FromArgb(255, 20, 144, 65);
            linearGauge.Hand.Gradient.Direction = GradientDirection.BottomTop;
            linearGauge.Hand.Transparency = 20;

            linearGauge.GreenLine.Visible = true;
            linearGauge.GreenLine.VertSize = 30;
            linearGauge.GreenLine.Gradient.StartColor = Color.FromArgb(255, 30, 119, 226);
            linearGauge.GreenLine.Gradient.MiddleColor = Color.FromArgb(255, 10, 80, 160);
            linearGauge.GreenLine.Gradient.EndColor = Color.FromArgb(255, 0, 40, 115);
            linearGauge.GreenLineEndValue = 5;
            linearGauge.GreenLineStartValue = 0;

            linearGauge.RedLine.Visible = true;
            linearGauge.RedLine.VertSize = 30;
            linearGauge.RedLine.Gradient.StartColor = Color.FromArgb(255, 110, 6, 9);
            linearGauge.RedLine.Gradient.MiddleColor = Color.FromArgb(255, 160, 10, 10);
            linearGauge.RedLine.Gradient.EndColor = Color.FromArgb(255, 200, 19, 16);
            linearGauge.RedLineStartValue = 7;
            linearGauge.RedLineEndValue = 10;

            linearGauge.MinorTicks.Visible = false;

            linearGauge.Ticks.Visible = false;
            linearGauge.Ticks.VertSize = 70;
            linearGauge.Ticks.HorizSize = 1;
            linearGauge.Ticks.Color = Color.White;
            linearGauge.Ticks.Pen.Color = Color.White;

            linearGauge.MaxValueIndicator.Visible = true;
            linearGauge.MaxValueIndicator.VertSize = 15;
            linearGauge.MaxValueIndicator.HorizSize = 15;
            linearGauge.MaxValueIndicator.Color = Color.FromArgb(255, 20, 93, 20);
            linearGauge.MaxValueIndicator.Style = PointerStyles.Triangle;

            linearGauge.FaceBrush.Gradient.Visible = false;
            linearGauge.FaceBrush.Color = Color.White;

            linearGauge.ValueAreaBrush.Visible = true;
            linearGauge.ValueAreaBrush.Color = Color.FromArgb(255, 180, 255, 230);

            linearGauge.IsoVertAxes = false;
            linearGauge.IsoHorizAxes = false;
        }

        private void InitMobileBatteryLinearGaugeChart()
        {
            VerticalLinearGauge linearGauge;

            linearGauge = new VerticalLinearGauge();

            _tChart.Chart.Series.Add(linearGauge);
            _tChart.Chart.Footer.Visible = true;
            _tChart.Chart.Footer.Font.Size = 30;
            _tChart.Chart.Footer.Font.Color = Color.Black;
            _tChart.Header.Visible = false;

            linearGauge.Maximum = 100;
            linearGauge.Minimum = 0;

            linearGauge.Axis.AxisPen.Color = Color.White;
            linearGauge.Axis.MinorGrid.Visible = true;
            linearGauge.Axis.Labels.Font.Size = 12;
            linearGauge.Axis.Labels.Color = Color.White;
            linearGauge.Axis.Ticks.Visible = true;
            linearGauge.Axis.Increment = 10;

            _tChart.Chart.Axes.Bottom.Labels.Font.Size = 16;
            _tChart.Chart.Axes.Bottom.Labels.Font.Color = Color.Black;
            _tChart.Chart.Axes.Bottom.Labels.Transparency = 100;
            _tChart.Chart.Axes.Bottom.MinorTicks.Visible = true;
            _tChart.Chart.Axes.Bottom.MinorTicks.Length = 20;
            _tChart.Chart.Axes.Bottom.MinorTicks.Width = 1;
            _tChart.Chart.Axes.Bottom.MinorTicks.Transparency = 100;
            _tChart.Chart.Axes.Bottom.Ticks.Visible = false;

            linearGauge.Hand.Gradient.Visible = false;
            linearGauge.Hand.Color = Color.White;
            linearGauge.Hand.Transparency = 0;

            linearGauge.GreenLine.Visible = false;
            linearGauge.RedLine.Visible = false;

            linearGauge.Ticks.Visible = true;
            linearGauge.Ticks.VertSize = 150;
            linearGauge.Ticks.HorizSize = (int)2.5;
            linearGauge.Ticks.Color = Color.White;
            linearGauge.Ticks.Pen.Color = Color.White;
            linearGauge.Axis.Labels.Font.Color = Color.White;

            linearGauge.MaxValueIndicator.Visible = false;

            linearGauge.FaceBrush.Gradient.Visible = false;
            linearGauge.FaceBrush.Color = Color.FromArgb(100,100,100);

            //linearGauge.ValueAreaBrush.Visible = true;

            //AddFaceBrushColor(value);

            //linearGauge.IsoVertAxes = false;
            //linearGauge.IsoHorizAxes = false;

            linearGauge.Marks.Visible = false;
            linearGauge.ValueChanged += LinearGauge_ValueChanged;

            Application.Context.RegisterReceiver(new BatterySensorExtension(linearGauge), new IntentFilter(Intent.ActionBatteryChanged));
        }

        private void LinearGauge_ValueChanged(object sender, EventArgs e)
        {
            _tChart.Footer.Text = (sender as VerticalLinearGauge).Value.ToString() + "%";
        }

        private class BatterySensorExtension : BroadcastReceiver
        {
            VerticalLinearGauge gauge;
            public BatterySensorExtension(VerticalLinearGauge gauge)
            {
                this.gauge = gauge;
            }
            public override void OnReceive(Context context, Intent intent)
            {
                int level = intent.GetIntExtra(BatteryManager.ExtraLevel, 0);
                gauge.Value = level;
                
            }
        }

        #endregion

        #region CALENDAR

        private void InitBasicCalendarChart()
        {
            Steema.TeeChart.Styles.Calendar calendar;
            calendar = new Steema.TeeChart.Styles.Calendar();

            _tChart.Chart.Header.Font.Size = 25;
            _tChart.Chart.Header.Text = "Calendar";
            _tChart.Chart.Header.Visible = true;

            calendar.FillSampleValues();
            _tChart.Chart.Series.Add(calendar);
            calendar.PreviousMonthButton.Visible = false;
            calendar.NextMonthButton.Visible = false;
            calendar.Trailing.Color = Color.FromArgb(255, 200, 200, 200);
            calendar.Trailing.Font.Size = 14;
            calendar.Today.Color = Color.FromArgb(255, 210, 210, 210);
            calendar.Today.Font.Color = Color.Black;
            calendar.Today.Font.Size = 14;
            calendar.WeekDays.Font.Size = 16;
            calendar.WeekDays.Font.Color = Color.FromArgb(255, 150, 150, 150);
            calendar.WeekDays.TextAlign = Android.Graphics.Paint.Align.Left;
            calendar.WeekDays.Pen.Width = 1;
            calendar.Days.Font.Size = 14;
            calendar.Days.TextAlign = Android.Graphics.Paint.Align.Left;
            calendar.WeekDays.Color = Color.Transparent;
            calendar.Sunday.Color = Color.Transparent;
            calendar.Sunday.Font.Size = 14;
            calendar.Sunday.Font.Color = Color.Black;
            calendar.Sunday.Pen.Width = 0;
            calendar.Sunday.Pen.Visible = false;
            calendar.Months.Visible = false;

            _tChart.Chart.Panning.Active = true;
        }

        private void InitSpecialDatesChart()
        {
            Steema.TeeChart.Styles.Calendar calendar;
            calendar = new Steema.TeeChart.Styles.Calendar();

            _tChart.Chart.Header.TextAlign = Android.Graphics.Paint.Align.Right;
            _tChart.Chart.Header.Visible = true;
            _tChart.Chart.Header.Text = DateTime.Today.ToShortDateString();
            _tChart.Chart.Header.Font.Size += 5;

            _tChart.Chart.SubHeader.Visible = true;
            _tChart.Chart.SubHeader.Text = "Hola";
            _tChart.Chart.SubHeader.Font.Size = 15;
            _tChart.Chart.SubHeader.Transparency = 100;

            calendar.FillSampleValues();
            _tChart.Chart.Series.Add(calendar);
            calendar.PreviousMonthButton.Visible = false;
            calendar.NextMonthButton.Visible = false;
            calendar.Trailing.Color = Color.FromArgb(200, 200, 200);
            calendar.Trailing.Font.Size = 14;
            calendar.Today.Color = Color.FromArgb(255, 240, 240);
            calendar.Today.Font.Color = Color.Black;
            calendar.Today.Font.Size = 14;
            calendar.Today.BorderRound = 90;
            calendar.WeekDays.Font.Size = 15;
            calendar.WeekDays.Font.Color = Color.FromArgb(180, 100, 100);
            calendar.WeekDays.TextAlign = Android.Graphics.Paint.Align.Left;
            calendar.WeekDays.Pen.Width = 1;
            calendar.WeekDays.UpperCase = true;
            calendar.Days.Font.Size = 14;
            calendar.Days.TextAlign = Android.Graphics.Paint.Align.Left;
            calendar.WeekDays.Color = Color.FromArgb(250, 230, 230);
            calendar.Sunday.Color = Color.Red;
            calendar.Sunday.Font.Size = 16;
            calendar.Sunday.Font.Color = Color.White;
            calendar.Sunday.ShapeStyle = TextShapeStyle.Rectangle;
            calendar.Sunday.Color = Color.FromArgb(235, 160, 160);
            calendar.Sunday.Gradient.Visible = false;
            calendar.Sunday.Pen.Visible = false;
            calendar.Months.Visible = false;
            calendar.Pen.Visible = true;
            calendar.Pen.Width = 3;
            calendar.Pen.Style = DashStyle.DashDot;
            calendar.Pen.Color = Color.FromArgb(200, 130, 130);

            _tChart.ClickSeries += _tChart_ClickSeries;
        }

        private void _tChart_ClickSeries(object sender, Series s, int valueIndex, MotionEvent e)
        {
            (s as Calendar).SetCell((int)e.XPrecision, (int)e.YPrecision);
            s.Chart.Header.Text = (s as Calendar).Date.ToShortDateString();
        }

        #endregion

        #region TAGCLOUD

        private void InitTagCloudChart()
        {
            Steema.TeeChart.Styles.TagCloud tagCloud;
            tagCloud = new Steema.TeeChart.Styles.TagCloud();
            tagCloud.FillSampleValues(40);

            _tChart.Chart.Header.Font.Size = 60;
            _tChart.Chart.Header.Transparency = 100;

            _tChart.Chart.Series.Add(tagCloud);
            tagCloud.TagSeparation = 5;
        }

        #endregion

        #region STANDARD FUNCTIONS

        private void InitAddStdFuncChart()
        {
            Steema.TeeChart.Functions.Add addFunction;
            Bar bar;
            Line theAddLine;

            addFunction = new Steema.TeeChart.Functions.Add();
            bar = new Bar();
            theAddLine = new Line();

            _tChart.Chart.Series.Add(bar);
            _tChart.Chart.Series.Add(theAddLine);

            bar.Title = "Data";
            theAddLine.Title = "Add";
            theAddLine.LinePen.Width = 6;

            bar.FillSampleValues(5);

            theAddLine.Function = addFunction;
            theAddLine.DataSource = bar;

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue, _tChart.Chart.Axes.Left.MaxYValue + 100);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Left.Increment = 500;
            _tChart.Chart.Axes.Bottom.Labels.Visible = false;
            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Header.Visible = false;

            theAddLine.Marks.Visible = true;
            theAddLine.Marks.Width += 40;
            theAddLine.Marks.DrawEvery = 2;
        }

        private void InitSubstractStdFuncChart()
        {
            Steema.TeeChart.Functions.Subtract subtFunction;
            Bar bar1;
            Bar bar2;
            Line theSubtLine;

            subtFunction = new Steema.TeeChart.Functions.Subtract();
            bar1 = new Bar();
            bar2 = new Bar();
            theSubtLine = new Line();

            bar1.FillSampleValues(5);
            bar2.FillSampleValues(5);

            _tChart.Chart.Series.Add(bar1);
            _tChart.Chart.Series.Add(bar2);
            _tChart.Chart.Series.Add(theSubtLine);

            theSubtLine.Function = subtFunction;
            theSubtLine.DataSource = new object[] { bar1, bar2 };

            bar1.Title = "Data 1";
            bar1.MarksLocation = MarksLocation.Start;

            bar2.Title = "Data 2";
            bar2.MarksLocation = MarksLocation.Start;

            theSubtLine.Title = "Subtract";
            theSubtLine.LinePen.Width = 6;
            theSubtLine.Pointer.Style = PointerStyles.Sphere;
            theSubtLine.Pointer.InflateMargins = true;
            theSubtLine.Pointer.HorizSize = 5;
            theSubtLine.Pointer.VertSize = 5;
            theSubtLine.TreatNulls = TreatNullsStyle.DoNotPaint;
            theSubtLine.Pointer.Visible = true;
            theSubtLine.Marks.Visible = true;

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue + 0.3, _tChart.Chart.Axes.Left.MaxYValue + 3);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Left.Increment = 10;
            _tChart.Chart.Axes.Bottom.Labels.Visible = false;
            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Header.Visible = false;

            _tChart.Chart.Series[0].Marks.AutoSize = true;
            _tChart.Chart.Series[1].Marks.AutoSize = true;
            _tChart.Chart.Panel.MarginLeft = 5;
        }

        private void InitMultiplyStdFuncChart()
        {
            Steema.TeeChart.Functions.Multiply multFunction;
            Bar bar1;
            Bar bar2;
            Line theMultLine;
            multFunction = new Steema.TeeChart.Functions.Multiply();
            bar1 = new Bar();
            bar2 = new Bar();
            theMultLine = new Line();

            bar1.FillSampleValues(5);
            bar2.FillSampleValues(5);

            _tChart.Chart.Series.Add(bar1);
            _tChart.Chart.Series.Add(bar2);
            _tChart.Chart.Series.Add(theMultLine);

            theMultLine.Function = multFunction;
            theMultLine.DataSource = new object[] { bar1, bar2 };

            bar1.Title = "Data 1";
            bar1.MarksLocation = MarksLocation.Start;

            bar2.Title = "Data 2";
            bar2.MarksLocation = MarksLocation.Start;

            theMultLine.Title = "Multiply";
            theMultLine.LinePen.Width = 6;
            theMultLine.Pointer.Style = PointerStyles.Sphere;
            theMultLine.Pointer.InflateMargins = true;
            theMultLine.Pointer.HorizSize = 5;
            theMultLine.Pointer.VertSize = 5;
            theMultLine.Pointer.Visible = true;
            theMultLine.Marks.Visible = true;

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue + 0.1, _tChart.Chart.Axes.Left.MaxYValue + 2);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Left.Increment = 3000;
            _tChart.Chart.Axes.Bottom.Labels.Visible = false;
            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Header.Visible = false;

            bar1.Marks.Pen.Visible = false;
            bar2.Marks.Pen.Visible = false;

            bar1.Marks.TailStyle = MarksTail.None;
            bar2.Marks.TailStyle = MarksTail.None;

            _tChart.Chart.Series[0].Marks.AutoSize = true;
            _tChart.Chart.Series[1].Marks.AutoSize = true;
            _tChart.Chart.Panel.MarginLeft = 5;
        }

        private void InitDivideStdFuncChart()
        {
            Steema.TeeChart.Functions.Divide divFunction;
            Bar bar1;
            Bar bar2;
            Line theDivLine;

            divFunction = new Steema.TeeChart.Functions.Divide();
            bar1 = new Bar();
            bar2 = new Bar();
            theDivLine = new Line();

            bar1.FillSampleValues(5);
            bar2.FillSampleValues(5);

            _tChart.Chart.Series.Add(bar1);
            _tChart.Chart.Series.Add(bar2);
            _tChart.Chart.Series.Add(theDivLine);

            theDivLine.Function = divFunction;
            theDivLine.DataSource = new object[] { bar1, bar2 };

            bar1.Title = "Data 1";
            bar1.MarksOnBar = false;
            bar1.MarksLocation = MarksLocation.Start;

            bar2.Title = "Data 2";
            bar2.MarksOnBar = false;
            bar2.MarksLocation = MarksLocation.Start;

            theDivLine.Title = "Divide";
            theDivLine.LinePen.Width = 6;
            theDivLine.Pointer.Style = PointerStyles.Sphere;
            theDivLine.Pointer.InflateMargins = true;
            theDivLine.Pointer.HorizSize = 5;
            theDivLine.Pointer.VertSize = 5;
            theDivLine.Pointer.Visible = true;
            theDivLine.Marks.Visible = true;

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue + 0.1, _tChart.Chart.Axes.Left.MaxYValue + 2);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Left.Increment = 3;
            _tChart.Chart.Axes.Bottom.Labels.Visible = false;
            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Header.Visible = false;

            _tChart.Chart.Panel.MarginLeft = 5;
        }

        private void InitCountStdFuncChart()
        {
            Steema.TeeChart.Functions.Count countFunction;
            Bar bar1;
            Line theCountLine;
        
            countFunction = new Steema.TeeChart.Functions.Count();
            bar1 = new Bar();
            theCountLine = new Line();

            bar1.FillSampleValues(5);

            _tChart.Chart.Series.Add(bar1);
            _tChart.Chart.Series.Add(theCountLine);

            theCountLine.Function = countFunction;
            theCountLine.DataSource = new object[] { bar1 };

            bar1.Title = "Data";
            bar1.MarksLocation = MarksLocation.Start;

            theCountLine.Title = "Count";
            theCountLine.LinePen.Width = 6;
            theCountLine.Pointer.Style = PointerStyles.Sphere;
            theCountLine.Pointer.InflateMargins = true;
            theCountLine.Pointer.HorizSize = 5;
            theCountLine.Pointer.VertSize = 5;
            theCountLine.Pointer.Visible = true;
            theCountLine.Marks.Visible = true;
            theCountLine.Marks.DrawEvery = 2;

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue + 0.07, _tChart.Chart.Axes.Left.MaxYValue + 2);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Left.Increment = 3;
            _tChart.Chart.Axes.Bottom.Labels.Visible = false;
            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Header.Visible = false;

            bar1.Marks.Pen.Visible = false;
            bar1.Marks.TailStyle = MarksTail.None;
        }

        private void InitAverageStdFuncChart()
        {
            Steema.TeeChart.Functions.Average avgFunction;
            Bar bar1;
            Line theAvgLine;
            avgFunction = new Steema.TeeChart.Functions.Average();
            bar1 = new Bar();
            theAvgLine = new Line();

            bar1.FillSampleValues(5);

            _tChart.Chart.Series.Add(bar1);
            _tChart.Chart.Series.Add(theAvgLine);

            theAvgLine.Function = avgFunction;
            theAvgLine.DataSource = new object[] { bar1 };

            bar1.Title = "Data";
            bar1.MarksOnBar = true;
            bar1.MarksLocation = MarksLocation.Start;
            bar1.Marks.TailStyle = MarksTail.None;

            theAvgLine.Title = "Average";
            theAvgLine.LinePen.Width = 6;
            theAvgLine.Pointer.Style = PointerStyles.Sphere;
            theAvgLine.Pointer.InflateMargins = true;
            theAvgLine.Pointer.HorizSize = 5;
            theAvgLine.Pointer.VertSize = 5;
            theAvgLine.Pointer.Visible = true;
            theAvgLine.Marks.Visible = true;
            theAvgLine.Marks.DrawEvery = 2;

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue + 1.6, _tChart.Chart.Axes.Left.MaxYValue + 2);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Left.Increment = 20;
            _tChart.Chart.Axes.Bottom.Labels.Visible = false;
            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Header.Visible = false;

            theAvgLine.Marks.AutoSize = true;
            theAvgLine.Marks.FollowSeriesColor = true;
            theAvgLine.Marks.Pen.Width = 1;
            theAvgLine.Marks.Font.Size = 13;
        }

        private void InitHighStdFuncChart()
        {
            Steema.TeeChart.Functions.High highFunction;
            Bar bar1;
            Line theHighLine;

            highFunction = new Steema.TeeChart.Functions.High();
            bar1 = new Bar();
            theHighLine = new Line();

            bar1.FillSampleValues(5);

            _tChart.Chart.Series.Add(bar1);
            _tChart.Chart.Series.Add(theHighLine);

            theHighLine.Function = highFunction;
            theHighLine.DataSource = new object[] { bar1 };

            bar1.Title = "Data";
            bar1.MarksOnBar = true;
            bar1.MarksLocation = MarksLocation.Start;

            theHighLine.Title = "High";
            theHighLine.LinePen.Width = 6;
            theHighLine.Pointer.Style = PointerStyles.Sphere;
            theHighLine.Pointer.InflateMargins = true;
            theHighLine.Pointer.HorizSize = 5;
            theHighLine.Pointer.VertSize = 5;
            theHighLine.Pointer.Visible = true;
            theHighLine.Marks.Visible = true;
            theHighLine.Marks.DrawEvery = 2;

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue + 0.23, _tChart.Chart.Axes.Left.MaxYValue + 2);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Left.Increment = 5;
            _tChart.Chart.Axes.Bottom.Labels.Visible = false;
            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Header.Visible = false;

            bar1.Marks.Pen.Visible = false;

            bar1.Marks.TailStyle = MarksTail.None;
        }

        private void InitLowStdFuncChart()
        {
            Steema.TeeChart.Functions.Low lowFunction;
            Bar bar1;
            Line theLowLine;
            lowFunction = new Steema.TeeChart.Functions.Low();
            bar1 = new Bar();
            theLowLine = new Line();

            bar1.FillSampleValues(5);

            _tChart.Chart.Series.Add(bar1);
            _tChart.Chart.Series.Add(theLowLine);

            theLowLine.Function = lowFunction;
            theLowLine.DataSource = new object[] { bar1 };

            bar1.Title = "Data";
            bar1.MarksOnBar = true;
            bar1.MarksLocation = MarksLocation.Start;

            theLowLine.Title = "Low";
            theLowLine.LinePen.Width = 6;
            theLowLine.Pointer.Style = PointerStyles.Sphere;
            theLowLine.Pointer.InflateMargins = true;
            theLowLine.Pointer.HorizSize = 5;
            theLowLine.Pointer.VertSize = 5;
            theLowLine.Pointer.Visible = true;
            theLowLine.Marks.Visible = true;
            theLowLine.Marks.DrawEvery = 2;

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue + 0.15, _tChart.Chart.Axes.Left.MaxYValue + 2);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Left.Increment = 3;
            _tChart.Chart.Axes.Bottom.Labels.Visible = false;
            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Header.Visible = false;

            bar1.Marks.Pen.Visible = false;

            bar1.Marks.TailStyle = MarksTail.None;
        }

        private void InitMedianStdFuncChart()
        {
            Steema.TeeChart.Functions.MedianFunction medianFunction;
            Line line;
            Line theMedianLine;

            medianFunction = new Steema.TeeChart.Functions.MedianFunction();
            line = new Line();
            theMedianLine = new Line();

            line.FillSampleValues(5);

            _tChart.Chart.Series.Add(line);
            _tChart.Chart.Series.Add(theMedianLine);

            theMedianLine.Function = medianFunction;
            theMedianLine.DataSource = new object[] { line };

            line.Title = "Data";
            line.Marks.Visible = false;
            line.LinePen.Width = 4;

            theMedianLine.Title = "Median";
            theMedianLine.LinePen.Width = 6;
            theMedianLine.Pointer.Visible = true;
            theMedianLine.Marks.Visible = true;
            theMedianLine.Marks.DrawEvery = 2;

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue, _tChart.Chart.Axes.Left.MaxYValue + 2);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Left.Increment = 10;
            _tChart.Chart.Axes.Bottom.Labels.Visible = false;
            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Header.Visible = false;
        }

        private void InitPercentChangeStdFuncChart()
        {
            Steema.TeeChart.Functions.PercentChange percentFunction;
            Area area;
            Line thePercentLine;
            percentFunction = new Steema.TeeChart.Functions.PercentChange();
            area = new Area();
            thePercentLine = new Line();

            area.FillSampleValues(5);

            _tChart.Chart.Series.Add(area);
            _tChart.Chart.Series.Add(thePercentLine);

            thePercentLine.Function = percentFunction;
            thePercentLine.DataSource = new object[] { area };

            area.Title = "Data";
            area.Smoothed = true;

            thePercentLine.Title = "Percent Change";
            thePercentLine.LinePen.Width = 6;
            thePercentLine.Pointer.Visible = false;
            thePercentLine.Marks.Visible = false;
            thePercentLine.VertAxis = VerticalAxis.Right;
            thePercentLine.LinePen.EndCap = Android.Graphics.Paint.Cap.Round;

            _tChart.Chart.Axes.Left.SetMinMax(_tChart.Chart.Axes.Left.MinYValue, _tChart.Chart.Axes.Left.MaxYValue + 2);
            _tChart.Chart.Axes.Bottom.SetMinMax(_tChart.Chart.Axes.Bottom.MinXValue, _tChart.Chart.Axes.Bottom.MaxXValue);
            _tChart.Chart.Axes.Left.Increment = 3;
            _tChart.Chart.Axes.Bottom.Labels.Visible = false;
            _tChart.Chart.Axes.Left.Grid.Visible = false;
            _tChart.Chart.Axes.Left.AxisPen.Visible = true;
            _tChart.Chart.Header.Visible = false;

            area.Marks.Pen.Visible = false;

            area.Marks.TailStyle = MarksTail.None;
            area.Transparency = 50;
            area.AreaLines.Visible = false;
            area.LinePen.Width = 5;
            area.LinePen.Transparency = 50;
            area.AreaLines.Width = 0;
            area.AreaLines.Transparency = 100;
            area.AreaLinesPen.Width = 1;
            area.AreaLinesPen.Visible = true;
        }

        #endregion

        #endregion

        #region EXTRA FUNCTIONS 

        /// <summary>
        /// Retorna la posició del valor introduït dins de l'array
        /// </summary>
        public int GetXIndexFromValue(Series series, double value)
        {
            bool trobat = false;
            int position = 0;
            while(!trobat && position < series.XValues.Count)
            {
                trobat = (series.XValues.Value[position] < value + 0.12 && series.XValues.Value[position] > value - 0.12);
                position++;
            }
            if (!trobat) return -1;
            return position - 1;            
        }

        #endregion

    }
}