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

<snippet id='radgridview-managing-data-how-to-edit-item-outside-gridview-example_1_replace_an_item_in_the_collection_bound_to_the_radgridview-cs' />

<snippet id='radgridview-managing-data-how-to-edit-item-outside-gridview-example_1_replace_an_item_in_the_collection_bound_to_the_radgridview-vb' />


__Example 2: Utilize the EditItem and CommitEdit methods of the Items collection__

<snippet id='radgridview-managing-data-how-to-edit-item-outside-gridview-example_2_utilize_the_edititem_and_commitedit_methods_of_the_items_collection-cs' />

<snippet id='radgridview-managing-data-how-to-edit-item-outside-gridview-example_2_utilize_the_edititem_and_commitedit_methods_of_the_items_collection-vb' />

