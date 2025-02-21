---
title: Image Editor Dialog
page_title: Image Editor Dialog
description: Check our &quot;Image Editor Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-image-editor
tags: image,editor
published: True
position: 1
---

# Image Editor Dialog

This dialog allows you to [edit images]({%slug radrichtextbox-features-editing-images%}) in the document.

![An image showing the image editor of RadRichTextBox for WPF](images/richtextbox-dialogs-image-editor-0.png)

The dialog can be opened from the __Edit Image__ option in the context menu (right click menu) of `RadRichTextBox`. This option is available only when the context menu is opened over an image.

![An image showing the button that opens the image editor dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-image-editor-1.png)

## Showing the Dialog Manually

The dialog can be shown by executing the `ShowImageEditorDialogCommand`. See how to bind the command to an external button in the [Commands]({%slug radrichtextbox-features-commands%}) article.

#### __[C#] Executing the show dialog command__
{{region richtextbox-dialogs-image-editor-0}}
	this.richTextBox.Commands.ShowImageEditorDialogCommand.Execute(null);
{{endregion}}

Alternatively, call the `ShowImageEditorDialog` method of `RadRichTextBox`.

#### __[C#] Using the show dialog method__
{{region richtextbox-dialogs-image-editor-1}}
	this.richTextBox.ShowImageEditorDialog();
{{endregion}}