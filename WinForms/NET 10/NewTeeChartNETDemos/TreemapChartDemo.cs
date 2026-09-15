using System.Drawing;
using Steema.TeeChart.Styles;

namespace NewTeeChartNETDemos
{
    public class TreemapChartDemo : AttentionChartDemoBase
    {
        public TreemapChartDemo() : base("Treemap Chart")
        {
            var series = new TreeMap(TeeChart.Chart)
            {
                Title = "CO₂ emissions 2018",
                ColorStyle = TreeMapColorStyle.ByValue,
                MapStyle = TreeMapTiling.Slice,
                PaletteSteps = 12
            };

            series.Palette.StartColor = Color.FromArgb(35, 75, 150);
            series.Palette.MidColor = Color.FromArgb(40, 170, 150);
            series.Palette.EndColor = Color.FromArgb(245, 210, 55);

            for (int i = 0; i < AttentionChartData.Countries.Length; i++)
                series.Add(AttentionChartData.Countries[i], AttentionChartData.Emissions[i]);

            TeeChart.Legend.Visible = false;
            TeeChart.Header.Text = "Treemap · CO₂ emissions by country";

            StartValueAnimation(phase =>
            {
                series.BeginUpdate();
                try
                {
                    for (int i = 0; i < series.Count; i++)
                        series.YValues[i] = AnimatedEmission(i, phase, 0.14);
                }
                finally
                {
                    series.EndUpdate();
                }
            });
        }
    }
}
