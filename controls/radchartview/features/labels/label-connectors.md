---
title: Label Connectors
page_title: Label Connectors
description: Label Connectors
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

The following example demonstrates how to set the LabelConnectorsSettings propety:

#### __XAML__
{{region radchartview-features-labels-label-connectors_00}}
	<telerik:RadPieChart Palette="Windows8">
		<telerik:PieSeries ShowLabels="True" RadiusFactor="0.6">
			<telerik:PieSeries.DataPoints>
				<telerik:PieDataPoint Value="43.46" Label="France: 43.46%"/>
				<telerik:PieDataPoint Value="27.53" Label="Germany: 27.53%" />
				<telerik:PieDataPoint Value="15.11" Label="Belgium: 15.11%" />
				<telerik:PieDataPoint Value="10.35" Label="Holland: 10.35%" />
				<telerik:PieDataPoint Value="3.55" Label="Luxembourg: 3.55%" />
			</telerik:PieSeries.DataPoints>
			
			<telerik:PieSeries.LabelDefinitions>
				<telerik:ChartSeriesLabelDefinition Margin="-40,0,0,0" />
			</telerik:PieSeries.LabelDefinitions>
			
			<telerik:PieSeries.LabelConnectorsSettings>
				<telerik:ChartSeriesLabelConnectorsSettings />
			</telerik:PieSeries.LabelConnectorsSettings>
		</telerik:PieSeries>            
	</telerik:RadPieChart>
{{endregion}}

Here is the end result:
![](images/radchartview-features-smart-labels-labelconnectors_01.png.png)
	
## See Also
* [GettingStarted]({%slug radchartview-introduction%})
* [LineSeries]({%slug radchartview-series-lineseries%})
* [Smart Labels]({%slug radchartview-features-smart-labels%})
* [Label Definition]({%slug radchartview-features-label-definition%})

