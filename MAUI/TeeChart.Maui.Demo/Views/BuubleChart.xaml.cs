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
            var bubble = new Bubble(tChart1.Chart);
            bubble.FillSampleValues();
        }
    }
}
