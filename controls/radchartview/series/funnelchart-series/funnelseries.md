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
<snippet id='radchartview-series-funnelchart-series-funnelseries-example_1_declaring_an_funnelseries_in_xaml-xaml' />


#### __Figure 1: FunnelSeries visual appearance__
![Telerik UI for WPF RadChartView FunnelSeries visual appearance](images/radchartview-series-funnelseries.png)

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

<snippet id='radchartview-series-funnelchart-series-funnelseries-example_2_defining_the_view_model-cs' />


__Example 3: Specify a FunnelSeries in XAML__
<snippet id='radchartview-series-funnelchart-series-funnelseries-example_3_specify_a_funnelseries_in_xaml-xaml' />


>See the [Create Data-Bound Chart]({%slug radchartview-series-databinding%}) for more information on data binding in the RadChartView suite.

## Label Connectors

FunnelSeries supports drawing of connector lines between the series' data points and their labels. In order to enable this feature you can set the chart series' __LabelConnectorsSettings__ property. The property accepts an object of type __ChartSeriesLabelConnectorsSettings__ which exposes the following properties:

* __FadeOpacity__: A property of type __double__ that gets or sets the opacity that is applied to the label connectors when the series is faded by the chart's hover interactivity.
* __MinLengthThreshold__: A property of type __double__ that gets or sets the min length threshold. If a label connector is shorter than this threshold, the label connector is not drawn.
* __Style__: A __Style__ property that gets or sets the connectors' style. The property accepts a Style targeting a Path element.

The following example demonstrates how to set the LabelConnectorsSettings propety:

__Example 4: Set label connectors__
<snippet id='radchartview-series-funnelchart-series-funnelseries-example_4_set_label_connectors-xaml' />


#### __Figure 1: Label connectors visual appearance__
![Telerik UI for WPF RadChartView FunnelSeries with data point labels](images/radchartview-series-funnelseries_labels.png)

## Styling the Series

You can see how to style funnel series using different properties in the [Customizing FunnelChart Series]({%slug radchartview-styles-and-templates-customizing-cartesianchart-series%}) help article.

Additionally, you can use the Palette property of the chart to change the colors of the FunnelSeries on a global scale. You can find more information about this feature in the [Palettes]({%slug radchartview-features-palettes-introduction%}) section in our help documentation.

## See Also
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
 * [Create Data-Bound Chart]({%slug radchartview-series-databinding%})