---
title: ScatterRangeBarSeries
page_title: ScatterRangeBarSeries
description: Check our &quot;ScatterRangeBarSeries&quot; (Histogram) documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-series-barseries-scatterrangebarseries
tags: scatterrangebarseries,histogram
published: True
position: 4
---

# ScatterRangeBarSeries

This series visualizes a set of rectangles (bars) representing each of the data points. The bars have numeric meaning in both directions - horizontal and vertical - and each bar is defined by horizontal and vertical start, and end values.

This series can be used to create histogram visualization. This can be done by using the properties of the data points or via the [ChartHistogramSource]({%slug radchartview-series-barseries-histogram%}#using-charthistogramsource).

## Declaratively Defined Series

The following example shows how to define `ScatterRangeBarSeries` and populate its `DataPoints` collection.

__Declaring a RangeBarSeries in XAML__
```XAML
	<telerik:RadCartesianChart Palette="Fluent">
		<telerik:RadCartesianChart.HorizontalAxis>
			<telerik:LinearAxis />
		</telerik:RadCartesianChart.HorizontalAxis>
		<telerik:RadCartesianChart.VerticalAxis>
			<telerik:LinearAxis />
		</telerik:RadCartesianChart.VerticalAxis>
		<telerik:RadCartesianChart.Grid>
			<telerik:CartesianChartGrid MajorLinesVisibility="Y" />
		</telerik:RadCartesianChart.Grid>
		<telerik:ScatterRangeBarSeries>
			<telerik:ScatterRangeBarSeries.DataPoints>
				<telerik:ScatterRangeDataPoint HorizontalLow="10" HorizontalHigh="30" VerticalLow="0" VerticalHigh="5"/>
				<telerik:ScatterRangeDataPoint HorizontalLow="30" HorizontalHigh="40" VerticalLow="0" VerticalHigh="6"/>
				<telerik:ScatterRangeDataPoint HorizontalLow="40" HorizontalHigh="60" VerticalLow="0" VerticalHigh="5.5"/>
				<telerik:ScatterRangeDataPoint HorizontalLow="60" HorizontalHigh="65" VerticalLow="0" VerticalHigh="6"/>
				<telerik:ScatterRangeDataPoint HorizontalLow="65" HorizontalHigh="70" VerticalLow="0" VerticalHigh="7"/>
				<telerik:ScatterRangeDataPoint HorizontalLow="70" HorizontalHigh="110" VerticalLow="0" VerticalHigh="6.5"/>
			</telerik:ScatterRangeBarSeries.DataPoints>
		</telerik:ScatterRangeBarSeries>
	</telerik:RadCartesianChart>
```

__ScatterRangeBarSeries visual appearance__  

![Picture showing WPF ScatterRangeBarSeries with basic setup](images/radchartview-series-scatterrangebarseries-0.png)
	
## Data Binding

To bind the series to a collection of business objects, use its `ItemsSource` property. The series will create a new `ScatterRangeDataPoint` for each data item in the collection. To map the data item properties to the data point, use the `HorizontalLowBinding`, `HorizontalHighBinding`, `VerticalLowBinding` and `VerticalHighBinding` properties of the series.

__Defining the data item model__  
```C#
	public class ScatterBarInfo
	{
		public double HorizontalLow { get; set; }
		public double HorizontalHigh { get; set; }
		public double VerticalLow { get; set; }
		public double VerticalHigh { get; set; }

 		public ScatterBarInfo(double horizontalLow, double horizontalHigh, double verticalLow, double verticalHigh)
		{
			this.HorizontalLow = horizontalLow;
			this.HorizontalHigh = horizontalHigh;
			this.VerticalLow = verticalLow;
			this.VerticalHigh = verticalHigh;
		}
	}
```		

__Populating with data__
```C#
	public MyUserControl() 
	{ 
		InitializeComponent();  
	 
		var source = new ObservableCollection<ScatterBarInfo>();
		source.Add(new ScatterBarInfo(0, 4, 8, 10));
		source.Add(new ScatterBarInfo(6, 10, 1, 6));
		source.Add(new ScatterBarInfo(1, 1.5, 1, 6.5));
		source.Add(new ScatterBarInfo(3, 3.5, 4, 5));
		source.Add(new ScatterBarInfo(8, 11, 7, 11));
		this.scatterRangeBarSeries.ItemsSource = source; 
	} 
```

__Specifying ScatterRangeBarSeries in XAML and setting its binding properties__
```XAML
	<telerik:ScatterRangeBarSeries x:Name="scatterRangeBarSeries" 
				   HorizontalLowBinding="HorizontalLow" 
                                   HorizontalHighBinding="HorizontalHigh"
                                   VerticalLowBinding="VerticalLow"
                                   VerticalHighBinding="VerticalHigh"
				   ItemsSource="{Binding}" />
```
	
>See the [Create Data-Bound Chart]({%slug radchartview-series-databinding%}) for more information on data binding in the RadChartView suite.

__ScatterRangeBarSeries populated with data binding__  

![Picture showing WPF ScatterRangeBarSeries populated with a collection of data items](images/radchartview-series-scatterrangebarseries-1.png)

## Palette Coloring

The chart provides a built-in palette support that allows you to automatically color each series or data points in a different color. То enable this, set the `Palette` property of the chart control. You can find more information about this feature in the [Palettes]({%slug radchartview-features-palettes-introduction%}) section in the help documentation.

To change the palette mode of `ScatterRangeBarSeries`, set its `PaletteMode` property. The available options are `Series` and `DataPoint` (default value). This determines if each data point in the same series should use a different color from the palette, or the entire series (all data points) should have the same color.

## Styling the Series

You can see how to style area series using different properties in the [RangeBarSeries section]({%slug radchartview-styles-and-templates-customizing-cartesianchart-series%}) of the Customizing CartesianChart Series help article.

## See Also
 * [Getting Started]({%slug radchartview-introduction%})
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
 * [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
