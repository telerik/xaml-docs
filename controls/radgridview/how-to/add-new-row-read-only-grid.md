---
title: Insert New Row in ReadOnly Grid
page_title: Insert New Row in ReadOnly Grid
description: Check out our example of how to insert a new row when the RadGridView is ReadOnly and Bound to List - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-add-new-row-read-only-grid
tags: insert,new,row,tab,read-only,list,cell,column,row
published: True
position: 14
---

# Insert New Row in ReadOnly RadGridView

When the RadGridView is read-only and bound to a collection that does not implement the __INotifyCollectionChanged__ interface, adding a new item to the collection won't be reflected inside the control. In this scenario, you can use the RadGridView __Items__ collection's __AddNewItem()__ method to add an item and select it if needed. **Example 1** shows how this can be done:

#### __[C#] Example 1: Inser New Row in ReadOnly RadGridView__

	{{region cs-gridview-add-new-row-read-only-grid_0}}
		private void Button1_Click(object sender, RoutedEventArgs e)
		{
			var item = new Club() { Name = "Asd" };
			this.myGridView.Items.AddNewItem(item);
			this.myGridView.SelectedItem = item; // select the new row if required
		}
	{{endregion}}

## See Also

* [Custom KeyboardCommandProvider]({%slug gridview-commands-keyboardcommandprovider%})
