---
title: Events
page_title: Events
description: Events
slug: radcalendar-events
tags: events
published: True
position: 1
---

# Events



## 

The __RadCalendar__ exposes three events that can be handled: __SelectionChanged__, __DisplayDateChanged__ and __DisplayModeChanged__. The events are routed events but can also be handled like normal events: 

#### __C#__

{{region radcalendar-events_0}}
	using System;
	using System.Windows.Controls;
	namespace EventsHandling
	{
	    public partial class Page : UserControl
	    {
	        public Page()
	        {
	            InitializeComponent();
	            calendar.SelectionChanged += new EventHandler<SelectionChangedEventArgs>(calendar_SelectionChanged);
	        }
	        void calendar_SelectionChanged(object sender, SelectionChangedEventArgs e)
	        {
	            message.Text = String.Format("{0} dates have been selected.", calendar.SelectedDates.Count);
	        }
	    }
	}
	{{endregion}}



#### __XAML__

{{region radcalendar-events_1}}
	<StackPanel>
	    <telerik:RadCalendar x:Name="calendar" SelectionMode="Extended"/>
	    <TextBlock x:Name="message" />
	</StackPanel>
	{{endregion}}



The real power of the __RoutedEvents__ lies in the fact that they can be handled by any parent in the visual tree of the element that raised them.  

This can be very helpful when notification is needed from controls that are part of data templates and as such are nor easily accessible.

The following example shows how to sign up for the __SelectionChanged__ event at a parent panel of the __RadCalendar__.

#### __C#__

{{region radcalendar-events_2}}
	public Page()
	{
	    InitializeComponent();
	    //Sign up for the event:
	    this.LayoutRoot.AddHandler(RadCalendar.SelectionChangedEvent, new Telerik.Windows.Controls.SelectionChangedEventHandler(OnCalendarSelectionChanged));
	}
	private void OnCalendarSelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e)
	{
	}
	{{endregion}}


