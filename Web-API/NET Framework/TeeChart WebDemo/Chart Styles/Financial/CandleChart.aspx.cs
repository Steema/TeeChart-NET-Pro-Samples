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

namespace WebDemo.Chart_Styles.Financial
{
	/// <summary>
	/// Summary description for CandleChart.
	/// </summary>
	public partial class CandleChart : System.Web.UI.Page
	{
		private Steema.TeeChart.Styles.Candle candleSeries1;
		private Steema.TeeChart.Chart ch1;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			ch1=WebChart1.Chart;
			ch1.Series.Add(candleSeries1= new Steema.TeeChart.Styles.Candle());
			candleSeries1.FillSampleValues();
			ch1.Legend.Visible = false;
      ch1.Axes.Bottom.Labels.Angle = 90;

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
			switch (DropDownList1.SelectedIndex)
			{
				case 0 : candleSeries1.Style = Steema.TeeChart.Styles.CandleStyles.CandleStick; break;
				case 1 : candleSeries1.Style = Steema.TeeChart.Styles.CandleStyles.CandleBar; break;
				case 2 : candleSeries1.Style = Steema.TeeChart.Styles.CandleStyles.OpenClose; break;
			}		
		}

		protected void CheckBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			candleSeries1.Pointer.Pen.Visible = CheckBox1.Checked;
		}

		protected void CheckBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			candleSeries1.Pointer.Draw3D = CheckBox2.Checked;
			ch1.Aspect.View3D = CheckBox2.Checked;
		}
	}
}
