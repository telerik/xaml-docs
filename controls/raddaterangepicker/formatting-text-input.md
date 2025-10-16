---
title: Text Input Formatting
page_title: Text Input Formatting
description: Check our &quot;Text Input Formatting&quot; documentation article for the RadDateRangePicker WPF control.
slug: raddaterangepicker-text-input-formatting
tags: daterangepicker,input,formatting
published: True
position: 10
---

# Text Input Formatting

The DateRangePicker control provides a variety of settings that can be used to customize the date text input.

## Using Format String

To format the string value that shows the start and end dates, you can use the `FormatString` property of `RadDateRangePicker`.

__Setting the FormatString property__
```XAML
	<telerik:RadDateRangePicker FormatString="{}Dates range: {0}" />
```

![Picture showing WPF RadDateRangePicker with custom format string](images/raddaterangepicker-text-input-formatting-0.png)

## Changing the Placeholder Symbol

The placeholder symbol is the underscore displayed when the selection is empty and the text input is focused.

__Default placeholder symbol__  

![Picture showing WPF RadDateRangePicker default placeholder](images/raddaterangepicker-text-input-formatting-1.png)

To change the symbol, set the `Placeholder` property of `RadDateRangePicker`.

__Setting the Placeholder property__
```XAML
	<telerik:RadDateRangePicker Placeholder="t"/>
```

__Custom placeholder symbol__  
![Picture showing WPF RadDateRangePicker with custom placeholder](images/raddaterangepicker-text-input-formatting-2.png)

## Changing the Separator Between the Dates

The default separator between the date texts is the `:` symbol. To change this, set the `Separator` property of `RadDateRangePicker`.

__Setting the Separator property__
```XAML
	<telerik:RadDateRangePicker Separator="to"/>
```

__Custom separator__  
![Picture showing WPF RadDateRangePicker with custom separator](images/raddaterangepicker-text-input-formatting-3.png)

## Setting Date Pattern

The date pattern allows you to set the formatting of the date parts of the text. To apply a custom pattern, set the `DatePattern` property of `RadDateRangePicker`.

__Setting the Separator property__
```XAML
	<telerik:RadDateRangePicker DatePattern="d-M-yyyy"/>
	<telerik:RadDateRangePicker DatePattern="yyyy/MM/dd"/>
```

__Custom date patterns__   
  
![Picture showing WPF RadDateRangePicker with custom date pattern](images/raddaterangepicker-text-input-formatting-4.png)

The `DatePattern` doesn't support formats for abbreviated days (ddd, dddd) and months (MMM, MMMM).

If the `DatePattern` cannot correctly parse the date, the `Culture` settings are used.

## See Also  
* [Customizing Appearance]({%slug raddaterangepicker-customizing-appearance%})
* [Getting Started]({%slug raddaterangepicker-getting-started%})
* [Selection]({%slug raddaterangepicker-programmatic-selection%})
