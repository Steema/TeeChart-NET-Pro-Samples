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

namespace WebDemo.Interacting_with_Charts.Drill_Down_Selection.ShowSeries
{
	/// <summary>
	/// Summary description for ShowSeries.
	/// </summary>

	public partial class ShowSeries : System.Web.UI.Page
	{
		private Chart chart;

		protected void Page_Load(object sender, System.EventArgs e)
		{
			chart=new Chart();	  			

			// Axes
			chart.Axes.Left.Labels.Font.Size = 6;
			chart.Axes.Bottom.Labels.Font.Size = 6;
			chart.Axes.Left.Labels.Font.Color = Color.DarkGray;
			chart.Axes.Bottom.Labels.Font.Color = Color.DarkGray;
			chart.Axes.Left.AxisPen.Visible = false;
			chart.Axes.Right.AxisPen.Visible = false;
			chart.Axes.Top.AxisPen.Visible = false;
			chart.Axes.Bottom.AxisPen.Visible = false;

			// Walls
			chart.Walls.Left.Visible = false;
			chart.Walls.Bottom.Visible = false;
			chart.Walls.Right.Visible = false;
			chart.Walls.Back.Pen.Color = Color.DarkGray;

			// Panel
			chart.Panel.Bevel.Width=0;

			// Quality
			chart.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

			if (Request.QueryString["view"]=="False")
				chart.Aspect.View3D=false;
			else
				chart.Aspect.View3D=true;

			//Add Series to Chart
			switch (Request.QueryString["seriestype"])
			{
				case "Line": chart.Series.Add(new Steema.TeeChart.Styles.Line()); 
					chart.Series.Add(new Steema.TeeChart.Styles.Line()); break;
				case "Bar": chart.Series.Add(new Steema.TeeChart.Styles.Bar()); break;
				case "HorizBar": chart.Series.Add(new Steema.TeeChart.Styles.HorizBar()); break;
				case "Area": chart.Series.Add(new Steema.TeeChart.Styles.Area()); break;
				case "Point": chart.Series.Add(new Steema.TeeChart.Styles.Points()); break;
				case "Surface": chart.Series.Add(new Steema.TeeChart.Styles.Surface()); break;
				default: chart.Series.Add(new Steema.TeeChart.Styles.Line()); break;
			}

			if (Request.QueryString["width"]!=null )
			{
				chart.Width=Convert.ToInt32(Request.QueryString["width"]);
				chart.Legend.Visible= false ;
				chart.Header.Visible= false ;
				chart[0].Marks.Visible= false ;
			}
			if (Request.QueryString["height"]!=null )
				chart.Height=Convert.ToInt32(Request.QueryString["height"]);

			//Fill Series with sample values
			foreach (Steema.TeeChart.Styles.Series s in chart.Series)
				if (s is Steema.TeeChart.Styles.Surface)
				{
					s.FillSampleValues(40);				
				}
				else
				{
					s.FillSampleValues(4);
					s.Color = Color.FromArgb(102,153,255);
				}
	
			//Gradient
			Steema.TeeChart.Drawing.Gradient g=chart.Panel.Gradient;
			g.Visible=true;
			g.StartColor=Color.FromArgb(234,234,255);
			g.MiddleColor=Color.FromArgb(234,234,255);
			g.EndColor=Color.FromArgb(255,255,255);

			//Header
			chart.Header.Text="TeeChart NET Series Types";
			chart.Header.Pen.Visible=false;

			//Other
			chart.Walls.Back.Transparency=50;

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
