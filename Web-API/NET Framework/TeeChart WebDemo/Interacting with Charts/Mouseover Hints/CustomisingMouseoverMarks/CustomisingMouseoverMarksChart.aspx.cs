using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using Steema.TeeChart;

namespace WebDemo.Interacting_with_Charts.Mouseover_Hints.CustomisingMouseoverMarks
{
	/// <summary>
	/// Summary description for DisplayingCustomToolTipChart.
	/// </summary>
  public partial class DisplayingCustomToolTipChart : System.Web.UI.Page
  {
    protected void Page_Load(object sender, System.EventArgs e)
    {
      Steema.TeeChart.Chart ch1 = WebChart1.Chart;

      //Series Hotspot Tool
      Steema.TeeChart.Tools.SeriesHotspot seriesHotspot1 = new Steema.TeeChart.Tools.SeriesHotspot();

      //Custom Hotspot tool (to add a Hotspot to any Chart element)
      Steema.TeeChart.Tools.CustomHotspot cHotspot1 = new Steema.TeeChart.Tools.CustomHotspot();
      
      //Assign events for on-the-fly Hotspot content
      seriesHotspot1.GetHTMLMap += new Steema.TeeChart.Tools.SeriesHotspotEventHandler(hotspot1_GetHTMLMap);
      cHotspot1.GetHTMLMap += new Steema.TeeChart.Tools.CustomHotspotEventHandler(cHotspot1_GetHTMLMap);

      seriesHotspot1.MapAction = Steema.TeeChart.Styles.MapAction.Script;

      Steema.TeeChart.Styles.Bar bar1 = new Steema.TeeChart.Styles.Bar();
      Steema.TeeChart.Styles.Bar bar2 = new Steema.TeeChart.Styles.Bar();
      Steema.TeeChart.Styles.Bar bar3 = new Steema.TeeChart.Styles.Bar();

      //Add tools to Chart
      ch1.Tools.Add(seriesHotspot1);
      ch1.Tools.Add(cHotspot1);

      ch1.Series.Add(bar1);
      ch1.Series.Add(bar2);
      ch1.Series.Add(bar3);

      System.Random rnd = new Random();
      // Populate series data
      foreach (Steema.TeeChart.Styles.Series ser in ch1.Series)
      {
        ser.Clear();
        ser.Add(0, rnd.Next(1000), "Spain");
        ser.Add(1, rnd.Next(1000), "UK");
        ser.Add(2, rnd.Next(1000), "Slovenia");
        ser.Marks.Visible = false;
      }
      ch1.Legend.CustomPosition = true;
      ch1.Legend.Left = 350;
      ch1.Legend.Top = 10;
      ch1.Legend.Shadow.Visible = false;
      ch1.Legend.Transparent = true;
      ch1.Axes.Left.MaximumOffset = 20;
    }

    #region Web Form Designer generated code
    override protected void OnInit(EventArgs e)
    {
      //
      // CODEGEN: This call is required by the ASP.NET Web Form Designer.
      //
      InitializeComponent();
      base.OnInit(e);
    }

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {

    }
    #endregion

    /// <summary>
    /// CustomHotspot event
    /// </summary>
    private void cHotspot1_GetHTMLMap(Steema.TeeChart.Tools.CustomHotspot sender, Steema.TeeChart.Tools.CustomHotspotEventArgs e)
    {
      int left = WebChart1.Chart.Legend.Left;
      int top = WebChart1.Chart.Legend.Top;
      int right = WebChart1.Chart.Legend.Right;
      int bottom = WebChart1.Chart.Legend.Bottom;

      Steema.TeeChart.Styles.PointPolygon p = new Steema.TeeChart.Styles.PointPolygon(0,
                     new int[] { left, top, right, top, right, bottom, left, bottom },
                     Steema.TeeChart.Styles.PolygonStyle.Rect);

      p.PointStyle = Steema.TeeChart.Styles.PolygonStyle.Poly;
      p.Title = "Legend hotspot";

      //add our Legend hotspot to the hotspots list
      e.Polygons.Add(p);

      int axLeft = WebChart1.Chart.Axes.Left.Position - 1;
      int axTop = WebChart1.Chart.Axes.Top.Position;
      int axRight = WebChart1.Chart.Axes.Left.Position + 1;
      int axBottom = WebChart1.Chart.Axes.Bottom.Position;

      p = new Steema.TeeChart.Styles.PointPolygon(0,
               new int[] { axLeft, axTop, axRight, axTop, axRight, axBottom, axLeft, axBottom },
               Steema.TeeChart.Styles.PolygonStyle.Rect);

      p.PointStyle = Steema.TeeChart.Styles.PolygonStyle.Poly;
      p.Title = "Axis hotspot";

      //add our Axis hotspot to the hotspots list
      e.Polygons.Add(p);
    }

    /// <summary>
    /// SeriesHotspot event
    /// </summary>
    private void hotspot1_GetHTMLMap(Steema.TeeChart.Tools.SeriesHotspot sender, Steema.TeeChart.Tools.SeriesHotspotEventArgs e)
    {
      switch (DropDownList1.SelectedIndex)
      {
        case 0:
          {
            e.PointPolygon.Attributes = String.Format(Texts.HelperScriptAnnotation,
                                      "<IMG SRC=images/image" + (e.PointPolygon.ValueIndex + 1) + ".gif>");
            break;
          }
        case 1:
          {
            string ParamValues = "&Fatal=" + WebChart1.Chart.Series[0].YValues[e.PointPolygon.ValueIndex];
            ParamValues += "&Serious=" + WebChart1.Chart.Series[1].YValues[e.PointPolygon.ValueIndex];
            ParamValues += "&Light=" + WebChart1.Chart.Series[2].YValues[e.PointPolygon.ValueIndex];

            e.PointPolygon.Attributes = String.Format(Texts.HelperScriptAnnotation,
              "<IMG SRC=ShowChart.aspx?ChartTitle=" + WebChart1.Chart.Series[0].Labels[e.PointPolygon.ValueIndex]
              + ParamValues + "&view=True&width=100&height=80>");
            break;
          }
        case 2:
          {
            e.PointPolygon.Attributes = String.Format(Texts.HelperScriptAnnotation, e.Series.YValues.Value[e.PointPolygon.ValueIndex].ToString() + " " + e.Series.Title.ToString() + " Accidents in " + e.Series.Labels[e.PointPolygon.ValueIndex]);
            break;
          }
      }
    }
  }
}
