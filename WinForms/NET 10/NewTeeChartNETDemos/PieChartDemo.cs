using Steema.TeeChart;
using Steema.TeeChart.Styles;

namespace NewTeeChartNETDemos
{
    public class PieChartDemo : AttentionChartDemoBase
    {
        public PieChartDemo() : base("Pie Chart")
        {
            var series = new Pie(TeeChart.Chart)
            {
                Title = "CO₂ emissions 2018",
                Circled = true,
                ColorEach = true
            };

            for (int i = 0; i < AttentionChartData.Countries.Length; i++)
                series.Add(AttentionChartData.Emissions[i], AttentionChartData.Countries[i], AttentionChartData.ColorFor(i));

            series.Marks.Visible = true;
            TeeChart.Legend.Visible = true;
            TeeChart.Legend.Alignment = LegendAlignments.Right;
            TeeChart.Header.Text = "Pie Chart · CO₂ emissions by country";

            StartValueAnimation(phase =>
            {
                series.BeginUpdate();
                try
                {
                    for (int i = 0; i < series.Count; i++)
                        series.YValues[i] = AnimatedEmission(i, phase, 0.11);
                }
                finally
                {
                    series.EndUpdate();
                }
            });
        }
    }
}
