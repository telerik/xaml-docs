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
```C#
    public class CustomNavigationBehavior : DefaultNavigationBehavior
    {
        public override void Navigate(NavigationData data, NavigationDirection direction)
        {
            // Prevent navigation for the Home key
            if (direction == NavigationDirection.First)
            {
                return;
            }
            // Prevent navigation for the End key
            else if (direction == NavigationDirection.Last)
            {
                return;
            }

             var slotSelectionService = data.ServiceProvider.GetService<SlotSelectionService>();
            var currentSlot = slotSelectionService.GetSelection();

             if(currentSlot != null)
            {
                // Prevent navigation to the right, if we have selected the slot for 24th of September
                if(currentSlot.End.Month == 9 && currentSlot.End.Day == 24 && direction == NavigationDirection.Right)
                {
                    return;
                }
            }

             base.Navigate(data, direction);
        }
    }
```
```VB.NET
    Public Class CustomNavigationBehavior
        Inherits DefaultNavigationBehavior

             Public Overrides Sub Navigate(ByVal data As NavigationData, ByVal direction As NavigationDirection)
                ' Prevent navigation for the Home key
                If direction Is NavigationDirection.First Then
                    Return
                ' Prevent navigation for the End key
                ElseIf direction Is NavigationDirection.Last Then
                    Return
                End If

                 Dim slotSelectionService = data.ServiceProvider.GetService(Of SlotSelectionService)()
                Dim currentSlot = slotSelectionService.GetSelection()

                 If currentSlot IsNot Nothing Then
                    ' Prevent navigation to the right, if we have selected the slot for 24th of September
                    If currentSlot.End.Month = 9 AndAlso currentSlot.End.Day = 24 AndAlso direction Is NavigationDirection.Right Then
                        Return
                    End If
                End If

                 MyBase.Navigate(data, direction)
            End Sub
    End Class
```

__Example 2: Applying the custom NavigationBehavior__

 ```XAML
    <telerik:RadScheduleView>
        <telerik:RadScheduleView.NavigationBehavior>
            <!-- The namespace "local" refers to the namespace where the CustomNavigationBehavior is defined -->
            <local:CustomNavigationBehavior />
        </telerik:RadScheduleView.NavigationBehavior>
    </telerik:RadScheduleView>
```

## See Also

 * [SlotSelectionBehavior]({%slug radscheduleview-features-slot-selection-behavior%})

 * [AppointmentSelectionBehavior]({%slug radscheduleview-features-appointment-selection-behavior%})
