---
title: RadChart vs. RadChartView
page_title: RadChart vs. RadChartView
description: RadChart vs. RadChartView
slug: radchartview-radchartview-vs.-radchart
tags: radchart,vs.,radchartview
published: True
position: 2
---

# RadChart vs. RadChartView



Since Q3 2011 we ship two separate charting controls - __RadChart__ and __RadChartView__. __RadChart__ allows you to visualize interactive, rich, animated charts and enables the end users to analyze complex data. It provides rich and mature functionality that covers a large spectrum of user case scenarios.
			

On the other hand, __RadChartView__ is a control that addresses some of the limitations and deficiencies that we have identified in the RadChart implementation over the years. Our [Overview]({%slug radchartview-overview%}) topic can walk you through all specifics of the __RadChartView__ control.
			

This help topic aims to compare the two controls and get you familiar with what you need to know when migrating from __RadChart__ to __RadChartView__.
			

>Generally we would encourage you to use the new __ChartView__ control for any new project development that you are starting now. As for your existing applications - the migration is possible but there is no straightforward migration path between __RadChart__ and __RadChartView__ due to the different approach taken in the development of __RadChartView__.
				

## Highlights of features and functionality

##### 1. __Performance__ - exceptional performance, intuitive and easy-to-use model and pixel-perfectness were some of the major tasks we have set for the __RadChartView__ control.
						

* We have separated the chart into several layers, where the core one is totally platform agnostic and is built on top of our custom logical tree. We call this layer the “View Model” of the chart.
								

* We have a custom property store used within the charting logical tree. It is about 5 times faster than DependencyObject in look-up time and consumes about 3 times less memory.
								

* We have an entirely custom layout and do not rely on the XAML layout system to arrange our charting view models.
								

* We have a stand-alone visualization layer that presents the chart view model. Every view model is presented by the simplest possible SL visual – e.g. __Rectangle__, __Line__, __Polyline__, etc. Still, every single aspect is fully customizable by specifying __DataTemplates__ or __Styles__.
								

* We use __Canvas__ – the only XAML panel that does not invalidate measure automatically. When a redraw of some charting part is required, we simply update the __Width__, __Height__ and __Canvas.Left__, __Canvas.Top__ properties of the corresponding visual. A simple test proved that calling __InvalidateMeasure__ of the canvas upon a change in the ViewModel degrades performance about 10 times.
								

##### 2. __Architecture__- a number of chart controls built for a specific purpose vs one monolith control (provides cleaner, simpler, and relevant API)
						

* __DataBinding__ - The presentation of the data itself in both controls is achieved by declaring chart series and filling these series with data points. The significant difference is that in __RadChartView__ the chart __Series__ utilize different visualization techiques based on the data points it represents. This is why in __RadChartView__ the Series expose an __ItemsSource__ property which has to be used to populate each __Series__ with data.
								

* __Axes__

* Both controls support [linear]({%slug radchartview-axes-axis%}) and [logarithmic]({%slug radchartview-axes-logarithmicaxis%}) axes. However, unlike the __RadChart__ logarithmic axis, the __RadChartView__ logarithmic axis is a separate type. And what is more, __RadChartView__ provides a variety of different axes: __Linear, Logarithmic, DateTime, Categorical__.
										

* DateTime support - __RadChartView__ further extends the charting __DateTime__ support by providing specific [DateTime Axes]({%slug radchartview-axes-datetimeaxes%}):
										

* __DateTimeCategoricalAxis__ - a specialized categorical axis that expects each __DataPoint__ to represent a __System.DateTime__ value. The points are grouped by a user-defined DateTime component (Year, Month, Day) and then the groups are sorted chronologically.
												

* __DateTimeContinuousAxis__ - a specialized axis that expects each __DataPoint__ to represent a __System.DateTime__ value. This axis mimics a timeline where the coordinates of each __DataPoint__ are calculated based on the position of its associated __DateTime__ value on the timeline. The base unit (or the timeline step) of the axis is calculated based on the smallest difference between any two dates.
												

* Multiple Axes - __RadChartView__ supports multiple __X-Axes__ unlike __RadChart__. Both controls support multiple __Y-Axes__ definitions. There is no limit on the number of additional axes that can be used.
										

* Radar and Polar axis - in order to display __Radar__ and __Polar Series RadChartView__ exposes these two axes. They have no alternative in __RadChart__. More details can be found in the [Polar Axis]({%slug radchartview-axes-polaraxis%}) topic as well as in the __Series__ section of this documentation.
										

* Automatic Range - In __RadChart__ you had to manually set all three range properties - __MinValue__, __MaxValue__ and __Step__ of the axis whenever you needed to customize the automatically generated range. However, the __RadChartView__ implementation allows you to set only two of the above properties as it can calculate the last one internally based on the custom settings you applied.
										

* __Series__ - __RadChartView__ supports almost all __Series__ types known from __RadChart__ to help you create rich, visually-appealing presentations. However, there are several new features added:
								

* Financial Indicators - __RadChartView__ supports 20 of the most common financial indicators to complement the data visualization for all Cartesian Series types.
										

* [Polar]({%slug radchartview-series-polarseries%}) and [Radar]({%slug radchartview-series-radarseries%}) Series - a two-dimensional charts presented in radial plot area in polar coordinates.
										

* Combined Series - uniform __RadCartesianChart Series__ can be combined in either __Stacks__ or __Clusters__. Combinations are formed when multiple __DataPoints__ from different __Series__ fall within the same category. You can read more about this in the [Chart Series]({%slug radchartview-series-chartseries%}) topic.
										

* Series Orientation - both controls allow you to have horizontally or vertically oriented series. However, while in __RadChart__ you have to specify different series types - __BarSeriesDefinition__ vs. __HorizontalBarSeriesDefinition__, in __RadChartView__ this concept is changed to facilitate usage of horizontal and vertical series. For instance, in order to display __BarSeries__ vertically in a __RadChartView__, you only need to set the __CategoricalAxis__ as an __Y-axis__ without having to change the series definition.
										All supported __RadChartView Series__ types are presented in the [Series Overview]({%slug radchartview-series-chartseries%}) topic.
								

* __Chart Legend__ - __RadChartView__ does not ship with a built-in legend. However, you can easily integrate the __RadLegend__ control in it.[Read More]({%slug radchartview-features-radlegend-support%})

##### 3. __Behaviors__ - both __RadChartView__ and __RadChart__ support *Selection*, *Tooltip* and *Scroll and Zoom* behaviors. However, on top of that the __RadChartView__ exposes a __TrackBall__ behavior:
						

* [TrackBall Behavior]({%slug radchartview-features-trackball%}) (or also known as a current value indicator) is a behavior available only within the __RadChartView__. It displays a vertical line across the charting plot area that comes with visual indicators (circles by default) at the points where the trackball line crosses the visualization of a __Series__ objects.
								

* [Selection]({%slug radchartview-features-selection%}) - this behavior exposes a *SelectionChanged* event that you can use to easily determine the __DataPoint__ that is selected and the __Series__ it belongs to. The behavior is avilable in both __RadChart__ and __RadChartView__ controls.
								

* [Scroll and Zoom]({%slug radchartview-features-panzoom%}) - this behavior is available in both __RadChart__ and __RadChartView__ controls. It allows horizontal and vertical zooming and scrolling. However, the approach implemented in the __RadChartView ZoomScroll__ behavior is brand new and it allows users to simultaneously set the zoom factor for both the X and Y axes.
								

* [Tooltip]({%slug radchartview-features-tooltip%}) - Although both charting controls support tooltips, only the Tooltip behavior implemented within the __RadChartView__ component allows you to specify the placement and the offset of the tooltip thus further controlling where it should be visualized.
								

##### 4. __Sampling__When the chart is populated with thousands of business items, the visual representation might not be that clear. It is possible that there are two or more DataPoints shown with a very close Y and X values. This is when sampling comes in handy. The sampling engine visualizes a subset of the original data. By combining the items, so that the __DataPoints__ are limited to a certain number (200 by default). In a data-bound __RadChart__ sampling is turned on by default and is activated as soon as the __DataPoints__ number exceeds 200. However, in some cases you might have to implement a custom sampling function that determines how to combine the values of two __DataPoints__. __RadChartView__ takes that idea on another level. Instead of providing a sampling mechanism after plotting the data, the control allows you to use a [ChartDataSource]({%slug radchartview-populating-with-data-chartdatasource%}) component to sample the business data beforehand. The [ChartDataSource]({%slug radchartview-populating-with-data-chartdatasource%}) component supports both index-based and __DateTime__ sampling.
						

#### 5. __Appearance__. Unline RadChart, the __RadChartView__ control comes with a built-in set of palettes which you can use to easily customize the look and feel of your charting components. You can examine and try all available palettes in the {% if site.site_name == 'Silverlight' %}[Appearance example](http://demos.telerik.com/silverlight/#ChartView/Palettes){% endif %}{% if site.site_name == 'WPF' %}[Appearance example](http://demos.telerik.com/wpf/#ChartView/Palettes) after navigating to the __ChartView__ control, in the *Overview* section{% endif %}.
						



## Features with no equivalent in RadChartView

>The information is up-to-date as for Q2 2013. The list of features will change with our next releases.
					

1. Sorting/Filtering

1. Hierarchical Data Support*

1. ChartTitle

1. Bubble series type

1. All 3D series types

>Currently ChartView provides partial support for Hierarchical Data through the [SeriesProvider]({%slug radchartview-features-chartseriesprovider%}) feature.
					

# See Also

 * [Axis]({%slug radchartview-axes-axis%})

 * [Series Overview]({%slug radchartview-series-chartseries%})

 * [Create Data-Bound Chart]({%slug radchartview-series-databinding%})

 * [Scroll and Zoom Behavior]({%slug radchartview-features-panzoom%})

 * [Tooltip Behavior]({%slug radchartview-features-tooltip%})

 * [Trackball Behavior]({%slug radchartview-features-trackball%})

 * [Selection Behavior]({%slug radchartview-features-selection%})
