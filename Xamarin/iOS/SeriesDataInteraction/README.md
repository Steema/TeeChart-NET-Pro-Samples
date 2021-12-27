<a href="https://www.steema.com/product/net_ios">
<img align="right" src="http://www.teechart.net/img/logos/teechart_ios.png">
</a>

SeriesDataInteraction Example
==========
(TeeChart for Xamarin.iOS)
------
The SeriesDataInteraction example intends to show how to use some of the different "Events" available in TeeChart for Xamarin.iOS. These can prove very useful if we would like to show information or perform actions when interacting with the Chart data. 
The events used are the following:
ClickBackground : Triggered when performing a touch gesture on any part of the Chart Area.
ClickSeries : Triggered when performing a touch gesture on any Series of the Chart.
ClickLegend : Fired when performing a touch gesture on any part of the Legend.
AfterDraw : This event is fired each time the Chart requires painting something on the Canvas. We don't use it in this demo, but it can be useful if we want to clear something from the Chart each time it is repainted.
ClickAxis : Triggerd when performing a touch gesture on any of the Chart Axes.
ClickTitle : Fired when performing a touch gesture on the Chart title.
This demo makes use of the Annotation Tool to show information at the point where we have performed the touch gesture. When we touch any other part of the Series the previous annotation will disappear.
In the case that we want to simulate a tooltip and make the annotation containing the information at that point disappear after a few seconds, it can be done easily by using the following code:
```
// In the case that we wanto to simulate a ToolTip which appears for one second , we can do :
await Task.Delay(1000);
annotation.Active = false;
// Also async to the ClickSeries method is required.
```
![screenshot](https://github.com/Steema/TeeChart-.NET-for-Xamarin.iOS-Unified-samples/blob/master/SeriesDataInteraction/Screenshots/Chart_SeriesDataInteraction.gif?raw=true "TeeChart.NET for Xamarin.iOS-Unified samples")

It also shows how to customise the aspect of the Chart in order to give a more professional appearance. Among which we have added a colour gradient, hidden some parts of the axes, the Seeries used as "smooth", vaious colours assigned to different parts of the Chart (labels, axes, grid lines,annotation, callout, etc). In addition it shows how to assign a specific text to the Legend.

### Requirements

You'll need TeeChart NET for Xamarin.iOS evaluation or registered version to run the example on this repository. Fully functional evaluation version can be obtained at https://www.steema.com/downloads/net_ios

------
### Author
------
Josep Lluis Jorge @joseplluisjorge