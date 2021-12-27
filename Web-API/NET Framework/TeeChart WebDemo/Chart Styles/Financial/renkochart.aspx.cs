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
	/// Summary description for Renko Chart.
	/// </summary>
  public partial class RenkoChart : System.Web.UI.Page
	{
    private Steema.TeeChart.Styles.Candle candle1;
    private Steema.TeeChart.Styles.Renko renko1;
		private Steema.TeeChart.Chart ch1;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
      ch1 = WebChart1.Chart;
      ch1.Series.Add(candle1 = new Steema.TeeChart.Styles.Candle());
      ch1.Series.Add(renko1 = new Steema.TeeChart.Styles.Renko());

      renko1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right;
      renko1.HorizAxis = Steema.TeeChart.Styles.HorizontalAxis.Top; 

      candle1.FillSampleValues(20);

      //// populate renko with closing values
      renko1.Clear();
      for (int i = 0; i < candle1.Count; i++)
        renko1.Add(candle1.CloseValues[i]);

      renko1.BoxSize = 5;
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
