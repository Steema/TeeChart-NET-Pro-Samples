extern alias SystemDrawingCommon;

using System;
using Microsoft.AspNetCore.Mvc;
using FastReport.Web;
using System.IO;

using SystemDrawingCommon::System.Drawing;
using SystemDrawingCommon::System.Drawing.Imaging;

namespace SPAWebReport.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        [HttpGet("[action]")]
        public IActionResult ShowReport()
        {
            WebReport WebReport = new WebReport();
            WebReport.Width = "1000";
            WebReport.Height = "1000";
            WebReport.Report.Load("App_Data/Master-Detail.frx"); //Çàãðóæàåì îò÷åò â îáúåêò WebReport

            System.Data.DataSet dataSet = new System.Data.DataSet(); //Ñîçäàåì èñòî÷íèê äàííûõ
            dataSet.ReadXml("App_Data/nwind.xml");  //Îòêðûâàåì áàçó äàííûõ xml
            WebReport.Report.RegisterData(dataSet, "NorthWind"); //Ðåãèñòðèðóåì èñòî÷íèê äàííûõ â îò÷åòå

            foreach (FastReport.ReportPage aPage in WebReport.Report.Pages)
            {
                aPage.Bands[0].BeforePrint += SampleDataController_BeforePrint;
            }

            ViewBag.WebReport = WebReport; //ïåðåäàåì îò÷åò âî View
            return View();
        }


        SystemDrawingCommon.System.Drawing.Image img;
        System.Drawing.Image img3;

        private void setupChart(Steema.TeeChart.Chart aChart)
        {
            aChart.Legend.Visible = false;
            aChart.Header.Visible = false;
            aChart.CurrentTheme = Steema.TeeChart.ThemeType.Report;
            aChart.Axes.Bottom.Title.Caption = "prod code - stock level";
            aChart.Axes.Bottom.Labels.Separation = 1;
        }

        private void SampleDataController_BeforePrint(object sender, EventArgs e)
        {

            Steema.TeeChart.Chart aChart = new Steema.TeeChart.Chart();
            setupChart(aChart);
            Steema.TeeChart.Styles.Bar aBar = new Steema.TeeChart.Styles.Bar();
            aChart.Series.Add(aBar);

            aBar.Marks.Visible = false;

            FastReport.DataBand dBand = (FastReport.DataBand)sender;

            FastReport.DataBand dBand2 = (FastReport.DataBand)dBand.Bands[0];

            object obj = dBand2.Objects[3];

            double[] vals = new double[dBand2.DataSource.RowCount];
            string[] prodCodes = new string[dBand2.DataSource.RowCount];

            dBand2.DataSource.CurrentRowNo = 0;
            for (int i = 0; i < dBand2.DataSource.RowCount; i++)
            {
                vals[i] = Convert.ToDouble(((System.Data.DataRow)dBand2.DataSource.CurrentRow).ItemArray[6]);
                prodCodes[i] = Convert.ToString(((System.Data.DataRow)dBand2.DataSource.CurrentRow).ItemArray[0]);
                dBand2.DataSource.CurrentRowNo++;
            }

            for (int i = 0; i < dBand2.DataSource.RowCount; i++)
            {
                aBar.Add(i,vals[i],prodCodes[i]);
            }

            System.IO.MemoryStream mStream = new MemoryStream();
            aChart.Export.Image.JPEG.Width = 718;
            aChart.Export.Image.JPEG.Height = 80;
            aChart.Export.Image.JPEG.Save(mStream);

            img3 = System.Drawing.Image.FromStream(mStream);


            FastReport.DataHeaderBand dhBand = dBand2.Header; //  new FastReport.DataHeaderBand;

            dhBand.Objects[0].BeforePrint += SampleDataController_BeforePrint1;

        }

        private void SampleDataController_BeforePrint1(object sender, EventArgs e)
        {
            if (sender is FastReport.PictureObject)
                ((FastReport.PictureObject)sender).Image = img3;

        }
    }
}
