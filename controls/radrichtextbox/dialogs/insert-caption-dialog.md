---
title: Insert Caption Dialog
page_title: Insert Caption Dialog
description: Check our &quot;Insert Caption Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-insert-captions
tags: link,insert
published: True
position: 1
---

# Insert Caption Dialog

This dialog allows you to insert [captions]({%slug radrichtextbox-features-captions-for-tables-and-figures%}) in the document.

![An image showing the insert captions dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-insert-captions-0.png)

The dialog can be opened from the __Insert Caption__ button in the __References__ tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}).

![An image showing the button that opens the insert captions dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-insert-captions-1.png)

## Showing the Dialog Manually

The dialog can be shown by executing the `ShowInsertCaptionDialogCommand`. See how to bind the command to an external button in the [Commands]({%slug radrichtextbox-features-commands%}) article.

__Executing the show dialog command__
```C#
	this.richTextBox.Commands.ShowInsertCaptionDialogCommand.Execute(null);
```

Alternatively, call the `ShowInsertCaptionDialog` method of `RadRichTextBox`.

__Using the show dialog method__
```C#
	this.richTextBox.ShowInsertCaptionDialog();
```