---
title: RadRichTextBox AutoText implementation
description: Shows how you can create reusable text snippets.
type: how-to
page_title: RadRichTextBox AutoText implementation
slug: kb-richtextbox-auto-text-implementation
position: 0
tags: autotext, reusable, snippets, richtextbox
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

This functionality can be achieved by tracking the keyboard input by attaching to the RadRichTextBox` KeyDown and KeyUp events. When the events are fired you can store and compare the entered text and when it matches a predefined pattern to use the RadDocument`s [CaretPosition](%slug radrichtextbox-features-positioning%) to make a [Selection](%slug radrichtextbox-features-selection%) that will be overwritten with the desired text snippet.

#### __[C#]__
{{region kb-richtextbox-auto-text-implementation}}

    private void RadRichTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (this.isTrackingInput && e.Key != Key.Space)
        {
            this.currentPattern.Append(e.Key);
        }

        if (this.isShiftPressed && e.Key == Key.OemSemicolon)
        {
            this.isTrackingInput = true;
            this.startPosition = new DocumentPosition(this.radRichTextBox.Document.CaretPosition, true);
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
{{endregion}}

## See Also

[Events](%slug radrichtextbox-events-overview%)
[Positioning](%slug radrichtextbox-features-positioning%)
[Selection](%slug radrichtextbox-features-selection%)