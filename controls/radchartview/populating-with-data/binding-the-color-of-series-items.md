---
title: Binding the Color of Series Items
page_title: Binding the Color of Series Items
description: Check our &quot;Binding the Color of Series Items&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-populating-with-data-binding-the-color-of-series-items
tags: binding,the,color,of,series,items
published: True
position: 4
---

# Binding the Color of Series Items

This topic demonstrates how to create charts, where each individual item, has its color bound to a property of the underlying data object.

There are small differences in the approaches used with the different series types. For the sake of the example the following series will be used. They cover the possible approaches.

* [Bar Series](#bar-series) 
* [Scatter Point Series](#scatter-point-series)
* [Pie Series](#pie-series)

The color binding is done via the `DefaultVisualStyle` or `PointTemplate` properties of the series. In case you are using one of the [lightweight render options]({%slug radchartview-features-rendering%}) (Direct2D or Bitmap), keep in mind that bindings are not support in the `DefaultVisualStyle`. Instead, use only fixed values. Also setting the `PointTemplate` property will disable the lightweight render options and the chart will fallback to the default XAML rendering.

## Example Data Model Definition

This section contains the data model used for the series examples in this article and also how to set it up.

__Example 1: Defining the data model__
<snippet id='radchartview-populating-with-data-binding-the-color-of-series-items-example_1_defining_the_data_model-cs' />

<snippet id='radchartview-populating-with-data-binding-the-color-of-series-items-example_1_defining_the_data_model-vb' />


Let's create some data so we can test the result.

__Example 2: Populating the data collection__
<snippet id='radchartview-populating-with-data-binding-the-color-of-series-items-example_2_populating_the_data_collection-cs' />

<snippet id='radchartview-populating-with-data-binding-the-color-of-series-items-example_2_populating_the_data_collection-vb' />



## Bar Series      

Here is a sample chart with __BarSeries__ defined in Xaml.

__Example 3: BarSeries definition__
<snippet id='radchartview-populating-with-data-binding-the-color-of-series-items-example_3_barseries_definition-xaml' />


You can see the data model used for this example in the [Example Data Model Definition](#example-data-model-definition) section.

There are couple approaches which could be used to bind the color from the data object to the fill of the data point visual (the bar).
	
* __Use the DefaultVisualStyle property of the series.__ You can use this to target the default visual of the series and bind its properties to the data model object.
	
	Using the data model from this article's example you can bind the Color property from the ChartData class.

	__Example 4: Setting BarSeries DefaultVisualStyle__
	<snippet id='radchartview-populating-with-data-binding-the-color-of-series-items-example_4_setting_barseries_defaultvisualstyle-xaml' />

	
* __Use the PointTemplate property of the series.__ In this case you can define a DataTemplate containing a custom visual element for the data points and bind its color property (Background or Fill for example) to the property from the data model. 
	
	Using the data model from this article's example you can bind the Color property from the ChartData class.

	__Example 5: Setting BarSeries PointTemplate__
	<snippet id='radchartview-populating-with-data-binding-the-color-of-series-items-example_5_setting_barseries_pointtemplate-xaml' />

	
	The DataItem in the binding's path points to the custom ChartData model.

>tip The __recommended__ approach for binding the color is to use the __DefaultVisualStyle__. This is because the PointTemplate creates an additional ContentPresenter for each data point visual which means a bit more rendering time for the framework. 

You can use those approaches with most series types of the chart.

#### __Figure 1: Different colored bars__
![Telerik UI for WPF RadChartView BarSeries with differently colored bars](images/RadChartView-binding_colors_0.png)

## Scatter Point Series      

Here is a sample chart with __ScatterPointSeries__ defined in XAML.

__Example 3: ScatterPointSeries definition__
<snippet id='radchartview-populating-with-data-binding-the-color-of-series-items-example_3_scatterpointseries_definition-xaml' />


You can see the data model used for this example in the [Example Data Model Definition](#example-data-model-definition) section.

The ScatterPointSeries can be customized using the same manner as with the [BarSeries](#bar-series). There are two small differences which could be applied.

>As all scatter series, ScatterPointSeries requires the RadCartesianChart to define two LinearAxis as a vertical and horizontal axis.

* When using __DefaultVisualStyle__ you will need to target a different UI element - a Path in this case. And also you will need to define the size (Width and Height) of the Path.

	__Example 6: Setting Point Series DefaultVisualStyle__
	<snippet id='radchartview-populating-with-data-binding-the-color-of-series-items-example_6_setting_point_series_defaultvisualstyle-xaml' />

	
	> The data context passed in the DefaultVisualStyle of the ScatterPointSeries (and several other series) is not the DataPoint object, but the context of the series. In this case the DataPoint is stored in the Tag property of the Path.

* When using __PointTemplate__ the most common shape you will use is an ellipse so you can define an Ellipse element in the template. 
	
	__Example 7: Setting Point Series PointTemplate__
	<snippet id='radchartview-populating-with-data-binding-the-color-of-series-items-example_7_setting_point_series_pointtemplate-xaml' />


You can see the data model used for this example in the [Example Data Model Definition](#example-data-model-definition) section.
	
#### __Figure 2: Different colored points__
![Telerik UI for WPF RadChartView ScatterPointSeries with differently colored points](images/RadChartView-binding_colors_1.png)

## Pie Series      

Similar to the [BarSeries](#bar-series) the PieSeries uses a default visual style to customize the appearance of the pie slices. The Style should target a Path element and it is applied to the __DefaultSliceStyle__ property of the series.

__Example 8: Setting Pie Series default visual style__
<snippet id='radchartview-populating-with-data-binding-the-color-of-series-items-example_8_setting_pie_series_default_visual_style-xaml' />


You can see the data model used for this example in the [Example Data Model Definition](#example-data-model-definition) section.

#### __Figure 3: Different colored pie slices__
![Telerik UI for WPF RadPieChart with differently colored pie slices](images/RadChartView-binding_colors_2.png)
		
## See Also
 * [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
 * [Customizing CartesianChart Series]({%slug radchartview-styles-and-templates-customizing-cartesianchart-series%})
