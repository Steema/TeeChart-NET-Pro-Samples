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
using System.Xml;
using System.Net;

namespace WebDemo
{
	/// <summary>
	/// Summary description for Content.
	/// </summary>
	public partial class Content : System.Web.UI.Page
	{
		private string webServer; // = "localhost";

		protected void Page_Load(object sender, System.EventArgs e)
		{
			string rooturl = this.Context.Request.Url.OriginalString.Substring(0, this.Context.Request.Url.OriginalString.IndexOf(this.Context.Request.RawUrl));
			webServer = rooturl;

			// Put user code to initialize the page here
			if ((string)Request.Params["SampleID"]=="0")
			{
				string fname = (string)Session["fileName"];
				string path = webServer+"/TeeChartForNET/"+fname;				
				Response.Redirect(path);				
			}
			else
			{
				string DemoID = Request.Params["SampleID"];
				string DemoParentID = Request.Params["ParentID"];

				string strID ="";
				string strParentID="";
				string strTitle="";
				string strSamplePage="";
				//string strSeqOrd="";
				string strParentNodePath="";
				string val="";

        string xmlFile = webServer + "/SampleList.xml";
        HttpWebRequest rqst = (HttpWebRequest)WebRequest.Create(xmlFile);
        rqst.Credentials = CredentialCache.DefaultCredentials;
        HttpWebResponse rsp = (HttpWebResponse)rqst.GetResponse();

        XmlTextReader reader = new XmlTextReader(rsp.GetResponseStream());

				reader.MoveToElement();
				try
				{
					while(reader.Read())					
					{
						if(reader.HasAttributes && reader.NodeType==XmlNodeType.Element)
						{
							reader.MoveToElement();
							reader.MoveToElement();
							reader.MoveToAttribute("ID");
							strID=reader.Value;

							if (strID == DemoID)
							{
								while(reader.Read())					
								{
									if(reader.HasAttributes && reader.NodeType==XmlNodeType.Element)
									{														
										val=reader.Name;

										reader.MoveToAttribute("ParentID");
										strParentID=reader.Value;
										reader.MoveToAttribute("ParentNodePath");
										strParentNodePath=reader.Value;


										if (strParentID==DemoParentID)
										{
											reader.Read();
											reader.Read();
											reader.Read();									
											strTitle=reader.Value;
											reader.Read();
											reader.Read();
											reader.Read();
											reader.Read();
											strSamplePage=reader.Value;
											reader.Read();
											reader.Read();
											reader.Read();
											reader.Read();
											//strSeqOrd=reader.Value;
											Session["fileName"]=strParentNodePath+"/"+strSamplePage;
											Response.Redirect(strParentNodePath+"/"+strSamplePage);
										}
									}
								}
							}
						}
					}
				}
				catch(XmlException ee)
				{
					Response.Redirect("ErrorPage.aspx?Error="+ee);				
				}
			}

			// Search SamplaPath in the XML file

			//if (Request.Params["SampleID"] == "0")
			//{
				//Response.Redirect("Overview/Introduction/Overview.htm");
			//}
			//else
			//{
				//string Path = "";
				//string SamplePage = "";

				// Get the info from xml file.

				//Response.Redirect(Path+SamplePage);
				//Response.Redirect(sid+".aspx");
			//}			
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
