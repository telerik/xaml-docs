---
title: Watermark Settings
page_title: Watermark Settings Dialog
description: Check our &quot;Watermark Settings Dialog&quot; documentation article for the RadRichTextBox WPF control.
slug: richtextbox-dialogs-watermark-settings
tags: link,insert,watermark
published: True
position: 1
---

# Watermark Settings Dialog

This dialog allows you to insert [watermarks]({%slug radrichtextbox-features-watermark%}) in the document.

![An image showing the watermark settings dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-watermark-settings-0.png)

The dialog can be opened using the __Watermark__ drop down button in the __Page Layout__ tab of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}).

![An image showing the button that opens the watermark settings dialog of RadRichTextBox for WPF](images/richtextbox-dialogs-watermark-settings-1.png)

## Showing the Dialog Manually

The dialog can be shown by executing the `ShowWatermarkSettingsDialogCommand`. See how to bind the command to an external button in the [Commands]({%slug radrichtextbox-features-commands%}) article.

__Executing the show dialog command__
```C#
	this.richTextBox.Commands.ShowWatermarkSettingsDialogCommand.Execute(null);
```

Alternatively, call the `ShowWatermarkSettingsDialog` method of `RadRichTextBox`.

__Using the show dialog method__
```C#
	this.richTextBox.ShowWatermarkSettingsDialog();
```