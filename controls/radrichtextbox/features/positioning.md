---
title: Positioning
page_title: Positioning
description: Positioning
slug: radrichtextbox-features-positioning
tags: positioning
published: True
---

# Positioning

The positioning feature in __RadRichTextBox__ is used to navigate through document's content and to get information about the document's elements at a specific position. The __RadDocument__ uses the positioning to track the movement of the caret and to control the selection.


## Overview

The positioning is implemented via the __DocumentPosition__ class. This class can be used by the developer to programmatically control the positioning or the selection. __DocumentPosition__ offers methods, such as __MoveToNextWordStart()__, __MoveToPreviousWordStart()__, __MoveToCurrentLineStart/End()__ and so on, which will navigate to the given document element. In order to get information about the element at a given position, you can use several methods such as __GetCurrentSpanBox()__, __GetCurrentParagraphBox()__, __GetCurrentSectionBox()__ and so on which will return the LayoutBox of an element. Another option is to use directly the methods returning the specific document element - __GetCurrentSpan()__, __GetCurrentParagraph()__, __GetCurrentTable()__ etc.

__DocumentPosition__ also redefines equality and comparison operators for more convenience, when you should find whether the __DocumentPosition__ is before or after another position in the natural flow of the document. By default, __RadRichTextBox__ moves __Document.CaretPosition__ using arrow keys or on mouse click. __DocumentPosition__ can also be obtained by giving the coordinates of a point in the document using the method __DocumentPosition.SetPosition()__.

You can manage the caret position for a specific __RadDocument__ by either accessing its __CaretPosition__ property, which is of type __DocumentPosition__, or by creating a new instance of the __DocumentPosition__ class and associating it with the desired __RadDocument__.

>When using the __CaretPosition__ property you are directly managing the caret position in the __RadDocument__. By using the __DocumentPosition__ class, you can create instances of several positions inside the document without changing the current caret position.

## CaretPosition property

This property enables you to manage the position of the caret inside the document and to obtain information about its location and the elements it currently resides at. Here is an example of how to use the __CaretPosition__ property to get the current word.

#### __[C#] Example 1: Getting the word on the caret position__  
{{region radrichtextbox-features-positioning_0}}

	string currentSpanText = this.radRichTextBox.Document.CaretPosition.GetCurrentSpan().Text;
{{endregion}}

#### __[VB.NET] Example 1: Getting the word on the caret position__  
{{region radrichtextbox-features-positioning_1}}

	Dim currentSpanText As String = Me.radRichTextBox.Document.CaretPosition.GetCurrentSpan().Text
{{endregion}}

## DocumentPosition Class

An alternative of using the __CaretPosition__ property is to create an instance of the __DocumentPosition__ class. Here is the same example from the previous chapter done with an instance of the __DocumentPosition__ class.        

>When instantiated in such a way, the position will be at the start of the document, so the result will be the first word in the text. The position of the instance won't be affected by the UI. To change it, you have to use {% if site.site_name == 'Silverlight' %}[the API of the DocumentPosition class](https://docs.telerik.com/devtools/silverlight/api/telerik.windows.documents.documentposition){% endif %}{% if site.site_name == 'WPF' %}[the API of the DocumentPosition class](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.documentposition){% endif %}.            

#### __[C#] Example 2: Getting the word on the caret using the DocumentPosition class__  
{{region radrichtextbox-features-positioning_2}}

	DocumentPosition position = new DocumentPosition(this.radRichTextBox.Document);
	string currentSpanText = position.GetCurrentSpan().Text;
{{endregion}}

#### __[VB.NET] Example 2: Getting the word on the caret position using the DocumentPosition class__  
{{region radrichtextbox-features-positioning_3}}

	Dim position As New DocumentPosition(Me.radRichTextBox.Document)
	Dim currentSpanText As String = position.GetCurrentSpan().Text
{{endregion}}

> To set selection range in RadRichTextBox, you can use the **DocumentPosition** class. You can read more about this in the [**Selection**]({%slug radrichtextbox-features-selection%}#programmatic-selection) help article.

### Tracking Positions

When you need to ensure that the position is kept between the same characters, no matter the modifications users can do on the document content, you can instantiate the DocumentPosition object using one of the constructors accepting a boolean value. This boolean value indicates whether the position should track the changes in the document and move accordingly so it can be located on the same position in the word.

**DocumentPosition** created with any of the constructors accepting the boolean *trackDocumentChangeEvents* parameter set to ``true`` moves automatically when the document is edited before the position (just like the caret position).

>Positions created in such a way could be explicitly disposed to avoid preserving them too much in memory.


## Determine The Type of Element The Position Is At

The **DocumentPosition** class offers different properties allowing you to determine where the position is located. For example, you can check whether the position is at the start of the document or at its end. Similarly, you can obtain information whether the position is inside table. Here is a list of these properties:

* **IsPositionAtDocumentEnd**
* **IsPositionAtDocumentStart**
* **IsPositionAtParagraphEnd**
* **IsPositionAtParagraphStart**
* **IsPositionAtTableCellEnd**
* **IsPositionAtTableCellStart**
* **IsPositionAtTableRowStart**
* **IsPositionInsideTable**

There is also a **Location** property holding information about where in the layout the position is situated. 


## Access Document Element from Caret Position

You can use the methods of the __DocumentPosition__ class to get the [document element]({%slug radrichtextbox-features-document-elements-hierarchy%}) at the specific position. The following list shows the methods which can be used.

* **GetCurrentInline()**
* **GetCurrentParagraph()**
* **GetCurrentSpan()**
* **GetCurrentTable()**
* **GetCurrentTableCell()**
* **GetCurrentTableRow()**
* **GetNextInline()**
* **GetNextSpan()**
* **GetPreviousInline()**

In addition to the above-mentioned methods, DocumentPosition exposes also __GetCurrent[document element]Box__ methods returning objects of type __LayoutBox__, which can be used to get the relevant layout information about a document element. To get the element from the layout box, you can use the __AssociatedDocumentElement__ property. 

In the different implementations of the LayoutBox class (examples: ParagraphLayoutBox, SectionLayoutBox, etc.) there are also more specific properties that allow you to easily get the associated document element without casting it from the base DocumentElement class. For example, the GetCurrentParagraphBox() method returns an object of type ParagraphLayoutBox which has __AssociatedParagraph__ property. And the GetCurrentSectionBox() returns SectionLayoutBox which has __AssociatedSection__ property. This rule applies to all LayoutBox elements (also TableLayoutBox, SpanLayoutBox, etc.).

#### __[C#] Example 3: Getting the Paragraph on the caret position__  
{{region radrichtextbox-features-positioning_4}}

	DocumentPosition documentPosition = radRichTextBox.Document.CaretPosition;
	Paragraph paragraph = documentPosition.GetCurrentParagraph();

{{endregion}}

#### __[VB.NET] Example 3: Getting the Paragraph on the caret position__  
{{region radrichtextbox-features-positioning_5}}

	Dim documentPosition As DocumentPosition = radRichTextBox.Document.CaretPosition
	Dim paragraph As Paragraph = documentPosition.GetCurrentParagraph()
{{endregion}}



#### __[C#] Example 4: Getting the Inline on the caret position__  
{{region radrichtextbox-features-positioning_6}}

	DocumentPosition documentPosition = radRichTextBox.Document.CaretPosition;
	Inline inline = documentPosition.GetCurrentInline();
{{endregion}}

#### __[VB.NET] Example 4: Getting the Inline on the caret position__  
{{region radrichtextbox-features-positioning_7}}

	Dim documentPosition As DocumentPosition = radRichTextBox.Document.CaretPosition
	Dim inline As Inline = documentPosition.GetCurrentInline()
{{endregion}}

To get the word on the document position, you can use the __GetCurrentWord()__ method.

#### __[C#] Example 5: Getting the word on the caret position__  
{{region radrichtextbox-features-positioning_8}}

	DocumentPosition documentPosition = radRichTextBox.Document.CaretPosition;
	string word = documentPosition.GetCurrentWord();	
{{endregion}}

#### __[VB.NET] Example 5: Getting the word on the caret position__  
{{region radrichtextbox-features-positioning_9}}

	Dim documentPosition As DocumentPosition = radRichTextBox.Document.CaretPosition
	Dim word As String = documentPosition.GetCurrentWord()
{{endregion}}

If the searched document element (paragraph, span, table, etc.) cannot be found on the caret position, the corresponding method will return `null`.

## Convert Between DocumentPosition And Screen Position

You can use the __ActiveDocumentPresenter__ of RadRichTextBox to convert a screen position to DocumentPosition and vice versa. The ActiveDocumentPresenter expose couple methods which can be used.

* __GetDocumentPositionFromViewPoint()__: The method accepts an argument of type __System.Windows.Point__ and returns an instance of type __DocumentPosition__.

	#### __[C#] Example 6: Screen position to DocumentPosition conversion__  
	{{region radrichtextbox-features-positioning_10}}

		Point position = GetMousePosition();
		DocumentPosition documentPosition = radRichTextBox.ActiveEditorPresenter.GetDocumentPositionFromViewPoint(position);
	{{endregion}}
	
	#### __[VB.NET] Example 6: Screen position to DocumentPosition conversion__  
	{{region radrichtextbox-features-positioning_11}}

		Dim position As Point = GetMousePosition()
		Dim documentPosition As DocumentPosition = radRichTextBox.ActiveEditorPresenter.GetDocumentPositionFromViewPoint(position)
	{{endregion}}

* __GetViewPointFromDocumentPosition()__: The method accepts an argument of type __DocumentPosition__ and returns an instance of type __System.Windows.Point__

	#### __[C#] Example 7: DocumentPosition to screen position conversion__  
	{{region radrichtextbox-features-positioning_12}}

		DocumentPosition documentPosition = radRichTextBox.Document.CaretPosition;
		Point position = radRichTextBox.ActiveEditorPresenter.GetViewPointFromDocumentPosition(documentPosition);
	{{endregion}}
	
	#### __[VB.NET] Example 7: DocumentPosition to screen position conversion__  
	{{region radrichtextbox-features-positioning_13}}

		Dim documentPosition As DocumentPosition = radRichTextBox.Document.CaretPosition
		Dim position As Point = radRichTextBox.ActiveEditorPresenter.GetViewPointFromDocumentPosition(documentPosition)
	{{endregion}}

## Events

There are several events that you can use to track changes in the position.


* **LocationChanging**: Occurs before changing the coordinates of a position. For the caret position, this can be also achieved by typing, using the arrows keys or by clicking somewhere in the document.
* **LocationChanged**: Occurs when changing the coordinates of a position. For the caret position, this can be also achieved by typing, using the arrows keys or by clicking somewhere in the document.

* **PositionChanging**: Occurs before the position is moved. For the caret position, this can be also achieved using the arrows keys or by clicking somewhere in the document.
* **PositionChanged**: Occurs when the position is moved. For the caret position, this can be also achieved using the arrows keys or by clicking somewhere in the document.


**Example 8** shows how you can change the background of a Table object once the caret is positioned inside a Table.

#### __[C#] Example 8: Using DocumentPosition events__  
{{region radrichtextbox-features-positioning_14}}

	private void CaretPosition_LocationChanged(object sender, EventArgs e)
	{
	    if (this.radRichTextBox.Document.CaretPosition.IsPositionInsideTable)
	    {
	        Table table = this.radRichTextBox.Document.CaretPosition.GetCurrentTable();
	        table.Background = Colors.Red;
	    }
	}
{{endregion}}

#### __[VB.NET] Example 8: Using DocumentPosition events__  
{{region radrichtextbox-features-positioning_15}}

	Private Sub CaretPosition_LocationChanged(ByVal sender As Object, ByVal e As EventArgs)
	    If Me.radRichTextBox.Document.CaretPosition.IsPositionInsideTable Then
	        Dim table As Table = Me.radRichTextBox.Document.CaretPosition.GetCurrentTable()
	        table.Background = Colors.Red
	    End If
	End Sub
{{endregion}}



## See Also  
* [DocumentPosition API Reference](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.documentposition)
* [Selection]({%slug radrichtextbox-features-selection%})
* [History]({%slug radrichtextbox-features-history%})
* [Document Elements]({%slug radrichtextbox-features-document-elements-hierarchy%})
