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
	/// Summary description for VHBarChart.
	/// </summary>
	public partial class VHBarChart : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			Steema.TeeChart.Chart ch1=WebChart1.Chart;
      WebChart1.CurrentTheme = Steema.TeeChart.ThemeType.Report;
      WebChart1.Chart.Panel.Shadow.Visible = false;
      WebChart1.Chart.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.None;
      WebChart1.Chart.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
      ch1.Legend.Shadow.Visible = false;
			ch1.Legend.Visible = false;
			DropDownList1_SelectedIndexChanged(sender,e);
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
			WebChart1.Chart.Series.RemoveAllSeries();
			switch (DropDownList1.SelectedIndex)
			{
				case 0:
					WebChart1.Chart.Series.Add(new Steema.TeeChart.Styles.Bar());
          WebChart1.Chart.Series.Add(new Steema.TeeChart.Styles.Bar());
          break;
				case 1:
					WebChart1.Chart.Series.Add(new Steema.TeeChart.Styles.HorizBar());
          WebChart1.Chart.Series.Add(new Steema.TeeChart.Styles.HorizBar());
          break;
			}

      WebChart1.CurrentTheme = Steema.TeeChart.ThemeType.Report;

     // Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(WebChart1.Chart, 21);

      WebChart1.Chart.Series[0].FillSampleValues(4);
      WebChart1.Chart.Series[1].FillSampleValues(4);

     /* WebChart1.Chart.Series[0].Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.WithPointer;
      WebChart1.Chart.Series[1].Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.WithPointer;

      WebChart1.Chart.Series[0].Marks.Color = Color.White;
      WebChart1.Chart.Series[1].Marks.Color = Color.White;*/
    }

	}
}
