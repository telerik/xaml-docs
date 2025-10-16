---
title: Selection Color is not Respected when CellStyle or CellStyleSelector is Applied
description: The selection color of the row is not shown when using a CellStyle or CellStyleSelector.
type: troubleshooting
page_title: When Using a CellStyle or CellStyleSelector the Selection Color of the Row is not Shown
slug: kb-gridview-selection-color-is-not-shown-with-cellstyleselector
position: 0
tags: gridview, row, selection, color, not, shown, applied, cellstyleselector
ticketid: 1151336
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2020.2.617</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGridView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

The selection background is not shown when a custom **CellStyle** or **CellStyleSelector** is applied.

## Solution

When a CellStyle or CellStyleSelector is applied, the background of the cells set through the CellStyle property overrides the selection background color of the **GridViewRow**.

To display the selection color instead of the custom background set for the cells, you can define a **DataTrigger** bound to the **IsSelected** property of the parent row.


```XAML
    <Style x:Key="CellStyle" TargetType="telerik:GridViewCell" BasedOn="{StaticResource GridViewCellStyle}">
        <Setter Property="Background" Value="Red" />
        <Style.Triggers>
            <DataTrigger Binding="{Binding IsSelected, RelativeSource={RelativeSource Mode=FindAncestor, AncestorType=telerik:GridViewRow}}" Value="True">
                <Setter Property="Background" Value="{Binding Background}" />
            </DataTrigger>
        </Style.Triggers>
    </Style>
```

## See Also
* [Styling Cells]({%slug gridview-styling-cell%})
