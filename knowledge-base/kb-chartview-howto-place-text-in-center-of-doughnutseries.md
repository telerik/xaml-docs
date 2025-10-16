---
title: How to place text in doughnut series center
description: Add a label in the center of a DoughnutSeries.
page_title: Include text in the middle of the doughnut inside a doughnut series
type: how-to
slug: kb-chartview-howto-place-text-in-center-of-doughnutseries
position: 0
tags: label, doughnut, series, center, text, pie, chart
ticketid: 1449533
res_type: kb
---

## Environment
<table>
    <tr>
        <td>Product</td>
        <td>RadChartView for WPF</td>
    </tr>
</table>

## Description

How to add text in the center of a doughnut series. 

## Solution

You can define the chart and position a TextBlock with the corresponding label on top of it as shown in __Example 1__.

__Example 1: Adding a TextBlock label__
```XAML
	
    <Grid>
        <telerik:RadPieChart>
            <!-- some settings here -->
        </telerik:RadPieChart>
        <TextBlock Text="Label Text" VerticalAlignment="Center" HorizontalAlignment="Center" />
    </Grid>
```

## See Also

* [DoughnutSeries]({%slug radchartview-series-doughnutseries%})
