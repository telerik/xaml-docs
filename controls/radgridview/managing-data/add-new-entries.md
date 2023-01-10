---
title: Adding New Entries
page_title: Adding New Entries
description: Read more about the two ways of adding new entries in Telerik's {{ site.framework_name }} DataGrid - by pressing the Insert key or by calling the BeginInsert method.
slug: gridview-managing-data-add-new-entries
tags: adding,new,entries
published: True
position: 1
---

# {{ site.framework_name }} RadGridView Adding New Entries

RadGridView comes with out-of-the-box insert functionality.

There are three ways to insert a new row in RadGridView:

* By pressing the __Insert__ key

* By clicking on the row which is shown in the control when the **NewRowPosition** property is set to either **Top** or **Bottom**

	#### __[XAML] Example 1: Showing the GridViewNewRow__

	{{region xaml-gridview-managing-data-add-new-entries_14}}
		<telerik:RadGridView NewRowPosition="Bottom" />
	{{endregion}}

	#### __Figure 1: The GridViewNewRow__	![{{ site.framework_name }} RadGridView The GridViewNewRow](images/RadGridView_AddingNewItems_0.png)

* By calling the __BeginInsert()__ method

	#### __[C#] Example 2: Adding new rows with BeginInsert()__

		{{region cs-gridview-managing-data-add-new-entries_0}}
		this.radGridView.BeginInsert();
	{{endregion}}

	#### __[VB.NET] Example 2: Adding new rows with BeginInsert()__

		{{region vb-gridview-managing-data-add-new-entries_1}}
		Me.radGridView.BeginInsert()
	{{endregion}}

When a user adds a new item, an empty row is created in which the user can input data.

#### __Figure 2: The newly created row__

![Telerik {{ site.framework_name }} DataGrid Adding New Items 1](images/RadGridView_AddingNewItems_1.png)

>If the __IsReadOnly__ property of RadGridView is set to __True__ or the __CanUserInsertRows__ property is set to __False__, no row is added.

>important The underlying object should expose a default constructor for an empty row to be added.

## Modifying New Entries

The next step in implementing the adding functionality is to attach event handlers to the __AddingNewDataItem__ and the __RowEditEnded__ events.

#### __[XAML] Example 3: Add handlers for the AddingNewDataItem and RowEditEnded events__

	{{region xaml-gridview-managing-data-add-new-entries_5}}
	<telerik:RadGridView AddingNewDataItem="radGridView_AddingNewDataItem"
	                 RowEditEnded="radGridView_RowEditEnded" />
{{endregion}}

The __AddingNewDataItem__ event is raised before a new row is added to RadGridView. A typical use case would be when you have to set initial values for an initialized object. You can do this by passing an object to the __GridViewAddingNewEventArgs__'s **NewObject** property.

#### __[C#] Example 4: The AddingNewDataItem event handler__

	{{region cs-gridview-managing-data-add-new-entries_6}}
	private void radGridView_AddingNewDataItem(object sender, GridViewAddingNewEventArgs e)
	{
	    var employee = new Employee();
	    employee.FirstName = "John";
	    employee.LastName = "Doe";
	    e.NewObject = employee;
	}
{{endregion}}

#### __[VB.NET] Example 4: The AddingNewDataItem event handler__

	{{region vb-gridview-managing-data-add-new-entries_7}}
	Private Sub radGridView_AddingNewDataItem(ByVal sender As Object, ByVal e As GridViewAddingNewEventArgs)
	    Dim employee = New Employee()
	    employee.FirstName = "John"
	    employee.LastName = "Doe"
	    e.NewObject = employee
	End Sub
{{endregion}}

If the ItemsSource is a __DataTable.DefaultView__, you can initialize the newly inserted item as shown in **Example 4**:

#### __[C#] Example 5: Adding a new item to a DataTable__

	{{region cs-gridview-managing-data-add-new-entries_12}}
	private void radGridView_AddingNewDataItem2(object sender, GridViewAddingNewEventArgs e)
	{
	    e.Cancel = true;
	    var newRow = this.dataSource.DefaultView.AddNew();
	    newRow["FirstName"] = "John";
	    newRow["LastName"] = "Doe";
	    e.NewObject = newRow;
	}
{{endregion}}

#### __[VB.NET] Example 5: Adding a new item to a DataTable__

	{{region vb-gridview-managing-data-add-new-entries_13}}
		Private Sub radGridView_AddingNewDataItem2(sender As Object, e As GridViewAddingNewEventArgs)
		    e.Cancel = True
		    Dim newRow = Me.dataSource.DefaultView.AddNew()
		    newRow("FirstName") = "John"
		    newRow("LastName") = "Doe"
		    e.NewObject = newRow
		End Sub
	{{endregion}}

>tipVia the __OwnerGridViewItemsControl__ property of the __GridViewAddingNewEventArgs__ class you can access the __GridViewItemsControl__ for the __RadGridView__ that raised the event.

## Committing New Entries

The __RowEditEnded__ event is raised when new data is added to RadGridView. This can be done in any of the following ways: 

* When the user presses the __Enter__ key.

* When the __CommitEdit()__ method is called.

* When another row is selected.

* When the insert operation is cancelled by pressing the __Escape__ key or calling the __CancelEdit()__ method.

You can access __EditAction__ (__Commit__ or __Cancel__) and __GridViewEditOperationType__ (__Insert__ or __Edit__) using __GridViewRowEditEndedEventArgs__ of the RowEditEnded event. It also allows you to access the new data via the __NewData__ property.

#### __[C#] Example 6: Handling the RowEditEnded event__

	{{region cs-gridview-managing-data-add-new-entries_10}}
	private void radGridView_RowEditEnded(object sender, GridViewRowEditEndedEventArgs e)
	{
	    if (e.EditAction == GridViewEditAction.Cancel)
	    {
	        return;
	    }
	    if (e.EditOperationType == GridViewEditOperationType.Insert)
	    {
	        //Add the new entry to the data base.
	    }
	}
{{endregion}}

#### __[VB.NET] Example 6: Handling the RowEditEnded event__

	{{region vb-gridview-managing-data-add-new-entries_11}}
	Private Sub radGridView_RowEditEnded(ByVal sender As Object, ByVal e As GridViewRowEditEndedEventArgs)
	    If e.EditAction = GridViewEditAction.Cancel Then
	        Exit Sub
	    End If
	
	    If e.EditOperationType = GridViewEditOperationType.Insert Then
	        'Add the new entry to the data base.
	    End If
	End Sub
{{endregion}}

When the new item is committed, it is added to RadGridView's __Items__ collection.

#### __Figure 3: The new row__

![Telerik {{ site.framework_name }} DataGrid Adding New Items 2](images/RadGridView_AddingNewItems_2.png)

## See Also

 * [Updating an Entry]({%slug gridview-managing-data-updating-entry%})

 * [Deleting an Entry]({%slug gridview-managing-data-deleting-entry%})

 * [Validating]({%slug gridview-managing-data-validation%})

 * [Adding Rows]({%slug gridview-rows-adding-rows%})
