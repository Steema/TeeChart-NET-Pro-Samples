using Steema.TeeChart.Maui;

namespace TeeChartMockUpDemos;

public class Dashboard : ContentPage
{
    private readonly TChart _chart1 = new();
    private readonly TChart _chart2 = new();
    private readonly TChart _chart3 = new();
    private readonly TChart _chart4 = new();
    private readonly TChart _chart5 = new();
    private readonly TChart _chart6 = new();
    private readonly TChart _chart7 = new();
    private readonly TChart _chart8 = new();
    private readonly TChart _chart9 = new();
    private readonly TChart _chart10 = new();

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

        /*
        // Row 0
        // The BoxView and Label are in row 0 and column 0, and so only need to be added to the
        // Grid to obtain the default row and column settings.
        Steema.TeeChart.Styles.Line _numericGauge = new();
        _numericGauge.FillSampleValues();
        _chart1.Chart.Series.Add(_numericGauge);
        _chart1.HeightRequest = 400;
        _chart1.WidthRequest = 400;
        _chart1.Chart.Width = 400;
        _chart1.Chart.Height = 400;
        _chart1.HorizontalOptions = LayoutOptions.FillAndExpand;
        _chart1.VerticalOptions = LayoutOptions.FillAndExpand;  */



        void _chart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
        {
            g.Font.Size = 16;
            g.Font.Color = System.Drawing.Color.Red;
            var str = "Hello Chart";
            var size = g.MeasureString(g.Font, str);
            g.TextOut(g.ChartXCenter - Steema.TeeChart.Utils.Round(size.Width / 2.0), g.ChartYCenter - Steema.TeeChart.Utils.Round(size.Height / 2.0), str);
        }

        _chart1.Drawable = _chart1;
        _chart1.AfterDraw += _chart1_AfterDraw;
        //_chart1.HeightRequest = 400;
        _chart1.HorizontalOptions = LayoutOptions.FillAndExpand;
        _chart1.VerticalOptions = LayoutOptions.FillAndExpand;
        grid.Add(_chart1, 0, 0);


        
        /* grid.Add(new Label
        {
            Text = "Row 0, Column 0",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        });  */

        grid.Add(new Label
        {
            Text = "Row 0, Column 1",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        }, 1, 0);

        // This BoxView and Label are in row 0 and column 2, which are specified as arguments
        // to the Add method.
        grid.Add(new BoxView
        {
            Color = Colors.Blue
        }, 2, 0);
        grid.Add(new Label
        {
            Text = "Row 0, Column 2",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        }, 2, 0);


        // Row 1
        // The BoxView and Label are in row 0 and column 0, and so only need to be added to the
        // Grid to obtain the default row and column settings.
        grid.Add(new BoxView
        {
            Color = Colors.Green
        }, 0, 1);
        grid.Add(new Label
        {
            Text = "Row 1, Column 0",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        }, 0, 1);

        // This BoxView and Label are in row 1 and column 1, which are specified as arguments
        // to the Add method.
        BoxView boxView2 = new()
        {
            Color = Colors.Blue
        };

        grid.Add(boxView2, 1, 1);
        grid.Add(new Label
        {
            Text = "Row 1, Column 1",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        }, 1, 1);
        grid.SetColumnSpan(boxView2, 2);

        // Row 2
        // This BoxView and Label are in row 1 and column 0, which are specified as arguments
        // to the Add method overload.
        BoxView boxView3 = new()
        {
            Color = Colors.Teal
        };

        grid.Add(boxView3, 0, 2);
        grid.Add(new Label
        {
            Text = "Row 2, Column 0",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        }, 0, 2);
        grid.SetColumnSpan(boxView3, 2);

        // This BoxView and Label are in row 2 and column 1, which are specified as arguments
        // to the Add method overload.
        grid.Add(new BoxView
        {
            Color = Colors.Purple
        }, 2, 2);
        grid.Add(new Label
        {
            Text = "Row2, Column 1",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        }, 2, 2);

        // Row 3
        // Alternatively, the BoxView and Label can be positioned in cells with the Grid.SetRow
        // and Grid.SetColumn methods.
        BoxView boxView = new() { Color = Colors.Red };
        Grid.SetRow(boxView, 3);
        Grid.SetColumnSpan(boxView, 3);
        Label label = new()
        {
            Text = "Row 3, Column 0 and 1",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };
        Grid.SetRow(label, 3);
        Grid.SetColumnSpan(label, 3);

        grid.Add(boxView);
        grid.Add(label);

        Title = "Dashboard";
        Content = grid;
    }

}
