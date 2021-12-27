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
	/// Summary description for GetAxisLabel.
	/// </summary>
	public partial class GetAxisLabelChart : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			Steema.TeeChart.Chart ch1=WebChart1.Chart;
			if (ch1.Series.Count<2)
			{
				ch1.Series.Add(new Steema.TeeChart.Styles.Area());
				ch1.Series.Add(new Steema.TeeChart.Styles.Area());
			}

			//appearance characteristics
			ch1.Series[0].Color=Color.FromArgb(255,199,26);
			ch1.Series[1].Color=Color.FromArgb(106,106,255);

			((Area)ch1.Series[0]).AreaLines.Visible=false;
			((Area)ch1.Series[1]).AreaLines.Visible=false;
			((Area)ch1.Series[1]).LinePen.Color=Color.FromArgb(79,79,255);
			((Area)ch1.Series[0]).MultiArea=MultiAreas.Stacked;

			ch1.Legend.Visible=false;
			ch1.Series[0].FillSampleValues(7);
			ch1.Series[1].FillSampleValues(7);
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
			this.WebChart1.GetAxisLabel += new Steema.TeeChart.GetAxisLabelEventHandler(this.WebChart1_GetAxisLabel);

		}
		#endregion

		private void WebChart1_GetAxisLabel(object sender, Steema.TeeChart.GetAxisLabelEventArgs e)
		{
			//example to show manipulation of the Axis Label Text at output time
			if ((Steema.TeeChart.Axis)sender==WebChart1.Chart.Axes.Bottom)
			{
				switch (e.LabelText.Substring(e.LabelText.Length-1,1))
				{
					case "0": e.LabelText="init. 0"; break;
					case "1": e.LabelText=e.LabelText+"st"; break;
					case "2": e.LabelText=e.LabelText+"nd"; break;
					case "3": e.LabelText=e.LabelText+"rd"; break;
					default: e.LabelText=e.LabelText+"th"; break;
				}
			}		
		}
	}
}
