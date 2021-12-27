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

namespace WebDemo.Interacting_with_Charts.Drill_Down
{
	/// <summary>
	/// Summary description for GenericUsageChart.
	/// </summary>
	public partial class GenericUsageChart : System.Web.UI.Page
	{
		protected Steema.TeeChart.Tools.SeriesHotspot seriesHotspot1;
		protected Steema.TeeChart.Tools.SeriesHotspot seriesHotspot2;
		private Steema.TeeChart.Chart ch1;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			Random rnd = new Random();
			ch1=WebChart1.Chart;
			for (int i=0;i<4;i++)
			{
				ch1.Series.Add(new Steema.TeeChart.Styles.Area());
				for (int ii=0;ii<8;ii++)
					ch1.Series[i].Add(1998+ii,rnd.Next(50));

				(ch1.Series[i] as Steema.TeeChart.Styles.Area).Stacked = Steema.TeeChart.Styles.CustomStack.Stack100;
				(ch1.Series[i] as Steema.TeeChart.Styles.Area).AreaLines.Visible = false;
				(ch1.Series[i] as Steema.TeeChart.Styles.Area).LinePen.Width = 2;
				(ch1.Series[i] as Steema.TeeChart.Styles.Area).LinePen.Color = Color.DarkGray;				
			}			
			ch1.Axes.Bottom.Labels.ValueFormat = "####";
			ch1.Axes.Bottom.Labels.Font.Bold = true;			
			ch1.Axes.Bottom.Labels.Angle = 90;		

			// Assign Titles to  the Series
			ch1.Series[0].Title = "Iberia";
			ch1.Series[1].Title = "British-Airways";
			ch1.Series[2].Title = "KLM";
			ch1.Series[3].Title = "Ryanair";

			// Apply palette
			//Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(ch1.Chart,9);			
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();

			((Steema.TeeChart.Tools.SeriesHotspot)(WebChart1.Chart.Tools[0])).GetHTMLMap += 
				new Steema.TeeChart.Tools.SeriesHotspotEventHandler(seriesHotspot1_GetHTMLMap);

			//Associate the Chart's Hotspot event with function
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.seriesHotspot1 = new Steema.TeeChart.Tools.SeriesHotspot();
			this.seriesHotspot2 = new Steema.TeeChart.Tools.SeriesHotspot();
			// 
			// seriesHotspot1
			// 
			this.seriesHotspot1.HelperScript = Steema.TeeChart.Tools.HotspotHelperScripts.Annotation;
			this.seriesHotspot1.HotspotCanvasIndex = 499;
			this.seriesHotspot1.MapAction = Steema.TeeChart.Styles.MapAction.URL;
			this.seriesHotspot1.MapElements = "";
			this.seriesHotspot1.GetHTMLMap += new Steema.TeeChart.Tools.SeriesHotspotEventHandler(this.seriesHotspot1_GetHTMLMap);
			// 
			// seriesHotspot2
			// 
			this.seriesHotspot2.HelperScript = Steema.TeeChart.Tools.HotspotHelperScripts.Annotation;
			this.seriesHotspot2.HotspotCanvasIndex = 499;
			this.seriesHotspot2.MapAction = Steema.TeeChart.Styles.MapAction.URL;
			this.seriesHotspot2.MapElements = "";

		}
		#endregion

		private void seriesHotspot1_GetHTMLMap(Steema.TeeChart.Tools.SeriesHotspot sender, Steema.TeeChart.Tools.SeriesHotspotEventArgs e)
		{
			if (CheckBox1.Checked)
				e.PointPolygon.Attributes="target='_blank'";
			else
				e.PointPolygon.Attributes="target='_self'";			
		
			if (e.Series==ch1.Series[0]) e.PointPolygon.HREF="http://" + TextBox1.Text;
			if (e.Series==ch1.Series[1]) e.PointPolygon.HREF="http://" + TextBox2.Text;
			if (e.Series==ch1.Series[2]) e.PointPolygon.HREF="http://" + TextBox3.Text;
			if (e.Series==ch1.Series[3]) e.PointPolygon.HREF="http://" + TextBox4.Text;
		}
	}
}
