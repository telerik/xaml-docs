---
title: Editing
page_title: Editing
description: Check our &quot;Editing&quot; documentation article for the RadVirtualGrid {{ site.framework_name }} control.
slug: virtualgrid-editing
tags: editing
published: True
position: 0
---

# Editing 

> By default, the __CanUserEdit__ property of __RadVirtualGrid__ is set to __True__, thus the editing mechanism is enabled. In order to disable it, its value needs to be set to __False__.

As __RadVirtualGrid__ does not utilize data binding for populating and managing its data, it does not provide a default editor. Instead, when the user double clicks to enter edit mode, the __EditorNeeded__ event is raised. This means that by default there won't be editor visulized until you create it in the event handler.

* [Events](#events)

* [Methods](#methods)

* [Edit Triggers](#edittriggers)

* [Action on LostFocus](#action-on-lostfocus)

## Events

>important The editing events will not be raised when the __DataProvider__ mechanism is used for populating the data of __RadVirtualGrid__. More information can be found in the [Getting Started]({%slug virtualgrid-getting-started2%}) topic.

### EditorNeeded

Through this event a custom editor for handling the editing operation can be defined. The event arguments expose the following properties:

* __ColumnIndex__: Provides information regarding the column index of the editor

* __RowIndex__: Provides information regarding the row index of the editor

* __Editor__: The control that will be used for the editing operation

* __EditorProperty__: The editor's dependency property that is to be edited

* __TextInput__: Gets the string containing the entered text when the __TextInput__ event occurs.The value of the property will be equal to the key with which enter mode is entered.

> The property of the editor that is being edited needs to be set manually as well.

__Example 1: Handling the EditorNeeded event__  
```C#
	private void VirtualGrid_EditorNeeded(object sender, 
            Telerik.Windows.Controls.VirtualGrid.EditorNeededEventArgs e)
        {
            TextBox tb = new TextBox();

            e.Editor = tb;
            tb.Text = String.Format("{0}.{1}", e.RowIndex, e.ColumnIndex);
            e.EditorProperty = TextBox.TextProperty;
        }
```

> Most input controls (MaskedTextInput, RadNumericUpDown, RadComboBox, etc.) in the Material, Fluent and Transparent themes have an opacity applied. This means that you can see through them which could lead to a visual glitch when used as editors in RadVirtualGrid. To avoid this set the Background property of the editor to a solid color when you create it in the event handler.

### EditorValueChanged

This event is triggered each time the underlying property value that is edited has been changed. Its event arguments provide the following information. 

* __ColumnIndex__: Provides information regarding the column index of the editor

* __RowIndex__: Provides information regarding the row index of the editor

* __Value__: Provides information regarding the user input.

__Example 2: Handling the EditorValueChanged event__  
```C#
	private void VirtualGrid_EditorValueChanged(object sender, 
			Telerik.Windows.Controls.VirtualGrid.CellValueEventArgs e)
        {
            
        }
```

### CellEditEnded

The event is raised when the user ends editing the cell by setting the focus to another element.  This is the mechanism through which the data modified through the UI can be synchronized with the underlying data source, as updating the data source will be needed only once when the edit of the cell has ended. The properties of the event arguments are listed below.

* __ColumnIndex__: Provides information regarding the column index of the editor

* __RowIndex__: Provides information regarding the row index of the editor

* __Value__: Provides information regarding the user input.

__Example 3: Handling the CellEditEnded event__  
```C#
	   private void VirtualGrid_CellEditEnded_1(object sender, CellEditEndedEventArgs e)
        {

        }
```

## Methods

### BeginEdit

Puts __RadVirtualGrid__ into edit mode for given cell coordinates. The method will work only if the control is not already in edit mode.

* __BeginEdit(int rowIndex, int columnIndex)__

### CancelEdit

Calling this method causes __RadVirtualGrid__ to cancel the current edit, revert to the original value and exit edit mode.

* __CancelEdit()__

### CommitEdit

Commits the current edit and exits edit mode. 

* __CommitEdit()__

### PushCellValue

When an edit is committed, the new property value needs to be manually pushed to the underlying source and to __RadVirtualGrid__ as well. The control exposes the __PushCellValue__ method for updating the UI. The method can be used in conjunction with the aforementioned __CellEditEnded__ event handler. It accepts the following parameters. 

* __PushCellValue(int rowIndex, int columnIndex, object value)__

__Example 2: Updating RadVirtualGrid with the modified data__  	
```C#
	private void VirtualGrid_CellEditEnded(object sender, 
            Telerik.Windows.Controls.VirtualGrid.CellValueEventArgs e)
        {
            this.VirtualGrid.PushCellValue(e.RowIndex, e.ColumnIndex, e.Value);
        }
```

## EditTriggers

__RadVirtualGrid__ provides a mechanism through which the way the control enters edit mode can be controlled. This is done through the __EditTriggers__ property. It is a flag enumeration that has the following values:

* __CellClick__: A __single click__ will put the cell into edit mode.

* __CurrentCellClick__: A click on the current cell will put it into edit mode.

* __Default__: The default setting which combines the __CurrentCellClick__, __F2__ and __TextInput__ values.

* __F2__: Pressing __F2__ on a cell will put it into edit mode.

* __None__: No action will put the cell in edit mode.

* __TextInput__: Any text input will put the cell into edit mode. When the control is populated with data manually, instead of with __DataProvider__, the __EditorNeeded__ event will have the __TextInput__ property of the event arguments equal to the key with which enter mode is entered.

## Action on LostFocus

The action that __RadVirtualGrid__ takes when its element loses focus can be manipulated through the __ActionOnLostFocus__ property. It has the following three values.

* __CancelEdit__: Cancels the current edit when the focus of the edited field is lost.

* __CommitEdit__: Commits the current edit when the focus of the edited field is lost.

* __None__: No specific action will be taken when the focus of the edited field is lost.

## See Also

* [Insert and Remove Data]({%slug virtualgrid-insert-data-and-remove-data%})
* [Pinned Rows and Columns]({%slug virtualgrid-pinned-rows-and-columns%})
