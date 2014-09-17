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



__RadDataForm__  allows you to navigate through the items without using the mouse. The keyboard can entirely replace the mouse by allowing you to perform navigation and editing.

Here is the list of the keys that are supported:

1. __Left and Right arrow keys__ - navigates through the items.
        

1. __Ctrl + Home / Ctrl + Left arrow__ - moves the current item to the first position.
        

1. __Ctrl + End / Ctrl + Right arrow__ - moves the current item to the last position.
        

1. __F2__ - start edit mode.
        

1. __Insert__ - adds new item.
        

1. __Enter__ - commits the edit operation.
        

1. __Escape__ - cancels the edit operation.
        

1. __Delete__ - deletes the current item.
        

## Custom Keyboard Command Provider

RadDataForm provides an easy MVVM-friendly approach for customization of its default commands' logic. More information can be found on [Customizing Commands help article]({%slug raddataform-customize-commands%}).
          However, if you want to extend the way RadDataForm handles a particular key you could create your own custom command provider and predefine the behaviour for that key.
        

The approach for accomplishing the purpose is to create a separate class, inherit the DataFormCommandProvider and overriding the ProvideCommandsForKey(KeyEventArgs args) method. In this way only the undesired behavior can be adjusted according to your requirements.

The class responsible for customizing the keyboard navigation should to be similar to the one below:

#### __C#__

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



Following up the code-snippet above, a press of Left/ Right keys will result in moving to the Next/ Previous item and editing it. However, do not forget to remove the predefined commands for that particular key by calling the Clear() method.

The last thing to be done is to set CommandProvider Property of the RadDataForm to be the newly-created CustomKeyboardCommandProvider class:

#### __XAML__

{{region raddataform-features-keyboard-support_0}}
	    <Window.Resources>
	        <my:CustomKeyboardCommandProvider x:Key="CustomProvider"/>
	    </Window.Resources>
	        
	    <telerik:RadDataForm x:Name="RadDataForm1"
	                         ItemsSource="{Binding Employees}" 
	                         CommandProvider="{StaticResource CustomProvider}"/> 
	{{endregion}}



#### __C#__

{{region raddataform-features-keyboard-support_2}}
	    this.RadDataForm1.CommandProvider = new CustomKeyboardCommandProvider(this.RadDataForm1);
	{{endregion}}


