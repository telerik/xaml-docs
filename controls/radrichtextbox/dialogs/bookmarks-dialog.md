---
title: Bookmarks Dialog
page_title: Bookmarks Dialog
description: Check our &quot;Bookmarks Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-bookmarks
tags: link,insert
published: True
position: 1
---

# Bookmarks Dialog

This allows you to insert and edit [bookmarks]({%slug radrichtextbox-features-document-elements-bookmarks%}) in the document.

![An image showing the bookmarks dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-bookmarks-0.png)

The dialog can be opened from the __Bookmark__ button in the __Insert__ tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}).

![An image showing the button that opens the bookmarks dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-bookmarks-1.png)

## Showing the Dialog Manually

The dialog can be shown by executing the `ShowManageBookmarksDialogCommand`. See how to bind the command to an external button in the [Commands]({%slug radrichtextbox-features-commands%}) article.

__Executing the show dialog command__
```C#
	this.richTextBox.Commands.ShowManageBookmarksDialogCommand.Execute(null);
```

Alternatively, call the `ShowManageBookmarksDialog` method of `RadRichTextBox`.

__Using the show dialog method__
```C#
	this.richTextBox.ShowManageBookmarksDialog();
```
