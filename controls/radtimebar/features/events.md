---
title: Events
page_title: Events
description: Events
slug: radtimebar-events
tags: events
published: True
position: 2
---

# Events

You can handle the following events when using the __RadTimeBar__ for a very rich user experience with the control:

* __GroupIntervalChanged__ - fires when interval groups drill level changed.

* __HoveredPeriodChanged__ - fires when the time period hovered changes.

* __ItemIntervalChanged__ - fires when the interval items drill level changed. 

* __VisiblePeriodChanged__ - fires when the period that is currently visible has changed as we scroll and zoom within the control.

* __SelectionChanged__ - fires when the time period selected has changed.

For example you can get the current item interval using the __TimeBar.ItemIntervalChanged__ event via the __TimeBar.CurrentItemInterval__ property.
This event will also fire on initial load, when the best current item interval is set.
        

#### __C#__

{{region radtimebar-events_0}}
		      public MainPage()
	        {
	            InitializeComponent();
	            radTimeBar1.ItemIntervalChanged += new EventHandler<DrillEventArgs>(radTimeBar1_ItemIntervalChanged);
	        }
	
	        void radTimeBar1_ItemIntervalChanged(object sender, DrillEventArgs e)
	        {
	            if (radTimeBar1.CurrentItemInterval is MonthInterval)
	            {
	                radTimeBar1.SelectionStart = new DateTime(2012, 05, 1);
	                radTimeBar1.SelectionEnd = new DateTime(2012, 07, 1);
	            }
	        }
	{{endregion}}



#### __VB.NET__

{{region radtimebar-events_1}}
	   public MainPage()
	   Public Sub New()
		InitializeComponent()
		AddHandler radTimeBar1.ItemIntervalChanged,      AddressOf radTimeBar1_ItemIntervalChanged
	   End Sub
	
	Private Sub radTimeBar1_ItemIntervalChanged(ByVal sender As Object, ByVal e As DrillEventArgs)
				If TypeOf  radTimeBar1.CurrentItemInterval Is MonthInterval Then
					 radTimeBar1.SelectionStart = New Date(2012, 05, 1)
					 radTimeBar1.SelectionEnd = New Date(2012, 07, 1)
				End If
	End Sub
	{{endregion}}


The same approach is applicable for groups - In order to get the current group interval you can use __TimeBar.GroupIntervalChanged__ event and __TimeBar.CurrentGroupInterval__ property respectively.
      
