---
title: Keyboard Support
page_title: Keyboard Support
description: Keyboard Support
slug: raddataform-features-keyboard-support
tags: keyboard,support
published: True
position: 4
---

# Keyboard Support


__RadDataForm__ allows you to navigate through the items without using the mouse. The keyboard can entirely replace the mouse by allowing you to perform navigation and editing. This article will walk you through the following sections.

* [Keys List](#keys-list)
* [Custom Keyboard Command Provider](#custom-keyboard-command-provider)
* [Disable the Built-in Navigation](#disable-the-built-in-navigation)
* [Control the Processing of Handled Events](#control-the-processing-of-handled-events)

## Keys List 

Below is the list of the keys that are supported.

1. __Left and Right arrow keys__ - navigates through the items.
        

1. __Ctrl + Home / Ctrl + Left arrow__ - moves the current item to the first position.
        

1. __Ctrl + End / Ctrl + Right arrow__ - moves the current item to the last position.
        

1. __F2__ - starts edit mode.
        

1. __Insert__ - adds new item.
        

1. __Enter__ - commits the edit operation.
        

1. __Escape__ - cancels the edit operation.
        

1. __Delete__ - deletes the current item.
        

## Custom Keyboard Command Provider

RadDataForm provides an easy MVVM-friendly approach for customization of its default commands' logic. You can find more information in the [Customizing Commands help article]({%slug raddataform-customize-commands%}). However, if you want to extend the way RadDataForm handles a particular key, you could create your own custom command provider and predefine the behaviour for that key.
        

The approach for accomplishing this is to create a separate class, inherit the DataFormCommandProvider and override the ProvideCommandsForKey(KeyEventArgs args) method. In this way, only the undesired behavior can be adjusted according to your requirements.

The class responsible for customizing the keyboard navigation should to be similar to Example 1:

#### __[C#] Example 1: Creating a custom KeyboardCommandProvider__

{{region raddataform-features-keyboard-support_1}}

	    class CustomKeyboardCommandProvider : DataFormCommandProvider
	    {
	        public CustomKeyboardCommandProvider()
	            : base(null)
	        {
	
	        }
	
	        public CustomKeyboardCommandProvider(RadDataForm dataForm)
	            : base(dataForm)
	        {
	            this.DataForm = dataForm;
	        }
	        public override List<DelegateCommandWrapper> ProvideCommandsForKey(KeyEventArgs args)
	        {
	            List<DelegateCommandWrapper> actionsToExecute = base.ProvideCommandsForKey(args);
	            if (args.Key == Key.Right)
	            {
	                actionsToExecute.Clear();
	                actionsToExecute.Add(new DataFormDelegateCommandWrapper(RadDataFormCommands.MoveCurrentToNext, this.DataForm));
	                actionsToExecute.Add(new DataFormDelegateCommandWrapper(RadDataFormCommands.BeginEdit, this.DataForm));
	            }
	            if (args.Key == Key.Left)
	            {
	                actionsToExecute.Clear();
	                actionsToExecute.Add(new DataFormDelegateCommandWrapper(RadDataFormCommands.MoveCurrentToPrevious, this.DataForm));
	                actionsToExecute.Add(new DataFormDelegateCommandWrapper(RadDataFormCommands.BeginEdit, this.DataForm));
	            }
	            if (actionsToExecute.Count > 0)
	            {
	                actionsToExecute.Add(new DataFormDelegateCommandWrapper(new Action(() => { this.DataForm.AcquireFocus(); }), 100, this.DataForm));
	                args.Handled = true;
	            }
	            return actionsToExecute;
	        }
	    }
	{{endregion}}

#### __[VB.NET] Example 1: Creating a custom KeyboardCommandProvider__

{{region raddataform-features-keyboard-support_3}}

	    Class CustomKeyboardCommandProvider
        Inherits DataFormCommandProvider
        Public Sub New()

            MyBase.New(Nothing)
        End Sub

        Public Sub New(dataForm As RadDataForm)
            MyBase.New(dataForm)
            Me.DataForm = dataForm
        End Sub

        Public Overrides Function ProvideCommandsForKey(args As KeyEventArgs) As List(Of DelegateCommandWrapper)
            Dim actionsToExecute As List(Of DelegateCommandWrapper) = MyBase.ProvideCommandsForKey(args)
            If args.Key = Key.Right Then
                actionsToExecute.Clear()
                actionsToExecute.Add(New DataFormDelegateCommandWrapper(RadDataFormCommands.MoveCurrentToNext, Me.DataForm))
                actionsToExecute.Add(New DataFormDelegateCommandWrapper(RadDataFormCommands.BeginEdit, Me.DataForm))
            End If

            If args.Key = Key.Left Then
                actionsToExecute.Clear()
                actionsToExecute.Add(New DataFormDelegateCommandWrapper(RadDataFormCommands.MoveCurrentToPrevious, Me.DataForm))
                actionsToExecute.Add(New DataFormDelegateCommandWrapper(RadDataFormCommands.BeginEdit, Me.DataForm))
            End If

            If actionsToExecute.Count > 0 Then
                actionsToExecute.Add(New DataFormDelegateCommandWrapper(New Action(Function()
                                                                                       Me.DataForm.AcquireFocus()

                                                                                   End Function), 100, Me.DataForm))
                args.Handled = True
            End If

            Return actionsToExecute
        End Function
    End Class
	{{endregion}}



Following up the code-snippet above, a press of Left/ Right keys will result in moving to the Next/ Previous item and editing it. However, do not forget to remove the predefined commands for that particular key by calling the Clear() method.

The last thing to be done is to set the CommandProvider property of the RadDataForm to be the newly-created CustomKeyboardCommandProvider class:

#### __[XAML] Example 2: Set the CommandProvider property__

{{region raddataform-features-keyboard-support_0}}

	    <Window.Resources>
	        <my:CustomKeyboardCommandProvider x:Key="CustomProvider"/>
	    </Window.Resources>
	        
	    <telerik:RadDataForm x:Name="RadDataForm1"
	                         ItemsSource="{Binding Employees}" 
	                         CommandProvider="{StaticResource CustomProvider}"/> 
	{{endregion}}


#### __[C#] Example 2: Set the CommandProvider property__

{{region raddataform-features-keyboard-support_2}}

	    this.RadDataForm1.CommandProvider = new CustomKeyboardCommandProvider(this.RadDataForm1);
	{{endregion}}

#### __[VB.NET] Example 2: Set the CommandProvider property__

{{region raddataform-features-keyboard-support_2}}

	    Me.RadDataForm1.CommandProvider = New CustomKeyboardCommandProvider(Me.RadDataForm1)
	{{endregion}}

## Disable the Built-in Navigation

As of Q1 2015, __DataFormCommandProvider__ exposed the __EnableBuiltInNavigation__ property. Its default value is __True__. In order to __disable the built-in navigation__, you can set its value to __False__.

#### __[C#] Example 3: Setting the EnableBuiltInNavigation property to False__ 

	public class CustomKeyboardCommandProvider : DataFormCommandProvider
	{
	    public CustomKeyboardCommandProvider()
	        : base(null)
	    {
	
	    }
	
	    public CustomKeyboardCommandProvider(RadDataForm dataForm)
	        : base(dataForm)
	    {
	        this.DataForm = dataForm;
	        this.EnableBuiltInNavigation = false;
	    }
	}


## Control the Processing of Handled Events

As of Q1 2015, the new boolean property __ShouldProcessHandledEvents__ of __DataFormCommandProvider__ is exposed. Its default value is __True__. If you want to manually process handled events, you can set its value to __False__.

#### __[C#] Example 4: Setting the ShouldProcessHandledEvents to False__

	public class CustomKeyboardCommandProvider : DataFormCommandProvider
	{
	    public CustomKeyboardCommandProvider()
	        : base(null)
	    {
	
	    }
	
	    public CustomKeyboardCommandProvider(RadDataForm dataForm)
	        : base(dataForm)
	    {
	        this.DataForm = dataForm;
	        this.ShouldProcessHandledEvents = false;
	    }
	}


# See Also

[Customizing Commands]({%slug raddataform-customize-commands%})
