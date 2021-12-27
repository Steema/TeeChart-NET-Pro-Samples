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
	public partial class JBarChart1 : System.Web.UI.Page
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
			ch1.Series.Add(new Steema.TeeChart.Styles.CircularGauge());
			ch1.Series[0].FillSampleValues(1);

			ch1.Legend.Shadow.Visible = false;
			ch1.Legend.Visible = false;

			//apply some custom code, runs just before Javascript Chart draw
			string[] customCode = new string[] {

						"Series1.ticksBack.radius=5;",

						"Series1.format.font.style = \"12px Arial\"; ",
						"Series1.format.font.fill = \"black\"; ",
						"Series1.format.font.shadow.visible = true;",

						"Series1.format.gradient.colors[1] = \"#999999\";",
						"Series1.format.gradient.colors[0] = \"#EEEEEE\";",
						"Series1.minorBack.visible=false;",
						"Series1.shape = \"rectangle\"; ",
						"Series1.bounds.custom=true;",
						"Series1.bounds.set(10, 0, 480, 280);",

						"Series1.ticks.outside=false;",
						"Series1.ticks.stroke.fill=\"gray\";",

						"Series1.bevel.gradient.direction=\"rightleft\";",
						"Series1.bevel.gradient.colors=[\"gray\",\"white\"];",
						"Series1.bevel.round.x=8;",
						"Series1.bevel.round.y=8;",
						"Series1.format.size=8;",
						"Series1.value=1.5;",
						"Series1.min=-10;",
						"Series1.max=3;",
						"Series1.step=1;",

						"Series1.ongetText=function(value) {",
						"return value < 0 ? value : \"+\"+value;",
						"}",

						"Series1.units.text=\"VU\";",
						"Series1.units.location.y=-10;",
						"Series1.units.format.font.fill=\"black\";",
						"Series1.units.format.font.style=\"16px Arial\";",
						"Series1.ticksBack.ranges=[ { value:0, fill:\"black\" }, { value:3, fill:\"red\" } ];",

						"Series1.back.gradient.colors[1]=\"#BBBBBB\";",
						"Series1.back.gradient.colors[0] = \"white\";",

						"Series1.back.round.x=8;",
						"Series1.back.round.y = 8;",
						"Series1.center.location.y=60;",
						"Series1.angle = 90;",
						"Series1.hand.size = 3;",
						"Series1.hand.back = 0;",
						"Series1.hand.length = 65;",
						"Series1.hand.gradient.colors[1] = \"black\";",
						"Series1.hand.gradient.direction = \"rightleft\";",

						"var annot=new Tee.Annotation(" + WebChart1.ClientID + "_chart); ",
						"annot.position.x = 25;",
						"annot.position.y = 250;",
						"annot.text=\"TeeChart Gauge. Steema Software\";",
						"annot.format.fill = \"rgba(0,0,0,0.0)\";",
						"annot.format.stroke.fill = \"rgba(0,0,0,0.0)\";",
			      WebChart1.ClientID + "_chart.tools.add(annot);",

			"setTimeout(modVal, 500);",

					};

			ch1.Export.Image.JScript.CustomCode = customCode;

		}

	}
}
