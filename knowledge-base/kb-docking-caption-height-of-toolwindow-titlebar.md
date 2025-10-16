---
title: How to Set the Caption Height of the ToolWindow's Titlebar of the RadDocking Control
page_title: Change the Caption Height of the Titlebar of ToolWindow
description: This article shows how to change the caption height of the toolWindow's titlebar.
type: how-to
slug: kb-docking-caption-height-of-toolwindow-titlebar
tags: docking, toolwindow, captionheight, drag, threshold
position: 0
ticketid: 1584109
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2022.3.912</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadDocking for WPF</td>
		</tr>
	</tbody>
</table>

## Description

The `Title` and `TitleTemplate` properties of the RadPane element allow you to introduce a title that is bigger height than the default one. This will not automatically update the title area that allows you to drag the generated ToolWindow element.

## Solution

To change this behavior, you can manually increase the drag threshold by setting the `CaptionHeight` property of the `ToolWindow` element.

__Changing the CaptionHeight property__
```XAML
	<!-- If you use NoXaml dlls set the BasedOn property of the Style: BasedOn="{StaticResource ToolWindowStyle}" --> 
	<Style TargetType="telerik:ToolWindow">
	    <Setter Property="CaptionHeight" Value="60"/>
	</Style>
```
