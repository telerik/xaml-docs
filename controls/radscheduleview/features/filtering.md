---
title: Filtering
page_title: Filtering
description: Filtering
slug: radscheduleview-features-filtering
tags: filtrering
published: True
position: 10
---

# Filtering

The RadScheduleView control enables you to filter its appointments and individual occurrences by passing a predicate to a view definition's **AppointmentFilter** and **OccurrenceFilter** properties. While the AppointmentFilter will filter out the appointments which fulfil the predicate's condition, the OccurrenceFilter will check each individual occurence (including exceptions) of an recurring appointment.

## AppointmentFilter

The following filter will exclude all appointments whose start date is not today.

#### [C#] Example 1: Define the appointments filter predicate

{{region cs-radscheduleview-features-filtering-1}}
    public Predicate<IAppointment> AppointmentsFilter
    {
        get { return Filter; }
    }

    public bool Filter(IAppointment appointment)
    {
        var app = appointment as Appointment;
        return app != null && TodaysAppointments(app);
    }

    public bool TodaysAppointments(Appointment app)
    {
        return app != null && app.Start.Date == DateTime.Today;
    }
{{endregion}}

#### [XAML] Example 2: Set a definition's AppointmentFilter property

{{region xaml-radscheduleview-features-filtering-2}}
	<telerik:WeekViewDefinition AppointmentFilter="{Binding AppointmentFilter}"/>
{{endregion}}

## OccurenceFilter

The filter demonstrated in **examples 3 and 4** will exclude all occurences whose total duration is more than one hour.

>The OccurenceFilter is useful when you need to exclude only certain occurrences/exceptions of any recurring appointment.

#### Example 3: Define the occurences filter predicate

{{region cs-radscheduleview-features-filtering-3}}
    public Predicate<IOccurrence> OccurenceFilter
    {
        get { return Filter; }
    }

    public bool Filter(IOccurrence occurance)
    {
        var occ = occurance as Occurrence;
        return occ != null && IsOccurenceShort(occ);
    }

    public bool IsOccurenceShort(Occurrence occ)
    {
        return (occ.End - occ.Start) <= TimeSpan.FromHours(1);
    }
{{endregion}}

#### [XAML] Example 4: Set a definition's AppointmentFilter property

{{region xaml-radscheduleview-features-filtering-4}}
	<telerik:DayViewDefinition OccurrenceFilter="{Binding OccurenceFilter}"/>
{{endregion}}

## See Also

* [Understanding Appointments]({%slug radscheduleview-getting-started-add-edit-delete-appointment%})
* [Recurrence]({%slug radscheduleview-features-recurrences-overview%})
* [Custom Appointments]({%slug radscheduleview-features-appointments-custom-appointment%})
