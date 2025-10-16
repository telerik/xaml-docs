---
title: Display CheckBox in Merged Cell for Column Bound to Boolean Property
description: How to Have Merged Cells in CheckBox Column.
type: how-to
page_title: Show CheckBox in Merged Cells
slug: kb-gridview-merged-cells-in-checkbox-column
position: 0
tags: merged, cells, checkbox, column
ticketid: 1416894
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product</td>
			<td>RadGridView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to show a CheckBox in merged cells inside a column bound to a boolean property (By default, True/False is shown).

## Solution

Create a [MergedCellsStyleSelector]({%slug gridview-merged-cells-style-selector%}) and return a custom style targeting __GridViewMergedCell__ with its ContentTemplate containing a CheckBox. You can return this style only when the __Value__ of the __MergedCellInfo__ is of type bool.


```XAML
	<Grid>
        <Grid.Resources>
            <DataTemplate x:Key="CheckBoxContentTemplate">
                <CheckBox IsChecked="{Binding .}" IsHitTestVisible="False"/>
            </DataTemplate>
            
            <Style x:Key="CheckBoxMergedCellStyle" TargetType="telerik:GridViewMergedCell" BasedOn="{StaticResource GridViewMergedCellStyle}">
                <Setter Property="ContentTemplate" Value="{StaticResource CheckBoxContentTemplate}" />
            </Style>
            
            <local:MergedCellsStyleSelector x:Key="MergedCellStyleSelector" CheckBoxStyle="{StaticResource CheckBoxMergedCellStyle}"/>
        </Grid.Resources>
        <telerik:RadGridView x:Name="radGridView"
							 MergedCellsDirection="Vertical"  
							 GroupRenderMode="Flat"
                             EditTriggers="CellClick"
                             MergedCellsStyleSelector="{StaticResource MergedCellStyleSelector}">
        </telerik:RadGridView>
    </Grid>
```



```C#
	public class MergedCellsStyleSelector : StyleSelector
    {
        public Style CheckBoxStyle { get; set; }

        public override Style SelectStyle(object item, DependencyObject container)
        {
            var cellInfo = item as MergedCellInfo;

            if(cellInfo.Value.GetType() == typeof(bool))
            {
                return CheckBoxStyle;
            }

            return base.SelectStyle(item, container);
        }
    }
```
