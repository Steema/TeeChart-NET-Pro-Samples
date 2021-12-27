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
	/// Summary description for TowerChart.
	/// </summary>
	public partial class TowerChart : System.Web.UI.Page
	{
		private Steema.TeeChart.Styles.Tower tower1;
		private Steema.TeeChart.Chart ch1;

	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			ch1=WebChart1.Chart;
			ch1.Series.RemoveAllSeries();			
			ch1.Series.Add(tower1=new Steema.TeeChart.Styles.Tower());
			this.tower1.FillSampleValues();
			this.tower1.TowerStyle = (Steema.TeeChart.Styles.TowerStyles)this.DropDownList1.SelectedIndex;
			this.tower1.UseOrigin = this.CheckBox1.Checked;
			this.tower1.UseColorRange = false;
			this.tower1.UsePalette = true;

      tower1.Pen.Color = Color.DarkGray;

      // Apply palette
      //Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(ch1.Chart,9);
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
