---
title: Set the FluentPalette ScrollBarsMode on a Single Control
description: Replace the ThemeHelper.ScrollBarsMode attached property for a specific ScrollViewer control.
page_title: Change ScrollBarsMode per Control in the Fluent Theme
slug: kb-common-change-fluentpalette-scrollbarsmode-per-control
position: 0
tags: change,scrollbarsmode,themehelper
ticketid: 1472946
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>UI for WPF</td>
	</tr>
</table>

## Description

How to change the __ThemeHelper.ScrollBarsMode__ attached property for a specific ScrollViewer control, this customizing the scrollbars in the Fluent theme.

## Solution

To do this, you can add an implicit style in the Resources of the corresponding ScrollViewer control. The Style can have a single Setter changing the ThemeHelper.ScrollBarsMode attached property.


```XAML
	 <ScrollViewer MaxHeight="150" Grid.Row="1">
		<ScrollViewer.Resources>
			<Style TargetType="ScrollBar" BasedOn="{StaticResource ScrollBarStyle}">
				<Setter Property="helpers:ThemeHelper.ScrollBarsMode" Value="Compact"/>
			</Style>
		</ScrollViewer.Resources>
		<!-- other XAML here -->
	</ScrollViewer>
```