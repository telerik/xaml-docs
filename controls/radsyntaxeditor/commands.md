---
title: Commands
page_title: Commands
description: This article lists and explains the commands exposed by the RadSyntaxEditor control.
slug: radsyntaxeditor-commands
tags: commands,radsyntaxeditor
position: 5
---

# Commands

`RadSyntaxEditor` exposes its functionality through various commands that can be executed on its behalf. All commands can be accessed through the `Commands` property of the control. Here's a full list of the available commands:

* `OpenFindDialogCommand`&mdash;Opens the find dialog. If there is any selected text, it is loaded in the search textbox.
* `CloseFindDialogCommand`&mdash;Closes the find dialog.
* `NavigateNextMatchCommand`&mdash;Navigates to the next matched text in the editor and selects it. If the match is contained in a folded region, it is unfolded. Takes as a parameter the search text.
* `NavigatePreviousMatchCommand`&mdash;Navigates to the previous matched text in the editor and selects it. If the match is contained in a folded region, it is unfolded. Takes as a parameter the search text.
* `HighlightAllMatchesCommand`&mdash;Tries to highlight all span matches via all registered `TextSearchHighlightTaggers`. Takes as a parameter the search text.
* `CodeCompletionCommand`&mdash;Shows the IntelliSense code completion dialog.
* `CutCommand`&mdash;Cuts the selected text or the current line if there is no selection.
* `CopyCommand`&mdash;Copies the selected text or the current line if there is no selection.
* `PasteCommand`&mdash;Pastes over the selected text or at the caret's position if there is no selection.
* `BackspaceCommand`&mdash;Deletes the selected text or the last character before the caret if there is no selection.
* `DeleteCommand`&mdash;Deletes the selected text or the first character after the caret if there is no selection.
* `DeleteFullLineCommand`&mdash;Deletes the full line on which the cursor currently is.
* `DeleteWordToLeftCommand`&mdash;Deletes the word to the left of the cursor.
* `DeleteWordToRightCommand`&mdash;Deletes the word to the right of the cursor.
* `IndentCommand`&mdash;Indents the selected text or the current line if there is no selection.
* `UnindentCommand`&mdash;Unindents the selected text or the current line if there is no selection.
* `MoveCaretCommand`&mdash;Moves the caret depending on the `CaretMovementType` parameter which is passed.
* `RedoCommand`&mdash;Redoes the last undo action.
* `UndoCommand`&mdash;Undoes the last action.
* `SelectAllCommand`&mdash;Selects all the text.
* `ToggleInsertModeCommand`&mdash;Toggles the insert mode.

The following example demonstrates how to select and delete the first occurrence of the "Telerik" word from the loaded text in code-behind and in XAML:

__Use commands in code-behind__
```C#
    this.syntaxEditor.Commands.NavigateNextMatchCommand.Execute("Telerik");
    this.syntaxEditor.Commands.DeleteCommand.Execute(null);
```

__Use commands in XAML__
```XAML
    <telerik:RadSyntaxEditor x:Name="syntaxEditor" />
    <telerik:RadButton Content="Select Next Match" Command="{Binding Commands.NavigateNextMatchCommand, ElementName=syntaxEditor}" CommandParameter="Telerik" />
    <telerik:RadButton Content="Delete" Command="{Binding Commands.DeleteCommand, ElementName=syntaxEditor}" />
```

## Managing Commands

RadSyntaxEditor allows you to register and unregister its commands. To do so, you can utilize the `RegisterCommand` and `UnregisterCommand` methods of the `KeyBindings` property of the RadSyntaxEditor control.

The following examples show how to register and unregister the `CodeCompletionCommand`:

__Register a command__
```C#
    SyntaxEditorDelegateCommand codeCompletionCommand = (SyntaxEditorDelegateCommand)this.syntaxEditor.Commands.CodeCompletionCommand;
    this.syntaxEditor.KeyBindings.RegisterCommand(codeCompletionCommand, Key.Enter, ModifierKeys.Control);
```
```VB.NET
    Dim codeCompletionCommand As SyntaxEditorDelegateCommand = CType(Me.syntaxEditor.Commands.CodeCompletionCommand, SyntaxEditorDelegateCommand)
    Me.syntaxEditor.KeyBindings.RegisterCommand(codeCompletionCommand, Key.Enter, ModifierKeys.Control)
```

__Unregister a command__
```C#
    SyntaxEditorDelegateCommand codeCompletionCommand = (SyntaxEditorDelegateCommand)this.syntaxEditor.Commands.CodeCompletionCommand;
    this.syntaxEditor.KeyBindings.UnregisterCommand(codeCompletionCommand);
```
```VB.NET
    Dim codeCompletionCommand As SyntaxEditorDelegateCommand = CType(Me.syntaxEditor.Commands.CodeCompletionCommand, SyntaxEditorDelegateCommand)
    Me.syntaxEditor.KeyBindings.UnregisterCommand(codeCompletionCommand)
```

>important Registering and unregistering commands would require the RadSyntaxEditor control to be loaded. You can utilize the RegisterCommand and UnregisterCommand methods in the `Loaded` event of the control.

## See Also

* [Events]({%slug radsyntaxeditor-events%})