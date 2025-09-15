---
title: Positioning
page_title: Positioning
description: Check our &quot;Positioning&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-positioning
tags: positioning
published: True
---

# Positioning

The positioning feature in `RadRichTextBox` is used to navigate through document's content and to get information about the document's elements at a specific position. The `RadDocument` uses the positioning to track the movement of the caret and to control the selection.


## Overview

The positioning is implemented via the `DocumentPosition` class. This class can be used by the developer to programmatically control the positioning or the selection. DocumentPosition offers methods, such as `MoveToNextWordStart()`, `MoveToPreviousWordStart()`, `MoveToCurrentLineStart/End()` and so on, which will navigate to the given document element. In order to get information about the element at a given position, you can use several methods such as `GetCurrentSpanBox()`, `GetCurrentParagraphBox()`, `GetCurrentSectionBox()` and so on which will return the LayoutBox of an element. Another option is to use directly the methods returning the specific document element - `GetCurrentSpan()`, `GetCurrentParagraph()`, `GetCurrentTable()` etc.

DocumentPosition also redefines equality and comparison operators for more convenience, when you should find whether the DocumentPosition is before or after another position in the natural flow of the document. By default, `RadRichTextBox` moves `Document.CaretPosition` using the arrow keys or on a mouse click. DocumentPosition can also be obtained by giving the coordinates of a point in the document using the method `DocumentPosition.SetPosition()`.

You can manage the caret position for a specific `RadDocument` by either accessing its `CaretPosition` property, which is of type DocumentPosition, or by creating a new instance of the DocumentPosition class and associating it with the desired RadDocument.

>When using the `CaretPosition` property you are directly managing the caret position in the RadDocument. By using the DocumentPosition class, you can create instances of several positions inside the document without changing the current caret position.

## CaretPosition property

This property enables you to manage the position of the caret inside the document and to obtain information about its location and the elements it currently resides at. Here is an example of how to use the CaretPosition property to get the current word.

__Getting the word on the caret position__  
```C#
	string currentSpanText = this.radRichTextBox.Document.CaretPosition.GetCurrentSpan().Text;
```
```VB.NET
	Dim currentSpanText As String = Me.radRichTextBox.Document.CaretPosition.GetCurrentSpan().Text
```

## CaretWidthScaleFactor property

The `RadRichTextBox` control exposes the `CaretWidthScaleFactor` property, which will allow you to customize the width of the caret. 

__Setting the CaretWidthScaleFactor property__
```C#
	this.radRichTextBox.CaretWidthScaleFactor = 10;
```
```VB.NET
	Me.radRichTextBox.CaretWidthScaleFactor = 10
```

## DocumentPosition Class

An alternative of using the `CaretPosition` property is to create an instance of the `DocumentPosition` class. Here is the same example from the previous chapter done with an instance of the DocumentPosition class.        

>When instantiated in such a way, the position will be at the start of the document, so the result will be the first word in the text. The position of the instance won't be affected by the UI. To change it, you have to use {% if site.site_name == 'Silverlight' %}[the API of the DocumentPosition class](https://docs.telerik.com/devtools/silverlight/api/telerik.windows.documents.documentposition){% endif %}{% if site.site_name == 'WPF' %}[the API of the DocumentPosition class](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.documentposition){% endif %}.            

__Getting the word on the caret using the DocumentPosition class__  
```C#
	DocumentPosition position = new DocumentPosition(this.radRichTextBox.Document);
	string currentSpanText = position.GetCurrentSpan().Text;
```
```VB.NET
	Dim position As New DocumentPosition(Me.radRichTextBox.Document)
	Dim currentSpanText As String = position.GetCurrentSpan().Text
```

> To set selection range in RadRichTextBox, you can use the DocumentPosition class. You can read more about this in the [Selection]({%slug radrichtextbox-features-selection%}#programmatic-selection) help article.

### Tracking Positions

When you need to ensure that the position is kept between the same characters, no matter the modifications users can do on the document content, you can instantiate the DocumentPosition object using one of the constructors accepting a boolean value. This boolean value indicates whether the position should track the changes in the document and move accordingly so it can be located on the same position in the word.

DocumentPosition created with any of the constructors accepting the boolean *trackDocumentChangeEvents* parameter set to true moves automatically when the document is edited before the position (just like the caret position).

>Positions created in such a way could be explicitly disposed to avoid preserving them too much in memory.

## Determine The Type of Element The Position Is At

The `DocumentPosition` class offers different properties allowing you to determine where the position is located. For example, you can check whether the position is at the start of the document or at its end. Similarly, you can obtain information whether the position is inside table. Here is a list of these properties:

* `IsPositionAtDocumentEnd`
* `IsPositionAtDocumentStart`
* `IsPositionAtParagraphEnd`
* `IsPositionAtParagraphStart`
* `IsPositionAtTableCellEnd`
* `IsPositionAtTableCellStart`
* `IsPositionAtTableRowStart`
* `IsPositionInsideTable`

There is also a `Location` property holding information about where in the layout the position is situated. 

## Access Document Element from Caret Position

You can use the methods of the `DocumentPosition` class to get the [document element]({%slug radrichtextbox-features-document-elements-hierarchy%}) at the specific position. The following list shows the methods which can be used.

* `GetCurrentInline()`
* `GetCurrentParagraph()`
* `GetCurrentSpan()`
* `GetCurrentTable()`
* `GetCurrentTableCell()`
* `GetCurrentTableRow()`
* `GetNextInline()`
* `GetNextSpan()`
* `GetPreviousInline()`

In addition to the above-mentioned methods, DocumentPosition exposes also __GetCurrent[document element]Box__ methods returning objects of type `LayoutBox`, which can be used to get the relevant layout information about a document element. To get the element from the layout box, you can use the `AssociatedDocumentElement` property. 

In the different implementations of the LayoutBox class (examples: ParagraphLayoutBox, SectionLayoutBox, etc.) there are also more specific properties that allow you to easily get the associated document element without casting it from the base DocumentElement class. For example, the GetCurrentParagraphBox() method returns an object of type ParagraphLayoutBox which has `AssociatedParagraph` property. And the GetCurrentSectionBox() returns SectionLayoutBox which has `AssociatedSection` property. This rule applies to all LayoutBox elements (also TableLayoutBox, SpanLayoutBox, etc.).

__Getting the Paragraph on the caret position__  
```C#
	DocumentPosition documentPosition = radRichTextBox.Document.CaretPosition;
	Paragraph paragraph = documentPosition.GetCurrentParagraph();

```
```VB.NET
	Dim documentPosition As DocumentPosition = radRichTextBox.Document.CaretPosition
	Dim paragraph As Paragraph = documentPosition.GetCurrentParagraph()
```

__Getting the Inline on the caret position__  
```C#
	DocumentPosition documentPosition = radRichTextBox.Document.CaretPosition;
	Inline inline = documentPosition.GetCurrentInline();
```
```VB.NET
	Dim documentPosition As DocumentPosition = radRichTextBox.Document.CaretPosition
	Dim inline As Inline = documentPosition.GetCurrentInline()
```

To get the word on the document position, you can use the `GetCurrentWord()` method.

__Getting the word on the caret position__  
```C#
	DocumentPosition documentPosition = radRichTextBox.Document.CaretPosition;
	string word = documentPosition.GetCurrentWord();	
```
```VB.NET
	Dim documentPosition As DocumentPosition = radRichTextBox.Document.CaretPosition
	Dim word As String = documentPosition.GetCurrentWord()
```

If the searched document element (paragraph, span, table, etc.) cannot be found on the caret position, the corresponding method will return `null`.

## Convert Between DocumentPosition And Screen Position

You can use the `ActiveDocumentPresenter` of RadRichTextBox to convert a screen position to DocumentPosition and vice versa. The ActiveDocumentPresenter expose couple methods which can be used.

* `GetDocumentPositionFromViewPoint()`&mdash;The method accepts an argument of type `System.Windows.Point` and returns an instance of type DocumentPosition.

	__Screen position to DocumentPosition conversion__  
	```C#
		Point position = GetMousePosition();
		DocumentPosition documentPosition = radRichTextBox.ActiveEditorPresenter.GetDocumentPositionFromViewPoint(position);
	```
```VB.NET
		Dim position As Point = GetMousePosition()
		Dim documentPosition As DocumentPosition = radRichTextBox.ActiveEditorPresenter.GetDocumentPositionFromViewPoint(position)
	```

* `GetViewPointFromDocumentPosition()`&mdash;The method accepts an argument of type DocumentPosition and returns an instance of type `System.Windows.Point`.

	__DocumentPosition to screen position conversion__  
	```C#
		DocumentPosition documentPosition = radRichTextBox.Document.CaretPosition;
		Point position = radRichTextBox.ActiveEditorPresenter.GetViewPointFromDocumentPosition(documentPosition);
	```
```VB.NET
		Dim documentPosition As DocumentPosition = radRichTextBox.Document.CaretPosition
		Dim position As Point = radRichTextBox.ActiveEditorPresenter.GetViewPointFromDocumentPosition(documentPosition)
	```

## Events

There are several events that you can use to track changes in the position.

* `LocationChanging`&mdash;Occurs before changing the coordinates of a position. For the caret position, this can be also achieved by typing, using the arrows keys or by clicking somewhere in the document.
* `LocationChanged`&mdash;Occurs when changing the coordinates of a position. For the caret position, this can be also achieved by typing, using the arrows keys or by clicking somewhere in the document.

* `PositionChanging`&mdash;Occurs before the position is moved. For the caret position, this can be also achieved using the arrows keys or by clicking somewhere in the document.
* `PositionChanged`&mdash;Occurs when the position is moved. For the caret position, this can be also achieved using the arrows keys or by clicking somewhere in the document.

The following example shows how you can change the background of a Table object once the caret is positioned inside a Table.

__Using DocumentPosition events__  
```C#
	private void CaretPosition_LocationChanged(object sender, EventArgs e)
	{
	    if (this.radRichTextBox.Document.CaretPosition.IsPositionInsideTable)
	    {
	        Table table = this.radRichTextBox.Document.CaretPosition.GetCurrentTable();
	        table.Background = Colors.Red;
	    }
	}
```
```VB.NET
	Private Sub CaretPosition_LocationChanged(ByVal sender As Object, ByVal e As EventArgs)
	    If Me.radRichTextBox.Document.CaretPosition.IsPositionInsideTable Then
	        Dim table As Table = Me.radRichTextBox.Document.CaretPosition.GetCurrentTable()
	        table.Background = Colors.Red
	    End If
	End Sub
```

## See Also  
* [DocumentPosition API Reference](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.documentposition)
* [Selection]({%slug radrichtextbox-features-selection%})
* [History]({%slug radrichtextbox-features-history%})
* [Document Elements]({%slug radrichtextbox-features-document-elements-hierarchy%})
