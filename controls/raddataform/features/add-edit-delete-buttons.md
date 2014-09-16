---
title: Insert, Delete and Editing Operations
page_title: Insert, Delete and Editing Operations
description: Insert, Delete and Editing Operations
slug: raddataform-add-edit-delete-buttons
tags: insert,,delete,and,editing,operations
publish: True
position: 0
---

# Insert, Delete and Editing Operations



This article explains how the edit operations of the __RadDataForm__ work. They are invoked through the Add, Edit and Delete buttons.

## Edit operation buttons

The state of the 'Add' and 'Delete' buttons depends on whether the bound data source collection supports inserting and removing items. If the collection itself supports insert and delete functionality, then the DataForm will be able to add or remove an item and the buttons will be enabled.

For example they will be enabled if the underlying collection is a List, an ObservableCollection or a custom collection that implements Add and Remove methods. On the other hand, if the underlying collection is an Array or an IEnumerable, then the buttons will be disabled as those collections do not expose those two options. 
        

Here is an example on how you could extend the IEnumerable collection to a collection that supports those operations.



#### __C#__

{{region raddataform-add-edit-delete-buttons_0}}
	
	public class MyCollection <T> : IEnumerable<Club> 
		{
			private List<Club> clubs = new List<Club>();
	
			public void Add(Club club)
			{
				this.clubs.Add(club);
			}
	
			public void AddRange(IEnumerable<Club> clubs)
			{
				this.clubs.AddRange(clubs);
			}
	
			public void Remove(Club club)
			{
				this.clubs.Remove(club);
			}
	
			public IEnumerator<Club> GetEnumerator()
			{
				return this.clubs.GetEnumerator();
			}
	
			System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}
	
	{{endregion}}



Similarly if the item is editable and the DataForm is enabled, the "Edit" button will be enabled.

>Please note that when an edit is started, the Navigation and AddNew commands get disabled, until the editing operation is committed, or cancelled.
          For more information on the behaviour of the OK and Cancel buttons you could check the article on [AutoCommit Settings]({%slug raddataform-auto-commit%})

## Cancel button

RadDataForm supports editing of types that does not implement the IEditableObject or INotifyPropertyChange interfaces. Still, please note that in this case you cannot take advantage of the cancel edit feature and the "Cancel" button will not be enabled. 
        

>tipYou can find a detailed explanation on how to implement the IEditableObject in this:
            [msdn article](http://msdn.microsoft.com/en-us/library/system.componentmodel.ieditableobject.aspx)

# See Also
