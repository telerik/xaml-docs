---
title: Changing Validation Color in Telerik UI for WPF Controls
description: Learn how to change the validation color of Telerik controls for the Telerik theme (like Windows8) using Xaml or NoXaml assemblies.
type: how-to
page_title: Modifying Validation Color for Telerik TextBox Elements
meta_title: Modifying Validation Color for Telerik Input Control
slug: kb-palette-change-validation-color
tags: ui-for-wpf, windows8-theme, validation-color, implicit-styles, noxaml, palette, windows8palette
res_type: kb
---

## Environment

<table>
<tbody>
<tr>
<td>Product</td>
<td>UI for WPF</td>
</tr>
<tr>
<td>Version</td>
<td>Current</td>
</tr>
</tbody>
</table>

## Description

How to change the validation color used in text input controls (like RadWatermarkTextBox, etc.) from the default red to another color.

## Solution

To do this, set the `ValidationColor` property of the corresponding [palette]({%slug styling-apperance-theme-palettes%}). 

This can be done in C#:

```C#
Windows8Palette.Palette.ValidationColor = Colors.Yellow;
```

Or alternatively, in XAML:

```XAML
<Application.Resources>
    <SolidColorBrush x:Key="{x:Static telerik:Windows8ResourceKey.ValidationBrush}" Color="Purple" />
</Application.Resources>
```

This approach is applicable in newer [themes]({%slug common-styling-appearance-available-themes%}), starting from Windows8.
