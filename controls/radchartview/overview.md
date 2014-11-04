---
title: Overview
page_title: Overview
description: Overview
slug: radchartview-overview
tags: overview
published: True
position: 0
---

# Overview



## {% if site.site_name == 'Silverlight' %}

![radchartview sl](images/radchartview_sl.png){% endif %}{% if site.site_name == 'WPF' %}

![radchartview wpf](images/radchartview_wpf.png){% endif %}

1. Overview
RadChartView is a versatile charting component that offers unmatched performance regarding loading time, drawing capabilities and real-time updates. Its intuitive object model and public API allow complex charts to be easily setup either in XAML or through code. The control is completely data aware and may work in bound or unbound mode, depending on the requirements. Chart types (or series) are organized in hierarchies, depending on the coordinate system, used to plot data points – for example we have RadCartesianChart (using Cartesian coordinate system) and RadPieChart (using radial coordinate system).


>The following references are required in order to use RadChartView:<br/>* __Telerik.Windows.Data.dll__<br/>* __Telerik.Windows.Controls.dll__<br/>* __Telerik.Windows.Controls.Chart.dll__<br/>

##### 2. Architecture
A charting component in general is used to visualize (or plot) some data in a human-readable way through different representations like lines, areas, bars pies, etc. Each series has a collection of data points – the data equivalent of a 2D point – and knows how to visualize them. Different series types may process certain types of data points – for example categorical series may contain categorical data points. Data points may be added directly to series or a data binding mechanism may be used to create the appropriate data points from the raw data.

##### 2.1. RadCartesianChart
As the name hints, this concrete chart control uses the Cartesian coordinate system to plot the data points in its chart series. The X and Y axes define how each point’s coordinates in the plot area are calculated.

##### 2.1.1.  Axes
Available are the following axes:

##### 2.1.1.1. Categorical
Arranges the plotted data points in categories where the key of each category is the point’s value (if available) for that axis or its index within the points collection. The point’s coordinate, specified by this axis is discrete and is calculated depending on the size of the category slot where the point resides.

##### 2.1.1.2. Date-time Categorical
Special categorical axis that expects each data point to provide a System.DateTime structure as its value for this axis. The points are grouped by a user-defined date-time component (Year, Month, Day, etc.) and then the groups are sorted chronologically.

##### 2.1.1.3. Linear
Calculates the coordinate of each data point, depending on the actual numerical value this point provides for the axis. Exposes Minimum and Maximum properties to allow for explicit definition of the range of values visible on this axis. If these properties are not specified, the axis will automatically calculate the range, depending on the minimum and maximum data point values.

##### 2.1.1.4. Logarithmic
Special linear axis that will transform each data point value using the logarithm function. Allows numerical data with huge delta between the minimum and the maximum to be visualized in a readable way.

##### 2.1.1.5. Date-time Continuous
Special axis that expects each data point to provide a System.DateTime structure as its value for this axis. May be thought of as a timeline where the coordinate of each data point is calculated depending on the position of its associated DateTime on the timeline. The base unit (or the timeline step) of the axis is calculated depending on the smallest difference between any two dates.

##### 2.1.1.6. Polar Axis
Special axis which is a fixed line in a system of polar coordinates from which the polar angle, θ, is measured anticlockwise. You may read more about it in [Polar Axis]({%slug radchartview-axes-polaraxis%}) topic.

##### 2.1.1.7. Radial Axis
Special axis used by RadPolarChart with [Radar Series]({%slug radchartview-series-radarseries%}).

* __Categorical__ - positions catgories/labels around the circumference of the circle.

##### 2.1.2.  Series
The currently implemented chart series are categorical – they accept Categorical data points and expect a categorical axis to be specified in order to be properly visualized. Following is a list with all the available series:    

##### 2.1.2.1. Area
Data points and the corresponding coordinate axis enclose an area that may be optionally stroked and/or filled.

##### 2.1.2.2. SplineArea
An area, which points are connected with smooth rather than straight segments.

##### 2.1.2.3. Bar
Data points are represented by a box where the height (width) of the box is the distance between the point’s numerical value and the categorical axis that plots the point. Bars may be either “horizontal” or “vertical” depending on whether the categorical axis is specified as an “X-axis” or as a “Y-axis”.

##### 2.1.2.4. Line
Data points are connected with straight line segments.    

##### 2.1.2.5. Spline
Data points are connected with smooth rather than straight line segments.

##### 2.1.2.6. Scatter Point
Data points are simply plotted in the chart plot area with nothing connecting them. Each scatter data point has X and Y values which make the position of the data point in the data source and its location on the plot area unrelated. For example the third data point in the data source may appear before the firstdata point when plotted. There are also scatter line and scatter area series which behave in the exact same way with the only (visual)difference that the points define a line and area respectively.

##### 2.1.2.7. Combined series
Each of the above series of same type may be combined in either stacks or clusters. Combinations are formed when more than one data point from different series falls within a same category. The “Cluster” combine mode will position such points next to each other while the “Stack” one will arrange such points in a stack-like structure. When stacks are formed, the numerical axis (if present) will consider each stack as a single entity and its sum will be the actual value used rather than each point’s one.For more information - refer to [Chart Series]({%slug radchartview-series-chartseries%}).

* __Stack100__ - Supported with Bar Series only. It shows the combined contribution of values as percentages where the combined total for each category is 100 percent. It's good to use it when the relationship between values in a category is more significant than the amounts.

##### 2.1.3. Chart Grid
The chart may be optionally decorated with grid-like visuals which support horizontal and vertical lines, associated with axis ticks and horizontal and vertical stripes – the area between two adjacent ticks. Such visuals are available for both Cartesian and Polar coordinates via Cartesian Grid and Polar Grid respectively.

##### 2.1.3.1  Cartesian Grid
You may refer to [Create Chart With Static Data]({%slug radchartview-populating-with-data-static-data%}) for more information on how to toggle GridLines and Stripes inside Cartesian Grid.

##### 2.1.3.2  Polar Grid
You may refer to [Radar Series]({%slug radchartview-series-radarseries%}) for more information on how to toggle GridLines and Stripes inside Polar Grid.

##### 2.2. RadPieChart
This concrete chart control visualizes its data points using radial coordinate system. Each point is represented as an arc segment where the arc’s length is actually the percentage this point’s value is from the total sum.

##### 2.3. RadPolarChartRadPolarChart inherits from RadChart and has a PolarAxis and a RadialAxis. It accepts only PolarSeries objects and plots data points in the polar coordinate system.

##### 2.4. Behaviors
Both chart types (pie and cartesian) have a behaviors collection that accepts ChartBehavior objects. Each object represents a special interaction behavior such as [Scroll and Zoom]({%slug radchartview-features-panzoom%}) or [TrackBall]({%slug radchartview-features-trackball%}).