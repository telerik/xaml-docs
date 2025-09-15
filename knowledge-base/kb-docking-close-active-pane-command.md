---
title: How to Close the Active Pane with a Key Combination
description: This article explains how to bind the ClosePane command to a key combination in order to close the currently active pane.
type: how-to
page_title: Using the ClosePane Command to Close the Currently Active Pane
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

As of **R3 2020**, you can use the new **ClosePane** command to close the currently active pane. The command accepts a parameter of type **ClosePaneMode** which has three possible values:

* **DocumentPanes**: The active document pane is closed or if there is no active, the first selected document pane is closed.
* **NonDocumentPanes**: The active non-document pane is closed, if any.
* **ActivePanes**: The active pane is closed, if any.

If no parameter is passed, the command will close the currently active pane, if there is such.

__Example 1: Binding the ClosePane to Ctrl+F4 for a single RadDocking instance__

```XAML
    <telerik:RadDocking>
		<!-- ... -->
		<telerik:RadDocking.InputBindings>
			<KeyBinding Command="telerik:RadDockingCommands.ClosePane" CommandParameter="DocumentPanes" Key="F4" Modifiers="Ctrl" />
		</telerik:RadDocking.InputBindings>
	</telerik:RadDocking>
```

You can also bind the command for all RadDocking controls in your application by using the **CommandManager.RegisterClassInputBinding** method.

__Example 2: Binding the ClosePane to Ctrl+F4 for all RadDocking controls in the application__

```C#
	public App()
	{
		KeyBinding keyBinding = new KeyBinding(RadDockingCommands.ClosePane, new KeyGesture(Key.F4, ModifierKeys.Control)) { CommandParameter = ClosePaneMode.DocumentPanes };
		CommandManager.RegisterClassInputBinding(typeof(RadDocking), keyBinding);
	}
```

## See Also
* [Navigator]({%slug raddocking-navigator%})
