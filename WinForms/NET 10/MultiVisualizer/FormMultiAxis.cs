namespace WinAppMultiVis
{
  public partial class FormMultiAxis : Form
  {
    public FormMultiAxis()
    {
      InitializeComponent();
      rand = new Random();
      ConfigMultiSeries1();
    }

    string cursorText = "";
    int cursorX = -1;
    int cursorY = -1;

    private void CursorTool1_Change(object sender, Steema.TeeChart.Tools.CursorChangeEventArgs e)
    {
      cursorText = line2.YScreenToValue(e.y).ToString("#.00");
      cursorX = e.x;
      cursorY = e.y;
    }


    private void tChart7_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
    {
      if (cursorX != -1)
      {
        g.Font.Color = Color.White;
        g.Font.Size = 12;
        g.TextOut(cursorX + 3, (int)(cursorY - g.TextHeight("H") - 2), "Freq. Hz.: " + cursorText);
      }
    }
    

    Random rand;

    private void ConfigMultiSeries1()
    {
      area1.FillSampleValues(100);
      line1.FillSampleValues(100);
      line2.FillSampleValues(100);

      double startDT = DateTime.Now.ToOADate();

      for (int i = 0; i < area1.XValues.Count; i++)
      {
        area1.XValues[i] = startDT + (1.0 / 86400 * i / 2);

        line1.XValues[i] = area1.XValues[i];
        line2.XValues[i] = area1.XValues[i];

        if (line1.YValues[i] > 999)
          line1.YValues[i] = 1000 - (rand.NextDouble() * 200);

        if (line2.YValues[i] > 999)
          line2.YValues[i] = 1000 - (rand.NextDouble() * 200);

        if (i % 2 == 0)
          bar3D1.Add(area1.XValues[i], 400 - rand.Next(400), 400 + rand.Next(400));
      }

    }
  }
}
