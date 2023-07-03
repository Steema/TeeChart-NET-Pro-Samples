using Microsoft.Maui;
using Steema.TeeChart.Maui;
using Steema.TeeChart.Styles;

namespace TeeChartMockUpDemos
{
    public partial class PointsChart : ContentPage
    {
        Points points;
        public PointsChart()
        {
            InitializeComponent();
            
            view3D.CheckedChanged += View3D_CheckedChanged;
            
            points = new Points(tChart1.Chart);
            points.FillSampleValues();
            tChart1.Chart.Panning.Active = true;            
        }

        private void View3D_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            tChart1.Chart.Aspect.View3D = e.Value;
            InvalidateMeasure();
        }
    }
}
