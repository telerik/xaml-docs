---
title: Spell Checking
page_title: Spell Checking Dialog
description: Check our &quot;Spell Checking Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-spell-checking
tags: spell, checking, typo
published: True
position: 1
---

# Spell Checking Dialog

This dialog allows you to [spell check]({%slug radrichtextbox-features-spellcheck%}) the text in the document.

![An image showing the spell checking dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-spell-checking-0.png)

The dialog can be opened from the __Spell Check__ button in the __Review__ tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}) or via the in the same option in the right-click menu (context menu) of `RadRichTextBox`.

![An image showing the button that opens the spell checking dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-spell-checking-1.png)

![An image showing the context menu that opens the spell checking dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-spell-checking-2.png)

## Showing the Dialog Manually

The dialog can be shown by executing the `ShowSpellCheckingDialogCommand`. See how to bind the command to an external button in the [Commands]({%slug radrichtextbox-features-commands%}) article.

__Executing the show dialog command__
```C#
	this.richTextBox.Commands.ShowSpellCheckingDialogCommand.Execute(null);
```

Alternatively, call the `ShowSpellCheckingDialog` method of `RadRichTextBox`.

__Using the show dialog method__
```C#
	this.richTextBox.ShowSpellCheckingDialog();
```