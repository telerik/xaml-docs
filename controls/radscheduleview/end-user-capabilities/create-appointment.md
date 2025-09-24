---
title: Create Appointment
page_title: Create Appointment
description: Check our &quot;Create Appointment&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-end-user-capabilities-create-appointment
tags: create,appointment
published: True
position: 1
---

# Create Appointment

This topic describes the work flow for creating an appointment in __RadScheduleView__ control.      

## Using UI

__RadScheduleView__ uses one and the same dialog to create and edit appointments. This topic describes the end-user's work flow for creating a new appointment.        

* In order to create a new appointment just double click the time when you want the appointment to occur. In Day, Week or Timeline view, you can double-click on a specific starting time to create an appointment. In Month view, appointments always start out as all-day events. The edit appointment dialog appears:

![RadScheduleView Create Appointment](images/radscheduleview_end_user_capabilities_create_appointment_01.png)

* Enter Subject, Description, Start and End time of the appointment. Keep in mind that the subject text will be displayed as label for this appointment in the schedule view.

* You can also assign a category, time marker or importance by using the tool bar controls.

* If you have completed the appointment edit, click the 'OK' button or press the __Enter__ key. If you want to cancel the appointment creation, click the X button, the Close button or press the __Esc__ key.

## Using code

You can add new appointment using the code. Here are the steps to accomplish this:

1. Call __CreateNew()__ method of the __RadScheduleView__ control. It creates an instance of the __IAppointment__ class and returns it. This method has 2 overloads:

1. Set the properties for the new appointment.

1. Call __Commit()__ method to commit the changes to this object and to update the __UI__.
          



```C#
	IAppointment appointment = this.radScheduleView.CreateNew();
	appointment.Start = DateTime.Now;
	appointment.End = DateTime.Now.AddHours(1);
	appointment.Subject = "New appointment";
	this.radScheduleView.Commit();
```



```VB.NET
	Dim appointment As IAppointment = Me.radScheduleView.CreateNew()
	appointment.Start = DateTime.Now
	appointment.End = DateTime.Now.AddHours(1)
	appointment.Subject = "New appointment"
	Me.radScheduleView.Commit()
```

## See Also

 * [Understanding Appointments]({%slug radscheduleview-getting-started-add-edit-delete-appointment%})

 * [Edit Appointment]({%slug radscheduleview-end-user-capabilities-edit-appointment%})

 * [Delete Appointment]({%slug radscheduleview-end-user-capabilities-delete-appointment%})
