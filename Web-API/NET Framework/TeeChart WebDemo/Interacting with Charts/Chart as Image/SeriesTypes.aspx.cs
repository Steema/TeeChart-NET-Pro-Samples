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
using System.IO;
using Steema.TeeChart;

namespace WebDemo.Interacting_with_Charts.Chart_as_Image
{
	/// <summary>
	/// Summary description for SeriesTypes.
	/// </summary>
	public partial class SeriesTypes : System.Web.UI.Page
	{
		private string seriesType;
		private string viewType;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			sendInfo();
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
			sendInfo();
		}

		private void sendInfo()
		{
			seriesType=DropDownList1.Items[DropDownList1.SelectedIndex].ToString();
			viewType=CheckBox1.Checked.ToString();
			Image1.ImageUrl="ShowSeries.aspx?seriestype="+seriesType+"&view="+viewType;

		}

		protected void Button1_Click(object sender, System.EventArgs e)
		{
			seriesType=DropDownList1.Items[DropDownList1.SelectedIndex].ToString();
			viewType=CheckBox1.Checked.ToString();
		}
	}
}

