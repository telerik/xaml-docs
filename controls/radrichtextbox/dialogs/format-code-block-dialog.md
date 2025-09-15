---
title: Format Code Block Dialog
page_title: Format Code Block Dialog
description: Check our &quot;Format Code Block Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-format-code-block
tags: format,code,snippet,block
published: True
position: 1
---

# Format Code Block Dialog

This dialog allows you to insert and edit [code blocks]({%slug radrichtextbox-features-code-block%}) in the document.

![An image showing the format code block dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-format-code-block-0.png)

The dialog can be opened from the __Code__ button in the __Insert__ tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}) or via the in the same option in the right-click menu (context menu) of `RadRichTextBox`.

![An image showing the button that opens the format code block dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-format-code-block-1.png)

![An image showing the context menu that opens the format code block dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-format-code-block-2.png)

## Showing the Dialog Manually

The dialog can be shown by executing the `ShowCodeFormattingDialogCommand`. See how to bind the command to an external button in the [Commands]({%slug radrichtextbox-features-commands%}) article.

__Executing the show dialog command__
```C#
	this.richTextBox.Commands.ShowCodeFormattingDialogCommand.Execute(null);
```

Alternatively, call the `ShowCodeFormattingDialog` method of `RadRichTextBox`.

__Using the show dialog method__
```C#
	this.richTextBox.ShowCodeFormattingDialog();
```