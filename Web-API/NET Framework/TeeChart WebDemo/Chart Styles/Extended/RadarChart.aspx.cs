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
	/// Summary description for RadarChart.
	/// </summary>
	public partial class RadarChart : System.Web.UI.Page
	{
		private Steema.TeeChart.Styles.Radar radar1;
		private Steema.TeeChart.Styles.Radar radar2;
		private Steema.TeeChart.Styles.Radar radar3;
		private Steema.TeeChart.Chart ch1;

	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			ch1=WebChart1.Chart;
			ch1.Series.RemoveAllSeries();			
			ch1.Series.Add(radar1=new Steema.TeeChart.Styles.Radar());
			ch1.Series.Add(radar2=new Steema.TeeChart.Styles.Radar());
			ch1.Series.Add(radar3=new Steema.TeeChart.Styles.Radar());
			foreach (Steema.TeeChart.Styles.Series s in ch1.Series) 
			{
				(s as Steema.TeeChart.Styles.Radar).Circled = true;
				s.FillSampleValues(5);
			}

			// Apply palette
			//Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(ch1.Chart,9);

			radar1.CircleLabels = CheckBox1.Checked;

      radar1.Circled = CheckBox4.Checked;
      radar2.Circled = CheckBox4.Checked;
      radar3.Circled = CheckBox4.Checked;

			radar1.Pen.Visible = CheckBox2.Checked;
			radar2.Pen.Visible = CheckBox2.Checked;
			radar3.Pen.Visible = CheckBox2.Checked;	

			radar1.Pen.Visible = CheckBox2.Checked;
			radar2.Pen.Visible = CheckBox2.Checked;
			radar3.Pen.Visible = CheckBox2.Checked;

			ch1.Axes.Right.Visible = CheckBox3.Checked;
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

	}
}
