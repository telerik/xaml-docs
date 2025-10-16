---
title: Create Event That is Fired When RepeatButtons are Released
description: Implement event which is thrown when RepeatButtons are released.
type: how-to
page_title: Add event thrown when the up or down button is let go
slug: kb-numericupdown-howto-introduce-event-fired-when-repeatbuttons-are-released
position: 0
tags: numericupdown, released, value, changed, repeatbutton
ticketid: 1405485
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadNumericUpDown for WPF</td>
	</tr>
</table>

## Description

How to receive only one notification, when the user releases the RepeatButton in a RadNumericUpDown.

## Solution

Inherit the RadNumericUpDown control and add a handler for the __MouseLeftButtonUp__ event of the RepeatButtons within the control. In that event handler, raise a custom RoutedEvent.


```C#
    public class MyNumericUpDown : RadNumericUpDown
    {
        public MyNumericUpDown()
        {
            this.AddHandler(RepeatButton.MouseLeftButtonUpEvent, new MouseButtonEventHandler(IncreaseDecreaseButton_MouseLeftButtonUp), true);
        }
        
        private void IncreaseDecreaseButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.RaiseFinalValueChangedEvent();
        }

        public static readonly RoutedEvent FinalValueChangedEvent = EventManager.RegisterRoutedEvent(
        "FinalValueChanged", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(MyNumericUpDown));

        
        public event RoutedEventHandler FinalValueChanged
        {
            add { AddHandler(FinalValueChangedEvent, value); }
            remove { RemoveHandler(FinalValueChangedEvent, value); }
        }
    
        void RaiseFinalValueChangedEvent()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(MyNumericUpDown.FinalValueChangedEvent);
            RaiseEvent(newEventArgs);
        }
    }
```

If the [NoXaml]({%slug xaml-vs-noxaml%}#noxaml-assemblies) dlls are used, the custom control's style should be based on the default one like so:


```XAML
        <Style TargetType="local:MyNumericUpDown" BasedOn="{StaticResource RadNumericUpDownStyle}" />
```
