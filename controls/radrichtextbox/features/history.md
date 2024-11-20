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

#### __[C#] Disable history__
{{region radrichtextbox-features-history_0}}
	this.radRichTextBox.Document.History.Enabled = false;
{{endregion}}

#### __[VB.NET] Disable history__
{{region radrichtextbox-features-history_1}}
	Me.radRichTextBox.Document.History.Enabled = False
{{endregion}}

## Clear History

To clear the history you just have to call the `Clear` method of the DocumentHistory class.

#### __[C#] Clearing the history__
{{region radrichtextbox-features-history_2}}
	this.radRichTextBox.Document.History.Clear();
{{endregion}}

#### __[VB.NET] Clearing the history__
{{region radrichtextbox-features-history_3}}
	Me.radRichTextBox.Document.History.Clear()
{{endregion}}

## Undo/Redo Actions

To undo and redo some actions, you can call the `Undo` and `Redo` methods of RadRichTextBox.

#### __[C#] Using the Redo and Undo methods of RadRichTextBox__

{{region radrichtextbox-features-history_4}}
	private void UndoAction()
	{
	    this.radRichTextBox.Undo();
	}
	private void RedoAction()
	{
	    this.radRichTextBox.Redo();
	}
{{endregion}}

#### __[VB.NET] Using the Redo and Undo methods of RadRichTextBox__
{{region radrichtextbox-features-history_5}}
	Private Sub UndoAction()
	 Me.radRichTextBox.Undo()
	End Sub
	Private Sub RedoAction()
	 Me.radRichTextBox.Redo()
	End Sub
{{endregion}}

## Change History Depth

To change the history capacity you have to set the desired value of the `Depth` property of the DocumentHistory. The default one is __1000__.

#### __[C#] Changing the history depth__
{{region radrichtextbox-features-history_6}}
	this.radRichTextBox.Document.History.Depth = 500;
{{endregion}}

#### __[VB.NET] Changing the history depth__
{{region radrichtextbox-features-history_7}}
	Me.radRichTextBox.Document.History.Depth = 500
{{endregion}}

## Preserve History Using RadDocumentEditor

RadDocument has API of its own, but using it has a set of limitations. One of those limitations is that the methods of RadDocument are not registered in the undo/redo stack. Thus, once such a method is used, the history stack is cleared and users will no longer be able to undo and redo their previous changes. You can find detailed information on the topic [here]({%slug radrichtextbox-features-raddocumenteditor%}).

## UndoGroup

The `RadDocumentEditor` control allows you to group several methods so that they are added to the Undo/Redo stack as a single item. To do so, you can use the `BeginUndoGroup` and `EndUndoGroup` methods.

#### __[C#] Using the BeginUndoGroup and EndUndoGroup methods__
{{region radrichtextbox-features-history-8}}
	documentEditor.BeginUndoGroup(); 
	
	if (documentEditor.Document.CaretPosition.IsPositionInsideTable) 
	{ 
	    documentEditor.InsertTableRow(); 
	    documentEditor.InsertTableRow(); 
	    documentEditor.InsertTableRow(); 
	    documentEditor.Document.Selection.Clear(); 
	} 
	
	documentEditor.EndUndoGroup("Insert three table rows"); 
{{endregion}}

#### __[VB.NET] Using the BeginUndoGroup and EndUndoGroup methods__
{{region radrichtextbox-features-history-9}}
	documentEditor.BeginUndoGroup() 
	
	If documentEditor.Document.CaretPosition.IsPositionInsideTable Then 
		documentEditor.InsertTableRow() 
		documentEditor.InsertTableRow() 
		documentEditor.InsertTableRow() 
		documentEditor.Document.Selection.Clear() 
	End If 
	
	documentEditor.EndUndoGroup("Insert three table rows") 
{{endregion}}

To cancel the execution of the undo group and prevent it from being recorded to the history, you can use the `CancelUndoGroup` method.

#### __[C#] Using the CancelUndoGroup method__
{{region radrichtextbox-features-history-10}}
	documentEditor.BeginUndoGroup(); 
	
	if (documentEditor.Document.CaretPosition.IsPositionInsideTable) 
	{ 
		documentEditor.InsertTableRow(); 
		documentEditor.InsertTableRow(); 
		documentEditor.InsertTableRow(); 
		documentEditor.Document.Selection.Clear(); 
	} 
	
	documentEditor.CancelUndoGroup(); 
{{endregion}}

#### __[VB.NET] Using the CancelUndoGroup method__
{{region radrichtextbox-features-history-11}}
	documentEditor.BeginUndoGroup() 
	
	If documentEditor.Document.CaretPosition.IsPositionInsideTable Then 
		documentEditor.InsertTableRow() 
		documentEditor.InsertTableRow() 
		documentEditor.InsertTableRow() 
		documentEditor.Document.Selection.Clear() 
	End If 
	
	documentEditor.CancelUndoGroup() 
{{endregion}}

One thing to note here is that it is not possible to remove some actions from the undo history altogether, i.e. you cannot perform an action without it getting registered in the Undo/Redo stack. In most cases, however, this is sufficient, as you can group the operations that you do not want to name and show explicitly to the end user with the ones that have been user-initiated and are expected by the person modifying the content of RadRichTextBox.

## See Also

 * [Selection]({%slug radrichtextbox-features-selection%})
 * [Positioning]({%slug radrichtextbox-features-positioning%})
 * [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%})
