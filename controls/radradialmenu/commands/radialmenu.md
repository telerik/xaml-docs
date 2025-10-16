---
title: RadialMenu Commands
page_title: RadialMenu Commands
description: Check our &quot;RadialMenu Commands&quot; documentation article for the RadRadialMenu {{ site.framework_name }} control.
slug: radradialmenu-commands-radialmenu
tags: radialmenu,commands
published: True
position: 0
---

# RadialMenu Commands

__RadRadialMenu__ control supports the following commands: 

* __Open Command__ - executes before the RadRadialMenu opens;

* __Close Command__ -  executes before the RadRadialMenu closes;          

* __NavigateToView Command__ - executes before the user navigates to another view (child items). This command receives a context of type __NavigateContext__, which exposes the following properties:            

	* __MenuItemTarget__ - gets the current RadialMenuItem that has been clicked/tapped.              

	* __MenuItemSource__ - gets the previous (if any) RadialMenuItem that has been used to navigate through.     
	
* __NavigateBack Command__ - (introduced with Q2 2016) navigates back to the parent item of the current RadRadialMenuItem.

__Example 1__ demonstrates how to navigate to another view in the RadRadialMenu using the NavigateToView command:

__Example 1: Executing the NavigateToView command__

```C#
	NavigateContext context = new NavigateContext(menuItem);
	this.radialMenu.CommandService.ExecuteCommand(Telerik.Windows.Controls.RadialMenu.Commands.CommandId.NavigateToView, context);
```

When the command executes the RadialMenu will navigate to the item passed as a parameter to the constructor of the NavigateContext class.

>tip When the RadRadialMenu is defined as a context menu, you can use the commands exposed through the [RadialMenuCommands]({%slug radradialmenu-features-contextmenu%}#using-the-static-radialmenucommands-class) class to show/close it.

## Custom Commands

__RadRadialMenu__ exposes a commands collection that allows you to register custom commands with each control's instance through the __RadRadialMenu.Commands__ property.        

To implement a command you need to create a class that derives from the __RadialMenuCommand__ class and override the __CanExecute__ and __Execute__ methods.        

__RadialMenuCommand__ class exposes the following properties:        

* __Id__ - this value is used to associate a command with a known event within a RadRadialMenu instance;          

* __Owner__ - gets the RadRadialMenu instance that has executed this command.          

>importantCustom commands have higher priority than the default commands.

The next example will show how to implement custom command that will be executed when the user navigates to the children of a menu item:

1. First, create a custom class that inherits from the __RadialMenuCommand__ class. You need to set the __Id__ of the command to specify when it will be executed. If you wish to execute the default behavior, then you have to call the __Owner.CommandService.ExecuteDefaultCommand__ method in the __Execute__ method of the command as shown in __Example 2__. 

	__Example 2: Creating a custom command__

	```C#
		public class CustomMenuCommand : RadialMenuCommand
		{
		    public CustomMenuCommand()
		    {
		        this.Id = CommandId.NavigateToView;
		    }
		
		    public override void Execute(object parameter)
		    {
		        base.Execute(parameter);
		        var context = parameter as NavigateContext;
		        var source = context.MenuItemSource; // parent menu item
		        var target = context.MenuItemTarget; // current menu item
		
		        // put your custom command logic here
		
		        this.Owner.CommandService.ExecuteDefaultCommand(CommandId.NavigateToView, context);
		    }
		
		    public override bool CanExecute(object parameter)
		    {
		        return true;
		    }
		}
	```

1. Then you have to define an instance of the custom command class in the __Commands__ collection of the __RadRadialMenu__ as demonstrated in __Example 3__.            

	__Example 3: Setting the custom command__

	```XAML
		<telerik:RadRadialMenu>
		    <telerik:RadRadialMenu.Commands>
		        <local:CustomMenuCommand />
		    </telerik:RadRadialMenu.Commands>
		    <telerik:RadRadialMenuItem Header="Item 1" >
		        <telerik:RadRadialMenuItem Header="Item 1.1">
		            <telerik:RadRadialMenuItem Header="Item 1.1.1" />
		        </telerik:RadRadialMenuItem>
		        <telerik:RadRadialMenuItem Header="Item 1.2" >
		            <telerik:RadRadialMenuItem Header="Item 1.2.1" />
		        </telerik:RadRadialMenuItem>
		    </telerik:RadRadialMenuItem>
		</telerik:RadRadialMenu>
	```

## See Also

 * [RadialMenuItem Commands]({%slug radradialmenu-commands-radialmenuitem%})
