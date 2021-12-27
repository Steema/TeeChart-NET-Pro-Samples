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
	/// Summary description for VHBoxPlotChart.
	/// </summary>
	public partial class VHBoxPlotChart : System.Web.UI.Page
	{
	
    private void setVisAxis(bool vert)
    {
      WebChart1.Chart.Axes.Left.AxisPen.Visible = !vert;
      WebChart1.Chart.Axes.Bottom.AxisPen.Visible = vert;
    }

		protected void Page_Load(object sender, System.EventArgs e)
		{
      Steema.TeeChart.Styles.CustomBox cb1 = new Steema.TeeChart.Styles.CustomBox();
      Steema.TeeChart.Styles.CustomBox cb2 = new Steema.TeeChart.Styles.CustomBox();
      Steema.TeeChart.Styles.CustomBox cb3 = new Steema.TeeChart.Styles.CustomBox();

      WebChart1.Chart.Series.RemoveAllSeries();
			switch (DropDownList1.SelectedIndex)
			{
				case 0:
					WebChart1.Chart.Series.Add(cb1 = new Steema.TeeChart.Styles.Box());
          WebChart1.Chart.Series.Add(cb2 = new Steema.TeeChart.Styles.Box());
          WebChart1.Chart.Series.Add(cb3 = new Steema.TeeChart.Styles.Box());
          setVisAxis(true);
          break;
				case 1:
					WebChart1.Chart.Series.Add(cb1 = new Steema.TeeChart.Styles.HorizBox());
          WebChart1.Chart.Series.Add(cb2 = new Steema.TeeChart.Styles.HorizBox());
          WebChart1.Chart.Series.Add(cb3 = new Steema.TeeChart.Styles.HorizBox());
          setVisAxis(false);
          break;
			}

      cb1.Position = 0;
      cb2.Position = 1;
      cb3.Position = 2;

      cb1.Title = "First Box";
      cb2.Title = "Second Box";
      cb3.Title = "Third Box";

      cb1.Quartile3 = 10;

      Color[] colors = Steema.TeeChart.Themes.ColorPalettes.GetPalette(9);

      cb1.Pointer.Brush.Color = colors[0];
      cb1.Pointer.Pen.Color = cb1.Pointer.Brush.Color;
      cb2.Pointer.Brush.Color = colors[1];
      cb2.Pointer.Pen.Color = cb2.Pointer.Brush.Color;
      cb3.Pointer.Brush.Color = colors[2];
      cb3.Pointer.Pen.Color = cb3.Pointer.Brush.Color;

      //cb1.Add(new double[6] { 3, 6, 8, 11, 14, 19 });
      cb1.FillSampleValues();
      cb2.Add(new double[6] { -12, 5, 7, 12, 19, 27 });
      cb3.Add(new double[7] { 1, 6, 7, 8, 15, 20, 29 });

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
	}
}
