---
title: FunnelSeries
page_title: FunnelSeries
description: Check our &quot;FunnelSeries&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-series-funnelchart-funnelseries
tags: funnelseries
published: True
position: 0
---

# FunnelSeries

The __FunnelSeries__ displays a single series of data in progressively decreasing or increasing proportions, organized in segments, where each segment represents the value for the particular item from the series. The size of each segment is determined by the value of the corresponding series item.

* [Declaratively Defined Series](#declaratively-defined-series)
* [Properties](#properties)
* [Data Binding](#data-binding)
* [Label Connectors](#label-connectors)
* [Styling the Series](#styling-the-series)

## Declaratively defined series

You can use the following definition to display a simple FunnelSeries:        

__Example 1: Declaring an FunnelSeries in XAML__
```XAML
	<telerik:RadFunnelChart Palette="Windows8">
		<telerik:FunnelSeries>
			<telerik:FunnelSeries.DataPoints>
				<telerik:FunnelDataPoint Value="100" Label="100 %"/>
				<telerik:FunnelDataPoint Value="80" Label="80 %"/>
				<telerik:FunnelDataPoint Value="58" Label="58 %"/>
				<telerik:FunnelDataPoint Value="40" Label="40 %"/>
				<telerik:FunnelDataPoint Value="25" Label="25 %"/>
			</telerik:FunnelSeries.DataPoints>
		</telerik:FunnelSeries>
	</telerik:RadFunnelChart>	
```

#### __Figure 1: FunnelSeries visual appearance__
![ radchartview-series-funnelchart-funnelseries](images/radchartview-series-funnelseries.png)

## Properties

* __ValueBinding__: A property of type __DataPointBinding__ that gets or sets the property path that determines the value of the data point.
* __DataPoints__: A property of type __ElementCollection__ of __FunnelDataPoints__ that gets the collection associated with the series.
* __IsDynamicHeight__: A __boolean__ property that gets or sets if all segments in the series have the same height or the height of every segment is set according to its value. Default value is true.
* __IsDynamicSlope__: A __boolean__ property that gets or sets a value indicating whether the form of each segment will be based on the ratio between the value from the current and the next segment. Default value is false.
* __LabelFormat__: A property of type __string__ that gets or sets the string used to format the default label of the Segments which is the Label of the FunnelDataPoint.
* __NeckRatio__: A property of type __float__ that gets or sets a value indicating the ratio between the top and the bottom bases of the whole funnel series. 

>This property can take effect only if the __Telerik.Windows.Controls.ChartView.FunnelSeries.IsDynamicSlope__ property is set to false.

* __SegmentSpacing__: A property of type __int__ that gets or sets a value indicating the space between the funnel segments in pixels.
* __SegmentStyles__: A __ObservableCollection__ of __Styles__ that gets the styles applied to every segment in the series. 

## Data Binding

You can use the ValueBinding property of the FunnelSeries to bind the DataPoint property to the property from your view models.

__Example 2: Defining the view model__

```C#
	public class PlotInfo
    {
        public double Value { get; set; }
    }

	//.......
	this.DataContext = new ObservableCollection<PlotInfo>
	{
		new PlotInfo() { Value = 100},
		//....
	};
```	

__Example 3: Specify a FunnelSeries in XAML__
```XAML	
	<telerik:FunnelSeries ItemsSource="{Binding}" ValueBinding="Value" />
```

>See the [Create Data-Bound Chart]({%slug radchartview-series-databinding%}) for more information on data binding in the RadChartView suite.

## Label Connectors

FunnelSeries supports drawing of connector lines between the series' data points and their labels. In order to enable this feature you can set the chart series' __LabelConnectorsSettings__ property. The property accepts an object of type __ChartSeriesLabelConnectorsSettings__ which exposes the following properties:

* __FadeOpacity__: A property of type __double__ that gets or sets the opacity that is applied to the label connectors when the series is faded by the chart's hover interactivity.
* __MinLengthThreshold__: A property of type __double__ that gets or sets the min length threshold. If a label connector is shorter than this threshold, the label connector is not drawn.
* __Style__: A __Style__ property that gets or sets the connectors' style. The property accepts a Style targeting a Path element.

The following example demonstrates how to set the LabelConnectorsSettings propety:

__Example 4: Set label connectors__
```XAML
	<telerik:RadFunnelChart  Margin="50 50 100 50"  Palette="Windows8" ClipToBounds="False">
		<telerik:FunnelSeries ShowLabels="True" Width="50" ClipToPlotArea="False">
			<telerik:FunnelSeries.DataPoints>
				<telerik:FunnelDataPoint Value="43.46" Label="France: 43.46%"/>
				<telerik:FunnelDataPoint Value="27.53" Label="Germany: 27.53%" />
				<telerik:FunnelDataPoint Value="15.11" Label="Belgium: 15.11%" />
				<telerik:FunnelDataPoint Value="10.35" Label="Holland: 10.35%" />
				<telerik:FunnelDataPoint Value="3.55" Label="Luxembourg: 3.55%" />
			</telerik:FunnelSeries.DataPoints>
			<telerik:FunnelSeries.LabelDefinitions>
				<telerik:ChartSeriesLabelDefinition HorizontalAlignment="Right" VerticalAlignment="Center" Margin="100 0 10 0"/>
			</telerik:FunnelSeries.LabelDefinitions>
			<telerik:FunnelSeries.LabelConnectorsSettings>
				<telerik:ChartSeriesLabelConnectorsSettings/>
			</telerik:FunnelSeries.LabelConnectorsSettings>
		</telerik:FunnelSeries>
	</telerik:RadFunnelChart>
```

#### __Figure 1: Label connectors visual appearance__
![ radchartview-series-funnelseries_labels](images/radchartview-series-funnelseries_labels.png)

## Styling the Series

You can see how to style funnel series using different properties in the [Customizing FunnelChart Series]({%slug radchartview-styles-and-templates-customizing-cartesianchart-series%}) help article.

Additionally, you can use the Palette property of the chart to change the colors of the FunnelSeries on a global scale. You can find more information about this feature in the [Palettes]({%slug radchartview-features-palettes-introduction%}) section in our help documentation.

## See Also
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
 * [Create Data-Bound Chart]({%slug radchartview-series-databinding%})