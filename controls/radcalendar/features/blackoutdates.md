---
title: BlackoutDates
page_title: BlackoutDates
description: Check our &quot;BlackoutDates&quot; documentation article for the RadCalendar {{ site.framework_name }} control.
slug: radcalendar-features-blackoutdates
tags: blackoutdates
published: True
position: 3
---

# BlackoutDates

With the Q2 SP1 2012 release we introduced an easier way to disable dates in __RadCalendar__ control. Now all that is needed to disable certain dates in the Calendar is to bind the __BlackoutDates__ property of the control to a collection of dates.

## Disable certain dates

The purpose of the following tutorial is to show how to disable certain dates in RadCalendar.

* Add a property for the blackout dates in your view model:



<snippet id='radcalendar-features-blackoutdates-block_1-cs' />

* Populate the property with some sample data:



<snippet id='radcalendar-features-blackoutdates-block_2-cs' />

* Bind the collection to the BlackoutDates property of the Calendar control:



<snippet id='radcalendar-features-blackoutdates-block_3-xaml' />

The end result is:

* Without BlackoutDates set:

![radcalendar-features-blackoutdates-1](images/radcalendar-features-blackoutdates-1.png)

* With BlackoutDates set:

![radcalendar-features-blackoutdates-2](images/radcalendar-features-blackoutdates-2.png)
