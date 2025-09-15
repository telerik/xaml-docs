---
title: Set MinXValue and MaxXValue When DateTime Values are Used in RadSparkline
description: Define minimum and maximum values for the sparkline horizontal axis when DateTime values are added in the control.
page_title: Set Manual Range When Date Time Data is Plotted on the Sparkline
type: how-to
slug: kb-sparkline-manual-datetime-range
position: 0
tags: datetime,minxvalue,maxxvalue,range
ticketid: 1444803
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.3.917</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadSparkline for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to set the minimum (MinXValue) and maximum (MaxXValue) when DateTime values are plotted on the horizonal axis.

## Solution

To define the range manually, set the __AutoRange__ property of RadSparkline to False. Then set the __MinXValue__ and __MaxXValue__ properties. To make this work with DateTime values, you will need to use the __Ticks of the DateTime__ objects used as minimum and maximum of the range.


```C#
	this.radSparkline.AutoRange = false;
	this.radSparkline.MinXValue = minDateTime.Ticks;
	this.radSparkline.MaxXValue = maxDateTime.Ticks;
```