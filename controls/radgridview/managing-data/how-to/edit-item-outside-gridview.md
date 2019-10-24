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

When you [edit an item]({%slug gridview-managing-data-updating-entry%}) from the collection bound to the RadGridView and the business object implements the __INotifyPropertyChanged__ interface - the changes immediately reflect in RadGridView. However, this does not update the filtering, grouping and sorting of the control. In order to reapply those operations, you can replace the desired item in the collection bound the ItemsSource of the RadGridView (provided that the collection implements [INotifyCollectionChanged](https://docs.microsoft.com/en-us/dotnet/api/system.collections.specialized.inotifycollectionchanged?view=netframework-4.8)) with a new object. 

#### __[C#] Example 1: Replace an item in the collection bound to the RadGridView__

{{region cs-edit-item-outside-gridview_0}}
	var newClub = new Club("New Club");
	
	// In the context of this example this.Clubs is a collection of Club objects, which is bound to the ItemsSource of the RadGridView
    	this.Clubs[0] = newClub;
{{endregion}}

#### __[VB.NET] Example 1: Replace an item in the collection bound to the RadGridView__

{{region vb-edit-item-outside-gridview_1}}
	Dim newClub = New Club("New Club")

	' In the context of this example this.Clubs is a collection of Club objects, which is bound to the ItemsSource of the RadGridView
	Me.Clubs(0) = newClub
{{endregion}}
