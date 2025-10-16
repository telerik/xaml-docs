---
title: Bind Custom Task's Properties in Event Container
page_title: How Use the Properties of a Custom Task in the EventContainer
description: Binding a custom GanttTask's properties to those of the event container.
type: how-to
slug: kb-ganttview-bind-custom-task-properties
tags: bind, custom, gantttask, properties, event, container
ticketid: 1428878
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.2.510</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGanttView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to set the background color for each individual task by databinding a property on a custom GanttTask class.

## Solution

To achieve the desired result, you need to bind the Color property through the **OriginalEvent** property of the **EventProxy** class which is the **DataContext** of the **EventContainer**.


```XAML
	<telerik:ColorToBrushConverter x:Key="ColorToBrushConverter" />
	<Style TargetType="telerik:EventContainer">
		<Setter Property="Background" Value="{Binding OriginalEvent.Color, Converter={StaticResource ColorToBrushConverter}}" />
	</Style>
```
		
>If your **Color** property is not of the **Brush** type, you will also need to use an adequate converter.
