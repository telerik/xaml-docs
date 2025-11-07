---
title: Text Selection
page_title: Text Selection
description: Check our &quot;Text Selection&quot; documentation article for the RadPdfViewer {{ site.framework_name }} control.
slug: radpdfviewer-text-text-selection
tags: text,selection
published: True
position: 5
---

# Text Selection

__RadPdfViewer__ supports selection both through the UI and programmatically.

## Selection through the UI

In order to be able to select text from the UI, __RadPdfViewer__ must be in TextSelection mode. The mode of the viewer is specified by the __Mode__ property, which could be set as show in **Example 1**.

__Example 1: Setting mode to RadPdfViewer__

```C#
	this.pdfViewer.Mode = Telerik.Windows.Documents.Fixed.UI.FixedDocumentViewerMode.TextSelection;
```

>More information on the different modes of the viewer can be found in [this article]({%slug radpdfviewer-viewer-modes%}).	        

## Programmatic Selection

When it comes to programmatic selection, it can occur even if the Mode of RadPdfViewer is not set to Selection.

All methods, properties and events relevant to the discussed functionality are contained in the __TextSelection__ class.        

### Properties

* __StartPosition__: The TextPosition at which the selection starts. More information on TextPositions can be found [here]({%slug radpdfviewer-text-text-position%}).
* __EndPosition__: The TextPosition denoting the end of the selection respectively.
* __IsEmpty__: A boolean property showing if there is selection in the current document.

### Methods

The methods for manipulating the selection include:

- **SetSelectionStart(TextPosition startPosition)**

- **SetSelectionEnd(TextPosition endPosition)**

- **SetSelection(TextPosition startPosition, TextPosition endPosition)**

- **SelectAll()**

- **Clear()**

- **GetSelectedText()**

- **GetSelectedTextAsync(Action&lt;string&gt; callback)**


**Example 2** demonstrates how the functionality of __TextPosition__ can be combined with that of __TextSelection__ in order to select the word that the caret is currently positioned in.

__Example 2: Using TextPosition and TextSelection classes__

```C#
	TextPosition start = new TextPosition(this.pdfViewer.Document.CaretPosition);
	start.MoveToCurrentWordStart();
	TextPosition end = new TextPosition(this.pdfViewer.Document.CaretPosition);
	end.MoveToCurrentWordEnd();
	this.pdfViewer.Document.Selection.SetSelection(start, end);
	MessageBox.Show(this.pdfViewer.Document.Selection.GetSelectedText());
```

>There are no genuine words in PDF, so the viewer uses a greedy text recognition method. That is why it is not guaranteed that it would find the exact start and end position of a word.

### Events

* __SelectionChanging__: Occurs when you start to select part of the text.
* __SelectionChanged__: Occurs when you have finished changing the current selection.

#### **[C#] Example 3: Attaching to SelectionChanged**

```C#
	 this.pdfViewer.Document.Selection.SelectionChanged += Selection_SelectionChanged;
```

## See Also  
* [Text Position]({%slug radpdfviewer-text-text-position%})
