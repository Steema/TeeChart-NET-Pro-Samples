using Steema.TeeChart.Drawing;
using Steema.TeeChart.Styles;
using Steema.TeeChart.Tools;
using System.Windows;

namespace TestAnnotationClickEvent;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    Annotation _annotation1;
    Line _lineSeries1;

    public MainWindow()
    {
        InitializeComponent();
        MakeGraph();
    }

    public void MakeGraph()
    {
        _lineSeries1 = new Line();
        _lineSeries1.FillSampleValues(20);
        tChart.Series.Add(_lineSeries1);


        _annotation1 = new Annotation
        {
            AutoSize = true,
            Position = AnnotationPositions.LeftBottom,
            Text = "Some text"
        };
        tChart.Tools.Add(_annotation1);

        _annotation1.Click += Annotation1_Click;
    }

    /* Now works */
    void Annotation1_Click(object sender, MouseEventArgs e)
    {
        MessageBox.Show(_annotation1.Text, "Clicked");
    }
}