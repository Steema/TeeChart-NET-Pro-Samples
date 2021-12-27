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

namespace WebDemo.Interacting_with_Charts.Drill_Down
{
	/// <summary>
	/// Summary description for DrillDownWithPreviewChart.
	/// </summary>
	public partial class DrillDownWithPreviewChart : System.Web.UI.Page
	{

	
		protected void Page_Load(object sender, System.EventArgs e)
		{

      Chart ch1 = WebChart1.Chart;

      Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(ch1, 9);
      Steema.TeeChart.Tools.SeriesHotspot hotspot1 = new Steema.TeeChart.Tools.SeriesHotspot();
      ch1.Legend.Visible = false;
      ch1.Tools.Add(hotspot1);
      hotspot1.MapAction = Steema.TeeChart.Styles.MapAction.Script;

      hotspot1.GetHTMLMap += new Steema.TeeChart.Tools.SeriesHotspotEventHandler(hotspot1_GetHTMLMap);

      ch1.Series.Add(new Steema.TeeChart.Styles.HorizBar());

      // Add sample Data
      ch1.Series[0].Add(105, "Flats");
      ch1.Series[0].Add(53, "Houses");
      ch1.Series[0].Add(71, "Parkings");
      ch1.Series[0].Add(32, "Premises");



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

		private void hotspot1_GetHTMLMap(Steema.TeeChart.Tools.SeriesHotspot sender, Steema.TeeChart.Tools.SeriesHotspotEventArgs e)
		{
			//This example calls a Bar Series but e.Series and e.PointPolygon.ValueIndex could be sent
			//as arguments for a drilldown query.

			//The prepared HelperScriptAnnotation text accepts your text as a variable for the Annotation
			//In the following case it calls an aspx script to generate and return a Chart as an image
			e.PointPolygon.Attributes=String.Format(Texts.HelperScriptAnnotation,
                                "<IMG SRC=ShowSeries.aspx?seriestype=Bar&view=False&width=100&height=80>");

			//The annotation could, alternatively, present text in the mouseover hint, eg.:
			//e.PointPolygon.Attributes=String.Format(Steema.TeeChart.Texts.HelperScriptAnnotation,"hello world.");
		}
	}
}
