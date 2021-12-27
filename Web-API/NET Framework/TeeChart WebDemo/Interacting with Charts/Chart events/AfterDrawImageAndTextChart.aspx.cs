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

namespace WebDemo.Interacting_with_Charts.Chart_events
{
	/// <summary>
	/// Summary description for CustomMapAreasChart.
	/// </summary>
	public partial class CustomMapAreasChart : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// Add Series and FillSampleValues
			Steema.TeeChart.Chart ch1=WebChart1.Chart;
			ch1.Series.Add( new Steema.TeeChart.Styles.Line());
			ch1.Series[0].FillSampleValues(5);
			ch1.Series[0].ColorEach = true;			

			(ch1.Series[0] as Steema.TeeChart.Styles.Line).Pointer.Visible = true;
			(ch1.Series[0] as Steema.TeeChart.Styles.Line).ColorEachLine = true;
			(ch1.Series[0] as Steema.TeeChart.Styles.Line).Pointer.HorizSize = 10;
			(ch1.Series[0] as Steema.TeeChart.Styles.Line).Pointer.VertSize = 10;
			(ch1.Series[0] as Steema.TeeChart.Styles.Line).Pointer.Pen.Color = Color.DarkGray;

			ch1.Legend.Visible = false;
			ch1.Legend.Shadow.Visible = false;

			// Apply palette
			//Steema.TeeChart.Themes.ColorPalettes.ApplyPalette(ch1.Chart,9);

			ch1.Axes.Left.Increment = ch1.Series[0].MaxYValue() / 10;
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
			this.WebChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.WebChart1_AfterDraw);

		}
		#endregion


		private void WebChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
		{
			int MaxYPoint=0;
			// Find the ValueIndex of the maximum Y value
			for (int i=0;i<WebChart1.Chart.Series[0].Count;i++)
			{
				if (WebChart1.Chart.Series[0].YValues[i]==WebChart1.Chart.Series[0].MaxYValue())
				{
					MaxYPoint = i;
				}
			}
	
			switch (DropDownList1.SelectedIndex)
			{
				case 0 :
				{
					// Load bitmap from file 
					System.Drawing.Image bitmap = Bitmap.FromFile(this.Page.MapPath("../../images/steelog.gif"));

					// Calculates image position depending on the Position of the Max YValue of the Serie
					RectangleF	imagePos = RectangleF.Empty;
			
					imagePos.X = WebChart1.Chart.Axes.Bottom.CalcXPosValue(MaxYPoint);
					imagePos.Y = WebChart1.Chart.Axes.Left.CalcYPosValue(WebChart1.Chart.Series[0].MaxYValue());

					imagePos.Width = bitmap.Width;
					imagePos.Height = bitmap.Height;
					imagePos.Y -= bitmap.Height + 10;
					imagePos.X -= bitmap.Width /2;

					// Draw image
					g.Draw(Rectangle.Round(imagePos),bitmap,Steema.TeeChart.Drawing.ImageMode.Normal,false);

					// Dispose image object
					bitmap.Dispose();				
					break;
				}
				case 1 :
				{
					g.TextOut(WebChart1.Chart.Axes.Bottom.CalcXPosValue(MaxYPoint)-50,
					WebChart1.Chart.Axes.Left.CalcYPosValue(WebChart1.Chart.Series[0].MaxYValue())-25,
					"http://www.steema.com");
					break;
				}
			}
		}

	}
}
