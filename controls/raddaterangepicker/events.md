---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadDateRangePicker WPF control.
slug: raddaterangepicker-events
tags: events
published: True
position: 3
---

# Events

This article lists the events specific to the `RadDateRangePicker` control. 

Currently, the control provides only a single dedicated event named `CustomRangesLoading`. It occurs when the predefined set of ranges is loading. The event can be used to modify or remove the ranges. The event arguments are of type `CustomRangesLoadingEventArgs`.

__CustomRangesLoading event handler__
```C#
	private void RadDateRangePicker_CustomRangesLoading(object sender, CustomRangesLoadingEventArgs e)
	{
		// removes the first predefined range
		e.CustomRanges.RemoveAt(0);

		// adds a new custom range
		var newRange = new CustomRange("Last 42 days")
		{
			StartDate = DateTime.Today.AddDays(-42),
			EndDate = DateTime.Today
		};
		e.CustomRanges.Add(newRange);
	}
```
