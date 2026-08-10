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

> By default, the __CanUserEdit__ property of __RadVirtualGrid__ is set to __True__, thus the editing mechanism is enabled. In order to disable it, set its value to __False__.

__RadVirtualGrid__ uses one of two editing paths:

* Without a __DataProvider__, handle __CellValueNeeded__, __EditorNeeded__, __EditorValueChanged__, and __CellEditEnded__ yourself. The control does not persist edited values in your data source automatically.

* With a __DataProvider__, the provider creates the default editor, supplies cell values, determines whether a column is read-only, and handles the edit lifecycle. The default __DataProvider__ automatically writes committed values to its source and updates the grid.

The editor lifecycle is:

1. The user enters edit mode through an edit trigger or a call to __BeginEdit__.
2. __EditorNeeded__ is raised. Create an editor, assign it to __Editor__, and assign the editor dependency property to __EditorProperty__.
3. The editor changes its dependency property. __EditorValueChanged__ receives the current value.
4. The edit ends through __CommitEdit__, __CancelEdit__, or the configured __ActionOnLostFocus__ behavior. __CellEditEnded__ receives the final value and an __EditAction__.
5. For a committed edit, persist the value and call __PushCellValue__ when you manage the data source directly. A __DataProvider__ does this automatically when __ShouldPushEditValueToGrid__ is __True__.

* [Editing paths](#editing-paths)

* [Events](#events)

* [Methods](#methods)

* [Edit Triggers](#edittriggers)

* [Action on LostFocus](#action-on-lostfocus)

## Editing paths

### Direct event handling

Use direct event handling when you populate the grid through __InitialRowCount__ and __InitialColumnCount__ and keep the data outside a __DataProvider__. Handle __CellValueNeeded__ to display values, create the editor in __EditorNeeded__, and persist the value in __CellEditEnded__.

The following example uses a __TextBox__ for every editable cell. Replace the `SaveValue` implementation with the code that updates your data source.

```C#
using System.Windows.Controls;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.VirtualGrid;

private void VirtualGrid_CellValueNeeded(object sender, CellValueEventArgs e)
{
    e.Value = this.GetValue(e.RowIndex, e.ColumnIndex);
}

private void VirtualGrid_EditorNeeded(object sender, EditorNeededEventArgs e)
{
    var editor = new TextBox
    {
        Text = e.TextInput ?? this.GetValue(e.RowIndex, e.ColumnIndex)?.ToString()
    };

    e.Editor = editor;
    e.EditorProperty = TextBox.TextProperty;
}

private void VirtualGrid_CellEditEnded(object sender, CellEditEndedEventArgs e)
{
    if (e.EditAction != VirtualGridEditAction.Commit)
    {
        return;
    }

    this.SaveValue(e.RowIndex, e.ColumnIndex, e.Value);
    this.VirtualGrid.PushCellValue(e.RowIndex, e.ColumnIndex, e.Value);
}
```

The __PushCellValue__ call updates the value that __RadVirtualGrid__ renders. It does not replace persistence in the underlying data source, so call both operations after a committed edit.

### DataProvider editing

Use a __DataProvider__ when the grid should read and write values through an item collection. The default provider creates a __TextBox__ editor, uses item properties to determine the editor value, and treats read-only item properties as non-editable.

The provider's __ShouldPushEditValueToGrid__ property returns __True__ by default. On a committed edit, __RadVirtualGrid__ calls __PushCellValueToSource__ and __PushCellValue__. Override this property when your provider owns synchronization and must handle the source and grid update itself.

The provider also receives __OnCellValueNeeded__, __OnEditorNeeded__, __OnEditorValueChanged__, and __OnCellEditEnded__ calls. When a __DataProvider__ is assigned, the corresponding public editing events are not raised by __RadVirtualGrid__; override the provider methods instead.

```C#
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Controls.VirtualGrid;

public class ProductDataProvider : DataProvider
{
    public ProductDataProvider(IEnumerable source)
        : base(source)
    {
    }

    protected override void CreateEditor(out FrameworkElement editor, out DependencyProperty editorProperty, object propertyValue, int columnIndex)
    {
        editor = new TextBox
        {
            Text = propertyValue?.ToString()
        };
        editorProperty = TextBox.TextProperty;
    }

    protected internal override void OnCellEditEnded(CellEditEndedEventArgs e)
    {
        if (e.EditAction == VirtualGridEditAction.Commit)
        {
            // Persist here only when the provider owns custom conversion or storage.
        }
    }
}
```

If the custom provider does not override __ShouldPushEditValueToGrid__, the base provider still converts the value to the item property type, writes it through the property descriptor, and refreshes the grid after a commit. Do not persist a cancelled value: __CellEditEndedEventArgs.EditAction__ is __Cancel__ when the edit is cancelled.

## Events

>important The public editing events are not raised when the __DataProvider__ mechanism is used for populating the data of __RadVirtualGrid__. Override the corresponding __DataProvider__ methods instead. More information can be found in the [Custom DataProvider]({%slug virtualgrid-custom-dataprovider%}) topic.

### EditorNeeded

Through this event a custom editor for handling the editing operation can be defined. The event arguments expose the following properties:

* __ColumnIndex__: Provides information regarding the column index of the editor

* __RowIndex__: Provides information regarding the row index of the editor

* __Editor__: The control that will be used for the editing operation

* __EditorProperty__: The editor's dependency property that is to be edited

* __TextInput__: Gets the string containing the entered text when the __TextInput__ edit trigger starts an edit. Use this value when you want the first typed character to replace the original cell value.

> The property of the editor that is being edited needs to be set manually as well.

__Example 1: Handling the EditorNeeded event__  
```C#
	private void VirtualGrid_EditorNeeded(object sender, 
            Telerik.Windows.Controls.VirtualGrid.EditorNeededEventArgs e)
        {
            TextBox tb = new TextBox();

            e.Editor = tb;
            tb.Text = e.TextInput;
            e.EditorProperty = TextBox.TextProperty;
        }
```

> Most input controls (MaskedTextInput, RadNumericUpDown, RadComboBox, etc.) in the Material, Fluent and Transparent themes have an opacity applied. This means that you can see through them which could lead to a visual glitch when used as editors in RadVirtualGrid. To avoid this set the Background property of the editor to a solid color when you create it in the event handler.

### EditorValueChanged

This event is triggered each time the editor dependency property changes. With a __DataProvider__, override __DataProvider.OnEditorValueChanged__ instead of handling this public event.

* __ColumnIndex__: Provides information regarding the column index of the editor

* __RowIndex__: Provides information regarding the row index of the editor

* __Value__: Provides the current editor value.

__Example 2: Handling the EditorValueChanged event__  
```C#
	private void VirtualGrid_EditorValueChanged(object sender, 
			Telerik.Windows.Controls.VirtualGrid.CellValueEventArgs e)
        {
            
        }
```

### CellEditEnded

The event is raised when the edit ends. The event can result from __CommitEdit__, __CancelEdit__, or __ActionOnLostFocus__. With a __DataProvider__, override __DataProvider.OnCellEditEnded__ instead of handling this public event.

* __ColumnIndex__: Provides information regarding the column index of the editor

* __RowIndex__: Provides information regarding the row index of the editor

* __Value__: Provides the current or final editor value.

* __EditAction__: Indicates whether the edit was committed through __VirtualGridEditAction.Commit__ or cancelled through __VirtualGridEditAction.Cancel__.

__Example 3: Handling the CellEditEnded event__  
```C#
	   private void VirtualGrid_CellEditEnded_1(object sender, CellEditEndedEventArgs e)
        {
            if (e.EditAction == VirtualGridEditAction.Commit)
            {
                this.SaveValue(e.RowIndex, e.ColumnIndex, e.Value);
                this.VirtualGrid.PushCellValue(e.RowIndex, e.ColumnIndex, e.Value);
            }
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

When an edit is committed through direct event handling, persist the new value in the underlying source and call __PushCellValue__ to update __RadVirtualGrid__. The method only updates the value rendered by the control; it does not write to your source. A __DataProvider__ calls the source and grid update methods automatically when __ShouldPushEditValueToGrid__ is __True__.

* __PushCellValue(int rowIndex, int columnIndex, object value)__

__Example 4: Updating RadVirtualGrid with the modified data__  	
```C#
	private void VirtualGrid_CellEditEnded(object sender, 
            Telerik.Windows.Controls.VirtualGrid.CellEditEndedEventArgs e)
        {
            if (e.EditAction == VirtualGridEditAction.Commit)
            {
                this.SaveValue(e.RowIndex, e.ColumnIndex, e.Value);
                this.VirtualGrid.PushCellValue(e.RowIndex, e.ColumnIndex, e.Value);
            }
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
