---
title: RadarAreaSeries
page_title: RadarAreaSeries
description: Check our &quot;RadarAreaSeries&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-series-radarareaseries
tags: radarareaseries
published: True
position: 1
---

# RadarAreaSeries

This series is visualized on the screen as a straight line connecting each of the __DataPoints__. As an addition this series also allows the area surrounded by the line to be colored in an arbitrary way      

## Declaratively defined series

You can use the following definition to display a simple RadarAreaSeries


```XAML
	<telerik:RadPolarChart Palette="Windows8">
		<telerik:RadPolarChart.PolarAxis>
			<telerik:PolarAxis />
		</telerik:RadPolarChart.PolarAxis>
		<telerik:RadPolarChart.RadialAxis>
			<telerik:CategoricalRadialAxis />
		</telerik:RadPolarChart.RadialAxis>
		<telerik:RadPolarChart.Series>
			<telerik:RadarAreaSeries>
				<telerik:RadarAreaSeries.DataPoints>
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
				</telerik:RadarAreaSeries.DataPoints>
			</telerik:RadarAreaSeries>
		</telerik:RadPolarChart.Series>
	</telerik:RadPolarChart>
```

![radchartview-series-radarareaseries](images/radchartview-series-radarareaseries.png)

## See Also
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})