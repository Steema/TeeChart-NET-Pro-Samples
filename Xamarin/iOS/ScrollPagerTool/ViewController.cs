using System;

using UIKit;
using Steema.TeeChart;
using Steema.TeeChart.Styles;
using Steema.TeeChart.Tools;
using Steema.TeeChart.Themes;
using System.Drawing;

namespace ScrollPagerTool
{
    public partial class ViewController : UIViewController
    {
        TChart tChart1 = new TChart();
        FastLine series;
        private ScrollPager tool;
        private ColorLine colorlinetool;
        NearestPoint point;
        Annotation annotate;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            InitializeChart();
        }

        private void InitializeChart()
        {
            tChart1.Frame = this.View.Frame;

            tChart1.Header.Text = "Scroll Pager Tool";
            tChart1.Panning.Active = true;
            tChart1.Series.Add(series = new FastLine());
            series.FillSampleValues(1000);

            tChart1.Tools.Add(tool = new ScrollPager());
            
            for (int i = 0; i < tChart1.Series.Count; i++)
            {
                if (tChart1.Series[i].Count > 0)
                    tool.Series = tChart1.Series[i];
            }
            
            tool.ColorBandTool.StartLine.AllowDrag = true;
            tool.ColorBandTool.EndLine.AllowDrag = true;
            tool.ColorBandTool.StartLine.Active = true;
            tool.ColorBandTool.EndLine.Active = true;


            tChart1.Tools.Add(colorlinetool = new ColorLine());
            colorlinetool.Value = 100;
            colorlinetool.AllowDrag = true;
            colorlinetool.Pen.Color = Color.Blue;

            tChart1.ClickBackground += TChart1_ClickBackground;

            tChart1.Tools.Add(point = new NearestPoint());
            tChart1.Tools.Add(annotate = new Annotation());

            point.Brush.Color = tool.PointerHighlightColor;
            point.DrawLine = false;
            point.Size = 6;
            point.Direction = NearestPointDirection.Horizontal;
            point.Series = series;
            point.Change += Point_Change;

            annotate.Position = AnnotationPositions.RightTop;
            annotate.Text = "YValue:";
            annotate.Shape.Shadow.Visible = false;
            annotate.Shape.Font.Color = Color.Red;
            annotate.Shape.Color = tool.PointerHighlightColor;
            annotate.Shape.Font.Size = 15;
            annotate.Shape.Pen.Visible = false;
            annotate.Shape.Transparent = true;
            annotate.TextAlign = CoreText.CTTextAlignment.Center;

            tChart1.Panel.Gradient.Visible = false;
            
            this.View.AddSubview(tChart1);
        }

        private void Point_Change(object sender, EventArgs e)
        {
            if (point.Point > -1)
            {
                annotate.Text = "YValue: " + series.YValues[point.Point];
            }
        }

        private void TChart1_ClickBackground(object sender, Foundation.NSSet e)
        {
            var touch = Utils.GetMouseButton(e);
            var locInView = touch.LocationInView(touch.View);
            Point P = new Point((int)locInView.X, (int)locInView.Y);

            int x = P.X;
            int y = P.Y;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}