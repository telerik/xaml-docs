---
title: StepLineSeries
page_title: StepLineSeries
description: StepLineSeries
slug: radchartview-series-steplineseries
tags: steplineseries
publish: True
position: 2
---

# StepLineSeries



This series is visualized on the screen as a line connecting all __DataPoints__. This series changes its value with a step.
      

## Declaratively defined series

You can use the following definition to display a simple StepLineSeries

	
            <telerik:RadCartesianChart Palette="Windows8">
            <telerik:RadCartesianChart.HorizontalAxis>
                <telerik:CategoricalAxis/>
            </telerik:RadCartesianChart.HorizontalAxis>
            <telerik:RadCartesianChart.VerticalAxis>
                <telerik:LinearAxis />
            </telerik:RadCartesianChart.VerticalAxis>
            <telerik:RadCartesianChart.Series>
                <telerik:StepLineSeries>
                    <telerik:StepLineSeries.DataPoints>
                        <telerik:CategoricalDataPoint Category="January" Value="2" />
                        <telerik:CategoricalDataPoint Category="February" Value="5" />
                        <telerik:CategoricalDataPoint Category="March" Value="3" />
                        <telerik:CategoricalDataPoint Category="April" Value="10" />
                        <telerik:CategoricalDataPoint Category="May" Value="9" />
                        <telerik:CategoricalDataPoint Category="June" Value="7" />
                        <telerik:CategoricalDataPoint Category="July" Value="1" />
                    </telerik:StepLineSeries.DataPoints>
                </telerik:StepLineSeries>
            </telerik:RadCartesianChart.Series>
            </telerik:RadCartesianChart>

![radchartview-series-steplineseries](images/radchartview-series-steplineseries.png)

# See Also

 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
