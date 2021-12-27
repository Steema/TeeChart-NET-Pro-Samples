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
using Steema.TeeChart.Styles;

namespace WebDemo.Chart_Styles.Extended
{
	/// <summary>
	/// Summary description for SurfaceChart.
	/// </summary>
	public partial class SurfaceChart : System.Web.UI.Page
	{
		private Steema.TeeChart.Styles.Surface surface1;
		private Steema.TeeChart.Styles.Points3D points3D1;

		private Steema.TeeChart.Chart ch1;

		private void Fill(Custom3D custom)
		{
      custom.Clear();
      custom.BeginUpdate();
			try
			{
				int m = 40;
				double tmpz, tmpx, tmpy;

				for (int x=-m; x<m; x++)
				{
					tmpx = x*x/900.0;
					for (int z=-m; z<m; z++)
					{
						tmpz = z*z/900.0;
						tmpz = Math.Sqrt(tmpx+tmpz);
						tmpy = 4*Math.Cos(3*tmpz)*Math.Exp(-0.5*tmpz);
            custom.Add(x, tmpy, z);
					}
				}
			}
			finally
			{
        custom.EndUpdate();
			}
		}
 
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			ch1=WebChart1.Chart;
			ch1.Series.RemoveAllSeries();			
			ch1.Series.Add(points3D1=new Steema.TeeChart.Styles.Points3D());
			ch1.Series.Add(surface1=new Steema.TeeChart.Styles.Surface());
			points3D1.Pointer.HorizSize=2;
			points3D1.Pointer.VertSize=2;
			points3D1.LinePen.Visible=false;
			ch1.Aspect.Chart3DPercent = 75;
			ch1.Aspect.Elevation = 338;
			ch1.Aspect.Orthogonal = false;
			ch1.Aspect.Perspective = 0;
			ch1.Aspect.Rotation = 314;
			ch1.Aspect.Zoom = 63;

      surface1.Pen.Visible = false;

      // Apply palette
      //Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(ch1.Chart,9);
      Fill(points3D1);
      Fill(surface1);
			
			
			switch (DropDownList1.SelectedIndex)
			{
				case 0:points3D1.Active=true;surface1.Active=false;break;
				case 1:points3D1.Active=false;surface1.Active=true;break;		
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
