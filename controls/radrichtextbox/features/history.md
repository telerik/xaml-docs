---
title: History
page_title: History
description: History
slug: radrichtextbox-features-history
tags: history
published: True
position: 3
---

# History



The __RadDocument__ class can track the history of any actions taken against its content. In this way it allows an undo and redo functionality to be easily implemented. The history is implemented via the __DocumentHistory__ class and the __RadDocument__ exposes the __History__ property of this type. The __RadRichTextBox__ automatically adds and removes items from the history, when its API methods get called, but you are allowed to manually work with the history as well.
      

>tipTo learn more about the __DocumentHistory API__ read {% if site.site_name == 'Silverlight' %}[here](http://www.telerik.com/help/silverlight/allmembers_t_telerik_windows_documents_history_documenthistory.html){% endif %}{% if site.site_name == 'WPF' %}[here](http://www.telerik.com/help/wpf/allmembers_t_telerik_windows_documents_history_documenthistory.html){% endif %}
          .
        

This topic will explain you how to:

* [Enable/Disable History](#enable/disable-history)

* [Clear History](#clear-history)

* [Undo/Redo Actions](#undo/redo-actions)

* [Change History Depth](#change-history-depth)

* [Preserv History Using RadDocumentEditor](#preserve-history-using-raddocumenteditor)

## Enable/Disable History

You can enable or disable the history for the __RadDocument__ via the __Enabled__ property of the __DocumentHistory__.
        

#### __C#__

{{region radrichtextbox-features-history_0}}
	this.radRichTextBox.Document.History.Enabled = false;
{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-history_1}}
	Me.radRichTextBox.Document.History.Enabled = False
{{endregion}}



## Clear History

To clear the history you just have to call the __Clear()__ method of the __DocumentHistory__ class.
        

#### __C#__

{{region radrichtextbox-features-history_2}}
	this.radRichTextBox.Document.History.Clear();
{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-history_3}}
	Me.radRichTextBox.Document.History.Clear()
{{endregion}}



## Undo/Redo Actions

To undo and redo some actions, you can call the __Undo()__ and __Redo()__ methods of the __RadRichTextBox__.
        

#### __C#__

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



#### __VB.NET__

{{region radrichtextbox-features-history_5}}
	Private Sub UndoAction()
	 Me.radRichTextBox.Undo()
	End Sub
	Private Sub RedoAction()
	 Me.radRichTextBox.Redo()
	End Sub
{{endregion}}



## Change History Depth

To change the history capacity you have to set the desired value of the __Depth__ property of the __DocumentHistory__. The default one is __1000__.
        

#### __C#__

{{region radrichtextbox-features-history_6}}
	this.radRichTextBox.Document.History.Depth = 500;
{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-history_7}}
	Me.radRichTextBox.Document.History.Depth = 500
{{endregion}}



## Preserve History Using RadDocumentEditor

RadDocument has API of its own, but using it has a set of limitations. One of those limitations is that the methods of RadDocument are not registered in the undo/redo stack. Thus, once such a method is used, the history stack is cleared and users will no longer be able to undo and redo their previous changes. You can find detailed information on the topic [here]({%slug radrichtextbox-features-raddocumenteditor%}).
        

# See Also

 * [Working with RadRichTextBox]({%slug radrichtextbox-features-working-with-radrichtextbox%})

 * [Selection]({%slug radrichtextbox-features-selection%})

 * [Positioning]({%slug radrichtextbox-features-positioning%})

 * [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%})
