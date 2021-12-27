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
	/// Summary description for FastLineChart.
	/// </summary>
	public partial class FastLineChart : System.Web.UI.Page
	{
		private Steema.TeeChart.Styles.FastLine fastLine1;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
      WebChart1.Chart.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.None;
      WebChart1.Chart.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;

      fastLine1 = new Steema.TeeChart.Styles.FastLine();
			WebChart1.Chart.Series.Add(fastLine1);			
			double[]	yValues = {10,15,20,2,23,63,33,1,33,77,94,65,45,23,32,4,54,2,18,21,80,67,45,32,3,10,56,13,52, 23, 72, 66, 32, 54, 74, 21, 86, 15};
			fastLine1.Add(yValues);
			
	//    Set some nulls - optional demo
	//		fastLine1.SetNull( 13 );
	//		fastLine1.SetNull( 25 );
	//		fastLine1.SetNull( 40 );

	//		fastLine1.IgnoreNulls = true;
			fastLine1.Stairs = true;

			// Apply palette
			//Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(WebChart1.Chart,9);
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

		protected void CBStairs_CheckedChanged(object sender, System.EventArgs e)
		{
			fastLine1.Stairs = CBStairs.Checked;
			CBInverted.Enabled = fastLine1.Stairs;
//			fastLine1.IgnoreNulls = CBIgNoreNulls.Checked;
		}

		protected void CBInverted_CheckedChanged(object sender, System.EventArgs e)
		{
			fastLine1.InvertedStairs = CBInverted.Checked;
//			fastLine1.IgnoreNulls = CBIgNoreNulls.Checked;
		}

		protected void CBIgNoreNulls_CheckedChanged(object sender, System.EventArgs e)
		{
//			fastLine1.IgnoreNulls = CBIgNoreNulls.Checked;
			fastLine1.Stairs = CBStairs.Checked;
		}
	}
}
