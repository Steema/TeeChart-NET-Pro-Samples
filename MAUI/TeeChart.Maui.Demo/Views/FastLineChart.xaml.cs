using Microsoft.Maui;
using Steema.TeeChart.Maui;
using Steema.TeeChart.Styles;

namespace TeeChartMockUpDemos
{
    public partial class FastLineChart : ContentPage
    {
        public FastLineChart()
        {
            InitializeComponent();

            var fastline = new FastLine(tChart1.Chart);
            fastline.FillSampleValues();
        }
    }
}
