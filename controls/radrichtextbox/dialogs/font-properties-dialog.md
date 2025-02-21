---
title: Font Properties Dialog
page_title: Font Properties Dialog
description: Check our &quot;Font Properties Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-font-properties
tags: font,properties,dialog
published: True
position: 1
---

# Font Properties Dialog

This dialog allows you to edit the selected [font]({%slug radrichtextbox-features-fonts%}) for the current selection in the document.

![An image showing the font dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-font-properties-0.png)

The dialog can be opened from the dialog launcher button at the bottom right corner of the __Font__ group in the __Home__ tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}) or via the in the same option in the right-click menu (context menu) of `RadRichTextBox`.

![An image showing the button that opens the font dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-font-properties-1.png)

![An image showing the context menu that opens the font dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-font-properties-2.png)

## Showing the Dialog Manually

The dialog can be shown by executing the `ShowFontPropertiesDialogCommand`. See how to bind the command to an external button in the [Commands]({%slug radrichtextbox-features-commands%}) article.

#### __[C#] Executing the show dialog command__
{{region richtextbox-dialogs-font-properties-0}}
	this.richTextBox.Commands.ShowFontPropertiesDialogCommand.Execute(null);
{{endregion}}

Alternatively, call the `ShowFontPropertiesDialog` method of `RadRichTextBox`.

#### __[C#] Using the show dialog method__
{{region richtextbox-dialogs-font-properties-1}}
	this.richTextBox.ShowFontPropertiesDialog();
{{endregion}}