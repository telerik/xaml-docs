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

In the following solution we are going to demonstrate how to change the group of a card when a property in an object has been changed.

## Solution

To achieve this requirement you can use a __QueryableCollectionView__ and refresh and reapply the __GroupDescriptors__ after updating a property in an object populating the __ItemsSource__.

#### __[C#]
    {{region cs-kb-cardview-fix-group-changes}}
        private void OnExecuted(object obj)
	{
    		var groupDescriptors = new GroupDescriptorCollection();
    		groupDescriptors.AddRange(this.CollectionView.GroupDescriptors);

    		this.CollectionView.GroupDescriptors.Clear();
    
    		var lastItem = this.CollectionView[this.CollectionView.Count - 1];
    		(lastItem as Person).InAttendance = !(lastItem as Person).InAttendance;

    		this.CollectionView.GroupDescriptors.AddRange(groupDescriptors);
	}
    {{endregion}}
