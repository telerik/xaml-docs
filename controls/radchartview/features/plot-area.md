---
title: Plot Area
page_title: Plot Area
description: Check our &quot;Plot Area&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-features-plot-area
tags: plotarea, plotareaclip, plotareastyle
published: True
position: 5
---

# Plot Area

The chart's plot area is the zone where all data points are drawn (see Figure 1). The API of the chart allows you to get information about the area or apply a custom style for the visual element that represents it.

#### __Figure 1: Chart's plot area__
![Chart's plot area](images/radchartview-features-plot-area-0.png)

The chart's axes are not included in the plot area.

## Get Plot Area Boundaries

You can get information about the plot area's boundaries via the __PlotAreaClip__ property of the chart. The property is of type __RadRect__ which contains the position and size of the plot area. The chart fires the [PlotAreaClipChanged]({%slug radchartview-events%}#chart-controls-events) event when the boundaries change.

> The provided information doesn't include the currently applied zoom factor.

## Clip to Plot Area

By default the elements presented by the chart (series and annotations) are clipped into the plot area. Anything that leaves the boundaries won't be rendered. To alter this you can use the __ClipToPlotArea__ property that is exposed by the elements. Its __default value__ is __True__.

__Example 1: Setting ClipToPlotArea of a chart series__
```XAML
	 <telerik:PointSeries ClipToPlotArea="False" />
```

#### __Figure 2: ClipToPlotArea example__
![ClipToPlotArea example](images/radchartview-features-plot-area-1.png)

## Customize the plot area visual

You can customize the plot area visual via the __PlotAreaStyle__ property of the chart. It is of type __Style__ and the expected __TargetType__ is __Border__ - the area's visual element.

__Example 2: Setting PlotAreaStyle__
```XAML
	<telerik:RadCartesianChart.PlotAreaStyle>
		<Style TargetType="Border">
			<Setter Property="Background" Value="#FFFDB3" />
		</Style>
	</telerik:RadCartesianChart.PlotAreaStyle>
```

#### __Figure 3: PlotAreaStyle example__
![PlotAreaStyle example](images/radchartview-features-plot-area-2.png)

## Controlling the stack order of the elements

The stack order of the elements in the chart is determined by their positions in the items collection that holds them. You can additionally control which element is displayed on top by setting the elements' **ZIndex** property. RadChartView elements which have this property are [Series]({%slug radchartview-series-chartseries%}), [Annotations]({%slug radchartview-annotations-overview%}) and [Axes]({%slug radchartview-axes-axis%}).

__Example 3: Setting the ZIndex property__
```XAML
	<telerik:RadCartesianChart x:Name="chart" Palette="Windows8">
            <telerik:RadCartesianChart.HorizontalAxis>
                <telerik:CategoricalAxis/>
            </telerik:RadCartesianChart.HorizontalAxis>

            <telerik:RadCartesianChart.VerticalAxis >
                <telerik:LinearAxis />
            </telerik:RadCartesianChart.VerticalAxis>

            <telerik:RadCartesianChart.Series>
                <telerik:LineSeries ZIndex="100">
                    <telerik:LineSeries.DataPoints >
                        <telerik:CategoricalDataPoint Category="January" Value="1" />
                        <telerik:CategoricalDataPoint Category="February" Value="5" />
                    </telerik:LineSeries.DataPoints>
                </telerik:LineSeries>

                <telerik:BarSeries>
                    <telerik:BarSeries.DataPoints>
                        <telerik:CategoricalDataPoint Category="January" Value="3" />
                        <telerik:CategoricalDataPoint Category="February" Value="5" />
                    </telerik:BarSeries.DataPoints>
                </telerik:BarSeries>
            </telerik:RadCartesianChart.Series>
        </telerik:RadCartesianChart>
```

#### __Figure 4: ZIndex example__
![ZIndex example](images/radchartview-ZIndex.png)
 
## See Also  
* [Getting Started]({%slug radchartview-introduction%})
* [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
* [Events]({%slug radchartview-events%})
