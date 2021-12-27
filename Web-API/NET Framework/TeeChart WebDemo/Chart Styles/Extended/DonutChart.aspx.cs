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

namespace WebDemo.Chart_Styles.Extended
{
	/// <summary>
	/// Summary description for DonutChart.
	/// </summary>
	public partial class DonutChart : System.Web.UI.Page
	{
		private Steema.TeeChart.Styles.Donut donut1;
		private Steema.TeeChart.Chart ch1;

	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			ch1=WebChart1.Chart;
			ch1.Series.RemoveAllSeries();			
			ch1.Series.Add(donut1=new Steema.TeeChart.Styles.Donut());
			this.donut1.FillSampleValues(8);
			this.donut1.DonutPercent = Convert.ToInt32(TextBox1.Text);		
			this.donut1.Pen.Color = Color.DarkGray;
      this.donut1.Circled = true;

      this.donut1.Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.WithPointer;
      this.donut1.Marks.Color = Color.White;
      this.donut1.Marks.Frame.Color = Color.LightGray;
      this.donut1.Marks.Arrow.Visible = false;

      // Apply palette
      //Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(ch1.Chart,4);
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

		protected void Button2_Click(object sender, System.EventArgs e)
		{
			this.donut1.DonutPercent = Convert.ToInt32(TextBox1.Text);
		}
	}
}
