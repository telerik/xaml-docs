---
title: Propagate the TextAlignment of the GridViewColumn to the Merged Cells in RadGridView for WPF
description: This article explains how to set the TextAlignment property in the merged cells in Telerik DataGird for WPF.
type: how-to
page_title: Sync the TextAlignment Property of GridViewColumn With the Text in the GridView Merged Cells
slug: kb-gridview-textalignment-merged-cells
tags: radgridview, wpf, textalignment, merged cells
res_type: kb
---

## Environment

| Property | Value |
| --- | --- |
| Product | RadGridView for WPF |
| Version | 2023.1.117 |

## Description

How to sync the `TextAlignment` setting of the `GridViewColumn` with the text in the merged cells in `RadGridView`.

## Solution

To do that, use the `MergedCellsStyleSelector` property of `RadGridView`. This will allow you to define `Style`s that target the `GridViewMergedCell` element and set its `HorizontalContentAlignment` or `VerticalContentAlignment` property.

In the merged cell styles selector, you can get the `MergedCellInfo` object and use it to access the corresponding  column. Based on its alignment setting, you can select the proper `Style`.


```XAML
   	<Window.Resources>
		<Style x:Key="RightAlignedMergedCellStyle" TargetType="telerik:GridViewMergedCell" BasedOn="{StaticResource GridViewMergedCellStyle}">
			<Setter Property="HorizontalContentAlignment" Value="Right" />
		</Style>

		<Style x:Key="CenterAlignedMergedCellStyle" TargetType="telerik:GridViewMergedCell" BasedOn="{StaticResource GridViewMergedCellStyle}">            
			<Setter Property="HorizontalContentAlignment" Value="Center" />
		</Style>

		<local:VerticalMergedCellsStyleSelector x:Key="VerticalMergedCellsStyleSelector"
												RightAlignedCellStyle="{StaticResource RightAlignedMergedCellStyle}"
												CenterAlignedCellStyle="{StaticResource CenterAlignedMergedCellStyle}"/>
	</Window.Resources>
	<Grid>
		<telerik:RadGridView GroupRenderMode="Flat"
							 MergedCellsDirection="Vertical"
							 ItemsSource="{Binding MyItemsSource}"
							 AutoGenerateColumns="False"
							 MergedCellsStyleSelector="{StaticResource VerticalMergedCellsStyleSelector}">         
			<telerik:RadGridView.Columns>
				<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" Width="150" />
				<telerik:GridViewDataColumn DataMemberBinding="{Binding Value}" Width="150" TextAlignment="Right"/>
				<telerik:GridViewDataColumn DataMemberBinding="{Binding Value}" Width="150" TextAlignment="Center"/>
				<telerik:GridViewDataColumn DataMemberBinding="{Binding Value}" Width="150"/>
			</telerik:RadGridView.Columns>
		</telerik:RadGridView>
	</Grid>
```


```C#
	public class VerticalMergedCellsStyleSelector : StyleSelector
	{
		public Style RightAlignedCellStyle { get; set; }
		public Style CenterAlignedCellStyle { get; set; }

		public override Style SelectStyle(object item, DependencyObject container)
		{
			var cellVisual = (GridViewMergedCell)container;
			var cellInfo = (MergedCellInfo)item;
			var column = cellVisual.ParentDataControl.Columns
				.OfType<Telerik.Windows.Controls.GridViewColumn>()
				.First(x => cellInfo.HorizontalStart == x.DisplayIndex);

			if (column.TextAlignment == TextAlignment.Right)
			{
				return RightAlignedCellStyle;
			}
			else if (column.TextAlignment == TextAlignment.Center)
			{
				return CenterAlignedCellStyle;
			}
			return base.SelectStyle(item, container);
		}
	}
```
