---
title: Remove MouseOver and Selected Overlay on Child Item
description: Avoid mouse enter and selection backgrounds for child RadPanelBarItem when selected or hovered.
type: how-to
page_title: Clear MouseOver and Selected Backgrounds from Child Item
slug: kb-panelbar-remove-mouseover-and-selected-overlay-child-item
position: 0
tags: hover,selection,overlay,background
ticketid: 1401889
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2019.1.220</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadPanelBar for WPF</td>
	</tr>
</table>

## Description

How to remove mouse over and selected background colors of a child RadPanelBarItem when it is hovered or selected.

## Solution

Extract and modify the content of the RadPanelBarItem Template property.

__To remove the mouse over overlay:__

1. Extract the Style of the RadPanelBarItem. 
2. Find the Setter that sets the Template property and go to the ControlTemplate in the setter.
3. Find the VisualState with x:Name="MouseOver" in the template and remove it.
4. Find the Border element with x:Name="MouseOverVisual" and remove it as well.

The following elements are the ones that should be removed from the template:


```XAML
	<VisualState x:Name="MouseOver">
		<Storyboard>
			<DoubleAnimation Duration="0:0:0.2" To="1" Storyboard.TargetProperty="Opacity" Storyboard.TargetName="MouseOverVisual"/>
		</Storyboard>
	</VisualState>
	<!---------------------------->
	<Border x:Name="MouseOverVisual" BorderBrush="#FFFFC92B" BorderThickness="1" CornerRadius="1" Opacity="0">
		<Border.Background>
			<LinearGradientBrush EndPoint="0.5,1" StartPoint="0.5,0">
				<GradientStop Color="#FFFFFBA3" Offset="1"/>
				<GradientStop Color="#FFFFFBDA" Offset="0"/>
			</LinearGradientBrush>
		</Border.Background>
		<Border BorderBrush="White" BorderThickness="1" Background="{x:Null}" CornerRadius="0"/>
	</Border>
```

__To remove the selected overlay:__

1. Extract the Style of the RadPanelBarItem. 
2. Find the Setter that sets the Template property and go to the ControlTemplate in the setter.
3. Find the VisualState with x:Name="Selected" in the ControlTemplate and remove it.
4. Find the Border element with x:Name="SelectedVisual" and remove it as well.

The following elements are the ones that should be removed from the template:


```XAML
	<VisualState x:Name="Selected">
		<Storyboard>
			<DoubleAnimation Duration="0" To="1" Storyboard.TargetProperty="Opacity" Storyboard.TargetName="SelectedVisual"/>
		</Storyboard>
	</VisualState>
	<!---------------------------->
	<Border x:Name="SelectedVisual" BorderBrush="#FFFFC92B" BorderThickness="1" CornerRadius="1" Opacity="0">
		<Border.Background>
			<LinearGradientBrush EndPoint="0.5,1" StartPoint="0.5,0">
				<GradientStop Color="#FFFCE79F" Offset="1"/>
				<GradientStop Color="#FFFDD3A8"/>
			</LinearGradientBrush>
		</Border.Background>
		<Border BorderBrush="White" BorderThickness="1" Background="{x:Null}" CornerRadius="0"/>
	</Border>
```

You can apply the custom style using an implicit style. This is a Style without its x:Key set.


```XAML
	<Style TargetType="telerik:RadPanelBarItem">
		<!-- Some setters here -->
	</Style>
```

Or you can apply the style via the __ItemContainerStyle__ property of the RadPanelBar control.

> The ControlTemplate extracts shown in the code snippets of this topic were extracted from the Office_Black [theme]({%slug common-styling-appearance-available-themes%}). 

## See Also

* [Editing Control Templates]({%slug styling-apperance-editing-control-templates%})
