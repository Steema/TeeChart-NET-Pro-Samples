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

namespace WebDemo.Chart_Styles.Other
{
	/// <summary>
	/// Summary description for CalendarChart.
	/// </summary>
	public partial class CalendarChart : System.Web.UI.Page
	{
		private Steema.TeeChart.Styles.Calendar calendarSeries1;
		private Steema.TeeChart.Chart ch1;
    private bool refreshing = false;

    protected void Page_Load(object sender, System.EventArgs e)
		{
      MemoryStream tmpChart = new MemoryStream();

      if ((Session[WebChart1.ID] == null) || (refreshing))
      {
        Steema.TeeChart.Chart ch1 = WebChart1.Chart;
        tmpChart = new MemoryStream();
        Session.Remove(WebChart1.ID);

        ch1.Series.RemoveAllSeries();
        ch1.Series.Add(calendarSeries1 = new Steema.TeeChart.Styles.Calendar());
        calendarSeries1.WeekDays.Visible = true;
        calendarSeries1.Months.Visible = true;
        this.calendarSeries1.FillSampleValues();

        ch1.Export.Template.Save(tmpChart);
        //save template to a Session variable
        Session.Add(WebChart1.ID, tmpChart);
      }
      else
      {
        //retrieve the session stored Chart
        tmpChart = (MemoryStream)Session[WebChart1.ID];
        //set the Stream position to 0 as the last read/write
        //will have moved the position to the end of the stream
        tmpChart.Position = 0;
        //import saved Chart
        WebChart1.Chart.Import.Template.Load(tmpChart);
      }

      ((Steema.TeeChart.Styles.Calendar)(WebChart1.Chart[0])).WeekDays.Visible = CheckBox1.Checked;
      ((Steema.TeeChart.Styles.Calendar)(WebChart1.Chart[0])).Months.Visible = CheckBox2.Checked;
    }

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();

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

		protected void CheckBox1_CheckedChanged(object sender, System.EventArgs e)
		{
      ((Steema.TeeChart.Styles.Calendar)(WebChart1.Chart[0])).WeekDays.Visible = CheckBox1.Checked;
		}

		protected void CheckBox2_CheckedChanged(object sender, System.EventArgs e)
		{
      ((Steema.TeeChart.Styles.Calendar)(WebChart1.Chart[0])).Months.Visible = CheckBox2.Checked;
		}

		private void WebChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
		{
      //make changes permanent to session
      MemoryStream tmpChart = new MemoryStream();
      Session.Remove(WebChart1.ID);
      WebChart1.Chart.Export.Template.Save(tmpChart);
      Session.Add(WebChart1.ID, tmpChart);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      if (Session[WebChart1.ID] != null)
      {
        Session.Remove(WebChart1.ID);
        Page_Load(sender, e);
      }
    }
  }
}
