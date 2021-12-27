using System;
using System.Drawing;

using Foundation;
using UIKit;
using Steema.TeeChart;

namespace Simple_Chart
{
    public partial class RootViewController : UIViewController
    {
        public RootViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        TChart Chart;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Creating the Chart component
            Chart = new TChart();
            // Setting the Chart bounds
            Chart.Frame = View.Frame;

            // 2D Chart
            Chart.Aspect.View3D = false;

            // Customizing the Axes grid appearance
            Chart.Axes.Bottom.Grid.Visible = false;
            Chart.Axes.Bottom.MinorTicks.Visible = false;

            // Setting a custom left axis increment, and axis pen width, and other properties
            Chart.Axes.Left.Increment = 12.5;
            Chart.Axes.Left.AxisPen.Width = 1;
            Chart.Axes.Bottom.AxisPen.Width = 1;
            Chart.Axes.Left.MaximumOffset = 12;
            Chart.Axes.Left.AxisPen.Visible = false;

            // Chaging the Legend, Panel and Walls appearance
            Chart.Legend.Transparent = true;
            Chart.Legend.Alignment = LegendAlignments.Bottom;
            Chart.Walls.Back.Visible = false;
            Chart.Panel.Gradient.Visible = false;            

            // Allow to Zoom and Pan over the Chart Series
            Chart.Panning.Active = true;
            Chart.Zoom.Active = true;

            // Creating the Chart Series (FastLine series in that case)
            Steema.TeeChart.Styles.FastLine fline1 = new Steema.TeeChart.Styles.FastLine(Chart.Chart);
            Steema.TeeChart.Styles.FastLine fline2 = new Steema.TeeChart.Styles.FastLine(Chart.Chart);

            // Customizing the Series 
            fline1.Color = Color.FromArgb(255, 156, 73, 181);
            fline1.Color = Color.FromArgb(255, 107,38,131);

            // Adding data to the Series
            fline1.FillSampleValues(100);
            fline2.FillSampleValues(100);

            // Hiding Series Marks
            fline1.Marks.Visible = false;
            fline2.Marks.Visible = false;
            fline1.LinePen.Width = 2;
            fline2.LinePen.Width = 2;

            // Left axis title mods
            Chart.Axes.Left.Title.Text = "This is a title";
            Chart.Axes.Left.Title.Angle = 90;
            Chart.Axes.Left.Title.Visible = true;

            // Setting custom size for left axis labels
            Chart.Axes.Left.Labels.AutoSize = false;
            Chart.Axes.Left.Labels.CustomSize = 50;

            // Setting custom left axis increment
            Chart.Axes.Left.Increment = fline1.YValues.Maximum / 5;

            Chart.Panning.Allow = ScrollModes.Horizontal;

            // Scroll by points per page....            
            // Chart.Page.MaxPointsPerPage = 10;

            // Scroll by using UISlider and SetMinMax
            Chart.Panel.MarginBottom += 10;
            Chart.Axes.Bottom.SetMinMax(0, 10);
            UISlider slider1 = new UISlider(new CoreGraphics.CGRect(0,this.View.Frame.Height - 25,this.View.Frame.Width, 20));
            slider1.MinValue = 5;
            slider1.MaxValue = 95;
            slider1.Value = 5.0f; // the current value
            slider1.ValueChanged += (sender, e) => Chart.Axes.Bottom.SetMinMax(((UISlider)sender).Value - 5, ((UISlider)sender).Value + 5);
            
            // Finally adding the Chart View as SubView to the parent View
            View.AddSubview(Chart);
            View.AddSubview(slider1);
        }

        private void Chart_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion
    }
}
 
 