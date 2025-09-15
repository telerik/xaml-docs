---
title: Remove Cell Background Highlighting When Searching as you Type
description: Remove the color of cell found when searching as you type.
type: how-to
page_title: Change Background Color of Found GridViewCell When Search as you Type
slug: kb-gridview-remove-search-cell-background
position: 0
tags: showsearchpanel,controltemplate,extract
ticketid: 1404829
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
		<td>RadGridView for WPF</td>
	</tr>
</table>

## Description

How to remove or change the background of a matching cell when you search as you type.

## Solution

1. [Extract the ControlTemplate]({%slug styling-apperance-editing-control-templates%}) of the GridViewCell element.
2. In the ControlTemplate, find the VisualState with x:Name set to "Highlighted".
	
	
	```XAML
		<VisualState x:Name="Highlighted">
			<Storyboard>
				<ObjectAnimationUsingKeyFrames Duration="0" Storyboard.TargetName="PART_CellBorder" Storyboard.TargetProperty="Background">
					<DiscreteObjectKeyFrame KeyTime="0">
						<DiscreteObjectKeyFrame.Value>
							<SolidColorBrush Color="#2B00BFE8"/>
						</DiscreteObjectKeyFrame.Value>
					</DiscreteObjectKeyFrame>
				</ObjectAnimationUsingKeyFrames>
			</Storyboard>
		</VisualState>
	```
	
3. Remove the Storyboard that targets the "PART_CellBorder" from the VisualState. If you want only to change the color instead of removing it, change the Color property of the SolidColorBrush element.

> This example is based on the [Fluent theme]({%slug common-styling-appearance-fluent-theme%}). The ControlTemplate content could vary accross the different themes.

## See Also  
* [Editing Control Templates]({%slug styling-apperance-editing-control-templates%})
* [Search as you Type]({%slug radgridview-search-as-you-type%})
