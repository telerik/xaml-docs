---
title: PolarPointSeries
page_title: PolarPointSeries
description: PolarPointSeries
slug: radchartview-series-polarpointseries
tags: polarpointseries
publish: True
position: 0
---

# PolarPointSeries



This series is visualized on the screen as separate points representing each of the __DataPoints__.
      

## Declaratively defined series

You can use the following definition to display a simple PolarPointSeries

	
            <telerik:RadPolarChart Palette="Windows8">
                <telerik:RadPolarChart.PolarAxis>
                    <telerik:PolarAxis />
                </telerik:RadPolarChart.PolarAxis>
                <telerik:RadPolarChart.RadialAxis>
                    <telerik:NumericRadialAxis />
                </telerik:RadPolarChart.RadialAxis>
                <telerik:RadPolarChart.Series>
                    <telerik:PolarPointSeries>
                        <telerik:PolarPointSeries.DataPoints>
                            <telerik:PolarDataPoint Angle="30" Value="4"/>
                            <telerik:PolarDataPoint Angle="60" Value="4"/>
                            <telerik:PolarDataPoint Angle="90" Value="4"/>
                            <telerik:PolarDataPoint Angle="120" Value="4"/>
                            <telerik:PolarDataPoint Angle="150" Value="4"/>
                            <telerik:PolarDataPoint Angle="180" Value="4"/>
                            <telerik:PolarDataPoint Angle="210" Value="4"/>
                            <telerik:PolarDataPoint Angle="240" Value="4"/>
                            <telerik:PolarDataPoint Angle="270" Value="4"/>
                            <telerik:PolarDataPoint Angle="300" Value="4"/>
                            <telerik:PolarDataPoint Angle="330" Value="4"/>
                            <telerik:PolarDataPoint Angle="360" Value="4"/>
                        </telerik:PolarPointSeries.DataPoints>
                    </telerik:PolarPointSeries>
                </telerik:RadPolarChart.Series>
            </telerik:RadPolarChart>

![radchartview-series-polarpointseries](images/radchartview-series-polarpointseries.png)

# See Also

 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
