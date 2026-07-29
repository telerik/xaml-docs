---
title: ErrorBarSeries
page_title: ErrorBarSeries
description: RadChartView for WPF Error Bar Series for {{ site.framework_name }} allows you to display error bars chart visualization.
slug: radchartview-series-errorbarseries
tags: error,uncertainty,box,plot,whiskers,errorbar
published: True
position: 0
---

# ErrorBarSeries

This type of series visualizes its data points using error bar shapes. 

The error bar shape allows you to display a error or uncertainty in the plotted data. The shape consists of a single line with caps at the two ends. An additional marker that shows the expected measure can be displayed too.

To start using the series, add it in the `Series` collection of the chart and populate its `DataPoints` collection (or the [ItemsSource](#data-binding)).

__Defining ErrorBarSeries in XAML__
<snippet id='radchartview-series-cartesianchart-series-bar-series-errorbarseries-defining_errorbarseries_in_xaml-xaml' />


__ErrorBarSeries example__  

![radchartview-series-errorbar](images/radchartview-series-errorbarseries-0.png)

>tip The error bar data points do not implement automatic coercion of the input values. This means that the provided values must be correct in order to display a proper visual element. Low must be smaller than High and the Value must be between low and high.

## Showing Value Marker

The series allows you to display an additional marker that shows the expected measure of the data point. To enable this, set the `ShowMarker` property of the `ErrorBarShape` element and the Value property of the `ErrorBarDataPoint` (or `ValueBinding` when using the [ItemsSource](#data-binding).

__Showing ErrorBarSeries markers__
<snippet id='radchartview-series-cartesianchart-series-bar-series-errorbarseries-showing_errorbarseries_markers-xaml' />


__ErrorBar markers__  

![radchartview-series-errorbar](images/radchartview-series-errorbarseries-1.png)

## Data Binding

The ErrorBarSeries works with data point objects of type ErrorBarDataPoint. In a data binding scenario a [ErrorBarDataPoint]({%slug radchartview-getting-started-data-point%}) will be created for each data item in the __ItemsSource__ collection of the series. To map the properties of the business objects from the ItemsSource to the properties of the data point object, use the binding properties of the series:

* __CategoryBinding__
* __LowBinding__
* __HighBinding__
* __ValueBinding__

The following example shows how to create a simple object describing the error bar and populate the series with a sample collection.

__Defining the model__
<snippet id='radchartview-series-cartesianchart-series-bar-series-errorbarseries-defining_the_model-cs' />


__Populating the data__
<snippet id='radchartview-series-cartesianchart-series-bar-series-errorbarseries-populating_the_data-cs' />


__Defining ErrorBarSeries in data binding scenario__
<snippet id='radchartview-series-cartesianchart-series-bar-series-errorbarseries-defining_errorbarseries_in_data_binding_scenario-xaml' />


__ErrorBarSeries data binding example__  

![{{ site.framework_name }} RadChartView ErrorBarSeries Data Binding Example](images/radchartview-series-errorbarseries-2.png)

Read more about the data binding support in the [Create Data-Bound Chart]({%slug radchartview-series-databinding%}) article.

## Customizing the Appearance

The appearance of the error bar visual can be modified using the `DefaultVisualStyle` property of the series. The style should target the `ErrorBarShape` element. Read more in the [ErrorBar section]({%slug radchartview-styles-and-templates-customizing-cartesianchart-series%}#customizing-error-bar-series) of the Customizing CartesianChart Series help article.

## See Also
 * [Getting Started]({%slug radchartview-introduction%})
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
 * [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
