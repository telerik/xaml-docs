---
title: Convert Self-Referencing Data Model to Hierarchical Data Structure in RadTreeListView
description: Learn how to present hierarchical data in RadTreeListView by converting self-referencing data into a hierarchical structure suitable for the control.
type: how-to
page_title: Convert Self-Referencing Data ot Hierarchy for Use with RadTreeListView
slug: kb-treelistview-convert-flat-data-to-hierarchical-data
tags: radtreelistview, wpf, hierarchical-data, self-referencing, data-conversion
res_type: kb
ticketid: 1681195
---

## Environment

<table>
<tbody>
<tr>
<td>Product</td>
<td>RadTreeListView for WPF</td>
</tr>
<tr>
<td>Version</td>
<td>2021.3.914</td>
</tr>
</tbody>
</table>

## Description

How to convert self-referencing data model to a hierarchical data structure that can be used in list controls which support hierarchy (like RadTreeListView).

## Solution

The following example shows a common self-referencing hierarchy data model.

```csharp
	public class DataItem
	{
	   public string Id { get; set; }
	   public string Text { get; set; }
           public int? ParentId { get; set; }
	}
```
The new hierarchical data model can look like this:

```csharp
	public class HierarchicalDataItem
	{
	   public string Id { get; set; }
	   public string Text { get; set; }
	   public ObservableCollection<HierarchicalDataItem> Children { get; set; }
	}
```

The conversion can be done using an algorithm similar to this one:

```csharp
		public ObservableCollection<HierarchicalDataItem> ConvertFlatCollectionToHierarchy(List<DataItem> flatSource)
	{
		var result = new ObservableCollection<HierarchicalDataItem>();
		var idToItemDict = new Dictionary<int, HierarchicalDataItem>();

		foreach (DataItem originalItem in flatSource)
		{
			var convertedItem = new HierarchicalDataItem();
			convertedItem.Children = new ObservableCollection<HierarchicalDataItem>();
			convertedItem.Id = originalItem.Id;
			convertedItem.Text = originalItem.Text;
			idToItemDict[convertedItem.Id] = convertedItem;

			if (originalItem.ParentId == null)
			{
				result.Add(convertedItem);
			}
			else
			{
				if (idToItemDict.ContainsKey(originalItem.ParentId.Value))
				{
					idToItemDict[originalItem.ParentId.Value].Children.Add(convertedItem);
				}
			}

		}
		return result;
	}
```

The following example shows the method usage:

```csharp
		var originalData = new List<DataItem>();
	originalData.Add(new DataItem() { Text = "Item 1", Id = 1, ParentId = null });
	originalData.Add(new DataItem() { Text = "Item 2", Id = 2, ParentId = null });
	originalData.Add(new DataItem() { Text = "Item 3", Id = 3, ParentId = null });
	originalData.Add(new DataItem() { Text = "Item 1.1", Id = 4, ParentId = 1 });
	originalData.Add(new DataItem() { Text = "Item 1.2", Id = 5, ParentId = 1 });
	originalData.Add(new DataItem() { Text = "Item 2.1", Id = 6, ParentId = 2 });
	originalData.Add(new DataItem() { Text = "Item 2.2", Id = 7, ParentId = 2 });
	originalData.Add(new DataItem() { Text = "Item 3.1", Id = 8, ParentId = 3 });
	originalData.Add(new DataItem() { Text = "Item 1.1.1", Id = 9, ParentId = 4 });
	originalData.Add(new DataItem() { Text = "Item 3.1.1", Id = 10, ParentId = 8 });

	ObservableCollection<HierarchicalDataItem> convertedCollection = ConvertFlatCollectionToHierarchy(originalData);
	
	this.treeListView.ItemsSource = convertedCollection;
```



