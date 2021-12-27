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

namespace WebDemo
{
	/// <summary>
    /// Summary description for JLineChart1.
	/// </summary>
	public partial class JPointsChart1 : System.Web.UI.Page
	{
		
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

		protected void Page_Load(object sender, System.EventArgs e)
		{
            
			//WebChart1.Chart.Panel.BorderRound = 30;
			Steema.TeeChart.Chart ch1=WebChart1.Chart;	
			ch1.Series.RemoveAllSeries();
			ch1.Series.Add(new Steema.TeeChart.Styles.Points());
            ch1.Series.Add(new Steema.TeeChart.Styles.Points());
            //((Steema.TeeChart.Styles.Line)(ch1.Series[0])).LinePen.Width = 3;
            ch1.Series[0].FillSampleValues(30);
            ch1.Series[1].FillSampleValues(30);
			ch1.Legend.Shadow.Visible = false;
			ch1.Legend.Visible = false;

            ((Steema.TeeChart.Styles.Points)(ch1.Series[0])).Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            ((Steema.TeeChart.Styles.Points)(ch1.Series[1])).Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;

            /*((Steema.TeeChart.Styles.Points)(ch1.Series[0])).Pointer.VertSize = 10;
            ((Steema.TeeChart.Styles.Points)(ch1.Series[0])).Pointer.HorizSize = 10;
            ((Steema.TeeChart.Styles.Points)(ch1.Series[1])).Pointer.VertSize = 10;
            ((Steema.TeeChart.Styles.Points)(ch1.Series[1])).Pointer.HorizSize = 10;*/

            ch1.Export.Image.JScript.SourceUnits.Add("teechart-animations.js");

            //apply some custom code, runs just before Javascript Chart draw
            string[] customCode = new string[] {
              "changeTheme(\"minimal\");",
              "changePalette(\"seaWash\");",

              "//function series",
              "  ",
              "  var avg = new Tee.Line();",
              "  avg.title = \"Average\";",
              "  var avgVals = new Array();",
              "  ",
              "  for (i = 0; i < Series1.data.values.length; i++)",
              "  {",
              "    avgVals[i] = (Series1.data.values[i]+points2.data.values[i]) / 2;",
              "  }",
              "  ",
              "  avg.data.values = avgVals;",
              "  avg.data.x = Series1.data.x;",
              "  avg.format.stroke.size=2;",
              "  avg.smooth=0.5;",
              "  " + WebChart1.ClientID + "_chart.addSeries(avg);",

              "//tooltip",
              "tip=new Tee.ToolTip(" + WebChart1.ClientID + "_chart);",
              "tip.render=\"dom\";",
              "tip.domStyle = \"padding-left:8px; padding-right:8px; padding-top:0px; padding-bottom:4px; margin-left:5px; margin-top:0px; \";",
              "tip.domStyle = tip.domStyle + \"background-color:#FCFCFC; border-radius:4px 4px; color:#FFF; \";",
              "tip.domStyle = tip.domStyle + \"border-style:solid;border-color:#A3A3AF;border-width:3; z-index:1000;\";",
              "" + WebChart1.ClientID + "_chart.tools.add(tip);",
              "tip.onhide=function() { scaling=0; poindex=-1; }",

              "tip.ongettext=function( tool, text, series, index) { ",
              "  var s = '<font face=\"verdana\" color=\"black\" size=\"1\"><strong>'+ series.title+'</strong></font>';",
              "	    s = s + '<br/><font face=\"verdana\" color=\"darkblue\" size=\"1\">Series point: <strong>'+ index.toFixed(0)+'</strong></font>';",
              "      s =	s +'<br/><font face=\"verdana\" color=\"red\" size=\"1\">Value: '+series.data.values[index].toFixed(2)+'</font>';  ",
              "   return s;",
              "}",

              "  //animation",
              "",
              "animation=new Tee.SeriesAnimation();",
              "animation.duration=1500;",
              "animation.kind=\"each\";",
              "fadeAnimation=new Tee.FadeAnimation();",
              "fadeAnimation.duration=500;",
              "fadeAnimation.fade.series=true;",
              "fadeAnimation.fade.marks=true;",
              "animation.mode = \"linear\"; ",
              "fadeAnimation.mode = \"linear\";",
              "animation.items.push(fadeAnimation);",
              "",
              "animation.animate(" + WebChart1.ClientID + "_chart);"

              };

            ch1.Export.Image.JScript.CustomCode = customCode;

		}

	}
}
