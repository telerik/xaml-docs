---
title: Commands
page_title: Commands
description: Check our &quot;Commands&quot; documentation article for the RadAIPrompt control.
slug: radaiprompt-commands
tags: commands, radaiprompt
published: True
position: 4
---

# Commands

`RadAIPrompt` provides several commands that you can utilize when working with the component. Furthermore, it allows you to define custom commands that will be displayed in a separate view to further personalize the control. 

The following list shows the commands that are exposed by the RadAIPrompt control:

* `PromptRequestCommand`&mdash;This command is executed when the input button is clicked.
* `SuggestionClickedCommand`&mdash;This command is executed when a suggestion from the Suggestions collection is clicked.
* `OutputItemCopyCommand`&mdash;This command is executed when the copy button of the generated response item is clicked.
* `OutputItemRetryCommand`&mdash;This command is executed when the retry button of the generated response item is clicked.
* `OutputItemRatingChangedCommand`&mdash;This command is executed when the rating of the generated response is changed through the UI.

The following example shows how to utilize one of the above-listed commands.

__Defining an ICommand property in the view model__
```C#
    public class MyViewModel
    {
        public MyViewModel()
        {
            this.PromptRequestCommand = new DelegateCommand(OnPromptRequestCommandExecuted);
        }
    
        public ICommand PromptRequestCommand { get; set; }
    
        private void OnPromptRequestCommandExecuted(object obj)
        {
            //Execute your logic here when the PromptRequestCommand of RadAIPrompt is executed
        }
    }
```

__Binding the view model ICommand to the PromptRequestCommand of RadAIPrompt__
```XAML
    <Grid>
        <Grid.DataContext>
            <local:MyViewModel/>
        </Grid.DataContext>
        <telerik:RadAIPrompt x:Name="aiPrompt"
                             PromptRequestCommand="{Binding PromptRequestCommand}">
            <telerik:RadAIPromptInputItem />
            <telerik:RadAIPromptOutputItem />
        </telerik:RadAIPrompt>
    </Grid>
```

## Configuring Custom Commands

The RadAIPrompt exposes the `Commands` collection. It allows you to provide a collection of objects deriving from the`AIPromptCommandBase` class that will be displayed in the [commands view]({%slug radaiprompt-views%}#commands-view) of the component.

The AIPromptCommandBase class provides the following properties:

* `Icon`&mdash;Allows you to display an icon for the command in the commands view. By default, a `Uri` that points to an svg image is expected. The svg is displayed via the [RadSvgImage]({%slug radsvgimage-overview%}) element. 
* `Text`&mdash;Allows you to specify a string that will display information about the command.

To add a logic that will be executed when the user interacts with the commands view's items, the RadAIPrompt provides two objects that extend the AIPromptCommandBase class. They are the `AIPromptCommand` and `AIPromptCommandGroup` objects.

### AIPromptCommand

This class exposes the `Command` property that will allow you to set an `ICommand` implementation to it. It will be raised when the User interacts with it. 

__Creating an AIPromptCommand instance__
```C#
    public class MyViewModel
    {
        public MyViewModel()
        {
    		AIPromptCommand simplifyCommand = new AIPromptCommand()
    		{
    			Command = new DelegateCommand(OnSimplifyCommandExecuted),
    			Text = "Simplify",
    		};

    		this.MyCommands = new ObservableCollection<AIPromptCommandBase>()
    		{
                simplifyCommand
            };
        }

        public ObservableCollection<AIPromptCommandBase> MyCommands { get; set; }

        private void OnSimplifyCommandExecuted(object obj)
        {
    		MessageBox.Show("SimplifyCommand Executed");
        }
    }
```

__Binding the custom commands collection to RadAIPrompt__
```XAML
    <Grid>
        <Grid.DataContext>
            <local:MyViewModel/>
        </Grid.DataContext>
        <telerik:RadAIPrompt x:Name="aiPrompt" Commands="{Binding MyCommands}">
            <telerik:RadAIPromptInputItem />
            <telerik:RadAIPromptOutputItem />
            <telerik:RadAIPromptCommandsItem />
        </telerik:RadAIPrompt>
    </Grid>
```

__RadAIPrompt with a custom commands collection__

![WPF RadAIPrompt with a custom commands collection](images/radaiprompt-commands-0.png)

### AIPromptCommandGroup

The `AIPromptCommandGroup` object provides the `Commands` collection property. It will allow you to group `AIPromptCommand` instances.

__Creating an AIPromptCommandGroup instance__
```C#
    public class MyViewModel
    {
        public MyViewModel()
        {
    		AIPromptCommand simplifyCommand = new AIPromptCommand()
    		{
    			Command = new DelegateCommand(OnSimplifyCommandExecuted),
    			Text = "Simplify"
    		};

            AIPromptCommand extendCommand = new AIPromptCommand()
            {
                Command = new DelegateCommand(OnExtendCommandExecuted),
                Text = "Extend"
            };

    		AIPromptCommandGroup aIPromptCommandGroup = new AIPromptCommandGroup()
    		{
    			Text = "Commands group"
    		};

    		List<AIPromptCommand> commands = new List<AIPromptCommand>()
    		{
    			simplifyCommand,
    			extendCommand
    		};

    		aIPromptCommandGroup.Commands = commands;

            this.MyCommands = new ObservableCollection<AIPromptCommandBase>()
    		{
                aIPromptCommandGroup
            };
        }

        public ObservableCollection<AIPromptCommandBase> MyCommands { get; set; }

        private void OnSimplifyCommandExecuted(object obj)
        {
    		MessageBox.Show("SimplifyCommand Executed");
        }

        private void OnExtendCommandExecuted(object obj)
        {
            MessageBox.Show("ExtendCommand Executed");
        }
    }
```

__RadAIPrompt with grouped commands__

![WPF RadAIPrompt with grouped commands](images/radaiprompt-commands-1.png)

## See Also
* [Views]({%slug radaiprompt-views%})
* [Events]({%slug radaiprompt-events%})
* [RadAIPromptButon]({%slug radaiprompt-prompt-button%})
* [Suggestions]({%slug radaiprompt-suggestions%})
* [Paging]({%slug radaiprompt-paging%})
