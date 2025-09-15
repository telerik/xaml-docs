---
title: How to Display DataTable DataRow Information in TrackBallInfoTemplate
page_title: Displaying DataTable DataRow Data in Series's TrackBallInfoTemplate
description: This article explains how to bind DataRow information in TrackBallInfoTemplate.
type: how-to
slug: kb-chartview-datarow-info-in-trackballinfotemplate
position: 0
tags: chartview, trackballinfotemplate, datarow
ticketid: 1588674
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2022.3.1109</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadChartView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to display `DataTable` `DataRow` information in the `TrackBallInfoTemplate` properties of the [chart view series]({%slug radchartview-series-chartseries%}).

## Solution

To display the values of the DataRow, you can use the `DataItem` property of the `DataPoint` instance. The DataPoint comes from the `DataPointInfo` object that is generated for each series entry. The DataItem will be of type DataRow and you can use the square brackets syntax to choose which values are going to be displayed.

__Displaying DataTable DataRow information in TrackBallInfoTemplate__
```XAML
    <telerik:PointSeries ItemsSource="{Binding DataTable.DefaultView}">
        <telerik:PointSeries.TrackBallInfoTemplate>
            <DataTemplate>
                <StackPanel Orientation="Horizontal">
                    <TextBlock Text="Value is: "/>
                    <TextBlock Text="{Binding DataPoint.DataItem[MyDataRowValue]}" Foreground="red"/>
                </StackPanel>
            </DataTemplate>
        </telerik:PointSeries.TrackBallInfoTemplate>
    </telerik:PointSeries>
```