---
title: Cannot insert new row
page_title: Cannot insert new row
description: Learn how to solve the problem of not being able to add new rows to RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-troubleshooting-cannot-insert-new-row
tags: cannot,insert,new,row
published: True
position: 12
---

# Cannot insert new row

Adding new items for RadGridView is done via the GridViewNewRow control when the __Insert key__ is pressed. It should appear in the form of an empty row that allows you to enter a value for the field of each column.
      
__PROBLEM__

The user cannot add new items to RadGridView.
        
__CAUSE__

Generally the reason why you cannot add any new item, is because RadGridView does not know how to create the new object of the Item's type. This is due to the fact that the Item does not have a default constructor.
        
Another possible reason can be the type of the bound data source collection. If the collection itself does not support inserting and removing items then you will not be able to add any new item.

>tipYou can find more information on different types of collections and the functionality they provide in [this help article](http://msdn.microsoft.com/en-us/library/system.collections(v=vs.110).aspx).
        
__SOLUTION__

You could subscribe for the __AddingNewDataItem__ event of RadGridView and specify what to be the initial values for every cell in the shown insert row.

For example if you have a collection of Orders when you want to add a new Order you could use the following approach:
        


```C#
	private void ordersGrid_AddingNewDataItem(object sender, Telerik.Windows.Controls.GridView.GridViewAddingNewEventArgs e)
	{
	    e.NewObject = new Order() { CustomerID = myCustomerID };
	}
```



```VB.NET
	Private Sub ordersGrid_AddingNewDataItem(sender As Object, e As Telerik.Windows.Controls.GridView.GridViewAddingNewEventArgs)
	    e.NewObject = New Order() With {
	     .CustomerID = myCustomerID
	    }
	End Sub
```

## See Also

 * [Adding New Entries]({%slug gridview-managing-data-add-new-entries%})
 * [Adding Rows]({%slug gridview-rows-adding-rows%})
