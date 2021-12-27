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
using System.IO;



namespace WebDemo.Interacting_with_Charts.Client_Side_Scripts
{
	/// <summary>
	/// Summary description for ServerSideClickEventChart.
	/// </summary>
	public partial class ServerSideClickEventChart : System.Web.UI.Page
	{
		private Steema.TeeChart.Styles.Area area1;
		private int clickedX;
		private int clickedY;
		private string msgText;
		bool ButtonClicked=false;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// ****************************************************
			//The data load code for WebChart1 demostrates a technique to save 
			//data between page calls. The Chart is saved as a TeeChart template 
			//to a session variable.
			// ****************************************************
			clickedX=-1;
			clickedY=-1;
			msgText="";

			Steema.TeeChart.Chart ch2=WebChart1.Chart;
			MemoryStream tmpChart=new MemoryStream();
			
			if (Session["ch2"]==null)
			{						
				// Add Serie and FillSampleValues to the Series
				ch2.Series.RemoveAllSeries();
				area1 = new Steema.TeeChart.Styles.Area();
				ch2.Series.Add(area1);
				area1.FillSampleValues();
				area1.Marks.Visible = false;
				ch2.Legend.Visible = false;
				area1.LinePen.Width = 2;
				area1.LinePen.Color = Color.DarkGray;
				area1.Color = Color.Blue;
				area1.Transparency = 70;	
				area1.AreaLines.Visible = false;

				// Apply palette
				Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(ch2.Chart,9);

				//export Chart to a MemoryStream template
				ch2.Export.Template.Save(tmpChart);
				//save template to a Session variable
				Session.Add("ch2",tmpChart);
			}
			else
			{
				//retrieve the session stored Chart
				tmpChart=(MemoryStream)Session["ch2"];
				//set the Stream position to 0 as the last read/write
				//will have moved the position to the end of the stream
				tmpChart.Position=0;
				//import saved Chart
				ch2.Import.Template.Load(tmpChart);	
			}			
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
			this.WebChart1.ClickBackground += new Steema.TeeChart.Web.WebChart.ClickEventHandler(this.WebChart1_ClickBackground);
			this.WebChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.WebChart1_AfterDraw);
			this.WebChart1.ClickSeries += new Steema.TeeChart.Web.WebChart.SeriesEventHandler(this.WebChart1_ClickSeries);

		}
		#endregion

		private void WebChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
		{
			//output text message to the rendered Chart.
			if (!ButtonClicked)
			{
				if (clickedX!=-1)
				{
					//g.Font.Bold=true;
					g.Font.Color=Color.OrangeRed;
					g.TextOut(clickedX,clickedY,msgText);
				}		
			}
			else
			{
				//g.Font.Bold=true;
				g.Font.Color=Color.OrangeRed;
				g.TextOut(Convert.ToInt32(TextBox1.Text),Convert.ToInt32(TextBox2.Text),TBText.Text);				
				ButtonClicked = false;
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
			msgText="Clicked Series: "+tChart.Series.IndexOf(s).ToString()+"\n\rValue: "+s.YValues[valueIndex].ToString("#0.00");
		}

		protected void Button1_Click(object sender, System.EventArgs e)
		{
			ButtonClicked = true;
		}
	}
}
