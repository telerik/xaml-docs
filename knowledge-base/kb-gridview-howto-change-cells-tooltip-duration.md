---
title: How to set the cell's tooltip duration 
description: Control the duration of a cell's tooltip.
type: howto
page_title: Change the timespan that a cell's tooltip is shown 
slug: kb-gridview-howto-change-cells-tooltip-duration
position: 0
tags: cell, tooltip, duration, timespan
ticketid: 1448661
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadGridView for WPF</td>
	</tr>
</table>

## Description

How to increase/decrease the period that a tooltip for a GridViewCell is visible.

## Solution

You can change the tooltip duration by setting the __ToolTipService.ShowDuration__ attached property of the cells via a style.

__Example 1: Setting ToolTipService.ShowDuration__
```XAML
    
    <Window.Resources>
	<!-- If you're using the NoXaml binaries, you need to add the BasedOn="{StaticResource GridViewCellStyle}" attribute -->
        <Style TargetType="telerik:GridViewCell">
	    <Setter Property="ToolTipService.ShowDuration" Value="1000" />
	</Style>
    </Window.Resources>
```

> If you do not want to apply this style to all GridViewCells in your application, you can use the [CellStyle]({%slug gridview-styling-cell%}) property of the columns to apply it only to a specific column.

## See Also

* [Add ToolTip for columns and headers]({%slug gridview-how-to-create-tooltip%})
