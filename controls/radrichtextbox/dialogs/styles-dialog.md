---
title: Styles Dialog
page_title: Styles Dialog
description: Check our &quot;Styles Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-styles
tags: styles,dialog,change
published: True
position: 1
---

# Styles Dialog

This dialog allows you to manage and apply the [styles]({%slug radrichtextbox-features-styles%}) used in the document.

![An image showing the styles dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-styles-0.png)

The dialog can be opened from the __Change Styles__ button in the __Home__ tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}).

![An image showing the button that opens the styles dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-styles-1.png)

## Showing the Dialog Manually

The dialog can be shown by executing the `ShowManageStylesDialogCommand`. See how to bind the command to an external button in the [Commands]({%slug radrichtextbox-features-commands%}) article.

#### __[C#] Executing the show dialog command__
{{region richtextbox-dialogs-styles-0}}
	this.richTextBox.Commands.ShowManageStylesDialogCommand.Execute(null);
{{endregion}}

Alternatively, call the `ShowManageStylesDialog` method of `RadRichTextBox`.

#### __[C#] Using the show dialog method__
{{region richtextbox-dialogs-styles-1}}
	this.richTextBox.ShowManageStylesDialog();
{{endregion}}