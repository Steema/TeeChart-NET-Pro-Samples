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

namespace WebDemo
{
	/// <summary>
    /// Summary description for JLineChart1.
	/// </summary>
	public partial class JLineChart1 : System.Web.UI.Page
	{
	
		

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

    protected void Page_Load(object sender, System.EventArgs e)
    {

      //WebChart1.Chart.Panel.BorderRound = 30;
      Steema.TeeChart.Chart ch1 = WebChart1.Chart;
      ch1.Header.Visible = false;
      ch1.Series.RemoveAllSeries();
      ch1.Series.Add(new Steema.TeeChart.Styles.Line());
      ch1.Series.Add(new Steema.TeeChart.Styles.Line());
      ((Steema.TeeChart.Styles.Line)(ch1.Series[0])).LinePen.Width = 2;
      ((Steema.TeeChart.Styles.Line)(ch1.Series[1])).LinePen.Width = 2;
      ch1.Series[0].FillSampleValues();
      ch1.Series[1].FillSampleValues();

      ch1.Series[0].Marks.Visible = false; //using tooltip jscript-side
      ch1.Series[1].Marks.Visible = false;

      double maxY = (ch1.Series[0].MaxYValue() > ch1.Series[1].MaxYValue()) ? ch1.Series[0].MaxYValue() : ch1.Series[1].MaxYValue();

      ch1.Legend.Shadow.Visible = false;
      ch1.Legend.Visible = false;

      //apply some custom code, runs just before Javascript Chart draw
      string[] customCode = new string[] {
            "  "+ WebChart1.ClientID + "_chart.axes.left.setMinMax("+ WebChart1.ClientID + "_chart.axes.left.minimum,"+ maxY.ToString() + " + 15);",
            "  " + WebChart1.ClientID + "_chart.series.items[0].format.stroke.size = 2;",
            "  " + WebChart1.ClientID + "_chart.series.items[1].format.stroke.size = 2;",
            "  //sets startup smoothing",
            "  " + WebChart1.ClientID + "_chart.series.items[0].smooth = 1/3;",
            "  " + WebChart1.ClientID + "_chart.series.items[1].smooth = 1/3;",
            "  ",
            "  //sets appearance",
            "  "+ WebChart1.ClientID + "_chart.applyPalette('seaWash');",            "  "+ WebChart1.ClientID + "_chart.applyTheme('minimal');",                          "  ",
              "//tooltip",
              "tip=new Tee.ToolTip("+ WebChart1.ClientID + "_chart);",
              "tip.render=\"dom\";",
              "tip.domStyle = \"padding-left:8px; padding-right:8px; padding-top:2px; padding-bottom:4px; margin-left:5px; margin-top:0px; \";",
              "tip.domStyle = tip.domStyle + \"background-color:#FCFCFC; border-radius:4px 4px; color:#FFF; \";",
              "tip.domStyle = tip.domStyle + \"border-style:solid;border-color:#A3A3AF;border-width:1; z-index:1000;\";",
              WebChart1.ClientID + "_chart.tools.add(tip);",
              "tip.onhide=function() { scaling=0; poindex=-1; }",

              "tip.ongettext=function( tool, text, series, index) { ",
              "  var s = '<font face=\"verdana\" color=\"black\" size=\"1\"><strong>'+ series.title+'</strong></font>';",
              "	    s = s + '<br/><font face=\"verdana\" color=\"darkblue\" size=\"1\">Series point: <strong>'+ index.toFixed(0)+'</strong></font>';",
              "      s =	s +'<br/><font face=\"verdana\" color=\"red\" size=\"1\">Value: '+series.data.values[index].toFixed(2)+'</font>';  ",
              "   return s;",
              "}",
              "  "
      //example code - could add Points
      /*"  " + WebChart1.ClientID + "_chart.series.items[0].pointer.width = 20;",
      "  " + WebChart1.ClientID + "_chart.series.items[0].pointer.height = 20;",
      "  " + WebChart1.ClientID + "_chart.series.items[0].pointer.style = \"ellipse\";",
      "  " + WebChart1.ClientID + "_chart.series.items[0].pointer.format.stroke.size = 4;",
      "  " + WebChart1.ClientID + "_chart.series.items[0].pointer.format.stroke.fill = \"white\";",
      "  " + WebChart1.ClientID + "_chart.series.items[0].pointer.format.shadow.visible = false;",
      "  " + WebChart1.ClientID + "_chart.series.items[0].format.stroke.size = 4;",
      "  " + WebChart1.ClientID + "_chart.series.items[0].format.shadow.visible = false;",
      "  " + WebChart1.ClientID + "_chart.series.items[0].hover.stroke.fill = \"rgba(255,255,128,1.0)\";",
      "  " + WebChart1.ClientID + "_chart.series.items[0].pointer.visible = true;"*/
    };

      ch1.Export.Image.JScript.CustomCode = customCode;
    }

	}
}
