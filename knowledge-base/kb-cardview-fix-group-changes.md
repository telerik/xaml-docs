---
title: CardView Refresh Collection After Group Changes
description: CardView reaply GroupDescriptors after changing card property of the item
type: how-to
page_title: Reaply GroupDescriptors in RadCardView After Changing Group Item
slug: kb-cardview-fix-group-changes
position: 0
tags: groupdescriptors, changes, collectionview, cardview
ticketid: 1630486
res_type: kb
---

## Environment
<table>
    <tbody>
        <tr>
            <td>Product Version</td>
            <td>2023.3.1010</td>
        </tr>
        <tr>
            <td>Product</td>
            <td>RadCardView for WPF</td>
        </tr>
    </tbody>
</table>

## Description

How to change the group of a card when a property in an object has been changed.

## Solution

To achieve this requirement you can use a `QueryableCollectionView` as the `ItemsSource` of `RadCardView`. Then on data item property changed, reset the `GroupDescriptors` of the collection view.


```C#
	private void UpdateItem()
	{
 		var qcv = (QueryableCollectionView)this.cardView.ItemsSource;
   		var dataItem = (Person)qcv[0];
		dataItem.GroupKeyProperty = "new group value";
		qcv.GroupDescriptors.Reset();
	}
```
