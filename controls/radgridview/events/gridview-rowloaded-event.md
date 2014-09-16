---
title: RowLoaded / RowUnloaded
page_title: RowLoaded / RowUnloaded
description: RowLoaded / RowUnloaded
slug: gridview-rowloaded-event
tags: rowloaded,/,rowunloaded
publish: True
position: 7
---

# RowLoaded / RowUnloaded



The __RowLoaded__ and __RowUnloaded__ events fire for each row of the RadGridView.

You can subscribe to the __RowLoaded / RowUnloaded__events declaratively or runtime like this:

#### __XAML__

{{region gridview-rowloaded-event_0}}
	<telerik:RadGridView Name="RadGridView1" RowLoaded="gridView_RowLoaded" RowUnloaded="gridView_RowUnloaded" />
	{{endregion}}



#### __C#__

{{region gridview-rowloaded-event_1}}
	this.RadGridView1.RowLoaded += new EventHandler<RowLoadedEventArgs>(RadGridView1_RowLoaded);
	this.RadGridView1.RowUnloaded += new EventHandler<RowUnloadedEventArgs>(RadGridView1_RowUnloaded);
	{{endregion}}



#### __VB.NET__

{{region gridview-rowloaded-event_2}}
	AddHandler Me.RadGridView1.RowLoaded, New EventHandler(Of RowLoadedEventArgs)(AddressOf RadGridView1_RowLoaded)
	AddHandler Me.RadGridView1.RowUnloaded, New EventHandler(Of RowUnloadedEventArgs)(AddressOf RadGridView1_RowUnloaded)
	{{endregion}}



## RowLoaded event 

The __RowLoaded__ event fires anytime the row appears within the view port.

The __RowLoaded__ event handler receives two arguments:

1. The sender argument contains the __RadGridView__. This argument is of type object, but can be cast to the __RadGridView__ type.
2. A __RowLoadedEventArgs__ object. This object has the following properties:

* __DataElement__ - Gets the data element (data context) for the row being loaded

* __GridViewDataControl__ - The gridview control holding the row being loaded

* __Row__ - The row being loaded



The example below uses the __RowLoaded__ event to disable any row with a Person with age under 30. The example below assumes the grid is bound to List of __Person__ objects:

#### __C#__

{{region gridview-rowloaded-event_3}}
	void RadGridView1_RowLoaded(object sender, RowLoadedEventArgs e)  
	 {  
	      if (e.Row is GridViewRow &&!(e.Row is GridViewNewRow) )  
	      {  
	           Person person = e.DataElement as Person;  
	           if ( person.Age < 30 )  
	             ((GridViewRow) e.Row).IsEnabled = false;  
	      }  
	 }
	{{endregion}}



#### __VB.NET__

{{region gridview-rowloaded-event_4}}
	Sub RadGridView1_RowLoaded(sender As Object, e As RowLoadedEventArgs)
	 If TypeOf e.Row Is GridViewRow AndAlso Not (TypeOf e.Row Is GridViewNewRow) Then
	  Dim person As Person = TryCast(e.DataElement, Person)
	  If person.Age < 30 Then
	   (DirectCast(e.Row, GridViewRow)).IsEnabled = False
	  End If
	 End If
	End Sub
	{{endregion}}







## RowUnloaded event

__RowUnloaded__ event occurs anytime the row disappears within the view port.

The __RowUnloaded__ event handler receives two arguments:

1. The sender argument contains the __RadGridView__. This argument is of type object, but can be cast to the __RadGridView__ type.
2. A __RowLoadedEventArgs__ object. This object has the following properties:

* __DataElement__ - Gets the data element (data context) for the row being unloaded

* __GridViewDataControl__ - The gridview control holding the row being unloaded

* __Row__ - The row being unloaded


