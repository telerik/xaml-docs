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



This article provides a description and examples of how to customize RadCollectionNavigator’s commands in a MVVM-friendly way. 

>Please note that Telerik introduced this functionality in Q1 2016.

## 

__Telerik.Windows.Controls.Data.CollectionNavigator.CollectionNavigatorBaseCommandProvider__ is a public class that exposes the “execute” and “can-execute” logic of all commands used by RadCollectionNavigator. RadCollectionNavigator processes these commands according to its current provider. Here is the set of methods that CollectionNavigatorBaseCommandProvider exposes:

*“Execute logic” methods*

The methods listed below identify the logic that is executed when a certain command’s invocation takes place.

#### __[C#]__ Example 1: RadCollectionNavigator's executable commands  

	void MoveCurrentToFirst()
	void MoveCurrentToLast()
	void MoveCurrentToNext()
	void MoveCurrentToPrevious()
	void BeginEdit()
	void Delete()
	void AddNew()
	
*“Can-execute logic” methods*

With the help of those methods you can identify whether a certain command can be executed or not.

#### __[C#]__ Example 2:RadCollectionNavigator "can-execute" methods 

	bool CanMoveCurrentToFirstExecute()
	bool CanMoveCurrentToLastExecute()
	bool CanMoveCurrentToNextExecute()
	bool CanMoveCurrentToPreviousExecute()
	bool CanBeginEditExecute()
	bool CanDeleteExecute()
	bool CanAddNewExecute()


## Designing a custom CommandProvider

The first step is to create your own class that inherits from CollectionNavigatorBaseCommandProvider.

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



Those commands, which logic is up to get customized, should have their corresponding methods overridden. In the following example we will customize: MoveCurrentToNext, MoveCurrentToPrevious.
<<Comment: This phrase, "which logic is up to get customized," does not make sense to me. Please revise and have another team member review it.>>
## MoveCurrentToNext and MoveCurrentToPrevious

If we have a requirement to prompt for the user's approval when moving through the items, the following change in the methods can be done:

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

The last thing to be done is to set the CommandProvider property of the RadCollectionNavigator to be the newly-created CustomCommandProvider class.
        

#### __[XAML]__ Example 5: Assigning the CommandProvider 

{{region radcollectionnavigator-customize-commands_3}}

	
	<telerik:RadCollectionNavigator x:Name="CollectionNavigator"
	                     			Source="{Binding Employees}"/>
	{{endregion}}



#### __[C#]__ Example 5: Assigning the CommandProvider 

{{region radcollectionnavigator-customize-commands_4}}

	this.CollectionNavigator.CommandProvider = new CustomCommandProvider(this.CollectionNavigator);
	{{endregion}}


Modifying the methods will result in the action shown in the image below when trying to move to the next item:

![collectionnavigator 03](../images/collectionnavigator_03.png)

# See Also

* [Overview]({%slug collectionnavigator_overview%})

* [Getting Started]({%slug collectionnavigator_getting_started%})
