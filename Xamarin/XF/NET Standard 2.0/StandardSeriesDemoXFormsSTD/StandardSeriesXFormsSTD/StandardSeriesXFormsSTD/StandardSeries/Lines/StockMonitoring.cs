using System;
using Steema.TeeChart;
using Xamarin.Forms;

namespace StandardSeriesXFormsSTD
{
	public class StockMonitoring : ContentPage
	{
        ChartView tChart1;        
        private Steema.TeeChart.Styles.Line line1;
        private Steema.TeeChart.Styles.Line line2;
        private Steema.TeeChart.Styles.Line line3;
        private Steema.TeeChart.Tools.MarksTip marksTip1;
		public StockMonitoring ()
		{
            this.Title = "Stock Monitoring";

            tChart1 = new ChartView();
            tChart1.WidthRequest = 400;
            tChart1.HeightRequest = 300;

            tChart1.Chart.Aspect.View3D = false;
            tChart1.Chart.Zoom.Active = true;
            tChart1.Chart.Aspect.ZoomText = true;
            tChart1.Chart.Panning.Active = true;

            this.line1 = new Steema.TeeChart.Styles.Line();
            this.line2 = new Steema.TeeChart.Styles.Line();
            this.line3 = new Steema.TeeChart.Styles.Line();
            this.marksTip1 = new Steema.TeeChart.Tools.MarksTip();
            this.tChart1.Chart.Aspect.Elevation = 350;
            this.tChart1.Chart.Aspect.ElevationFloat = 350D;
            this.tChart1.Chart.Aspect.Perspective = 55;
            this.tChart1.Chart.Aspect.View3D = false;
            this.tChart1.Chart.Axes.Bottom.AxisPen.Color = Color.FromRgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.tChart1.Chart.Axes.Bottom.AxisPen.Width = 0;
            this.tChart1.Chart.Axes.Bottom.Grid.Color = Color.FromRgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.tChart1.Chart.Axes.Bottom.Grid.Visible = false;
            this.tChart1.Chart.Axes.Bottom.Labels.Font.Brush.Color = Color.Gray;
            this.tChart1.Chart.Axes.Bottom.Labels.Font.Name = "Segoe UI";
            this.tChart1.Chart.Axes.Bottom.Labels.Font.Size = 16;
            this.tChart1.Chart.Axes.Bottom.MinorTicks.Visible = false;
            this.tChart1.Chart.Axes.Bottom.Ticks.Color = Color.FromRgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Chart.Axes.Bottom.Title.Font.Name = "Segoe UI";
            this.tChart1.Chart.Axes.Depth.Title.Font.Name = "Segoe UI";
            this.tChart1.Chart.Axes.Depth.Title.Font.Size = 13;
            this.tChart1.Chart.Axes.DepthTop.Title.Font.Name = "Segoe UI";
            this.tChart1.Chart.Axes.DepthTop.Title.Font.Size = 13;
            this.tChart1.Chart.Axes.Left.AxisPen.Visible = false;
            this.tChart1.Chart.Axes.Left.AxisPen.Width = 0;
            this.tChart1.Chart.Axes.Left.Grid.Color = Color.FromRgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.tChart1.Chart.Axes.Left.Labels.Font.Brush.Color = Color.Gray;
            this.tChart1.Chart.Axes.Left.Labels.Font.Name = "Segoe UI";
            this.tChart1.Chart.Axes.Left.Labels.Font.Size = 16;
            this.tChart1.Chart.Axes.Left.MinorTicks.Visible = false;
            this.tChart1.Chart.Axes.Left.Ticks.Color = Color.FromRgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Chart.Axes.Left.Ticks.Length = 7;
            this.tChart1.Chart.Axes.Left.Title.Caption = "Quote";
            this.tChart1.Chart.Axes.Left.Title.Font.Brush.Color = Color.Gray;
            this.tChart1.Chart.Axes.Left.Title.Font.Name = "Segoe UI";
            this.tChart1.Chart.Axes.Left.Title.Lines = new string[] {"Quote"};
            this.tChart1.Chart.Axes.Right.AxisPen.Width = 0;
            this.tChart1.Chart.Axes.Right.Grid.Visible = false;
            this.tChart1.Chart.Axes.Right.Labels.Font.Brush.Color = Color.Gray;
            this.tChart1.Chart.Axes.Right.Labels.Font.Name = "Segoe UI";
            this.tChart1.Chart.Axes.Right.Labels.Font.Size = 31;
            this.tChart1.Chart.Axes.Right.MinorTicks.Visible = false;
            this.tChart1.Chart.Axes.Right.Ticks.Visible = false;
            this.tChart1.Chart.Axes.Right.Title.Font.Name = "Segoe UI";
            this.tChart1.Chart.Axes.Top.Title.Font.Name = "Segoe UI";
            this.tChart1.Chart.Footer.Font.Brush.Color = Color.Blue;
            //this.tChart1.Header.Font.Bold = true;
            this.tChart1.Chart.Header.Font.Brush.Color = Color.Gray;
            this.tChart1.Chart.Header.Font.Name = "Segoe UI Lt";
            this.tChart1.Chart.Header.Font.Shadow.Brush.Color = Color.FromRgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Chart.Header.Font.Shadow.SmoothBlur = 2;
            this.tChart1.Chart.Header.Font.Shadow.Visible = true;
            this.tChart1.Chart.Header.Font.Size = 14;            
            this.tChart1.Chart.Header.Lines = new string[] {"Stock Monitoring"};
            this.tChart1.Chart.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
            this.tChart1.Chart.Legend.Font.Brush.Color = Color.Gray;
            this.tChart1.Chart.Legend.Font.Name = "Segoe UI";
            this.tChart1.Chart.Legend.Font.Size = 13;
            this.tChart1.Chart.Legend.Pen.Visible = false;
            this.tChart1.Chart.Legend.Shadow.Visible = false;
            this.tChart1.Chart.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            this.tChart1.Chart.Panel.Bevel.Width = 2;
            this.tChart1.Chart.Panel.BevelWidth = 2;
            this.tChart1.Chart.Panel.Brush.Color = Color.White;
            this.tChart1.Chart.Series.Add(this.line1);
            this.tChart1.Chart.Series.Add(this.line2);
            this.tChart1.Chart.Series.Add(this.line3);
            this.tChart1.Chart.Tools.Add(this.marksTip1);
            this.tChart1.Chart.Walls.Back.Brush.Gradient.EndColor = Color.White;
            this.tChart1.Chart.Walls.Back.Pen.Visible = false;
            this.tChart1.Chart.Walls.Back.Visible = false;
            this.tChart1.Chart.Walls.Bottom.Brush.Gradient.EndColor = Color.Silver;
            this.tChart1.Chart.Walls.Bottom.Brush.Gradient.StartColor = Color.Gray;
            this.tChart1.Chart.Walls.Bottom.Brush.Gradient.Visible = true;
            this.tChart1.Chart.Walls.Bottom.Pen.Color = Color.Gray;
            this.tChart1.Chart.Walls.Bottom.Transparent = true;
            this.tChart1.Chart.Walls.Left.Brush.Color = Color.White;
            this.tChart1.Chart.Walls.Left.Brush.Gradient.EndColor = Color.Silver;
            this.tChart1.Chart.Walls.Left.Brush.Gradient.StartColor = Color.Gray;
            this.tChart1.Chart.Walls.Left.Brush.Gradient.Visible = true;
            this.tChart1.Chart.Walls.Left.Pen.Color = Color.Gray;
            this.tChart1.Chart.Walls.Left.Transparent = true;
            this.tChart1.Chart.Walls.Right.Transparent = true;
            // line1
            this.line1.Brush.Color = Color.FromRgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.line1.Color = Color.FromRgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.line1.ColorEach = false;
            this.line1.LinePen.Color = Color.FromRgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.line1.LinePen.Width = 3;
            this.line1.Marks.Arrow.Visible = false;
            this.line1.Marks.ArrowLength = 0;
            this.line1.Marks.Font.Name = "Segoe UI";
            this.line1.Marks.Font.Size = 24;
            this.line1.Marks.Transparent = true;
            this.line1.Pointer.Brush.Color = Color.FromRgba(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.line1.Pointer.Brush.Gradient.Transparency = 2;
            this.line1.Pointer.HorizSize = 6;
            this.line1.Pointer.Pen.Color = Color.FromRgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.line1.Pointer.Pen.Width = 3;
            this.line1.Pointer.SizeDouble = 0D;
            this.line1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.line1.Pointer.VertSize = 6;
            this.line1.Pointer.Visible = true;
            this.line1.Title = "Portfolio 1";
            this.line1.ValueFormat = "#.##0,###";
            this.line1.XValues.DateTime = true;
            this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // line2
            this.line2.Brush.Color = Color.FromRgba(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.line2.Gradient.Transparency = 2;
            this.line2.Color = Color.FromRgba(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.line2.ColorEach = false;
            this.line2.LinePen.Color = Color.FromRgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.line2.LinePen.Transparency = 2;
            this.line2.LinePen.Width = 3;
            this.line2.Marks.Arrow.Transparency = 2;
            this.line2.Marks.Arrow.Visible = false;
            this.line2.Marks.ArrowLength = 0;
            this.line2.Marks.Brush.Color = Color.FromRgba(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(250)))));
            this.line2.Marks.Brush.Gradient.Transparency = 2;
            this.line2.Marks.Font.Brush.Color = Color.FromRgba(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(250)))));
            this.line2.Marks.Font.Brush.Gradient.Transparency = 2;
            this.line2.Marks.Font.Name = "Segoe UI";
            this.line2.Marks.Font.Size = 24;
            this.line2.Marks.Pen.Transparency = 2;
            this.line2.Marks.Shadow.Brush.Color = Color.FromRgba(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.line2.Marks.Shadow.Brush.Gradient.Transparency = 2;
            this.line2.Marks.Transparent = true;
            this.line2.Pointer.Brush.Color = Color.FromRgba(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.line2.Pointer.Brush.Gradient.Transparency = 2;
            this.line2.Pointer.HorizSize = 6;
            this.line2.Pointer.Pen.Color = Color.FromRgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.line2.Pointer.Pen.Transparency = 2;
            this.line2.Pointer.Pen.Width = 3;
            this.line2.Pointer.SizeDouble = 0D;
            this.line2.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.line2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.line2.Pointer.VertSize = 6;
            this.line2.Pointer.Visible = true;
            this.line2.Title = "Portfolio 2";
            this.line2.Transparency = 2;
            this.line2.ValueFormat = "#.##0,###";
            this.line2.XValues.DateTime = true;
            this.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // line3
            this.line3.Brush.Color = Color.FromRgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.line3.Color = Color.FromRgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.line3.ColorEach = false;
            this.line3.LinePen.Color = Color.FromRgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.line3.LinePen.Width = 3;
            this.line3.Marks.Arrow.Visible = false;
            this.line3.Marks.ArrowLength = 0;
            this.line3.Marks.Font.Name = "Segoe UI";
            this.line3.Marks.Font.Size = 24;
            this.line3.Marks.Transparent = true;
            this.line3.Pointer.Brush.Color = Color.FromRgba(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.line3.Pointer.Brush.Gradient.Transparency = 2;
            this.line3.Pointer.HorizSize = 6;
            this.line3.Pointer.Pen.Color = Color.FromRgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.line3.Pointer.Pen.Width = 3;
            this.line3.Pointer.SizeDouble = 0D;
            this.line3.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.line3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.line3.Pointer.VertSize = 6;
            this.line3.Pointer.Visible = true;
            this.line3.Title = "Portfolio 3";
            this.line3.ValueFormat = "#.##0,###";
            this.line3.XValues.DateTime = true;
            this.line3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // StockMonitoring

            tChart1.Chart.Panel.Gradient.Visible = false;
            tChart1.Chart.Walls.Back.Transparent = true;

            tChart1.Chart[0].FillSampleValues(12);
            tChart1.Chart[1].FillSampleValues(10);
            tChart1.Chart[2].FillSampleValues(11);

            this.tChart1.Chart.Aspect.ZoomText = true;

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = {
                    tChart1
                }
            };
        }
	}
}


