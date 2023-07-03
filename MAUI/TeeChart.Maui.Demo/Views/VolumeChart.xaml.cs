using Microsoft.Maui;
using Steema.TeeChart.Maui;
using Steema.TeeChart.Styles;

namespace TeeChartMockUpDemos
{
    public partial class VolumeChart : ContentPage
    {
        public VolumeChart()
        {
            InitializeComponent();

            var volume = new Volume(tChart1.Chart);
            volume.FillSampleValues();
        }
    }
}
