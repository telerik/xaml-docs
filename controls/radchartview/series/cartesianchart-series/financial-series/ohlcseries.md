---
title: OhlcSeries
page_title: OhlcSeries
description: OhlcSeries
slug: radchartview-series-ohlcseries
tags: ohlcseries
publish: True
position: 0
---

# OhlcSeries



This is a typical financial series that can be used to visualize the state of a market for a period of time. This kind of series require one CategoricalAxis and one LinearAxis.

## Declaratively defined series

You can use the following definition to display a simple OhlcSeries

	
            <telerik:RadCartesianChart Palette="Windows8">
            <telerik:RadCartesianChart.HorizontalAxis>
                <telerik:CategoricalAxis/>
            </telerik:RadCartesianChart.HorizontalAxis>
            <telerik:RadCartesianChart.VerticalAxis>
                <telerik:LinearAxis />
            </telerik:RadCartesianChart.VerticalAxis>
            <telerik:RadCartesianChart.Series>
                <telerik:OhlcSeries>
                    <telerik:OhlcSeries.DataPoints>
                        <telerik:OhlcDataPoint Category="Monday" Open="5" Close="4" Low="2" High="10" />
                        <telerik:OhlcDataPoint Category="Tuseday" Open="10" Close="8" Low="7" High="12"/>
                        <telerik:OhlcDataPoint Category="Wednesday" Open="6" Close="8" Low="5" High="9"/>
                        <telerik:OhlcDataPoint Category="Thursday" Open="3" Close="7" Low="3" High="8"/>
                        <telerik:OhlcDataPoint Category="Friday" Open="5" Close="6" Low="4" High="7"/>
                    </telerik:OhlcSeries.DataPoints>
                </telerik:OhlcSeries>
            </telerik:RadCartesianChart.Series>
            </telerik:RadCartesianChart>

![radchartview-series-ohlcseries](images/radchartview-series-ohlcseries.png)

# See Also

 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
