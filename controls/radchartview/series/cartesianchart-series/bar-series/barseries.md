---
title: BarSeries
page_title: BarSeries
description: Check our &quot;BarSeries&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-series-barseries
tags: barseries
published: True
position: 0
---

# BarSeries

This series is visualized on the screen as separate rectangles representing each of the data points. The height (width) of the box is the distance between the point’s numerical value and the categorical axis that plots the point.     

* [Declaratively Defined Series](#declaratively-defined-series)
* [Properties](#properties)
* [Data Binding](#data-binding)
* [Features](#features)
* [Styling the Series](#styling-the-series)


## Declaratively defined series

You can use the definition from __Example 1__ to display a BarSeries.

__Example 1: Declaring a BarSeries in XAML__
<snippet id='radchartview-series-cartesianchart-series-bar-series-barseries-example_1_declaring_a_barseries_in_xaml-xaml' />


#### __Figure 1: BarSeries visual appearance__  
![Telerik UI for WPF RadChartView BarSeries visual appearance](images/radchartview-series-barseries.png)

## Properties

* __CategoryBinding__: A property of type __DataPointBinding__ that gets or sets the property path that determines the category value of the data point.
* __ValueBinding__: A property of type __DataPointBinding__ that gets or sets the property path that determines the value of the data point.
* __OriginValue__: A property of type double which controls the origin value from which the series should start drawing on the numeric axis (LinearAxis or LogarithmicAxis).
* __LegendSettings__: A property of type ChartLegendSettings that gets or sets the legend setting.
* __PaletteMode__: A property of type __SeriesPaletteMode__ that gets or sets the mode that determines how the pallete should be applied. This property will be applied only if the Palette property of the chart is set. The pallete mode is an enumeration and it allows the following values: 
	* __Series__: Default value. When set every series will be applied a different color.
	* __DataPoint__: When set each data point will have a different color.

## Data Binding

You can use the ValueBinding and CategoryBinding properties of the BarSeries to bind the DataPoints’ properties to the properties from your view models.

__Example 2: Defining the view model__

<snippet id='radchartview-series-cartesianchart-series-bar-series-barseries-example_2_defining_the_view_model-cs' />


__Example 3: Specify a BarSeries in XAML__
<snippet id='radchartview-series-cartesianchart-series-bar-series-barseries-example_3_specify_a_barseries_in_xaml-xaml' />


>See the [Create Data-Bound Chart]({%slug radchartview-series-databinding%}) for more information on data binding in the RadChartView suite.

## Features

The series supports all standard features exposed by all other categorical series. However, the specification of the series brings few additional functionalities which are listed below:

* __DataPointLegendSettings__: The series supports two types of legend settings, the first one is the common SeriesLegendSettings which can be used with all types of series and it maps each legend item to a series. The series supports an additional DataPointLegendSettings which maps the legend items per data point.

__Example 4: Specify LegendSettings of the BarSeries__
<snippet id='radchartview-series-cartesianchart-series-bar-series-barseries-example_4_specify_legendsettings_of_the_barseries-xaml' />


#### __Figure 2: Setting BarSeries legend settings__
![Telerik UI for WPF RadChartView BarSeries with data point legend settings](images/radchartview-series-barseries-legendsettings.PNG)

* __PaletteMode__: The BarSeries supports two modes that determine whether the applied palette should be applied per series or per data point. The mode can be controlled through the PalleteMode property. The modes are called Series and DataPoint. The following image demonstrates the DataPoint PaletteMode with the Windows8 palette applied:
	
#### __Figure 3: Specify BarSeries pallete mode__
![Telerik UI for WPF RadChartView BarSeries using DataPoint palette mode](images/radchartview-series-barseries-palletemode.PNG)
	
Setting the PaletteMode to __Series__ will apply different color for each series defined in the chart.

* __Hover interactivity__: RadCartesianChart exposes a property called HoverMode. This property can be used only by the bar and bubble series. If it is set to “FadeOtherSeries”, when you mouse over a data point, the bar from all other series will fade out. The default value of the property is “None”.

__Example 8: Setting the HoverMode of the RadCartesianChart__
<snippet id='radchartview-series-cartesianchart-series-bar-series-barseries-example_8_setting_the_hovermode_of_the_radcartesianchart-xaml' />


#### __Figure 4: Hover interactivity in BarSeries__ 
![Telerik UI for WPF RadChartView BarSeries hover interaction fading other series](images/radchartview-series-barseries-hovermode.PNG)

## Styling the Series

You can see how to style area series using different properties in the [BarSeries section]({%slug radchartview-styles-and-templates-customizing-cartesianchart-series%}) of the Customizing CartesianChart Series help article.

Additionally, you can use the Palette property of the chart to change the colors of the BarSeries on a global scale. You can find more information about this feature in the [Palettes]({%slug radchartview-features-palettes-introduction%}) section in our help documentation.

## See Also
 * [Getting Started]({%slug radchartview-introduction%})
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
 * [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
