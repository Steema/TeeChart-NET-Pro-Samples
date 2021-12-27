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
using System.Globalization;

//save data between calls
using System.IO;

namespace WebDemo.Interacting_with_Charts.Mouseover_Hints.ModifyStandardMarkText
{
	/// <summary>
	/// Summary description for FormattingValuesChart.
	/// </summary>
	public partial class FormattingValuesChart : System.Web.UI.Page
	{
		protected Steema.TeeChart.Tools.SeriesHotspot seriesHotspot1;
		protected Steema.TeeChart.Tools.ZoomTool zoomTool1;
		private static string StrCustom ="";
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			Steema.TeeChart.Chart ch1=WebChart1.Chart;
			Steema.TeeChart.Styles.Bubble bubble1 = new Steema.TeeChart.Styles.Bubble(ch1);

			bubble1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.PolishedSphere;

			// Apply palette
			//Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(ch1.Chart,9);
			
			ch1.Axes.Left.Labels.RoundFirstLabel = false;
			// Populate series data
			double[]	yValues = {23.67894, 75.4561, 60.4530, 34.54204, 85.62427, 32.4397, 55.9812734, 67.2345, 56.345234, 23.1452435, 45.24098, 67.41023, 13.452, 56.36356, 45.29654};
			double[]	yRadius = {2.56, 6.1, 7.89, 2.56, 1.23, 5.78, 3.67, 9.7, 4.61, 8.45, 3.67, 7.84, 1.98, 6.56, 3.54};
			DateTime	currentDate = DateTime.Now.Date;

			bubble1.XValues.DateTime = true;
			for(int valueIndex = 0;  valueIndex < yValues.Length; valueIndex++)
			{							
				double XVal = currentDate.AddDays(valueIndex).ToOADate();
				bubble1.Add(XVal, yValues[valueIndex], yRadius[valueIndex],"");				
			}			
			ch1.Axes.Bottom.Labels.DateTimeFormat = "dd MMM";						
			((Steema.TeeChart.Tools.SeriesHotspot)(ch1.Chart.Tools[0])).Style=Steema.TeeChart.Styles.MarksStyles.XValue;

			// Chart Border
			WebChart1.BackColor = Color.White;
			ch1.Panel.ImageBevel.Visible = false;
			ch1.Panel.ImageBevel.Pen.Visible = false;
			ch1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
			ch1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.None;
			ch1.Panel.BorderRound = 50;
			ch1.Panel.Pen.Visible = false;
			ch1.Panel.Shadow.Visible = false;

			// *************** Code for zoom support ***************
			CheckZoom(WebChart1);
		}


		private void CheckZoom(Steema.TeeChart.Web.WebChart wChart)
		{
			ArrayList zoomedState=(ArrayList)Session[wChart.ID+"Zoomed"];
			zoomedState=((Steema.TeeChart.Tools.ZoomTool)wChart.Chart.Tools[1]).SetCurrentZoom(Request,
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

			//Associate the Chart's Hotspot event with function
			((Steema.TeeChart.Tools.SeriesHotspot)(WebChart1.Chart.Tools[0])).GetHTMLMap += 
				new Steema.TeeChart.Tools.SeriesHotspotEventHandler(hotspot1_GetHTMLMap);

			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.seriesHotspot1 = new Steema.TeeChart.Tools.SeriesHotspot();
			this.zoomTool1 = new Steema.TeeChart.Tools.ZoomTool();
			// 
			// seriesHotspot1
			// 
			this.seriesHotspot1.HelperScript = Steema.TeeChart.Tools.HotspotHelperScripts.Annotation;
			this.seriesHotspot1.HotspotCanvasIndex = 499;
			this.seriesHotspot1.MapAction = Steema.TeeChart.Styles.MapAction.Mark;
			this.seriesHotspot1.MapElements = "";
			// 
			// zoomTool1
			// 
			this.zoomTool1.CustomVariables = "";
			this.zoomTool1.ZoomCanvasIndex = 499;
			this.zoomTool1.ZoomPenColor = System.Drawing.Color.Red;

		}
		#endregion

		private void hotspot1_GetHTMLMap(Steema.TeeChart.Tools.SeriesHotspot sender, Steema.TeeChart.Tools.SeriesHotspotEventArgs e)
		{
			//Title and/or HREF URL compatible with scripting
			//e.PointPolygon.Title="Cursor over "+e.Series.ToString()+", "+e.PointPolygon.ValueIndex.ToString()+", value: "+e.Series.YValues[e.PointPolygon.ValueIndex].ToString();
			//e.PointPolygon.HREF="http://www.steema.com";
			//e.PointPolygon.Attributes="onmouseover=\"DisplayAnnotation('"&lt;IMG SRC=bubble.gif"&gt;');\" onmouseout=\"DisplayAnnotation('');\"";
			string StrXVal=e.PointPolygon.Title;	
			DateTimeFormatInfo format = new DateTimeFormatInfo();			
			
			switch (DropDownList1.SelectedIndex)
			{
				case 0:
					StrXVal = DateTime.FromOADate(Convert.ToInt32(WebChart1.Chart[0].XValues[e.PointPolygon.ValueIndex].ToString())).ToShortDateString();
					//StrXVal = DateTime.FromOADate(Convert.ToInt32(WebChart1.Chart[0].XValues[0].ToString())).ToShortDateString();
					break;
				case 1:
					StrXVal = DateTime.FromOADate(Convert.ToInt32(WebChart1.Chart[0].XValues[e.PointPolygon.ValueIndex].ToString())).ToLongDateString();
					break;
				case 2:
					StrXVal = DateTime.FromOADate(Convert.ToInt32(WebChart1.Chart[0].XValues[e.PointPolygon.ValueIndex].ToString())).ToString(format.FullDateTimePattern);
					break;
				case 3:
					StrXVal = DateTime.FromOADate(Convert.ToInt32(WebChart1.Chart[0].XValues[e.PointPolygon.ValueIndex].ToString())).ToString();
					break;
				case 5:					
					StrXVal = DateTime.FromOADate(Convert.ToInt32(WebChart1.Chart[0].XValues[e.PointPolygon.ValueIndex].ToString())).ToString(format.YearMonthPattern);
					break;
			}

			if (StrCustom == "")
			{
				e.PointPolygon.Title = "XValue : " + StrXVal + "\n" +
					"YValue : " + WebChart1.Chart.Series[0].YValues[e.PointPolygon.ValueIndex].ToString()+ "\n" +
					"Radius : " + (WebChart1.Chart.Series[0] as Steema.TeeChart.Styles.Bubble).RadiusValues[e.PointPolygon.ValueIndex].ToString();	
			}
			else
			{
				e.PointPolygon.Title = "XValue : " + StrXVal + "\n" +
					"YValue : " + WebChart1.Chart.Series[0].YValues[e.PointPolygon.ValueIndex].ToString()+ "\n" +
					"Radius : " + (WebChart1.Chart.Series[0] as Steema.TeeChart.Styles.Bubble).RadiusValues[e.PointPolygon.ValueIndex].ToString()+ "\n" +	
					StrCustom;
			}
		}

		protected void Button1_Click(object sender, System.EventArgs e)
		{			
			StrCustom = TextBox1.Text;
		}
	}
}
