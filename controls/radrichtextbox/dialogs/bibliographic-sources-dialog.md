---
title: Manage Bibliographic References Dialog
page_title: Manage Bibliographic Sources Dialog
description: Check our &quot;Manage Bibliographic References Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-bibliographic-sources
tags: link,insert,bibliographic,references,dialog
published: True
position: 1
---

# Manage Bibliographic References Dialog

This dialog allows you to insert and edit [bibliographic references]({%slug radrichtextbox-features-bibliographic-references%}) in the document.

![An image showing the bibliographic references dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-bibliographic-sources-0.png)

![An image showing the bibliographic references dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-bibliographic-sources-1.png)

The insert bibliographic dialog can be opened from the __Add New Source__ option of the __Insert Citation__ drop down button in the __References__ tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}) or via the in the same option in the right-click menu (context menu) of `RadRichTextBox`.

The manage bibliographic references can be opened with the __Manage Sources__ button.

![An image showing the button that opens the bibliographic references dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-hyperlink-2.png)

## Showing the Dialog Manually

The dialogs can be shown by executing the `ShowManageBibliographicSourcesDialogCommand` and `ShowAddNewBibliographicReferenceDialogCommand`. See how to bind the commands to external buttons in the [Commands]({%slug radrichtextbox-features-commands%}) article.

#### __[C#] Executing the show dialog command__
{{region richtextbox-dialogs-bibliographic-sources-0}}
	this.richTextBox.Commands.ShowManageBibliographicSourcesDialogCommand.Execute(null);
{{endregion}}

Alternatively, you can call the `ShowAddNewBibliographicSourceDialog` and `ShowManageBibliographicSourcesDialog` methods of `RadRichTextBox`.

#### __[C#] Using the show dialog method__
{{region richtextbox-dialogs-bibliographic-sources-1}}
	this.richTextBox.ShowAddNewBibliographicSourceDialog();
{{endregion}}