using Microsoft.Maui;
using Steema.TeeChart.Maui;
using Steema.TeeChart.Styles;

namespace TeeChartMockUpDemos
{
    public partial class LineChart : ContentPage
    {
        public LineChart()
        {
            InitializeComponent();
            view3D.CheckedChanged += View3D_CheckedChanged;
            var line = new Line(tChart1.Chart);
            line.FillSampleValues();
            var line2 = new Line(tChart1.Chart);
            line2.FillSampleValues();
            var line3 = new Line(tChart1.Chart);
            line3.FillSampleValues();

            tChart1.Panning.Active = false;
            tChart1.Zoom.Active = true;
        }

        private void View3D_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            tChart1.Chart.Aspect.View3D = e.Value;
        }
    }
}
