using Steema.TeeChart;
using Steema.TeeChart.Styles;

namespace NewTeeChartNETDemos
{
    public class CircularBarChartDemo : AttentionChartDemoBase
    {
        public CircularBarChartDemo() : base("Circular Bar Chart")
        {
            var series = new Rose(TeeChart.Chart)
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
            TeeChart.Header.Text = "Circular Bar Chart · CO₂ emissions by country";

            StartValueAnimation(phase =>
            {
                series.BeginUpdate();
                try
                {
                    for (int i = 0; i < series.Count; i++)
                        series.YValues[i] = AnimatedEmission(i, phase);
                }
                finally
                {
                    series.EndUpdate();
                }
            });
        }
    }
}
