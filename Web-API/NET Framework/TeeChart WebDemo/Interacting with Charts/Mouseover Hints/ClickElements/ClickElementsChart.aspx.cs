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
using Steema.TeeChart.Web;
using Steema.TeeChart.Styles;

//save data between calls
using System.IO;


namespace WebDemo.Interacting_with_Charts.Mouseover_Hints.ClickElements
{
	/// <summary>
	/// Summary description for CapturingMouseEventsChart.
	/// </summary>
	public partial class ClickElementsChart : System.Web.UI.Page
	{
		protected Steema.TeeChart.Tools.SeriesHotspot seriesHotspot1;

		private int clickedX;
		private int clickedY;
		private string msgText;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			clickedX=-1;
			clickedY=-1;
			msgText="";
    
			// ****************************************************
			//The data load code for WebChart1 demostrates a technique to save 
			//data between page calls. The Chart is saved as a TeeChart template 
			//to a session variable.
			// ****************************************************
			Steema.TeeChart.Chart ch1=WebChart1.Chart;
			MemoryStream tmpChart=new MemoryStream();

			if (Session["ch3"]==null)
			{			
				//setup Chart
				if (ch1.Series.Count<2)
				{ 
					ch1.Series.Add(new Steema.TeeChart.Styles.Points());
					ch1.Series.Add(new Steema.TeeChart.Styles.Points());
				}				

				((Points)ch1.Series[0]).Pointer.Pen.Visible=false;
				((Points)ch1.Series[1]).Pointer.Pen.Color=Color.FromArgb(79,79,255);
		
				ch1.Series[0].Color=Color.FromArgb(255,199,26);
				ch1.Series[1].Color=Color.FromArgb(106,106,255);

				ch1.Series[0].FillSampleValues(6);
				ch1.Series[1].FillSampleValues(6);
				//export Chart to a MemoryStream template
				ch1.Export.Template.Save(tmpChart);
				//save template to a Session variable
				Session.Add("ch3",tmpChart);
			}
			else
			{
				//retrieve the session stored Chart
				tmpChart=(MemoryStream)Session["ch3"];
				//set the Stream position to 0 as the last read/write
				//will have moved the position to the end of the stream
				tmpChart.Position=0;
				//import saved Chart
				ch1.Import.Template.Load(tmpChart);
			}
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			//Associate the Chart's Hotspot event with function

			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.seriesHotspot1 = new Steema.TeeChart.Tools.SeriesHotspot();
			this.WebChart1.ClickBackground += new Steema.TeeChart.Web.WebChart.ClickEventHandler(this.WebChart1_ClickBackground);
			this.WebChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.WebChart1_AfterDraw);
			this.WebChart1.ClickSeries += new Steema.TeeChart.Web.WebChart.SeriesEventHandler(this.WebChart1_ClickSeries);
			// 
			// seriesHotspot1
			// 
			this.seriesHotspot1.HelperScript = Steema.TeeChart.Tools.HotspotHelperScripts.Annotation;
			this.seriesHotspot1.HotspotCanvasIndex = 499;
			this.seriesHotspot1.MapAction = Steema.TeeChart.Styles.MapAction.Script;
			this.seriesHotspot1.MapElements = "";

		}
		#endregion



		private void WebChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
		{
			//output text message to the rendered Chart.
			if (clickedX!=-1)
			{
				g.Font.Bold=true;
				g.Font.Color=Color.Blue; 
				g.TextOut(clickedX,clickedY,msgText);
			}
		}

		private void WebChart1_ClickBackground(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			//event triggered when any point on the Chart is clicked. If the ClickSeries event is active
			//it will take precedence when a Series is clicked.
			clickedX=e.X;
			clickedY=e.Y;
			msgText="Clicked background\n\rX:"+WebChart1.Chart.Axes.Bottom.CalcPosPoint(clickedX).ToString("#0.00")
				+", Y:"+WebChart1.Chart.Axes.Left.CalcPosPoint(clickedY).ToString("#0.00");
		}

		private void WebChart1_ClickSeries(object sender, Steema.TeeChart.Styles.Series s, int valueIndex, System.EventArgs e)
		{
			Steema.TeeChart.Chart tChart=((WebChart)sender).Chart;

			clickedX=s.CalcXPos(valueIndex);
			clickedY=s.CalcYPos(valueIndex);
			msgText="Series: "+tChart.Series.IndexOf(s).ToString()+"\n\rValue: "+s.YValues[valueIndex].ToString("#0.00");
		}
	}
}
