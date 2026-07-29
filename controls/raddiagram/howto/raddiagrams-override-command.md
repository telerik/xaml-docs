---
title: Override Diagram Command
page_title: Override Diagram Command
description: Check our &quot;Override Diagram Command&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagrams-howto-override-command
tags: override,delete,diagram,command,diagramcommands
published: True
position: 19
---

# Override Diagram Command

This article will show you how to override the default behavior of the commands used across the __RadDiagram__ control. 

The diagram uses the [DiagramCommands]({%slug raddiagrams-features-commands%}) class and its static [RoutedUICommands](https://msdn.microsoft.com/en-us/library/system.windows.input.routeduicommand(v=vs.110).aspx) to execute different actions like paste, delete, copy, undo, redo, etc. To replace the default behavior of a command you can use the standart approach for binding an action to a __RoutedUICommand__. 

The following steps describe how to override the __DiagramCommands.Delete__ command and implement a very basic deleting process from scratch. This approach can be used to override also other commands from the __DiagramCommands__ class or any other __RoutedUICommand__.

1. Define a new __CommandBinding__ object and register it using the __CommandManager__. The binding will be used to replace the default behavior of the command. You can do that in the static constructor of the window, UserControl or the application which uses the RadDiagram control.
	
	__Example 1: Defining CommandBinding__  
	<snippet id='raddiagram-howto-raddiagrams-override-command-example_1_defining_commandbinding-cs' />

	
2. Implement the __OnCanExecute__ handler of the command. Here you can decide whether the command can be executed or not.
	
	__Example 2: Implementing OnCanExecute__  
	<snippet id='raddiagram-howto-raddiagrams-override-command-example_2_implementing_oncanexecute-cs' />

	
3. Implement the __OnExecute__ handle of the command. Here is implemented the behavior of the command. The following code shows how to create very basic delete operation.
		
	__Example 3: Implementing OnExecute__  
	<snippet id='raddiagram-howto-raddiagrams-override-command-example_3_implementing_onexecute-cs' />

	
## Extend Diagram Command Action

You can use the __CommandExecuted__ event of RadDiagram to implement an additional action which will get invoked after the execution of a built-in command. The event arguments allows you to get the execute action and the command itself via the __Command__ and __ExecuteAction__ properties.

__Example 4: Implementing command execute handler__  
<snippet id='raddiagram-howto-raddiagrams-override-command-example_4_implementing_command_execute_handler-cs' />


## See Also
 * [Getting Started]({%slug raddiagram-getting-started%})
 * [Commands]({%slug raddiagrams-features-commands%})
 * [RoutedUICommand](https://msdn.microsoft.com/en-us/library/system.windows.input.routeduicommand(v=vs.110).aspx)
