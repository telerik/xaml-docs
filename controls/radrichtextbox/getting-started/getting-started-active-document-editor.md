---
title: Active Document Editor
page_title: Active Document Editor
description: Active Document Editor
slug: radrichtextbox-getting-started-activedocumenteditor
tags: idocumenteditor,activedocumenteditor,activedocumenteditorchanged
published: True
position: 6
---

# Active Document Editor

RadRichTextBox displays the different parts of its content using few different document editors. A document editor is a control that implements the IDocumentEditor interface. For example the RadRichTextBox control.

## Document Editor Types

There are few types of document editors.

* __MainDocument__: This is the RadRichtTextBox control that displays the main document.

* __Header__: This is the document editor that displays a header in the document. When you start editing a header, this type of document editor is activated. Read more about headers and footers in [Headers and Footers help article]({%slug radrichtextbox-features-headers-and-footers%})

* __Footer__: This is the document editor that displays a footer in the document. When you start editing a footer, this type of document editor is activated. 

* __Note__: This is the document editor that displays notes in the document. When you start editing a note, this type of document editor is activated. Read more about notes in the [Footnotes and Endnotes]({%slug radrichtextbox-features-footnotes-endnotes%}) help article.

* __Comment__: This is the document editor that displays a comment in the document. When you start editing a comment, this type of document editor is activated. Read more about comments in the [Comments]({%slug radrichtextbox-features-comments%}) help article.

Currently, all document editors are of type RadRichTextBox. In other words, RadRichTextBox uses child RadRichTextBox controls as IDocumentEditors to edit the different parts of its content.

## Using the Active Document Editor

The active editor can be get via the __ActiveDocumentEditor__ property of RadRichTextBox.

#### __[C#] Example 1: Getting the active document editor__  
{{region radrichtextbox-getting-started-activedocumenteditor-0}} 
	IDocumentEditor activeEditor = radRichTextBox.ActiveDocumentEditor;
{{endregion}}

You can see when the active editor is changed using the __ActiveDocumentEditorChanged__ event. The event arguments contains the editors type which you can get via the args' __DocumentEditorType__ property. This event is useful when you need to modify the active document editor or subscribe for its events.

#### __[C#] Example 2: Using the ActiveDocumentEditorChanged event__  
{{region radrichtextbox-getting-started-activedocumenteditor-1}} 
	private void Rtb_ActiveDocumentEditorChanged(object sender, Telerik.Windows.Documents.UI.ActiveDocumentEditorChangedEventArgs e)
	{
		var richTextBox = (RadRichTextBox)sender;
		if (e.DocumentEditorType == Telerik.Windows.Documents.UI.DocumentEditorType.Header)
		{
			RadRichTextBox activeEditor = (RadRichTextBox)richTextBox.ActiveDocumentEditor;
			activeEditor.CommandExecuting += ActiveEditor_CommandExecuting;
		}
	}
	
	private void ActiveEditor_CommandExecuting(object sender, Telerik.Windows.Documents.RichTextBoxCommands.CommandExecutingEventArgs e)
	{		  
	}
{{endregion}}

## See Also  
* [Getting Started]({%slug radrichtextbox-getting-started%})
* [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%})
* [Developer Focused Examples]({%slug radrichtextbox-sdk-examples%})
