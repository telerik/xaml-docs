---
title: Commands
page_title: Commands
description: Check our &quot;Commands&quot; documentation article for the RadFileDialogs {{ site.framework_name }} control.
slug: radfiledialogs-features-commands
tags: filtering,features,radopenfiledialog,radsavefiledialog
published: True
position: 5
---

# Commands

The file dialogs suite provides several commands used to interact with the controls. All commands can be found in the __FileDialogsCommands__ static class. The commands are attached to the controls' operations as copy, cut, open folder/file, delete, etc. 

If you use the __ExplorerControl__ it might be useful to execute the commands manually in some cases. To do so, you can call the __Execute()__ method of the corresponding ICommand implementation. Alternatively, you can set the command to the Command property of a button or a similar component.

> All commands in the FileDialogsCommands class are objects of type [RoutedUICommand](https://msdn.microsoft.com/en-us/library/system.windows.input.routeduicommand(v=vs.110).aspx).

__Example 1: Executing a command in code__
```C#
	RoutedUICommand command = (RoutedUICommand)FileDialogsCommands.Delete;
	command.Execute(this.explorerControl, this.explorerControl);
```

__Example 2: Assigning a command to a Button in XAML__
```XAML
	<Grid>
        <fileDialogs:ExplorerControl x:Name="explorerControl"/>
        <Button Command="fileDialogs:FileDialogsCommands.Delete"
                CommandParameter="{Binding ElementName=explorerControl}"
                CommandTarget="{Binding ElementName=explorerControl}"
                Content="Delete"/>
    </Grid>
```

## List of Commands

* __NewFolder Command__: This command creates a new folder in the current directory. It is executed when you press the [New Folder Button]({%slug radfiledialogs-visual-structure%}) or call the command manually as shown in __Examples 1 and 2__.

* __Edit Command__: This command starts the edit mode of the selected file/folder. It is executed when you press __F2__ or call the command manually as shown in __Examples 1 and 2__.

* __Copy Command__: This command copies a file/folder from the clipboard if available. It is executed when you press __Ctrl+C__ or call the command manually as shown in __Examples 1 and 2__.

* __Cut Command__: This command cuts the selected file/folder. It is executed when you press __Ctrl+X__ or call the command manually as shown in __Examples 1 and 2__.

* __Paste Command__: This command pastes a file/folder from the clipboard if available. It is executed when you press __Ctrl+V__ or call the command manually as shown in __Examples 1 and 2__.

* __Delete Command__: This command deletes the selected file/folder. It is executed when you press the __Delete__ key or call the command manually as shown in __Examples 1 and 2__.

> Most of those commands are also available in the context menu opened on right mouse click in the dialog control.

## Cancel Keyboard Commands

To cancel the command executed for a specific key or a keycombo you can handle the __PreviewKeyDown event__ of the dialog control.

__Example 3: Canceling Delete command in ExplorerControl__
```C#
	private void ExplorerControl_PreviewKeyDown(object sender, KeyEventArgs args)
	{
		if (args.Key == Key.Delete)
		{
			args.Handled = true;
		}
	}
```

__Example 4: Canceling Delete command in a dialog control__
```XAML
	RadOpenFileDialog openFileDialog = new RadOpenFileDialog();
	openFileDialog.Owner = this;
	openFileDialog.PreviewKeyDown += (s, args) =>
	{
		if (args.Key == Key.Delete)
		{
			args.Handled = true;
		}
	};
	openFileDialog.ShowDialog();
```

## See Also

 * [Getting Started]({%slug radfiledialogs-getting-started%})
 * [RadOpenFileDialog]({%slug radfiledialogs-radopenfiledialog%})
 * [RadOpenFolderDialog]({%slug radfiledialogs-radopenfolderdialog%})
 * [RadSaveFileDialog]({%slug radfiledialogs-radsavefiledialog%})
