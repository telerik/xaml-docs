---
title: How to Remove Empty Space in PropertyGrid
description: Remove the white space and gray area showed on the bottom of RadPropertyGrid.
type: how-to
page_title: Clear Empty Area on the Bottom of the Control
slug: kb-propertygrid-remove-empty-space-on-bottom
position: 
tags: descriptionpanelvisibility,verticalalignment
ticketid: 1403141
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
		<td>RadPropertyGrid for WPF</td>
	</tr>
</table>

## Description

How to remove the white space when there is more space than displayed properties.

How to remove the gray area at the bottom of the control.

## Solution

To remove the white space, set the __VerticalAlignment__ of RadPropertyGrid to __Top__.

To remove the gray space, set the __DescriptionPanelVisibility__ property to __Collapsed__.


```XAML
	<telerik:RadPropertyGrid DescriptionPanelVisibility="Collapsed"  VerticalAlignment="Top" />
```

![{{ site.framework_name }} RadPropertyGrid Remove Empty Space](images/kb-propertygrid-remove-empty-space-on-bottom-0.png)