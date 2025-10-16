---
title: Table of Contents Dialog
page_title: Table of Contents Dialog
description: Check our &quot;Table of Contents Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-contents-table
tags: link,insert,table,contents,toc
published: True
position: 1
---

# Table of Contents Dialog

This dialog allows you to insert a table of contents in the document.

![An image showing the table of contents dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-contents-table-0.png)

The dialog can be opened from the __Table of Contents__ button in the __References__ tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}).

![An image showing the button that opens the table of contents dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-contents-table-1.png)

## Showing the Dialog Manually

The dialog can be shown by executing the `ShowInsertTableOfContentsDialogCommand`. See how to bind the command to an external button in the [Commands]({%slug radrichtextbox-features-commands%}) article.

__Executing the show dialog command__
```C#
	this.richTextBox.Commands.ShowInsertTableOfContentsDialogCommand.Execute(null);
```

Alternatively, call the `ShowInsertTableOfContentsDialog` method of `RadRichTextBox`.

__Using the show dialog method__
```C#
	this.richTextBox.ShowInsertTableOfContentsDialog();
```