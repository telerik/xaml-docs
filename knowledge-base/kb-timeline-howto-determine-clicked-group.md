---
title: How to determine what group was clicked inside
description: Find out within which group did a mouse click happen.
type: how-to
page_title: Check which TimelineItemGroupControl was clicked
slug: kb-timeline-howto-determine-clicked-group
position: 0
tags: timeline, group, mouse, click, timelineitemgroupcontrol
ticketid: 1453129
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadTimeline for WPF</td>
	</tr>
</table>

## Description

How to determine which timeline group was clicked. 

## Solution

Handle the MouseRightButtonDown/MouseLeftButtonDown event of the RadTimeLine and check, if the clicked element is a TimelineItemGroupControl.

__Example 1: Checking the clicked element__
```C#

	private void RadTimeline_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        var panel = e.OriginalSource as VirtualizingTimelinePanel;
        if (panel != null)
        {
            var groupControl = panel.ParentOfType<TimelineItemGroupControl>();
            if (groupControl != null)
            {
                var context =  (TimelineDataItemGroup)groupControl.DataContext;
            }
        }
    }
```
```VB.NET

	Private Sub RadTimeline_MouseRightButtonDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs)
		Dim panel = TryCast(e.OriginalSource, VirtualizingTimelinePanel)
		If panel IsNot Nothing Then
			Dim groupControl = panel.ParentOfType(Of TimelineItemGroupControl)()
			If groupControl IsNot Nothing Then
				Dim context = CType(groupControl.DataContext, TimelineDataItemGroup)
			End If
		End If
    End Sub
```

## See Also

* [Grouping]({%slug radtimeline-features-grouping%})
