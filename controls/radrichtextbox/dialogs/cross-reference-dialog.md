---
title: Cross-Reference Dialog
page_title: Cross-Reference Dialog
description: Check our &quot;Cross-Reference Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-cross-reference
tags: link,insert,cross,reference,dialog
published: True
position: 1
---

# Cross-Reference Dialog

This dialog allows you to insert [cross-reference fields]({%slug radrichtextbox-features-cross-reference%}) that point to a caption, heading or a bookmark in the document.

![An image showing the cross reference dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-cross-reference-0.png)

The dialog can be opened from the __Cross-reference__ button in the __References__ tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}).

![An image showing the button that opens the cross reference dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-cross-reference-1.png)

## Showing the Dialog Manually

The dialog can be shown by executing the `ShowInsertCrossReferenceWindowCommand`. See how to bind the command to an external button in the [Commands]({%slug radrichtextbox-features-commands%}) article.

__Executing the show dialog command__
```C#
	this.richTextBox.Commands.ShowInsertCrossReferenceWindowCommand.Execute(null);
```

Alternatively, call the `ShowInsertCrossReferenceWindow` method of `RadRichTextBox`.

__Using the show dialog method__
```C#
	this.richTextBox.ShowInsertCrossReferenceWindow();
```