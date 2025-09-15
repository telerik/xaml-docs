---
title: History
page_title: History
description: Check our &quot;History&quot; documentation article for the RadRichTextBox control.
slug: radrichtextbox-features-history
tags: history
published: True
---

# History

The `RadDocument` class can track the history of any actions taken against its content. In this way it allows an undo and redo functionality to be easily implemented. The history is implemented via the `DocumentHistory` class and the RadDocument exposes the `History` property of this type. The `RadRichTextBox` control automatically adds and removes items from the history, when its API methods get called, but you are allowed to manually work with the history as well.

>tip To learn more about the DocumentHistory API, read [here](http://www.telerik.com/help/wpf/t_telerik_windows_documents_history_documenthistory.html).

This topic will explain you how to:

* [Enable/Disable History](#enabledisable-history)
* [Clear History](#clear-history)
* [Undo/Redo Actions](#undoredo-actions)
* [Change History Depth](#change-history-depth)
* [Preserve History Using RadDocumentEditor](#preserve-history-using-raddocumenteditor)
* [UndoGroup](#undogroup)

## Enable/Disable History

You can enable or disable the history for the RadDocument via the `Enabled` property of the DocumentHistory.

__Disable history__
```C#
	this.radRichTextBox.Document.History.Enabled = false;
```
```VB.NET
	Me.radRichTextBox.Document.History.Enabled = False
```

## Clear History

To clear the history you just have to call the `Clear` method of the DocumentHistory class.

__Clearing the history__
```C#
	this.radRichTextBox.Document.History.Clear();
```
```VB.NET
	Me.radRichTextBox.Document.History.Clear()
```

## Undo/Redo Actions

To undo and redo some actions, you can call the `Undo` and `Redo` methods of RadRichTextBox.

__Using the Redo and Undo methods of RadRichTextBox__

```C#
	private void UndoAction()
	{
	    this.radRichTextBox.Undo();
	}
	private void RedoAction()
	{
	    this.radRichTextBox.Redo();
	}
```
```VB.NET
	Private Sub UndoAction()
	 Me.radRichTextBox.Undo()
	End Sub
	Private Sub RedoAction()
	 Me.radRichTextBox.Redo()
	End Sub
```

## Change History Depth

To change the history capacity you have to set the desired value of the `Depth` property of the DocumentHistory. The default one is __1000__.

__Changing the history depth__
```C#
	this.radRichTextBox.Document.History.Depth = 500;
```
```VB.NET
	Me.radRichTextBox.Document.History.Depth = 500
```

## Preserve History Using RadDocumentEditor

The methods of the RadDocument class do not register in the undo/redo stack. Once a method is invoked, the history stack will be cleared and the users will no longer be able to undo/redo previous actions. Due to this and for some other factors, the RadDocumentEditor class was introduced. You can find detailed information about it [here]({%slug radrichtextbox-getting-started%}#raddocumenteditor).

## UndoGroup

The `RadDocumentEditor` control allows you to group several methods so that they are added to the Undo/Redo stack as a single item. To do so, you can use the `BeginUndoGroup` and `EndUndoGroup` methods.

__Using the BeginUndoGroup and EndUndoGroup methods__
```C#
	documentEditor.BeginUndoGroup(); 
	
	if (documentEditor.Document.CaretPosition.IsPositionInsideTable) 
	{ 
	    documentEditor.InsertTableRow(); 
	    documentEditor.InsertTableRow(); 
	    documentEditor.InsertTableRow(); 
	    documentEditor.Document.Selection.Clear(); 
	} 
	
	documentEditor.EndUndoGroup("Insert three table rows"); 
```
```VB.NET
	documentEditor.BeginUndoGroup() 
	
	If documentEditor.Document.CaretPosition.IsPositionInsideTable Then 
		documentEditor.InsertTableRow() 
		documentEditor.InsertTableRow() 
		documentEditor.InsertTableRow() 
		documentEditor.Document.Selection.Clear() 
	End If 
	
	documentEditor.EndUndoGroup("Insert three table rows") 
```

To cancel the execution of the undo group and prevent it from being recorded to the history, you can use the `CancelUndoGroup` method.

__Using the CancelUndoGroup method__
```C#
	documentEditor.BeginUndoGroup(); 
	
	if (documentEditor.Document.CaretPosition.IsPositionInsideTable) 
	{ 
		documentEditor.InsertTableRow(); 
		documentEditor.InsertTableRow(); 
		documentEditor.InsertTableRow(); 
		documentEditor.Document.Selection.Clear(); 
	} 
	
	documentEditor.CancelUndoGroup(); 
```
```VB.NET
	documentEditor.BeginUndoGroup() 
	
	If documentEditor.Document.CaretPosition.IsPositionInsideTable Then 
		documentEditor.InsertTableRow() 
		documentEditor.InsertTableRow() 
		documentEditor.InsertTableRow() 
		documentEditor.Document.Selection.Clear() 
	End If 
	
	documentEditor.CancelUndoGroup() 
```

One thing to note here is that it is not possible to remove some actions from the undo history altogether, i.e. you cannot perform an action without it getting registered in the Undo/Redo stack. In most cases, however, this is sufficient, as you can group the operations that you do not want to name and show explicitly to the end user with the ones that have been user-initiated and are expected by the person modifying the content of RadRichTextBox.

## See Also

 * [Selection]({%slug radrichtextbox-features-selection%})
 * [Positioning]({%slug radrichtextbox-features-positioning%})