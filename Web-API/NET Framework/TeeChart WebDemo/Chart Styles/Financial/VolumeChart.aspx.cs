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

namespace WebDemo.Chart_Styles.Financial
{
	/// <summary>
	/// Summary description for VolumeChart.
	/// </summary>
	public partial class VolumeChart : System.Web.UI.Page
	{
		private Steema.TeeChart.Styles.Volume volume1;
		private Steema.TeeChart.Chart ch1;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			ch1=WebChart1.Chart;
			ch1.Series.Add(volume1= new Steema.TeeChart.Styles.Volume());
			volume1.FillSampleValues();
			volume1.Origin = 33;

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
			volume1.UseOrigin=CheckBox1.Checked;
			if (CheckBox1.Checked)
			{
				volume1.Origin = Convert.ToInt32(TextBox1.Text);
				TextBox1.Enabled =true;
			}
			else
			{
				volume1.Origin = 0;
				TextBox1.Enabled = false;
			}				
		}
	}
}
