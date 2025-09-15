---
title: Adjust ribbon view's height to its content
description: Autofit RadRibbonView content height to the selected item content.
type: how-to
page_title: Autosize RadRibbonView height to selected tab elements 
slug: kb-ribbonview-contentheight-nan-autofit
position: 12
tags: autofit,nan,contentheight
ticketid: 1388550
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2019.1.116</td>
	</tr>
	<tr>
		<td>Product</td>
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
