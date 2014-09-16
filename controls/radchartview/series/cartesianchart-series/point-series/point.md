---
title: PointSeries
page_title: PointSeries
description: PointSeries
slug: radchartview-series-point
tags: pointseries
publish: True
position: 0
---

# PointSeries



This series is visualized on the screen as separate points representing each of the __DataPoints__.
      

## Declaratively defined series

You can use the following definition to display a simple PointSeries

	
            <telerik:RadCartesianChart Palette="Windows8">
            <telerik:RadCartesianChart.HorizontalAxis>
                <telerik:CategoricalAxis/>
            </telerik:RadCartesianChart.HorizontalAxis>
            <telerik:RadCartesianChart.VerticalAxis>
                <telerik:LinearAxis />
            </telerik:RadCartesianChart.VerticalAxis>
            <telerik:RadCartesianChart.Series>
                <telerik:PointSeries>
                    <telerik:PointSeries.DataPoints>
                        <telerik:ScatterDataPoint XValue="0" YValue="2" />
                        <telerik:ScatterDataPoint XValue="1" YValue="5" />
                        <telerik:ScatterDataPoint XValue="2" YValue="3" />
                        <telerik:ScatterDataPoint XValue="3" YValue="10" />
                        <telerik:ScatterDataPoint XValue="4" YValue="9" />
                        <telerik:ScatterDataPoint XValue="5" YValue="7" />
                        <telerik:ScatterDataPoint XValue="6" YValue="1" />
                    </telerik:PointSeries.DataPoints>
                </telerik:PointSeries>
            </telerik:RadCartesianChart.Series>
            </telerik:RadCartesianChart>

![radchartview-series-pointseries](images/radchartview-series-pointseries.png)

# See Also

 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
