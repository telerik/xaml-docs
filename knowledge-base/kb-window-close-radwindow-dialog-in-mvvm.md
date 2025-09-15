---
title: How to close RadWindow dialog in MVVM using custom button
description: Closing a RadWindow dialog from within the command that is being executed from a custom button specified in the template.
type: how-to
page_title: Using button command to close a RadWindow dialog in MVVM.
slug: kb-window-close-radwindow-dialog-in-mvvm
position: 0
tags: window,close, mvvm, button, custom, template
ticketid: 313798
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2019.1.116</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadWindow for WPF</td>
	</tr>
</table>

## Description

How to close a RadWindow Confirm dialog in MVVM scenario using custom button.

## Solution

1. Create a custom style which targets RadConfirm (for example) dialog. 
2. Override the ControlTemplate by specifying your own one. You can add your button. 
3. Bind the command property of the button to your custom command using RelativeSource binding. 
4. To close the dialog in the executed method you need to pass the RadWindow to the CommandParameter using the same approach with RelativeSource binding. 


```XAML
	<Style TargetType="telerik:RadConfirm">
	    <Setter Property="IsTabStop" Value="False"/>
	    <Setter Property="MinWidth" Value="275"/>
	    <Setter Property="MaxWidth" Value="500"/>
	    <Setter Property="SnapsToDevicePixels" Value="True"/>
	    <Setter Property="Template">
		<Setter.Value>
		    <ControlTemplate TargetType="telerik:RadConfirm">
			<!--Your custom template-->
			<telerik:RadButton Content=" My Button" Command="{Binding Content.MyCommand,RelativeSource={RelativeSource Mode=FindAncestor,AncestorType=telerik:RadConfirm}}" CommandParameter="{Binding RelativeSource={RelativeSource AncestorType=telerik:RadWindow,Mode=FindAncestor}}"/>
		    </ControlTemplate>
		</Setter.Value>
	    </Setter>
	</Style>
```

The final step is to call the executed method of the window.


```C#
	public class MainViewModel
	{
		public ICommand MyCommand { get; set; }
		public MainViewModel()
		{
			MyCommand = new DelegateCommand(OnCommandExecuted);
		}

		private void OnCommandExecuted(object obj)
		{
			var window = obj as RadWindow;
			window.Close();
		}
	}
```
