---
title: Customizing Commands
page_title: Customizing Commands
description: Customizing Commands
slug: radcollectionnavigator-customize-commands
tags: customizing,commands
published: True
position: 3
---

# Customizing Commands



This article provides a description and examples of how to customize commands for **RadCollectionNavigator** in a MVVM-friendly way. 
<Comment: Nothing in this article mentions MVVM. >
>Please note that this functionality is introduced with Q1 2016.


__Telerik.Windows.Controls.Data.CollectionNavigator.CollectionNavigatorBaseCommandProvider__ is a public class that exposes the “execute” and “can-execute” logic of all commands used by RadCollectionNavigator. RadCollectionNavigator processes these commands according to its current provider. Here is the set of methods that CollectionNavigatorBaseCommandProvider exposes:

##“Execute logic” methods

The methods listed in Example 1 identify the logic that is executed when a certain command’s invocation takes place.

#### __[C#]__ Example 1: RadCollectionNavigator`s executable commands  

	void MoveCurrentToFirst()
	void MoveCurrentToLast()
	void MoveCurrentToNext()
	void MoveCurrentToPrevious()
	void BeginEdit()
	void Delete()
	void AddNew()
	
##“Can-execute logic” methods

The methods listed in Example 2 help you can identify whether a certain command can be executed or not.

#### __[C#]__ Example 2:RadCollectionNavigator "can-execute" methods 

	bool CanMoveCurrentToFirstExecute()
	bool CanMoveCurrentToLastExecute()
	bool CanMoveCurrentToNextExecute()
	bool CanMoveCurrentToPreviousExecute()
	bool CanBeginEditExecute()
	bool CanDeleteExecute()
	bool CanAddNewExecute()


## Designing a custom CommandProvider
<Comment: I suggest you start with a sentence that describes why a customer might want to create a custom CommanProvider.>
The first step is to create your own class that inherits from CollectionNavigatorBaseCommandProvider:
<Comment: The caption for Example 3 is not descriptive. Which custom commands?>
#### __[C#]__ Example 3: Creating a class that provides the custom commands

{{region radcollectionnavigator-customize-commands_1}}

	public class CustomCommandProvider : CollectionNavigatorBaseCommandProvider
	{
		public CustomCommandProvider() : base(null)
		{
		}
	 
		public CustomCommandProvider(RadCollectionNavigator collectionNavigator)
            : base(collectionNavigator)
        {
            
        }
		//. . .
	}
	
	{{endregion}}



Those commands, which logic is up to get customized, should have their corresponding methods overridden. In the following example we will customize: MoveCurrentToNext, MoveCurrentToPrevious. <Comment: I do not know what "which logic is up to get customized" means.>

## MoveCurrentToNext and MoveCurrentToPrevious

In case we have a requirement to prompt for the user`s approval when moving through the items, the following change in the methods can be done:
<Comment: The caption in example 4 is not very descriptive and says nothing about what the example will show the reader.>
#### __[C#]__ Example 4: Overriding the default commands

{{region radcollectionnavigator-customize-commands_2}}

		public override void MoveCurrentToNext()
		{
			MessageBoxResult result = MessageBox.Show("MoveCurrentToNext ?", "MoveCurrentToNext", MessageBoxButton.OKCancel);
			if (result == MessageBoxResult.OK)
			{
				this.CollectionNavigator.MoveCurrentToNext();
			}
		}

		public override void MoveCurrentToPrevious()
		{
			MessageBoxResult result = MessageBox.Show("MoveCurrentToPrevious ?", "MoveCurrentToPrevious", MessageBoxButton.OKCancel);
			if (result == MessageBoxResult.OK)
			{
				this.CollectionNavigator.MoveCurrentToPrevious();
			}
		}
	
	{{endregion}}

The last thing to be done is to set the CommandProvider property of the RadCollectionNavigator to be the newly-created CustomCommandProvider class:
        

#### __[XAML]__ Example 5: Assigning the CommandProvider 

{{region radcollectionnavigator-customize-commands_3}}

	
	<telerik:RadCollectionNavigator x:Name="CollectionNavigator"
	                     			Source="{Binding Employees}"/>
	{{endregion}}



#### __[C#]__ Example 5: Assigning the CommandProvider 

{{region radcollectionnavigator-customize-commands_4}}

	this.CollectionNavigator.CommandProvider = new CustomCommandProvider(this.CollectionNavigator);
	{{endregion}}


Modifying the methods will result in the following action when trying to move to the next item:
<Comment: The sentence should describe what the action is for search. "will result in the following action" is not search friendly.>
![collectionnavigator 03](../images/collectionnavigator_03.png)

# See Also

* [Overview]({%slug collectionnavigator_overview%})

* [Getting Started]({%slug collectionnavigator_getting_started%})
