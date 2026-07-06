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
using Steema.TeeChart;
using System.IO;


namespace WebDemo.Interacting_with_Charts.Client_Side_Scripts.ShowChart
{
	/// <summary>
	/// Summary description for ShowImages.
	/// </summary>
	public partial class ShowChart : System.Web.UI.Page
	{
		private Chart chart;

		protected void Page_Load(object sender, System.EventArgs e)
		{			
			chart=new Chart();	  

			// Quality
			chart.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

			// Sets the Chart Title
			if(this.Page.Request["ChartTitle"] != null)
			{
				string charttitle = (string)this.Page.Request["ChartTitle"];
				chart.Header.Text = charttitle;
			}

			// Add the Series Type , in this case Pie Series
			chart.Series.Add (new Steema.TeeChart.Styles.Pie());

			// Add the values to the Pie Series
			if(this.Page.Request["Mortal"] != null)
			{
				chart.Series[0].Add(int.Parse(this.Page.Request["Mortal"]),Color.FromArgb(255,128,128));
			}
			if(this.Page.Request["Serious"] != null)
			{
				chart.Series[0].Add(int.Parse(this.Page.Request["Serious"]),Color.FromArgb(102,102,255));
			}
			if(this.Page.Request["Light"] != null)
			{
				chart.Series[0].Add(int.Parse(this.Page.Request["Light"]),Color.FromArgb(255,204,153));
			}

			if (Request.QueryString["width"]!=null )
			{
				chart.Width=Convert.ToInt32(Request.QueryString["width"]);
				chart.Legend.Visible= false ;
				//chart.Header.Visible= false ;
				chart[0].Marks.Visible= false ;
			}
			if (Request.QueryString["height"]!=null )
				chart.Height=Convert.ToInt32(Request.QueryString["height"]);


			//Gradient
			Steema.TeeChart.Drawing.Gradient g=chart.Panel.Gradient;
			g.Visible=true;
			g.StartColor=Color.FromArgb(234,234,255);
			g.MiddleColor=Color.FromArgb(234,234,255);
			g.EndColor=Color.FromArgb(255,255,255);

			MemoryStream tempStream = new MemoryStream();
			chart.Export.Image.PNG.Save(tempStream);
			//tempStream.Flush();
			Response.ContentType="Image/PNG";
			Response.OutputStream.Write(tempStream.ToArray(),0,(int)tempStream.Length);
			tempStream.Close();			
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
