---
title: Add Clear Button to WatermarkTextBox
description: How to add a button which clears the text of the WatermarkTextBox Control.
page_title: Button to Clear The Text of the WatermarkTextBox Control
type: how-to
slug: kb-watermarktextbox-add-clear-button
position: 0
tags: watermarktextbox, add, clear, button
ticketid: 1581294
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2022.3.912</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadWatermarkTextBox for WPF</td>
	</tr>
</table>

## Description

How to add a clear button to the RadWatermarkTextBox control.

## Solution

You can add a button as the `AdditionalContent` of the RadWatermarkTextBox control and bind its `Command` property to the `RadWatermarkTextBoxCommands.Clear` command.

__Add clear button as AdditionalContent__ 
```XAML
	<telerik:RadWatermarkTextBox.AdditionalContent>
		<telerik:RadButton Focusable="False" IsBackgroundVisible="False"
							Command="telerik:RadWatermarkTextBoxCommands.Clear"
							CommandTarget="{Binding RelativeSource={RelativeSource AncestorType=telerik:RadWatermarkTextBox}}"
							Visibility="{Binding RelativeSource={RelativeSource AncestorType=telerik:RadWatermarkTextBox}, Path=Text, Converter={StaticResource NullToVisibilityConverter}}">
			<telerik:RadGlyph Glyph="{StaticResource GlyphClose}"/>
		</telerik:RadButton>
	</telerik:RadWatermarkTextBox.AdditionalContent>
```

## See Also
* [AdditionalContent]({%slug radwatermarktextbox-features%}#clear-command)