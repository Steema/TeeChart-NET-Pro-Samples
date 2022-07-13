namespace TeeChart.Maui.Gallery;

public partial class MainPage : ContentPage
{
	int count = 0;
	ChartView chartView;

	public MainPage()
	{
		InitializeComponent();
        OnCounterClicked(null, null);
    }

    private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);

		chartView = new ChartView();
        chartView.Chart.Width = 400;
        chartView.Chart.Height = 500;
        var _s = new Steema.TeeChart.Styles.Points();
        chartView.Chart.Series.Add(_s);
        _s.FillSampleValues(10);
        _s.Marks.Visible = true;
        _s.Marks.Transparent = true;
        _s.Marks.ArrowLength = 5;


        chartView.Chart.Axes.Left.Visible = true;
        chartView.Chart.Axes.Left.AxisPen.Color = System.Drawing.Color.Blue;
        chartView.Chart.Axes.Left.AxisPen.Width = 5;
        chartView.Chart.Axes.Left.Title.Text = "Left Axis Title";
        chartView.Chart.Axes.Left.AxisPen.Visible = true;

        chartView.Chart.AfterDraw += Chart_AfterDraw;

        var stack = new StackLayout()
        {
            Orientation = StackOrientation.Vertical,
            HorizontalOptions = LayoutOptions.Fill,
            VerticalOptions = LayoutOptions.Center,

            Children =
            {
                chartView,
            }
        };
        Content = stack;
    }

    private void Chart_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
    {
        g.TextOut(10,10, "custom drawing");
    }
}

