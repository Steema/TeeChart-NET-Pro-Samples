using Microsoft.Maui;
using Steema.TeeChart.Maui;
using Steema.TeeChart.Styles;

namespace TeeChartMockUpDemos
{
    public partial class CircularGaugeChart : ContentPage
    {
        public CircularGaugeChart()
        {
            InitializeComponent();
            var circularGauge = new CircularGauge(tChart1.Chart);            
            circularGauge.FillSampleValues(10);
            circularGauge.Value = 35;
            tChart1.Chart.Panning.Active = false;
            tChart1.Chart.Zoom.Active = true;
            tChart1.Chart.Header.Visible = false;            
        }
    }
}
