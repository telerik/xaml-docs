---
title: How to Disable RadExpander Header Click
description: This article demonstrates how to disable the header click of the RadExpander.
type: how-to
page_title: Cancel the Action of the RadExpander Header upon Button Click 
slug: kb-expander-disable-header-click
position: 0
tags: expander, disable, click, header
ticketid: 1452587
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadExpander for WPF</td>
	</tr>
</table>

## Description

How to disallow the clicking of the RadExpander's header.

## Solution

To achieve this requirement you can set the **IsHitTestVisible** property of the header button to **False**. This will prevent the propagation of mouse events to the button. To set the property of the button, you can use the **HeaderButtonStyle** property of RadExpander.

__Example 1: Disable header button click__
    ```XAML
        <telerik:RadExpander.HeaderButtonStyle>
            <Style TargetType="telerik:RadToggleButton">
                <Setter Property="IsHitTestVisible" Value="False" />
            </Style>
        </telerik:RadExpander.HeaderButtonStyle>
    ```

## See Also
* [How To Change the Action Triggering an Expand]({%slug radexpander-howto-change-expand-action%})