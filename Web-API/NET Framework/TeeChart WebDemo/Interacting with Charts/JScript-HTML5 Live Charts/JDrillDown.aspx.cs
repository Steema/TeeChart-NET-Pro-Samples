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
using Steema.TeeChart;

namespace WebDemo
{
	/// <summary>
    /// Summary description for JBarChart1.
	/// </summary>
	public partial class JDrillDownChart1 : System.Web.UI.Page
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

            double[] outerData = new double[] { 4.5, 7, 3.7, 6.2, 5.4 };

			Steema.TeeChart.Chart ch1=WebChart1.Chart;
            ch1.Panel.BorderRound = 4;
            ch1.Panel.Shadow.Visible = false;
            ch1.Panel.Pen.Visible = false;
			ch1.Series.RemoveAllSeries();
			ch1.Series.Add(new Steema.TeeChart.Styles.Bar());
            ch1.Series[0].Add(outerData);
            // Steema.TeeChart.Styles.StringList labels = new Steema.TeeChart.Styles.StringList() {"Fruit","Veg","Meat","Dairy","Frozen"};
            //For all VS versions. 
            Steema.TeeChart.Styles.StringList labels = new Steema.TeeChart.Styles.StringList();
            labels.Add("Fruit");
            labels.Add("Veg");
            labels.Add("Meat");
            labels.Add("Dairy");
            labels.Add("Frozen"); 
            ch1.Series[0].Labels = labels;
            ch1.Series[0].Marks.Visible = false;
			ch1.Legend.Shadow.Visible = false;
			ch1.Legend.Visible = false;

            ch1.Axes.Left.Title.Text = "Income ($ 000)";
            ch1.Axes.Bottom.Title.Text = "Category";

			// Apply theme
            //Steema.TeeChart.Themes.Theme.ApplyFromResource(ch1.Chart, "BlackIsBackTheme");


            /*Chart1.axes.left.title.text="Income ($ 000)";
  Chart1.axes.bottom.title.text="Category";*/

            //apply some custom code, runs just before Javascript Chart draw
            string[] customCode = new string[] {
                
                " changeTheme(\"minimal\");",

                " var innerData = [[1.5, 1, 0.7, 0.2, 1.1 ],",
                "                 [3.5, 1, 1.7, 0.5, 0.3],",
                "                 [0.5, 0.9, 1.2, 0.4, 0.7],",
                "                 [0.9, 2.1, 2.1, 0.4, 0.7],",
                "                 [2.3, 0.7, 1.1, 0.6, 0.7]];",

                " var innerLabels = [['Apples', 'Pears', 'Oranges', 'Lemons', 'Other' ],",
                "                 ['Potatoes', 'Carrots', 'Cucumbers', 'Peppers', 'Other' ],",
                "                 ['Beef', 'Lamb', 'Pork', 'Chicken', 'Other' ],",
                "                 ['Milk', 'Yoghurt', 'Butter', 'Cheese', 'Other' ],",
                "                 ['Peas', 'Chips', 'Fish', 'Pizza', 'Other' ]];",                

                //override default font sizes chart axis titles
                "  " + WebChart1.ClientID + "_chart.axes.left.title.format.font.style=\"12px Tahoma\";",
                "  " + WebChart1.ClientID + "_chart.axes.bottom.title.format.font.style=\"12px Tahoma\";",
                // Create ToolTip, setting \"render\" to \"dom\":",
                "",
                "  tip=new Tee.ToolTip(" + WebChart1.ClientID + "_chart);",
                "  tip.autoHide=true;",
                "  tip.delay=6000;",
                "  tip.render=\"dom\";",
                "",
                "  " + WebChart1.ClientID + "_chart.tools.add(tip);",
                "",
                "  // When the tip shows, create and paint a \"sub\" pie chart:",
                "",
                "  tip.onshow=function(tool,series,index) {",
                "          subChart=new Tee.Chart(\"sub\");",
                "          // optionally could apply theme - subChart.applyTheme(globalTheme);",
                "          subChart.applyTheme(\"minimal\");",
                "          subChart.applyPalette(globalPalette);",
                "          var spie1 = subChart.addSeries(new Tee.Pie());",
                "          spie1.data.values=innerData[index];",
                "          spie1.data.labels=innerLabels[index];",
                "          //subChart.legend.visible=false;",
                "          subChart.title.visible=false;",
                "          subChart.series.items[0].marks.visible=false;",
                "          subChart.draw();",
                "  }",
                "",
                "  // Return custom text, including a \"sub\" canvas where to paint the sub chart:",
                "",
                "  tip.ongettext=function( tool, text, series, index) {",
                "      var s='Series point: <strong>'+ index.toFixed(0) +'</strong><br/>Value: '+series.data.values[index].toFixed(2);",
                "      s+='<br/><br/><canvas id=\"sub\" width=\"250\" height=\"130\"></canvas>';",
                "      return s;",
                "  }",     
       
                "  //basis of alternative technique, point-click",
                "  //bar1.onclick=function(series,index,x,y) {",
                "  //  alert(\"Clicked point: \"+index);",
                "  //}"

            };
            
            ch1.Export.Image.JScript.CustomCode = customCode;

		}

	}
}
