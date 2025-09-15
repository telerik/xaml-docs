---
title: Input Modes
page_title: Input Modes
description: Check our &quot;Input Modes&quot; documentation article for the RadDateTimePicker {{ site.framework_name }} control.
slug: raddatetimepicker-features-input-modes
tags: input,modes
published: True
position: 0
---

# Input Modes

This __RadDateTimePicker__ fully replaces the functionality of the __RadTimePicker__ and __RadDatePicker__ controls. When you use a __RadDateTimePicker__ control you might want to specify that you need to use the calendar or the clock independently. 

This behavior can be controlled via the __InputMode__ property. The default value gives you both the calendar and the clock views. There are three input modes that correspond to these scenarios:

* __DatePicker__ - with this input mode your __RadDateTimePicker__ control will show only the calendar view.

* __TimePicker__ - this input mode lets your __RadDateTimePicker__ control show only the clock view.

* __DateTimePicker__ - this input mode is the default one and will visualize both the calendar and the clock views.

You can change the value of this property in XAML as shown in this snippet:

#### __XAML__

```XAML
	<telerik:RadDateTimePicker InputMode="DatePicker"/>
```

Here is the result:

![{{ site.framework_name }} RadDateTimePicker DatePicker InputMode](images/dateTimePicker_features___input_modes_010.png)

Similarly if you decide to have only the time picker you can choose the TimePicker input mode:

#### __XAML__

```XAML
	<telerik:RadDateTimePicker InputMode="TimePicker"/>
```

This leads to the following result:

![{{ site.framework_name }} RadDateTimePicker TimePicker InputMode](images/dateTimePicker_features___input_modes_020.png)

## See Also

 * [Overview]({%slug raddatetimepicker-overview%})

 * [Visual Structure]({%slug raddatetimepicke-visual-structure%})

 * [Date Selection Modes]({%slug raddatetimepicker-features-date-selection-modes%})

 * [Selection]({%slug raddatetimepicker-features-selection%})

 * [Formatting]({%slug raddatetimepicker-features-formatting%})
