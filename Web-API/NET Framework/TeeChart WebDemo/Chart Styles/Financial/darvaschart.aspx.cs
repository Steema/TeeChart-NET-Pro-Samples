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
  /// Summary description for DarvasChart.
	/// </summary>
	public partial class DarvasChart : System.Web.UI.Page
	{
    private Steema.TeeChart.Styles.Candle candle1;
    private Steema.TeeChart.Styles.Darvas darvas1;
		private Steema.TeeChart.Chart ch1;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
      ch1 = WebChart1.Chart;
      ch1.Series.Add(candle1 = new Steema.TeeChart.Styles.Candle());
      ch1.Series.Add(darvas1 = new Steema.TeeChart.Styles.Darvas());

      candle1.FillSampleValues(100);

      for (int i = 0; i < candle1.Count; i++)
      {
        darvas1.Add(candle1.DateValues[i], candle1.OpenValues[i], candle1.HighValues[i], candle1.LowValues[i], candle1.CloseValues[i]);
      }
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
