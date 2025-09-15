---
title: Active Document Editor
page_title: Active Document Editor
description: Check our &quot;Active Document Editor&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-getting-started-activedocumenteditor
tags: idocumenteditor,activedocumenteditor,activedocumenteditorchanged
published: True
position: 6
---

# Active Document Editor

RadRichTextBox displays the different parts of its content using few different document editors. A document editor is a control that implements the [IDocumentEditor](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.model.idocumenteditor) interface. For example the RadRichTextBox control.

* [Document Editor Types](#document-editor-types)
* [Using the Active Document Editor](#using-the-active-document-editor)

## Document Editor Types

There are few types of document editors.

* __MainDocument__: This is the RadRichtTextBox control that displays the main document.

* __Header__: This is the document editor that displays a header in the document. When you start editing a header, this type of document editor is activated. Read more about headers and footers in [Headers and Footers help article]({%slug radrichtextbox-features-headers-and-footers%})

* __Footer__: This is the document editor that displays a footer in the document. When you start editing a footer, this type of document editor is activated. 

* __Note__: This is the document editor that displays notes in the document. When you start editing a note, this type of document editor is activated. Read more about notes in the [Footnotes and Endnotes]({%slug radrichtextbox-features-footnotes-endnotes%}) help article.

* __Comment__: This is the document editor that displays a comment in the document. When you start editing a comment, this type of document editor is activated. Read more about comments in the [Comments]({%slug radrichtextbox-features-comments%}) help article.

## Using the Active Document Editor

You can get the active editor via the __ActiveDocumentEditor__ property of RadRichTextBox.

__Example 1: Getting the active document editor__  
```C# 
	IDocumentEditor activeEditor = radRichTextBox.ActiveDocumentEditor;
```

You can see when the active editor is changed using the __ActiveDocumentEditorChanged__ event. The event arguments contain the editor's type which you can get via the args' __DocumentEditorType__ property. This event is useful when you need to modify the active document editor or subscribe for its events.

__Example 2: Using the ActiveDocumentEditorChanged event__  
```C# 
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
```

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF RichTextBox Component](https://www.telerik.com/products/wpf/richtextbox.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also  
* [Getting Started]({%slug radrichtextbox-getting-started%})
* [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%})
* [Developer Focused Examples]({%slug radrichtextbox-sdk-examples%})
