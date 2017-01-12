---
title: Edit an item outside RadGridView
page_title: Edit an item outside RadGridView
description: Edit an item outside RadGridView
slug: edit-item-outside-gridview
tags: edit,an,item,outside,radgridview
published: True
position: 2
---

# Edit an item outside RadGridView

As you probably know, if you [edit an item]({%slug gridview-managing-data-updating-entry%}) in RadGridView and the business object implements the __INotifyPropertyChanged__ interface - the changes immediately reflect in RadGridView. To achieve the same result when editing an item outside the user interface of RadGridView you should follow a few simple steps:

1. Before editing the item, find it in the Items collection of the gridview and call the __EditItem__(item) method of the Items collection:

#### __C#__

{{region cs-edit-item-outside-gridview_0}}
	Club selectedItem = this.clubsGrid.SelectedItem as Club;
	this.clubsGrid.Items.EditItem(selectedItem);
{{endregion}}

#### __VB.NET__

{{region vb-edit-item-outside-gridview_1}}
	Dim selectedItem As Club = TryCast(Me.clubsGrid.SelectedItem, Club)
	Me.clubsGrid.Items.EditItem(selectedItem)
{{endregion}}

2. Modify the object and then call the __CommitEdit()__ method of the Items collection:

#### __C#__

{{region cs-edit-item-outside-gridview_2}}
	selectedItem.Name = "new Name of the item";
	this.clubsGrid.Items.CommitEdit();
{{endregion}}

#### __VB.NET__

{{region vb-edit-item-outside-gridview_3}}
	selectedItem.Name = "new Name of the item"
	Me.clubsGrid.Items.CommitEdit()
{{endregion}}

That's it - the RadGridView will show the updated data immediately. 


