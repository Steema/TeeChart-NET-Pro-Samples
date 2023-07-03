using Microsoft.Maui;
using Steema.TeeChart.Maui;
using Steema.TeeChart.Styles;

namespace TeeChartMockUpDemos
{
    public partial class BubbleChart : ContentPage
    {
        public BubbleChart()
        {
            InitializeComponent();
            view3D.CheckedChanged += View3D_CheckedChanged;
            var bubble = new Bubble(tChart1.Chart);
            bubble.FillSampleValues();
        }

        private void View3D_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            tChart1.Chart.Aspect.View3D = e.Value;
            InvalidateMeasure();
        }

    }
}
