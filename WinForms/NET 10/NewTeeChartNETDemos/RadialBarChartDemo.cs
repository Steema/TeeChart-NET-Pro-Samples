using Steema.TeeChart;
using Steema.TeeChart.Styles;

namespace NewTeeChartNETDemos
{
    public class RadialBarChartDemo : AttentionChartDemoBase
    {
        public RadialBarChartDemo() : base("Radial Bar Chart")
        {
            var series = new PolarBar(TeeChart.Chart)
            {
                Title = "CO₂ emissions 2018",
                ColorEach = true,
                Circled = true
            };

            for (int i = 0; i < AttentionChartData.Countries.Length; i++)
            {
                double angle = i * 360.0 / AttentionChartData.Countries.Length;
                series.Add(angle, AttentionChartData.Emissions[i],
                    AttentionChartData.Countries[i], AttentionChartData.ColorFor(i));
            }

            TeeChart.Legend.Visible = true;
            TeeChart.Legend.Alignment = LegendAlignments.Right;
            TeeChart.Header.Text = "Radial Bar Chart · CO₂ emissions by country";

            // Keep the polar viewport fixed while the radial bars animate.
            series.GetVertAxis.SetMinMax(0, 3200);
            series.GetVertAxis.Increment = 400;
            series.GetHorizAxis.SetMinMax(0, 360);
            series.GetHorizAxis.Increment = 90;
            series.RadiusIncrement = 400;
            series.AngleIncrement = 90;

            StartValueAnimation(phase =>
            {
                series.BeginUpdate();
                try
                {
                    for (int i = 0; i < series.Count; i++)
                        series.YValues[i] = AnimatedEmission(i, phase, 0.10);
                }
                finally
                {
                    series.EndUpdate();
                }
            });
        }
    }
}
