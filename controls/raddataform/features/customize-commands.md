---
title: Customizing Commands
page_title: Customizing Commands
description: Customizing Commands
slug: raddataform-customize-commands
tags: customizing,commands
published: True
position: 3
---

# Customizing Commands



This article provides a description and examples of how to customize RadDataForm’s commands in MVVM-friendly way. 

>Please note that this functionality is introduced with Q1 2013.

## 

__Telerik.Windows.Controls.Data.DataForm.DataFormCommandProvider__ is a public class that exposes the “execute” and “can-execute” logic of all commands, utilized by RadDataForm. RadDataForm processes these commands according to its current provider. Here is the set of methods that DataFormCommandProvider exposes:“Execute logic” methods

The methods listed bellow identify the logic that is executed when a certain command’s invocation takes place.

#### __C#__

{{region raddataform-customize-commands_0}}
	void MoveCurrentToFirst()
	void MoveCurrentToLast()
	void MoveCurrentToNext()
	void MoveCurrentToPrevious()
	void BeginEdit()
	void CommitEdit()
	void Delete()
	void CancelEdit()
	void AddNew()
	{{endregion}}

“Can-execute logic” methods

With the help of those methods you can identify whether a certain command can be executed or not.

#### __C#__

{{region raddataform-customize-commands_1}}
	bool CanMoveCurrentToFirstExecute()
	bool CanMoveCurrentToLastExecute()
	bool CanMoveCurrentToNextExecute()
	bool CanMoveCurrentToPreviousExecute()
	bool CanBeginEditExecute()
	bool CanCommitEditExecute()
	bool CanDeleteExecute()
	bool CanCancelEditExecute()
	bool CanAddNewExecute()
	{{endregion}}



A runnable demo that utilizes the code from this article can be found on
          {% if site.site_name == 'Silverlight' %}[this online demo](http://demos.telerik.com/silverlight/#DataForm/CustomCommandsProvider){% endif %}{% if site.site_name == 'WPF' %}[the DataForm's CustomCommandsProvider demo](http://demos.telerik.com/wpf/){% endif %}.
        

## Designing a custom CommandProvider

The first step is to create your own class that inherits from DataFormCommandProvider:

#### __C#__

{{region raddataform-customize-commands_2}}
	public class CustomCommandProvider : DataFormCommandProvider
	{
		public CustomCommandProvider() : base(null)
		{
		}
	 
		public CustomCommandProvider(RadDataForm dataForm)
				: base(dataForm)
		{
			this.DataForm = dataForm;
		}
		//. . .
	}
	
	{{endregion}}



Those commands, which logic is up to get customized, should have their corresponding methods overridden. In the following example we will customize: MoveCurrentToNext, MoveCurrentToPrevious, BeginEdit and CancelEdit.

## MoveCurrentToNext and MoveCurrentToPrevious

We aim at changing their execution logic, in order to start editing the item, as soon as it was set as a current one and bypass the logic in the same place. Here are the overridden methods:

#### __C#__

{{region raddataform-customize-commands_3}}
	protected override void MoveCurrentToNext()
	{
		if (this.DataForm != null)
		{
			this.DataForm.MoveCurrentToNext();
			this.DataForm.BeginEdit();
		}
	}
	 
	protected override void MoveCurrentToPrevious()
	{
		if (this.DataForm != null)
		{
			this.DataForm.MoveCurrentToPrevious();
			this.DataForm.BeginEdit();
		}
	}
	
	{{endregion}}



## CommitEdit and CancelEdit

A common requirement for data form is to add __confirmation message boxes when CRUD operations are executed__. Here we will do a similar thing with the CommitEdit/CancelEdit commands.

#### __C#__

{{region raddataform-customize-commands_4}}
	protected override void CommitEdit()
	{
		MessageBoxResult result = MessageBox.Show("Commit changes for the current edit item?", "CommitEdit confirmation", MessageBoxButton.OKCancel);
		if (result == MessageBoxResult.OK)
		{
			if (this.DataForm != null && this.DataForm.ValidateItem())
			{
				this.DataForm.CommitEdit();
			}
		}			
	}
	 
	protected override void CancelEdit()
	{
		MessageBoxResult result = MessageBox.Show("Cancel changes for the current edit item?", "CancelEdit confirmation", MessageBoxButton.OKCancel);
		if (result == MessageBoxResult.OK)
		{
			if (this.DataForm != null)
			{
				this.DataForm.CancelEdit();
			}
		}	
	}
	
	{{endregion}}



The last thing to be done is to set CommandProvider Property of the RadDataForm to be the newly-created CustomKeyboardCommandProvider class:
        

#### __XAML__

{{region raddataform-customize-commands_10}}
	 <Window.Resources>
	    <my:CustomCommandProvider x:Key="CustomProvider"/>
	</Window.Resources>
	
	<telerik:RadDataForm x:Name="RadDataForm1"
	                     ItemsSource="{Binding Employees}" 
	                     CommandProvider="{StaticResource CustomProvider}"/>
	{{endregion}}



#### __C#__

{{region raddataform-customize-commands_5}}
	this.RadDataForm1.CommandProvider = new CustomCommandProvider(this.RadDataForm1);
	{{endregion}}



# See Also
