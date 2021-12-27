using System;

using UIKit;
using Steema.TeeChart;
using System.Drawing;

namespace DashBoard
{
    public partial class ViewController : UIViewController
    {
        TChart chart1;
        TChart chart2;
        TChart chart3;
        TChart chart4;
        UIImageView imageview;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            chart1 = new TChart();
            chart2 = new TChart();
            chart3 = new TChart();
            chart4 = new TChart();

            CoreGraphics.CGRect r1 = this.View.Frame;
            r1.Height = r1.Height / 4;
            r1.Y = (r1.Height * 3) - 85;
            chart1.Frame = r1;

            CoreGraphics.CGRect r4 = this.View.Frame;
            r4.Height = r4.Height / 4;
            r4.Y = (r4.Height * 2) - 85;
            chart4.Frame = r4;

            CoreGraphics.CGRect r2 = this.View.Frame;
            r2.Height = r2.Height / 2;
            r2.Width = r2.Width / 2  + 40;
            r2.Y = -25;
            r2.X = -25;
            chart2.Frame = r2;

            CoreGraphics.CGRect r3 = this.View.Frame;
            r3.Height = r3.Height / 2;
            r3.Width = r3.Width / 2 + 40;
            r3.X = r3.Width-55;
            r3.Y = -25;
            chart3.Frame = r3;

            chart1.Series.Add(new Steema.TeeChart.Styles.Volume());
            chart1.Series[0].FillSampleValues();
            chart1.Aspect.View3D = false;
            chart1.Axes.Bottom.Grid.Visible = false;
            chart1.Legend.Visible = false;
            chart1.Axes.Left.Visible = false;


            for (int i = 0; i < 3; i++)
            {
                chart4.Series.Add(new Steema.TeeChart.Styles.Line());
                chart4.Series[i].FillSampleValues(20);
                chart4.Series[i].Marks.Visible = false;
                (chart4.Series[i] as Steema.TeeChart.Styles.Line).LinePen.Width = 3;
            }

            chart4.Aspect.View3D = false;            
            chart4.Axes.Bottom.Increment = 3;

            Steema.TeeChart.Styles.CircularGauge gauge1 = new Steema.TeeChart.Styles.CircularGauge();
            Steema.TeeChart.Styles.CircularGauge gauge2 = new Steema.TeeChart.Styles.CircularGauge();

            chart2.Series.Add(gauge1);
            chart3.Series.Add(gauge2);

            chart2.Panel.MarginTop = 0;
            chart2.Panel.MarginBottom = 0;
            chart2.Panel.MarginLeft = 0;
            chart2.Panel.MarginRight = 0;

            chart3.Panel.MarginTop = 0;
            chart3.Panel.MarginBottom = 0;
            chart3.Panel.MarginLeft = 0;
            chart3.Panel.MarginRight = 0;

            this.View.AddSubview(chart1);
            this.View.AddSubview(chart2);
            this.View.AddSubview(chart3);
            this.View.AddSubview(chart4);

            chart3.Axes.Left.Labels.Font.Size = 5;
            chart2.Axes.Left.Labels.Font.Size = 5;

            gauge1.Frame.Width = 15;
            gauge1.Ticks.VertSize = 3;
            gauge1.Center.Shadow.Visible = false;
            gauge1.Axis.AxisPen.Visible = false;
            gauge1.FaceBrush.Gradient.Visible = false;
            gauge1.FaceBrush.Color = Color.FromArgb(220, 220, 220);
            gauge1.Hand.Color = Color.FromArgb(255, 65, 56);
            gauge1.Hand.Gradient.Visible = false;
            gauge1.Hand.Shadow.Visible = false;
            gauge1.Axis.AxisPen.Visible = false;            
            gauge1.Value = 75;
            gauge1.Ticks.VertSize = 3;

            gauge2.Frame.Width = 15;
            gauge2.Ticks.VertSize = 3;
            gauge2.Axis.AxisPen.Visible = false;
            gauge2.Center.Shadow.Visible = false;
            gauge2.FaceBrush.Gradient.Visible = false;
            gauge2.FaceBrush.Color = Color.FromArgb(220, 220, 220);
            gauge2.Hand.Color = Color.FromArgb(255, 65, 56);
            gauge2.Hand.Gradient.Visible = false;
            gauge2.Hand.Shadow.Visible = false;
            gauge2.Axis.AxisPen.Visible = false;
            gauge2.Value = 50;
            gauge2.Ticks.VertSize = 3;


            chart1.Header.Visible = false;
            chart2.Header.Visible = false;
            chart3.Header.Visible = false;
            chart4.Header.Visible = false;

            chart1.Panel.Gradient.Visible = false;
            chart1.Panel.Color = Color.Black;
            chart1.Walls.Back.Transparent = true;
            chart1.Legend.Visible = false;
            chart1.Axes.Bottom.Labels.Font.Color = Color.FromArgb(220, 220, 220);

            chart4.Panel.Gradient.Visible = false;
            chart4.Panel.Color = Color.Black;
            chart4.Walls.Back.Transparent = true;
            chart4.Legend.Visible = false;
            chart4.Axes.Left.Visible = false;
            chart4.Axes.Bottom.Labels.Font.Color = Color.FromArgb(220, 220, 220);

            chart2.Panel.Gradient.Visible = false;
            chart2.Panel.Color = Color.Black;

            chart3.Panel.Gradient.Visible = false;
            chart3.Panel.Color = Color.Black;

            chart2.Panel.MarginTop = 0;
            chart2.Panel.MarginLeft = 0;
            chart2.Panel.MarginBottom = 0;
            chart2.Panel.MarginRight = 0;

            chart3.Panel.MarginTop = 0;
            chart3.Panel.MarginLeft = 0;
            chart3.Panel.MarginBottom = 0;
            chart3.Panel.MarginRight = 0;

            this.View.BackgroundColor = UIColor.Black;

            imageview = new UIImageView(UIImage.FromBundle("logo.png"));
            
            CoreGraphics.CGRect rimage = new CoreGraphics.CGRect((this.View.Frame.Width/2)-69, this.View.Frame.Height - 76, 138,70);
            imageview.Frame = rimage;

            this.View.AddSubview(imageview);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}