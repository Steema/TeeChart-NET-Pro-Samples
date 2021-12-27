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

			Steema.TeeChart.Styles.ActivityGauge aGauge = new Steema.TeeChart.Styles.ActivityGauge();

			ch1.Series.Add(aGauge);
			ch1.Series[0].FillSampleValues(4);
			aGauge.Pen.Color = Color.White;
			aGauge.Pen.Width = 3;

			ch1.Legend.Shadow.Visible = false;
			ch1.Legend.Visible = false;

			ch1.Export.Image.JScript.SourceUnits.Add("teechart-animations.js");

			//apply some custom code, runs just before Javascript Chart draw
			string[] customCode = new string[] {
			 
			      //animation
						"animation = new Tee.SeriesAnimation();",
						"animation.duration = 900;",
						"animation.kind = \"each\";",
						"fadeAnimation = new Tee.FadeAnimation();",
						"fadeAnimation.duration = 500;",
						"fadeAnimation.fade.series = true;",
						"fadeAnimation.fade.marks = true;",
						"animation.mode = \"linear\";",
						"fadeAnimation.mode = \"linear\";",
						"animation.items.push(fadeAnimation);",

						"animation.animate("+WebChart1.ClientID + "_chart);",

						"var annot=new Tee.Annotation(" + WebChart1.ClientID + "_chart); ",
						"annot.position.x = 25;",
						"annot.position.y = 250;",
						"annot.text=\"TeeChart Activity Gauge.\\nSteema Software\";",
						"annot.format.fill = \"rgba(0,0,0,0.0)\";",
						"annot.format.stroke.fill = \"rgba(0,0,0,0.0)\";",
						WebChart1.ClientID + "_chart.tools.add(annot);",

					};

			ch1.Export.Image.JScript.CustomCode = customCode;

		}

	}
}
