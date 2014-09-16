---
title: Column resize
page_title: Column resize
description: Column resize
slug: gridview-column-resize-event
tags: column,resize
publish: True
position: 6
---

# Column resize



As of __Q1 2010 SP2__, __RadGridView__ provides two new events which fire when the user changes the column's width - __ColumnWidthChanging__ and __ColumnWidthChanged__. 

* [Column Width Change events lifecycle](#lifecycle)

* [ColumnWidthChanging event](#changing)

* [ColumnWidthChanged event](#changed)

## Column Width Change events lifecycle

When the user resizes the column the __ColumnWidthChanging__ event is fired and if it is not canceled the __ColumnWidthChanged__ event fires after the resize is completed. Note that the user can resize columns only if the __CanUserResizeColumns__ is set to __True__ (which is the default value). 

>When the user __double clicks__ the header cell gripper and the column is resized - only the __ColumnWidthChanged__ event is fired in that case.

You can subscribe to the events either declaratively or runtime like this:

#### __XAML__

{{region gridview-column-resize-event_0}}
	<telerik:RadGridView Name="gridView"
	                    ColumnWidthChanging="gridView_ColumnWidthChanging"
	                    ColumnWidthChanged="gridView_ColumnWidthChanged"/>
	{{endregion}}



#### __C#__

{{region gridview-column-resize-event_1}}
	gridView.ColumnWidthChanging += new EventHandler<ColumnWidthChangingEventArgs>(gridView_ColumnWidthChanging);
	gridView.ColumnWidthChanged += new EventHandler<ColumnWidthChangedEventArgs>(gridView_ColumnWidthChanged);
	{{endregion}}



#### __VB.NET__

{{region gridview-column-resize-event_2}}
	AddHandler gridView.ColumnWidthChanging, AddressOf gridView_ColumnWidthChanging
	AddHandler gridView.ColumnWidthChanged, AddressOf gridView_ColumnWidthChanged
	{{endregion}}





## ColumnWidthChanging event

The __ColumnWidthChanging__ event occurs when the column is being resized. If it is canceled the column does not change its width and the __ColumnWidthChanged__ event does not fire. The event handler receives the following two arguments:

* The __sender__ argument contains the __RadGridView__. This argument is of type object, but can be cast to the __RadGridView__ type.

* A __ColumnWidthChangingEventArgs__ object. This object has the following properties: 

* __Cancel__ - gets or sets the value indicating whether the event should be canceled.

* __Column__ - the column that is being resized

* __HorizontalChangeWidth__ - a double value which indicates the number of pixels that would be added/subtracted to the column width. If you shrink the width the value will be negative, e.g. -10

* __OriginalWidth__ - a double value which presents the original width of the column

The following example shows how to allow the user to widen the column, bot not to shrink it:

#### __C#__

{{region gridview-column-resize-event_3}}
	public MainPage()
	{
	   InitializeComponent();
	   gridView.ColumnWidthChanging += new EventHandler<ColumnWidthChangingEventArgs>(gridView_ColumnWidthChanging); 
	}
	void gridView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
	{ 
	   //if we shrink the column
	   if (e.HorizontalChangeWidth < 0)
	   {
	      //cancel the event
	      e.Cancel = true;
	   }
	}
	{{endregion}}



#### __VB.NET__

{{region gridview-column-resize-event_4}}
	Public Sub New()
	 InitializeComponent()
	 AddHandler gridView.ColumnWidthChanging, AddressOf gridView_ColumnWidthChanging
	End Sub
	Private Sub gridView_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs)
	 'if we shrink the column
	 If e.HorizontalChangeWidth < 0 Then
	  'cancel the event
	  e.Cancel = True
	 End If
	End Sub
	{{endregion}}



## ColumnWidthChanged event

The __ColumnWidthChanged__ event occurs after the resize is complete. It also fires when the user double clicks the header cell gripper to automatically resize the column to fit its content.

The event handler receives the following two arguments:

* The __sender__ argument contains the __RadGridView__. This argument is of type object, but can be cast to the __RadGridView__ type.

* A __ColumnWidthChangedEventArgs__ object. This object has the following properties: 

* __Column__ - the column that has been resized

* __NewWidth__ - the value of the new width of the resized column

* __OriginalWidth__ - the value of the original width of the resized column.


