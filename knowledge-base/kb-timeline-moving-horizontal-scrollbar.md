---
title: How to Control RadTimeline Horizontal Scroll Manually
description: Scrolling timeline horizontal ScrollViewer ScrollBar programmatically
page_title: Moving RadTimeLine Horizontal ScrollBar
type: how-to
slug: kb-timeline-moving-horizontal-scrollbar
position: 0
tags: visualperiodstart, visualperiodend, scrollviewer, scrollbar
ticketid: 1400046
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
		<td>RadTimeline for WPF</td>
	</tr>
</table>

## Description

How to move the horizontal scrollbar of RadTimeline manually.

## Solution

To control the horizontal scrollbar set the VisiblePeriodStart and VisiblePeriodEnd properties.

#### __[XAML]__
{{region kb-timeline-moving-horizontal-scrollbar-0}}
	<telerik:RadTimeline VisiblePeriodStart="2019/6/22"
						 VisiblePeriodEnd="2019/7/13" />
{{endregion}}

#### __[C#]__
{{region kb-timeline-moving-horizontal-scrollbar-1}}
	this.radTimeline.VisiblePeriodStart = new DateTime(2019, 6, 22);
	this.radTimeline.VisiblePeriodEnd = new DateTime(2019, 7, 13);
{{endregion}}

> VisiblePeriodStart and VisiblePeriodEnd are dependency properties, so you can data bind them as well.

## See Also  
* [Properties]({%slug radtimeline-properties%})
* [ScrollMode]({%slug radtimeline-features-scrollmode%})
