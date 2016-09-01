---
title: Selection
page_title: Selection
description: Selection
slug: radrichtextbox-features-selection
tags: selection
published: True
---

# Selection



The __RadRichTextBox__ supports not only selection via the UI, but also programmatic selection. This topic covers the following:

* [Use UI Selection](#ui-selection)

* [Implement Programmatic Selection](#programmatic-selection)

* [Implement Multi-range Selection](#multi-range-selection)

## UI Selection

The user is able to select the content of the __RadRichTextBox__ in the same way as in MS Word. This is done by clicking on the desired position and dragging to the desired end of the selection. A multiple ranges selection is also allowed. This one is done by holding the __Ctrl__ key while selecting the different ranges.

## Programmatic Selection

The developer is allowed to work with the selection programmatically. This can be used when implementing [Search functionality]({%slug radrichtextbox-features-search%}) functionality in your __RadRichTextBox__ and you want to select the found string. 

The programmatic selection gets implemented via the __DocumentSelection__ class. The instance of the class gets associated with the __RadDocument__ of the __RadRichTextBox__ and allows you to specify selection starts and ends, selection ranges and other. You can manage the selection by either using the __Selection__ property of the __RadDocument__ or by creating an instance of the __DocumentSelection__ class.

Here is an example of how to select the current word.

>tipTo learn more about the __DocumentPosition__ read the [Positioning]({%slug radrichtextbox-features-positioning%}) topic.

#### __C#__

{{region radrichtextbox-features-selection_0}}
    DocumentPosition startPosition = new DocumentPosition(this.radRichTextBox.Document.CaretPosition);
    DocumentPosition endPosition = new DocumentPosition(startPosition);
    startPosition.MoveToCurrentWordStart();
    endPosition.MoveToCurrentWordEnd();
    this.radRichTextBox.Document.Selection.SetSelectionStart(startPosition);
    this.radRichTextBox.Document.Selection.AddSelectionEnd(endPosition);
{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-selection_1}}
	Dim startPosition As New DocumentPosition(Me.radRichTextBox.Document.CaretPosition)
	Dim endPosition As New DocumentPosition(startPosition)
	startPosition.MoveToCurrentWordStart()
	endPosition.MoveToCurrentWordEnd()
	Me.radRichTextBox.Document.Selection.SetSelectionStart(startPosition)
	Me.radRichTextBox.Document.Selection.AddSelectionEnd(endPosition)
{{endregion}}



## Multi-Range Selection

You can implement multi-range Selection by either calling multiple times the __AddSelectionStart()__ and __AddSelectionEnd()__ methods or by working with the __Ranges__ collection.

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
	} 
	while (position.MoveToNextWordStart());
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

When working with ranges, you may need to check what elements are included in a selection range. This could be achieved with the __RangeType__ property of __SelectionRange__. This property is of type __SelectionRangeType__ and could have one of the following values:

* __Composite__: Represents selection range with mixed elements.

* __Table__: __SelectionRange__, which contains a [Table]({%slug radrichtextbox-features-document-elements-tables%}).

* __TableRow__: The range consists of a __TableRow__.

* __TableCell__: __TableCell__ selection range.

#### __C#__

{{region radrichtextbox-features-selection_4}}
	SelectionRange selectionRange = this.radRichTextBox.Document.Selection.Ranges.First();
	if (selectionRange.RangeType == SelectionRangeType.Table)
	{
	    SetTableProperties();
	}
{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-selection_5}}
	Dim selectionRange As SelectionRange = Me.radRichTextBox.Document.Selection.Ranges.First()
	If selectionRange.RangeType = SelectionRangeType.Table Then
		SetTableProperties()
	End If
{{endregion}}


# See Also

 * [Positioning]({%slug radrichtextbox-features-positioning%})

 * [History]({%slug radrichtextbox-features-history%})

 * [Clipboard Support]({%slug radrichtextbox-features-clipboard-support%})
