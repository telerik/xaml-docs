---
title: Hyperlink Dialog
page_title: Hyperlink Dialog
description: Check our &quot;Hyperlink Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-hyperlink
tags: link,insert
published: True
position: 1
---

# Hyperlink Dialog

This dialog allows you to insert and edit [hyperlinks]({%slug radrichtextbox-features-document-elements-hyperlink%}) pointing to web addresses or bookmarks in the document.

![An image showing the hyperlink dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-hyperlink-0.png)

The dialog can be opened from the __Hyperlink__ button in the __Insert__ tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}) or via the in the same option in the right-click menu (context menu) of `RadRichTextBox`.

![An image showing the button that opens the hyperlink dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-hyperlink-1.png)

![An image showing the context menu that opens the hyperlink dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-hyperlink-3.png)

## Showing the Dialog Manually

The dialog can be shown by executing the `ShowInsertHyperlinkDialogCommand`. See how to bind the command to an external button in the [Commands]({%slug radrichtextbox-features-commands%}) article.

#### __[C#] Executing the show dialog command__
{{region radrichtextbox-dialogs-hyperlink-0}}
	this.richTextBox.Commands.ShowInsertHyperlinkDialogCommand.Execute(null);
{{endregion}}

Alternatively, call the `ShowInsertHyperlinkDialog` method of `RadRichTextBox`.

#### __[C#] Using the show dialog method__
{{region radrichtextbox-dialogs-hyperlink-1}}
	this.richTextBox.ShowInsertHyperlinkDialog();
{{endregion}}
