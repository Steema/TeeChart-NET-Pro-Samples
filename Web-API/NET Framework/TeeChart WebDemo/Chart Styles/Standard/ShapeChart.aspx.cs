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
	/// Summary description for ShapeChart.
	/// </summary>
	public partial class ShapeChart : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			Steema.TeeChart.Chart ch1=WebChart1.Chart;
      Steema.TeeChart.Styles.Shape plugin;
      Steema.TeeChart.Styles.Shape cpu;


      ch1.Series.RemoveAllSeries();

			ch1.Series.Add(plugin = new Steema.TeeChart.Styles.Shape());
			ch1.Series.Add(cpu = new Steema.TeeChart.Styles.Shape());
      ch1.Series.Add(new Steema.TeeChart.Styles.Shape());
      ch1.Series.Add(new Steema.TeeChart.Styles.Shape());
			plugin.FillSampleValues();
			cpu.FillSampleValues();

      ch1.Series[2].FillSampleValues();
      ch1.Series[3].FillSampleValues();

      //bounding co-ordinates
      plugin.Style = Steema.TeeChart.Styles.ShapeStyles.Circle;
      plugin.X0 = 5;
      plugin.X1 = 25;
      plugin.Y0 = 5;
      plugin.Y1 = 25;

      plugin.Brush.Image = System.Drawing.Image.FromFile(this.Page.MapPath("../../images/maq.png"));

      cpu.Style = Steema.TeeChart.Styles.ShapeStyles.Rectangle;
      cpu.X0 = 11;
      cpu.X1 = 19;
      cpu.Y0 = 10;
      cpu.Y1 = 20;

      cpu.Brush.Image = System.Drawing.Image.FromFile(this.Page.MapPath("../../images/chip.png"));
      cpu.Pen.Visible = false;

      (ch1.Series[2] as Steema.TeeChart.Styles.Shape).Style = Steema.TeeChart.Styles.ShapeStyles.InvertTriangle;
      (ch1.Series[3] as Steema.TeeChart.Styles.Shape).Style = Steema.TeeChart.Styles.ShapeStyles.Diamond;
      (ch1.Series[3] as Steema.TeeChart.Styles.Shape).Brush.Gradient.Visible = true;


      ch1.Legend.Shadow.Visible = false;
			ch1.Legend.Visible = false;

			foreach (Steema.TeeChart.Styles.Shape sh in WebChart1.Chart.Series)
				sh.Transparent = CheckBox1.Checked;


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

		protected void CheckBox1_CheckedChanged(object sender, System.EventArgs e)
		{
		}
	}
}
