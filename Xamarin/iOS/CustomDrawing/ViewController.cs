using System;

using UIKit;
using Steema.TeeChart;
using System.Drawing;

namespace CustomDrawing
{
    public partial class ViewController : UIViewController
    {
        TChart Chart1;

        private Steema.TeeChart.Styles.Line line1;
        private Steema.TeeChart.Styles.Bar3D bar3D1;
        private Steema.TeeChart.Styles.Line line2;
        private Steema.TeeChart.Tools.Annotation annotation1;
        private Steema.TeeChart.Tools.Annotation annotation2;


        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            InitChart();
        }

        private void InitChart()
        {
            // Create the Chart
            Chart1 = new TChart();

            // Assign a Rect frame
            Chart1.Frame = this.View.Frame;

            // Creates the AfterDraw Event call
            Chart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(chart_AfterDraw);
            Chart1.GetAxisLabel += Chart1_GetAxisLabel;

            // Adds the Chart view to the Root view
            this.View.AddSubview(Chart1);

            Chart1.Aspect.View3D = false;

            this.Chart1.Axes.Bottom.AxisPen.Visible = false;
            this.Chart1.Axes.Bottom.Grid.Color = Color.FromArgb(255, 20, 44, 80);
            this.Chart1.Axes.Bottom.Grid.Style = Steema.TeeChart.Drawing.DashStyle.Solid;
            this.Chart1.Axes.Bottom.Grid.Width = 2;
            this.Chart1.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb(255, 255, 255, 255);
            this.Chart1.Axes.Bottom.MinorTicks.Visible = false;
            this.Chart1.Axes.Bottom.TickOnLabelsOnly = false;
            this.Chart1.Axes.Bottom.Ticks.Visible = false;
            this.Chart1.Axes.Left.AxisPen.Visible = false;
            this.Chart1.Axes.Left.Grid.Visible = false;
            this.Chart1.Axes.Left.Increment = 5D;
            this.Chart1.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb(255, 128, 128, 255);
            this.Chart1.Axes.Left.Labels.Font.Size = 9;
            this.Chart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            this.Chart1.Axes.Left.MinorTicks.Visible = false;
            this.Chart1.Axes.Left.TickOnLabelsOnly = false;
            this.Chart1.Axes.Left.Ticks.Visible = false;
            this.Chart1.Header.Font.Brush.Color = Color.FromArgb(255, 255, 255, 255);
            this.Chart1.Header.Font.Size = 21;
            this.Chart1.Header.Font.SizeFloat = 21F;
            this.Chart1.Header.Lines = new string[] {
                        "Custom drawing on Chart"};

            this.Chart1.Legend.Visible = false;
            this.Chart1.Panel.Brush.Color = Color.FromArgb(255, 29, 56, 109);
            this.Chart1.Panel.Brush.Gradient.Visible = false;
            this.Chart1.Panel.MarginLeft = 22D;

            line1 = new Steema.TeeChart.Styles.Line();
            bar3D1 = new Steema.TeeChart.Styles.Bar3D();
            line2 = new Steema.TeeChart.Styles.Line();

            this.Chart1.Series.Add(this.line1);
            this.Chart1.Series.Add(this.bar3D1);
            this.Chart1.Series.Add(this.line2);
            annotation1 = new Steema.TeeChart.Tools.Annotation();
            annotation2 = new Steema.TeeChart.Tools.Annotation();

            this.Chart1.Tools.Add(this.annotation1);
            this.Chart1.Tools.Add(this.annotation2);
            this.Chart1.Walls.Visible = false;
            // line1
            this.line1.Brush.Color = Color.FromArgb(255, 255, 255, 255);
            this.line1.Color = Color.FromArgb(255, 255, 255, 255);
            this.line1.ColorEach = false;
            this.line1.LinePen.Color = Color.FromArgb(255, 255, 255, 255);
            this.line1.Pointer.Pen.Color = Color.FromArgb(255, 29, 56, 109);
            this.line1.Pointer.SizeDouble = 0D;
            this.line1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.line1.Pointer.Visible = true;
            this.line1.Title = "line1";
            this.line1.XValues.DataMember = "X";
            this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.line1.YValues.DataMember = "Y";
            // 
            // bar3D1
            this.bar3D1.Brush.Color = Color.FromArgb(255, 88, 130, 214);
            this.bar3D1.Color = Color.FromArgb(255, 88, 130, 214);
            this.bar3D1.ColorEach = false;
            this.bar3D1.Marks.Visible = false;
            this.bar3D1.Pen.Color = Color.FromArgb(255, 146, 94, 32);
            this.bar3D1.Pen.Visible = false;
            this.bar3D1.Title = "bar3D1";
            this.bar3D1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // line2
            this.line2.Brush.Color = Color.FromArgb(255, 255, 255, 255);
            this.line2.Color = Color.FromArgb(255, 255, 255, 255);
            this.line2.ColorEach = false;
            this.line2.LinePen.Color = Color.FromArgb(255, 255, 255, 255);
            this.line2.Pointer.Pen.Color = Color.FromArgb(255, 29, 56, 109);
            this.line2.Pointer.SizeDouble = 0D;
            this.line2.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.line2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.line2.Pointer.Visible = true;
            this.line2.Title = "line2";
            this.line2.XValues.DataMember = "X";
            this.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.line2.YValues.DataMember = "Y";
            // 
            // annotation1
            // 
            this.annotation1.AutoSize = true;
            this.annotation1.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.annotation1.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
            this.annotation1.Callout.ArrowHeadSize = 8;
            this.annotation1.Callout.Brush.Color = Color.Black;
            this.annotation1.Callout.Distance = 0;
            this.annotation1.Callout.Draw3D = false;
            this.annotation1.Callout.SizeDouble = 0D;
            this.annotation1.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.annotation1.Callout.XPosition = 0;
            this.annotation1.Callout.YPosition = 0;
            this.annotation1.Callout.ZPosition = 0;
            this.annotation1.Left = 2;
            this.annotation1.Shape.Bottom = 373;
            this.annotation1.Shape.CustomPosition = true;
            this.annotation1.Shape.Font.Brush.Color = Color.FromArgb(255, 255, 255, 255);
            this.annotation1.Shape.Font.Size = 40;
            this.annotation1.Shape.Font.SizeFloat = 40F;
            this.annotation1.Shape.Left = 2;
            this.annotation1.Shape.Lines = new string[] { "40%" };
            this.annotation1.Shape.Right = 207;
            this.annotation1.Shape.Top = 25;
            this.annotation1.Shape.Transparent = true;
            this.annotation1.Text = "40%";
            this.annotation1.Top = 70;
            // 
            // annotation2
            // 
            this.annotation2.AutoSize = true;
            this.annotation2.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.annotation2.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
            this.annotation2.Callout.ArrowHeadSize = 8;
            this.annotation2.Callout.Brush.Color = Color.Black;
            this.annotation2.Callout.Distance = 0;
            this.annotation2.Callout.Draw3D = false;
            this.annotation2.Callout.SizeDouble = 0D;
            this.annotation2.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.annotation2.Callout.XPosition = 0;
            this.annotation2.Callout.YPosition = 0;
            this.annotation2.Callout.ZPosition = 0;
            this.annotation2.Left = 0;
            this.annotation2.Shape.Bottom = 280;
            this.annotation2.Shape.CustomPosition = true;
            this.annotation2.Shape.Font.Brush.Color = Color.FromArgb(255, 128, 128, 255);
            this.annotation2.Shape.Font.Size = 9;
            this.annotation2.Shape.Font.SizeFloat = 9F;
            this.annotation2.Shape.Left = 6;
            this.annotation2.Shape.Lines = new string[] {
        "Percentage",
        "sample data"};
            this.annotation2.Shape.Right = 166;
            this.annotation2.Shape.Top = 243;
            this.annotation2.Shape.Transparent = true;
            this.annotation2.Text = "Sample\r\ndata";
            this.annotation2.Top = 120;

            Chart1.Axes.Left.SetMinMax(-20, 33);
            Chart1.Axes.Bottom.SetMinMax(-1, 16);

            bar3D1.Add(0, 26, -11);
            bar3D1.Add(1, 19, -5);
            bar3D1.Add(2, 18.5, -3);
            bar3D1.Add(3, 19, -1);
            bar3D1.Add(4, 17.5, -0.5, "5 jaar");
            bar3D1.Add(5, 15, 2);
            bar3D1.Add(6, 15, 1);
            bar3D1.Add(7, 15, 0.5);
            bar3D1.Add(8, 14.5, 0.5);
            bar3D1.Add(9, 13, 1, "10 jaar");
            bar3D1.Add(10, 12.5, 1.5);
            bar3D1.Add(11, 12.2, 1.5);
            bar3D1.Add(12, 9, 2.2);
            bar3D1.Add(13, 9, 3);
            bar3D1.Add(14, 7, 3.3, "15 jaar");

            double[] xses = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            double[] firstLine = { 31, 23, 22, 22.5, 20.5, 19, 18, 17, 16.5, 15.5, 14.9, 13.9, 13, 13.5, 13.2 };
            double[] secondLine = { -19.5, -13, -8, -3, -2, -0.5, -0.6, -1.5, -1, 0, 0.4, 0.2, 1.7, 2.2, 2.7 };

            line1.Add(xses, firstLine);
            line2.Add(xses, secondLine);
        }

        void Chart1_GetAxisLabel(object sender, GetAxisLabelEventArgs e)
        {
            if (sender == Chart1.Axes.Left)
            {
                e.LabelText = e.LabelText + "%";
            }
        }

        private void chart_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
        {

            for (int i = 0; i < bar3D1.Count; i++)
            {
                double left = bar3D1.CalcXPos(i); // -(bar3D1.BarBounds.Width / 2);
                double right = bar3D1.CalcXPos(i) + (bar3D1.BarBounds.Width / 2);

                double top = Chart1.Axes.Left.CalcPosValue(0);
                double bottom = Chart1.Axes.Left.CalcPosValue(bar3D1.ValuesLists[2][i]);

                if (bottom > top)
                {
                    Rectangle r = new Rectangle(Steema.TeeChart.Utils.Round(left), Steema.TeeChart.Utils.Round(top),
                                                Steema.TeeChart.Utils.Round(bar3D1.BarBounds.Width), Steema.TeeChart.Utils.Round(bottom - top));

                    g.Brush.Color = Color.FromArgb(255, 164, 189, 255);
                    g.Pen.Visible = false;

                    g.Rectangle(r);
                }
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}