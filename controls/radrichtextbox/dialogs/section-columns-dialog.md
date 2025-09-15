---
title: Section Columns Dialog
page_title: Section Columns Dialog
description: Check our &quot;Section Columns Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-section-columns
tags: section, columns, text
published: True
position: 1
---

# Section Columns Dialog

This dialog allows you to arrange the text in the document into [columns]({%slug radrichtextbox-ui-for-applying-rich-text-formatting-section-columns%}).

![An image showing the section columns dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-section-columns-0.png)

The dialog can be opened from the __More Columns__ option in the __Page Layout__ tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}).

![An image showing the button that opens the section columns dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-section-columns-1.png)

## Showing the Dialog Manually

The dialog can be shown by executing the `ShowSectionColumnsDialogCommand`. See how to bind the command to an external button in the [Commands]({%slug radrichtextbox-features-commands%}) article.

__Executing the show dialog command__
```C#
	this.richTextBox.Commands.ShowSectionColumnsDialogCommand.Execute(null);
```

Alternatively, call the `ShowSectionColumnsDialog` method of `RadRichTextBox`.

__Using the show dialog method__
```C#
	this.richTextBox.ShowSectionColumnsDialog();
```