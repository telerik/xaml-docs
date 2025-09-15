---
title: Footnote and Endnote
page_title: Notes Dialog
description: Check our &quot;Notes Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-footnotes-endnotes
tags: footenotes,endnotes
published: True
position: 1
---

# Footnote and Endnote Dialog

This dialog allows you to insert [footnotes and endnotes]({%slug radrichtextbox-features-footnotes-endnotes%}) in the document.

![An image showing the footnotes dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-footnotes-endnotes-0.png)

The dialog can be opened from the dialog launcher button at the bottom right corner of the __Footnotes__ group in the __References__ tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}).

![An image showing the button that opens the footnotes dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-footnotes-endnotes-1.png)

## Showing the Dialog Manually

The dialog can be shown by executing the `ShowNotesDialogCommand`. See how to bind the command to an external button in the [Commands]({%slug radrichtextbox-features-commands%}) article.

__Executing the show dialog command__
```C#
	this.richTextBox.Commands.ShowNotesDialogCommand.Execute(null);
```

Alternatively, call the `ShowNotesDialog` method of `RadRichTextBox`.

__Using the show dialog method__
```C#
	this.richTextBox.ShowNotesDialog();
```