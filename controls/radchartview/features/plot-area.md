---
title: Plot Area
page_title: Plot Area
description: Plot Area
slug: radchartview-features-plot-area
tags: plotarea, plotareaclip, plotareastyle
published: True
position: 5
---

# Plot Area

The chart's plot area is the zone where all data points are drawn (see Figure 1). The API of the chart allows you to get information about the area or apply custom style for the visual element that represents it.

#### __Figure 1: Chart's plot area__
![](images/radchartview-features-plot-area-0.png)

The chart's axes are not included in the plot area.

## Get Plot Area Boundaries

You can get information about the plot area's boundaries via the __PlotAreaClip__ property of the chart. The property is of type __RadRect__ which contains the position and size of the plot area. The chart fires the [PlotAreaClipChanged]({%slug radchartview-events%}#chart-controls-events) event when the boundaries change.

> The provided information doesn't include the currently applied zoom factor.

## Clip to Plot Area

By default the elements presented by the chart (series and annotations) are clipped into the plot area. Anything that leaves the boundaries won't be rendered. To alter this you can use the __ClipToPlotArea__ property that is exposed by the elements. Its __default value__ is __True__.

#### __[XAML] Example 1: Setting ClipToPlotArea of a chart series__
{{region radchartview-features-plot-area-0}}
	 <telerik:PointSeries ClipToPlotArea="False" />
{{endregion}}

#### __Figure 2: ClipToPlotArea example__
![](images/radchartview-features-plot-area-1.png)

## Customize the plot area visual

You can customize the plot area visual via the __PlotAreaStyle__ property of the chart. It is a type of __Style__ and the expected TargetType is __Border__ - the area's visual element.

#### __[XAML] Example 2: Setting PlotAreaStyle__
{{region radchartview-features-plot-area-1}}
	<telerik:RadCartesianChart.PlotAreaStyle>
		<Style TargetType="Border">
			<Setter Property="Background" Value="#FFFDB3" />
		</Style>
	</telerik:RadCartesianChart.PlotAreaStyle>
{{endregion}}

#### __Figure 3: PlotAreaStyle example__
![](images/radchartview-features-plot-area-2.png)

## See Also  
* [Getting Started]({%slug radchartview-introduction%})
* [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
* [Events]({%slug radchartview-events%})
