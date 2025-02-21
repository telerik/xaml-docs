---
title: Insert Symbol Dialog
page_title: Insert Symbol Dialog
description: Check our &quot;Insert Symbol Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-insert-symbol
tags: insert,symbol,special,characters
published: True
position: 1
---

# Insert Symbol Dialog

This dialog allows you to insert special symbols at the cursor position in the document.

![An image showing the insert symbol dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-insert-symbol-0.png)

The dialog can be opened from the __Symbol__ button in the __Insert__ tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}).

![An image showing the button that opens the insert symbol dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-insert-symbol-1.png)

## Showing the Dialog Manually

The dialog can be shown by executing the `ShowInsertSymbolWindowCommand`. See how to bind the command to an external button in the [Commands]({%slug radrichtextbox-features-commands%}) article.

#### __[C#] Executing the show dialog command__
{{region richtextbox-dialogs-insert-symbol-0}}
	this.richTextBox.Commands.ShowInsertSymbolWindowCommand.Execute(null);
{{endregion}}

Alternatively, call the `ShowInsertSymbolWindow` method of `RadRichTextBox`.

#### __[C#] Using the show dialog method__
{{region richtextbox-dialogs-insert-symbol-1}}
	this.richTextBox.ShowInsertSymbolWindow();
{{endregion}}