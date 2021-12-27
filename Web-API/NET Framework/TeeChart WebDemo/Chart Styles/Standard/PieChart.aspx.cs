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
	/// Summary description for PieChart.
	/// </summary>
	public partial class PieChart : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			//WebChart1.Chart.Panel.BorderRound = 30;
			Steema.TeeChart.Chart ch1=WebChart1.Chart;	
			ch1.Series.RemoveAllSeries();
			ch1.Series.Add(new Steema.TeeChart.Styles.Pie());
			
      Steema.TeeChart.Styles.Pie pie = (ch1.Series[0] as Steema.TeeChart.Styles.Pie);

      pie.Circled = true;
      pie.Pen.Visible = false;
      pie.BevelPercent = 30;
      pie.EdgeStyle = Steema.TeeChart.Drawing.EdgeStyles.Curved;

      pie.Marks.Pen.Visible = true;
     // pie.Marks.Transparency = 30;
      pie.Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.WithPointer;
      pie.Marks.Arrow.Visible = false;
      pie.Marks.ArrowLength = 20;
      pie.Marks.Color = Color.White;

      ch1.Series[0].FillSampleValues();			
			ch1.Legend.Shadow.Visible = false;
			ch1.Legend.Visible = false;
			
			// Apply palette
			Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(ch1.Chart,13);
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
