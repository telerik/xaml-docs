---
title:  Update Current Color in UI
page_title:  Update Current Color in UI
description:  Update Current Color in UI
slug: radrichtextbox-how-to-update
tags: update,current,color,in,ui
published: True
position: 4
---

# Update Current Color in UI

The **FormattingColorPicker** is a color picker, which allows you to update the currently selected color of the content in the UI. It tracks the current color of the document element to update the selected color accordingly and it is used in **RadRichTextBox** to apply fore color, highlight color and paragraph background color.

![Rad Rich Text Box Update Current Color in UI 0](images/RadRichTextBox-Update-Current-Color-in-UI_0.png)

## Using FormattingColorPicker

To use **FormattingColorPicker** you will need to add a reference to the **Telerik.Windows.Controls.RichTextBoxUI** assembly.

**Example 1** demonstrates how to add the control to your XAML and bind it to a command.

#### __[XAML] Example 1: Add FormattingColorPicker__

{{region radrichtextbox-how-to-update-current-color-in-ui_0}}

	<telerik:FormattingColorPicker ActiveColor="Red" telerik:RadRichTextBoxRibbonUI.RichTextCommand="{Binding ChangeFontForeColorCommand}"/>
{{endregion}}



>tipTo learn more about the commands exposed by the __RadRichTextBox__ and how to use them read [here]({%slug radrichtextbox-features-commands%}).


### ActiveColor property

This property gets or sets the active color which is shown on the bottom part of the drop down button. It keeps the currently selected color and it is updated according to the position of the caret.

# See Also

* [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%})

* [Commands in RadRichTextBox]({%slug radrichtextbox-features-commands%})