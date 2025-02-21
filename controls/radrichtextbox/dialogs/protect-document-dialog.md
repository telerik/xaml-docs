---
title: Protect Document Dialogs
page_title: Protect Document Dialog
description: Check our &quot;Protect Document Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-protect-document
tags: protect,document,restrict
published: True
position: 1
---

# Protect Document Dialogs

These dialogs allow you to [protect the document]({%slug radrichtextbox-features-document-protection%}) by adding a password or change the edit restrictions.

## Protect and Unprotect Document Dialogs

![An image showing the protect document dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-protect-document-0.png)

The protect document dialog can be opened from the __Protect Document__ button in the __Review__ tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}).

![An image showing the button that opens the protect document dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-protect-document-1.png)

If the document is protected with a password, the __Protect Document__ button will open the __Unprotect Document__ dialog.

![An image showing the button that opens the unprotect document dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-protect-document-2.png)

## Editing Restrictions Dialog

![An image showing the editing resitrctions dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-protect-document-3.png)

This dialog can be opened from the __Editing Restrictions__ button in the __Review__ tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}).

![An image showing the button that opens the editing restrictions dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-protect-document-4.png)

## Showing the Dialogs Manually

The dialog can be shown by executing the following commands:

* `ToggleDocumentProtectionCommand`
* `ShowChangeEditingPermissionsDialogCommand`

See how to bind the commands to external buttons in the [Commands]({%slug radrichtextbox-features-commands%}) article.

#### __[C#] Executing the show dialog command__
{{region richtextbox-dialogs-protect-document-0}}
	this.richTextBox.Commands.ToggleDocumentProtectionCommand.Execute();
	
	this.richTextBox.Commands.ShowChangeEditingPermissionsDialogCommand.Execute(null);
{{endregion}}

Alternatively, you can use the following methods of `RadRichTextBox`:

* `ShowProtectDocumentDialog`
* `ShowUnprotectDocumentDialog`
* `ShowChangeEditingPermissionsDialog`

#### __[C#] Using the show dialog method__
{{region richtextbox-dialogs-protect-document-1}}
	this.richTextBox.ShowProtectDocumentDialog();
	
	this.richTextBox.ShowChangeEditingPermissionsDialog();
{{endregion}}