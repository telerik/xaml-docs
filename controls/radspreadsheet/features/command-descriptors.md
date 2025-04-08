---
title: Command Descriptors
page_title: Command Descriptors
description: Describes how you can override the default command descriptors of RadSpreadsheet for WPF and create custom commands.
slug: radspreadsheet-command-descriptors
tags: command, descriptors
published: True
position: 0
---

# Command Descriptors

## Default Command Descriptors

__RadSpreadsheet__'s command descriptors are wrappers of its predefined set of commands. They were introduced as a way to easily enable/disable the commands based on the current document state. This comes in handy in the creation of UI for the RadSpreadsheet such as a ribbon, context menu, etc.
      

The __CommandDescriptor__ class contains 3 public properties:
      
* __IsEnabled__(Boolean): Gets or sets if the command is enabled.
* __Command__(ICommand): The command to be executed.
* __SelectedValue__(object): Gets or sets the selected value (if available for the current command). 

## Custom Command Descriptors

The following section demonstrates how you can create a custom command along with the respective command descriptor.

First you need to inherit the __WorksheetCommandDescriptors__ class. This will allow you to override the default commands properties and return your custom command. In this case, you will change the open file command with a custom one. If you want to override the key combination that triggers this command you should register the new command as well. 

#### __C# Example 1: Create a class that inherits WorksheetCommandDescriptors__

{{region radspreadsheet-command-descriptors_0}}

    class CustomDescriptors : WorksheetCommandDescriptors
    {
        private ICommand openCommand;
        private CommandDescriptor openFile;
        RadWorksheetEditor owner;
    
        public CustomDescriptors(RadWorksheetEditor owner) : base(owner)
        {
            this.owner = owner;
            InitializeCommands();
        }
        public override CommandDescriptor OpenFile
        {
            get
            {
                return openFile;
            }
        }
    
        private void InitializeCommands()
        {
            this.openCommand = new DelegateCommand((p) =>
            {
                MessageBox.Show("Open command executed.");
            });
            openFile = new CommandDescriptor(openCommand);
            this.owner.KeyBindings.RegisterCommand(new DelegateCommand(p => { this.openCommand.Execute(null); }), Key.O, ModifierKeys.Control, null);
    
        }
    }


{{endregion}}



The second step is to set the newly created class to the active worksheet editor. This should be done each time the editor is changed, this is why you are going to use the __ActiveSheetEditorChanged__ event to set the new descriptors. 

#### __C# Example 2: Change the default command descriptors__

{{region radspreadsheet-command-descriptors_1}}

    private void RadSpreadsheet_ActiveSheetEditorChanged(object sender, EventArgs e)
    {
        RadWorksheetEditor editor = (RadWorksheetEditor)this.radSpreadsheet.ActiveSheetEditor;
        if (editor != null)
        {
            editor.RadWorksheetCommandDescriptors = new CustomDescriptors(editor);
        }

    }



{{endregion}}

That is everything that is required to change the default command. Now when the open button is pressed or the Ctrl + O combination is used the custom command will be executed. 
