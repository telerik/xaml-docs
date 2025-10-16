---
title: Commands
page_title: Commands
description: The article describes the available commands exposed by RadCardView.
slug: radcardview-features-commands
tags: commands,cardview
published: True
position: 3
---

# Commands

RadCardView provides a set of built-in commands that enables you to easily handle the user interface actions, but still make your logic independent of the UI layout. Thus, you are not obliged to subscribe to a particular event in order to achieve the desired behavior.

All supported commands are defined in the static `RadCardViewCommands` class and are listed below:

* `BeginEdit`&mdash;Invokes editing of the current item. Press the __F2__ or __Enter__ keys to invoke it via the keyboard.
* `CommitEdit`&mdash;Forces all the changes to be committed. If the RadCardView is currently in edit mode, pressing the __Enter__ key will invoke this command.
* `CancelEdit`&mdash;Causes the editing of the item to be discontinued. If the RadCardView is currently in edit mode, pressing the __Escape__ key will invoke this command.
* `MoveUp`, `MoveDown`&mdash;Moves the selection to the item situated above/below the selected one. You can also invoke these commands by pressing the __Up__ or __Down__ arrow keys.
* `MoveLeft`, `MoveRight`&mdash;Moves the selection to the item situated on the left/right side of the selected one. You can also invoke these commands by pressing the __Left__ or __Right__ arrow keys.
* `MoveFirst`, `MoveLast`&mdash;Moves the selection to the first/last item on the current row/column (depending on the [CardLayout]({%slug radcardview-features-layout%}) property). Executed when pressing the __Home__ or __End__ keys.
* `MoveNext`, `MovePrevious`&mdash;Moves the selection to the next/previous item with regards to its position in the collection. The MoveNext command is also invoked when pressing the __Tab__ key. The MovePrevious is invoked when holding the __Shift__ key and pressing the __Tab__ one.
* `MoveHome`, `MoveEnd`&mdash;Moves the selection to the first/last item in the collection. Executed when holding the __Control__ key and pressing the __Home__ or __End__ keys.
* `MovePageUp`, `MovePageDown`&mdash;Moves the __focus__ to the item situated one viewport away from the current item. Executed when pressing the __PageUp__ or __PageDown__ keys.
* `MoveTop`, `MoveBottom`&mdash;Moves the selection to the item situated in the first/last item. Executed when holding the __Control__ key and pressing the __PageUp__ or __PageDown__ keys.
* `SelectCurrentItem`&mdash;Selects the current item.
* `ExpandCardViewItem`, `CollapseCardViewItem`&mdash;Expands/collapses the selected item. Takes as a parameter the item to be expanded/collapsed. If no parameter is provided, the SelectedItem is expanded/collapsed.

As the commands provided by RadCardView are `ICommands` at their core, they do provide methods for  both checking if they can be invoked - `CanExecute` and for invoking them - `Execute`.

Using the RadCardViewCommands class, you can set a sequence of commands to be performed one after another.  So, for example, you may easily handle the `Click` event of a button, move the selection down and then collapse it. However, when invoking the commands in such a manner a second parameter should be added, pointing out the target UI Element as shown in the following example:

__Executing different commands__  
```C#
	private void Button1_Click(object sender, RoutedEventArgs e)
    {
		var moveDownCommand = RadCardViewCommands.MoveDown as RoutedUICommand;
		var collapseCommand = RadCardViewCommands.CollapseCardViewItem as RoutedUICommand;
		moveDownCommand.Execute(null, this.cardView);
		collapseCommand.Execute(null, this.cardView);
    }
```

In order to ensure that all commands will be executed in the correct sequence, it is advised to use RadCardView's `PendingCommands` collection as demonstrated below:

__Executing different commands with the ExecutePendingCommand method__  
```C#
	private void Button2_Click(object sender, RoutedEventArgs e)
	{
		this.cardView.PendingCommands.Add(RadCardViewCommands.MoveDown);
		this.cardView.PendingCommands.Add(RadCardViewCommands.CollapseCardViewItem);
		this.cardView.ExecutePendingCommand();
	}
```

## Keyboard Command Provider

RadCardView provides a set of keyboard navigation scenarios that will result in certain consequence of commands to be executed. However, in case you require them not to be invoked at all or to utilize different commands, you may take advantage of the `IKeyboardCommandProvider` interface and implement your custom logic. 
Thus, you will be able to change the behavior of all keys. The hurdle here is the requirement for predefining each one of the commands. 

Another approach for accomplishing the purpose will be to create a separate class, inheriting the `DefaultKeyboardCommandProvider` and overriding the `ProvideCommandsForKey` method. In this way only the undesired behavior can be adjusted according to your requirements.

The custom class responsible for the update of the commands needs to be similar to the one below:

__Defining the custom IKeyboardCommandProvider__  
```C#
	public class CustomKeyboardCommandProvider : DefaultKeyboardCommandProvider
	{
	    private RadCardView parentCardView;
	
	    public CustomKeyboardCommandProvider(RadCardView cardView)
	     : base(cardView)
	    {
	        this.parentCardView = cardView;
	    }
	
	    public override IEnumerable<ICommand> ProvideCommandsForKey(Key key)
	    {
	        List<ICommand> commandsToExecute = base.ProvideCommandsForKey(key).ToList();
	
	        if (key == Key.Enter)
	        {
	            commandsToExecute.Clear();
	            commandsToExecute.Add(RadCardViewCommands.CommitEdit);
	            commandsToExecute.Add(RadCardViewCommands.MoveNext);
	            commandsToExecute.Add(RadCardViewCommands.BeginEdit);
	        }
	
	        return commandsToExecute;
	    }
	}
```

Following up the code-snippet above, a press of Enter key will result in saving the current changes,
moving the focus to the next item and editing it. However, do not forget to remove the predefined
commands for that particular key by calling the `Clear` method.

The last thing to be done is to set `KeyboardCommandProvider` property of the RadCardView control to be the newly-created CustomKeyboardCommandProvider class:

__Setting the KeyboardCommandProvider property__  
```C#
	this.cardView.KeyboardCommandProvider = new CustomKeyboardCommandProvider(this.cardView);
```

## See Also  
* [Getting Started]({%slug radcardview-getting-started%})
* [Filtering]({%slug radcardview-features-filtering%})
* [Grouping]({%slug radcardview-features-grouping%})