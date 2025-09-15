---
title: Reapply data operations when property changes
page_title: Reapply data operations when property changes
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to reapply the filtering, sorting and grouping when a property of the data item is changed.
slug: edit-item-outside-gridview
tags: edit,an,item,outside,radgridview
published: True
position: 2
---

# Edit an item outside RadGridView

When you [edit an item]({%slug gridview-managing-data-updating-entry%}) from the collection bound to the RadGridView and the business object implements the __INotifyPropertyChanged__ interface - the changes immediately reflect in the grid. However, this does not update the filtering, grouping and sorting of the control. In order to reapply those operations, you can replace the desired item in the collection bound the ItemsSource of the RadGridView (provided that the collection implements [INotifyCollectionChanged](https://docs.microsoft.com/en-us/dotnet/api/system.collections.specialized.inotifycollectionchanged?view=netframework-4.8)) with a new object. Alternatively, you can also invoke the __EditItem__ and __CommitEdit__ methods of the Items collection. Both approaches are demonstrated in __Examples 1 and 2__.

__Example 1: Replace an item in the collection bound to the RadGridView__

```C#
	var newClub = new Club("New Club");
	
	// In the context of this example this.Clubs is a collection of Club objects, which is bound to the ItemsSource of the RadGridView
    	this.Clubs[0] = newClub;
```
```VB.NET
	Dim newClub = New Club("New Club")

	' In the context of this example this.Clubs is a collection of Club objects, which is bound to the ItemsSource of the RadGridView
	Me.Clubs(0) = newClub
```

__Example 2: Utilize the EditItem and CommitEdit methods of the Items collection__

```C#
	Club selectedItem = this.gridView.SelectedItem as Club;
	this.gridView.Items.EditItem(selectedItem);
	
	selectedItem.Name = "New Name";
	this.gridView.Items.CommitEdit();
```
```VB.NET
	Dim selectedItem As Club = TryCast(Me.gridView.SelectedItem, Club)
	Me.gridView.Items.EditItem(selectedItem)
	
	selectedItem.Name = "New Name"
	Me.gridView.Items.CommitEdit()
```
