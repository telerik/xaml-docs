---
title: PolarLineSeries
page_title: PolarLineSeries
description: Check our &quot;PolarLineSeries&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-series-polarlineseries
tags: polarlineseries
published: True
position: 0
---

# PolarLineSeries

This series is visualized on the screen as a straight line connecting each of the __DataPoints__.   

## Declaratively defined series

You can use the following definition to display a simple PolarLineSeries


```XAML
	<telerik:RadPolarChart Palette="Windows8">
		<telerik:RadPolarChart.PolarAxis>
			<telerik:PolarAxis />
		</telerik:RadPolarChart.PolarAxis>
		<telerik:RadPolarChart.RadialAxis>
			<telerik:NumericRadialAxis />
		</telerik:RadPolarChart.RadialAxis>
		<telerik:RadPolarChart.Series>
		   <telerik:PolarLineSeries>
				<telerik:PolarLineSeries.DataPoints>
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
				</telerik:PolarLineSeries.DataPoints>
			</telerik:PolarLineSeries>
		</telerik:RadPolarChart.Series>
	</telerik:RadPolarChart>
```

![radchartview-series-polarlineseries](images/radchartview-series-polarlineseries.png)

## See Also
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
