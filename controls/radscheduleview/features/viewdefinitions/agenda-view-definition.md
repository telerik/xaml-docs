---
title: Agenda View
page_title: AgendaViewDefinition
description: AgendaViewDefinition allows you to display a set of appointments for a specific period of time.
slug: radscheduleview-viewdefinitions-agenda
tags: agendaviewdefinition, appointments
published: True
position: 5
---

# Agenda View

__AgendaViewDefinition__ allows you to display a set of appointments for a specific period of time.

>tip See the [Configuration]({%slug radscheduleview-viewdefinitions-configuration%}) article to see the functionality that is shared accross the different views.

## Setting up the View

To set any of the RadScheduleView's view definition objects, add it in the ViewDefinitions collection. The following example shows how to setup RadScheduleView in a basic scenario and use the AgendaViewDefinition element.

__Example 1: Define RadScheduleView and set AgendaViewDefinition in the ViewDefinitions collection__
```XAML
	<telerik:RadScheduleView x:Name="radScheduleView">
		<telerik:RadScheduleView.ViewDefinitions>
			<telerik:AgendaViewDefinition />
		</telerik:RadScheduleView.ViewDefinitions>
	</telerik:RadScheduleView>
```

__Example 2: Setting the AppointmentSource of RadScheduleView__
```C#
	var currentDate = DateTime.Today;
	var source = new ObservableCollection<Appointment>();
	for (int i = 0; i < 5; i++)
	{
		currentDate = DateTime.Today.AddDays(i);
		for (int k = 0; k < 3; k++)
		{
			source.Add(new Appointment() { Subject = "Appointment " + k , Start = currentDate.AddHours(k), End = currentDate.AddHours(k + 1)});
		}
	}

	this.radScheduleView.AppointmentsSource = source;
```

#### Figure 1: AgendaViewDefinition
![{{ site.framework_name }} RadScheduleView AgendaViewDefinition](images/radscheduleview-viewdefinition-agenda-0.png)

## Number of Visible Days

To set the number of visible days, set the __VisibleDays__ property of AgendaViewDefinition. This determines how many rows with days will be visible in the current view.

__Example 3: Setting visible days number__
```XAML
	<telerik:RadScheduleView.ViewDefinitions>
		<telerik:AgendaViewDefinition VisibleDays="2" />
	</telerik:RadScheduleView.ViewDefinitions>
```

The default value of VisibleDays is 7.

#### Figure 2: AgendaViewDefinition with 2 visible days
![{{ site.framework_name }} RadScheduleView AgendaViewDefinition with 2 visible days](images/radscheduleview-viewdefinition-agenda-1.png)

## Hide Empty Days

The agenda view displays empty days by default. You can alter this behavior and hide days that don't contain appointments, by setting the __ShowEmptyDays__ property to __False__.

__Example 4: Hiding empty days__
```XAML
	<telerik:RadScheduleView.ViewDefinitions>
		<telerik:AgendaViewDefinition ShowEmptyDays="False" />
	</telerik:RadScheduleView.ViewDefinitions>
```

#### Figure 3: Setting ShowEmptyDays with appointments (comparison)
![{{ site.framework_name }} RadScheduleView Setting ShowEmptyDays with appointments (comparison)](images/radscheduleview-viewdefinition-agenda-2.png)

#### Figure 4: Setting ShowEmptyDays without appointments (comparison)
![{{ site.framework_name }} RadScheduleView Setting ShowEmptyDays without appointments (comparison)](images/radscheduleview-viewdefinition-agenda-3.png)

## See Also
* [Getting Started]({%slug radscheduleview-getting-started%})
* [ViewDefinitions Overview]({%slug radscheduleview-viewdefinitions-overview%})
* [ViewDefinitions Configuration]({%slug radscheduleview-viewdefinitions-configuration%})


