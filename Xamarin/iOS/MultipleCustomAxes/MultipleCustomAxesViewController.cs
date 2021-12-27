using UIKit;
using System.Drawing;
using System;
using Foundation;
using Steema.TeeChart;
using Steema.TeeChart.Styles;

namespace MultipleCustomAxes
{
	public partial class MultipleCustomAxesViewController : UIViewController
	{
		// TChart defiition
		TChart Chart1;
		
		public MultipleCustomAxesViewController (string nibName, NSBundle bundle) : base (nibName, bundle)
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			//any additional setup after loading the view, typically from a nib.
			
			Chart1 = new TChart();
            Chart1.Frame = this.View.Frame;
			
			Chart1.Aspect.ZoomScrollStyle=Steema.TeeChart.Drawing.Aspect.ZoomScrollStyles.Manual;
			this.ApplyCustomAxes();
			
			this.View.AddSubview(Chart1);
		}
				
		private void ApplyCustomAxes()
		{
			Line line1 = new Line();
			Line line2 = new Line();
			Chart1.Aspect.View3D = false;
			Chart1.Panel.Gradient.Visible = true;
			Chart1.Header.Text = "TeeChart Multiple Axes";
			Chart1.Walls.Back.Transparent=true;
			Chart1.Series.Add(line1);
			Chart1.Series.Add(line2);
			
			for(int t = 0; t<=10; ++t) {
				line1.Add(Convert.ToDouble(t),Convert.ToDouble(10+t),Color.Red);
				line2.Add(Convert.ToDouble(2+t),Convert.ToDouble(t),Color.Green);				
			}
			
			Axis leftAxis = Chart1.Axes.Left;
			
			leftAxis.Grid.DrawEvery=2;
			leftAxis.StartPosition=0;
			leftAxis.EndPosition=50;
			leftAxis.AxisPen.Color=Color.Red;
			
			Axis axis1 = new Axis(false, false,Chart1.Chart);
			
			Chart1.Axes.Custom.Add(axis1);
			line2.CustomVertAxis=axis1;
			
			axis1.StartPosition=50;
			axis1.EndPosition=100;
			axis1.AxisPen.Color=Color.Green;
			axis1.PositionUnits=PositionUnits.Percent;
			axis1.RelativePosition=20;		
			axis1.Grid.DrawEvery=2;
		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Release any retained subviews of the main view.
			// e.g. myOutlet = null;
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return false;
		}
	}
}
