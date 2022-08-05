---
title: StyleManager.ApplicationTheme is Null
description: The ApplicationTheme property of the StyleManager is not set
type: troubleshooting
page_title: Application Theme Cannot Be Set by StyleManager
slug: kb-stylemanager-applicationtheme-is-null
position: 0
tags: stylemanager, applicationtheme, null, not, set
ticketid: 1452402
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2020.2.617</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>UI for WPF</td>
	</tr>
</table>

## Description

The **StyleManager.ApplicationTheme** property is always **null**, even if it was explicitly set beforehand.

## Solution

This happens if you're using the [NoXaml]({%slug xaml-vs-noxaml%}) assemblies. To resolve this, reference the Xaml version of the Telerik UI for WPF binaries instead.

## See Also
* [Xaml vs NoXaml]({%slug xaml-vs-noxaml%})
* [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%})
* [Available Themes]({%slug common-styling-appearance-available-themes%})
