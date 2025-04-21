---
title: Keyboard support 
page_title:  Keyboard support 
description:  Keyboard support. 
slug: radspreadsheet-keyboard-support
tags: customize, keyboard, shortcuts
published: True
position: 10
---

# Keyboard Support

By default, __RadSpreadSheet__ supports keyboard shortcuts that allow you to perform various operations without touching the mouse. The bellow tables list all supported shortcuts.

## List of keys handled by RadSpreadSheet

### Navigation

|__Key__|__Action__|
|---|---|
|Left|Move to previous column|
|Right|Move to next column|
|Up|Move to previous row|
|Down|Move to next row|
|Home|Move to Row start|
|End|Move to row end|
|Tab|Move to next column|
|Shift + Tab|Move to previous columns|
|Enter|Move to next row|
|Shift + Enter|Move to previous row|
|Ctrl + PageDown|Switch sheets to right|
|Ctrl + PageUp|Switch sheets to left|
|Ctrl + Space|Select all cells|
|Shift + Space|Select the entire row|
|Ctrl + Shift + * | Select the current region |
|PageDown|Move one screen down|
|PageUp|Move one screen up|
|Shift + PageDown|Move one screen down and select from current cell|
|Shift + PageUp|Move one screen up and select from current cell|
|Ctrl + A|Select All|
|Ctrl + Shift + Space|Select All|
|Ctrl + Shift + Home|Selects from current to the first cell|
|Alt + PageDown|Move one screen to the right|
|Alt + Shift + PageDown|Move one screen to the right|
|Alt + PageUp|Move one screen to the left|
|Alt + Shift + PageUp|Move one screen to the left|
|Ctrl + End|Moves to used cell range end|

### Document

|__Key Combination__|__Action__|
|---|---|
|Ctrl + N|New document|
|Ctrl + O|Open file|
|Ctrl + S|Save current document|
|F12|Save file|
|Shift + F11|Inserts new sheet|
|Ctrl + F11|Inserts new sheet|
|F11|Inserts new sheet|
|Ctrl + Z|Undo|
|Ctrl + Y|Redo|
|Ctrl + K|Show hyperlink dialog|
|Ctrl + D|Fill Down (Copies the contents of the previous cell)   |
|Delete|Clears the contents of the cell|
|Back|Clears the contents of the cell|
|Ctrl + "-"|Remove the selected cells|
|Ctrl + "+"|Insert new cells depending on the selection|
|Ctrl + B|Toggle Bold|
|Ctrl + I|Toggle Italic|
|Ctrl + U|Toggle Underline|
|F2|Activate edit mode|
|Ctrl + Alt + P|Print|
|Ctrl + F|Open the Find dialog|
|Ctrl + H|Open the Replace Dialog|
|Ctrl + X|Cut|
|Ctrl + C|Copy|
|Ctrl + V|Paste|
|Ctrl + Insert|Copy|
|Shift + Insert|Paste|

## Customize Keyboard Shortcuts

The above shortcuts can be customized. To change a shortcut you need to register it using the __RegisterCommand__ method. For example you can change the behavior of the Enter key and make it go to next column instead of the next row. If the ActiveWorksheetEditor is changed you will need to register the command again. This is why it would be better to use the __ActiveSheetEditorChanged__ event for this.

#### __C# Example 1: Change the behavior of the Enter key__
{{region radspreadsheet-keyboard-support_0}}

    private void RadSpreadsheet_ActiveSheetEditorChanged(object sender, EventArgs e)
    {
        RadWorksheetEditor worksheetEditor = this.radSpreadsheet.ActiveWorksheetEditor;

        if (this.radSpreadsheet.ActiveWorksheetEditor != null)
        {
            worksheetEditor.KeyBindings.RegisterCommand(worksheetEditor.Commands.UpdateActiveSelectionRangeCommand, Key.Enter, ModifierKeys.None, MovementType.MoveToNextColumn);
        }
    }
   
{{endregion}}

Please note that the above code will override the default enter command. 

## Registering a Custom Command

It is possible to register a shortcut that executes a custom command. All you need to do is pass the command when registering the shortcut. 

#### __C# Example 2: Associate a custom command with a shortcut__

{{region radspreadsheet-keyboard-support_1}}

    private void RadSpreadsheet_ActiveSheetEditorChanged(object sender, EventArgs e)
    {   
        RadWorksheetEditor worksheetEditor = this.radSpreadsheet.ActiveWorksheetEditor;
        if (worksheetEditor != null)
        {
            ICommand customPasteCommand = new DelegateCommand((parameter) =>
                {
                    MessageBox.Show("Custom paste command is executed!");
                });
            worksheetEditor.KeyBindings.RegisterCommand(customPasteCommand, Key.V, ModifierKeys.Control, PasteType.Values);
        }
    }

{{endregion}}

## Disable a Command

To disable a specific shortcut you can register the same key combination and pass an empty command.

#### __C# Example 3: Disable a specific command__

{{region radspreadsheet-keyboard-support_2}}

    private void RadSpreadsheet_ActiveSheetEditorChanged(object sender, EventArgs e)
    {   
        RadWorksheetEditor worksheetEditor = this.radSpreadsheet.ActiveWorksheetEditor;
        if (worksheetEditor != null)
        {           
            worksheetEditor.KeyBindings.RegisterCommand(new DelegateCommand((p) => { }), Key.V, ModifierKeys.Control, PasteType.Values);
        }
    }

{{endregion}}

