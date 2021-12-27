using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAppCoreNetTest.Models;
using Steema.TeeChart;
using System.IO;

namespace WebAppCoreNetTest.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		public void GetChart(int width, int height)
		{

			if (width == 0) width = 800;
			if (height == 0) height = 600;

			Steema.TeeChart.TChart mChart = new TChart();
			Steema.TeeChart.Styles.Bar mBar = new Steema.TeeChart.Styles.Bar();

			mChart.Header.Text = "TeeChart via ImageSharp PNG example";

			mChart.Series.Add(mBar);

			mBar.FillSampleValues();

			mBar.XValues.DateTime = true;
			//mChart.Axes.Bottom.Labels.Angle = 90;
			mChart.Axes.Bottom.Increment = Steema.TeeChart.Utils.GetDateTimeStep(DateTimeSteps.OneDay);

			System.IO.MemoryStream ms = new System.IO.MemoryStream();
			mChart.Export.Image.JPEG.Width = width;
			mChart.Export.Image.JPEG.Height = height;
			mChart.Export.Image.JPEG.Save(ms);
			ms.Position = 0;

			//SixLabors.ImageSharp.Image img = SixLabors.ImageSharp.Image.Load(ms);

			Response.ContentType = "Image/PNG";
			Response.Body.WriteAsync(ms.ToArray(), 0, (int)ms.Length);

			ms.Close();
		}

		public void GetHTML5Chart(int width, int height, int? type)
		{
			if (width == 0) width = 800;
			if (height == 0) height = 600;


			{
				Steema.TeeChart.TChart wChart3 = new Steema.TeeChart.TChart();

				wChart3.Header.Text = "TeeChart Native Javascript example";

				List<string> customCode = new List<string>();

				string[] customCodeS = new string[] {
							" ",
							" ",

							"//tooltip",
							"tip=new Tee.ToolTip(chart1);",
							"tip.render=\"dom\";",
							"tip.autoHide=true;",
							"tip.domStyle = \"padding-left:8px; padding-right:8px; padding-top:2px; padding-bottom:4px; margin-left:5px; margin-top:0px; \";",
							"tip.domStyle = tip.domStyle + \"background-color:#FCFCFC; border-radius:4px 4px; color:#FFF; \";",
							"tip.domStyle = tip.domStyle + \"border-style:solid;border-color:#A3A3AF;border-width:1; z-index:1000;\";",
							"chart1.tools.add(tip);",
							"tip.onhide=function() { scaling=0; poindex=-1; }",

							"tip.ongettext=function( tool, text, series, index) { ",
							"  var s = '<font face=\"verdana\" color=\"black\" size=\"1\"><strong>'+ series.title+'</strong></font>';",
							"	    s = s + '<br/><font face=\"verdana\" color=\"darkblue\" size=\"1\">Series point: <strong>'+ index.toFixed(0)+'</strong></font>';",
							"      s =	s +'<br/><font face=\"verdana\" color=\"red\" size=\"1\">Value: '+series.data.values[index].toFixed(2)+'</font>';  ",
							"   return s;",
							"}"
				};
				//********* end client code *********************

				customCode.AddRange(customCodeS);

				customCode.Add(wChart3.Export.Image.JScript.ChartName + ".applyTheme(\"minimal\");");

				wChart3.Chart.Panning.Allow = Steema.TeeChart.ScrollModes.None;

				if (type == 0)
					wChart3.Series.Add(new Steema.TeeChart.Styles.Pie());
				else if (type == 1)
				{
					wChart3.Series.Add(new Steema.TeeChart.Styles.Bar());

					List<string> extFunc = new List<string>();

					extFunc.Add("var animation;");
					extFunc.Add("var loopCounter = 0;");

					extFunc.Add("function manualLoop()");
					extFunc.Add("{");
					extFunc.Add("animation.animate(" + wChart3.Export.Image.JScript.ChartName + ");");
					extFunc.Add("loopCounter++;");
					extFunc.Add("if (loopCounter < 10)");
					extFunc.Add("  setTimeout(manualLoop, 9000);");
					extFunc.Add("}");

					wChart3.Export.Image.JScript.ExternalCode = extFunc.ToArray();

					wChart3.Export.Image.JScript.SourceUnits.Add("teechart-animations.js");

					customCode.Add("   //animation");
					customCode.Add("   animation = new Tee.SeriesAnimation();");
					customCode.Add("   animation.duration = 3900;");
					customCode.Add("   animation.kind = \"each\";");
					customCode.Add("   fadeAnimation = new Tee.FadeAnimation();");
					customCode.Add("   fadeAnimation.duration = 5000;");
					customCode.Add("   fadeAnimation.fade.series = true;");
					customCode.Add("   fadeAnimation.fade.marks = true;");
					customCode.Add("   animation.mode = \"linear\"; ");
					customCode.Add("   fadeAnimation.mode = \"linear\";");
					customCode.Add("   animation.items.push(fadeAnimation);");
					customCode.Add("   ");
					customCode.Add("   animation.animate(chart1);");

					customCode.Add("  setTimeout(manualLoop, 6000); ");

					customCode.Add(wChart3.Export.Image.JScript.ChartName + ".axes.bottom.labels.format.font.fill = \"rgba(0,0,0,0.6)\";");
					customCode.Add(wChart3.Export.Image.JScript.ChartName + ".axes.bottom.labels.format.font.setSize(\"10px\");");
					customCode.Add(wChart3.Export.Image.JScript.ChartName + ".series.items[0].marks.transparent = true;");
				}
				else
				{
					Steema.TeeChart.Styles.Line line = new Steema.TeeChart.Styles.Line();
					wChart3.Series.Add(line);
				}

				if (wChart3.Series[0] is Steema.TeeChart.Styles.Line)
					wChart3.Series[0].FillSampleValues(100);
				else
					wChart3.Series[0].FillSampleValues();

				wChart3.Export.Image.JScript.CustomCode = customCode.ToArray();

				System.IO.MemoryStream tempStream2 = new MemoryStream();

				tempStream2 = new System.IO.MemoryStream();
				wChart3.Export.Image.JScript.Width = width;
				wChart3.Export.Image.JScript.Height = height;
				wChart3.Export.Image.JScript.Save(tempStream2);

				tempStream2.Position = 0;

				byte[] output = ReadFully(tempStream2);

				Response.ContentType = "text/html";
				Response.Body.WriteAsync(output, 0, output.Length);

			}
		}
		public static byte[] ReadFully(System.IO.MemoryStream input)
		{
			byte[] buffer = new byte[16 * 1024];
			using (MemoryStream ms = new MemoryStream())
			{
				int read;
				while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
				{
					ms.Write(buffer, 0, read);
				}
				return ms.ToArray();
			}

		}
	}

}
