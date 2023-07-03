using Microsoft.Maui;
using Steema.TeeChart.Maui;
using Steema.TeeChart.Styles;

namespace TeeChartMockUpDemos
{
    public partial class BarChart : ContentPage
    {
        public BarChart()
        {
            InitializeComponent();
            view3D.CheckedChanged += View3D_CheckedChanged;
            var bar = new Bar(tChart1.Chart);
            bar.Add(10000000);
            tChart1.Chart.Panning.Active = false;
            tChart1.Chart.Zoom.Active = true;
        }

        private void View3D_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            tChart1.Chart.Aspect.View3D = e.Value;
            InvalidateMeasure();
        }

    }
}
