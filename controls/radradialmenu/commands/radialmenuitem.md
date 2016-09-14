---
title: RadialMenuItem Commands
page_title: RadialMenuItem Commands
description: RadialMenuItem Commands
slug: radradialmenu-commands-radialmenuitem
tags: radialmenuitem,commands
published: True
position: 1
---

# RadialMenuItem Commands

__RadRadialMenuItem__ provides a __Command__ property that can be bound to an __ICommand__ implementation. The execution of the command is triggered by click/tap event. The parameter passed to the command is set through the __CommandParameter__ property of the RadialMenuItem.        

## Create a Command

Here is an example demonstrating how to add a command to a RadialMenuItem.

1. First, create a class that implements the __ICommand__ interface. __Example 1__ shows a sample implementation.          

	#### __[C#] Example 1: Creating a command__

	{{region cs-radradialmenu-commands-radialmenuitem_0}}
		public class CustomItemCommand : ICommand
		{
		    public bool CanExecute(object parameter)
		    {
		        var radialMenuItem = parameter as RadRadialMenuItem;
		        if (radialMenuItem != null)
		        {
		            // perform custom logic here
		        }
		        return true;
		    }
		
		    public void Execute(object parameter)
		    {
		        var radialMenuItem = parameter as RadRadialMenuItem;
		        if (radialMenuItem != null)
		        {
		            // perform custom logic here                
		        }
		    }
		
		    public event EventHandler CanExecuteChanged;
		}
	{{endregion}}

1. Add an instance of the custom command class to the Resources of the UserControl.

	#### __[XAML] Example 2: Adding the command to the Resources__

	{{region xaml-radradialmenu-commands-radialmenuitem_1}}
		<UserControl.Resources>
		    <local:CustomItemCommand x:Key="CustomItemCommand"/>
		</UserControl.Resources>
	{{endregion}}

1. Bind the __Command__ property of the RadialMenuItem to the instance of the custom command as shown in __Example 3__.          

	#### __[XAML] Example 3: Bind the command__

	{{region xaml-radradialmenu-commands-radialmenuitem_2}}
		<telerik:RadRadialMenu>
		    <telerik:RadRadialMenuItem Header="Item 1" Command="{StaticResource CustomItemCommand}" 
		    CommandParameter="{Binding RelativeSource={RelativeSource Self}}" />
		    <telerik:RadRadialMenuItem Header="Item 2" Command="{StaticResource CustomItemCommand}" 
		    CommandParameter="{Binding RelativeSource={RelativeSource Self}}" />
		    <telerik:RadRadialMenuItem Header="Item 3" Command="{StaticResource CustomItemCommand}" 
		    CommandParameter="{Binding RelativeSource={RelativeSource Self}}" />
		</telerik:RadRadialMenu>
	{{endregion}}

# See Also

 * [RadialMenu Commands]({%slug radradialmenu-commands-radialmenu%})
