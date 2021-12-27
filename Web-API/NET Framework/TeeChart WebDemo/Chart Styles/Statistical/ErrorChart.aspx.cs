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
	/// Summary description for Error.
	/// </summary>
	public partial class Error : System.Web.UI.Page
	{
		private Steema.TeeChart.Styles.Error error1;
		private Steema.TeeChart.Chart ch1;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			ch1=WebChart1.Chart;
			ch1.Series.Add(error1= new Steema.TeeChart.Styles.Error());
			error1.Clear();
			error1.Add(0, 250, 200, "A");
			error1.Add( 1,  10, 200, "B");
			error1.Add( 2,  90, 100, "C");
			error1.Add( 3,  30,  50, "D");
			error1.Add( 4,  70, 150, "E");
			error1.Add( 5, 120, 150, "F");
			DropDownList1_SelectedIndexChanged(sender,e);

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
			switch (DropDownList1.SelectedIndex)
			{
				case 0 : this.error1.ErrorStyle = Steema.TeeChart.Styles.ErrorStyles.Left; break;
				case 1 : this.error1.ErrorStyle = Steema.TeeChart.Styles.ErrorStyles.Top; break;
				case 2 : this.error1.ErrorStyle = Steema.TeeChart.Styles.ErrorStyles.Right; break;
				case 3 : this.error1.ErrorStyle = Steema.TeeChart.Styles.ErrorStyles.Bottom; break;
				case 4 : this.error1.ErrorStyle = Steema.TeeChart.Styles.ErrorStyles.LeftRight; break;
				case 5 : this.error1.ErrorStyle = Steema.TeeChart.Styles.ErrorStyles.TopBottom; break;
			}		
		}
	}
}
