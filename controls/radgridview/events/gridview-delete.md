---
title: Delete
page_title: Delete
description: Delete
slug: gridview-events-delete
tags: delete
published: True
position: 3
---

# Delete



The delete events are ment to support the deleting data process. They occur when the data in the __RadGridView__ is about to be deleted or has been already deleted by the user.

Currently the delete events occur once for all the rows to be deleted. To get notified use the following events exposed by the __RadGridView__ control:

* [Delete Events Lifecycle](#deleteEventsLifecycle)

* [Deleting event](#deletingEvent)

* [Deleted event](#deletedEvent)

## Delete Events Lifecycle

It is important to know that each one of the delete events is fired only when the user is trying to delete row/rows in the __RadGridView__ control via the Delete button.

The __Deleting__ event always occurs when the user is about to delete the row/rows. The __Deleting__ event can be __canceled__ thus allowing you to stop the delete process. To do so set the __Cancel__ property of the event arguments to __True__.

If the Deleting event is not canceled then the data is deleted and the __Deleted__ event fires.

## Deleting event

The __Deleting__ event occurs when the row/rows is about to be deleted. It fires only once for all the selected rows (in case the [SelectionMode]({%slug gridview-multiple-selection%}) is set to Multiple or Extended). The Deleting event handler receives two arguments:

* The __sender__ argument contains the __RadGridView__. This argument is of type object, but can be cast to the __RadGridView__ type. 


* A __GridViewDeletingEventArgs__ object. This object has the following properties: 


* __Cancel__ - gets or sets the value indicating whether the event should be canceled. 


* __Items__ - IEnumerable<Object> collection of the gridview's items to be deleted 

You can subscribe to the __Deleting__ event declaratively or runtime like this:

#### __XAML__

{{region gridview-events-delete_0}}
	<telerik:RadGridView Name="gridView" Deleting="gridView_Deleting" />
	{{endregion}}



#### __C#__

{{region gridview-events-delete_1}}
	this.gridView.Deleting += new EventHandler<GridViewDeletingEventArgs>(gridView_Deleting);
	{{endregion}}



#### __VB.NET__

{{region gridview-events-delete_2}}
	AddHandler Me.gridView.Deleting, AddressOf gridView_Deleting
	{{endregion}}



The Deleting event is cancelable. The example below uses the __Deleting__ event to ask the user for confirmation before the deletion is performed.

#### __C#__

{{region gridview-events-delete_3}}
	public MainPage()
	{
	   InitializeComponent();
	   gridView.ItemsSource = Club.GetClubs();
	   this.gridView.Deleting += new EventHandler<GridViewDeletingEventArgs>(gridView_Deleting);
	}
	protected IEnumerable<Object> itemsToBeDeleted;
	private void gridView_Deleting(object sender, Telerik.Windows.Controls.GridViewDeletingEventArgs e)
	{
	   //store the items to be deleted
	   itemsToBeDeleted = e.Items;
	
	   //cancel the event so the item is not deleted
	   //and wait for the user confirmation
	   e.Cancel = true;
	   //open the Confirm dialog
	   RadWindow.Confirm("Are you sure?", this.OnRadWindowClosed);
	}
	private void OnRadWindowClosed(object sender, WindowClosedEventArgs e)
	{
	   //check whether the user confirmed
	   bool shouldDelete = e.DialogResult.HasValue ? e.DialogResult.Value : false;
	   if (shouldDelete)
	   {
	     foreach (var club in itemsToBeDeleted)
	     {
	        gridView.Items.Remove(club);
	     }
	   }
	}
	{{endregion}}



#### __VB.NET__

{{region gridview-events-delete_4}}
	Public Sub New()
	 InitializeComponent()
	 gridView.ItemsSource = Club.GetClubs()
	 AddHandler Me.gridView.Deleting, AddressOf gridView_Deleting
	End Sub
	Protected itemsToBeDeleted As IEnumerable(Of [Object])
	Private Sub gridView_Deleting(sender As Object, e As Telerik.Windows.Controls.GridViewDeletingEventArgs)
	 'store the items to be deleted
	 itemsToBeDeleted = e.Items
	 'cancel the event so the item is not deleted
	 'and wait for the user confirmation
	 e.Cancel = True
	 'open the Confirm dialog
	 RadWindow.Confirm("Are you sure?", Me.OnRadWindowClosed)
	End Sub
	Private Sub OnRadWindowClosed(sender As Object, e As WindowClosedEventArgs)
	 'check whether the user confirmed
	 Dim shouldDelete As Boolean = If(e.DialogResult.HasValue, e.DialogResult.Value, False)
	 If shouldDelete Then
	  For Each club As var In itemsToBeDeleted
	   gridView.Items.Remove(club)
	  Next
	 End If
	End Sub
	{{endregion}}



## Deleted event

The __Deleted__ event occurs when the data has been deleted. The __Deleted__ event handler receives two arguments:The __sender__ argument contains the __RadGridView__. This argument is of type object, but can be cast to the __RadGridView__ type. 
A __GridViewDeletedEventArgs__ object. This object has the following properties: 

* __Items__ - IEnumerable<Object> collection of the gridview's items that have been deleted

You can subscribe to the __Deleted__ event declaratively or runtime like this:

#### __XAML__

{{region gridview-events-delete_5}}
	<telerik:RadGridView Name="gridView" Deleted="gridView_Deleted" />
	{{endregion}}



#### __C#__

{{region gridview-events-delete_6}}
	this.gridView.Deleted += new EventHandler<GridViewDeletedEventArgs>(gridView_Deleted);
	{{endregion}}



#### __VB.NET__

{{region gridview-events-delete_7}}
	AddHandler Me.gridView.Deleted, AddressOf gridView_Deleted
	{{endregion}}



# See Also

 * [Overview]({%slug gridview-events-overview%})
