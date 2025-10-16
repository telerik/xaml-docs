---
title: Set Today
page_title: Set Today
description: Check our &quot;Set Today&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-viewdefinitions-set-today
tags: settoday, todaybuttonvisibility
published: True
position: 5
---

# Set Today

The scheduleview control allows you to easily navigate to the current day. You can do this via the *Today* button shown in __Figure 1__ or by executing the __RadScheduleViewCommands.SetToday__ command.

## Showing the Today button

The *Today* button is hidden by default. To show it in the [navigation header]({%slug radscheduleview-getting-started-visual-structure%}) you can set the __TodayButtonVisibility__ property.

__Example 1: Showing the Today button__
```XAML
	<telerik:RadScheduleView TodayButtonVisibility="Visible" />
```

#### Figure 1: Today button
![{{ site.framework_name }} RadScheduleView Today button](images/radscheduleview-viewdefinition-set-today-0.png)

## Set Today in Code

You can navigate to the current day in the view using the __RadScheduleViewCommands.SetToday__ command.

__Example 2: Set today in code__
```C#
	RadScheduleViewCommands.SetToday.Execute(null, scheduleView);
```

> Read more about the available commands in the [Commands]({%slug radscheduleview-features-commands%}) article.

## See Also
* [Getting Started]({%slug radscheduleview-getting-started%})
* [ViewDefinitions Overview]({%slug radscheduleview-viewdefinitions-overview%})
* [ViewDefinitions Configuration]({%slug radscheduleview-viewdefinitions-configuration%})


