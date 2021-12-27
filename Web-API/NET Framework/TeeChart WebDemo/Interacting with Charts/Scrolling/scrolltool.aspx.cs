using System;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using Steema.TeeChart.Web;
using Steema.TeeChart.Styles;

public partial class Interacting_with_Charts_Scrolling_scrolltool : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    // ****************************************************
    //The data load code for WebChart1 demostrates a technique to save 
    //data between page calls. The Chart is saved as a TeeChart template 
    //to a session variable.
    // ****************************************************
    Steema.TeeChart.Chart ch1 = WebChart1.Chart;
    MemoryStream tmpChart = new MemoryStream();

    //Steema.TeeChart.Tools.ScrollTool scrollTool = new Steema.TeeChart.Tools.ScrollTool(ch1);

    if (Page.Cache["ch1Scroll"] == null)
    {
      //setup Chart
      if (ch1.Series.Count < 2)
      {
        ch1.Series.Add(new Steema.TeeChart.Styles.Area());
        ch1.Series.Add(new Steema.TeeChart.Styles.Points());
      }

      ch1.Panel.Gradient.Visible = false;
      ch1.Walls.Back.Pen.Visible = false;

      //ch1.Series[0].Color = Color.FromArgb(255, 199, 26);
      //ch1.Series[1].Color = Color.FromArgb(106, 106, 255);

      Random r = new Random();
      DateTime date = DateTime.Now.AddMonths(-48);

      ch1.Series[0].Clear();
      ch1.Series[1].Clear();

      ch1.Series[0].Marks.Visible = false;
      ch1.Series[1].Marks.Visible = false;
      ch1.Series[2].Marks.Visible = false;

      for (int i = 0; i < 208; i++)
      {
        int yVal1 = 0;
        int yVal2 = 0;
        if (ch1.Series[0].Count == 0) yVal1 = r.Next(50);
        else
        {
          int rVal = Convert.ToInt32(ch1.Series[0].YValues.Last - 10 + r.Next(20));
          yVal1 = rVal > 0 ? rVal : Convert.ToInt32(ch1.Series[0].YValues.Last + (r.Next(30)));
          if (yVal1 > 49) yVal1 = yVal1 - r.Next(50);
        }
        
        if ((yVal1 > 5) && (yVal1 < 40)) yVal2 = yVal1 - (r.Next(9));
        else yVal2 = r.Next(45);

        ch1.Series[0].Add(date, yVal1);
        ch1.Series[1].Add(date,10+(yVal2*3));
        date=date.AddDays(7);
      }
      ch1.Series[2].CheckDataSource();

      ch1.Axes.Bottom.SetMinMax(ch1.Series[0].MinXValue() - 5.0, ch1.Series[0].MaxXValue() + 5);

      //export Chart to a MemoryStream template
      ch1.Export.Template.Save(tmpChart);
      //save template to a Session variable
      Page.Cache.Add("ch1Scroll", tmpChart, null,
                       DateTime.Now.AddSeconds(40), System.Web.Caching.Cache.NoSlidingExpiration,
                       System.Web.Caching.CacheItemPriority.NotRemovable, null);

      ((Steema.TeeChart.Tools.ScrollTool)ch1.Tools[0]).StartPosition = 30;
    }
    else
    {
      //retrieve the session stored Chart
      tmpChart = (MemoryStream)Page.Cache["ch1Scroll"];
      //set the Stream position to 0 as the last read/write
      //will have moved the position to the end of the stream
      tmpChart.Position = 0;
      //import saved Chart
      WebChart1.Chart.Import.Template.Load(tmpChart);
    }
  }
}
