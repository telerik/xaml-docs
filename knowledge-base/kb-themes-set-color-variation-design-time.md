---
title: How to Set Theme's Color Variation in Design Time
description: This article explains how to set he color variation of a given theme so that it is visible in the Visual Studio designer.
type: how-to
page_title: View Theme Variation in the Visual Studio Designer
slug: kb-themes-set-color-variation-design-time
position: 0
tags: themes, set, color, variation, design, time
ticketid: 1076498
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2016.2 613</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>Telerik UI for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to set a theme's color variation in Visual Studio's designer.

## Solution

Visual Studio will run code for designer use if you have enabled the **Project Code** setting in the designer and have set the theme variant:
* Before the **InitializeComponent()** invocation - for a **UserControl**
* In the **static constructor** - for a **custom control**

#### __[C#]__

{{region cs-kb-themes-set-color-variation-design-time_1}}
    static MainWindow()
    {
        FluentPalette.LoadPreset(FluentPalette.ColorVariation.Dark);
    }
{{endregion}}

#### __[VB.NET]__

{{region vb-kb-themes-set-color-variation-design-time_1}}
    Shared Sub New()
        FluentPalette.LoadPreset(FluentPalette.ColorVariation.Dark)
    End Sub
{{endregion}}

Please make sure to clean, rebuild and run the project before reloading the designer for the changes to take effect.

## See Also
* [Available Themes]({%slug common-styling-appearance-available-themes%})
