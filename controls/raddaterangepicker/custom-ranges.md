---
title: Custom Date Ranges
page_title: Custom Date Ranges
description: Check our &quot;Custom Date Ranges&quot; documentation article for the RadDateRangePicker WPF control.
slug: raddaterangepicker-custom-date-ranges
tags: daterangepicker,custom,ranges,dates,disabled,readonly
published: True
position: 7
---

# Custom Date Ranges

The custom ranges are a set of pre-defined date spans displayed next to the calendars of the DateRangePicker component. The set can be used to easily select a specific time span.

The `RadDateRangePicker` control has the following built-in ranges, that can be customized or removed with the `CustomRangesLoadingEventArgs` event.

* __Last 7 Days__
* __Last 30 Days__
* __Last Month__
* __Last Year__

![Picture showing the pre-defined custom date ranges of WPF RadDateRangePicker](images/raddaterangepicker-custom-date-ranges-0.png)

__Adding and removing ranges in the CustomRangesLoadingEventArgs event handler__
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

![Picture showing a new custom date range added to WPF RadDateRangePicker](images/raddaterangepicker-custom-date-ranges-1.png)

## Hiding the Date Ranges Panel

To hide the date ranges from the UI, set the `IsDefaultRangesPanelVisible` property of `RadDateRangePicker` to `false`.

__Hiding the date ranges panel__
```C#
	<telerik:RadDateRangePicker IsDefaultRangesPanelVisible="False" />
```

![Picture showing WPF RadDateRangePicker without the data ranges panel](images/raddaterangepicker-custom-date-ranges-2.png)

## See Also
* [Getting Started]({%slug raddaterangepicker-getting-started%})
* [Events]({%slug raddaterangepicker-events%})
