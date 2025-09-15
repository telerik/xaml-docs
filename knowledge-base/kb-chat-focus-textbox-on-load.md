---
title: Setting focus to RadChat on load
description: How to focus RadChat textbox on load.
type: how-to
page_title: Providing Focus to RadChat
slug: kb-chat-focus-textbox-on-load
position: 0
tags: chat, textbox, focus, load
ticketid: 1402627
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2019.1.220</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadChat for WPF</td>
	</tr>
</table>


## Description

How to set focus to RadChat on load.

## Solution

Access the __RadWatermarkTextBox__ inside the RadChat, using the [ChildrenOfType]({%slug common-visual-tree-helpers%}) extension method and focus it. This can be achieved in the __Loaded__ event of the control.


```XAML
	<telerik:RadChat x:Name="chat" Loaded="chat_Loaded" />
```


```C#
	private void chat_Loaded(object sender, RoutedEventArgs e)
    {
        var chat = sender as RadChat;
        var watermarkTextBox = chat.ChildrenOfType<RadWatermarkTextBox>().FirstOrDefault(tb => tb.Name == "PART_InputBox");
        watermarkTextBox.Focus();
    }
```
