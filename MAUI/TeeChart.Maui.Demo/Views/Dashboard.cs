using Steema.TeeChart.Maui;
using Steema.TeeChart.Styles;

namespace TeeChartMockUpDemos;

public class Dashboard : ContentPage
{
    private readonly TChart _chart1 = new();
    private readonly TChart _chart1_2 = new();
    private readonly TChart _chart1_3 = new();
    private readonly TChart _chart2 = new();
    private readonly TChart _chart3 = new();
    private readonly TChart _chart4 = new();
    private readonly TChart _chart5 = new();
    private readonly TChart _chart6 = new();

    [Obsolete]
    public Dashboard()
    {
        Grid grid = new()
        {
            RowDefinitions =
            {
                new RowDefinition { Height = new GridLength(100) },
                new RowDefinition { Height = new GridLength(2, GridUnitType.Star) },
                new RowDefinition(),
                new RowDefinition { Height = new GridLength(100) }
            },
            ColumnDefinitions =
            {
                new ColumnDefinition(),
                new ColumnDefinition(),
                new ColumnDefinition()
            }
        };

        void _chart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
        {
            g.Font.Size = 14;
            g.Font.Color = System.Drawing.Color.Red;
            var str = "This is a custom text on Canvas";
            var size = g.MeasureString(g.Font, str);
            g.TextOut(g.ChartXCenter - Steema.TeeChart.Utils.Round(size.Width / 2.0), g.ChartYCenter - Steema.TeeChart.Utils.Round(size.Height / 2.0), str);
        }

        _chart1.Drawable = _chart1;
        _chart1.Chart.Header.Visible = false;
        _chart1.Chart.Series.Add(new NumericGauge());
        _chart1.Chart.Series[0].FillSampleValues();        
        _chart1.HorizontalOptions = LayoutOptions.FillAndExpand;
        _chart1.VerticalOptions = LayoutOptions.FillAndExpand;
        grid.Add(_chart1, 0, 0);

        _chart1_2.Drawable = _chart1_2;
        _chart1_2.Chart.Header.Visible = false;
        _chart1_2.Chart.Series.Add(new NumericGauge());
        _chart1_2.Chart.Series[0].FillSampleValues();
        _chart1_2.HorizontalOptions = LayoutOptions.FillAndExpand;
        _chart1_2.VerticalOptions = LayoutOptions.FillAndExpand;
        grid.Add(_chart1_2, 1, 0);

        _chart1_3.Drawable = _chart1_3;
        _chart1_3.Chart.Header.Visible = false;
        _chart1_3.Chart.Series.Add(new NumericGauge());
        _chart1_3.Chart.Series[0].FillSampleValues();
        _chart1_3.HorizontalOptions = LayoutOptions.FillAndExpand;
        _chart1_3.VerticalOptions = LayoutOptions.FillAndExpand;
        grid.Add(_chart1_3, 2, 0);

        _chart2.Drawable = _chart2;
        _chart2.Chart.Header.Visible = false;
        _chart2.Chart.Series.Add(new Donut());
        _chart2.Chart.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
        (_chart2.Chart.Series[0] as Donut).Marks.Visible = false;
        (_chart2.Chart.Series[0] as Donut).Circled = true;
        (_chart2.Chart.Series[0] as Donut).Pen.Visible = false;
        _chart2.Chart.Series[0].FillSampleValues();
        _chart2.HorizontalOptions = LayoutOptions.FillAndExpand;
        _chart2.VerticalOptions = LayoutOptions.FillAndExpand;
        grid.Add(_chart2, 0, 1);

        _chart3.Drawable = _chart3;
        _chart3.Chart.Series.Add(new Area());
        _chart3.Chart.Header.Visible = false;
        _chart3.Chart.Series[0].FillSampleValues();
        _chart3.Chart.Legend.Visible = false;
        _chart3.Chart.Axes.Left.Visible = false;
        _chart3.Chart.Axes.Bottom.Increment = 10;
        (_chart3.Chart.Series[0] as Area).Smoothed = true;
        (_chart3.Chart.Series[0] as Area).AreaLines.Visible = false;
        _chart3.HorizontalOptions = LayoutOptions.FillAndExpand;
        _chart3.VerticalOptions = LayoutOptions.FillAndExpand;
        grid.Add(_chart3, 1, 1);

        grid.SetColumnSpan(_chart3, 2);

        // Row 2
        _chart4.Drawable = _chart4;
        _chart4.Chart.Header.Visible = false;
        _chart4.Chart.Series.Add(new World());
        _chart4.Chart.Axes.Bottom.Visible = false;
        (_chart4.Chart.Series[0] as World).Map = WorldMapType.World;
        (_chart4.Chart.Series[0] as World).Pen.Visible = false;
        _chart4.Chart.Series[0].FillSampleValues();
        _chart4.HorizontalOptions = LayoutOptions.FillAndExpand;
        _chart4.VerticalOptions = LayoutOptions.FillAndExpand;
        grid.Add(_chart4, 0, 2);

        grid.SetColumnSpan(_chart4, 2);

        _chart5.Drawable = _chart5;
        _chart5.Chart.Header.Visible = false;
        _chart5.Chart.Series.Add(new Bar());
        _chart5.Chart.Series[0].FillSampleValues();
        _chart5.Chart.Series[0].Marks.Visible = false;
        _chart5.Chart.Axes.Left.Visible = false;
        _chart5.Chart.Legend.Visible = false;        
        _chart5.HorizontalOptions = LayoutOptions.FillAndExpand;
        _chart5.VerticalOptions = LayoutOptions.FillAndExpand;
        grid.Add(_chart5, 2, 2);

        // Row 3
        _chart6.Drawable = _chart6;
        _chart6.Chart.Header.Visible = false;
        _chart6.Chart.Series.Add(new Line());
        (_chart6.Chart.Series[0] as Line).LinePen.Width = 5;
        _chart6.Chart.Series[0].FillSampleValues();
        _chart6.Chart.Legend.Visible = false;
        _chart6.Chart.Axes.Left.Visible = false;
        _chart6.Chart.Axes.Bottom.Visible = false;
        _chart6.Chart.Panel.MarginBottom = 50;
        _chart6.HorizontalOptions = LayoutOptions.FillAndExpand;
        _chart6.VerticalOptions = LayoutOptions.FillAndExpand;
        _chart6.AfterDraw += _chart1_AfterDraw;
        grid.Add(_chart6, 0, 3);

        Grid.SetColumnSpan(_chart6, 3);

        Title = "Steema TeeChart sample Dashboard";
        Content = grid;
    }

}
