using System;

using UIKit;
using Steema.TeeChart;
using Steema.TeeChart.Styles;
using System.Drawing;

namespace ColorLineTool
{
    public partial class ViewController : UIViewController
    {
        TChart tChart1 = new TChart();
        private Line line1;
        private Line line2;
        private Steema.TeeChart.Tools.ColorLine colorlinetTool;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            tChart1.Frame = this.View.Frame;

            tChart1.Series.Add(line1 = new Line());
            tChart1.Series.Add(line2 = new Line());
            line1.FillSampleValues();
            line2.FillSampleValues();

            tChart1.Axes.Bottom.Grid.Visible = false;
            tChart1.Aspect.View3D = false;

            tChart1.Tools.Add(colorlinetTool = new Steema.TeeChart.Tools.ColorLine());
            colorlinetTool.Axis = tChart1.Axes.Bottom;
            colorlinetTool.Value = 10;
            colorlinetTool.Pen.Color = Color.Red;
            colorlinetTool.Pen.Width = 2;
            colorlinetTool.ColorLineClickTolerance = 10;
            colorlinetTool.AllowDrag = true;
			colorlinetTool.DragRepaint = true;

            tChart1.Panning.Active = true;
            tChart1.Panning.Allow = ScrollModes.Both;
            tChart1.Zoom.Active = true;

            tChart1.Axes.Left.Increment = line1.YValues.Maximum / 5;
            tChart1.Walls.Visible = false;
            tChart1.Legend.Alignment = LegendAlignments.Bottom;
            tChart1.Legend.Transparent = true;
            tChart1.Chart.Title.Text = "Chart with a ColorLine Tool";
            tChart1.Chart.Title.Font.Color = Color.Gray;

            this.View.AddSubview(tChart1);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}