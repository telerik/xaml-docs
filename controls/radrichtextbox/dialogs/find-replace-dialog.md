---
title: Find and Replace Dialog
page_title: Find and Replace Dialog
description: Check our &quot;Find and Replace Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-find-replace
tags: find,replace,search
published: True
position: 1
---

# Find and Replace Dialog

The find and replace dialog allows you find text and replace it if needed.

![An image showing the find and replace dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-find-replace-0,png)

The dialog can be opened from the __Find/Replace__ button in the __Home__ tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}).

![An image showing the button that opens the find and replace dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-find-replace-0.png)

## Showing the Dialog Manually

The dialog can be shown by executing the `ShowFindReplaceDialogCommand`. See how to bind the command to an external button in the [Commands]({%slug radrichtextbox-features-commands%}) article.

#### __[C#] Executing the show dialog command__
{{region richtextbox-dialogs-find-replace-0}}
	this.richTextBox.Commands.ShowFindReplaceDialogCommand.Execute(null);
{{endregion}}

Alternatively, call the `ShowFindReplaceDialog` method of `RadRichTextBox`.

#### __[C#] Using the show dialog method__
{{region richtextbox-dialogs-find-replace-1}}
	this.richTextBox.ShowFindReplaceDialog();
{{endregion}}

## See Also  
* [Search in Document]({%slug radrichtextbox-features-search%})
