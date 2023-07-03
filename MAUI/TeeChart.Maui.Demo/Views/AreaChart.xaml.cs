using Microsoft.Maui;
using Steema.TeeChart.Maui;
using Steema.TeeChart.Styles;

namespace TeeChartMockUpDemos
{
    public partial class AreaChart : ContentPage
    {
        public AreaChart()
        {
            InitializeComponent();

            var area = new Area(tChart1.Chart);
            view3D.CheckedChanged += View3D_CheckedChanged;

            area.FillSampleValues();
            var c = new System.Drawing.Color();
            c = System.Drawing.Color.Blue;
            area.Color = c;
        }

        private void View3D_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            tChart1.Chart.Aspect.View3D = e.Value;
            InvalidateMeasure();
        }

    }
}
