---
title: List Numbering Value
page_title: List Numbering Value Dialog
description: Check our &quot;Set List Numbering Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-list-numbering
tags: list,numbering,set,value
published: True
position: 1
---

# Set List Numbering Value Dialog

This dialog allows you adjust the numbering values in ordered list in the document.

![An image showing the list numbering dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-list-numbering-0.png)

The dialog can be opened using the __Set Numbering Value__ option in the right-click menu (context menu) of `RadRichTextBox`.

![An image showing the button that opens the list numbering dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-list-numbering-1.png)

## Showing the Dialog Manually

The dialog can be shown by executing the `ShowSetNumberingValueDialogCommand`. See how to bind the command to an external button in the [Commands]({%slug radrichtextbox-features-commands%}) article.

__Executing the show dialog command__
```C#
	this.richTextBox.Commands.ShowSetNumberingValueDialogCommand.Execute(null);
```

Alternatively, call the `ShowSetNumberingValueDialog` method of `RadRichTextBox`.

__Using the show dialog method__
```C#
	this.richTextBox.ShowSetNumberingValueDialog();
```