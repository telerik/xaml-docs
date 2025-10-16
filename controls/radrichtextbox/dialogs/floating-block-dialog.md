---
title: Floating Blocks Properties Dialog
page_title: Floating Blocks Properties Dialog
description: Check our &quot;Floating Block Properties Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-floating-block
tags: link,insert,floating,block,image
published: True
position: 1
---

# Floating Blocks Layout Properties Dialog

This dialog allows you to update the properties of floating blocks, like [floating images]({%slug radrichtextbox-features-document-elements-floatingimage%}).

![An image showing the floating block properties dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-floating-block-0.png)

The dialog can be opened from the __More Layout Options__ button in the right-click menu (context menu) of `RadRichTextBox`.

![An image showing the button that opens the floating block properties dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-floating-block-1.png)

## Showing the Dialog Manually

The dialog can be shown by executing the `ShowFloatingBlockPropertiesDialogCommand`. See how to bind the command to an external button in the [Commands]({%slug radrichtextbox-features-commands%}) article.

__Executing the show dialog command__
```C#
	this.richTextBox.Commands.ShowFloatingBlockPropertiesDialogCommand.Execute(null);
```

Alternatively, call the `ShowFloatingBlockPropertiesDialog` method of `RadRichTextBox`.

__Using the show dialog method__
```C#
	this.richTextBox.ShowFloatingBlockPropertiesDialog();
```