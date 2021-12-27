using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Chart_Styles_Financial_indicators : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(WebChart1.Chart, 19); //android
    WebChart1.Chart[0].FillSampleValues(40);  //market
    WebChart1.Chart[1].CheckDataSource(); //macd
    ((Steema.TeeChart.Functions.MACDFunction)(WebChart1.Chart[1].Function)).HistogramPen.Color = Color.Magenta;

    ((Steema.TeeChart.Styles.Candle)(WebChart1.Chart[0])).Pointer.Pen.Color = Color.White;

    Random volume = new Random(25);
    WebChart1.Chart[2].Clear();

    for (int x = 0; x < WebChart1.Chart[0].Count; x++)
      WebChart1.Chart[2].Add(((Steema.TeeChart.Styles.Candle)(WebChart1.Chart[0])).DateValues[x], volume.Next(25)); //volume
  }

  protected void WebChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
  {

    if (WebChart1.Chart.Series.Count > 0)
    {
      Steema.TeeChart.Styles.Candle candle = ((Steema.TeeChart.Styles.Candle)(WebChart1.Chart[0]));

      double highVal = candle.HighValues.Maximum;
      double lowVal = candle.LowValues.Minimum;
      for (int i = 0; i < candle.Count; i++)
        if (candle.HighValues[i] == highVal)
        {
          int xPos = candle.CalcXPos(i);
          int yPos = candle.CalcYPosValue(highVal);

          string output = "High: " + highVal.ToString("#.00");

          if ((candle.CalcXPos(candle.Count - 1) - xPos) < ((int)g.TextWidth(output) + 6))
            xPos = xPos - ((int)g.TextWidth(output) + 6);

          g.Brush.Transparency = 40;
          g.Pen.Color = System.Drawing.Color.Olive;
          g.Rectangle(xPos - 1,
                      yPos - ((int)g.TextHeight("H") + 1) - 3,
                      xPos + (int)g.TextWidth(output) + 2,
                      yPos - 2);
          g.TextOut(xPos, yPos - ((int)g.TextHeight("H") + 1) - 3, output);
        }
        else if (candle.LowValues[i] == lowVal)
        {
          int xPos = candle.CalcXPos(i);
          int yPos = candle.CalcYPosValue(lowVal);

          string output = "Low: " + lowVal.ToString("#.00");

          if ((candle.CalcXPos(candle.Count - 1) - xPos) < ((int)g.TextWidth(output) + 6))
            xPos = xPos - ((int)g.TextWidth(output) + 6);

          g.Brush.Transparency = 40;
          g.Pen.Color = System.Drawing.Color.Olive;
          g.Rectangle(xPos - 1,
                      yPos - 1,
                      xPos + (int)g.TextWidth(output) + 2,
                      yPos + ((int)g.TextHeight("H") + 1) + 1);
          g.TextOut(xPos, yPos, output);
        }

      double dayDiff = (candle.CloseValues[candle.Count - 1] - candle.OpenValues[candle.Count - 1]);
      g.Font.Color = Color.White;
      g.Font.Size = 7;
      string closeStr = "Last close: " + candle.CloseValues[candle.Count - 1].ToString("#0.00") + ", Last day diff: ";

      int xLeft = WebChart1.Chart.Axes.Left.Position;

      g.TextOut(xLeft, WebChart1.Chart.Axes.Left.CalcYPosValue(WebChart1.Chart.Axes.Left.Maximum), closeStr);
      if (dayDiff < 0) g.Font.Color = Color.Orange;
      g.TextOut(xLeft + (int)g.TextWidth(closeStr), WebChart1.Chart.Axes.Left.CalcYPosValue(WebChart1.Chart.Axes.Left.Maximum)
                , dayDiff.ToString("#0.00"));

      g.Font.Color = Color.Black;
      g.Font.Size = 7;
      g.TextOut(430, 200, "Steema Software - Stock trending and evolution analysis");

    }

  }
}
