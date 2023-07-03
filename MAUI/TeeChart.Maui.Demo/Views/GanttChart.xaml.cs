using Microsoft.Maui;
using Steema.TeeChart.Maui;
using Steema.TeeChart.Styles;

namespace TeeChartMockUpDemos
{
    public partial class GanttChart : ContentPage
    {
        public GanttChart()
        {
            InitializeComponent();
            view3D.CheckedChanged += View3D_CheckedChanged;
            var gantt = new Gantt(tChart1.Chart);
            gantt.FillSampleValues();
        }

        private void View3D_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            tChart1.Chart.Aspect.View3D = e.Value;
            InvalidateMeasure();
        }

    }
}
