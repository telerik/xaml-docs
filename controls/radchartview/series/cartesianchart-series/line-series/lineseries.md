---
title: LineSeries
page_title: LineSeries
description: LineSeries
slug: radchartview-series-lineseries
tags: lineseries
published: True
position: 0
---

# LineSeries



This series is visualized on the screen as a straight line connecting all __DataPoints__.

## Declaratively defined series

You can use the following definition to display a simple LineSeries

#### XAML
{{region radchartview-lineseries}}
            <telerik:RadCartesianChart Palette="Windows8">
            <telerik:RadCartesianChart.HorizontalAxis>
                <telerik:CategoricalAxis/>
            </telerik:RadCartesianChart.HorizontalAxis>
            <telerik:RadCartesianChart.VerticalAxis>
                <telerik:LinearAxis />
            </telerik:RadCartesianChart.VerticalAxis>
            <telerik:RadCartesianChart.Series>
                <telerik:LineSeries>
                    <telerik:LineSeries.DataPoints>
                        <telerik:CategoricalDataPoint Category="January" Value="2" />
                        <telerik:CategoricalDataPoint Category="February" Value="5" />
                        <telerik:CategoricalDataPoint Category="March" Value="3" />
                        <telerik:CategoricalDataPoint Category="April" Value="10" />
                        <telerik:CategoricalDataPoint Category="May" Value="9" />
                        <telerik:CategoricalDataPoint Category="June" Value="7" />
                        <telerik:CategoricalDataPoint Category="July" Value="1" />
                    </telerik:LineSeries.DataPoints>
                </telerik:LineSeries>
            </telerik:RadCartesianChart.Series>
            </telerik:RadCartesianChart>
{{endregion}}
![radchartview-series-lineseries](images/radchartview-series-lineseries.png)

# See Also

 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
