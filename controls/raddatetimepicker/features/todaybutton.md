---
title: Today Button
page_title: Today Button
description: Today Button
slug: raddatetimepicker-todaybutton
tags: today,button
published: True
position: 7
---

# Today Button

With the Q1 2016 release version of UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} a button that provides the ability to select the current date and time of __RadDateTimePicker__ was introduced. By default the button is not visible. However, you could easily visualize it by setting the __TodayButtonVisibility__ to __Visible__. You are also able to change the current content of the button using the __TodayButtonContent__.

>When the __InputMode__ is set to __DatePicker__ and the button gets pressed only the current date will be select, while when it is set to __TimePicker__ by pressing the button the current time will be selected.

#### [XAML] __TodayButtonVisibility and TodayButtonContent__

{{region raddatetimepicker-todaybutton_0}}
	<telerik:RadDateTimePicker TodayButtonVisibility="Visible" TodayButtonContent="Select Today"/>
{{endregion}}

The final result is shown on the snapshot below:

![raddatetimepicker-todaybutton-0](images/raddatetimepicker-todaybutton-01.png)

# See Also

 * [Date Selection Modes]({%slug raddatetimepicker-features-date-selection-modes%})

 * [Selection]({%slug raddatetimepicker-features-selection%})
