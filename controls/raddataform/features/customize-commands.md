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


__Telerik.Windows.Controls.Data.DataForm.DataFormCommandProvider__ is a public class that exposes the “execute” and “can-execute” logic of all commands, utilized by RadDataForm. RadDataForm processes these commands according to its current provider. Here is the set of methods that DataFormCommandProvider exposes:“Execute logic” methods

## Execute Logic Methods

The methods listed below identify the logic that is executed when a certain command’s invocation takes place.

#### __[C#] Example 1: The IExecuteLogicMethods__

{{region raddataform-customize-commands_0}}

    public interface IExecuteLogicMethods
    {
        void MoveCurrentToFirst();
        void MoveCurrentToLast();
        void MoveCurrentToNext();
        void MoveCurrentToPrevious();
        void BeginEdit();
        void CommitEdit();
        void Delete();
        void CancelEdit();
        void AddNew();
    }
	{{endregion}}

#### __[VB.NET] Example 1: The IExecuteLogicMethods__

{{region raddataform-customize-commands_6}}

    Public Interface IExecuteLogicMethods
        Sub MoveCurrentToFirst()
        Sub MoveCurrentToLast()
        Sub MoveCurrentToNext()
        Sub MoveCurrentToPrevious()
        Sub BeginEdit()
        Sub CommitEdit()
        Sub Delete()
        Sub CancelEdit()
        Sub AddNew()
    End Interface
	{{endregion}}

## "Can-Execute Logic" Methods

With the help of those methods you can identify whether a certain command can be executed or not.

#### __[C#] Example 2: The ICanExecuteLogicMethods__

{{region raddataform-customize-commands_1}}

    public interface ICanExecuteLogicMethods
    {
        bool CanMoveCurrentToFirstExecute();
        bool CanMoveCurrentToLastExecute();
        bool CanMoveCurrentToNextExecute();
        bool CanMoveCurrentToPreviousExecute();
        bool CanBeginEditExecute();
        bool CanCommitEditExecute();
        bool CanDeleteExecute();
        bool CanCancelEditExecute();
        bool CanAddNewExecute();
    }
	{{endregion}}

#### __[VB.NET] Example 2: The ICanExecuteLogicMethods__

{{region raddataform-customize-commands_7}}

    Public Interface ICanExecuteLogicMethods
        Function CanMoveCurrentToFirstExecute() As Boolean
        Function CanMoveCurrentToLastExecute() As Boolean
        Function CanMoveCurrentToNextExecute() As Boolean
        Function CanMoveCurrentToPreviousExecute() As Boolean
        Function CanBeginEditExecute() As Boolean
        Function CanCommitEditExecute() As Boolean
        Function CanDeleteExecute() As Boolean
        Function CanCancelEditExecute() As Boolean
        Function CanAddNewExecute() As Boolean
    End Interface
	{{endregion}}


A runnable demo that utilizes the code from this article can be found on {% if site.site_name == 'Silverlight' %}[this online demo](http://demos.telerik.com/silverlight/#DataForm/CustomCommandsProvider){% endif %}{% if site.site_name == 'WPF' %}[the DataForm's CustomCommandsProvider demo](http://demos.telerik.com/wpf/){% endif %}.
        

## Designing a custom CommandProvider

The first step is to create your own class that inherits from **DataFormCommandProvider**:

#### __[C#] Example 3: Defining a Custom CommandProvider__

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

#### __[VB.NET] Example 3: Defining a Custom CommandProvider__

{{region raddataform-customize-commands_8}}

    Public Class CustomCommandProvider
        Inherits DataFormCommandProvider
        Public Sub New()
            MyBase.New(Nothing)
        End Sub

        Public Sub New(dataForm As RadDataForm)
            MyBase.New(dataForm)
            Me.DataForm = dataForm
        End Sub
        '. . .
    End Class
	{{endregion}}


Those commands, which logic is up to get customized, should have their corresponding methods overridden. In the following example we will customize: **MoveCurrentToNext**, **MoveCurrentToPrevious**, **BeginEdit** and **CancelEdit**.

## MoveCurrentToNext and MoveCurrentToPrevious

We aim at changing their execution logic, in order to start editing the item, as soon as it was set as a current one and bypass the logic in the same place. Here are the overridden methods:

#### __[C#] Example 4: Customizing MoveCurrentToNext and MoveCurrentToPrevious__

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

#### __[VB.NET] Example 4: Customizing MoveCurrentToNext and MoveCurrentToPrevious__

{{region raddataform-customize-commands_9}}

    Protected Overrides Sub MoveCurrentToNext()
        If Me.DataForm IsNot Nothing Then
            Me.DataForm.MoveCurrentToNext()
            Me.DataForm.BeginEdit()
        End If
    End Sub

    Protected Overrides Sub MoveCurrentToPrevious()
        If Me.DataForm IsNot Nothing Then
            Me.DataForm.MoveCurrentToPrevious()
            Me.DataForm.BeginEdit()
        End If
    End Sub
	{{endregion}}

## CommitEdit and CancelEdit

A common requirement for data form is to add __confirmation message boxes when CRUD operations are executed__. Here we will do a similar thing with the CommitEdit/CancelEdit commands.

#### __[C#] Example 5: Customizing CommitEdit and CancelEdit__

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

#### __[VB.NET] Example 5: Customizing CommitEdit and CancelEdit__

{{region raddataform-customize-commands_10}}

    Protected Overrides Sub CommitEdit()
        Dim result As MessageBoxResult = MessageBox.Show("Commit changes for the current edit item?", "CommitEdit confirmation", MessageBoxButton.OKCancel)
        If result = MessageBoxResult.OK Then
            If Me.DataForm IsNot Nothing AndAlso Me.DataForm.ValidateItem() Then
                Me.DataForm.CommitEdit()
            End If
        End If
    End Sub

    Protected Overrides Sub CancelEdit()
        Dim result As MessageBoxResult = MessageBox.Show("Cancel changes for the current edit item?", "CancelEdit confirmation", MessageBoxButton.OKCancel)
        If result = MessageBoxResult.OK Then
            If Me.DataForm IsNot Nothing Then
                Me.DataForm.CancelEdit()
            End If
        End If
    End Sub
	{{endregion}}

The last thing to be done is to set CommandProvider Property of the RadDataForm to be the newly-created CustomKeyboardCommandProvider class:
        

#### __[XAML] Example 6: Set the CommandProvider Property__

{{region raddataform-customize-commands_11}}

    <Grid.Resources>
        <my:CustomCommandProvider x:Key="CustomProvider"/>
    </Grid.Resources>

    <telerik:RadDataForm x:Name="RadDataForm1"
                 ItemsSource="{Binding Employees}" 
                 CommandProvider="{StaticResource CustomProvider}"/>
	{{endregion}}



#### __[C#] Example 6: Set the CommandProvider Property__

{{region raddataform-customize-commands_5}}

	this.RadDataForm1.CommandProvider = new CustomCommandProvider(this.RadDataForm1);
	{{endregion}}

#### __[VB.NET] Example 6: Set the CommandProvider Property__

{{region raddataform-customize-commands_12}}

	Me.RadDataForm1.CommandProvider = New CustomCommandProvider(Me.RadDataForm1)
	{{endregion}}
