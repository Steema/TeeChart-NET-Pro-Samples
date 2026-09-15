using Steema.TeeChart.Styles;

namespace NewTeeChartNETDemos
{
    public class BubbleChartDemo : AttentionChartDemoBase
    {
        public BubbleChartDemo() : base("Bubble Chart")
        {
            var series = new Bubble(TeeChart.Chart)
            {
                Title = "CO₂ emissions 2018",
                ColorEach = true,
                Squared = true
            };

            for (int i = 0; i < AttentionChartData.Countries.Length; i++)
            {
                double x = i + 1;
                double y = AttentionChartData.Emissions[i];
                double radius = 8 + y / 110.0;
                series.Add(x, y, radius, AttentionChartData.Countries[i], AttentionChartData.ColorFor(i));
            }

            TeeChart.Legend.Visible = false;
            TeeChart.Header.Text = "Bubble Chart · CO₂ emissions by country";
            TeeChart.Axes.Bottom.Title.Text = "Country index";
            TeeChart.Axes.Left.Title.Text = "MTCO₂e";

            // Keep the viewport stable while the values and bubble sizes animate.
            TeeChart.Axes.Bottom.SetMinMax(0.5, AttentionChartData.Countries.Length + 0.5);
            TeeChart.Axes.Bottom.Increment = 1;
            TeeChart.Axes.Left.SetMinMax(0, 3200);
            TeeChart.Axes.Left.Increment = 400;

            StartValueAnimation(phase =>
            {
                series.BeginUpdate();
                try
                {
                    for (int i = 0; i < series.Count; i++)
                    {
                        double value = AnimatedEmission(i, phase, 0.15);
                        series.YValues[i] = value;
                        series.RadiusValues[i] = 8 + value / 110.0;
                    }
                }
                finally
                {
                    series.EndUpdate();
                }
            });
        }
    }
}
