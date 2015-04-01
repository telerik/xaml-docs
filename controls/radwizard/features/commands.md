---
title: Commands
page_title: Commands
description: Commands
slug: wizard-features-commands
tags: commands
published: True
position: 2
---

# Commands

__RadWizard__ provides a set of built-in commands that enables you to easily handle the User Interface actions, but still make your logic independent of the UI layout. 

All supported commands are defined in the __RadWizardCommands__ class and are listed below:

* __Cancel__
* __Finish__
* __Help__
* __MoveCurrentToPrevious__
* __MoveCurrentToNext__


## Implementation ##



Fast and quite easy approach for implementing the built-in commands in __RadWizard__ is to set them directly to a particular __RadButton__. Thus, once you click a single button, the predefined command will be executed.  

There are two major scenarios to define a __RadButton__ – inside and outside __RadWizard__. The definition will be as follows:
#### __[XAML] Definition of the namespace needed to use the built-in commands of RadWizard__

	xmlns:wizard="clr-namespace:Telerik.Windows.Controls.Wizard;assembly=Telerik.Windows.Controls.Navigation"

The following example illustrates how to add a __RadButton__ within the __FooterTemplate__ of __RadWizard__ (__Example 1__).

#### __[XAML] Example 1: Demonstrates how you can use the built-in commands inside RadWizard__

	<telerik:WizardPage.FooterTemplate>
	    <DataTemplate>
	            <telerik:RadButton Content="Back" 
								   Width="70" Height="25"
								   Command="wizard:RadWizardCommands.MoveCurrentToPrevious"
								   CommandParameter="{Binding}"/>
	    </DataTemplate>
	</telerik:WizardPage.FooterTemplate>


Once the source object is defined up in the tree as a __DataContext__, you can set the source for the __CommandParameter__ Property's Binding to be the entire object.

The other approach is to define the __RadButton__ beyond the boundaries of __RadWizard__ (__Example 2__).
#### __[XAML] Example 2: Demonstrates how you can use the built-in commands outside RadWizard__
	<telerik:RadButton Content="Back" 
	                   Width="70" 
                       Height="25"
	                   Command="wizard:RadWizardCommands.MoveCurrentToPrevious"
	                   CommandTarget="{Binding ElementName=myWizard}" />

In this case the target object needs to be explicitly set in the definition of the __CommandTarget__ Property, specifying the __RadWizard__ towards which the command has to be executed. This specific command will be automatically disabled until a change in any of the items in the __RadWizard__ is made.
