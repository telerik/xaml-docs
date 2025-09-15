---
title: Minimize and Minus Glyphs are Stretched When Shown in RadPathButton
page_title: Minimize and Minus Glyph Icons not Displayed Properly in RadPathButton
description: The Minimize and Minus font glyphs are stretched when hosted in PathButton.
type: troubleshooting
slug: kb-buttons-minimize-minus-glyphs-stretched-in-pathbutton
position: 0
tags: glyph,icon,stretched
ticketid: 1459222
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
	    	<td>RadButton for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

The Minimize and Minus font glyphs are stretched when hosted in RadPathButton.

## Solution

This happens because RadPathButton stretches its Path element by default. To change this behavior, you can set the Stretch property of the Path to None via the __PathStyle__ property of RadPathButton.


```XAML
	<telerik:RadPathButton.PathStyle>
		<Style TargetType="{x:Type Path}">
			<Setter Property="Fill" Value="Black"/>
			<Setter Property="Stretch" Value="None"/>
			<Setter Property="VerticalAlignment" Value="Center"/>
			<Setter Property="HorizontalAlignment" Value="Center"/>
			<Setter Property="SnapsToDevicePixels" Value="True"/>
		</Style>
	</telerik:RadPathButton.PathStyle>
```