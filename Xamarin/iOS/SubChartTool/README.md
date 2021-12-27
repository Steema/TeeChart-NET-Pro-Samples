<a href="https://www.steema.com/product/net_ios">
<img align="right" src="http://www.teechart.net/img/logos/teechart_ios.png">
</a>

SubChart Tool Demo
==================
 
In the demo we use the SubChart Tool available with TChart for Xamarin.iOS. This Tool lets us create a limitless number of Charts within the area of the main Chart. Each and everyone of these Charts can be personalised to our own taste, as if it were the base Chart, by placing it in the position we like and determining its size. We can use any type of DataSeries to populate the Chart.

Example code to create and use of the SubChart Tool:

            tChart1.Tools.Add(subChartTool1 = new Steema.TeeChart.Tools.SubChartTool());
 	 
 
 	            tChart1.Panning.Active = true;
 	 
 
 	            subchart1 = subChartTool1.Charts.AddChart("Chart0");
 	            subchart1.Panel.Color = Color.Transparent;
 	            subchart1.Series.Add(new Bar());
 	            subchart1.Aspect.View3D = false;
 	            subchart1.Series[0].FillSampleValues();
 	            subchart1.Series[0].ColorEach = true;
 	            (subchart1.Series[0] as Bar).Pen.Visible = false;
 	            subchart1[0].Marks.Visible = false;
 	            subchart1[0].Chart.Title.Visible = false;
 	            subchart1[0].Chart.Walls.Back.Transparent = true;
 	            subchart1[0].Chart.Panel.Transparent = true;
 	            subchart1[0].Chart.Axes.Left.Grid.Visible = false;
 	 
 
 	            subChartTool1.Charts[0].Chart.Walls.Visible = false;
 	 
 
 	            for (int j = 0; j < subChartTool1.Charts.Count; j++)
 	            {
 	                subchart1 = subChartTool1.Charts[j].Chart;
 	                for (int i = 0; i < line1.Count; i++)
 	                {
 	                    subchart1[0].Add(line1.XValues[i], line1.YValues[i]);
 	                }
 	            }
 
            subChartTool1.Charts[0].Left = 50;
 	            subChartTool1.Charts[0].Top = 390;
 	            subChartTool1.Charts[0].Width = 325;

[![screenshot](https://github.com/Steema/TeeChart-.NET-for-Xamarin.iOS-Unified-samples/blob/master/SubChartTool/Screenshots/SubChartTool1.png)](https://github.com/Steema/TeeChart-.NET-for-Xamarin.iOS-Unified-samples/blob/master/SubChartTool/Screenshots/SubChartTool.png "TeeChart.Net for Xamarin.iOS")

### Requirements

You'll need TeeChart NET for Xamarin.iOS evaluation or registered version to run the example on this repository. Fully functional evaluation version can be obtained at https://www.steema.com/downloads/net_ios

------
### Author
------
Josep Lluis Jorge @joseplluisjorge
