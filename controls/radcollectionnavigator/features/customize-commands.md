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

The methods listed below in Example 1 identify the logic that is executed when a certain command’s invocation takes place.

#### __[C#] Example 1: RadCollectionNavigator's executable commands__  

	void MoveCurrentToFirst()
	void MoveCurrentToLast()
	void MoveCurrentToNext()
	void MoveCurrentToPrevious()
	void BeginEdit()
	void Delete()
	void AddNew()
	
*“Can-execute logic” methods*

With the help of the methods listed in *Example 2* you can identify whether a certain command can be executed or not.

#### __[C#] Example 2:RadCollectionNavigator "can-execute" methods__ 

	bool CanMoveCurrentToFirstExecute()
	bool CanMoveCurrentToLastExecute()
	bool CanMoveCurrentToNextExecute()
	bool CanMoveCurrentToPreviousExecute()
	bool CanBeginEditExecute()
	bool CanDeleteExecute()
	bool CanAddNewExecute()


## Designing a custom CommandProvider

The first step is to create your own class that inherits from CollectionNavigatorBaseCommandProvider.

#### __[C#] Example 3: Creating a class that provides the custom commands__

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



You need to override the methods of the commands that will be customized. In the following example we will customize: MoveCurrentToNext, MoveCurrentToPrevious.

## MoveCurrentToNext and MoveCurrentToPrevious

If we have a requirement to prompt for the user's approval when moving through the items, the following change in the methods can be done:

#### __[C#] Example 4: Overriding the default commands__ 

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
        

#### __[XAML] Example 5: Assigning the CommandProvider__ 

{{region radcollectionnavigator-customize-commands_3}}

	
	<telerik:RadCollectionNavigator x:Name="CollectionNavigator"
	                     			Source="{Binding Employees}"/>
	{{endregion}}



#### __[C#] Example 5: Assigning the CommandProvider__ 

{{region radcollectionnavigator-customize-commands_4}}

	this.CollectionNavigator.CommandProvider = new CustomCommandProvider(this.CollectionNavigator);
	{{endregion}}


Modifying the methods will result in the action shown in the image below when trying to move to the next item:

![collectionnavigator 03](../images/collectionnavigator_03.png)

# See Also

* [Overview]({%slug collectionnavigator_overview%})

* [Getting Started]({%slug collectionnavigator_getting_started%})
