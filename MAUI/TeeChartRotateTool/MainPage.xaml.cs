using Steema.TeeChart.Maui;
using Steema.TeeChart.Styles;

namespace TeeChartRotateTool
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            var tower = new Tower(tChart1.Chart);
            tower.FillSampleValues();
            tChart1.Chart.Zoom.Active = false;
            tChart1.Chart.Panning.Active = false;
            var _rotateTool = new Steema.TeeChart.Tools.Rotate();
            _rotateTool.Style = Steema.TeeChart.Tools.RotateStyles.Rotation;
            tChart1.Chart.Tools.Add(_rotateTool);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
