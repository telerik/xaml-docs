---
title: Line Numbers Dialog
page_title: Line Numbering Dialog
description: Check our &quot;Line Numbers Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-line-numbers
tags: line,numbers,numbering
published: True
position: 1
---

# Line Numbers Dialog

This dialog allows you to adjust the [line numbering]({%slug radrichtextbox-features-line-numbering%}) in the document.

![An image showing the line numbering dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-line-numbers-0.png)

The dialog can be opened from the __Line Numbers__ drop down button in the __Page Layout__ tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}).

![An image showing the button that opens the line numbering dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-line-numbers-1.png)

## Showing the Dialog Manually

The dialog can be shown by executing the `ShowLineNumberingDialogCommand`. See how to bind the command to an external button in the [Commands]({%slug radrichtextbox-features-commands%}) article.

__Executing the show dialog command__
```C#
	this.richTextBox.Commands.ShowLineNumberingDialogCommand.Execute(null);
```

Alternatively, call the `ShowInsertHyperlinkDialog` method of `RadRichTextBox`.

__Using the show dialog method__
```C#
	this.richTextBox.ShowLineNumberingDialog();
```