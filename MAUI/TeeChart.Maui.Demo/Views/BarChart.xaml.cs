using Microsoft.Maui;
using Microsoft.Maui.Controls.Shapes;
using Steema.TeeChart.Maui;
using Steema.TeeChart.Styles;

namespace TeeChartMockUpDemos
{
    public partial class BarChart : ContentPage
    {
        public BarChart()
        {
            InitializeComponent();
            view3D.CheckedChanged += View3D_CheckedChanged;
            var bar = new Bar(tChart1.Chart);
            //bar.Add(10000000);
            bar.FillSampleValues(10);

            var bar2 = new Bar(tChart1.Chart);
            //bar.Add(10000000);
            bar2.FillSampleValues(10);
            tChart1.Chart.Panning.Active = false;
            tChart1.Chart.Zoom.Active = true;

            bar2.Gradient.Visible = true;
            bar2.BarStyle = BarStyles.RectGradient;
        }

        private void View3D_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            tChart1.Chart.Aspect.View3D = e.Value;
            InvalidateMeasure();
        }

    }
}
