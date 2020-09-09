---
title: How to Close the Active Pane with a Key Combination
description: This article explains how to bind the CloseActivePane command to a key combination in order to close the currently active pane.
type: how-to
page_title: Using the CloseActivePane Command to Close the Currently Active Pane
slug: kb-docking-close-active-pane-command
position: 0
tags: docking, close, active, pane, command
ticketid: 1350663
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2020.3.916</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadDocking for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to close the active pane with a key combination.

## Solution

As of **R3 2020**, you can use the new **CloseActivePane** command to close the currently active pane.

#### __[XAML] Example 1: Binding the CloseActivePane to Ctrl+F4 for a single RadDocking instance__

{{region xaml-kb-docking-close-active-pane-command_1}}
    <telerik:RadDocking>
		<!-- ... -->
		<telerik:RadDocking.InputBindings>
			<KeyBinding Command="telerik:RadDockingCommands.CloseActivePane" Key="F4" Modifiers="Ctrl" />
		</telerik:RadDocking.InputBindings>
	</telerik:RadDocking>
{{endregion}}

You can also bind the command for all RadDocking controls in your application by using the **CommandManager.RegisterClassInputBinding** method.

#### __[C#] Example 2: Binding the CloseActivePane to Ctrl+F4 for all RadDocking controls in the application__

{{region cs-kb-docking-close-active-pane-command_2}}
	public App()
	{
		KeyBinding keyBinding = new KeyBinding(RadDockingCommands.CloseActivePane, new KeyGesture(Key.F4, ModifierKeys.Control));
		CommandManager.RegisterClassInputBinding(typeof(RadDocking), keyBinding);
	}
{{endregion}}

## See Also
* [Navigator]({%slug raddocking-navigator%})