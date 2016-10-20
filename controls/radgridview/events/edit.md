---
title: Edit
page_title: Edit
description: Edit
slug: gridview-events-edit
tags: edit
published: True
position: 2
---

# Edit


The edit events are ment to support the editing data process. They occur when the data in the __RadGridView__ is about to be edited or has been already edited by the user.

Currently the edit events occur on row and cell level. To get notified use the following events exposed by the __RadGridView__ control:

* [Edit Events Lifecycle](#edit-events-lifecycle)

* [BeginningEdit](#beginningedit-event)

* [PreparingCellForEdit](#preparingcellforedit-event)

* [PreparedCellForEdit](#preparedcellforedit-event)

* [CellEditEnded](#celleditended-event)

* [RowEditEnded](#roweditended-event)

## Edit Events Lifecycle

It is important to know that each one of the edit events is fired only when the user is trying to edit data in __RadGridView__ control.

The __BeginningEdit__ event always occurs when the user is about to edit the data. The __BeginningEdit__ event allows you to stop the edit process by setting the boolean property __Cancel__ to __True__. Note that regarding the fact that the edit process is cancelled, the __BeginningEdit__ event will still be raised. If not canceled, the __PreparingCellForEdit__ event is fired. You can access the default editing element there and set its properties if needed. The PreparingCellForEdit can be canceled too, thus preventing the __PreparedCellForEdit__ event to fire.

The __CellEditEnded__ event is always fired before __RowEditEnded__ event.

## BeginningEdit Event

The __BeginningEdit__ event occurs when the cell is about to enter into __EditMode__. The __BeginningEdit__ event handler receives two arguments:

* The __sender__ argument contains the __RadGridView__. This argument is of type object, but can be cast to the __RadGridView__ type.

* A __GridViewBeginningEditRoutedEventArgs__ object. This object has the following properties:

* __Cancel__ - gets or sets the value indicating whether the event should be canceled. 

* __Cell__ - gets or sets the cell. 

* __Row__ - gets or sets the row. 

You can subscribe to the __BeginningEdit__ event declaratively or runtime like this:

#### __XAML__

{{region xaml-gridview-events-edit_0}}
	<telerik:RadGridView BeginningEdit="radGridView_BeginningEdit"/>
{{endregion}}


#### __C#__

{{region cs-gridview-events-edit_1}}
	this.radGridView.BeginningEdit += radGridView_BeginningEdit;
{{endregion}}

#### __VB.NET__

{{region vb-gridview-events-edit_2}}
	AddHandler Me.radGridView.BeginningEdit, AddressOf radGridView_BeginningEdit
{{endregion}}

The __BeginningEdit__ event is cancelable:

#### __C#__

{{region cs-gridview-events-edit_3}}
	private void radGridView_CancelBeginningEdit(object sender, Telerik.Windows.Controls.GridViewBeginningEditRoutedEventArgs e)
	{
	    e.Cancel = true;
	}
{{endregion}}


#### __VB.NET__

{{region vb-gridview-events-edit_4}}
	Private Sub radGridView_CancelBeginningEdit(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.GridViewBeginningEditRoutedEventArgs)
	    e.Cancel = True
	End Sub
{{endregion}}


The example below uses the __BeginningEdit__ event to show a tool tip when the user tries to edit a cell from a certain column:

#### __C#__

{{region cs-gridview-events-edit_5}}
	private void radGridView_BeginningEdit(object sender, Telerik.Windows.Controls.GridViewBeginningEditRoutedEventArgs e)
	{
	    if (e.Cell.Column.UniqueName == "CustomerID")
	    {
	        ToolTipService.SetToolTip(e.Cell, "Editing the ID may result in inconsistency in the database");
	    }
	}
{{endregion}}


#### __VB.NET__

{{region vb-gridview-events-edit_6}}
	Private Sub radGridView_BeginningEdit(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.GridViewBeginningEditRoutedEventArgs)
	    If e.Cell.Column.UniqueName = "CustomerID" Then
	        ToolTipService.SetToolTip(e.Cell, "Editing the ID may result in inconsistency in the database")
	    End If
	End Sub
{{endregion}}


## PreparingCellForEdit Event

The PreparingCellForEdit event fires after the __BeginningEdit__ event. It allows you to access the default editor and initialize some of its properties if needed. The event handler receives two arguments:

* The __sender__ argument contains __RadGridView__. This argument is of type object, but can be cast to the __RadGridView__ type.

* A __GridViewPreparingCellForEditEventArgs__ object. This object has the following properties:

* __Cancel__ - gets or sets the value indicating whether the event should be canceled. 

* __Column__ - gets the column that the cell belong to. 

* __Row__ - gets the row that the cell belong to. 

* __EditingElement__ - gets the default editing element

The example below uses the __PreparingCellForEdit__ event to access the underlying TextBox editing element and set its TextWrapping property to Wrap:

#### __C#__

{{region cs-gridview-events-edit_7}}
	private void clubsGrid_PreparingCellForEdit(object sender, GridViewPreparingCellForEditEventArgs e)
	{
	    if ((string)e.Column.Header == "Name")
	    {
	        var tb = e.EditingElement as TextBox;
	        tb.TextWrapping = TextWrapping.Wrap;
	    }
	}
{{endregion}}

#### __VB.NET__

{{region vb-gridview-events-edit_8}}
	Private Sub clubsGrid_PreparingCellForEdit(sender As Object, e As GridViewPreparingCellForEditEventArgs)
	    If DirectCast(e.Column.Header, String) = "Name" Then
	        Dim tb = TryCast(e.EditingElement, TextBox)
	        tb.TextWrapping = TextWrapping.Wrap
	    End If
	End Sub
{{endregion}}

## PreparedCellForEdit Event

The __PreparedCellForEdit__ event fires after the __PreparingCellForEdit__ event (if not canceled). When fired, the editing element is already prepared, e.g. the text is already selected. This is the place where you can alter this behavior. 

The event handler receives two arguments:

* The __sender__ argument contains the __RadGridView__. This argument is of type object, but can be cast to the __RadGridView__ type.

* A __GridViewPreparingCellForEditEventArgs__ object. This object has the following properties:

* __Column__ - gets the column that the cell belong to. 

* __Row__ - gets the row that the cell belong to. 

* __EditingElement__ - gets the default editing element

The example below uses the __PreparedCellForEdit__ event to prevent the selection of the text inside the editing element:

#### __C#__

{{region cs-gridview-events-edit_9}}
	private void clubsGrid_PreparedCellForEdit(object sender, GridViewPreparingCellForEditEventArgs e)
	{
	    if ((string)e.Column.Header == "Name")
	    {
	        var tb = e.EditingElement as TextBox;
	        //remove the selection of the text
	        tb.SelectionLength = 0;
	    }
	}
{{endregion}}


#### __VB.NET__

{{region vb-gridview-events-edit_10}}
	Private Sub clubsGrid_PreparedCellForEdit(sender As Object, e As GridViewPreparingCellForEditEventArgs)
	    If DirectCast(e.Column.Header, String) = "Name" Then
	        Dim tb = TryCast(e.EditingElement, TextBox)
	        'remove the selection of the text
	        tb.SelectionLength = 0
	    End If
	End Sub
{{endregion}}


## CellEditEnded Event

The __CellEditEnded__ occurs when cell validation is passed successfully and new data is committed to the __RadGridView.ItemsSource__. The __CellEditEnded__ event handler receives two arguments:

* The __sender__ argument contains the __RadGridView__. This argument is of type object, but can be cast to the __RadGridView__ type. 

* A __GridViewCellEditEndedEventArgs__ object. This object has the following properties:

* __Cell__ - Gets the edited cell.

* __EditAction__ - Gets the edit action.

* __EditingElement__ - Gets the editor element.

* __NewData__ - Gets the new data.

* __OldData__ - Gets the old data.

>The __EditAction__ property is a __GridViewEditAction__ enumeration, which exposes the following values:

* __Cancel__

* __Commit__

You can subscribe to the __CellEditEnded__ event declaratively or runtime like this:

#### __XAML__

{{region xaml-gridview-events-edit_11}}
	<telerik:RadGridView CellEditEnded="radGridView_CellEditEnded"/>
{{endregion}}


#### __C#__

{{region cs-gridview-events-edit_12}}
	this.radGridView.CellEditEnded += radGridView_CellEditEnded;
{{endregion}}


#### __VB.NET__

{{region vb-gridview-events-edit_13}}
	AddHandler Me.radGridView.CellEditEnded, AddressOf radGridView_CellEditEnded
{{endregion}}


The example below uses the __CellEditEnded__ event to show a message box containing details of the cell being edited - like column's __Unique name__ and the __new value__ of the cell:

#### __C#__

{{region cs-gridview-events-edit_14}}
	private void radGridView_CellEditEnded(object sender, Telerik.Windows.Controls.GridViewCellEditEndedEventArgs e)
	{
	    Employee editedEmployee = e.Cell.DataContext as Employee;
	    string propertyName = e.Cell.Column.UniqueName;
	    MessageBox.Show(string.Format("Property {0} is edited and newValue is {1}", propertyName, e.NewData));
	}
{{endregion}}

#### __VB.NET__

{{region vb-gridview-events-edit_15}}
	Private Sub radGridView_CellEditEnded(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.GridViewCellEditEndedEventArgs)
	    Dim editedEmployee As Employee = TryCast(e.Cell.DataContext, Employee)
	    Dim propertyName As String = e.Cell.Column.UniqueName
	    MessageBox.Show(String.Format("Property {0} is edited and newValue is {1}", propertyName, e.NewData))
	End Sub
{{endregion}}

## RowEditEnded Event

The __RowEditEnded__ event occurs when row validation passed successfully and new data is committed to the __RadGridView.ItemsSource__.The __RowEditEnded__ event handler receives two arguments:

* The __sender__ argument contains the __RadGridView__. This argument is of type object, but can be cast to the __RadGridView__ type.

* A __GridViewRowEditEndedEventArgs__ object. This object has the following properties:

* __NewData__ - Gets the new data of the edited row.

* __Row__ - Gets the edited __GridViewRow__.

* __EditAction__ - Gets the edit action.

* __EditOperationType__ - Gets the edit operation type.

>tipThe __EditOperationType__ property is a __EditOperationType__ enumeration, which exposes the following values:

* __Insert__

* __Edit__

You can subscribe to the __RowEditEnded__ event declaratively or runtime like this:

#### __XAML__

{{region xaml-gridview-events-edit_16}}
	<telerik:RadGridView RowEditEnded="radGridView_RowEditEnded"/>
{{endregion}}

#### __C#__

{{region cs-gridview-events-edit_17}}
	this.radGridView.RowEditEnded += radGridView_RowEditEnded;
{{endregion}}

#### __VB.NET__

{{region vb-gridview-events-edit_18}}
	AddHandler Me.radGridView.RowEditEnded, AddressOf radGridView_RowEditEnded
{{endregion}}

The example below uses the __RowEditEnded__ to display the new data of the edited row in a text block. It also assumes that the grid is bound to List of __Employee__ objects:

#### __C#__

{{region cs-gridview-events-edit_19}}
	private void radGridView_RowEditEnded(object sender, Telerik.Windows.Controls.GridViewRowEditEndedEventArgs e)
	{
	    Employee newEmployee = e.NewData as Employee;
	    if (newEmployee != null)
	    {
	        textBlock1.Text = "e.NewData contains: " + newEmployee.ToString();
	    }
	}
{{endregion}}

#### __VB.NET__

{{region vb-gridview-events-edit_20}}
	Private Sub radGridView_RowEditEnded(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.GridViewRowEditEndedEventArgs)
	    Dim newEmployee As Employee = TryCast(e.NewData, Employee)
	    If newEmployee IsNot Nothing Then
	        textBlock1.Text = "e.NewData contains: " & newEmployee.ToString()
	    End If
	End Sub
{{endregion}}

>tipThe __CellEditEnded__ event is always fired before __RowEditEnded__ event.

# See Also

 * [Events - Overview]({%slug gridview-events-overview%})

 * [Validation Events]({%slug gridview-events-validation%})
