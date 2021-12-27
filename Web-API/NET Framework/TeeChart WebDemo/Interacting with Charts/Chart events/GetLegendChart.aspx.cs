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
using Steema.TeeChart.Web;
using Steema.TeeChart.Styles;

namespace WebDemo.Interacting_with_Charts.Chart_events
{
	/// <summary>
	/// Summary description for GetLegendChart.
	/// </summary>
	public partial class GetLegendChart : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			Steema.TeeChart.Chart ch1=WebChart1.Chart;
			if (ch1.Series.Count<2)
			{
				ch1.Series.Add(new Steema.TeeChart.Styles.Line());
				ch1.Series.Add(new Steema.TeeChart.Styles.Line());
			}
			//appearance characteristics
			ch1.Series[0].Color=Color.FromArgb(255,199,26);
			ch1.Series[1].Color=Color.FromArgb(106,106,255);
			((Line)ch1.Series[0]).LinePen.Color=Color.FromArgb(210,173,0);
			((Line)ch1.Series[1]).LinePen.Color=Color.FromArgb(79,79,255);

			ch1.Legend.Alignment=Steema.TeeChart.LegendAlignments.Bottom;
			ch1.Series[0].FillSampleValues(5);
			ch1.Series[1].FillSampleValues(5);
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
			this.WebChart1.GetLegendText += new Steema.TeeChart.GetLegendTextEventHandler(this.WebChart1_GetLegendText);

		}
		#endregion

		private void WebChart1_GetLegendText(object sender, Steema.TeeChart.GetLegendTextEventArgs e)
		{
			if (e.Index==1)
				e.Text=e.Text+"(2nd)";		
		}
	}
}
