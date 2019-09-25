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

In order to modify the default NavigationBehavior of the control, you can create a class inheriting __DefaultNavigationBehavior__. It exposes a single virtual method - __Navigate__, which is called when one of the navigation keys is pressed. This method receives [NavigationData](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.scheduleview.navigationdata) and [NavigationDirection](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.scheduleview.navigationdirection) parameters. The __NavigationData__ class exposes a property of type [ServiceProvider](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.iserviceprovider) through which you can get information about various things that you might need (such as selected slots and appointments). __Example__ 1 demonstrates how you can prevent the navigation in some scenarios and use the SlotSelectionService.

#### __[C#] Example 1: Custom NavigationBehavior__
{{region cs-radscheduleview-features-navigationbehavior_0}}
    public class CustomNavigationBehavior : DefaultNavigationBehavior
    {
        public override void Navigate(NavigationData data, NavigationDirection directon)
        {
            // Prevent navigation for the Home key
            if (directon == NavigationDirection.First)
            {
                return;
            }
            // Prevent navigation for the End key
            else if (directon == NavigationDirection.Last)
            {
                return;
            }

            var slotSelectionService = data.ServiceProvider.GetService<SlotSelectionService>();
            var currentSlot = slotSelectionService.GetSelection();
                
            if(currentSlot != null)
            {
                // Prevent navigation to the right, if we have selected the slot for 24th of September
                if(currentSlot.End.Month == 9 && currentSlot.End.Day == 24 && directon == NavigationDirection.Right)
                {
                    return;
                }
            }

            base.Navigate(data, directon);
        }
    }
{{endregion}}

#### __[VB.NET] Example 1: Custom NavigationBehavior__
{{region vb-radscheduleview-features-navigationbehavior_1}}
    Public Class CustomNavigationBehavior
        Inherits DefaultNavigationBehavior

            Public Overrides Sub Navigate(ByVal data As NavigationData, ByVal directon As NavigationDirection)
                ' Prevent navigation for the Home key
                If directon Is NavigationDirection.First Then
                    Return
                ' Prevent navigation for the End key
                ElseIf directon Is NavigationDirection.Last Then
                    Return
                End If

                Dim slotSelectionService = data.ServiceProvider.GetService(Of SlotSelectionService)()
                Dim currentSlot = slotSelectionService.GetSelection()

                If currentSlot IsNot Nothing Then
                    ' Prevent navigation to the right, if we have selected the slot for 24th of September
                    If currentSlot.End.Month = 9 AndAlso currentSlot.End.Day = 24 AndAlso directon Is NavigationDirection.Right Then
                        Return
                    End If
                End If

                MyBase.Navigate(data, directon)
            End Sub
    End Class
{{endregion}}

#### __[XAML] Example 2: Applying the custom NavigationBehavior__

{{region xaml-radscheduleview-features-navigationbehavior_2}}
    <telerik:RadScheduleView>
        <telerik:RadScheduleView.NavigationBehavior>
            <!-- The namespace "local" refers to the namespace where the CustomNavigationBehavior is defined -->
            <local:CustomNavigationBehavior />
        </telerik:RadScheduleView.NavigationBehavior>
    </telerik:RadScheduleView>
{{endregion}}

## See Also

 * [SlotSelectionBehavior]({%slug radscheduleview-features-slot-selection-behavior%})

 * [AppointmentSelectionBehavior]({%slug radscheduleview-features-appointment-selection-behavior%})