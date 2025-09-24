---
title: The Specified Value Cannot be Assigned to the Collection. The Following Type was Expected CartesianSeries
description: Compile time error XLS0503 Value of type LineSeries cannot be added to collection of type PresenterCollection when adding chart series in XAML.
type: troubleshooting
page_title: A Value of Type LineSeries Cannot be Added to Collection or Dictionary of Type PresenterCollection Error in RadChartView
slug: kb-chartview-namespace-error
position: 0
tags: charting, old, dll
ticketid: 1495519
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2020.3.1020</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadChartView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

An error with code XLS0503 and message "A Value of Type LineSeries Cannot be Added to Collection or Dictionary of Type PresenterCollection" shown during the build of a project where a chart series is defined in XAML. 

![{{ site.framework_name }} RadChartView Compile Time Error XLS0503 Value of type LineSeries Cannot be Added](images/kb-chartview-namespace-error-0.png)

## Solution

This error appears when referencing both the *Telerik.Windows.Controls.Chart* and *Telerik.Windows.Controls.Charting* assemblies in the same project. The Chart assembly contains the newer RadChartView component. The Charting dll contains the old RadChart which is not recommended. Use RadChartView instead. There are few classes with the same names that are defined in both the Chart and Charting assemblies and are mapped to the "telerik" XAML schema. When you try to use "telerik" to access one of those classes (like LineSeries for example) and error appears.

This issue can be observed also if you reference the Telerik UI for WPF nuget package wich contains all Telerik WPF dlls.

To resolve this remove the *Telerik.Windows.Controls.Charting* assembly from the project references. Or use a XAML namespace that points to the Telerik.Windows.Controls.ChartView namespace.


```XAML  
	<Window xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
		xmlns:chartView="clr-namespace:Telerik.Windows.Controls.ChartView;assembly=Telerik.Windows.Controls.Chart">
```


```XAML
<!-- chartView points to xmlns:chartView="clr-namespace:Telerik.Windows.Controls.ChartView;assembly=Telerik.Windows.Controls.Chart" -->
	<telerik:RadCartesianChart.Series>
		<chartView:LineSeries Stroke="Orange" StrokeThickness="2">
			<chartView:LineSeries.DataPoints>
				<telerik:CategoricalDataPoint Value="20"/>
				<telerik:CategoricalDataPoint Value="40"/>
				<telerik:CategoricalDataPoint Value="35"/>
				<telerik:CategoricalDataPoint Value="40"/>
				<telerik:CategoricalDataPoint Value="30"/>
				<telerik:CategoricalDataPoint Value="50"/>
			</chartView:LineSeries.DataPoints>
		</chartView:LineSeries>
	</telerik:RadCartesianChart.Series>
```
