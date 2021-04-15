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

All supported commands are defined in the static **RadCardViewCommands** class and are listed below:

* **BeginEdit**: Invokes editing of the current item.

* **CommitEdit**: Forces all the changes to be committed.

* **CancelEdit**: Causes the editing of the item to be discontinued.

* **MoveUp, MoveDown**: Moves the selection to the item situated above/below the selected one.

* **MoveFirst, MoveLast**: Moves the selection to the first/last item on the current row/column (depending on the [CardLayout]({%slug radcardview-features-layout%}) property).

* **MoveLeft, MoveRight**: Moves the selection to the item situated on the left/right side of the selected one.

* **MoveNext, MovePrevious**: Moves the selection to the next/previous item with regards to its position in the collection.

* **MoveHome, MoveEnd**: Moves the selection to the first/last item in the collection.

* **MovePageUp, MovePageDown**: Moves the **focus** to the item situated one viewport away from the current item.

* **MoveTop, MoveBottom**: Moves the selection to the item situated in the first/last item.

* **SelectCurrentItem**: Selects the current item.

* **ExpandCardViewItem, CollapseCardViewItem**: Expands/collapses the selected item. Takes as a parameter the item to be expanded/collapsed. If no parameter is provided, the SelectedItem is expanded/collapsed.

As the commands provided by __RadCardView__ are __ICommands__ at their core, they do provide methods for  both checking if they can be invoked - __CanExecute()__ and for invoking them - __Execute()__.

Using the __RadCardViewCommands__ class, you can set a sequence of commands to be performed one after another.  So, for example, you may easily handle the **Click** event of a button, move the selection down and then collapse it. However, when invoking the commands in such a manner a second parameter should be added, pointing out the target UI Element as shown in **Example 1**.

#### __[C#] Example 1: Executing different commands__  
{{region cs-radcardview-features-commands_0}}
	private void Button1_Click(object sender, RoutedEventArgs e)
    {
		var moveDownCommand = RadCardViewCommands.MoveDown as RoutedUICommand;
		var collapseCommand = RadCardViewCommands.CollapseCardViewItem as RoutedUICommand;
		moveDownCommand.Execute(null, this.cardView);
		collapseCommand.Execute(null, this.cardView);
    }
{{endregion}}

In order to ensure that all commands will be executed in the correct sequence, it is advised to use RadCardView's **PendingCommands** collection as demonstrated in **Example 2**.

#### __[C#] Example 2: Executing different commands with the ExecutePendingCommand method__  
{{region cs-radcardview-features-commands_1}}
	private void Button2_Click(object sender, RoutedEventArgs e)
	{
		this.cardView.PendingCommands.Add(RadCardViewCommands.MoveDown);
		this.cardView.PendingCommands.Add(RadCardViewCommands.CollapseCardViewItem);
		this.cardView.ExecutePendingCommand();
	}
{{endregion}}

## Keyboard Command Provider

__RadCardView__ provides a set of keyboard navigation scenarios that will result in certain consequence of commands to be executed. However, in case you require them not to be invoked at all or to utilize different commands, you may take advantage of the __IKeyboardCommandProvider__ interface and implement your custom logic. 
Thus, you will be able to change the behavior of all keys. The hurdle here is the requirement for predefining each one of the commands. 

Another approach for accomplishing the purpose will be to create a separate class, inheriting the __DefaultKeyboardCommandProvider__ and overriding the __ProvideCommandsForKey (Key key)__ method. In this way only the undesired behavior can be adjusted according to your requirements.

The custom class responsible for the update of the commands needs to be similar to the one below:

#### __[C#] Example 3: Defining the custom IKeyboardCommandProvider__  

{{region cs-radcardview-features-commands_2}}
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
{{endregion}}

Following up the code-snippet above, a press of Enter key will result in saving the current changes,
moving the focus to the next item and editing it. However, do not forget to remove the predefined
commands for that particular key by calling the __Clear()__ method.

The last thing to be done is to set __KeyboardCommandProvider__ property of the __RadCardView__ to be the newly-created __CustomKeyboardCommandProvider__ class:

#### __[C#] Example 4: Setting the KeyboardCommandProvider property__  

{{region cs-radcardview-features-commands_3}}
	this.cardView.KeyboardCommandProvider = new CustomKeyboardCommandProvider(this.cardView);
{{endregion}}

## See Also  
* [Getting Started]({%slug radcardview-getting-started%})
* [Filtering]({%slug radcardview-features-filtering%})
* [Grouping]({%slug radcardview-features-grouping%})