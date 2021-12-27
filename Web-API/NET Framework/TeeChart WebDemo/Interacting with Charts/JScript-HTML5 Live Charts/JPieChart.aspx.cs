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
    /// Summary description for JPieChart1.
	/// </summary>
	public partial class JPieChart1 : System.Web.UI.Page
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
			ch1.Series.Add(new Steema.TeeChart.Styles.Pie());
            ((Steema.TeeChart.Styles.Pie)(ch1.Series[0])).Pen.Width = 0;
			ch1.Series[0].FillSampleValues();			
			ch1.Legend.Shadow.Visible = false;
			ch1.Legend.Visible = false;

            //apply some custom code, runs just before Javascript Chart draw
            string[] customCode = new string[] {
              WebChart1.ClientID + "_chart.series.items[0].format.gradient.visible = false;",
              WebChart1.ClientID + "_chart.series.items[0].format.stroke.fill = \"white\";",
              WebChart1.ClientID + "_chart.series.items[0].format.shadow.visible=false;",
              "changeTheme(\"minimal\");",
              "changePalette(\"seaWash\");",
              "setMarksUnder(true);"
              };

            ch1.Export.Image.JScript.CustomCode = customCode;

		}

	}
}
