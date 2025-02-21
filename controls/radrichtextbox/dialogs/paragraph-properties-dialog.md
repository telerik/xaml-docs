---
title: Paragraph Properties
page_title: Paragraph Properties Dialog
description: Check our &quot;Paragraph Properties Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-paragraph-properties
tags: link,insert
published: True
position: 1
---

# Paragraph Properties Dialog

This dialog allows you edit the settings of the current (where the caret is positioned) [paragraph]({%slug radrichtextbox-features-document-elements-paragraph%}) in the document.

![An image showing the paragraph properties dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-paragraph-properties-0.png)

The dialog can be opened from the dialog launcher button at the bottom right corner of the __Paragraph__ group in the __Home__ tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}) or via the in the same option in the right-click menu (context menu) of `RadRichTextBox`.

![An image showing the button that opens the paragraph properties dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-paragraph-properties-1.png)

![An image showing the context menu that opens the paragraph properties dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-paragraph-properties-2.png)

The paragraph properties dialog allows you to open the __Tab Stops__ dialog via its __Tabs__ button.

![An image showing the tab stops dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-paragraph-properties-3.png)

## Showing the Dialog Manually

The dialog can be shown by executing the `ShowParagraphPropertiesDialogCommand`. See how to bind the command to an external button in the [Commands]({%slug radrichtextbox-features-commands%}) article.

#### __[C#] Executing the show dialog command__
{{region richtextbox-paragraph-properties-0}}
	this.richTextBox.Commands.ShowParagraphPropertiesDialogCommand.Execute(null);
{{endregion}}

Alternatively, call the `ShowParagraphPropertiesDialog` method of `RadRichTextBox`.

#### __[C#] Using the show dialog method__
{{region richtextbox-paragraph-properties-1}}
	this.richTextBox.ShowParagraphPropertiesDialog();
{{endregion}}

The __Tab Stops__ dialog can be manually opened with the `ShowTabStopsPropertiesDialogCommand` or with the `ShowTabStopsPropertiesDialog` method of `RadRichTextBox`.
