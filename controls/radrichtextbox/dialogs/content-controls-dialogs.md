---
title: Content Control Properties Dialog
page_title: Content Control Properties Dialog
description: Check our &quot;Content Controls Properties Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-content-controls
tags: link,insert
published: True
position: 1
---

# Content Control Properties Dialog

This dialog allows you to edit the properties of the [content controls]({%slug radrichtextbox-features-document-elements-hyperlink%}) in the document.

![An image showing the content controls properties dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-content-controls-0.png)

The dialog can be opened from the __Properties__ button in the __Developer__ tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}) or via the in the same option in the right-click menu (context menu) of `RadRichTextBox`.

![An image showing the button that opens the content controls properties dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-content-controls-1.png)

![An image showing the context menu that opens the content controls properties dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-content-controls-2.png)

## Showing the Dialog Manually

The dialog can be shown by executing the `ShowContentControlPropertiesDialogCommand`. See how to bind the command to an external button in the [Commands]({%slug radrichtextbox-features-commands%}) article.

#### __[C#] Executing the show dialog command__
{{region radrichtextbox-dialogs-content-controls-0}}
	this.richTextBox.Commands.ShowContentControlPropertiesDialogCommand.Execute(null);
{{endregion}}