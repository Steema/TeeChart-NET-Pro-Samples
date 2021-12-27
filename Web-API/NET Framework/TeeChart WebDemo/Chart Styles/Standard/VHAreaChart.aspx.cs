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

namespace WebDemo.Chart_Styles.Standard
{
	/// <summary>
	/// Summary description for VHAreaChart.
	/// </summary>
	public partial class VHAreaChart : System.Web.UI.Page
	{
		private Steema.TeeChart.Chart ch1;

		protected void Page_Load(object sender, System.EventArgs e)
		{			
			ch1=WebChart1.Chart;	
			ch1.Series.RemoveAllSeries();
			ch1.Legend.Shadow.Visible = false;
			ch1.Legend.Visible = false;
			// Apply palette
			//Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(ch1.Chart,9);
			DropDownList1_SelectedIndexChanged(sender,e);
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

		private void DropDownList1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			WebChart1.Chart.Series.RemoveAllSeries();
			switch (DropDownList1.SelectedIndex)
			{
				case 0:
					WebChart1.Chart.Series.Add(new Steema.TeeChart.Styles.Area());
					(ch1.Series[0] as Steema.TeeChart.Styles.Area).AreaLines.Color = WebChart1.Chart.Series[0].Color;
          (ch1.Series[0] as Steema.TeeChart.Styles.Area).Transparency = 30;
					break;
				case 1:
					WebChart1.Chart.Series.Add(new Steema.TeeChart.Styles.HorizArea());
					(ch1.Series[0] as Steema.TeeChart.Styles.HorizArea).AreaLines.Color = WebChart1.Chart.Series[0].Color;
          (ch1.Series[0] as Steema.TeeChart.Styles.HorizArea).Transparency = 30;
					break;
			}
			WebChart1.Chart.Series[0].FillSampleValues();		
		}
	}
}