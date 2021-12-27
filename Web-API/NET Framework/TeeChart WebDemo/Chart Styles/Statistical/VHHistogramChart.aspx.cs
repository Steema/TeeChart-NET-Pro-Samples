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

namespace WebDemo.Chart_Styles.Statistical
{
	/// <summary>
	/// Summary description for Histogram.
	/// </summary>
	public partial class Histogram : System.Web.UI.Page
	{
		protected Steema.TeeChart.Styles.Histogram histogram1;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			DropDownList1_SelectedIndexChanged(sender,e);
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			// Apply palette
			//Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(WebChart1.Chart,9);			

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

		protected void DropDownList1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			WebChart1.Chart.Series.RemoveAllSeries();
			switch (DropDownList1.SelectedIndex)
			{
				case 0:
					WebChart1.Chart.Series.Add(new Steema.TeeChart.Styles.Histogram());			
					(WebChart1.Chart.Series[0]as Steema.TeeChart.Styles.Histogram).LinesPen.Color = WebChart1.Chart.Series[0].Color;
					(WebChart1.Chart.Series[0]as Steema.TeeChart.Styles.Histogram).LinePen.Visible = false;
					break;
				case 1:
					WebChart1.Chart.Series.Add(new Steema.TeeChart.Styles.HorizHistogram());
					(WebChart1.Chart.Series[0]as Steema.TeeChart.Styles.HorizHistogram).LinesPen.Color = WebChart1.Chart.Series[0].Color;
					(WebChart1.Chart.Series[0]as Steema.TeeChart.Styles.HorizHistogram).LinePen.Visible = false;
					break;
			}			
			WebChart1.Chart.Series[0].FillSampleValues();										
		}
	}
}
