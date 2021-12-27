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

namespace WebDemo.Chart_Styles.Statistical
{
	/// <summary>
	/// Summary description for ColorGridChart.
	/// </summary>
	public partial class ColorGridChart : System.Web.UI.Page
	{
		private Steema.TeeChart.Styles.ColorGrid colorGrid1;
		private Steema.TeeChart.Chart ch1;

	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			ch1=WebChart1.Chart;
			ch1.Series.RemoveAllSeries();			
			ch1.Series.Add(colorGrid1=new Steema.TeeChart.Styles.ColorGrid());
			
			colorGrid1.FillSampleValues(Convert.ToInt32(TextBox1.Text));
			colorGrid1.UseColorRange = false;
			colorGrid1.UsePalette = true;			
			colorGrid1.Pen.Color=Color.DarkGray;
			
			if (Convert.ToInt32(TextBox1.Text) > 30)
			{
				CheckBox1.Checked = false;
				colorGrid1.Pen.Visible = false;
			}						
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

		protected void CheckBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			colorGrid1.Pen.Visible = CheckBox1.Checked;
		}
	}
}
