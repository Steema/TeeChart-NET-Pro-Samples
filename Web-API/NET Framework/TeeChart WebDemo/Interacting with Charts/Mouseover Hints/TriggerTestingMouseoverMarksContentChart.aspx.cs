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

namespace WebDemo.Interacting_with_Charts.Mouseover_Hints
{
	/// <summary>
	/// Summary description for CustomizingDefaultImageMapsChart.
	/// </summary>
	public partial class CustomizingDefaultImageMapsChart : System.Web.UI.Page
	{
		protected Steema.TeeChart.Tools.SeriesHotspot seriesHotspot1;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			WebChart1.Chart.Series.Add (new Steema.TeeChart.Styles.Gantt());			
			(WebChart1.Chart.Series[0] as Steema.TeeChart.Styles.Gantt).Add(DateTime.Today.AddDays(-3),DateTime.Today.AddDays(10),0,"Project 1");
			(WebChart1.Chart.Series[0] as Steema.TeeChart.Styles.Gantt).Add(DateTime.Today.AddDays(-5),DateTime.Today.AddDays(2),1,"Project 2");
			(WebChart1.Chart.Series[0] as Steema.TeeChart.Styles.Gantt).Add(DateTime.Today,DateTime.Today.AddDays(5),2,"Project 3");
			(WebChart1.Chart.Series[0] as Steema.TeeChart.Styles.Gantt).Add(DateTime.Today.AddDays(-1),DateTime.Today.AddDays(3),3,"Project 4");
			(WebChart1.Chart.Series[0] as Steema.TeeChart.Styles.Gantt).Add(DateTime.Today.AddDays(-7),DateTime.Today.AddDays(8),4,"Project 5");
			(WebChart1.Chart.Series[0] as Steema.TeeChart.Styles.Gantt).Add(DateTime.Today.AddDays(-6),DateTime.Today.AddDays(1),5,"Project 6");

			(WebChart1.Chart.Series[0] as Steema.TeeChart.Styles.Gantt).Pointer.Pen.Visible = false;

			// Apply palette
			//Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(WebChart1.Chart,9);
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();

			//Associate the Chart's Hotspot event with function
			((Steema.TeeChart.Tools.SeriesHotspot)(WebChart1.Chart.Tools[0])).GetHTMLMap += 
				new Steema.TeeChart.Tools.SeriesHotspotEventHandler(hotspot1_GetHTMLMap);

			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.seriesHotspot1 = new Steema.TeeChart.Tools.SeriesHotspot();
			// 
			// seriesHotspot1
			// 
			this.seriesHotspot1.HelperScript = Steema.TeeChart.Tools.HotspotHelperScripts.Annotation;
			this.seriesHotspot1.HotspotCanvasIndex = 499;
			this.seriesHotspot1.MapAction = Steema.TeeChart.Styles.MapAction.Mark;
			this.seriesHotspot1.MapElements = "";

		}
		#endregion

		private void hotspot1_GetHTMLMap(Steema.TeeChart.Tools.SeriesHotspot sender, Steema.TeeChart.Tools.SeriesHotspotEventArgs e)
		{			
			if (RadioButtonList1.Items[1].Selected)	
			{
				int days = Convert.ToInt32((WebChart1.Chart.Series[0] as Steema.TeeChart.Styles.Gantt).EndValues[e.PointPolygon.ValueIndex] - DateTime.Now.ToOADate());
				switch (days)
				{
					case 0: e.PointPolygon.Title = "on the last day!"; break;
					case 1: e.PointPolygon.Title = "1 Day left!"; break;
					case 2:
					case 3:	e.PointPolygon.Title = (int)days + " Days left!!!"; break;
				}
			}
		}
	}
}
