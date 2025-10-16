---
title: How to Highlight Header Cell when the Column is Filtered
description: This article demonstrates how to apply styling to the header cells of a column which is filtered.
type: how-to
page_title: Style the Header Cells of a Column with an Applied Filter
slug: kb-gridview-style-filtered-column-header-cell
position: 0
tags: gridview, style, highlight, header, cell, filtered, column
ticketid: 1480644
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.3.917</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGridView for WPF</td>
		</tr>
	</tbody>
</table>


## Description

How to style the header cells when their parent column is filtered.

## Solution

To apply conditional styling of the header cells only when their parent column has a filter applied to it, you can create a style for the **GridViewHeaderCell** element with a **DataTrigger** pointing to the **IsActive** property of the respective column's **ColumnFilterDescriptor**.


```XAML
    <Style TargetType="telerik:GridViewHeaderCell">
        <Style.Triggers>
            <DataTrigger Binding="{Binding Path=Column.ColumnFilterDescriptor.(telerik:IColumnFilterDescriptor.IsActive), RelativeSource={RelativeSource Self}}" Value="True">
                <Setter Property="Background" Value="Red" />
            </DataTrigger>
        </Style.Triggers>
    </Style>
```

## See Also
* [Styling Column Headers]({%slug gridview-styling-column-headers%})