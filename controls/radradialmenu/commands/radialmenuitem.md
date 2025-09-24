---
title: RadialMenuItem Commands
page_title: RadialMenuItem Commands
description: Check our &quot;RadialMenuItem Commands&quot; documentation article for the RadRadialMenu {{ site.framework_name }} control.
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

	```C#
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
	```

1. Add an instance of the custom command class to the Resources of the UserControl.

	```XAML
		<UserControl.Resources>
		    <local:CustomItemCommand x:Key="CustomItemCommand"/>
		</UserControl.Resources>
	```

1. Bind the __Command__ property of the RadialMenuItem to the instance of the custom command as shown in __Example 3__.          

	```XAML
		<telerik:RadRadialMenu>
		    <telerik:RadRadialMenuItem Header="Item 1" Command="{StaticResource CustomItemCommand}" 
		    CommandParameter="{Binding RelativeSource={RelativeSource Self}}" />
		    <telerik:RadRadialMenuItem Header="Item 2" Command="{StaticResource CustomItemCommand}" 
		    CommandParameter="{Binding RelativeSource={RelativeSource Self}}" />
		    <telerik:RadRadialMenuItem Header="Item 3" Command="{StaticResource CustomItemCommand}" 
		    CommandParameter="{Binding RelativeSource={RelativeSource Self}}" />
		</telerik:RadRadialMenu>
	```

## See Also

 * [RadialMenu Commands]({%slug radradialmenu-commands-radialmenu%})
