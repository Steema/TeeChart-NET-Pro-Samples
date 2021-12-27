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
	/// Summary description for WaterfallChart.
	/// </summary>
	public partial class WaterfallChart : System.Web.UI.Page
	{

		protected void Page_Load(object sender, System.EventArgs e)
		{
      Chart ch1 = WebChart1.Chart;
      ch1.Aspect.View3D = true;
      ch1.Series.RemoveAllSeries();
      ch1.Series.Add(new Steema.TeeChart.Styles.Waterfall());
      ch1[0].FillSampleValues();
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
