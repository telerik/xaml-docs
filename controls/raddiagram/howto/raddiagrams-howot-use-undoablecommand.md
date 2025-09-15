---
title: Execute Undoable Action
page_title: Execute Undoable Action
description: Check our &quot;Execute Undoable Action&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagrams-howto-execute-undoable-action
tags: undo,redo,stack,undoablgedelegatecommand,rotate,rotationangle,shape
published: True
position: 20
---

# Execute Undoable Action

This article will show you how to execute an undoable action. By default the diagram pushes only some actions in its undo/redo stack. Those undoable actions are performed when the user interacts with the diagram using the input device (the mouse or the keyboard for example). If you do something in code as setting a property or calling a method, the action won't be added in the undo/redo stack. To alter this you can use the diagram's __UndoRedoService__ along with the __UndoableDelegateCommnad__ class.

## Executing UndoableDelegateCommand

The constructor of the command expects a name and two actions to execute - the original action and the undo action.

__Example 1: Executing command__
```C#
	UndoRedoService service = radDiagram.ServiceLocator.GetService<IUndoRedoService>() as UndoRedoService;
	UndoableDelegateCommand undoableCommand = new UndoableDelegateCommand("MyUndoableCommand",
		(o) => {
			// set the new status
		},
		(o) => {
			// set the previous status
		});
	service.ExecuteCommand(undoableCommand);
```

If you press __Ctrl+Z__ after the command is executed the undo action will kick in.
	
> This approach could be used in an MVVM scenario to push actions executed over the GraphSource (add,remove, etc. from the view model) in the undo/redo stack.

## Example

This section contains a runnable code which demonstrates how to create an undoable action for setting a RadDiagramShape property in code-behind. After the ExecuteCommand is called you can use Ctrl+Z to call the undo action and revert the command effect.

__Example 2: Defining the view__
```XAML
	<Grid>
		<Grid.RowDefinitions>
			<RowDefinition />
			<RowDefinition Height="Auto" />
		</Grid.RowDefinitions>
		<telerik:RadDiagram x:Name="diagram">
			<telerik:RadDiagramShape Position="100 100" x:Name="shape"/>
		</telerik:RadDiagram>
		<Button Content="Rotate the shape" Grid.Row="1" Click="Button_Click" />
	</Grid>    
```
	
__Example 3: Setting a property of RadDiagramShape using a command__
```C#
	private void Button_Click(object sender, RoutedEventArgs e)
	{
		UndoRedoService service = diagram.ServiceLocator.GetService<IUndoRedoService>() as UndoRedoService;
		UndoableDelegateCommand undoableCommand = new UndoableDelegateCommand("ChangeRotatonAngleCommand",
			(o) => {
				this.shape.RotationAngle += 45;
			},
			(o) => {
				this.shape.RotationAngle -= 45;
			});
		service.ExecuteCommand(undoableCommand);            
	}
```

## See Also
 * [Getting Started]({%slug raddiagram-getting-started%})
 * [Commands]({%slug raddiagrams-features-commands%})
 * [Services]({%slug raddiagram-features-services%})