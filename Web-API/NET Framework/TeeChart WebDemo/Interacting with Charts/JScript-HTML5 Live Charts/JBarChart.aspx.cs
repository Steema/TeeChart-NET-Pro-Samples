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
    /// Summary description for JBarChart1.
	/// </summary>
	public partial class JBarChart1 : System.Web.UI.Page
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
			Steema.TeeChart.Chart ch1=WebChart1.Chart;
            ch1.Panel.BorderRound = 4;
            ch1.Panel.Shadow.Visible = false;
            ch1.Panel.Pen.Visible = false;
			ch1.Series.RemoveAllSeries();
			ch1.Series.Add(new Steema.TeeChart.Styles.Bar());
            ch1.Series.Add(new Steema.TeeChart.Styles.Bar());
            //((Steema.TeeChart.Styles.Bar)(ch1.Series[0])).ColorEach = true;
			ch1.Series[0].FillSampleValues(3);
            ch1.Series[1].FillSampleValues(3);
            ch1.Series[0].Marks.Visible = false;
            ch1.Series[1].Marks.Visible = false;
			ch1.Legend.Shadow.Visible = false;
			ch1.Legend.Visible = false;
			// Apply theme
            //Steema.TeeChart.Themes.Theme.ApplyFromResource(ch1.Chart, "BlackIsBackTheme");

            //apply some custom code, runs just before Javascript Chart draw
            //string[] customCode = new string[] {};
            //ch1.Export.Image.JScript.CustomCode = customCode;

		}

	}
}
