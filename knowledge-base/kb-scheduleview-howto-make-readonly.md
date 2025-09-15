---
title: How To Make ScheduleView ReadOnly
description: How to disable appointments manipulation.
type: how-to
page_title: How To Prevent Modification of Appointments 
slug: kb-scheduleview-howto-make-readonly
position: 0
tags: ScheduleView, editing, resizing, deleting, dragging, saving, disable, readonly
ticketid: 1401926
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2019.1.220</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadScheduleView for WPF</td>
	</tr>
</table>

## Description

How to show a readonly schedule in RadScheduleView.

## Solution

Create a class inheriting [ReadOnlyBehavior](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.scheduleview.readonlybehavior) and set an instance of it to the __ReadOnlyBehavior__ property of the RadScheduleView. Override the virtual methods in order to disable deleting, dragging, editing, resizing, saving an appoitment and editing a slot by simply returning __false__ in all of them.

1. Define the ViewModel

	
	```C#
		public class ViewModel : ViewModelBase
        {
            public ObservableCollection<Appointment> Appointments { get; private set; }

            public ViewModel()
            {
                var today = DateTime.Today;
                var endOfDay = new DateTime(today.Year, today.Month, today.Day, 23, 59, 59);
                var startOfDay = new DateTime(today.Year, today.Month, today.Day, 0, 0, 0);

                this.Appointments = new ObservableCollection<Appointment>()
                {
                    new Appointment() { Subject = "First Appointment", Start = startOfDay, End = startOfDay.AddHours(1)},
                    new Appointment() { Subject = "Last Appointment", Start = endOfDay.AddHours(-1), End = endOfDay}
                };
            }
        }
	```

2. Create the custom ReadOnlyBehavior

	
	```C#
		public class CustomReadOnlyBehavior : ReadOnlyBehavior
        {
            public override bool CanSaveAppointment(IReadOnlySettings readOnlySettings, IOccurrence occurrence)
            {
                return false;
            }

            public override bool CanEditAppointment(IReadOnlySettings readOnlySettings, IOccurrence occurrence)
            {
                return false;
            }

            public override bool CanDragAppointment(IReadOnlySettings readOnlySettings, IOccurrence occurrence)
            {
                return false;
            }

            public override bool CanResizeAppointment(IReadOnlySettings readOnlySettings, IOccurrence occurrence)
            {
                return false;
            }

            public override bool CanDeleteAppointment(IReadOnlySettings readOnlySettings, IOccurrence occurrence)
            {
                return false;
            }

            public override bool CanEditSlot(IReadOnlySettings readOnlySettings, Slot slot)
            {
                return false;
            }
        }
	```

3. Define a RadScheduleView and set its __ReadOnlyBehavior__ property.

	
	```XAML
		<Grid>
            <Grid.DataContext>
                <local:ViewModel />
            </Grid.DataContext>
            
            <telerik:RadScheduleView AppointmentsSource="{Binding Appointments}">
                <telerik:RadScheduleView.ViewDefinitions>
                    <telerik:DayViewDefinition />
                </telerik:RadScheduleView.ViewDefinitions>
                <telerik:RadScheduleView.ReadOnlyBehavior>
                    <local:CustomReadOnlyBehavior />
                </telerik:RadScheduleView.ReadOnlyBehavior>
            </telerik:RadScheduleView>
        </Grid>
	```

    > Note that the namespace "local" refers to the namespace where the CustomReadOnlyBehavior class is defined.

## See Also  

* [ReadOnlyBehavior]({%slug radscheduleview-features-readonly-behavior%})
* [Implementing MVVM]({%slug radscheduleview-populating-with-data-implementing-view-model%})
