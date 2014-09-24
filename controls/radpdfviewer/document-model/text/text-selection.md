---
title: Text Selection
page_title: Text Selection
description: Text Selection
slug: radpdfviewer-text-text-selection
tags: text,selection
published: True
position: 2
---

# Text Selection



__RadPdfViewer__ supports selection both through the UI and programmatically.

## Selection through the UI

In order to be able to select text from the UI, __RadPdfViewer__ must be in TextSelection mode. The mode of the viewer is specified by the
        __Mode__ property, which could be set as follows:

#### __C#__

{{region radpdfviewer-text-text-selection_0}}
	this.pdfViewer.Mode = Telerik.Windows.Documents.Fixed.UI.FixedDocumentViewerMode.TextSelection;
	{{endregion}}



>More information on the different modes of the viewer can be found in
	   			[this article]({%slug radpdfviewer-viewer-modes%}).
	        

## Programmatic Selection

When it comes to programmatic selection, it can occur even if the Mode of RadPdfViewer is not Selection.

All methods, properties and events relevant to the discussed functionality are contained in the __TextSelection__ class.
        

* Properties:

* __StartPosition__ - the TextPosition at which the selection starts. More information on TextPositions can be found
        			[here]({%slug radpdfviewer-viewer-modes%}).
        		

* __EndPosition__ - the TextPosition denoting the end of the selection respectively.

* __IsEmpty__ - a boolean property showing if there is selection in the current document.

* Methods:The methods for manipulating the selection include:

#### __C#__

{{region radpdfviewer-text-text-selection_1}}
	public void SetSelectionStart(TextPosition startPosition)
	public void SetSelectionEnd(TextPosition endPosition)
	public void SetSelection(TextPosition startPosition, TextPosition endPosition)
	
	public void SelectAll()
	public void Clear()
	
	public string GetSelectedText()
	public void GetSelectedTextAsync(Action<string> callback)
	{{endregion}}

Their names show clearly the action they execute.Here is an example showing how the functionality of __TextPositions__ can be combined with that of __TextSelection__
        	in order to select the word that the caret is currently positioned in:

#### __C#__

{{region radpdfviewer-text-text-selection_2}}
	TextPosition start = new TextPosition(this.pdfViewer.Document.CaretPosition);
	start.MoveToCurrentWordStart();
	TextPosition end = new TextPosition(this.pdfViewer.Document.CaretPosition);
	end.MoveToCurrentWordEnd();
	this.pdfViewer.Document.Selection.SetSelection(start, end);
	MessageBox.Show(this.pdfViewer.Document.Selection.GetSelectedText());
	{{endregion}}



>There are no genuine words in PDF, so the viewer uses a greedy text recognition method. That is why it is not guaranteed that it
        		would find the exact start and end position of a word.

* Events:

* __SelectionChanging__ - occurs when you start to select part of the text.

* __SelectionChanged__ - occurs when you have finished changing the current selection.

# See Also

 * [Text Position]({%slug radpdfviewer-text-text-position%})
