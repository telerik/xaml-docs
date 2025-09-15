---
title: Enabling Keyboard Shortcuts for RadMenu
description: Learn how to implement keyboard shortcuts for RadMenu items in WPF applications, ensuring functionality across the entire application window.
type: how-to
page_title: How to Add Keyboard Shortcuts to RadMenu Items
slug: kb-menu-enable-keyboard-shortcuts
tags: radmenu, wpf, keyboard, shortcuts, inputbindings, command
res_type: kb
ticketid: 1639610
---

## Environment

| Product | Version |
| --- | --- |
| RadMenu for WPF | Current |

## Description

How to enable keyboard shortcuts for RadMenu items using the WPF KeyBinding objects.

## Solution

In WPF, in order to recieve a `KeyDown` event, the corresponding element needs to be focused. Since `RadMenu` is usually not constantly focused, you cannot rely on its `KeyDown` event. Instead, you can use the `KeyDown` of the host `Window`.

To add shortcuts for the menu, you can add `KeyBinding` objects in the host `Window`'s `InputBindings` collection. 


```XAML
	<Window x:Class="MyWpfApplication.MainWindow"
			xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
			xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
			xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
			xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
			xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
			mc:Ignorable="d"
			Title="MainWindow" Height="450" Width="800">
		<Window.InputBindings>
			<KeyBinding Gesture="Ctrl+N" Command="{Binding MyAddNewCommand}"/>
			<KeyBinding Gesture="Ctrl+E" Command="{Binding MyEditCommand}"/>
			<KeyBinding Gesture="Ctrl+S" Command="{Binding MySaveCommand}"/>
		</Window.InputBindings>
		<Grid>
			<telerik:RadMenu VerticalAlignment="Top">
				<telerik:RadMenuItem Header="New" InputGestureText="Ctrl+N" />
				<telerik:RadMenuItem Header="Edit" InputGestureText="Ctrl+E"/>
				<telerik:RadMenuItem Header="Save" InputGestureText="Ctrl+S"/>
			</telerik:RadMenu>
		</Grid>
	</Window>
```

