---
title: Import/Export to ICalendar
page_title: Import/Export to ICalendar
description: This article demonstrates how the appointments displayed in a RadScheduleView can be exported to the ICalendar format or imported from a file in the that format. 
slug: radscheduleview-import-export-ical
tags: import, export, ical
published: True
position: 22
---

# Import/Export to ICalendar

The RadScheduleView allows for importing and exporting data to the [ICalendar](https://en.wikipedia.org/wiki/ICalendar) format. This is supported through the [AppointmentCalendarImporter](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.scheduleview.icalendar.appointmentcalendarimporter) and [AppointmentCalendarExporter](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.scheduleview.icalendar.appointmentcalendarexporter) classes. 

{% if site.site_name == 'Silverlight' %}

> Check out the [Ical](https://demos.telerik.com/silverlight/#ScheduleView/Ical) RadScheduleView example, which demonstrates this feature.{% endif %}

{% if site.site_name == 'WPF' %}

> Check out the __Ical__ RadScheduleView example from our [demos](https://demos.telerik.com/wpf/), which demonstrates this feature.

{% endif %}

## AppointmentCalendarImporter

You can import data in the ICalendar format by using the AppointmentCalendarImporter. It exposes an __Import__ method, which expects a __TextReader__ object with the content that should be imported and returns a collection of IAppointment objects, which can be set to the AppointmentsSource of the RadScheduleView.

__Example 1: Using the AppointmentCalendarImporter__
<snippet id='radscheduleview-features-import-export-ical-block_1-cs' />
<snippet id='radscheduleview-features-import-export-ical-block_2-vb' />

## AppointmentCalendarExporter

You can export the appointments from RadScheduleView to a file in the ICalendar format with the help of the AppointmentCalendarExporter. You can use its __Export__ method, which receives a collection of appointments and a __TextWriter__ object. 

__Example 2: Using the AppointmentCalendarExporter__
<snippet id='radscheduleview-features-import-export-ical-block_3-cs' />
<snippet id='radscheduleview-features-import-export-ical-block_4-vb' />

>tip The AppointmentCalendarExporter and AppointmentCalendarImporter classes expose some useful virtual methods, which can be overriden in a derived class in cases where the import or export behavior needs to be customized.

## See Also 

* [Getting Started]({%slug radscheduleview-getting-started%})