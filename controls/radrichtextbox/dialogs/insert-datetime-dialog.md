---
title: Insert Date and Time Dialog
page_title: Insert Date and Time Dialog
description: Check our &quot;Insert Date and Time Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-insert-date-time
tags: insert,date,time,datetime
published: True
position: 1
---

# Insert Date and Time Dialog

This dialog allows you to insert a date-time value in the document.

![An image showing the insert date and time Dialog dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-insert-date-time-0.png)

The dialog can be opened from the __Date & Time__ button in the __Insert__ tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}).

![An image showing the button that opens the insert date and time Dialog dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-insert-date-time-1.png)

## Showing the Dialog Manually

The dialog can be shown by executing the `ShowInsertDateTimeDialogCommand`. See how to bind the command to an external button in the [Commands]({%slug radrichtextbox-features-commands%}) article.

#### __[C#] Executing the show dialog command__
{{region richtextbox-dialogs-insert-date-time-0}}
	this.richTextBox.Commands.ShowInsertDateTimeDialogCommand.Execute(null);
{{endregion}}

Alternatively, call the `ShowInsertDateTimeDialog` method of `RadRichTextBox`.

#### __[C#] Using the show dialog method__
{{region richtextbox-dialogs-insert-date-time-1}}
	this.richTextBox.ShowInsertDateTimeDialog();
{{endregion}}