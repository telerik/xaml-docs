---
title: Commands
page_title: Commands
description: This article goes over the predefined commands exposed by the RadWizard. 
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

## Using The RadWizardCommands

In order to utilize the built-in __RadWizard__ commands, you can set them directly to the __Command__ property of a button. Thus, once you click the button, the predefined command will be executed.  

There are two major scenarios to define a __RadButton__ – inside and outside __RadWizard__. The wizard namespace definition is as follows:

__Definition of the namespace needed to use the built-in commands of RadWizard__
```XAML
	xmlns:wizard="clr-namespace:Telerik.Windows.Controls.Wizard;assembly=Telerik.Windows.Controls.Navigation"
```

__Example 1__ illustrates how to add a __RadButton__ within the __FooterTemplate__ of __RadWizard__.

__Example 1: Demonstrates how you can use the built-in commands inside RadWizard__
```XAML
	<telerik:WizardPage.FooterTemplate>
	    <DataTemplate>
	            <telerik:RadButton Content="Back" 
								   Width="70" Height="25"
								   Command="wizard:RadWizardCommands.MoveCurrentToPrevious"
								   CommandParameter="{Binding}"/>
	    </DataTemplate>
	</telerik:WizardPage.FooterTemplate>
```

Once the source object is defined up in the tree as a __DataContext__, you can set the source for the __CommandParameter__ property's binding to be the entire object.

The other approach is to define the __RadButton__ beyond the boundaries of __RadWizard__.

__Example 2: Demonstrates how you can use the built-in commands outside RadWizard__
```XAML
	<telerik:RadButton Content="Back" 
	                   Width="70" 
                       Height="25"
	                   Command="wizard:RadWizardCommands.MoveCurrentToPrevious"
	                   CommandTarget="{Binding ElementName=myWizard}" />
```

In this case the target object needs to be explicitly set in the definition of the __CommandTarget__ property, specifying the __RadWizard__ towards which the command has to be executed. This specific command will be automatically disabled until a change in any of the items in the __RadWizard__ is made.

## Execute RadWizardCommands Programmatically

All RadWizardCommands are of type __RoutedUICommand__. So, for example, you may easily handle the __Click__ event of a button, and execute your command. However, when invoking the command in such a manner a second parameter should be added, pointing out the target UI Element as shown in Exapmle 3.

__Example 3: Executing wizard command from code behind__
```C#
	private void RadButton_Click(object sender, RoutedEventArgs e)
	{
		var moveCurrentToNextCommand = RadWizardCommands.MoveCurrentToNext as RoutedUICommand; 
		moveCurrentToNextCommand.Execute(null, this.wizard); 
	}
```

## Custom CommandProvider

RadWizard also exposes a __CommandProvider__ property, which allows you to customize the behavior of the commands in an MVVM-friendly way. Each of the commands listed in the beginning of the article can be customized by overriding its corresponding __Execute__/__CanExecute__ method. __Examples 3 and 4__ demonstrate a custom CommandProvider implementation. 

__Example 4: Creating a custom WizardCommandProvider__
```C#
	public class CustomCommandProvider : WizardCommandProvider
    {
        public CustomCommandProvider() : base(null)
        {
        }

        public CustomCommandProvider(RadWizard wizard) : base(wizard)
        {
        }

        protected override void Finish()
        {
            if (MessageBox.Show("Are you sure?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                // prevent finish
            }
            else
            {
                base.Finish();
            }
            
        }
    }
```
```VB.NET
	Public Class CustomCommandProvider
		Inherits WizardCommandProvider

			Public Sub New()
				MyBase.New(Nothing)
			End Sub

			Public Sub New(ByVal wizard As RadWizard)
				MyBase.New(wizard)
			End Sub

			Protected Overrides Sub Finish()
				If MessageBox.Show("Are you sure?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) = MessageBoxResult.No Then
					' prevent finish
				Else
					MyBase.Finish()
				End If

			End Sub
	End Class
```

__Example 5: RadWizard with custom CommandProvider implementation__
```XAML
	<Grid>
        <Grid.Resources>
            <local:CustomCommandProvider x:Key="CommandProvider"/>
        </Grid.Resources>
		<telerik:RadWizard CommandProvider="{StaticResource CommandProvider}">
			<telerik:RadWizard.WizardPages>
                <telerik:WizardPage ButtonsVisibilityMode="All" NextButtonContent="Continue" CancelButtonContent="Stop">
                    <TextBox Text="Wizard Page 1" />
                   
                </telerik:WizardPage>
                <telerik:WizardPage ButtonsVisibilityMode="Cancel,Finish" NextButtonContent="Finish" CancelButtonContent="Stop">
                    <TextBlock Text="Wizard Page 2" />
                </telerik:WizardPage>
            </telerik:RadWizard.WizardPages>
		</telerik:RadWizard>
    </Grid>
```

## See also 

* [Navigation]({%slug wizard-navigation%})
* [Wizard Pages]({%slug wizard-pages%})