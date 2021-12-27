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

namespace WebDemo.Interactive_Charting.TeeMapWeb
{
	/// <summary>
	/// Summary description for MapHeader.
	/// </summary>
	public partial class MapHeader : System.Web.UI.Page
	{

		private string path;
		private string webServer; //="localhost";
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			string rooturl = this.Context.Request.Url.OriginalString.Substring(0, this.Context.Request.Url.OriginalString.IndexOf(this.Context.Request.RawUrl));
			webServer = rooturl;

			//When changing map, be sure to delete any saved Zoom location.
			Session.Remove("ch1Zoomed");			
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);

			string rooturl = this.Context.Request.Url.OriginalString.Substring(0, this.Context.Request.Url.OriginalString.IndexOf(this.Context.Request.RawUrl));
			webServer = rooturl;

			path = Request.PhysicalApplicationPath + @"Interacting with Charts\Mapping\";

			if(File.Exists(path+@"Maps\World.shp")) 
			{
				comboBox1.Items.Add(@"Maps\World");
				if(File.Exists(path+@"Maps\USAStates.shp")) 
					comboBox1.Items.Add(@"Maps\USAStates");

				comboBox1.SelectedIndex = 0;
			}

			System.Text.StringBuilder stb1 = new System.Text.StringBuilder();
			stb1.Append("<script language='JavaScript'>\n");
			stb1.Append("function loadMap(mapurl)\n");
			stb1.Append("{\n");
			stb1.Append("var obj=document.getElementById('comboBox1');\n");
			stb1.Append("parent.framebody.location=mapurl+obj.selectedIndex;\n");
			stb1.Append("window.status=parent.location\n");	
			stb1.Append("}\n");
			stb1.Append("\n");
			stb1.Append("function popup(url)\n");
			stb1.Append("{\n");			
			stb1.Append("window.open(url);\n");
			stb1.Append("}\n");

			stb1.Append("</script>\n");
			
			string mapurl = webServer + Request.ApplicationPath+"Interacting with Charts/Mapping/TeeMapWeb.aspx?winmap=";
			string url = webServer + Request.ApplicationPath+"/Interacting with Charts/Mapping/mapindex.htm";
			this.Page.RegisterClientScriptBlock("JavaScript1",stb1.ToString());
			comboBox1.Attributes.Add("onchange","loadMap('"+mapurl+"');");
			LinkButton1.Attributes.Add("OnClick","popup('"+url+"');");
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
