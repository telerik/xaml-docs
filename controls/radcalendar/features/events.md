---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadCalendar {{ site.framework_name }} control.
slug: radcalendar-events
tags: events
published: True
position: 1
---

# Events

The __RadCalendar__ exposes three events that can be handled: __SelectionChanged__, __DisplayDateChanged__ and __DisplayModeChanged__. The events are routed events but can also be handled like normal events: 



```C#
	public partial class Default_Cs : UserControl
	{
	       public Default_Cs ()
	    {
	           this.InitializeComponent();
	           calendar.SelectionChanged += calendar_SelectionChanged;
	
	           calendar.SelectionChanged +=calendar_SelectionChanged;
	    }
	
	       void calendar_SelectionChanged(object sender, SelectionChangedEventArgs e)
	       {
	           message.Text = String.Format("{0} dates have been selected.", calendar.SelectedDates.Count);
	       }
	
	}
```



```XAML
	<StackPanel>
	    <telerik:RadCalendar x:Name="calendar" SelectionMode="Extended"/>
	    <TextBlock x:Name="message" />
	</StackPanel>
```

The real power of the __RoutedEvents__ lies in the fact that they can be handled by any parent in the visual tree of the element that raised them.  

This can be very helpful when notification is needed from controls that are part of data templates and as such are nor easily accessible.

The following example shows how to sign up for the __SelectionChanged__ event at a parent panel of the __RadCalendar__.



```C#
	public Page()
	{
	    InitializeComponent();
	    //Sign up for the event:
	    this.LayoutRoot.AddHandler(RadCalendar.SelectionChangedEvent, new SelectionChangedEventHandler(OnCalendarSelectionChanged));
	}
	
	private void OnCalendarSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}
```
