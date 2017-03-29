---
title: Positioning
page_title: Positioning
description: Positioning
slug: radrichtextbox-features-positioning
tags: positioning
published: True
---

# Positioning

The positioning feature in the __RadRichTextBox__ is used to navigate through document's content and to get information about the document's elements at a specific position. The __RadDocument__ uses the positioning to track the movement of the caret and to control the selection.

* [Overview](#overview)
* [Access document element from caret position](#access-document-element-from-caret-position)
* [Convert between DocumentPosition and screen position](#convert-between-documentposition-and-screen-position)

## Overview

The positioning is implemented via the __DocumentPosition__ class. This class can be used by the developer to programmatically control the positioning or the selection. __DocumentPosition__ offers methods, such as __MoveToNextWord()__, __MoveToPreviousWord()__, __MoveToCurrentLineStart/End()__ and so on, which will navigate to the given document element. In order to get information about the element at a given position you can use several methods such as __GetCurrentSpanBox()__, __GetCurrentParagraphBox()__, __GetCurrentSectionBox()__ and so on.

__DocumentPosition__ also redefines equality and comparison operators for more convenience, when you should find whether the __DocumentPosition__ is before or after another position in the natural flow of the document. By default __RadRichTextBox__ moves __Document.CaretPosition__ using arrow keys or on mouse click. __DocumentPosition__ can also be obtained by giving the coordinates of a point in the document using the method __DocumentPosition.SetPosition__.

You can manage the caret position for a specific __RadDocument__ by either accessing its __CaretPosition__ property, which is of type __DocumentPosition__, or by creating a new instance of the __DocumentPosition__ class and associating it with the desired __RadDocument__.

>When using the __CaretPosition__ property you are directly managing the caret position in the __RadDocument__. By using the __DocumentPosition__ class you can create instances of several positions inside the document without changing the current caret position.

## CaretPosition property

Here is an example of how to use the __CaretPosition__ property to get the current word.

#### __[C#] Example 1: Getting the word on the caret position__  
{{region radrichtextbox-features-positioning_0}}
	string currentSpanText = this.radRichTextBox.Document.CaretPosition.GetCurrentSpanBox().Text;
{{endregion}}

#### __[VB.NET] Example 1: Getting the word on the caret position__  
{{region radrichtextbox-features-positioning_1}}
	Dim currentSpanText As String = Me.radRichTextBox.Document.CaretPosition.GetCurrentSpanBox().Text
{{endregion}}

## DocumentPosition class

An alternative of using the __CaretPosition__ property is to create an instance of the __DocumentPosition__ class. Here is the same example from the previous chapter done with an instance of the __DocumentPosition__ class.        

>When instantiated in such a way, the position will be at the start of the document, so the result will be the first word in the text.The position of the instance won't be affected by the UI. To change it you have to use {% if site.site_name == 'Silverlight' %}[the API of the DocumentPosition class](http://www.telerik.com/help/silverlight/t_telerik_windows_documents_documentposition.html){% endif %}{% if site.site_name == 'WPF' %}[the API of the DocumentPosition class](http://docs.telerik.com/devtools/wpf/api/html/t_telerik_windows_documents_documentposition.htm){% endif %}.            

#### __[C#] Example 2: Getting the word on the caret using the DocumentPosition class__  
{{region radrichtextbox-features-positioning_2}}
	DocumentPosition position = new DocumentPosition( this.radRichTextBox.Document );
	string currentSpanText = position.GetCurrentSpanBox().Text;
{{endregion}}

#### __[VB.NET] Example 2: Getting the word on the caret position using the DocumentPosition class__  
{{region radrichtextbox-features-positioning_3}}
	Dim position As New DocumentPosition(Me.radRichTextBox.Document)
	Dim currentSpanText As String = position.GetCurrentSpanBox().Text
{{endregion}}

> To set selection range in RadRichTextBox you can use the DocumentPosition class. You can read more about this in the [Selection]({%slug radrichtextbox-features-selection%}#programmatic-selection) help article.

## Access document element from caret position

You can use the methods of the __DocumentPosition__ class to get the [document element]({%slug radrichtextbox-features-document-elements-hierarchy%}) on the caret position. The following list shows the methods which can be used.

* __GetCurrentInlineBox__
* __GetCurrentSpanBox__
* __GetCurrentParagraphBox__
* __GetCurrentSectionBox__	
* __GetCurrentTableBox__	
* __GetCurrentTableRowBox__	
* __GetCurrentTableCellBox__	

The __GetCurrent[document element]Box__ methods return objects of type __LayoutBox__ which can be used to get the relevant document element. To get the element you can use the __AssociatedDocumentElement__ property. 

In the different implementations of the LayoutBox class (examples: ParagraphLayoutBox, SectionLayoutBox, etc.) there are also more specific properties that allow you to easily get the associated document element without casting it from the base DocumentElement class. For example, the GetCurrentParagraphBox() method returns an object of type ParagraphLayoutBox which has __AssociatedParagraph__ property. And the GetCurrentSectionBox() returns SectionLayoutBox which has __AssociatedSection__ property. This rule applies to all LayoutBox elements (also TableLayoutBox, SpanLayoutBox, etc.).

#### __[C#] Example 3: Getting the Paragraph on the caret position__  
{{region radrichtextbox-features-positioning_4}}
	DocumentPosition documentPosition = radRichTextBox.Document.CaretPosition;
	ParagraphLayoutBox paragraphBox = documentPosition.GetCurrentParagraphBox();
	Paragraph paragraph = paragraphBox.AssociatedParagraph;				
{{endregion}}

#### __[VB.NET] Example 3: Getting the Paragraph on the caret position__  
{{region radrichtextbox-features-positioning_5}}
	Dim documentPosition As DocumentPosition = radRichTextBox.Document.CaretPosition
	Dim paragraphBox As ParagraphLayoutBox = documentPosition.GetCurrentParagraphBox()
	Dim paragraph As Paragraph = paragraphBox.AssociatedParagraph
{{endregion}}

There is also a __GetCurrentInline__ method that returns directly the inline element on the caret position.

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

To get the word on the document position you can use the __GetCurrentWord__ method.

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

## Convert between DocumentPosition and screen position

You can use the __ActiveDocumentPresenter__ of RadRichTextBox to convert a screen position to DocumentPosition and vice versa. The ActiveDocumentPresenter expose couple methods which can be used.

* __GetDocumentPositionFromViewPoint__: The method accepts an argument of type __System.Windows.Point__ and returns an instance of type __DocumentPosition__.

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

* __GetViewPointFromDocumentPosition__: The method accepts an argument of type __DocumentPosition__ and returns an instance of type __System.Windows.Point__

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

## See Also  
* [Selection]({%slug radrichtextbox-features-selection%})
* [History]({%slug radrichtextbox-features-history%})
* [Document Elements]({%slug radrichtextbox-features-document-elements-hierarchy%})
