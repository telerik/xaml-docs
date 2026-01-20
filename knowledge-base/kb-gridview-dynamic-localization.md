---
title: Refresh GridView After Language Change
page_title: Update RadGridView UI When Localization Culture is Changed
description: Update the UI of RadGridView when the current culture is changed bringing dynamic localization in versions prior 2025.4.1320.
type: how-to
slug: kb-gridview-dynamic-localization
position: 0
tags: update,refresh,ui,localization,culture,language,dynamic,runtime
ticketid: 1582097
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2022.2.621</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGridView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to refresh the UI of RadGridView when the current culture is changed, thus changing the language.

## Solution

> Since version 2025.4.1320 of Telerik UI for WPF, RadGridView supports [dynamic localization]({%slug common-localization%}#dynamic-localization) out of the box. Use the approach below only for older versions.

RadGridView doesn't support dynamic localization in versions prior 2025.4.1320. To get the desired effect, the GridView's ControlTemplate should be reset after the current culture changed.


```C#
	LocalizationManager.Manager.Culture = newCulture;
	var template = this.gridView.Template;
	this.gridView.Template = null;
	this.gridView.Template = template;
```
