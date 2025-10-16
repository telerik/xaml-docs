---
title: RadRichTextBox AutoText implementation
description: Shows how you can create reusable text snippets.
type: how-to
page_title: Implement custom functionality for reusable text snippets
slug: kb-richtextbox-auto-text-implementation
position: 0
tags: autotext, autocomplete, reusable, snippets, richtextbox
ticketid: 1465065
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2020.1.508</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadRichTextBox for WPF</td>
	    </tr>
    </tbody>
</table>


## Description

In this article, you will find how to implement custom functionality for reusable text snippets (AutoText) in RadRichTextBox.

## Solution

This functionality can be achieved by tracking the keyboard input. You can attach to the RadRichTextBox` KeyDown and KeyUp events. When the events are fired you can store and compare the entered text with a predefined pattern. When the text matches the pattern you can use the RadDocument`s [CaretPosition](%slug radrichtextbox-features-positioning%) to make a [Selection](%slug radrichtextbox-features-selection%) over the entered text and to overwrite it with the desired text snippet.

In the following codes snippet, we will demonstrate how to implement this functionality. The specific here is to get the right start and end position of the entered text that will be replaced with a text snippet. First, we are getting the end position by creating a new instance of [DocumentPosition](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.documentposition) passing the current CaretPosition and the trackDocumentChangeEvents (This indicates whether the position is anchored to the end of the word. If true, the position is kept between the same characters when there is a modification in the content before the position.). And second, we are passing the endPosition instance to the DocumentPosition constructor and then move the start position adjusting all the characters from the entered text (including the Colon and Space symbols).
Having both the start and the end position we can create a new Selection and using the RadRichTextBox` **Insert(string)** method (inserts text into the document at the specified position) we can overwrite this selection with a text snippet.

 
```C#

    private void RadRichTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (this.isTrackingInput && e.Key != Key.Space)
        {
            this.currentPattern.Append(e.Key);
        }

        if (this.isShiftPressed && e.Key == Key.OemSemicolon)
        {
            this.isTrackingInput = true;
        }

        if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
        {
            this.isShiftPressed = true;
        }
    }

    private void RadRichTextBox_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Space && this.isTrackingInput)
        {
            this.isTrackingInput = false;

            if (this.currentPattern.ToString().ToLower() == "tlk")
            {
                this.endPosition = new DocumentPosition(this.radRichTextBox.Document.CaretPosition, true);
                this.startPosition = new DocumentPosition(endPosition);
                for (int i = 0; i < currentPattern.Length + 2; i++)
                {
                    this.startPosition.MoveToPrevious();
                }

                this.radRichTextBox.Document.Selection.SetSelectionStart(this.startPosition);
                this.radRichTextBox.Document.Selection.AddSelectionEnd(this.endPosition);

                this.radRichTextBox.Insert("Progress (r) Telerik");
            }

            this.currentPattern.Clear();
        }

        if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
        {
            this.isShiftPressed = false;
        }
    }
```

## See Also

[Events](%slug radrichtextbox-events-overview%)
[Positioning](%slug radrichtextbox-features-positioning%)
[Selection](%slug radrichtextbox-features-selection%)