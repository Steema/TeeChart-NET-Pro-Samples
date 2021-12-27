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

using Steema.TeeChart.Web;
using Steema.TeeChart.Styles;


namespace WebDemo.Interacting_with_Charts.Zooming
{
	/// <summary>
	/// Summary description for WebForm1.
	/// </summary>
	public partial class WebAppZoomChart : System.Web.UI.Page
	{
    private int clickedX;
    private int clickedY;
    private string msgText;

    private bool refreshing = false;

		protected void Page_Load(object sender, System.EventArgs e)
		{
      clickedX = -1;
      clickedY = -1;
      msgText = "";
			// Put user code to initialize the page here
			// ****************************************************
			// The data load code for WebChart1 demostrates a technique to save 
			// data between page calls. The Chart is saved as a TeeChart template 
			// to a session variable.
			// ****************************************************
			Steema.TeeChart.Chart ch1=WebChart1.Chart;
			MemoryStream tmpChart=new MemoryStream();

			if ((Session["ch1"]==null) || (refreshing))
			{
        refreshing = false; //just once
        ch1.Axes.Left.Automatic = true;
        ch1.Axes.Bottom.Automatic = true;
        Session.Remove(WebChart1.ID + "Zoomed");

        //setup Chart
        if (ch1.Series.Count<2)
				{ 
					ch1.Series.Add(new Steema.TeeChart.Styles.Points());
					ch1.Series.Add(new Steema.TeeChart.Styles.Points());
				}


        if (ch1.Tools.Count < 1)
        {
          ch1.Tools.Add(new Steema.TeeChart.Tools.ZoomTool());
          ch1.Tools.Add(new Steema.TeeChart.Tools.SeriesHotspot());
        }

        ((Steema.TeeChart.Tools.ZoomTool)ch1.Tools[0]).ZoomPenColor = Color.OliveDrab;
        ((Steema.TeeChart.Tools.SeriesHotspot)ch1.Tools[1]).Style = MarksStyles.LabelPercentTotal;
				((Points)ch1.Series[0]).Pointer.Pen.Visible=false;
        ((Points)ch1.Series[0]).Pointer.HorizSize = 2;
        ((Points)ch1.Series[0]).Pointer.VertSize = 2;
				((Points)ch1.Series[1]).Pointer.Pen.Color=Color.FromArgb(79,79,255);
        ((Points)ch1.Series[1]).Pointer.HorizSize = 2;
        ((Points)ch1.Series[1]).Pointer.VertSize = 2;
		
				ch1.Series[0].Color=Color.FromArgb(255,199,26);
				ch1.Series[1].Color=Color.FromArgb(106,106,255);

				ch1.Series[0].FillSampleValues(36);
				ch1.Series[1].FillSampleValues(36);
				//export Chart to a MemoryStream template
				ch1.Export.Template.Save(tmpChart);
				//save template to a Session variable
				Session.Add("ch1",tmpChart);
			}
			else
			{
				//retrieve the session stored Chart
				tmpChart=(MemoryStream)Session["ch1"];
				//set the Stream position to 0 as the last read/write
				//will have moved the position to the end of the stream
				tmpChart.Position=0;
				//import saved Chart
				WebChart1.Chart.Import.Template.Load(tmpChart);

				//check whether zoom request is being sent
				CheckZoom(WebChart1);
			}
		}

		private void CheckZoom(WebChart wChart)
		{
			ArrayList zoomedState=(ArrayList)Session[wChart.ID+"Zoomed"];
			zoomedState=((Steema.TeeChart.Tools.ZoomTool)wChart.Chart.Tools[0]).SetCurrentZoom(Request,
				zoomedState);
			if (zoomedState==null)
				Session.Remove(wChart.ID+"Zoomed");
			else
				Session.Add(wChart.ID+"Zoomed",zoomedState);
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

    protected void WebChart1_ClickAxis(object sender, ImageClickEventArgs e)
    {
      Steema.TeeChart.Axis axis = (Steema.TeeChart.Axis)sender;
      clickedX = e.X;
      clickedY = e.Y;
      double axisValue=0;
      if (axis.Horizontal)
        axisValue=((Steema.TeeChart.Axis)sender).CalcPosPoint(clickedX);
      else
        axisValue = ((Steema.TeeChart.Axis)sender).CalcPosPoint(clickedY);
      msgText = "Clicked Axis at:" + "\n\rValue: " + axisValue.ToString("#.00");
    }
    protected void WebChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
    {
      if (clickedX != -1)
      {
        g.Font.Color = Color.Maroon;
        g.TextOut(clickedX, clickedY, msgText);
      }		
    }
    protected void WebChart1_ClickSeries(object sender, Series s, int valueIndex, EventArgs e)
    {
      Steema.TeeChart.Chart tChart = ((WebChart)sender).Chart;

      clickedX = s.CalcXPos(valueIndex);
      clickedY = s.CalcYPos(valueIndex);
      msgText = "Clicked Series: " + tChart.Series.IndexOf(s).ToString() + "\n\rValue: " + s.YValues[valueIndex].ToString("#0.00");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      refreshing = true;
      Page_Load(sender, e);
    }
  }
}
