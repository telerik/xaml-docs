---
title: RadTreeView SelectedItems collection is not Updated When Items are Removed
description: The SelectedItems collection of RadTreeView contains items removed from the ItemsSource
type: troubleshooting
page_title: TreeView SelectedItems Contains Child Items Removed from the ItemsSource
slug: kb-treeview-selecteditems-contains-irrelevant-items
tags: radtreeview, wpf, selection, remove, node, inotifypropertychanged, observablecollection
res_type: kb
ticketid: 1410845
---

## Environment

| Product | Version |
| --- | --- |
| RadTreeView for WPF | 2024.2.514 |

## Description

The `SelectedItems` collection of `RadTreeView` contains child data items when their associated parent data item is removed from the ItemsSource.

This issue is a limitation coming from the UI virtualization of RadTreeView.

## Solution

To resolve this, you will need to manually remove the child items from the `SelectedItems` collection before removing the parent item. 

The exact solution will depend on the exact models strucutre in the application, but the idea is the same. The following example shows how to apply this approach with a very basic model used to populate the TreeView control.

__Creating the data model__
```C#
	public class ItemInfo
	{
		public string Name { get; set; }
		public ObservableCollection<ItemInfo> Children { get; set; }
	}
```

__Populating with data__
```C#
	this.radTreeView.ItemsSource = new ObservableCollection<ItemInfo>()
	{
		new ItemInfo() 
		{ 
			Name="Item 1", 
			Children = new ObservableCollection<ItemInfo>() 
			{
				 new ItemInfo() 
				 { 
					 Name = "Item 1.1",
					 Children = new ObservableCollection<ItemInfo>()
					 {
						 new ItemInfo() { Name = "Item 1.1.1" }
					 } 
				 } 
			}
		},
		new ItemInfo() 
		{
			Name="Item 2", 
			Children = new ObservableCollection<ItemInfo>() 
			{
				new ItemInfo() { Name = "Item 2.1" },
				new ItemInfo() { Name = "Item 2.2" },
				new ItemInfo() { Name = "Item 2.3" },
			} 
		},
		new ItemInfo() { Name="Item 3" },
		new ItemInfo() { Name="Item 4" },
	};
```

__Removing an item along with its children from the ItemsSource__
```XAML
	private void RemoveItem(ItemInfo itemToRemove)
	{
		DetachChildItemFromSelectedItem(itemToRemove);
		foreach (var item in this.radTreeView.SelectedItems.ToList())
		{
			RadTreeViewItem container = this.radTreeView.ContainerFromItemRecursive(item);
			if (container == null)
			{
				this.radTreeView.SelectedItems.Remove(item);
			}
		}

		var source = (IList)this.radTreeView.ItemsSource;
		if (source.Count > 0)
		{
			source.RemoveAt(0);
		}
	}

	public void DetachChildItemFromSelectedItem(ItemInfo item)
	{
		if (item.Children != null && this.radTreeView.SelectedItem != null)
		{
			foreach (var property in item.Children)
			{
				var childNameHashCode= ((ItemInfo)this.radTreeView.SelectedItem).Name.GetHashCode();
				if (property.Name.GetHashCode() == childNameHashCode)
				{
					this.radTreeView.SelectedItem = null;
					return;
				}
				DetachChildItemFromSelectedItem(property);
			}
		}            
	}
```

