<a href="https://www.steema.com/product/net_ios">
<img align="right" src="http://www.teechart.net/img/logos/teechart_ios.png">
</a>

Chart Scroll Demo
=================

The Chart_Scroll demo shows you how to easily add Scroll/Pan functionality to your application with only a few lines of code.
TeeChart for Xamarin.iOS offers two ways to add this functionality.

1) By assigning the specific number of points we want to be visible on the screen and then move through all the data of the Chart one page at a time. In order to achieve this we must use the MaxPointPerPage property:
```
   // Before doing anything else we need to make sure that the Scroll/Pan function is activated.
	Chart.Panning.Active = true;

   // In the case that we only want to allow Scrolling in one direction, we can use the following line of cade:
	Chart.Panning.Allow = ScrollModes.Horizontal;

   // We can now assign the number of points per page we would like to appear.
	Chart.Page.MaxPointsPerPage = 10;	
```
2) Another way of visual moving through the data is by making use of the UISlider control, also shown in the example. The code to use is the following:

```
   // Scroll by using UISlider and SetMinMax
   // Assign an inicial min and max value
   	Chart.Axes.Bottom.SetMinMax(0, 10);
   // Create the UISlider, to which we will assign some inicial values
   	UISlider slider1 = new UISlider(new CoreGraphics.CGRect(0,this.View.Frame.Height - 25,this.View.Frame.Width, 20));
   	slider1.MinValue = 5;
   	slider1.MaxValue = 95;
   	slider1.Value = 5.0f; // the current value
   	slider1.ValueChanged += (sender, e) => Chart.Axes.Bottom.SetMinMax(((UISlider)sender).Value - 5, ((UISlider)sender).Value + 5);
            
   // Add the Chart and the Slider to our View
   	View.AddSubview(Chart);
   	View.AddSubview(slider1);
```
![screenshot](https://raw.githubusercontent.com/Steema/TeeChart-.NET-for-Xamarin.iOS-Unified-samples/master/Chart_Scroll/Screenshots/Chart_Scroll.png "TeeChart.Net for Xamarin.iOS")


This example also shows how to modify the size of the labels on the left axis of the Chart, so that we can choose the space to leave between the axis title and the labels.

------
### Author
------
Josep Lluis Jorge @joseplluisjorge