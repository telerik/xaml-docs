---
title: Override Diagram Command
page_title: Override Diagram Command
description: Override Diagram Command
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
	
	#### __[C#] Example 1: Defining CommandBinding__  
		static MainPage()
		{
			var commandBinding = new CommandBinding(
                DiagramCommands.Delete, 
                OnDiagramDeleteCommandExecute, 
                OnDiagramDeleteCommandCanExecute);
            CommandManager.RegisterClassCommandBinding(typeof(RadDiagram), commandBinding);
		}
	
2. Implement the __OnCanExecute__ handler of the command. Here you can decide whether the command can be executed or not.
	
	#### __[C#] Example 2: Implementing OnCanExecute__  
		static void OnDiagramDeleteCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			// Here you can implement additional logic that decides whether the command should be executed or not
			e.CanExecute = true;
			e.Handled = true;
		}
	
3. Implement the __OnExecute__ handle of the command. Here is implemented the behavior of the command. The following code shows how to create very basic delete operation.
		
	#### __[C#] Example 3: Implementing OnCanExecute__  	
		static void OnDiagramDeleteCommandExecute(object sender, ExecutedRoutedEventArgs e)
        {
            var diagram = (RadDiagram)sender;             
            while (diagram.SelectedItems.Count() > 0)
            {
                var item = diagram.SelectedItems.ElementAt(diagram.SelectedItems.Count() - 1);
                if (item is RadDiagramContainerShape)
                {
                    RemoveContainerShapeChildren(diagram, (RadDiagramContainerShape)item);                    
                }
                diagram.Items.Remove(item);
            }
        }

        static void RemoveContainerShapeChildren(RadDiagram diagram, RadDiagramContainerShape container)
        {
            while (container.Items.Count > 0)
            {                
                diagram.Items.Remove(container.Items[container.Items.Count - 1]);
            }         
        }

## See Also
 * [Getting Started]({%slug raddiagram-getting-started%})
 * [Commands]({%slug raddiagrams-features-commands%})
 * [RoutedUICommand](https://msdn.microsoft.com/en-us/library/system.windows.input.routeduicommand(v=vs.110).aspx)