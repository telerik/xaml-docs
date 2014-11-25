---
title: PieSeries
page_title: PieSeries
description: PieSeries
slug: radchartview-series-pieseries
tags: pieseries
published: True
position: 0
---

# PieSeries

This series is visualized on the screen as separate pie slices representing each of the __DataPoints__.

## Declaratively defined series

You can use the following definition to display a simple PieSeries	
	<telerik:RadPieChart Palette="Windows8">
		<telerik:RadPieChart.Series>
			<telerik:PieSeries>
				<telerik:PieSeries.DataPoints>
					<telerik:PieDataPoint Label="43.46%" Value="43.46"/>
					<telerik:PieDataPoint Label="27.53%" Value="27.53"/>
					<telerik:PieDataPoint Label="15.11%" Value="15.11"/>
					<telerik:PieDataPoint Label="10.35%" Value="10.35"/>
					<telerik:PieDataPoint Label="3.55%" Value="3.55"/>
				</telerik:PieSeries.DataPoints>
			</telerik:PieSeries>
		</telerik:RadPieChart.Series>
	</telerik:RadPieChart>

![radchartview-series-pieseries](images/radchartview-series-pieseries.png)

# See Also
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})