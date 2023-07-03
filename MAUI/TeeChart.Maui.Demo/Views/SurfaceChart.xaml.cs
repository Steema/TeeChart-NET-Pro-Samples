using Microsoft.Maui;
using Steema.TeeChart.Maui;
using Steema.TeeChart.Styles;

namespace TeeChartMockUpDemos
{
    public partial class SurfaceChart : ContentPage
    {
        public SurfaceChart()
        {
            InitializeComponent();
            view3D.CheckedChanged += View3D_CheckedChanged;
            var surface = new Surface(tChart1.Chart);
            surface.FillSampleValues();
        }

        private void View3D_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            tChart1.Chart.Aspect.View3D = e.Value;
            InvalidateMeasure();
        }

    }
}
