---
title: Insert New Row in Read-Only Grid
page_title: Add New Item to Read-Only RadGridView
description: Check out our example of how to insert a new row when the RadGridView is ReadOnly and Bound to List - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-add-new-row-read-only-grid
tags: insert,new,row,tab,read-only,list,cell,column,row
published: True
position: 14
---

# Insert New Row in ReadOnly RadGridView

When the RadGridView is read-only or bound to a collection that does not implement the __INotifyCollectionChanged__ interface you can use the RadGridView __Items__ collection's __AddNewItem()__ method to add an item and select it if needed. **Example 1** shows how this can be done:

__Example 1: Inser New Row in ReadOnly RadGridView__

```C#
	private void Button1_Click(object sender, RoutedEventArgs e)
	{
		var item = new Club() { Name = "New Club" };
		this.myGridView.Items.AddNewItem(item);
		this.myGridView.SelectedItem = item; // select the new row if required
	}
```

## See Also

* [Custom KeyboardCommandProvider]({%slug gridview-commands-keyboardcommandprovider%})
