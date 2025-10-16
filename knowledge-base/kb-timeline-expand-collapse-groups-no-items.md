---
title: Expanding or Collapsing Groups While New Items are Added Cause the RadTimeline to Display No Items
description: Expand/collapse groups when new elements inserted at runtime leads to blank control.
type: troubleshooting
page_title: Expanding and Collapsing Groups After New Items are Added Cause the RadTimeline to Show No Items
slug: kb-timeline-expand-collapse-groups-no-items
position: 0
tags: expand,collapse,grouping,timelineitemgroupcontrol
ticketid: 1401798
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
		<td>RadTimeline for WPF</td>
	</tr>
</table>

## Description

Expanding or collapsing groups, while new items are being added, can cause the RadTimeline control to display no items at all.

## Workaround

Disable the collapse/expand animations. You can do this via an implicit style that targets the __TimelineItemGroupControl__, and set the __AnimationManager.AnimationSelector__ attached property to __null__.


```XAML
	<Window.Resources>
		<Style TargetType="telerik:TimelineItemGroupControl">
			<Setter Property="telerik:AnimationManager.AnimationSelector" Value="{x:Null}" />
		</Style>
	</Window.Resources>
```

## See Also

* [Grouping]({%slug radtimeline-features-grouping%})
