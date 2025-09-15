---
title: AppointmentSelectionBehavior
page_title: AppointmentSelectionBehavior
description: Check our &quot;AppointmentSelectionBehavior&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-features-appointment-selection-behavior
tags: appointmentselectionbehavior
published: True
position: 18
---

# AppointmentSelectionBehavior

In RadScheduleView there are plugin selection behaviors that make it possible to customize the logic behind all selections in the control. There are selection behaviors like AppointmentSelectionBehavior, SlotSelectionBehavior etc.

AppointmentSelectionBehavior is responsible for executing the selection logic of appointments in the control. Its default behavior is for single, multiple and extended selection. It is possible to customize the behavior in order to restrict selecting appointments in different resources, selecting more than one appointment etc.

## Synchronize with CurrentAppointment

The AppointmentSelectionBehavior exposes an `IsSynchronizedWithCurrentItem` property which determines whether the `CurrentAppointment` and `SelectedAppointment` properties will be synchronized (have the same value).

The default AppointmentSelectionBehavior used by the RadScheduleView control has its IsSynchronizedWithCurrentItem set to `True`, but you can change this as demonstrated in the next examples.

__Set IsSynchronizedWithCurrentItem to False__

```XAML
	<telerik:RadScheduleView.AppointmentSelectionBehavior>
		<telerik:AppointmentSelectionBehavior IsSynchronizedWithCurrentItem="False" />
	</telerik:RadScheduleView.AppointmentSelectionBehavior>
```

__Set IsSynchronizedWithCurrentItem to False__

```C#
	this.scheduleView.AppointmentSelectionBehavior = new AppointmentSelectionBehavior() { IsSynchronizedWithCurrentItem = false };
```
```VB.NET
	Me.scheduleView.AppointmentSelectionBehavior = New AppointmentSelectionBehavior() With {.IsSynchronizedWithCurrentItem = False}
```

## Disable Multiple Appointments Selection Based on ResourceName

This tutorial will go through on how to create a custom AppointmentSelectionBehavior in the scenario when there are different resources in the ScheduleView control and it is required to disable simultaneous selection of appointments in different resource groups.

>Before proceeding with this tutorial first read about [Resources in RadScheduleView]({%slug radscheduleview-features-resources%}).

* Create CustomAppointmentSelectionBehavior class that inherits AppointmentSelectionBehavior class:

#### __C#__

```C#
	public class CustomAppointmentSelectionBehavior : AppointmentSelectionBehavior
	{
	}
```

* Override the GetSelectedAppointments method:

#### __C#__

```C#
	public class CustomAppointmentSelectionBehavior : AppointmentSelectionBehavior
	{
		protected override IEnumerable<IOccurrence> GetSelectedAppointments(AppointmentSelectionState state, IOccurrence target)
		{
			var result = base.GetSelectedAppointments(state, target);
	
			if (result.Skip(1).Any())
			{
				var firstSelected = state.CurrentSelectedAppointments.First();
				var firstSelectedAppointment = GetAppointment(firstSelected);
				var firstSelectedResource = firstSelectedAppointment.Resources[0];
	
				return result.Where(occ => GetAppointment(occ).Resources.Contains(firstSelectedResource));
			}
			return result;
		}
	
		private static IAppointment GetAppointment(IOccurrence occurence)
		{
			return occurence is IAppointment ? ((IAppointment)occurence) : ((Occurrence)occurence).Appointment;
		}
	}
```

* All that is left is to attach the newly created custom behavior to the ScheduleView:

#### __XAML__

```XAML
	<telerik:RadScheduleView ...>
		<!-- ... -->
		<telerik:RadScheduleView.AppointmentSelectionBehavior>
			<local:CustomAppointmentSelectionBehavior/>
		</telerik:RadScheduleView.AppointmentSelectionBehavior>
		<!-- ... -->
	</telerik:RadScheduleView>
```

Finally the ScheduleView control in the XAML should look like this:

#### __XAML__

```XAML
	<telerik:RadScheduleView ...>
		<!-- ... -->
		<telerik:RadScheduleView.ResourceTypesSource>
			<telerik:ResourceTypeCollection>
				<telerik:ResourceType Name="Location">
					<telerik:Resource ResourceName="Room 1" />
					<telerik:Resource ResourceName="Room 2" />
					<telerik:Resource ResourceName="Room 3" />
				</telerik:ResourceType>
			</telerik:ResourceTypeCollection>
		</telerik:RadScheduleView.ResourceTypesSource>
		<telerik:RadScheduleView.GroupDescriptionsSource>
			<telerik:GroupDescriptionCollection>
				<telerik:ResourceGroupDescription ResourceType="Location" />
			</telerik:GroupDescriptionCollection>
		</telerik:RadScheduleView.GroupDescriptionsSource>
		<telerik:RadScheduleView.AppointmentSelectionBehavior>
			<local:CustomAppointmentSelectionBehavior />
		</telerik:RadScheduleView.AppointmentSelectionBehavior>
		<!-- ... -->
	</telerik:RadScheduleView>
```

The end result is:

* With the default AppointmentSelectionBehavior (before selection):

![radscheduleview features appointment selection behavior 0](images/radscheduleview_features_appointment_selection_behavior_0.png)

* With the default AppointmentSelectionBehavior (after selection with pressed Ctrl or Shift keyboard key):

![radscheduleview features appointment selection behavior 1](images/radscheduleview_features_appointment_selection_behavior_1.png)

* With the custom AppointmentSelectionBehavior (before selection):

![radscheduleview features appointment selection behavior 2](images/radscheduleview_features_appointment_selection_behavior_2.png)

* With the custom AppointmentSelectionBehavior (after selection with pressed Ctrl or Shift keyboard key):

![radscheduleview features appointment selection behavior 3](images/radscheduleview_features_appointment_selection_behavior_3.png)

## See Also

 * [Resources]({%slug radscheduleview-features-resources%})

 * [SlotSelectionBehavior]({%slug radscheduleview-features-slot-selection-behavior%})
