---
title: Label Connectors
page_title: Label Connectors
description: Check our &quot;Label Connectors&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-features-label-connectors
tags: label,connectors,settings
published: True
position: 2
---

# Label Connectors

RadChartView supports drawing of connector lines between the series' data points and their labels. In order to enable this feature you can set the chart series' __LabelConnectorsSettings__ property. The property accepts an object of type __ChartSeriesLabelConnectorsSettings__ which exposes the following properties:
* __FadeOpacity__: Gets or sets the opacity that is applied to the label connectors when the series is faded by the chart's hover interactivity.
* __MinLengthThreshold__: Gets or sets the min length threshold. If a label connector is shorter than this threshold, the label connector is not drawn.
* __Style__: Gets or sets the connectors' style. The property accepts a Style targeting a Path element.

__Example 1: Setting LabelConnectorsSettings in XAML__
<snippet id='radchartview-features-labels-label-connectors-example_1_setting_labelconnectorssettings_in_xaml-xaml' />


#### __Figure 1: Label connectors visual appearance__
![{{ site.framework_name }} RadChartView Label connectors visual appearance](images/radchartview-features-smart-labels-labelconnectors_01.png.png)

## Customizing labels connectors points

With the __R3 2017__ release of UI for WPF controls you can customize the labels connectors position. This can be achieve by overriding the __GetLabelConnector()__ method of the series. This method accepts an object of type __ChartSeriesLabelPositionInfo__ which contains information about the label. 

* __DataPoint__: Gets the DataPoint associated with the label.
* __DefaultLayoutSlot__: Gets the initially calculated layout slot for the label.
* __FinalLayoutSlot__: Gets or sets the final layout in which the label will be arranged.

In the following example we will demonstrate how to customize the connectors appearance by adding additional points. First we will create custom class which derives from __FunnelSeries__ and override the __GetLabelConnector()__ method. In this method we will create new points which the framework will used to draw the connector across them.

__Example 2: Overriding GetLabelConnector() method__
<snippet id='radchartview-features-labels-label-connectors-example_2_overriding_getlabelconnector_method-cs' />


Next we will create custom __IValueConverter__ class to change the __Stroke__ of every connector.

__Example 3: Specifying CustomFunnelSeries in XAML__
<snippet id='radchartview-features-labels-label-connectors-example_3_specifying_customfunnelseries_in_xaml-cs' />


Now we can add the custom funnel series into the view.

__Example 4: Specifying CustomFunnelSeries in XAML__
<snippet id='radchartview-features-labels-label-connectors-example_4_specifying_customfunnelseries_in_xaml-cs' />


#### __Figure 2: Customized connectors visual appereance__
![{{ site.framework_name }} RadChartView Customized connectors visual appereance](images/radchartview-features-customized-labelconnectors_02.png)

## See Also
* [GettingStarted]({%slug radchartview-introduction%})
* [LineSeries]({%slug radchartview-series-lineseries%})
* [Smart Labels]({%slug radchartview-features-smart-labels%})
* [Label Definition]({%slug radchartview-features-label-definition%})
