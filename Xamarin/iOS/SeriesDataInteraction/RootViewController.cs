using System;
using System.Drawing;

using Foundation;
using UIKit;
using Steema.TeeChart;
using Steema.TeeChart.Tools;
using CoreText;
using System.Threading.Tasks;

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
        Annotation annotation;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Creating the Chart component
            Chart = new TChart();

            // Setting the Chart bounds
            Chart.Frame = View.Frame;

            // 2D Chart
            Chart.Aspect.View3D = false;

            // Chart appearance
            Chart.Header.Font.Color = Color.White;
            Chart.Header.Font.Size = 16;
            Chart.Header.Text = "CALORIES";
            Chart.Header.Font.Name = "Verdana";
            Chart.SubHeader.Text = "Today's Summary";
            Chart.SubHeader.Visible = true;
            Chart.SubHeader.Font.Bold = true;
            Chart.SubHeader.Font.Name = "Verdana";
            Chart.Header.Font.Size = 12;
            Chart.SubHeader.Font.Color = Color.FromArgb(255, 78, 191, 185);
            Chart.SubFooter.Visible = true;
            Chart.SubFooter.Font.Name = "Verdana";
            Chart.SubFooter.Text = "TeeChart for Xamarin.Forms";
            Chart.SubFooter.Font.Color = Color.FromArgb(255, 78, 191, 185);
            Chart.Header.Font.Size = 12;

            Chart.Panel.Gradient.StartColor = Color.FromArgb(255, 17, 151, 140);
            Chart.Panel.Gradient.EndColor = Color.FromArgb(255, 11, 93, 143);
            Chart.Panel.Gradient.UseMiddle = false;
            Chart.Panel.Gradient.Visible = true;

            Chart.Panel.Pen.Visible = true;
            Chart.Panel.Pen.Color = Color.FromArgb(255, 20, 58, 69);
            Chart.Panel.Color = Color.FromArgb(255, 11, 93, 143);

            // Customizing the Axes grid appearance
            Chart.Axes.Bottom.Grid.Visible = false;
            Chart.Axes.Bottom.MinorTicks.Visible = false;
            
            // Setting a custom left axis increment, and axis pen width, and other properties
            Chart.Axes.Left.AxisPen.Width = 1;
            Chart.Axes.Bottom.AxisPen.Width = 1;
            Chart.Axes.Bottom.AxisPen.Color = Color.FromArgb(255, 51, 138, 166);
            Chart.Axes.Left.MaximumOffset = 12;
            Chart.Axes.Left.AxisPen.Visible = false;
            Chart.Axes.Left.Grid.Color = Color.FromArgb(255, 51, 138, 166);

            Chart.Axes.Right.AxisPen.Visible = false;
            Chart.Axes.Right.Grid.Color = Color.FromArgb(255, 51, 138, 166);
            Chart.Axes.Right.Labels.Font.Color = Color.FromArgb(255, 78, 191, 185);
            Chart.Axes.Right.Labels.Font.Size = 12;
            Chart.Axes.Right.MinorTicks.Visible = false;
            Chart.Axes.Right.Ticks.Visible = false;
            Chart.Axes.Right.GridCentered = true;
            Chart.Axes.Right.Ticks.Length = -150;
            Chart.Axes.Right.Ticks.Visible = true;
            Chart.Axes.Right.RelativePosition = 10;           

            Chart.Axes.Left.Labels.Visible = false;
            Chart.Axes.Bottom.Labels.Font.Color = Color.FromArgb(255, 51, 138, 166);
            Chart.Axes.Bottom.Labels.Font.Size = 12;

            // Chaging the Legend, Panel and Walls appearance
            Chart.Legend.Transparent = true;
            Chart.Legend.Font.Color = Color.White;
            Chart.Legend.Font.Size = 16;
            Chart.Legend.Alignment = LegendAlignments.Bottom;
            Chart.Legend.LegendStyle = LegendStyles.Series;
            
            Chart.Walls.Back.Visible = false;
            
            Chart.Panel.BorderPen.Width = 3;
            Chart.Panel.BorderRound = 32;
            Chart.Panel.Bevel.Width = 2;
            Chart.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            Chart.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            Chart.Panel.Bevel.ColorOne = Color.FromArgb(255, 20, 58, 69);
            Chart.Panel.Bevel.ColorTwo = Color.FromArgb(255, 20, 58, 69);

            // Allow to Zoom and Pan over the Chart Series
            Chart.Panning.Active = true;
            Chart.Zoom.Active = true;

            // Creating the Chart Series (FastLine series in that case)
            Steema.TeeChart.Styles.Area fline1 = new Steema.TeeChart.Styles.Area(Chart.Chart);

            fline1.AreaBrush.Gradient.Visible = true;
            fline1.AreaBrush.Gradient.StartColor = Color.FromArgb(255, 78, 191, 185);
            fline1.LinePen.Color = Color.FromArgb(255, 197, 248, 229);
            fline1.AreaBrush.Gradient.EndColor = Color.Transparent;
            fline1.AreaLinesPen.Color = Color.FromArgb(255, 197, 248, 229);
            fline1.AreaLinesPen.Width = 3;
            fline1.AreaLines.Visible = false;
            fline1.Title = "Today";

            var tmpHour = Utils.GetDateTimeStep(DateTimeSteps.OneHour);

            // Adding data to the Series
            fline1.Add(DateTime.Now.ToOADate(), 350, "350");
            fline1.Add(DateTime.Now.ToOADate() + tmpHour, 500, "500");
            fline1.Add(DateTime.Now.ToOADate() + tmpHour*2, 400, "400");
            fline1.Add(DateTime.Now.ToOADate() + tmpHour * 3, 475, "475");
            fline1.Add(DateTime.Now.ToOADate() + tmpHour * 4, 300, "300");
            fline1.Add(DateTime.Now.ToOADate() + tmpHour * 5, 222, "222");
            fline1.Add(DateTime.Now.ToOADate() + tmpHour * 6, 280, "280");

            fline1.Smoothed = true;            
            fline1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right;

            fline1.XValues.DateTime = true;
            Chart.Axes.Bottom.Labels.DateTimeFormat = "HH:mm tt";
            Chart.Axes.Bottom.Increment = Steema.TeeChart.Utils.GetDateTimeStep( DateTimeSteps.OneHour );
            Chart.Axes.Right.MinimumOffset = 10;

            // Add a click Tolerance in pixels
            fline1.ClickTolerance = 3;            

            // Hiding Series Marks
            fline1.Marks.Visible = false;
            fline1.LinePen.Width = 4;

            // Setting custom left axis increment
            Chart.Axes.Right.Increment = 100;
            Chart.Axes.Right.Automatic = true;

            Chart.Panning.Allow = ScrollModes.Horizontal;

            // Scroll by points per page....    
            // Chart.Page.MaxPointsPerPage = 10;

            // Scroll by using UISlider and SetMinMax
            //Chart.Panel.MarginBottom += 10;
            //Chart.Axes.Bottom.SetMinMax(0, 10);

            /* Using Slider to scroll 
            UISlider slider1 = new UISlider(new CoreGraphics.CGRect(0,this.View.Frame.Height - 25,this.View.Frame.Width, 20));
            slider1.MinValue = 5;
            slider1.MaxValue = 95;
            slider1.Value = 5.0f; // the current value
            slider1.ValueChanged += (sender, e) => Chart.Axes.Bottom.SetMinMax(((UISlider)sender).Value - 5, ((UISlider)sender).Value + 5);            
            */

            // Use of Annotation Tool            
            annotation = new Annotation(Chart.Chart);
            annotation.Active = false;
            annotation.Shape.Font.Size = 14;
            //annotation.Shape.Font.Bold = true;

            annotation.Shape.Pen.Color = Color.White;
            annotation.Shape.Pen.Width = 3;
            annotation.TextAlign = CTTextAlignment.Center;
            annotation.Position = AnnotationPositions.Center;

            // Chart and Series events
            Chart.ClickBackground += Chart_ClickBackground;
            Chart.ClickSeries += Chart_ClickSeries;
            Chart.ClickLegend += Chart_ClickLegend;
            Chart.AfterDraw += Chart_AfterDraw1;
            Chart.ClickAxis += Chart_ClickAxis; 
            Chart.ClickTitle += Chart_ClickTitle;
            Chart.GetLegendText += Chart_GetLegendText;


            Chart.Draw();


            // Finally adding the Chart View as SubView to the parent View
            View.AddSubview(Chart);

            // In the case we want to add an slider
            //View.AddSubview(slider1);
        }

        private void Chart_GetLegendText(object sender, GetLegendTextEventArgs e)
        {
            e.Text = "Today 2247 cal";  // it could be done progrmatically
        }

        private void Chart_ClickTitle(object sender, NSSet e)
        {
            Chart.Header.Text = "Title clicked! ";
        }

        private void Chart_ClickAxis(object sender, NSSet e)
        {
            Chart.Header.Text = "Axis clicked! ";
        }

        private void Chart_ClickLegend(object sender, NSSet e)
        {
            var touch = Utils.GetMouseButton(e);
            var locInView = touch.LocationInView(touch.View);

            Chart.Header.Text = "Legend clicked! ";
        }

        private void Chart_ClickBackground(object sender, NSSet e)
        {
            Chart.Header.Text = "BackGround clicked! ";
        }

        private async void Chart_ClickSeries(object sender, Steema.TeeChart.Styles.Series s, int valueIndex, NSSet e)
        {
            Chart.Header.Text = "Series clicked! ";

            annotation.Active = false;
            
            annotation.Shape.AutoSize = true;
            annotation.Shape.Shadow.Visible = false;

            annotation.Text = "P:" + valueIndex.ToString() + " - V: " + s.ValueMarkText(valueIndex);  // Point . Value
            annotation.Callout.Visible = true;
            annotation.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Sphere;            
            annotation.Shape.ShapeStyle = Steema.TeeChart.Drawing.TextShapeStyle.RoundRectangle;            
            annotation.Callout.Color = Color.FromArgb(255, 17, 164, 216);
            annotation.Callout.Pen.Color = Color.White;
            annotation.Callout.Pen.Width = 2;
            annotation.Callout.VertSize = 4;
            annotation.Callout.HorizSize = 4;
            annotation.Shape.Font.Color = Color.FromArgb(255, 31, 154, 224);
            annotation.ClipText = true;

            var touch = Utils.GetMouseButton(e);
            var locInView = touch.LocationInView(touch.View);

            Point tmpP = new Point(Utils.Round(locInView.X), Utils.Round(locInView.Y));

            annotation.Left = tmpP.X - (annotation.Width / 2);
            annotation.Top = tmpP.Y - 35;
            annotation.Callout.XPosition = tmpP.X;
            annotation.Callout.YPosition = tmpP.Y;
            annotation.Callout.ZPosition = 0;
            annotation.TextAlign = CTTextAlignment.Center;

            annotation.Active = true;

            // In the case we wanto to simulate a ToolTip which appears for one second , we can do :
            await Task.Delay(1000);
            annotation.Active = false;
        }


        private void Chart_AfterDraw1(object sender, Steema.TeeChart.Drawing.Graphics3D g)
        {
            // After Draw
            Chart.Series[0].XValues.DateTime = true;
            Console.WriteLine("After draw fired !");
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
 
 