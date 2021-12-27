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
//save data between calls
using System.IO;


namespace WebDemo.Interacting_with_Charts.SegmentingPies
{
	/// <summary>
	/// Summary description for SegmentingPiesChart.
	/// </summary>
	public partial class SegmentingPiesChart : System.Web.UI.Page
	{
		protected Steema.TeeChart.Tools.SeriesHotspot seriesHotspot1;
		private Steema.TeeChart.Styles.Pie pie1;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{  
			//WebChart1.GetChartFile="/WebDemo/GetChart.aspx";
			Steema.TeeChart.Chart ch1=WebChart1.Chart;
			// Add Serie and FillSampleValues to the Series
			ch1.Series.RemoveAllSeries();
			pie1 = new Steema.TeeChart.Styles.Pie();
			ch1.Series.Add(pie1);
			pie1.Add(20,"Ball");
			pie1.Add(10,"Racket");
			pie1.Add(30,"Skate");
			pie1.Add(15,"Cycle");
			pie1.Add(25,"Mat");
			pie1.Marks.Visible = false;
			pie1.Pen.Color = Color.DarkGray;
			pie1.CustomXRadius = 100;
			pie1.CustomYRadius = 100;
			ch1.Aspect.View3D = false;

			// Apply palette
			//Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(ch1.Chart,9);

			int index = Convert.ToInt32(Request.Params["index"]);
			pie1.ExplodedSlice[index] = 30;			

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
				new Steema.TeeChart.Tools.SeriesHotspotEventHandler(seriesHotspot1_GetHTMLMap);

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

		private void seriesHotspot1_GetHTMLMap(Steema.TeeChart.Tools.SeriesHotspot sender, Steema.TeeChart.Tools.SeriesHotspotEventArgs e)
		{		
			e.PointPolygon.Title = e.Series.Labels[e.PointPolygon.ValueIndex]+" "+ e.Series.YValues.Value[e.PointPolygon.ValueIndex].ToString();
			e.PointPolygon.HREF =Request.Path+"?index="+e.PointPolygon.ValueIndex;
		}

	}
}
