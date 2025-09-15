---
title: How do I Set FirstVisibleTime on DayView and WeekView Definitions
page_title: Apply First Visible Time Different Than 12 o Clock When Switching View Definitions
description: How to change the first FirstVisibleTime of RadScheduleView when the active view definition gets changed. 
type: how-to
slug: kb-scheduleview-set-firstvisibletime
position: 0
tags: firstvisibletime,definition
ticketid: 1418968
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.2.618</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadScheduleView for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to change the FirstVisibleTime of RadScheduleView when the active view definition gets changed. 

## Solution

Create a custom control that derives from RadScheduleView and override the OnActiveViewDefinitionChanged. Then reset the FirstVisibleTime property.


```C#
	public class CustomScheduleView : RadScheduleView
	{
		protected override void OnActiveViewDefinitionChanged(ViewDefinitionBase oldValue, ViewDefinitionBase newValue)
		{
			base.OnActiveViewDefinitionChanged(oldValue, newValue);

			// reset the first visible time
			var time = this.FirstVisibleTime;
			this.FirstVisibleTime = TimeSpan.Zero;
			this.FirstVisibleTime = time;
		}
	}
```