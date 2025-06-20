---
title: Sync Custom GridViewCell Background with the GridViewRow Hover and Selection Background
description: How to fix the background of GridViewCell to match the selection and hover states of the parent GridViewRow
type: how-to
page_title: Match a Custom Set GridViewCell Background with the Mouse Over and Selection Brushes of the Parent Row
meta_title: Match a Custom Set GridViewCell Background with the Mouse Over and Selection Brushes of the Parent Row
slug: kb-gridview-sync-cell-background-with-row-selection-brush
tags: radgridview, wpf, autogeneratingcolumn, styling, gridviewcell, alignment, hover-effects
res_type: kb
ticketid: 1631425
---

## Environment
<table>
<tbody>
<tr>
<td>Product</td>
<td>RadGridView for WPF</td>
</tr>
<tr>
<td>Version</td>
<td>Current</td>
</tr>
</tbody>
</table>

## Description

RadGridView allows you to change the background brush of the cells by setting the `Background` of `GridViewCell` using the `CellStyle` property of the column. However, because the GridViewCell is drawn over the row visual, the background and mouse over states of the row are rendered behind the cell. In other words, they are not visible because the custom set background of the cell overlaps the underlying visual.

## Solution

To resolve this, you can use a `DataTrigger` to conditionally data bind the `Background` of `GridViewCell` to the [MouseOverBackground and SelectedBackground]({%slug radgridview-rows-selected-background%}) properties of the parent `GridViewRow`.

```csharp
	<telerik:GridViewDataColumn.CellStyle>
		<Style TargetType="telerik:GridViewCell">
			<Setter Property="Background" Value="Green" />
			<Style.Triggers>
				<DataTrigger Binding="{Binding RelativeSource={RelativeSource AncestorType=telerik:GridViewRow}, Path=IsMouseOver}" Value="True">
					<Setter Property="Background" Value="{Binding RelativeSource={RelativeSource AncestorType=telerik:GridViewRow}, Path=MouseOverBackground}" />
				</DataTrigger>
				<DataTrigger Binding="{Binding RelativeSource={RelativeSource AncestorType=telerik:GridViewRow}, Path=IsSelected}" Value="True">
					<Setter Property="Background" Value="{Binding RelativeSource={RelativeSource AncestorType=telerik:GridViewRow}, Path=SelectedBackground}" />
				</DataTrigger>
			</Style.Triggers>
		</Style>
	</telerik:GridViewDataColumn.CellStyle>
```


