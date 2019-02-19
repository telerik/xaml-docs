---
title: Adjust the ribbon view's height to its content
description: Adjust the ribbon view's height to its content using the ContentHeight property
type: how-to
page_title: Adjust the ribbon view's height to its content
slug: kb-ribbonview-contentheight-nan-autofit
position: 
tags: autofit,nan,contentheight
ticketid: 1388550
res_type: kb
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

By default the RadRibbonView control has a fixed height (for example 80px) for the content of the selected tab. This is controlled via the ContentHeight property. 

## Solution

To make the content height to stretch based on the size of the elements in the selected tab, you can set the ContentHeight property to double.NaN.

#### Set ContentHeight in XAML
{{region kb-ribbonview-contentheight-nan-autofit-0}}
    <telerik:RadRibbonView ContentHeight="NaN" />
{{endregion}}

#### Set ContentHeight in code
{{region kb-ribbonview-contentheight-nan-autofit-1}}
     this.radRibbonView.ContentHeight = double.NaN;
{{endregion}}

#### Before (left) and after (right) visual example
![Before (left) and after (right) visual example](images/kb-ribbonview-contentheight-nan-autofit-0.png)

## See Also
* [Getting Started]({%slug radribbonview-gettingstarted%})
* [Controlling Appearance]({%slug radribbonview-styling-controlling-appearance%})
