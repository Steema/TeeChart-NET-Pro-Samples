namespace TeeChart.Maui.TEST;

public sealed class SeriesMenuItem : ContentView
{
    private readonly BoxView selectionBackground;
    private readonly Label textLabel;

    public static readonly BindableProperty TextProperty = BindableProperty.Create(
        nameof(Text), typeof(string), typeof(SeriesMenuItem), string.Empty,
        propertyChanged: (bindable, _, value) =>
            ((SeriesMenuItem)bindable).textLabel.Text = value?.ToString() ?? string.Empty);

    public static readonly BindableProperty SeriesTypeProperty = BindableProperty.Create(
        nameof(SeriesType), typeof(string), typeof(SeriesMenuItem), string.Empty);

    public static readonly BindableProperty IsSelectedProperty = BindableProperty.Create(
        nameof(IsSelected), typeof(bool), typeof(SeriesMenuItem), false,
        propertyChanged: (bindable, _, value) =>
            ((SeriesMenuItem)bindable).UpdateSelection((bool)value));

    public SeriesMenuItem()
    {
        HeightRequest = 34;
        HorizontalOptions = LayoutOptions.Fill;

        selectionBackground = new BoxView
        {
            Color = Colors.Transparent,
            CornerRadius = 6,
            InputTransparent = true
        };
        textLabel = new Label
        {
            TextColor = Color.FromArgb("#253858"),
            FontSize = 14,
            Padding = new Thickness(12, 6),
            VerticalTextAlignment = TextAlignment.Center,
            HorizontalTextAlignment = TextAlignment.Start,
            InputTransparent = true
        };
        var clickTarget = new Button
        {
            Text = string.Empty,
            BackgroundColor = Colors.Transparent,
            BorderWidth = 0,
            Padding = 0,
            HorizontalOptions = LayoutOptions.Fill,
            VerticalOptions = LayoutOptions.Fill
        };
        clickTarget.Clicked += (_, _) => Clicked?.Invoke(this, EventArgs.Empty);

        var layout = new Grid();
        layout.Children.Add(selectionBackground);
        layout.Children.Add(textLabel);
        layout.Children.Add(clickTarget);
        Content = layout;
    }

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public string SeriesType
    {
        get => (string)GetValue(SeriesTypeProperty);
        set => SetValue(SeriesTypeProperty, value);
    }

    public bool IsSelected
    {
        get => (bool)GetValue(IsSelectedProperty);
        set => SetValue(IsSelectedProperty, value);
    }

    public event EventHandler Clicked;

    private void UpdateSelection(bool selected)
    {
        selectionBackground.Color = selected ? Color.FromArgb("#E8F1FF") : Colors.Transparent;
        textLabel.TextColor = selected ? Color.FromArgb("#0B63CE") : Color.FromArgb("#253858");
        textLabel.FontAttributes = selected ? FontAttributes.Bold : FontAttributes.None;
    }
}
