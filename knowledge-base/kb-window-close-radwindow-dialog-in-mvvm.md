---
title: How to close RadWindow dialog in MVVM using custom button
description: 
type: how-to
page_title: 
slug: kb-window-close-radwindow-dialog-in-mvvm
position: 
tags: 
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

Create a custom style which targets RadConfirm dialog. Then override the ControlTemplate by specifying your own one. You can add your button. Then you can bind the command property of the button to your custom command using RelativeSource binding. To close the dialog in the executed method we need to pass the RadWindow to the CommandParameter using the same approach with RelativeSource binding. 

#### __[XAML]__
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
{{endregion}}

The final step is to call the executed method of the window.

#### __[C#]__
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
{{endregion}}