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

namespace WebDemo.Chart_Styles.Extended
{
	/// <summary>
	/// Summary description for PolarChart.
	/// </summary>
	public partial class PolarChart : System.Web.UI.Page
	{
		private Steema.TeeChart.Styles.Polar polarSeries1;
		private Steema.TeeChart.Styles.Polar polarSeries2;
		private Steema.TeeChart.Styles.Polar polarSeries3;
		private Steema.TeeChart.Chart ch1;

	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			ch1=WebChart1.Chart;
			ch1.Series.RemoveAllSeries();			
			ch1.Series.Add(polarSeries1=new Steema.TeeChart.Styles.Polar());
			ch1.Series.Add(polarSeries2=new Steema.TeeChart.Styles.Polar());
			ch1.Series.Add(polarSeries3=new Steema.TeeChart.Styles.Polar());
			this.polarSeries1.Circled = true;
			this.polarSeries2.Circled = true;
			this.polarSeries3.Circled = true;
			this.polarSeries1.FillSampleValues(5);
			this.polarSeries2.FillSampleValues(7);
			this.polarSeries3.FillSampleValues(8);

			// Apply palette
			//Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(ch1.Chart,9);

			this.polarSeries1.Transparency = Convert.ToInt32(TextBox1.Text);
			this.polarSeries2.Transparency = Convert.ToInt32(TextBox2.Text);
			this.polarSeries3.Transparency = Convert.ToInt32(TextBox3.Text);

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

		protected void Button2_Click(object sender, System.EventArgs e)
		{
		}
	}
}
