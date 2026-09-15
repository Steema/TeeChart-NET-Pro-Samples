using Steema.TeeChart.Styles;

namespace NewTeeChartNETDemos
{
    public class RadarChartDemo : AttentionChartDemoBase
    {
        public RadarChartDemo() : base("Radar Chart")
        {
            var series = new Radar(TeeChart.Chart)
            {
                Title = "CO₂ emissions 2018",
                ColorEach = true,
                Circled = true,
                CloseCircle = true,
                CircleLabels = true,
                AutoCircleResize = false
            };

            for (int i = 0; i < AttentionChartData.Countries.Length; i++)
                series.Add(AttentionChartData.Emissions[i], AttentionChartData.Countries[i], AttentionChartData.ColorFor(i));

            TeeChart.Legend.Visible = false;
            TeeChart.Header.Text = "Radar Chart · CO₂ emissions by country";

            // Fix both polar axes so the animated profile can be compared directly.
            series.GetVertAxis.SetMinMax(0, 3200);
            series.GetVertAxis.Increment = 400;
            series.GetHorizAxis.SetMinMax(0, 360);
            series.GetHorizAxis.Increment = 90;

            StartValueAnimation(phase =>
            {
                series.BeginUpdate();
                try
                {
                    for (int i = 0; i < series.Count; i++)
                        series.YValues[i] = AnimatedEmission(i, phase, 0.13);
                }
                finally
                {
                    series.EndUpdate();
                }
            });
        }
    }
}
