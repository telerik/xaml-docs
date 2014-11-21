---
title: Command Support
page_title: Command Support
description: Command Support
slug: common-command-support
tags: command,support
published: True
position: 7
site_name: Silverlight
---

# Command Support



## Command support

Telerik UI for Silverlight provide full implementation of the Command pattern, facilitating the building of complex UIs and yet keeping the code simple by using Commands. 
Having a common code base and common API is principal in the development of the Telerik controls for Silverlight and WPF. The Telerik command manager for Silverlight follows this principle and has an API that is very similar to the built-in commands framework in WPF. This allows applying the same knowledge and ideas when using commands across the two platforms. All Telerik buttons and menus have built-in support for commands.
        What are Commands?

There are several ways that can be taken when something needs to be triggered by a user action. A simple and straightforward way is to register for the input events of a control or a visual element, for example the KeyDown and MouseLeftButtonUp events. Registering for input events may not be always possible and it does not fit the Model-View-ViewModel pattern.
        

A Command is an abstraction for an executable piece of code normally found in event handlers. In more general terms we can think of commands as an implementation of the [ Command design pattern.](http://msdn.microsoft.com/en-us/library/ff921126(v=pandp.20).aspx)
          The built-in support for commands in Silverlight is limited to a single interface, the ICommand. It serves as the basis for all command implementations.
Today there are several Command frameworks that can be found for Silverlight. Each tries to address the need for a common way to deal with commands.
        

## Command Classes

In its essence a command is an object that can be notified when a command should be executed and can be used to check whether a command can be executed. This similarity is shared between all commands because they implement the built-in ICommand interface:        

#### __C#__

{{region create-ICommand_1}}
	public interface ICommand
	{
		event EventHandler CanExecuteChanged;

		bool CanExecute(object parameter);
		void Execute(object parameter);
	}
{{endregion}}

The RoutedUICommand represents a command that uses routed events to notify when it has executed and to check whether it can execute. In order to use these commands more effectively an understanding of how routed events work is needed.
        

## Command Basics: Creating and using a Command

Commands are commonly created as public static fields so that they can be easily shared:
    

#### __C#__

{{region creating-RoutedCommand_2}}
	public static RoutedUICommand MyCommand = new RoutedUICommand ("My Command Text", "MyCommand", typeof(MainPage));	
{{endregion}}



Note that the UICommand Constructor takes a readable text that is can be used to represent the command. The second parameter should match the name of the static field and the third should be the class where the static field was created. This allows the commands to be used in xaml.
Then a command can be used by setting the command property on any of the RadButtons or the RadMenuItem:
    

#### __XAML__

{{region set-Command-property_0}}
	<telerik:RadButton Command="MainPage.MyCommand" Content="{Binding Command.Text, RelativeSource={RelativeSource Self}}"/>
	<telerik:RadMenuItem Command="MainPage.MyCommand" Header="{Binding Command.Text, RelativeSource={RelativeSource Self}}"/>
{{endregion}}


Note how the command is specifies with the name of the type where it was defined and the name of the static field. Then the content of the button and the menu item are bound to the command text that was specified in its constructor.
Commands raise two routed events the CommandManager.CanExecute and CommandManager.Executed events. They can be handled anywhere along the visual route of the events to specify whether a command can execute and act on when it has executed. Using routed events allows command management to be sufficiently decoupled.

Here is how these routed events can be handled:

#### __C#__

{{region handle-commands_3}}
			public MainPage()
			{
				InitializeComponent();
	
				CommandManager.AddCanExecuteHandler(this, OnCommandCanExecute);
				CommandManager.AddExecutedHandler(this, OnCommandExecuted);
			}
	
			private void OnCommandExecuted(object sender, ExecutedRoutedEventArgs e)
			{
				//TODO: Add code that will act when the command is executed.
				e.Handled = true;
			}
	
			private void OnCommandCanExecute(object sender, ExecutedRoutedEventArgs e)
			{
				//Whether a command can currently execute will depend on the application logic:
				e.CanExecute = true;
				e.Handled = true;
			}
	{{endregion}}



If there are application events that invalidate the command state, the CommandManager can be used update the CanExecute state of all commands:
    

#### __C#__

{{region update-CanExecute_4}}
			CommandManager.InvalidateRequerySuggested();
	{{endregion}}



## Input Bindings

Input bindings can be used to specify an input event that will execute the command. This can be either a keyboard or a mouse event. A keyboard shortcut for MyCommand can be done by adding an input binding to the root visual of the application:
        

#### __XAML__

{{region set-input-bindings_1}}
	        <Grid x:Name="LayoutRoot">
	            <telerik:CommandManager.InputBindings>
	                <telerik:InputBindingCollection>
	                    <telerik:KeyBinding Command="MainPage.MyCommand" Key="M" Modifiers="Shift"/>
	                </telerik:InputBindingCollection>
	            </telerik:CommandManager.InputBindings>
	        </Grid>
	{{endregion}}



## Command Bindings

Handling routed events when there are a large number of commands may become cumbersome. For this reason command bindings may be used. A command binding is an object that contains handlers for the CanExecute and Executed events of a specific command. These handlers will be called only when routed events of the given command are handled the visual object where the binding is attached. Here is how this can be specified in xaml:
        

#### __XAML__

{{region set-command-bindings_2}}
	        <telerik:CommandManager.CommandBindings>
	            <telerik:CommandBindingCollection>
	                <telerik:CommandBinding Command="MainPage.MyCommand" Executed="OnMyCommandExecuted" CanExecute="OnMyCommandCanExecute"/>
	            </telerik:CommandBindingCollection>
	        </telerik:CommandManager.CommandBindings>
	{{endregion}}


