---
title: RangeBarSeries
page_title: RangeBarSeries
description: RangeBarSeries
slug: radchartview-series-rangebarseries
tags: rangebarseries
publish: True
position: 1
---

# RangeBarSeries



This series is visualized on the screen as separate rectangles representing each of the __DataPoints__. The main difference of the BarSeries is that you are allowed to define range with each data point.
      

## Declaratively defined series

You can use the following definition to display a simple RangeBarSeries

	
            <telerik:RadCartesianChart Palette="Windows8">
            <telerik:RadCartesianChart.HorizontalAxis>
                <telerik:CategoricalAxis/>
            </telerik:RadCartesianChart.HorizontalAxis>
            <telerik:RadCartesianChart.VerticalAxis>
                <telerik:LinearAxis />
            </telerik:RadCartesianChart.VerticalAxis>
            <telerik:RadCartesianChart.Series>
                <telerik:RangeBarSeries>
                    <telerik:RangeBarSeries.DataPoints>
                        <telerik:RangeDataPoint Category="January"  High="5" Low="0"/>
                        <telerik:RangeDataPoint Category="February" High="7" Low="2"/>
                        <telerik:RangeDataPoint Category="March" High="6" Low="4"/>
                        <telerik:RangeDataPoint Category="April" High="8" Low="5"/>
                        <telerik:RangeDataPoint Category="May" High="4" Low="3"/>
                        <telerik:RangeDataPoint Category="June" High="9" Low="7"/>
                        <telerik:RangeDataPoint Category="July" High="3" Low="1"/>
                    </telerik:RangeBarSeries.DataPoints>
                </telerik:RangeBarSeries>
            </telerik:RadCartesianChart.Series>
            </telerik:RadCartesianChart>

![radchartview-series-rangebarseries](images/radchartview-series-rangebarseries.png)

# See Also

 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
