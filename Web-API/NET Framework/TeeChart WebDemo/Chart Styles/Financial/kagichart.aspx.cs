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
	/// Summary description for KagiChart.
	/// </summary>
	public partial class KagiChart : System.Web.UI.Page
	{
    private Steema.TeeChart.Styles.Kagi kagi1;
		private Steema.TeeChart.Chart ch1;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
      ch1=WebChart1.Chart;
      ch1.Series.Add(kagi1 = new Steema.TeeChart.Styles.Kagi());

      ch1.Axes.Bottom.Labels.Angle = 90;

      // 1st week
      kagi1.Add(20, "2006-08-21");
      kagi1.Add(14, "2006-08-22");
      kagi1.Add(15, "2006-08-23");
      kagi1.Add(10, "2006-08-24");
      kagi1.Add(12, "2006-08-25");

      // 2nd week 
      kagi1.Add(12, "2006-08-28");
      kagi1.Add(12, "2006-08-29");
      kagi1.Add(13, "2006-08-30");
      kagi1.Add(9, "2006-08-31");
      kagi1.Add(8, "2006-9-01");

      // customize axis labels, because Kagi is not aware of time scale
      Steema.TeeChart.AxisLabels labels = kagi1.GetHorizAxis.Labels;
      labels.Items.Clear();
      // these are dates when direction changes
      labels.Items.Add(0, "2006-08-21");
      labels.Items.Add(1, "2006-08-23");
      labels.Items.Add(2, "2006-08-24");
      labels.Items.Add(3, "2006-08-30");
      labels.Items.Add(4, "2006-09-01");
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
