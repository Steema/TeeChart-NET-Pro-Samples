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
using System.Timers;

namespace WebDemo.Chart_Styles.Other
{
	/// <summary>
	/// Summary description for ClockChart.
	/// </summary>
	public partial class ClockChart : System.Web.UI.Page
	{
		private Steema.TeeChart.Styles.Clock clockSeries1;
		private Steema.TeeChart.Chart ch1;
		private static bool IsRoman;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			SetClockStyle();
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			InitializeChart();
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

		private void SetClockStyle() 
		{
			if (IsRoman)
			{
				this.clockSeries1.Style = Steema.TeeChart.Styles.ClockStyles.Roman;
			}
			else
			{
				this.clockSeries1.Style = Steema.TeeChart.Styles.ClockStyles.Decimal;
			}		
			CheckBox1.Checked = IsRoman;
		}

		private void InitializeChart() 
		{
			ch1=WebChart1.Chart;
			ch1.Series.RemoveAllSeries();			
			ch1.Series.Add(clockSeries1=new Steema.TeeChart.Styles.Clock());
			// Apply palette
			//Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(ch1.Chart,9);
		}

		protected void CheckBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			IsRoman = !IsRoman;
		}
	}
}
