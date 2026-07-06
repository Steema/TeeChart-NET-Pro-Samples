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
using System.Text;

using System.Collections.Specialized;
using System.Reflection;


namespace WebDemo.Codes
{
	/// <summary>
	/// Summary description for Code.
	/// </summary>
	public partial class Code : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{						
			string fname = (string)Session["fileName"];
			string path = MapPath("/TeeChartForNET/")+fname+".cs";

      if (File.Exists(path))
      {
        //Open the stream and process it.		
        System.Windows.Forms.RichTextBox rtb = new System.Windows.Forms.RichTextBox();

        SourceControl cs = new SourceControl(rtb);
        cs.LoadTextFromFile(path);
        rtb.Text = "<HTML><HEAD><title>Codes</title> " +
        "<LINK href='..\\Styles\\ContentStyles.css' type='text/css' rel='stylesheet'>" +
        "<HEAD><Body><Div class='demoCode'>" +
        rtb.Text + "</div></body></html>";
        Response.Write(rtb.Text.Replace("\n", "<br>").Replace("\t", "&nbsp;&nbsp;&nbsp"));
      }
      else
        Response.Write("&nbsp;&nbsp;&nbspSourcefile not available for this element.");
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

		private void Button1_Click(object sender, System.EventArgs e)
		{
		}

	}
}
