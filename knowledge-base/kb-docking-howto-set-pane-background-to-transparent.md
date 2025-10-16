---
title: How to Set the Background of RadDocking's Pane to Transparent
description: How to remove the background of a RadPane including the corresponding RadPaneGroup and AutoHideArea.
type: how-to
page_title: Remove the Background of RadDocking's Pane
slug: kb-docking-howto-set-pane-background-to-transparent
position: 0
tags: pane, transparent, background, docking
ticketid: 1426047
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.2.618</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadDocking for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to set the background of a RadDocking's pane to transparent (including RadPaneGroup and AutoHideArea elements)?

## Solution

To remove the backround of a RadPane, add the following Styles:


```XAML
	<Application.Resources>
  		<!-- If you are using the StyleManager theming mechanism with the XAML binaries, remove the BasedOn attributes -->
		<Style TargetType="telerik:RadPane" BasedOn="{StaticResource RadPaneStyle}">
			<Setter Property="mat:MaterialAssist.IsShadowDisabled" Value="True"/>
			<Setter Property="Background" Value="Transparent"/>
		</Style>
		<Style TargetType="telerik:RadPaneGroup" BasedOn="{StaticResource RadPaneGroupStyle}">
			<Setter Property="mat:MaterialAssist.IsShadowDisabled" Value="True"/>
			<Setter Property="Background" Value="Transparent"/>
		</Style>
		<Style TargetType="telerik:AutoHideArea" BasedOn="{StaticResource AutoHideAreaStyle}">
			<Setter Property="mat:MaterialAssist.IsShadowDisabled" Value="True"/>
			<Setter Property="Background" Value="Transparent"/>
		</Style>
	</Application.Resources>
```

> The setters for the **mat:MaterialAssist.IsShadowDisabled** properties are only needed for the **Crystal**, **Fluent** and **Material** themes.
