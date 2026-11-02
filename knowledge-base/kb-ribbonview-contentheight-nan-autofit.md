---
title: Adjust ribbon view's height to its content
description: Autofit RadRibbonView content height to the selected item content.
components: ["ribbonview"]
type: how-to
page_title: Autosize RadRibbonView height to selected tab elements 
slug: kb-ribbonview-contentheight-nan-autofit
position: 12
tags: radribbonview, autofit,nan,contentheight
ticketid: 1388550
---

## Environment
<table>
	<tr>
		<th scope="row">Product Version</th>
		<td>2019.1.116</td>
	</tr>
	<tr>
		<th scope="row">Product</th>
		<td>RadRibbonView for WPF</td>
	</tr>
</table>

## Description

How to autofit the content area of RadRibbonView to the elements in the selected tab.

## Solution

To make the content height stretch based on the size of the elements in the selected tab, you can set the ContentHeight property of RadRibbonView to double.NaN.


```XAML
    <telerik:RadRibbonView ContentHeight="NaN" />
```


```C#
     this.radRibbonView.ContentHeight = double.NaN;
```

![Before (left) and after (right) visual example](images/kb-ribbonview-contentheight-nan-autofit-0.png)

## See Also
* [Getting Started]({%slug radribbonview-gettingstarted%})
* [Controlling Appearance]({%slug radribbonview-styling-controlling-appearance%})
