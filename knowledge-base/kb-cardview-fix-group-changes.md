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

To achieve this requirement you can use a `QueryableCollectionView` and refresh and reapply the `GroupDescriptors` after updating a property in an object populating the `ItemsSource`.

#### __[C#]
    {{region cs-kb-cardview-fix-group-changes}}
        private void OnExecuted(object obj)
	{
		var lastItem = (Person)this.CollectionView[this.CollectionView.Count - 1];
		lastItem.InAttendance = false;
		this.CollectionView.GroupDescriptors.Reset();
	}
    {{endregion}}
