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
<snippet id='radrichtextbox-features-positioning-block_1-cs' />
<snippet id='radrichtextbox-features-positioning-block_2-vb' />

## CaretWidthScaleFactor property

The `RadRichTextBox` control exposes the `CaretWidthScaleFactor` property, which will allow you to customize the width of the caret. 

__Setting the CaretWidthScaleFactor property__
<snippet id='radrichtextbox-features-positioning-block_3-cs' />
<snippet id='radrichtextbox-features-positioning-block_4-vb' />

## DocumentPosition Class

An alternative of using the `CaretPosition` property is to create an instance of the `DocumentPosition` class. Here is the same example from the previous chapter done with an instance of the DocumentPosition class.        

>When instantiated in such a way, the position will be at the start of the document, so the result will be the first word in the text. The position of the instance won't be affected by the UI. To change it, you have to use {% if site.site_name == 'Silverlight' %}[the API of the DocumentPosition class](https://docs.telerik.com/devtools/silverlight/api/telerik.windows.documents.documentposition){% endif %}{% if site.site_name == 'WPF' %}[the API of the DocumentPosition class](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.documentposition){% endif %}.            

__Getting the word on the caret using the DocumentPosition class__  
<snippet id='radrichtextbox-features-positioning-block_5-cs' />
<snippet id='radrichtextbox-features-positioning-block_6-vb' />

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
<snippet id='radrichtextbox-features-positioning-block_7-cs' />
<snippet id='radrichtextbox-features-positioning-block_8-vb' />

__Getting the Inline on the caret position__  
<snippet id='radrichtextbox-features-positioning-block_9-cs' />
<snippet id='radrichtextbox-features-positioning-block_10-vb' />

To get the word on the document position, you can use the `GetCurrentWord()` method.

__Getting the word on the caret position__  
<snippet id='radrichtextbox-features-positioning-block_11-cs' />
<snippet id='radrichtextbox-features-positioning-block_12-vb' />

If the searched document element (paragraph, span, table, etc.) cannot be found on the caret position, the corresponding method will return `null`.

## Convert Between DocumentPosition And Screen Position

You can use the `ActiveDocumentPresenter` of RadRichTextBox to convert a screen position to DocumentPosition and vice versa. The ActiveDocumentPresenter expose couple methods which can be used.

* `GetDocumentPositionFromViewPoint()`&mdash;The method accepts an argument of type `System.Windows.Point` and returns an instance of type DocumentPosition.

	__Screen position to DocumentPosition conversion__  
	<snippet id='radrichtextbox-features-positioning-block_13-cs' />
	<snippet id='radrichtextbox-features-positioning-block_14-vb' />

* `GetViewPointFromDocumentPosition()`&mdash;The method accepts an argument of type DocumentPosition and returns an instance of type `System.Windows.Point`.

	__DocumentPosition to screen position conversion__  
	<snippet id='radrichtextbox-features-positioning-block_15-cs' />
	<snippet id='radrichtextbox-features-positioning-block_16-vb' />

## Events

There are several events that you can use to track changes in the position.

* `LocationChanging`&mdash;Occurs before changing the coordinates of a position. For the caret position, this can be also achieved by typing, using the arrows keys or by clicking somewhere in the document.
* `LocationChanged`&mdash;Occurs when changing the coordinates of a position. For the caret position, this can be also achieved by typing, using the arrows keys or by clicking somewhere in the document.

* `PositionChanging`&mdash;Occurs before the position is moved. For the caret position, this can be also achieved using the arrows keys or by clicking somewhere in the document.
* `PositionChanged`&mdash;Occurs when the position is moved. For the caret position, this can be also achieved using the arrows keys or by clicking somewhere in the document.

The following example shows how you can change the background of a Table object once the caret is positioned inside a Table.

__Using DocumentPosition events__  
<snippet id='radrichtextbox-features-positioning-block_17-cs' />
<snippet id='radrichtextbox-features-positioning-block_18-vb' />

## See Also  
* [DocumentPosition API Reference](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.documentposition)
* [Selection]({%slug radrichtextbox-features-selection%})
* [History]({%slug radrichtextbox-features-history%})
* [Document Elements]({%slug radrichtextbox-features-document-elements-hierarchy%})