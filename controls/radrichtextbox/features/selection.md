---
title: Selection
page_title: Selection
description: Selection
slug: radrichtextbox-features-selection
tags: selection
published: True
position: 1
---

# Selection



The __RadRichTextBox__ supports not only selection via the UI, but also programmatic selection. This topic will explain you how to:

* [Use UI Selection](#ui-selection)

* [Implement Programmatic Selection](#programmatic-selection)

* [Implement Multi-range Selection](#multi-range-selection)

## UI Selection

The user is able to select the content of the __RadRichTextBox__ in the same way as in MS Word. This is done by clicking on the desired position and dragging to the desired end of the selection. A multiple ranges selection is also allowed. This one is done by holding the __Ctrl__ key while selecting the different ranges.

## Programmatic Selection

The developer is allowed to work with the selection programmatically. This can be used when having a __Find__ functionality in your __RadRichTextBox__ and you want to select the found string. Examples that involve the programmatic selection can be found in the How To section.

The programmatic selection gets implemented via the __DocumentSelection__ class. The instance of the class gets associated with the __RadDocument__ of the __RadRichTextBox__ and allows you to specify selection starts and ends, selection ranges and other. You can manage the selection by either using the __Selection__ property of the __RadDocument__ or by creating an instance of the __DocumentSelection__ class.

Here is an example of how to select the current word.

>tipTo learn more about the __DocumentPosition__ read the [Positioning]({%slug radrichtextbox-features-positioning%}) topic.

#### __C#__

{{region radrichtextbox-features-selection_0}}
	DocumentPosition startPosition = this.radRichTextBox.Document.CaretPosition; //new DocumentPosition( this.radRichTextBox.Document );
	DocumentPosition endPosition = new DocumentPosition(startPosition);
	startPosition.MoveToCurrentWordStart();
	endPosition.MoveToCurrentWordEnd();
	this.radRichTextBox.Document.Selection.AddSelectionStart(startPosition);
	this.radRichTextBox.Document.Selection.AddSelectionEnd(endPosition);
{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-selection_1}}
	Dim startPosition As DocumentPosition = Me.radRichTextBox.Document.CaretPosition
	\'new DocumentPosition(this.radRichTextBox.Document);
	Dim endPosition As New DocumentPosition(startPosition)
	startPosition.MoveToCurrentWordStart()
	endPosition.MoveToCurrentWordEnd()
	Me.radRichTextBox.Document.Selection.AddSelectionStart(startPosition)
	Me.radRichTextBox.Document.Selection.AddSelectionEnd(endPosition)
{{endregion}}



## Multi-Range Selection

You can implement Multi-Range Selection by either calling multiple times the __AddSelectionStart()__ and __AddSelectionEnd()__ methods or by working with the __Ranges__ collection.

Here is an example of selecting each "RadRichTextBox" word in the text. This example uses the first approach.

#### __C#__

{{region radrichtextbox-features-selection_2}}
	DocumentPosition position = new DocumentPosition(this.radRichTextBox.Document);
	do
	{
	    //GetCurrentSpan().Text returns the word at the position
	    string word = position.GetCurrentSpanBox().Text;
	    if (word.Contains("RadRichTextBox"))
	    {
	        DocumentPosition wordEndPosition = new DocumentPosition(position);
	        wordEndPosition.MoveToCurrentWordEnd();
	        this.radRichTextBox.Document.Selection.AddSelectionStart(position);
	        this.radRichTextBox.Document.Selection.AddSelectionEnd(wordEndPosition);
	
	    }
	} while (position.MoveToNextWordStart());
{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-selection_3}}
	Dim position As New DocumentPosition(Me.radRichTextBox.Document)
	Do
	 \'GetCurrentSpan().Text returns the word at the position
	 Dim word As String = position.GetCurrentSpanBox().Text
	 If word.Contains("RadRichTextBox") Then
	  Dim wordEndPosition As New DocumentPosition(position)
	  wordEndPosition.MoveToCurrentWordEnd()
	  Me.radRichTextBox.Document.Selection.AddSelectionStart(position)
	
	  Me.radRichTextBox.Document.Selection.AddSelectionEnd(wordEndPosition)
	 End If
	Loop While position.MoveToNextWordStart()
{{endregion}}



![](images/RadRichTextBox_Selection_01.png)

# See Also

 * [Positioning]({%slug radrichtextbox-features-positioning%})

 * [History]({%slug radrichtextbox-features-history%})

 * [Clipboard Support]({%slug radrichtextbox-features-clipboard-support%})
