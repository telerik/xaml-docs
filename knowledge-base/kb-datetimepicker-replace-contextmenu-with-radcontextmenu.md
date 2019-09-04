---
title: How to replace ContextMenu with RadContextMenu in RadDateTimePicker
description: Replacing ContextMenu with RadContextMenu in RadDateTimePicker
type: how-to
page_title: Replacing ContextMenu with RadContextMenu in RadDateTimePicker
slug: kb-datetimepicker-replace-contextmenu-with-radcontextmenu
position: 
tags: 
ticketid: 1427861
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2018.3.911</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadDateTimePicker for WPF</td>
	    </tr>
    </tbody>
</table>


## Description
How to replace ContextMenu with RadContextMenu in RadDateTimePicker.

## Solution
To replace the ContextMenu with RadContextMenu to disable the ContextMenu that comes from the RadWatermarkTextBox in the ControlTemplate of the RadDateTimePicker and add a RadContextMenu instead with the EventName="PreviewMouseRightButtonDown" property set.

#### __[XAML]__
{{region kb-datetimepicker-replace-contextmenu-with-radcontextmenu-0}}
	<telerik:RadWatermarkTextBox ContextMenu="{x:Null}">
        <telerik:RadContextMenu.ContextMenu>
            <telerik:RadContextMenu EventName="PreviewMouseRightButtonDown">
                <telerik:RadMenuItem Command="ApplicationCommands.Cut" />
                <telerik:RadMenuItem Command="ApplicationCommands.Copy"  />
                <telerik:RadMenuItem Command="ApplicationCommands.Paste" />
            </telerik:RadContextMenu>
        </telerik:RadContextMenu.ContextMenu>
    </telerik:RadWatermarkTextBox>
{{endregion}}
