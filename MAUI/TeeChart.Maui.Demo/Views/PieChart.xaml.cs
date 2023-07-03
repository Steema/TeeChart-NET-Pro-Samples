using Microsoft.Maui;
using Steema.TeeChart.Maui;
using Steema.TeeChart.Styles;

namespace TeeChartMockUpDemos
{
    public partial class PieChart : ContentPage
    {
        public PieChart()
        {
            InitializeComponent();
            view3D.CheckedChanged += View3D_CheckedChanged;
            var pie = new Pie(tChart1.Chart);
            pie.FillSampleValues();
        }

        private void View3D_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            tChart1.Chart.Aspect.View3D = e.Value;
            InvalidateMeasure();
        }

    }
}
