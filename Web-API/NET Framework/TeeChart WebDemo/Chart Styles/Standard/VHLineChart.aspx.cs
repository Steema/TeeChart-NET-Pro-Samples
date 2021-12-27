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

namespace WebDemo
{
	/// <summary>
	/// Summary description for VHLineChart1.
	/// </summary>
	public partial class VHLineChart1 : System.Web.UI.Page
	{

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

		protected void Page_Load(object sender, System.EventArgs e)
		{
			//WebChart1.Chart.Panel.BorderRound = 30;
			Steema.TeeChart.Chart ch1=WebChart1.Chart;	
			ch1.Series.RemoveAllSeries();

      //set current them at webchart level
      WebChart1.CurrentTheme = Steema.TeeChart.ThemeType.Report;
      WebChart1.Chart.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;

      ch1.Series.Add(fillChart(true));
      ch1.Series.Add(fillChart(true));

      foreach (Steema.TeeChart.Styles.Series s in ch1.Series)
        s.FillSampleValues();

      ch1.Legend.Shadow.Visible = false;
			ch1.Legend.Visible = false;
			// Apply palette
			//Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(ch1.Chart,9);
		}

    protected Steema.TeeChart.Styles.Series fillChart(bool vert)
    {
      Steema.TeeChart.Styles.Series line;

      if (vert)
      {
        line = new Steema.TeeChart.Styles.Line();
        ((Steema.TeeChart.Styles.Custom)(line)).Smoothed = true;
      }
      else
        line = new Steema.TeeChart.Styles.HorizLine();

      ((Steema.TeeChart.Styles.Custom)(line)).LinePen.Width = 2;

      return line;
    }

		protected void DropDownList1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			WebChart1.Chart.Series.RemoveAllSeries();
      WebChart1.CurrentTheme = Steema.TeeChart.ThemeType.Report;
      switch (DropDownList1.SelectedIndex)
			{
				case 0:
					WebChart1.Chart.Series.Add(fillChart(true));
          WebChart1.Chart.Series.Add(fillChart(true));
          break;
				case 1:
					WebChart1.Chart.Series.Add(fillChart(false));
          WebChart1.Chart.Series.Add(fillChart(false));
          break;
			}

      foreach (Steema.TeeChart.Styles.Series s in WebChart1.Chart.Series)
        s.FillSampleValues();
    }
	}
}
