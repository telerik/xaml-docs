---
title: ReadOnlyBehavior
page_title: ReadOnlyBehavior
description: Check our &quot;ReadOnlyBehavior&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-features-readonly-behavior
tags: readonlybehavior
published: True
position: 20
---

# ReadOnlyBehavior

RadScheduleView's **ReadOnlyBehavior** is responsible for determining which operations are applicable to the appointments in the control. It can be customized in order to implement logic for whether you can save, edit, drag, resize, delete an appointment and edit a slot. This is done by inheriting the ReadOnlyBehavior class and overriding one or several of its virtual methods:

  * **CanSaveAppointment**: Override to add logic for whether an appointment can be saved.
  * **CanEditAppointment**: Override to add logic for whether an appointment can be edited.
  * **CanDragAppointment**: Override to add logic for whether an appointment can be dragged.
  * **CanResizeAppointment**: Override to add logic for whether an appointment can be resized.
  * **CanDeleteAppointment**: Override to add logic for whether an appointment can be deleted.
  * **CanEditSlot**: Override to add logic for whether a slot can be edited.

## Implementing Custom ReadOnlyBehavior

To implement a custom readonlybehavior, you have to create a class which inherits ReadOnlyBehavior.

__Example 1: Custom ReadOnlyBehavior__

<snippet id='radscheduleview-features-readonlybehavior-block_1-cs' />
<snippet id='radscheduleview-features-readonlybehavior-block_2-vb' />

> Note, that by default the base class implementation of the ReadOnlyBehavior class works with the [ReadOnlySlots]({%slug radscheduleview-features-speacialslots%}) of the RadScheduleView. If you want to change the default behavior, you can introduce custom logic. For an example implementation, check out the [ReadOnlyBehavior](https://github.com/telerik/xaml-sdk/tree/master/ScheduleView/CustomReadOnlyBehavior) SDK example.

Then you need to set it to RadScheduleView's **ReadOnlyBehavior** property.

__Example 2: Setting ReadOnlyBehavior__

<snippet id='radscheduleview-features-readonlybehavior-block_3-xaml' />

> In this example the namespace **"local"** is referring to the namespace in which the CustomReadonlyBehavior is declared.

## See Also

 * [AppointmentSelectionBehavior]({%slug radscheduleview-features-appointment-selection-behavior%})

 * [Custom Slots]({%slug radscheduleview-features-customslots%})

 * [Special and ReadOnly slots]({%slug radscheduleview-features-speacialslots%})