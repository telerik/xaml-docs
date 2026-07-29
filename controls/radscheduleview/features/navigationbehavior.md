---
title: NavigationBehavior
page_title: NavigationBehavior
description: This article will demonstrate the NavigationBehavior feature of RadScheduleView.
slug: radscheduleview-features-navigationbehavior
tags: navigationbehavior
published: True
position: 21
---

# NavigationBehavior

 RadScheduleView's **NavigationBehavior** is responsible for handling the keyboard navigation. The control handles the KeyDown event for the following keys: __Tab__, __PageUp__, __PageDown__, __Home__, __End__ and all of the arrow keys. The default navigation logic of the control is implemented in the [DefaultNavigationBehavior](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.scheduleview.defaultnavigationbehavior) class. 

## Implementing Custom NavigationBehavior

 In order to modify the default NavigationBehavior of the control, you can create a class inheriting __DefaultNavigationBehavior__. It exposes a single virtual method - __Navigate__, which is called when one of the navigation keys is pressed. This method receives [NavigationData](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.scheduleview.navigationdata) and [NavigationDirection](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.scheduleview.navigationdirection) parameters. The __NavigationData__ class exposes a property of type [ServiceProvider](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.iserviceprovider) through which you can get information that you might need (such as selected slots and appointments). __Example__ 1 demonstrates how you can prevent the navigation in some scenarios and use the **SlotSelectionService**.

__Example 1: Custom NavigationBehavior__
<snippet id='radscheduleview-features-navigationbehavior-block_1-cs' />
<snippet id='radscheduleview-features-navigationbehavior-block_2-vb' />

__Example 2: Applying the custom NavigationBehavior__

<snippet id='radscheduleview-features-navigationbehavior-block_3-xaml' />

## See Also

 * [SlotSelectionBehavior]({%slug radscheduleview-features-slot-selection-behavior%})

 * [AppointmentSelectionBehavior]({%slug radscheduleview-features-appointment-selection-behavior%})