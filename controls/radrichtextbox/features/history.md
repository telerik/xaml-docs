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

* [Enable/Disable History](#enable-disable-history)
* [Clear History](#clear-history)
* [Undo/Redo Actions](#undo-redo-actions)
* [Change History Depth](#change-history-depth)
* [Preserve History Using RadDocumentEditor](#preserve-history-using-raddocumenteditor)
* [UndoGroup](#undogroup)

## Enable/Disable History

You can enable or disable the history for the RadDocument via the `Enabled` property of the DocumentHistory.

__Disable history__
<snippet id='radrichtextbox-features-history-block_1-cs' />
<snippet id='radrichtextbox-features-history-block_2-vb' />

## Clear History

To clear the history you just have to call the `Clear` method of the DocumentHistory class.

__Clearing the history__
<snippet id='radrichtextbox-features-history-block_3-cs' />
<snippet id='radrichtextbox-features-history-block_4-vb' />

## Undo/Redo Actions

To undo and redo some actions, you can call the `Undo` and `Redo` methods of RadRichTextBox.

__Using the Redo and Undo methods of RadRichTextBox__

<snippet id='radrichtextbox-features-history-block_5-cs' />
<snippet id='radrichtextbox-features-history-block_6-vb' />

## Change History Depth

To change the history capacity you have to set the desired value of the `Depth` property of the DocumentHistory. The default one is __1000__.

__Changing the history depth__
<snippet id='radrichtextbox-features-history-block_7-cs' />
<snippet id='radrichtextbox-features-history-block_8-vb' />

## Preserve History Using RadDocumentEditor

The methods of the RadDocument class do not register in the undo/redo stack. Once a method is invoked, the history stack will be cleared and the users will no longer be able to undo/redo previous actions. Due to this and for some other factors, the RadDocumentEditor class was introduced. You can find detailed information about it [here]({%slug radrichtextbox-getting-started%}#raddocumenteditor).

## UndoGroup

The `RadDocumentEditor` control allows you to group several methods so that they are added to the Undo/Redo stack as a single item. To do so, you can use the `BeginUndoGroup` and `EndUndoGroup` methods.

__Using the BeginUndoGroup and EndUndoGroup methods__
<snippet id='radrichtextbox-features-history-block_9-cs' />
<snippet id='radrichtextbox-features-history-block_10-vb' />

To cancel the execution of the undo group and prevent it from being recorded to the history, you can use the `CancelUndoGroup` method.

__Using the CancelUndoGroup method__
<snippet id='radrichtextbox-features-history-block_11-cs' />
<snippet id='radrichtextbox-features-history-block_12-vb' />

One thing to note here is that it is not possible to remove some actions from the undo history altogether, i.e. you cannot perform an action without it getting registered in the Undo/Redo stack. In most cases, however, this is sufficient, as you can group the operations that you do not want to name and show explicitly to the end user with the ones that have been user-initiated and are expected by the person modifying the content of RadRichTextBox.

## See Also

 * [Selection]({%slug radrichtextbox-features-selection%})
 * [Positioning]({%slug radrichtextbox-features-positioning%})