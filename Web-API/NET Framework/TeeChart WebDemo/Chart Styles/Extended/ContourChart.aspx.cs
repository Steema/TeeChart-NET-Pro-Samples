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
	/// Summary description for ContourChart.
	/// </summary>
	public partial class ContourChart : System.Web.UI.Page
	{
		private Steema.TeeChart.Styles.Contour contourSeries1;
		private Steema.TeeChart.Styles.Surface surfaceSeries1;

		private Steema.TeeChart.Chart ch1;


		// auxilary functions for populating series
		private double ToAngle(double val)
		{
			return (val+10.0)*Math.PI*0.1;
		}
		private double fun(int x, int z)
		{
			return 500*(Math.Sin(ToAngle(x))+Math.Pow(Math.Cos(z),2.0));
		}

		protected void Page_Load(object sender, System.EventArgs e)
		{
			ch1=WebChart1.Chart;
			ch1.Series.RemoveAllSeries();			
			ch1.Series.Add(contourSeries1=new Steema.TeeChart.Styles.Contour());
			ch1.Series.Add(surfaceSeries1=new Steema.TeeChart.Styles.Surface());

      WebChart1.Chart.Walls.Bottom.Height = 4;
      WebChart1.Chart.Walls.Left.Height = 4;

      contourSeries1.ColorEach = true;
      contourSeries1.CreateAutoLevels();

      contourSeries1.IrregularGrid = false;
			for (int x=-10;x<10;x++)
			{
				for (int z=-10;z<10;z++)
				{
					contourSeries1.Add(x,fun(x,z),z);
				}
			}
			/* 
			 * surfaceSeries1 displays the same data, 
			 * so let's connect it to contour series
			*/
			surfaceSeries1.DataSource = contourSeries1;
			surfaceSeries1.Visible = CheckBox5.Checked;

			// Then we specify how many "contour levels" we want 
			contourSeries1.NumLevels = 10;
			// initially, YPosition in the middle
			contourSeries1.YPosition = 0.5*(contourSeries1.YValues.Maximum + contourSeries1.YValues.Minimum);

			ch1.Aspect.View3D = !CheckBox1.Checked;
			CheckBox5.Enabled = ch1.Aspect.View3D;
      CheckBox4.Enabled = ch1.Aspect.View3D;
      ch1.Walls.Visible = CheckBox2.Checked;
			contourSeries1.ColorEach = CheckBox3.Checked;
			contourSeries1.YPositionLevel = CheckBox4.Checked;
			surfaceSeries1.Active = CheckBox5.Checked;

      if ((ch1.Aspect.View3D) && (!contourSeries1.YPositionLevel))
      {
        WebChart1.Chart.Panel.MarginBottom = 30;
        WebChart1.Chart.Panel.MarginTop = 30;
      }
      else
      {
        WebChart1.Chart.Panel.MarginBottom = 4;
        WebChart1.Chart.Panel.MarginTop = 4;
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
