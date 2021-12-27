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

namespace WebDemo.Interacting_with_Charts.Mouseover_Hints
{
	/// <summary>
	/// Summary description for ImageMapFeaturesAndBinaryStreamingChart.
	/// </summary>
	public partial class ImageMapFeaturesAndBinaryStreamingChart : System.Web.UI.Page
	{
		protected Steema.TeeChart.Tools.ColorBand colorBand1;
		protected Steema.TeeChart.Tools.SeriesHotspot seriesHotspot1;
		private Steema.TeeChart.Chart ch1;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// Add Series and FillSampleValues
			ch1=WebChart1.Chart;
			ch1.Series.Add( new Steema.TeeChart.Styles.Bar());
			double[]	yValues = {52, 23, 72, 66, 32, 54, 74, 21, 86, 15};
			Steema.TeeChart.Styles.StringList labels = new Steema.TeeChart.Styles.StringList(10);
			labels.Add("Surface");
			labels.Add("Bar");
			labels.Add("Candle");
			labels.Add("Pie");
			labels.Add("Line");
			labels.Add("Gantt");
			labels.Add("Volume");
			labels.Add("Bubble");
			labels.Add("Clock");
			labels.Add("Gauge");
			ch1.Series[0].Add(yValues);
			ch1.Series[0].Labels = labels;			
			ch1.Series[0].Title = "Chart Styles";
			ch1.Axes.Bottom.Labels.Angle = 90;
			ch1.Series[0].Marks.Visible = false;
			ch1.Series[0].ColorEach = true;		
			ch1.Axes.Bottom.Title.Text = "Most used Chart Styles";
			ch1.Axes.Bottom.Title.Font.Color = Color.DarkGray;
			ch1.Aspect.View3D = false;

			ch1.Legend.LegendStyle = Steema.TeeChart.LegendStyles.Series;

			// Apply palette
			//Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(ch1.Chart,9);

			((Steema.TeeChart.Tools.SeriesHotspot)(ch1.Chart.Tools[0])).Style=Steema.TeeChart.Styles.MarksStyles.Value;
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
			this.colorBand1 = new Steema.TeeChart.Tools.ColorBand();
			this.seriesHotspot1 = new Steema.TeeChart.Tools.SeriesHotspot();
			// 
			// colorBand1
			// 
			// 
			// colorBand1.Brush
			// 
			this.colorBand1.Brush.Color = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.colorBand1.End = 40;
			// 
			// colorBand1.EndLinePen
			// 
			this.colorBand1.EndLinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(255)));
			// 
			// colorBand1.Pen
			// 
			this.colorBand1.Pen.Visible = false;
			this.colorBand1.ResizeEnd = true;
			this.colorBand1.ResizeStart = true;
			this.colorBand1.Start = 20;
			// 
			// colorBand1.StartLinePen
			// 
			this.colorBand1.StartLinePen.Color = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(255)));
			// 
			// seriesHotspot1
			// 
			this.seriesHotspot1.HelperScript = Steema.TeeChart.Tools.HotspotHelperScripts.Annotation;
			this.seriesHotspot1.HotspotCanvasIndex = 499;
			this.seriesHotspot1.MapAction = Steema.TeeChart.Styles.MapAction.Mark;
			this.seriesHotspot1.MapElements = "";

		}
		#endregion


		protected void DropDownList1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (DropDownList1.SelectedIndex)
			{
				case 0:  
					((Steema.TeeChart.Tools.SeriesHotspot)(ch1.Chart.Tools[0])).Style=Steema.TeeChart.Styles.MarksStyles.Value;
					break;
				case 1:
					((Steema.TeeChart.Tools.SeriesHotspot)(ch1.Chart.Tools[0])).Style=Steema.TeeChart.Styles.MarksStyles.Percent;
					break;
				case 2:
					((Steema.TeeChart.Tools.SeriesHotspot)(ch1.Chart.Tools[0])).Style=Steema.TeeChart.Styles.MarksStyles.Label;
					break;
				case 3:
					((Steema.TeeChart.Tools.SeriesHotspot)(ch1.Chart.Tools[0])).Style=Steema.TeeChart.Styles.MarksStyles.LabelPercent;
					break;
				case 4:					
					((Steema.TeeChart.Tools.SeriesHotspot)(ch1.Chart.Tools[0])).Style=Steema.TeeChart.Styles.MarksStyles.LabelValue;
					break;
				case 5:					
					((Steema.TeeChart.Tools.SeriesHotspot)(ch1.Chart.Tools[0])).Style=Steema.TeeChart.Styles.MarksStyles.Legend;
					break;
				case 6:					
					((Steema.TeeChart.Tools.SeriesHotspot)(ch1.Chart.Tools[0])).Style=Steema.TeeChart.Styles.MarksStyles.PercentTotal;
					break;
				case 7:					
					((Steema.TeeChart.Tools.SeriesHotspot)(ch1.Chart.Tools[0])).Style=Steema.TeeChart.Styles.MarksStyles.LabelPercentTotal;
					break;
				case 8:					
					((Steema.TeeChart.Tools.SeriesHotspot)(ch1.Chart.Tools[0])).Style=Steema.TeeChart.Styles.MarksStyles.XValue;
					break;
				case 9:					
					((Steema.TeeChart.Tools.SeriesHotspot)(ch1.Chart.Tools[0])).Style=Steema.TeeChart.Styles.MarksStyles.XY;
					break;
			}				
		}
	}
}
