---
title: Exception Thrown Attempting to Set StrokeDashArray on CartesianChartGrid
description: Specified value of type System.Windows.Media.DoubleCollection must have IsFrozen set to false to modify - occurs if you set StrokeDashArray property in MajorXLineStyle or MajorYLineStyle.
type: troubleshooting
page_title: InvalidOperationException Thrown When Setting CartesianChartGrid Line StrokeDashArray Property
slug: kb-chartview-invalid-operation-exception-strokedasharray
position: 0
tags: strokedasharray,majorlinestyle,chartview
ticketid: 1429449
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.2 902</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadChartView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

InvalidOperationException is thrown when setting the StrokeDashArray property of the CartesianChartGrid lines through the MajorXLineStyle or MajorYLineStyle properties. 

The error message is: "Specified value of type 'System.Windows.Media.DoubleCollection' must have IsFrozen set to false to modify."

## Solution

Instead of the StrokeDashArray property of the Line element, set the __MajorXLineDashArray__ and __MajorYLineDashArray__ properties of the CartesianChartGrid element.


```XAML
	<telerik:RadCartesianChart.Grid>
		<telerik:CartesianChartGrid MajorXLineDashArray="4,2" MajorYLineDashArray="4,2" >
	</telerik:RadCartesianChart.Grid>
```
