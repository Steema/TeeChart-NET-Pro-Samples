using System;

using UIKit;
using Steema.TeeChart;
using Steema.TeeChart.Styles;
using System.Drawing;

namespace SubChartTool
{
    public partial class ViewController : UIViewController
    {
        TChart tChart1 = new TChart();
        private Line line1;
        private Line line2;
        private Steema.TeeChart.Tools.SubChartTool subChartTool1;

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
            TChart subchart1;
            TChart subchart2;
            tChart1.Frame = this.View.Frame;

            tChart1.Series.Add(line1 = new Line());
            tChart1.Series.Add(line2 = new Line());
            line1.FillSampleValues();
            line2.FillSampleValues();

            tChart1.Axes.Bottom.Grid.Visible = false;
            tChart1.Aspect.View3D = false;

            tChart1.Tools.Add(subChartTool1 = new Steema.TeeChart.Tools.SubChartTool());

            tChart1.Panning.Active = true;

            subchart1 = subChartTool1.Charts.AddChart("Chart0");
            subchart1.Panel.Color = Color.Transparent;
            subchart1.Series.Add(new Bar());
            subchart1.Aspect.View3D = false;
            subchart1.Series[0].FillSampleValues();
            subchart1.Series[0].ColorEach = true;
            (subchart1.Series[0] as Bar).Pen.Visible = false;
            subchart1[0].Marks.Visible = false;
            subchart1[0].Chart.Title.Visible = false;
            subchart1[0].Chart.Walls.Back.Transparent = true;
            subchart1[0].Chart.Panel.Transparent = true;
            subchart1[0].Chart.Axes.Left.Grid.Visible = false;

            subChartTool1.Charts[0].Chart.Walls.Visible = false;

            for (int j = 0; j < subChartTool1.Charts.Count; j++)
            {
                subchart1 = subChartTool1.Charts[j].Chart;
                for (int i = 0; i < line1.Count; i++)
                {
                    subchart1[0].Add(line1.XValues[i], line1.YValues[i]);
                }
            }

            tChart1.Axes.Left.Increment = line1.YValues.Maximum / 5;
            tChart1.Walls.Visible = false;
            tChart1.Legend.Alignment = LegendAlignments.Bottom;
            tChart1.Legend.Transparent = true;
            tChart1.Chart.Title.Text = "Chart with a SubChart Tool";
            tChart1.Chart.Title.Font.Color = Color.Gray;
            tChart1.Chart.Axes.Left.MinimumOffset = 200;         

            subChartTool1.Charts[0].Left = 50;
            subChartTool1.Charts[0].Top = 390;
            subChartTool1.Charts[0].Width = 325;

            this.View.AddSubview(tChart1);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}