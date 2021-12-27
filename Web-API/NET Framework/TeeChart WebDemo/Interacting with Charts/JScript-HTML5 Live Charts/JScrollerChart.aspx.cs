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
	public partial class JScrollerChart1 : System.Web.UI.Page
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
            ch1.Panel.Shadow.Visible = false;
            ch1.Panel.Pen.Visible = false;
			ch1.Series[0].FillSampleValues(100);
            ch1.Series[0].Marks.Visible = false;
			ch1.Legend.Visible = false;

            ch1.Export.Image.JScript.SourceUnits.Add("date.format.js");

            //apply some custom code, runs just before Javascript Chart draw
            string[] customCode = new string[] {
              "changeTheme(\"daybreak\");",
              "changePalette(\"onBlack\");",

              //Take Gradient off Candle so that it responds to palette changes
              WebChart1.ClientID + "_chart.series.items[0].higher.gradient.visible = false;",
							WebChart1.ClientID + "_chart.series.items[0].lower.gradient.visible = false;",
							WebChart1.ClientID + "_chart.series.items[0].lower.fill="+ WebChart1.ClientID + "_chart.palette.colors[1];",

							WebChart1.ClientID + "_chart.zoom.direction=\"horizontal\";",

              WebChart1.ClientID + "_chart.title.visible=false;",
  
              // annotation (alternative title)
              /*"var a1=new Tee.Annotation(" + WebChart1.ClientID + "_chart);",
              "a1.format.fill = \"rgba(0,0,0,0.0)\";",
              "a1.format.stroke.fill=\"rgba(0,0,0,0.0)\";",
              "a1.format.font.style=\"20px Tahoma\";",
              "a1.format.font.fill = \"rgba(0,0,0,0.6)\";",
              "a1.text=\"TeeChart Javascript Scroller\";",
              WebChart1.ClientID + "_chart.draw();",  //get position
              "a1.position.x = " + WebChart1.ClientID + "_chart.axes.bottom.calc(" + WebChart1.ClientID + "_chart.axes.bottom.minimum);",
              "a1.position.y = 8;",

              WebChart1.ClientID + "_chart.tools.add(a1);",*/

              WebChart1.ClientID + "_chart.axes.bottom.labels.dateFormat=\"shortDate\";",
              WebChart1.ClientID + "_chart.axes.bottom.labels.alternate=true;",

              "var x0="+WebChart1.ClientID + "_chart.series.items[0].data.x;",
              WebChart1.ClientID + "_chart.axes.bottom.setMinMax(x0[20].getTime(), x0[49].getTime());",

              "scroller.panel.transparent=false;",
              "scroller.panel.format.shadow.visible=false;",
              "scroller.panel.format.round.x=0;",
              "scroller.panel.format.round.y=0;",
              "scroller.panel.format.gradient.visible=true;",
              "if (" + WebChart1.ClientID + "_chart.panel.format.gradient.colors.length>1)",
              "  scroller.panel.format.gradient.colors=[" + WebChart1.ClientID + "_chart.panel.format.gradient.colors[0]," + WebChart1.ClientID + "_chart.panel.format.gradient.colors[1]];",
              "else",
              "  scroller.panel.format.gradient.colors=[\"white\"];",
              "scroller.panel.format.gradient.direction=\"topbottom\";",
              "scroller.panel.format.stroke.fill=\"rgba(204,204,204,1.0)\";",
              "scroller.panel.format.stroke.size = 0;",

              "scroller.onChanging=function(s,min,max) {",
              "    document.getElementById(\"data\").textContent=\"Showing data from \"+new Date(min).toDateString()+\" to \"+new Date(max).toDateString();",
              "  }"
            };

            ch1.Export.Image.JScript.CustomCode = customCode;

		}

	}
}
