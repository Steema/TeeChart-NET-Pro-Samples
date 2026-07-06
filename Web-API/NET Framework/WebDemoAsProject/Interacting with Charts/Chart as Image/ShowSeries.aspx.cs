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
using Steema.TeeChart.Web;


namespace WebDemo.Interacting_with_Charts.Chart_as_Image
{
	/// <summary>
	/// Summary description for ShowSeries.
	/// </summary>
	public partial class ShowSeries : System.Web.UI.Page
	{
		private Chart chart;
		protected void Page_Load(object sender, System.EventArgs e)
		{
			WebChart chart1=new WebChart();
            chart = chart1.Chart;

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

			//Fill Series with sample values
			foreach (Steema.TeeChart.Styles.Series s in chart.Series)
				if (s is Steema.TeeChart.Styles.Surface)
					s.FillSampleValues(40);
				else
					s.FillSampleValues(9);

			//Gradient
			Steema.TeeChart.Drawing.Gradient g=chart.Panel.Gradient;
			g.Visible=true;
			g.StartColor=Color.FromArgb(234,234,255);
			g.MiddleColor=Color.FromArgb(234,234,255);
			g.EndColor=Color.FromArgb(255,255,255);

			//Header
			chart.Header.Text="Chart as Image";
			chart.Header.Pen.Visible=false;
			chart.Header.Font.Name = "Verdana";
			chart.Header.Font.Color = Color.DarkBlue;
			chart.Header.Font.Size = 10;
			chart.Header.Shadow.Visible = true;
			chart.Header.Shadow.Color = Color.DarkGray;

			// Axes
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

			//Other
			chart.Walls.Back.Transparency=50;

			// Apply palette
			Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(chart.Chart,9);

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

