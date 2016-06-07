---
title: Adding New Entries
page_title: Adding New Entries
description: Adding New Entries
slug: gridview-managing-data-add-new-entries
tags: adding,new,entries
published: True
position: 1
---

# Adding New Entries

RadGridView comes with out of the box insert functionality. In this topic we will discuss:

* [Inserting New Entries](#inserting-new-entries)

* [Modifying New Entries](#modifying-new-entries)

* [Commiting New Entries](#commiting-new-entries)

## Inserting New Entries

There are two ways to insert a new row with RadGridView - by pressing the __Insert__ key or by calling the __BeginInsert()__ method.

#### __[C#] Example 1: Adding new rows with BeginInsert()__

	{{region gridview-managing-data-add-new-entries_0}}
	this.AddingNewRowsGrid.BeginInsert();
	{{endregion}}

#### __[VB.NET] Example 1: Adding new rows with BeginInsert()__

	{{region gridview-managing-data-add-new-entries_1}}
	Me.AddingNewRowsGrid.BeginInsert()
	{{endregion}}

When adding a new item, an new empty row is created, in which the user can input the desired data.

#### __Figure 1: The newly created row__

![The newly created row](images/RadGridView_AddingNewItems_1.png)

>If the __IsReadOnly__ property of the RadGridView is set to __True__ or the __CanUserInsertRows__ property is set to __False__, no row will be added.

The next step in implementing the adding functionality is to attach event handlers to the __AddingNewDataItem__ and the __RowEditEnded__ events.

#### __[XAML] Example 2: Add handlers for the AddingNewDataItem and RowEditEnded events__

	{{region gridview-managing-data-add-new-entries_5}}
	<telerik:RadGridView x:Name="radGridView"
                         AddingNewDataItem="radGridView_AddingNewDataItem"
                         RowEditEnded="radGridView_RowEditEnded" />
	{{endregion}}

## Modifying New Entries

The __AddingNewDataItem__ event is raised before the new row is added to the RadGridView. A typical use case is when you need to set initial values for the initialized object. This can be done by passing an object to the __GridViewAddingNewEventArgs__'s **NewObject** property.

#### __[C#] Example 3: The AddingNewDataItem event handler__

	{{region gridview-managing-data-add-new-entries_6}}
	private void radGridView_AddingNewDataItem( object sender, GridViewAddingNewEventArgs e )
	{
	    var employee = new Employee();
		employee.FirstName = "John";
		employee.LastName = "Doe";
		e.NewObject = employee;
	}
	{{endregion}}

#### __[VB.NET] Example 3: The AddingNewDataItem event handler__

	{{region gridview-managing-data-add-new-entries_7}}
	Private Sub radGridView_AddingNewDataItem(ByVal sender As Object, ByVal e As GridViewAddingNewEventArgs)
	    Dim employee = New Employee()
		employee.FirstName = "John"
		employee.LastName = "Doe"
		e.NewObject = employee
	End Sub
	{{endregion}}

In the case when the ItemsSource is a __DataTable.DefaultView__, you can initialize the newly inserted item as shown in **Example 4**:

#### __[C#] Example 4: Adding a new item to a DataTable__

	{{region gridview-managing-data-add-new-entries_12}}
	radGridView_AddingNewDataItem(object sender, GridViewAddingNewEventArgs e)
	{
	    e.Cancel = true;
        var newRow = (e.OwnerGridViewItemsControl.ItemsSource as DataView).AddNew();
        newRow["Dosage"] = 100;
        newRow["Patient"] = "Doe";
        e.NewObject = newRow;
	}
	{{endregion}}

#### __[VB.NET] Example 4: Adding a new item to a DataTable__

	{{region gridview-managing-data-add-new-entries_13}}
    Private Sub New(sender As Object, e As GridViewAddingNewEventArgs)
		e.Cancel = True
		Dim newRow = TryCast(e.OwnerGridViewItemsControl.ItemsSource, DataView).AddNew()
		newRow("Dosage") = 100
		newRow("Patient") = "Doe"
		e.NewObject = newRow
    End Sub
	{{endregion}}

>tipVia the __OwnerGridViewItemsControl__ property of the __GridViewAddingNewEventArgs__ class you can access the __GridViewItemsControl__ for the __RadGridView__ that raised the event.

## Commiting New Entries

The __RowEditEnded__ event is raised when new data is added to RadGridView. This can be done by any of the following ways: 

* When the user presses the __Enter__ key.

* When the __CommitEdit()__ method is called.

* When another row is selected.

* When the insert operation is cancelled by pressing the __Escape__ key or calling the __CancelEdit()__ method.

Via the __GridViewRowEditEndedEventArgs__ of the RowEditEnded event, you can access the __EditAction__ (__Commit__ or __Cancel__) and the __GridViewEditOperationType__ (__Insert__ or __Edit__). The event arguments class also allows you to access the new data via the __NewData__ property.

#### __[C#] Example 5: Handling the RowEditEnded event__

	{{region gridview-managing-data-add-new-entries_10}}
	private void radGridView_RowEditEnded( object sender, GridViewRowEditEndedEventArgs e )
	{
	    if (e.EditAction == GridViewEditAction.Cancel)
	    {
	        return;
	    }

	    if (e.EditOperationType == GridViewEditOperationType.Insert)
	    {
	        // Add the new entry to the database.
	    }
	}
	{{endregion}}

#### __[VB.NET] Example 5: Handling the RowEditEnded event__

	{{region gridview-managing-data-add-new-entries_11}}
	Private Sub radGridView_RowEditEnded(ByVal sender As Object, ByVal e As GridViewRowEditEndedEventArgs)
	    If e.EditAction = GridViewEditAction.Cancel Then
	        Exit Sub
	    End If
	
	    If e.EditOperationType = GridViewEditOperationType.Insert Then
	        ' Add the new entry to the database.'
	    End If
	End Sub
	{{endregion}}

When the new item is committed, it will be automatically added to RadGridView's __Items__ collection.

#### __Figure 2: The new row__

![The new row](images/RadGridView_AddingNewItems_2.png)

# See Also

 * [Updating an Entry]({%slug gridview-managing-data-updating-entry%})

 * [Deleting an Entry]({%slug gridview-managing-data-deleting-entry%})

 * [Validating]({%slug gridview-managing-data-validation%})

 * [Adding Rows]({%slug gridview-rows-adding-rows%})
