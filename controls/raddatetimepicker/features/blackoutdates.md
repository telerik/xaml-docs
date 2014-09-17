---
title: BlackoutDates
page_title: BlackoutDates
description: BlackoutDates
slug: raddatetimepicker-features-blackoutdates
tags: blackoutdates
published: True
position: 9
---

# BlackoutDates



With the Q2 SP1 2012 release we introduced an easier way to disable dates in __RadDateTimePicker__ control. Now all that is needed to disable certain dates in the calendar of the control  is to bind the __BlackoutDates__ property of the control to a collection of dates.

## Disable certain dates

RadDateTimePicker control uses RadCalendar to show its calendar and the approach on using BlackoutDates property in the two controls is the same. For detailed information on how to set up and use BlackoutDates read the help article about 
          {% if site.site_name == 'Silverlight' %}[BlackoutDates in RadCalendar](http://www.telerik.com/help/silverlight/radcalendar-features-blackoutdates.html){% endif %}{% if site.site_name == 'WPF' %}[BlackoutDates in RadCalendar](http://www.telerik.com/help/wpf/radcalendar-features-blackoutdates.html){% endif %}
        .

>importantYou can download a runnable example project that demonstrates how to use the __BlackoutDates__, __SelectableDateStart__ and __SelectableDateEnd__ from our online SDK repository
            [here](https://github.com/telerik/xaml-sdk), the example is listed as __DatePicker / AllowedDates__.
          
