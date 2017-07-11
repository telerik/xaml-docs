---
title: DoughtnutSeries
page_title: DoughtnutSeries
description: DoughtnutSeries
slug: radchartview-series-doughnutseries
tags: doughtnutseries
published: True
position: 1
---

# DoughtnutSeries

This series is visualized on the screen as separate slices representing each of the __DataPoints__. The only difference from the PieSeries is that the separate slices of this series start with an offset of the center of the RadPieChart control.
      

## Declaratively defined series

You can use the following definition to display a simple DoughnutSeries

#### __XAML__
{{region radchartview-series-doughnutseries-0}}
	<telerik:RadPieChart Palette="Windows8">
		<telerik:RadPieChart.Series>
			<telerik:DoughnutSeries>
				<telerik:DoughnutSeries.DataPoints>
					<telerik:PieDataPoint Label="43.46%" Value="43.46"/>
					<telerik:PieDataPoint Label="27.53%" Value="27.53"/>
					<telerik:PieDataPoint Label="15.11%" Value="15.11"/>
					<telerik:PieDataPoint Label="10.35%" Value="10.35"/>
					<telerik:PieDataPoint Label="3.55%" Value="3.55"/>
				</telerik:DoughnutSeries.DataPoints>
			</telerik:DoughnutSeries>
		</telerik:RadPieChart.Series>
	</telerik:RadPieChart>
{{endregion}}

![radchartview-series-doughnutseries](images/radchartview-series-doughnutseries.png)

## See Also
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
