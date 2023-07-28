using Microsoft.Maui;
using Steema.TeeChart.Maui;
using Steema.TeeChart.Styles;

namespace TeeChartMockUpDemos
{
    public partial class MapChart : ContentPage
    {
        public MapChart()
        {
            InitializeComponent();
            var map = new World(tChart1.Chart);
            map.Map = WorldMapType.World;
            map.FillSampleValues();
            map.Pen.Visible = false;
            
            tChart1.Chart.Panning.Active = false;
            tChart1.Chart.Zoom.Active = true;
            tChart1.Chart.Axes.Left.Increment = 50;
        }
    }
}
