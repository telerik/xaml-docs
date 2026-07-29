---
title: Snapping Appointments
page_title: Snapping Appointments
description: Check our &quot;Snapping Appointments&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-features-snapappointments
tags: snapping,appointments
published: True
position: 1
---

# Snapping Appointments

RadScheduleView provides the option to automatically snap the appointments while resizing/dragging them. This behavior is enabled through the __SnapAppointments__ Boolean property:



<snippet id='radscheduleview-features-appointments-snapappointments-block_1-xaml' />

This way during drag/resize operation the Start/End times of the appointment will be rounded according to the TimeSlots’ length:

![radscheduleview snapappointments 1](images/radscheduleview_snapappointments_1.png)

>When dragging an appointment, the default snap behavior rounds the appointment's start time to the closest tick.

You could set MinorTickLength property of the ViewDefinition in order to snap the appointments to different duration:     



<snippet id='radscheduleview-features-appointments-snapappointments-block_2-xaml' />

And the result is:

![radscheduleview snapappointments 2](images/radscheduleview_snapappointments_2.png)

>tip You can check [Configuring the TimeRuler ticks]({%slug radscheduleview-features-timeruler-ticks-configuration%}) article for more details about MinorTickLength property.

## Customizing the SnapBehavior

For more advanced scenarios when snapping of the appointments is not directly connected with the time slots, the RadScheduleView control provides a way to customize the snapping of the appointments in a more detailed manner. You just need to create a class which inherits from __Telerik.Windows.Controls.ScheduleView.SnapBehavior__ and to override its SnapStart and SnapEnd methods. Then an instance of this class should be set to the __SnapBehavior__ property of RaddScheduleView.

In the next example it is demonstrated how to set the snapping to 5 minutes regardless of the TimeSlots length.

* First, create CustomSnapBehavior class:



<snippet id='radscheduleview-features-appointments-snapappointments-block_3-cs' />

* Override the needed methods:



<snippet id='radscheduleview-features-appointments-snapappointments-block_4-cs' />

* Attach the newly created custom behavior to the ScheduleView control:



<snippet id='radscheduleview-features-appointments-snapappointments-block_5-xaml' />

So now the appointments are snapped to 5 minutes:

![radscheduleview snapappointments 3](images/radscheduleview_snapappointments_3.png)