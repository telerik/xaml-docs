---
title: SDK Examples
page_title: SDK Examples
description: SDK Examples
slug: radchartview-sdk-examples
tags: sdk,examples
published: True
position: 1
---

# SDK Examples



The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadChartView__.

## List of all RadChartView SDK examples:{% if site.site_name == 'WPF' %}

* __Animations__ - An example that uses a utilities class and demonstrates how you can use animations for the chart series.

* __Annotations adding__ - Every chart contains an Annotations collection which holds all the annotations plotted against the chart. The RadChartView will visualize the annotations only if it contains data. 

* __Annotation types__ - The ChartView provides the following types of annotations: Cartesian Grid Line, Cartesian Plot Band, Polar Axis Grid Line, Polar Axis Plot Band, Radial Axis Grid Line, Radial Axis Plot Band and custom Cartesian and Polar annotations. 

* __Area series__ - The area series can be SplineAreaSeries and normal AreaSeries which correspond to the SplineSeries and LineSeries respectively. The area series are behave just like the spline and line series but they also allow the area between the curve/lines and the corresponding axis to be colored in an arbitrary way.

* __Axis__ - RadChartView plots data points in a coordinate system defined by its two axes. There are a few different types of axes and they are: Linear, Logarithmic, DateTime and Categorical.

* __Bar series__ - RadChartView provides BarSeries out of the box. This series is used to visualize data points as bar blocks with the height of each bar denoting the magnitude of its value. The bars can be styled differently so that they can easily be differentiated from each other if necessary.

* __Binding the color of series items__ - This example will demonstrate how to create charts where each individual item has its color bound to a property of the underlying DataObject. The following chart series will be used for this example:   - Bar Series   - Scatter Point Series   - Pie Series

* __Binding to data table__ - In this example we will demonstrate how to bind a ChartView to a DataTable. 

* __Cartesian ChartGrid__ - In order to improve the readiness of the chart you may want to add a grid-like visuals which support horizontal and vertical lines, associated with axis ticks and horizontal and vertical stripes for better readability. RadCartesianChart offers the CartesianChartGrid.

* __Categorical axis__ - The categorical axis displays a range of categories and the values that determine each category do not define an order. If a category binding is not specified for the categorical axis, each data point will be in its own category with the category being determined by the position of the data point in the data source.

* __Chart DataSource__ - Aside from binding to a collection of business objects as shown in Create Data-Bound Chart topic RadChartView supports a more complex way of binding which allows you to combine the datapoints (known as sampling) before plotting them. This is done by using the ChartDataSource.

* __ChartView customization__ - The purpose of this example is to show different ways to customize the appearance of the chartview series. Some of them are easily customized via Fill, Stroke, Style exposed properties while others such as RadPieChart present you a more complex approach.

* __Create chart with static data__ - In this sample you are going to create and visualize your data using simple line chart. This line chart will be based on some predefined static data declared in XAML or code-behind.

* __Create data bound chart__ - RadChartView supports data binding and manual population with data out of the box. The data binding feature is exposed by the different series and can be utilized by assigning a value to the ItemsSource property of a series object.

* __Crosshair__ - This example demonstrates some of the options of the CrosshairBehavior.

* __Customizing scatter points__ - RadChart allows that you set custom shape for the Scatter points (items of the ScatterPoint series) via DataTemplate. However there are cases where we would like each point in our scatter series to have different shape or color. This is where you should use the PointTemplateSelector property. 

* __Date time axes__ - RadCartesianChart supports two types of DateTime axes: 	- The DateTime continuous axis is like a numerical axis but the axis value range consists of DateTime values which are always sorted chronologically. 	- The DateTime categorical axis is a categorical axis with Date-Time values which are sorted chronologically and is represented by the DateTimeCategoricalAxis class. It also allows definition of categories based on specific date time components. For example if such an axis displays a range of one year, the data points can be plotted in categories for each month. If the range is one month, the values may be categorized by day and so on.

* __Drag to select__ - The chart view currently does not support built-in drag-to-select feature. This example demonstrates one approach to  implement an application that mimics the drag-to-select functionality.

* __Drill down__ - The chart view currently does not support built-in drill-down feature. This example demonstrates one approach to  implement an application that mimics the drill-down functionality.

* __Individual axis zooming__ - The chart view currently does not support built-in zooming on individual axes. This example demonstrates one approach to  implement an application that mimics the zoom-per-axis functionality.

* __Introduction__ - In this example we are going to create a chart from scratch using the chart related classes in the RadChartView control suite.

* __Logarithmic axis__ - The logarithmic axis displays values of items using intervals corresponding to orders of magnitude, rather than a standard linear scale.

* __Multiple axes__ - Additional horizontal / vertical axes can be specified through the CartesianSeries.HorizontalAxis / VerticalAxis properties.

* __Pie series__ - The PieSeries are special series that are used to visualize data in the pie chart. Like all other series the pie series uniquely visualize its data point collection by representing different data points with pie slices. The sweep of a pie slices is directly proportional to the magnitude of the raw data point’s value.

* __Plot mode__ - RadChartView allows you to modify the layout of the Categorical and Date Time axes to improve the look and feel of the series presented. Depending on the selected plot mode, the axis's ticks and labels will be visualized differently. 

* __Polar axis__ - In order to create a valid RadPolarChart object users must set its PolarAxis and RadialAxis properties to PolarAxis and NumericRadialAxis objects respectively. The PolarAxis class contains three properties and these are MajorStep, Minimum and Maximum which define the tick step, the minimum value and the maximum value of the axis. NumericRadialAxis does not define any properties specific to it.

* __Polar ChartGrid__ - In order to improve the readiness of the chart you may want to add a grid-like visuals which support horizontal and vertical lines, associated with axis ticks and horizontal and vertical stripes for better readability. RadPolarChart offers the PolarChartGrid.

* __Polar series__ - The polar series consists of a group of classes that plot data in radial plot area in polar coordinates. The polar series are special because they are valid only in the context of the RadPolarChart control.

* __Radar series__ - The radar chart is a two-dimensional chart of three or more quantitative variables represented on axes starting from the same point. The radar series are special because they are valid only in the context of the RadPolarChart control.

* __Scatter series__ - RadChartView provides a group of scatter series that can be plotted on two linear axes unlike the other series which are always plotted on a categorical and a linear or another categorical axis.

* __Scroll and zoom__ - RadChartView provides zoom and scroll interactivity with the ChartPanAndZoomBehavior class. It is very simple to use and allows users to zoom in the chart plot area when there is a dense area of data points that can not be seen clearly at the normal chart scale.

* __Scroll and zoom synced charts__ - Demonstrates one possible way to achieve synchronized zooming between two or more charts. Another possible way is to bind the Zoom and PanOffset of the two charts to properties in the same view model.

* __Selection__ - This help example will demonstrate how you can make your charts more interactive by adding a selection behavior. Here are the main properties that ChartSelectionBehavior exposes:   - DataPointSelectionMode - to control single / multiple data point selection.   - HitTestMargin - to increase the hit-testable area around the data point (especially useful when visualizing small scatter points that can be selected).   - SelectionPoints - to detect the selection. You may also use the SelectionChanged event of the RadChartView for the same purpose.   - SelectionPalette - to control the selected element appearance. 

* __Series provider__ - This example demonstrates how to populate RadCartesianChart with dynamic number of series. The actual number of series created depends on the data chart is bound to. In this example the chart is bound to a collection of 3 SeriesProviderDataImte objects, hence 3 ChartSeries are created. Each of them contains 4 items, so each series ends up with 4 DataPoints.

* __Spline series__ - The spline series are similar to the line series but instead of straight line segments, the spline series connects its data points with a smooth curve which represents rough approximations of the missing data points.

* __Tooltip__ - RadChartView provides a tooltip behavior which can be used to visualize arbitrary information related to a data point. The tooltip is triggered by setting the ToolTipTemplate property of ChartToolTipBehavior to a valid DataTemplate object during design-time and positioning the mouse cursor down somewhere on the chart during run-time. If the user hovers directly over a data point, the tooltip will display information for this particular data point. 

* __Track ball__ - Along with tooltip and pan/zoom behaviors, RadChart provides a trackball behavior through the ChartTrackballBehavior class. This behavior can display a vertical line across the chart plot area and also to display little visual indicators (circles by default) at points where the trackball line crosses the visualization of a series object. For example when the trackball line crosses a line series line segment, a small circle is drawn highlighting the value of the series at this point.

* __Track ball like annotations__ - This sdk example demonstrates how to use annotations in order to achieve a TrackBall-Like effect. These annotaions can be synced between two or more charts and you can apply a custom behavior such as key navigation(left/right).{% endif %}{% if site.site_name == 'Silverlight' %}

* __Animations__ - An example that uses a utilities class and demonstrates how you can use animations for the chart series.

* __Annotations adding__ - Every chart contains an Annotations collection which holds all the annotations plotted against the chart. The RadChartView will visualize the annotations only if it contains data. 

* __Annotation types__ - The ChartView provides the following types of annotations: Cartesian Grid Line, Cartesian Plot Band, Polar Axis Grid Line, Polar Axis Plot Band, Radial Axis Grid Line, Radial Axis Plot Band and custom Cartesian and Polar annotations. 

* __Area series__ - The area series can be SplineAreaSeries and normal AreaSeries which correspond to the SplineSeries and LineSeries respectively. The area series are behave just like the spline and line series but they also allow the area between the curve/lines and the corresponding axis to be colored in an arbitrary way.

* __Axis__ - RadChartView plots data points in a coordinate system defined by its two axes. There are a few different types of axes and they are: Linear, Logarithmic, DateTime and Categorical.

* __Bar series__ - RadChartView provides BarSeries out of the box. This series is used to visualize data points as bar blocks with the height of each bar denoting the magnitude of its value. The bars can be styled differently so that they can easily be differentiated from each other if necessary.

* __Binding the color of series items__ - This example will demonstrate how to create charts where each individual item has its color bound to a property of the underlying DataObject. The following chart series will be used for this example:   - Bar Series   - Scatter Point Series   - Pie Series

* __Cartesian ChartGrid__ - In order to improve the readiness of the chart you may want to add a grid-like visuals which support horizontal and vertical lines, associated with axis ticks and horizontal and vertical stripes for better readability. RadCartesianChart offers the CartesianChartGrid.

* __Categorical axis__ - The categorical axis displays a range of categories and the values that determine each category do not define an order. If a category binding is not specified for the categorical axis, each data point will be in its own category with the category being determined by the position of the data point in the data source.

* __Chart DataSource__ - Aside from binding to a collection of business objects as shown in Create Data-Bound Chart topic RadChartView supports a more complex way of binding which allows you to combine the datapoints (known as sampling) before plotting them. This is done by using the ChartDataSource.

* __ChartView customization__ - The purpose of this example is to show different ways to customize the appearance of the chartview series. Some of them are easily customized via Fill, Stroke, Style exposed properties while others such as RadPieChart present you a more complex approach.

* __Create chart with static data__ - In this sample you are going to create and visualize your data using simple line chart. This line chart will be based on some predefined static data declared in XAML or code-behind.

* __Create data bound chart__ - RadChartView supports data binding and manual population with data out of the box. The data binding feature is exposed by the different series and can be utilized by assigning a value to the ItemsSource property of a series object.

* __Crosshair__ - This example demonstrates some of the options of the CrosshairBehavior.

* __Customizing scatter points__ - RadChart allows that you set custom shape for the Scatter points (items of the ScatterPoint series) via DataTemplate. However there are cases where we would like each point in our scatter series to have different shape or color. This is where you should use the PointTemplateSelector property. 

* __Date time axes__ - RadCartesianChart supports two types of DateTime axes: 	- The DateTime continuous axis is like a numerical axis but the axis value range consists of DateTime values which are always sorted chronologically. 	- The DateTime categorical axis is a categorical axis with Date-Time values which are sorted chronologically and is represented by the DateTimeCategoricalAxis class. It also allows definition of categories based on specific date time components. For example if such an axis displays a range of one year, the data points can be plotted in categories for each month. If the range is one month, the values may be categorized by day and so on.

* __Drag to select__ - The chart view currently does not support built-in drag-to-select feature. This example demonstrates one approach to  implement an application that mimics the drag-to-select functionality.

* __Drill down__ - The chart view currently does not support built-in drill-down feature. This example demonstrates one approach to  implement an application that mimics the drill-down functionality.

* __Individual axis zooming__ - The chart view currently does not support built-in zooming on individual axes. This example demonstrates one approach to  implement an application that mimics the zoom-per-axis functionality.

* __Introduction__ - In this example we are going to create a chart from scratch using the chart related classes in the RadChartView control suite.

* __Logarithmic axis__ - The logarithmic axis displays values of items using intervals corresponding to orders of magnitude, rather than a standard linear scale.

* __Multiple axes__ - Additional horizontal / vertical axes can be specified through the CartesianSeries.HorizontalAxis / VerticalAxis properties.

* __Pie series__ - The PieSeries are special series that are used to visualize data in the pie chart. Like all other series the pie series uniquely visualize its data point collection by representing different data points with pie slices. The sweep of a pie slices is directly proportional to the magnitude of the raw data point’s value.

* __Plot mode__ - RadChartView allows you to modify the layout of the Categorical and Date Time axes to improve the look and feel of the series presented. Depending on the selected plot mode, the axis's ticks and labels will be visualized differently. 

* __Polar axis__ - In order to create a valid RadPolarChart object users must set its PolarAxis and RadialAxis properties to PolarAxis and NumericRadialAxis objects respectively. The PolarAxis class contains three properties and these are MajorStep, Minimum and Maximum which define the tick step, the minimum value and the maximum value of the axis. NumericRadialAxis does not define any properties specific to it.

* __Polar ChartGrid__ - In order to improve the readiness of the chart you may want to add a grid-like visuals which support horizontal and vertical lines, associated with axis ticks and horizontal and vertical stripes for better readability. RadPolarChart offers the PolarChartGrid.

* __Polar series__ - The polar series consists of a group of classes that plot data in radial plot area in polar coordinates. The polar series are special because they are valid only in the context of the RadPolarChart control.

* __Radar series__ - The radar chart is a two-dimensional chart of three or more quantitative variables represented on axes starting from the same point. The radar series are special because they are valid only in the context of the RadPolarChart control.

* __Scatter series__ - RadChartView provides a group of scatter series that can be plotted on two linear axes unlike the other series which are always plotted on a categorical and a linear or another categorical axis.

* __Scroll and zoom__ - RadChartView provides zoom and scroll interactivity with the ChartPanAndZoomBehavior class. It is very simple to use and allows users to zoom in the chart plot area when there is a dense area of data points that can not be seen clearly at the normal chart scale.

* __Scroll and zoom synced charts__ - Demonstrates one possible way to achieve synchronized zooming between two or more charts. Another possible way is to bind the Zoom and PanOffset of the two charts to properties in the same view model.

* __Selection__ - This help example will demonstrate how you can make your charts more interactive by adding a selection behavior. Here are the main properties that ChartSelectionBehavior exposes:   - DataPointSelectionMode - to control single / multiple data point selection.   - HitTestMargin - to increase the hit-testable area around the data point (especially useful when visualizing small scatter points that can be selected).   - SelectionPoints - to detect the selection. You may also use the SelectionChanged event of the RadChartView for the same purpose.   - SelectionPalette - to control the selected element appearance. 

* __Series provider__ - This example demonstrates how to populate RadCartesianChart with dynamic number of series. The actual number of series created depends on the data chart is bound to. In this example the chart is bound to a collection of 3 SeriesProviderDataImte objects, hence 3 ChartSeries are created. Each of them contains 4 items, so each series ends up with 4 DataPoints.

* __Spline series__ - The spline series are similar to the line series but instead of straight line segments, the spline series connects its data points with a smooth curve which represents rough approximations of the missing data points.

* __Tooltip__ - RadChartView provides a tooltip behavior which can be used to visualize arbitrary information related to a data point. The tooltip is triggered by setting the ToolTipTemplate property of ChartToolTipBehavior to a valid DataTemplate object during design-time and positioning the mouse cursor down somewhere on the chart during run-time. If the user hovers directly over a data point, the tooltip will display information for this particular data point. 

* __Track ball__ - Along with tooltip and pan/zoom behaviors, RadChart provides a trackball behavior through the ChartTrackballBehavior class. This behavior can display a vertical line across the chart plot area and also to display little visual indicators (circles by default) at points where the trackball line crosses the visualization of a series object. For example when the trackball line crosses a line series line segment, a small circle is drawn highlighting the value of the series at this point.

* __Track ball like annotations__ - This sdk example demonstrates how to use annotations in order to achieve a TrackBall-Like effect. These annotaions can be synced between two or more charts and you can apply a custom behavior such as key navigation(left/right).{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).
