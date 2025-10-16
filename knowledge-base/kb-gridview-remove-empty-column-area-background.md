---
title: Remove the Empty Column Space Background Color After the Last RadGridView column
description: How to change the background color of the empty space to the right of the last column in a RadGridView for WPF.
type: how-to
page_title: How to Set the Fill of the Empty Cells Shown After Last Column in RadGridView
slug: kb-gridview-remove-empty-column-area-background
tags: radgridview, wpf, background color, empty space, row style, cell style
res_type: kb
---

## Environment

| Product | Version |
|---------|---------|
| RadGridView for WPF | 2022.2.621 |

## Description

 How to remove the background color of the empty space to the right of the last column in a RadGridView.

## Solution

This empty area is part of the `GridViewRow` visual. To hide it, you can set the row's `Background` property to `Transparent`. To customize the cells in actual columns, you can use an implicit Style targeting the `GridViewCell` visual (or use the `CellStyle` property of the columns).


```XAML
	<Window.Resources>
	 <Style TargetType="telerik:GridViewCell">
		 <Setter Property="Background" Value="#29293E" />
	 </Style>        
	</Window.Resources>
	<Grid>
		 <telerik:RadGridView AutoGenerateColumns="False"
							  GroupRenderMode="Flat"
							  ItemsSource="{Binding}" 
							  Background="#76716A"
							  UseLayoutRounding="True">            
			 <telerik:RadGridView.RowStyle>
				 <Style TargetType="telerik:GridViewRow">
					 <Setter Property="Background" Value="Transparent" />
				 </Style>
			 </telerik:RadGridView.RowStyle>
			 <telerik:RadGridView.Columns>
				 <telerik:GridViewDataColumn DataMemberBinding="{Binding Id}" Width="150"/>
				 <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" Width="150"/>
			 </telerik:RadGridView.Columns>
		 </telerik:RadGridView>
	</Grid>
```

