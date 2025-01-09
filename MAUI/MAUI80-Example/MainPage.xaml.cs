using Steema.TeeChart;
using Steema.TeeChart.Styles;

namespace MAUI80_Example
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        Bar _bar;
        public MainPage()
        {
            InitializeComponent();

            _bar = new Bar();
            tChart1.Chart.Series.Add(_bar);
            _bar.FillSampleValues(5);
            _bar.ColorEach = true;
           
            tChart1.Zoom.Active = false;
            tChart1.Zoom.History = true;
            tChart1.Zoom.Direction = ZoomDirections.Both;

            tChart1.Panning.Active = true;
            tChart1.Panning.InsideBounds = true;

            tChart1.Chart.Header.Visible = false;
            tChart1.Chart.Header.AutoSize = true;
            tChart1.Chart.Header.AdjustFrame = true;
            tChart1.Chart.Header.Alignment = Steema.TeeChart.Drawing.StringAlignment.Center;
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
