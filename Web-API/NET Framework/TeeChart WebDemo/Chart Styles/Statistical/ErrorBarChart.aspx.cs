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

namespace WebDemo.Chart_Styles.Statistical
{
	/// <summary>
	/// Summary description for ErrorBar.
	/// </summary>
	public partial class ErrorBar : System.Web.UI.Page
	{
		private Steema.TeeChart.Chart ch1;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			ch1=WebChart1.Chart;
      ch1.Series.RemoveAllSeries();
      ch1.Series.Add(new Steema.TeeChart.Styles.ErrorBar());

			(ch1.Series[0] as Steema.TeeChart.Styles.ErrorBar).Add(0, 50, 10, "A");
			(ch1.Series[0] as Steema.TeeChart.Styles.ErrorBar).Add(1, 80, 20, "B");
			(ch1.Series[0] as Steema.TeeChart.Styles.ErrorBar).Add(2, 20,  8, "C");
			(ch1.Series[0] as Steema.TeeChart.Styles.ErrorBar).Add(3, 60, 30, "D");
			(ch1.Series[0] as Steema.TeeChart.Styles.ErrorBar).Add(4, 40,  5, "E");
			
			ch1.Aspect.View3D=CheckBox1.Checked;
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
