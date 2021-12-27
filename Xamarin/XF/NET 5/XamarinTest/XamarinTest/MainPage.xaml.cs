using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Steema.TeeChart;
using Steema.TeeChart.Styles;
using Xamarin.Forms;

namespace XamarinTest
{
	public partial class MainPage : ContentPage
	{        
        
        public MainPage()
		{
			InitializeComponent();
            InitializeChart();
        }

        ChartView _tChart1;


        private void InitializeChart()
        {

            Button button = new Button { Text = "CUSTOM BUTTON" };
            //button.Visual = new CustomVisual();
            button.Clicked += Button_Clicked;


            var watch = Stopwatch.StartNew();

            _tChart1 = new ChartView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,

                WidthRequest = 400,
                HeightRequest = 600,
            };

            _tChart1.Chart.Aspect.View3D = true;

            (this.Content as StackLayout).Children.Add(_tChart1);

            //_tChart1.InvalidateDisplay();
            var bar = new Bar(_tChart1.Chart);
            bar.FillSampleValues(3);
            bar.ColorEach = true;
            _tChart1.Chart.Panning.Active = true;
            _tChart1.Chart.ClickSeries += Chart_ClickSeries;

            Console.WriteLine($"Time taken to load chart: {watch.ElapsedMilliseconds}");

            watch.Stop();

            this.Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Start,
                Children =
                {
                    _tChart1
                },
            };

        }

        private void Chart_ClickSeries(object sender, Series s, int valueIndex, Steema.TeeChart.Drawing.MouseEventArgs e)
        {
            _tChart1.Chart.Header.Text = "clicked";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
