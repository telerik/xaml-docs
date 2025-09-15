---
title: ScatterBubbleSeries
page_title: ScatterBubbleSeries
description: Check our &quot;ScatterBubbleSeries&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-series-scatterbubbleseries
tags: ScatterBubbleSeries
published: True
position: 1
---

# ScatterBubbleSeries

The scatter bubble series is used to visualize three dimensional data. Each entity in the data set is represented by a bubble shape. Two of the data's dimensions determine the bubble's position and the third determines its size.

## Declaratively defined series

You can use the following definition to display a simple ScatterBubbleSeries:

#### __XAML__
```XAML
	<telerik:RadCartesianChart>
		<telerik:RadCartesianChart.HorizontalAxis>
			<telerik:LinearAxis />
		</telerik:RadCartesianChart.HorizontalAxis>
		<telerik:RadCartesianChart.VerticalAxis>
			<telerik:LinearAxis />
		</telerik:RadCartesianChart.VerticalAxis>
		<telerik:RadCartesianChart.Series>
			<telerik:ScatterBubbleSeries ShowLabels="True" >
				<telerik:ScatterBubbleSeries.DataPoints>
					<telerik:ScatterBubbleDataPoint BubbleSize="50" XValue="1" YValue="20" />
					<telerik:ScatterBubbleDataPoint BubbleSize="100" XValue="2" YValue="8" />
					<telerik:ScatterBubbleDataPoint BubbleSize="70" XValue="3" YValue="13" />
					<telerik:ScatterBubbleDataPoint BubbleSize="50" XValue="4" YValue="20" />
					<telerik:ScatterBubbleDataPoint BubbleSize="42" XValue="5" YValue="5" />
				</telerik:ScatterBubbleSeries.DataPoints>
			</telerik:ScatterBubbleSeries>
		</telerik:RadCartesianChart.Series>
	</telerik:RadCartesianChart>
```

The following image demonstrates the end result:
![radchartview-series-scatterbubbleseries](images/radchartview-series-scatterbubbleseries_01.png)

## Data bound series

You can use the __XValueBinding__, __YValueBinding__ and the __BubbleSizeBinding__ properties of the ScatterBubbleSeries to bind the DataPoints’ properties to the properties from your view models.

#### __C#__
```C#
	public class PlotInfo
	{
		public double XVal { get; set; }
		public double YVal { get; set; }
		public double Size { get; set; }
	}

	//.......
	this.DataContext = new ObservableCollection<PlotInfo>
	{
		new PlotInfo { XVal = 4, YVal = 20, Size = 50, },
		//....
	};
```
	
#### __XAML__
```XAML
	<telerik:ScatterBubbleSeries ItemsSource="{Binding}" YValueBinding="YVal"  XValueBinding="XVal" BubbleSizeBinding="Size" />
```

>See the [Create Data-Bound Chart]({%slug radchartview-series-databinding%}) for more information on data binding in the RadChartView suite

## Features

The series supports all standard features exposed by all other categorical series. However, the specification of the series brings few additional functionalities which are listed below:

* __DataPointLegendSettings__ - the series supports two types of legend settings, the first one is the common SeriesLegendSettings which can be used with all types of series and it maps each legend item to a series. The series supports an additional DataPointLegendSettings which maps the legend items per data point. 

	#### __XAML__
	```XAML
		<telerik:ScatterBubbleSeries.LegendSettings>
			<telerik:DataPointLegendSettings/>
		</telerik:ScatterBubbleSeries.LegendSettings>
	```
	
	![radchartview-series-scatterbubbleseries](images/radchartview-series-scatterbubbleseries_02.png)
	
* __PaletteMode__ – the ScatterBubbleSeries supports two modes that determine whether the applied palette should be applied per series or per data point. The mode can be controlled through the PalleteMode property. The modes are called Series and DataPoint.

	The following image demonstrates the __DataPoint__ PaletteMode with the __Windows8 palette__ applied:  
	![radchartview-series-scatterbubbleseries](images/radchartview-series-scatterbubbleseries_03.png)

	Setting the PaletteMode to Series will apply different color for each series defined in the chart.

* __Hover interactivity__ – RadCartesianChart exposes a property called HoverMode. This property can be used only by the bubble and bar series. If it is set to “FadeOtherSeries”, when you mouse over a data point, the bubbles from all other series will fade out. The default value of the property is “None”.

	#### __XAML__
	```XAML
		<telerik:RadCartesianChart HoverMode="FadeOtherSeries">
	```
	
	![radchartview-series-scatterbubbleseries](images/radchartview-series-scatterbubbleseries_04.png)
	
* __BubbleSizeSelector__ – this feature allows you to customize the size of each bubble. The ScatterBubbleSeries exposes a __BubbleSizeSelector__ property that accepts a property of type __ChartBubbleSizeSelector__. 

	The size of the bubbles is always determined by the BubbleSizeSelector. By default the series uses the __AbsoluteBubbleSizeSelector__ which returns the BubbleSize value of the data point. There are two built-in size selectors – the __AbsoluteBubbleSizeSelector__ and the __RelativeBubbleSizeSelector__. The absolute selector is simple and it always returns the __BubbleSize__ value. If your business items contain the size in pixels, you can use the default selector. 

	On the other hand the relative size selector is more complex and it takes into account several factors when calculating the bubble size. The selector chooses a size that is relative to the maximum value in the associated series and the maximum allowed size. The maximum size of a bubble depends on the size of the chart and the MaximumSizePercent property of the selector.  By default the value of this property set to 0.2 and the maximum bubble size is 20% of the chart's size. You can adjust the RelativeBubbleSizeSelector by manually set its __MinimumValue__, __MaximumValue__, __MinimumSize__, __MaximumSize__. You can use the __BubbleSizeFunction__ property to specify whether how the value should be mapped - with a __linear function, square root function, logarithmic function or a cubic function__.

## Create a custom bubble size selector

You can customize the BubbleSize of each DataPoint by creating a custom bubble size selector. The selector should derive from the abstract __ChartBubbleSizeSelector__ class which exposes a single abstract method called __SelectBubbleSize__. The method accepts an object of type __IBubbleDataPoint__ and it return the size of the bubble. You can calculate the new size based on the information in the data point object.

The following code snippet demonstrates an example implementation of a bubble size selector:

#### __C#__
```C#
    public class CustomBubbleSizeSelector : ChartBubbleSizeSelector
    {
        public static double SelectBubbleSize(double bubbleSize)
        {
            return Math.Abs(bubbleSize) / 1000;
        }

        public override RadSize SelectBubbleSize(IBubbleDataPoint dataPoint)
        {    
            double size = SelectBubbleSize(dataPoint.BubbleSize.Value);                        
            return new RadSize(size, size);
        }
    }
```

#### __XAML__
```XAML
	<FrameworkElement.Resources>
		<local:CustomBubbleSizeSelector x:Key="CustomBubbleSizeSelector" />
    </FrameworkElement.Resources>
	..........
    <telerik:ScatterBubbleSeries BubbleSizeSelector="{StaticResource selector}" >
```

>tip You can find a runnable project demonstrating the BubbleSeries in our [GitHub SDK repository](https://github.com/telerik/xaml-sdk/tree/master/ChartView/WPF/BubbleSeriesAndNegativeValues).

## See Also
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
 * [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
 * [Palettes]({%slug radchartview-features-palettes-introduction%}) 
 * [RadLegend Support]({%slug radchartview-features-radlegend-support%})
