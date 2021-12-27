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

namespace WebDemo.Chart_Styles.Other
{
	/// <summary>
	/// Summary description for Bar3DChart.
	/// </summary>
	public partial class Bar3DChart : System.Web.UI.Page
	{
		private Steema.TeeChart.Styles.Bar3D bar3DSeries1;
		private Steema.TeeChart.Chart ch1;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			ch1=WebChart1.Chart;
			ch1.Series.RemoveAllSeries();			
			ch1.Series.Add(bar3DSeries1=new Steema.TeeChart.Styles.Bar3D());

			this.bar3DSeries1.Add(0, 250, 200, "A");
			this.bar3DSeries1.Add( 1,  10, 200, "B");
			this.bar3DSeries1.Add( 2,  90, 100, "C");
			this.bar3DSeries1.Add( 3,  30,  50, "D" );
			this.bar3DSeries1.Add( 4,  70, 150, "E");
			this.bar3DSeries1.Add( 5, 120, 150, "F");
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

		protected void DropDownList1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.bar3DSeries1.BarStyle = (Steema.TeeChart.Styles.BarStyles)DropDownList1.SelectedIndex;
		}
	}
}
