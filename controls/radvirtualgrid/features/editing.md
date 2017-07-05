---
title: Editing
page_title: Editing
description: Editing
slug: virtualgrid-editing
tags: editing
published: True
position: 0
---

# Editing 

> By default, the __CanUserEdit__ property of __RadVirtualGrid__ is set to __False__, thus the editing mechanism is disabled. In order to enabled it, its value needs to be set to __True__

As __RadVirtualGrid__ does not utilize data binding for populating and managing its data, it does not provide a default editor. Instead, when the user double clicks to enter edit mode, the __EditorNeeded__ event is raised. 

## EditorNeeded

Through this event a custom editor for handling the editing operation can be defined. The event arguments expose the following properties:

* __ColumnIndex__: Provides information regarding the column index of the editor

* __RowIndex__: Provides information regarding the row index of the editor

* __Editor__: The control that will be used for the editing operation

* __EditorProperty__: The editor's dependency property that is to be edited

> The property of the editor that is being edited needs to be set manually as well.

#### __[C#] Example 1: Handling the EditorNeeded event__

{{region radvirtualgrid-features_editing_0}}
	private void VirtualGrid_EditorNeeded(object sender, 
            Telerik.Windows.Controls.VirtualGrid.EditorNeededEventArgs e)
        {
            TextBox tb = new TextBox();

            e.Editor = tb;
            tb.Text = String.Format("{0}.{1}", e.RowIndex, e.ColumnIndex);
            e.EditorProperty = TextBox.TextProperty;
        }
{{endregion}}

## EditorValueChanged

This event is triggered each time the underlying property value that is edited has been changed. Similarly to the previously discussed __EditorNeeded__ event, the __EditorValueChanged__'s event arguments expose the __ColumnIndex__ and __RowIndex__ properties. Furthermore, they provide information regarding the user input through the __Value__ property.

## CellEditEnded

The event is raised when the user ends editing the cell by setting the focus to another element.  This is the mechanism through which the data modified through the UI can be synchronized with the underlying data source, as updating the data source will be needed only once when the edit of the cell has ended.

## PushCellValue

When an edit is committed, the new property value needs to be manually pushed to the underlying source and to __RadVirtualGrid__ as well. The control exposes the __PushCellValue__ method for updating the UI. The method can be used in conjunction with the aforementioned __CellEditEnded__ event handler. It accepts the following parameters. 

* __PushCellValue(int columnIndex, int rowIndex, object value)__

#### __[C#] Example 2: Updating RadVirtualGrid with the modified data__
	
{{region radvirtualgrid-features_editing_1}}
	private void VirtualGrid_CellEditEnded(object sender, 
            Telerik.Windows.Controls.VirtualGrid.CellValueEventArgs e)
        {
            this.VirtualGrid.PushCellValue(e.ColumnIndex, e.RowIndex, e.Value);
        }
{{endregion}}

## See Also

* [Insert and Remove Data]({%slug virtualgrid-insert-data-and-remove-data%})

* [Pinned Rows and Columns]({%slug virtualgrid-pinned-rows-and-columns%})


