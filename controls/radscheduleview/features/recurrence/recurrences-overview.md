---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-features-recurrences-overview
tags: overview
published: True
position: 0
---

# Overview

__RadScheduleView__ provides the functionality to configure repeating appointments. The user has the ability to apply recurring scheduling patterns such as daily, weekly, monthly or set a range of recurrence from date to date. The flexible rule mechanism covers all possible recurrence scenarios. Furthermore, you also have the option to handle the exceptions from this rule.        

The purpose of this overview is to give you a straight-forward way how to create and apply a recurrence pattern, rule and exception. If you want to dive deeper into the recurrence feature of the RadScheduler, check out the following topics:

* [Recurrence Pattern]({%slug radscheduleview-features-recurrences-recurrencepattern%})

* [Recurrence Rule]({%slug radscheduleview-features-recurrences-recurrencerule%})

__RadScheduleView__ includes support for recurring events on daily, weekly, monthly and yearly basis. Exceptions to the recurrence rules are also permitted. To support this recurrence behavior, the __IAppointment__ interface includes the __RecurrenceRule__ property. When an appointment is promoted into a recurring event its __RecurrenceRule__ is set with correct __RecurrencePattern__.        

>If the user modifies an individual appointment occurrence, an exception is created. This exception is added to the __RecurrenceRule__ of the master appointment along with its specific date.          

Consider the following example:

* Create a sample appointment that starts at 11/05/2011 10:00 AM and lasts half an hour: 



<snippet id='radscheduleview-features-recurrence-recurrences-overview-block_1-cs' />
<snippet id='radscheduleview-features-recurrence-recurrences-overview-block_2-vb' />

* Create a daily recurrence pattern, that specifies a limit of 4 occurrences for the appointment: 



<snippet id='radscheduleview-features-recurrence-recurrences-overview-block_3-cs' />
<snippet id='radscheduleview-features-recurrence-recurrences-overview-block_4-vb' />

* Set the recurrence rule to appointment: 



<snippet id='radscheduleview-features-recurrence-recurrences-overview-block_5-cs' />
<snippet id='radscheduleview-features-recurrence-recurrences-overview-block_6-vb' />

* Add exception date to the recurrence rule: 



<snippet id='radscheduleview-features-recurrence-recurrences-overview-block_7-cs' />
<snippet id='radscheduleview-features-recurrence-recurrences-overview-block_8-vb' />

* Create an exception appointment: 



<snippet id='radscheduleview-features-recurrence-recurrences-overview-block_9-cs' />
<snippet id='radscheduleview-features-recurrence-recurrences-overview-block_10-vb' />

Finally when you add the created appointment to the collection bound to the __AppointmentsSource__ property of the __RadScheduleView__, you'll get four generated appointments: 

![Recurrent Appointment Overview](images/radscheduleview_recurrencyoverview.png)