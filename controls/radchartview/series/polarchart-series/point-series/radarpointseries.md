---
title: RadarPointSeries
page_title: RadarPointSeries
description: RadarPointSeries
slug: radchartview-series-radarpointseries
tags: radarpointseries
publish: True
position: 1
---

# RadarPointSeries



This series is visualized on the screen as separate points representing each of the __DataPoints__.
      

## Declaratively defined series

You can use the following definition to display a simple RadarPointSeries

	
            <telerik:RadPolarChart Palette="Windows8">
                <telerik:RadPolarChart.PolarAxis>
                    <telerik:PolarAxis />
                </telerik:RadPolarChart.PolarAxis>
                <telerik:RadPolarChart.RadialAxis>
                    <telerik:CategoricalRadialAxis />
                </telerik:RadPolarChart.RadialAxis>
                <telerik:RadPolarChart.Series>
                    <telerik:RadarPointSeries>
                        <telerik:RadarPointSeries.DataPoints>
                            <telerik:CategoricalDataPoint Category="A" Value="4" />
                            <telerik:CategoricalDataPoint Category="B" Value="4" />
                            <telerik:CategoricalDataPoint Category="C" Value="4" />
                            <telerik:CategoricalDataPoint Category="D" Value="4" />
                            <telerik:CategoricalDataPoint Category="E" Value="4" />
                            <telerik:CategoricalDataPoint Category="F" Value="4" />
                            <telerik:CategoricalDataPoint Category="G" Value="4" />
                            <telerik:CategoricalDataPoint Category="H" Value="4" />
                            <telerik:CategoricalDataPoint Category="J" Value="4" />
                            <telerik:CategoricalDataPoint Category="K" Value="4" />
                            <telerik:CategoricalDataPoint Category="L" Value="4" />
                            <telerik:CategoricalDataPoint Category="M" Value="4" />
                        </telerik:RadarPointSeries.DataPoints>
                    </telerik:RadarPointSeries>
                </telerik:RadPolarChart.Series>
            </telerik:RadPolarChart>

![radchartview-series-radarpointseries](images/radchartview-series-radarpointseries.png)

# See Also

 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
