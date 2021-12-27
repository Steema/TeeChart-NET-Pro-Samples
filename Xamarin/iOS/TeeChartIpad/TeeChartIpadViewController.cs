using UIKit;
using System.Drawing;
using System;
using Foundation;
using Steema.TeeChart;


namespace TeeChartIpad
{
	public partial class TeeChartIpadViewController : UIViewController
	{
		public TChart chart1= new Steema.TeeChart.TChart();
		public TChart chart2= new Steema.TeeChart.TChart();
		public TChart chart3= new Steema.TeeChart.TChart();
		public TChart chart4= new Steema.TeeChart.TChart();
		
		System.Drawing.RectangleF r1;
		System.Drawing.RectangleF r2;
		System.Drawing.RectangleF r3;
		System.Drawing.RectangleF r4;
		
		
		public TeeChartIpadViewController () : base ("TeeChartIpadViewController", null)
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
			r1 = new System.Drawing.RectangleF(0,0,(float)this.View.Bounds.Width/2,(float)this.View.Bounds.Height/2);						
			r2 = new System.Drawing.RectangleF((float)this.View.Bounds.Width/2,0, (float)this.View.Bounds.Width/2, (float)this.View.Bounds.Height/2);						
			r3 = new System.Drawing.RectangleF(0, (float)this.View.Bounds.Height/2, (float)this.View.Bounds.Width, (float)this.View.Bounds.Height/2);						
					
			chart1.Frame = r1;
			chart2.Frame = r2;
			chart3.Frame = r3;
			
			chart1.Header.Visible = false;
			chart1.Legend.Visible = false;
			chart2.Header.Visible = false;
			chart3.Header.Visible = false;
			
			this.View.AddSubview(chart1);
			this.View.AddSubview(chart2);
			this.View.AddSubview(chart3);
			
			Steema.TeeChart.Themes.BlackIsBackTheme theme1 = new Steema.TeeChart.Themes.BlackIsBackTheme(chart1.Chart);
			Steema.TeeChart.Themes.BlackIsBackTheme theme2 = new Steema.TeeChart.Themes.BlackIsBackTheme(chart2.Chart);
			Steema.TeeChart.Themes.BlackIsBackTheme theme3 = new Steema.TeeChart.Themes.BlackIsBackTheme(chart3.Chart);
			
		
			Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(chart1.Chart,Steema.TeeChart.Themes.Theme.OnBlackPalette);	
			Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(chart2.Chart,Steema.TeeChart.Themes.Theme.OnBlackPalette);	
			Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(chart3.Chart,Steema.TeeChart.Themes.Theme.OnBlackPalette);	
			
			// Chart 1
			chart1.Panel.Gradient.Visible = false;
			chart1.Panel.Color = Color.Black;
			Steema.TeeChart.Styles.Donut series1 = new Steema.TeeChart.Styles.Donut();
			chart1.Aspect.View3D = false;
			series1.FillSampleValues(4);
			series1.Circled = true;
			series1.Pen.Width = 5;
			series1.ExplodeBiggest=20;
			series1.Marks.Transparent = true;
			series1.Marks.Font.Color = Color.FromArgb(144,255,255,255);
			series1.Marks.Font.Size = 20;
			chart1.Series.Add(series1);
			  
			// Chart 2
			
			chart2.Aspect.View3D = false;
			chart2.Chart.Aspect.ZoomScrollStyle = Steema.TeeChart.Drawing.Aspect.ZoomScrollStyles.Manual;						
			chart2.Panel.Gradient.Visible = false;
			chart2.Panel.Color = Color.Black;
			chart2.Walls.Back.Gradient.Visible = true;
			chart2.Walls.Back.Gradient.StartColor = Color.FromArgb(255,0,0,0);
			chart2.Walls.Back.Gradient.EndColor = Color.DarkGray;
			chart2.Axes.Bottom.Grid.Visible = false;
			chart2.Axes.Left.Increment = 15;
			chart2.Axes.Bottom.Labels.Font.Size = 15;
			chart2.Legend.Alignment = LegendAlignments.Bottom;
			chart2.Legend.Transparent = true;
			Steema.TeeChart.Styles.Line series2 = new Steema.TeeChart.Styles.Line();
			series2.Add(15);
			series2.Add(25);
			series2.Add(16);
			series2.Add(30);
			series2.Add(40);
			series2.Add(35);
			series2.Add(25);
			series2.Add(50);
			series2.Pointer.Visible = true;
			series2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
			series2.LinePen.Width = 3;
			series2.Pointer.Pen.Visible = false;
			Steema.TeeChart.Styles.Area series3 = new Steema.TeeChart.Styles.Area();
			series3.Add(10);
			series3.Add(15);
			series3.Add(6);
			series3.Add(15);
			series3.Add(10);
			series3.Add(25);
			series3.Add(20);
			series3.Add(24);
			series3.AreaLinesPen.Visible = true;
			series3.AreaLinesPen.Width=3;
			series3.AreaLinesPen.Color = series3.Color;		
			series3.LinePen.Visible = true;
			series3.LinePen.Width = 5;
			series3.AreaLines.Visible = false;
			series3.AreaBrush.Gradient.Visible = true;
			series3.AreaBrush.Gradient.EndColor = Color.DarkGray;
			chart2.Series.Add(series2);
			chart2.Series.Add(series3);

			// Chart 3
			
			chart3.Aspect.View3D = false;
			chart3.Legend.Visible = false;
			chart3.Chart.Aspect.ZoomScrollStyle = Steema.TeeChart.Drawing.Aspect.ZoomScrollStyles.Manual;									
			chart3.Panel.Gradient.Visible = false;
			chart3.Panel.Color = Color.Black;
			chart3.Walls.Back.Gradient.Visible = true;
			chart3.Walls.Back.Gradient.StartColor = Color.Black;
			chart3.Walls.Back.Gradient.EndColor = Color.FromArgb(255,79,79,79);
			chart3.Axes.Left.Labels.Separation = 100;
			chart3.Axes.Left.Grid.Visible = true;
			chart3.Axes.Left.Grid.Color = Color.FromArgb(255,79,79,79);
			chart3.Axes.Bottom.Grid.Color = Color.FromArgb(255,79,79,79);
			chart3.Axes.Left.AxisPen.Visible = false;
			
			Steema.TeeChart.Styles.Candle candle = new Steema.TeeChart.Styles.Candle();
			Steema.TeeChart.Styles.Volume volume = new Steema.TeeChart.Styles.Volume();
			
			chart3.Series.Add(candle);
			chart3.Series.Add(volume);
			
			candle.FillSampleValues(70);
			candle.Pen.Visible = false;
			
			volume.FillSampleValues(70);
			volume.Color = Color.Yellow;
			
			Steema.TeeChart.Axis axis = chart3.Axes.Left;

			axis.StartPosition = 0;
			axis.EndPosition = 72;
			axis.Labels.Font.Size = 12;
			
			Steema.TeeChart.Axis customAxis = new Steema.TeeChart.Axis(chart3.Chart);
			customAxis.OtherSide = true;
			chart3.Axes.Custom.Add(customAxis);

			customAxis.StartPosition = 74;
			customAxis.EndPosition = 100;
			customAxis.Labels.Font.Color = Color.FromArgb(255,255,255,240);
			customAxis.Labels.Font.Size = 12;
			customAxis.Grid.Visible = false;
			customAxis.AxisPen.Visible = false;
			
			volume.CustomVertAxis = customAxis;
			
			chart3.Legend.Alignment = LegendAlignments.Bottom;
			chart3.Legend.Transparent = true;
			chart3.Legend.Font.Size = 12;
			chart3.Legend.TopLeftPos = 0;
			
			chart3.Axes.Bottom.Labels.Font.Size = 12;

			
			/* Chart 4

			chart4.Aspect.View3D = false;
			chart4.Chart.Aspect.ZoomScrollStyle = Steema.TeeChart.Drawing.Aspect.ZoomScrollStyles.Manual;									
			chart4.Panel.Gradient.Visible = false;
			chart4.Panel.Color = UIColor.Black.CGColor;
			chart4.Walls.Back.Transparent=true;
			Steema.TeeChart.Styles.HorizBar series5 = new Steema.TeeChart.Styles.HorizBar();
			series5.Add(10);
			series5.Add(50);
			series5.Add(30);
			series5.Add(70);
			//series5.BarHeightPercent=100;
			//series5.CustomBarWidth= 80;
			series5.ColorEach = true;
			//series5.Pen.Width = 3;
			//series5.Gradient.Visible = true;
			chart4.Series.Add(series5);
			chart4.Axes.Bottom.Visible = false;
			*/
		}
		
		public override void DidRotate(UIInterfaceOrientation fromInterfaceOrientation) 
		{
			// Refresh Chart rotating the device
			r1 = new System.Drawing.RectangleF(0,0, (float)this.View.Bounds.Width/2, (float)this.View.Bounds.Height/2);						
			r2 = new System.Drawing.RectangleF((float)this.View.Bounds.Width/2,0, (float)this.View.Bounds.Width/2, (float)this.View.Bounds.Height/2);						
			r3 = new System.Drawing.RectangleF(0, (float)this.View.Bounds.Height/2, (float)this.View.Bounds.Width, (float)this.View.Bounds.Height/2);						
					
			chart1.Frame = r1;
			chart2.Frame = r2;
			chart3.Frame = r3;
		}

		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Release any retained subviews of the main view.
			// e.g. this.myOutlet = null;
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations			
			return true;
		}
	}
}
