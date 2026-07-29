---
title: Deleting an Entry
page_title: Deleting an Entry
description: Learn how to remove manually the desired items from the ItemsSource collection of Telerik's {{ site.framework_name }} DataGrid in order to delete an entry.
slug: gridview-managing-data-deleting-entry
tags: deleting,an,entry
published: True
position: 3
---

# Deleting an Entry

__GridView__ allows you to easily delete rows using the `Del` key or programmatically. 

The control doesn't have built-in UI for deleting rows, but it provides a command that allows to do that easily. The [RadGridViewCommands.Delete]({%slug gridview-commands-overview%}) is a `RoutedUICommand` that can be assigned directly to a button or any other element that supports commands. The command can be executed also manually in code. 

Another option to delete rows is to remove the data items from the `ItemsSource` collection of the `RadGridView`. 

To disable the `Del` key deletion set the `CanUserDeleteRows` property of `RadGridView` to `true`.

The following examples show how to manually remove items from the `ItemsSource`.

  
<snippet id='radgridview-managing-data-deleting-entry-block_1-xaml' />


To determine which items are to be removed, use the __SelectedItems__ collection of the __RadGridView__. You can also use the __SelectedItem__ or the __CurrentItem__ objects, but the __SelectedItems__ collection is more flexible and allows your deleting logic to function even by [multiple selection]({%slug gridview-multiple-selection%}).



<snippet id='radgridview-managing-data-deleting-entry-block_2-cs' />

<snippet id='radgridview-managing-data-deleting-entry-block_2-vb' />


When an item is removed from the __ItemsSource__ collection it is also removed from the __SelectedItems__ collection. This means that you cannot directly use the __SelectedItems__ in the same foreach, where the items get removed, because it will result in an exception. This is where the itemsToRemove comes in hand.

Here is an example of a sample deleting logic implemented in the event handler for a Button's Click event.



<snippet id='radgridview-managing-data-deleting-entry-block_3-cs' />

<snippet id='radgridview-managing-data-deleting-entry-block_3-vb' />


In this example the implementation manages both the __RadGridView__ and the data storage. Of course it is up to the developer to shape the deleting logic, so it suits the application requirements in the best way.

## See Also  
 * [Adding New Entries]({%slug gridview-managing-data-add-new-entries%})
 * [Updating an Entry]({%slug gridview-managing-data-updating-entry%})
 * [Validating]({%slug gridview-managing-data-validation%})
