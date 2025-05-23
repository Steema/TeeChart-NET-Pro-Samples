using Steema.TeeChart.Styles;

namespace Speed_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int seriesCount = 10;
            int pointCount = 300;
            Random rnd = new();

            for (int i = 0; i < seriesCount; i++)
            {
                Line line = new(tChart1.Chart);
                line.Pointer.Visible = true;
                line.Pointer.Style = PointerStyles.Circle;
                for (int j = 0; j < pointCount; j++)
                {
                    _ = line.Add(rnd.NextDouble() * 100);
                }
            }
        }
    }
}