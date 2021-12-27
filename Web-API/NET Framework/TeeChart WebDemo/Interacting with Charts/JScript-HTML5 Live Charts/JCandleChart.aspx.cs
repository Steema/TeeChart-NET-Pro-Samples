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
    /// Summary description for JBarChart1.
	/// </summary>
	public partial class JCandleChart1 : System.Web.UI.Page
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
			Steema.TeeChart.Chart ch1=WebChart1.Chart;
            ch1.Panel.BorderRound = 4;
            ch1.Panel.Shadow.Visible = false;
            ch1.Panel.Pen.Visible = false;
			ch1.Series.RemoveAllSeries();
			ch1.Series.Add(new Steema.TeeChart.Styles.Candle());
            ch1.Series.Add(new Steema.TeeChart.Styles.Volume());
            //((Steema.TeeChart.Styles.Bar)(ch1.Series[0])).ColorEach = true;
			ch1.Series[0].FillSampleValues(100);
            ch1.Series[1].FillSampleValues(100);
            ch1.Series[0].Marks.Visible = false;
            ch1.Series[1].Marks.Visible = false;
			ch1.Legend.Shadow.Visible = false;
			ch1.Legend.Visible = false;

            Steema.TeeChart.Axis vAxis1 = new Steema.TeeChart.Axis(false, false, ch1);
            ch1.Axes.Custom.Add(vAxis1);

            //setup axes (could be done via Editor)
            ch1.Axes.Left.StartPosition = 0;
            ch1.Axes.Left.EndPosition = 68;
            vAxis1.StartPosition = 72;
            vAxis1.EndPosition = 100;
            ch1.Series[1].XValues.DateTime = true;
            ch1.Series[1].VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom;
            ch1.Series[1].CustomVertAxis = vAxis1;

            ch1.Export.Image.JScript.SourceUnits.Add("date.format.js");
            //ch1.Export.Image.JScript.SourceScriptPath = @"http://www.steema.com/files/private/TeeChartJScr/prereleasesrc";
            //ch1.Export.Image.JScript.SourceScriptPath = @"../../";

            //apply some custom code, runs just before Javascript Chart draw
            string[] customCode = new string[] {
              "changeTheme(\"minimal\");",
              "changePalette(\"seaWash\");",
              
              WebChart1.ClientID + "_chart.walls.back.format.stroke.fill=\"\";",
              WebChart1.ClientID + "_chart.panel.margins.bottom = 10;",
              WebChart1.ClientID + "_chart.axes.bottom.labels.ongetlabel=function(value,s) {",
              "  return s.replace(\" \",\"\\n\");",
              "}",

              "Series1.higher.gradient.visible = false;",
              "Series1.lower.gradient.visible = false;",
              "Series1.lower.fill="+ WebChart1.ClientID + "_chart.palette.colors[1];",

              "var startupRange = "+WebChart1.ClientID + "_chart.series.items[0].data.x["+WebChart1.ClientID + "_chart.series.items[0].count()-1] - "+WebChart1.ClientID + "_chart.series.items[0].data.x[0]",
              "STARTAXISMIN = Date.parse(" +WebChart1.ClientID + "_chart.series.items[0].data.x[0]) + (startupRange / 4)",
              "STARTAXISMAX = Date.parse(" +WebChart1.ClientID + "_chart.series.items[0].data.x["+WebChart1.ClientID + "_chart.series.items[0].count()-1]) - (startupRange / 4)",
              WebChart1.ClientID + "_chart.axes.bottom.setMinMax(STARTAXISMIN,STARTAXISMAX);",

              "// After zoom reset, set again a portion of horizontal axis:",
              WebChart1.ClientID + "_chart.zoom.onreset=function() {",
              "  "+ WebChart1.ClientID + "_chart.axes.bottom.setMinMax(STARTAXISMIN, STARTAXISMAX);",
              "}",

              "// Set mouse zooming and vertical scroll:",
              WebChart1.ClientID + "_chart.zoom.enabled=true;",
              WebChart1.ClientID + "_chart.zoom.mouseButton=2;",
              WebChart1.ClientID + "_chart.zoom.direction=\"horizontal\";",

              WebChart1.ClientID + "_chart.scroll.direction=\"horizontal\";",
              WebChart1.ClientID + "_chart.scroll.mouseButton=0;",
              
              WebChart1.ClientID + "_chart.axes.bottom.labels.dateFormat=\"shortDate\";",
              WebChart1.ClientID + "_chart.title.visible = false;",
              "// annotation (alternative title)",
              "a1=new Tee.Annotation(" + WebChart1.ClientID + "_chart);",
              "a1.format.fill = \"rgba(0,0,0,0.0)\";",
              "a1.format.stroke.fill=\"rgba(0,0,0,0.0)\";",
              "a1.format.font.style=\"20px Tahoma\";",
              "a1.format.font.fill = \"rgba(0,0,0,0.6)\";",
              "a1.text=\""+ch1.Header.Text+"\";",
              "" + WebChart1.ClientID + "_chart.draw();  //get position",
              "a1.position.x = " + WebChart1.ClientID + "_chart.axes.bottom.calc(" + WebChart1.ClientID + "_chart.axes.bottom.minimum);",
              "a1.position.y = 8;"
            
            };
            ch1.Export.Image.JScript.CustomCode = customCode;

		}

	}
}
