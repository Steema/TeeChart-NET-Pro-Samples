using Steema.TeeChart.Styles;

namespace Speed_Test
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

      var seriesCount = 10;
      var pointCount = 300;
      var rnd = new Random();

      for (int i = 0; i < seriesCount; i++)
      {
        var line = new Line(tChart1.Chart);
        line.Pointer.Visible = true;
        line.Pointer.Style = PointerStyles.Circle;
        for (int j = 0; j < pointCount; j++)
        {
          line.Add(rnd.NextDouble() * 100);
        }
      }
    }
  }
}