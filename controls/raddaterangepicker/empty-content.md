---
title: Empty Content
page_title: Empty Content
description: Check our &quot;Empty Content&quot; documentation article for the RadDateRangePicker WPF control.
slug: raddaterangepicker-empty-content
tags: daterangepicker,empty,content
published: True
position: 8
---

# Empty Content

The empty content of DateRangePicker is displayed when no dates are selected and the control is not focused.

By default there is nothing displayed in the empty content area. To change this, set the `EmptyContent` property of `RadDateRangePicker`. 

__Setting the empty content__
```XAML
	<telerik:RadDateRangePicker EmptyContent="Select dates range" />
```

![Picture showing WPF RadDateRangePicker with string assigned to the EmptyContent](images/raddaterangepicker-empty-content-0.png)

To customize the empty content further, you can use a visual element in the `EmptyContent` or define a `DataTemplate` and assign it to the `EmptyContentTemplate` property. The data context passed to the `EmptyContentTemplate` is the value of the `EmptyContent` property.

__Setting visual element in the empty content__
```XAML
	<telerik:RadDateRangePicker>
		<telerik:RadDateRangePicker.EmptyContent>
			<TextBlock Text="Select dates range" Foreground="#F5CC84" FontStyle="Normal"/>
		</telerik:RadDateRangePicker.EmptyContent>
	</telerik:RadDateRangePicker>
```

__Setting the empty content template__
```XAML
	<telerik:RadDateRangePicker>
		<telerik:RadDateRangePicker.EmptyContentTemplate>
			<DataTemplate>
				<TextBlock Text="Select dates range" Foreground="#F5CC84" FontStyle="Normal"/>
			</DataTemplate>
		</telerik:RadDateRangePicker.EmptyContentTemplate>
	</telerik:RadDateRangePicker>
```

![Picture showing WPF RadDateRangePicker with visual element assigned as EmptyContent](images/raddaterangepicker-empty-content-1.png)

## See Also
* [Getting Started]({%slug raddaterangepicker-getting-started%})
* [Events]({%slug raddaterangepicker-events%})