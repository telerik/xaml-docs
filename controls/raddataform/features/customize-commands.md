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

This article will demonstrate how to customize RadDataForm's commands in an MVVM-friendly way as well as how to execute them manually. 

* [The DataFormCommandProvider](#the-dataformcommandprovider)
* [Designing a Custom DataFormCommandProvider](#designing-a-custom-dataformcommandprovider)
* [Setting the Custom DataFormCommandProvider](#setting-the-custom-dataformcommandprovider)
* [Executing Commands Manually](#executing-commands-manually)

## The DataFormCommandProvider

The public __DataFormCommandProvider__ class exposes the "execute" and "can-execute" logic of all commands utilized by RadDataForm. RadDataForm processes these commands according to its current provider.

### Execute Logic Methods

The methods listed below identify the logic that is executed when a certain command's invocation takes place.

#### __[C#] Example 1: The IExecuteLogicMethods__

{{region cs-raddataform-customize-commands_0}}
	void MoveCurrentToFirst();
	void MoveCurrentToLast();
	void MoveCurrentToNext();
	void MoveCurrentToPrevious();
	void BeginEdit();
	void CommitEdit();
	void Delete();
	void CancelEdit();
	void AddNew();
{{endregion}}

#### __[VB.NET] Example 1: The IExecuteLogicMethods__

{{region vb-raddataform-customize-commands_0}}
	Sub MoveCurrentToFirst()
	Sub MoveCurrentToLast()
	Sub MoveCurrentToNext()
	Sub MoveCurrentToPrevious()
	Sub BeginEdit()
	Sub CommitEdit()
	Sub Delete()
	Sub CancelEdit()
	Sub AddNew()
{{endregion}}

### Can-Execute Logic Methods

With the help of those methods you can identify whether a certain command can be executed or not.

#### __[C#] Example 2: The ICanExecuteLogicMethods__

{{region cs-raddataform-customize-commands_1}}
    bool CanMoveCurrentToFirstExecute();
    bool CanMoveCurrentToLastExecute();
    bool CanMoveCurrentToNextExecute();
    bool CanMoveCurrentToPreviousExecute();
    bool CanBeginEditExecute();
    bool CanCommitEditExecute();
    bool CanDeleteExecute();
    bool CanCancelEditExecute();
    bool CanAddNewExecute();
{{endregion}}

#### __[VB.NET] Example 2: The ICanExecuteLogicMethods__

{{region vb-raddataform-customize-commands_1}}
	Function CanMoveCurrentToFirstExecute() As Boolean
	Function CanMoveCurrentToLastExecute() As Boolean
	Function CanMoveCurrentToNextExecute() As Boolean
	Function CanMoveCurrentToPreviousExecute() As Boolean
	Function CanBeginEditExecute() As Boolean
	Function CanCommitEditExecute() As Boolean
	Function CanDeleteExecute() As Boolean
	Function CanCancelEditExecute() As Boolean
	Function CanAddNewExecute() As Boolean
{{endregion}}

A runnable demo that utilizes the code from this article can be found on {% if site.site_name == 'Silverlight' %}[this online demo](http://demos.telerik.com/silverlight/#DataForm/CustomCommandsProvider){% endif %}{% if site.site_name == 'WPF' %}[the DataForm's CustomCommandsProvider demo](http://demos.telerik.com/wpf/){% endif %}.

## Designing a Custom DataFormCommandProvider

The first step is to create your own class that inherits from **DataFormCommandProvider**:

#### __[C#] Example 3: Defining a Custom CommandProvider__

{{region cs-raddataform-customize-commands_2}}
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

{{region vb-raddataform-customize-commands_2}}
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

You need to override the methods of the commands that will be customized. In the following example we will customize: **MoveCurrentToNext**, **MoveCurrentToPrevious**, **BeginEdit** and **CancelEdit**.

### MoveCurrentToNext and MoveCurrentToPrevious

We aim at changing their execution logic, in order to start editing the item, as soon as it was set as a current one and bypass the logic in the same place. Here are the overridden methods:

#### __[C#] Example 4: Customizing MoveCurrentToNext and MoveCurrentToPrevious__

{{region cs-raddataform-customize-commands_3}}
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

{{region vb-raddataform-customize-commands_3}}
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

### CommitEdit and CancelEdit

A common requirement for data form is to add __confirmation message boxes when CRUD operations are executed__. Here we will do a similar thing with the CommitEdit/CancelEdit commands.

#### __[C#] Example 5: Customizing CommitEdit and CancelEdit__

{{region cs-raddataform-customize-commands_4}}
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

{{region vb-raddataform-customize-commands_4}}
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

## Setting the Custom DataFormCommandProvider

The last thing to be done is to set the **CommandProvider** property of the RadDataForm to the newly-created **CustomKeyboardCommandProvider** class:

#### __[XAML] Example 6: Set the CommandProvider Property__

{{region xaml-raddataform-customize-commands_6}}
	<Grid.Resources>
	    <my:CustomCommandProvider x:Key="CustomProvider"/>
	</Grid.Resources>
	<telerik:RadDataForm x:Name="RadDataForm1"
	             ItemsSource="{Binding Employees}" 
	             CommandProvider="{StaticResource CustomProvider}"/>
{{endregion}}

#### __[C#] Example 6: Set the CommandProvider Property__

{{region cs-raddataform-customize-commands_5}}
	this.RadDataForm1.CommandProvider = new CustomCommandProvider(this.RadDataForm1);
{{endregion}}

#### __[VB.NET] Example 6: Set the CommandProvider Property__

{{region vb-raddataform-customize-commands_5}}
	Me.RadDataForm1.CommandProvider = New CustomCommandProvider(Me.RadDataForm1)
{{endregion}}

## Executing Commands Manually

Using the **RadDataFormCommands** class, you can set a sequence of commands to be performed one after another. So, for example, you may easily handle the click event of a button, move to the next item and put it in edit mode. However, when invoking the commands in such a manner a second parameter should be added, pointing out the target **UI Element** as shown in **Exapmle 7**.

#### __[C#] Example 7: Executing a sequence of commands__

{{region cs-raddataform-customize-commands_7}}
	private void Button1_Click(object sender, RoutedEventArgs e)
	{
		var moveToNextCommand = RadDataFormCommands.MoveCurrentToNext as RoutedUICommand;
		var editCommand = RadDataFormCommands.BeginEdit as RoutedUICommand;
		moveToNextCommand.Execute(null, this.DataForm);
		editCommand.Execute(null, this.DataForm);
	}
{{endregion}}

#### __[VB.NET] Example 7: Executing a sequence of commands__

{{region vb-raddataform-customize-commands_7}}
	Private Sub Button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
		Dim moveToNextCommand = TryCast(RadDataFormCommands.MoveCurrentToNext, RoutedUICommand)
		Dim editCommand = TryCast(RadDataFormCommands.BeginEdit, RoutedUICommand)
		moveToNextCommand.Execute(Nothing, Me.DataForm)
		editCommand.Execute(Nothing, Me.DataForm)
	End Sub
{{endregion}}

## See Also

* [Getting Started]({%slug raddataform-getting-started%})
* [Developer Focused Examples]({%slug raddataform-sdk-examples%})
* [Add, Edit and Delete Operations]({%slug raddataform-add-edit-delete-buttons%})
