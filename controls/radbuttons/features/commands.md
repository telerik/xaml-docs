---
title: Commands
page_title: Commands
description: Check our &quot;Commands&quot; documentation article for the RadButtons {{ site.framework_name }} control.
slug: radbuttons-features-commands
tags: commands
published: True
position: 6
---

# Commands

The __RadButtons__ provide a standard __ICommandSource__ implementation and allow you to bind your buttons to commands that will be executed on click. To take advantage of the __ICommandSource__ implementation, use the following properties:	  

* __Command__ - gets the command that will be executed when the command source is invoked.		

* __CommandParameter__ - represents a user-defined data value that can be passed to the command when it is executed.		

* __CommandTarget__ - the object on which the command is being executed.		

>tip As the __RadButtons__ implement the __ICommandSource__, you can use them with any command that implements the __ICommand__ interface, for example, the Telerik {% if site.site_name == 'Silverlight' %}[DelegateCommand](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_delegatecommand.html){% endif %}{% if site.site_name == 'WPF' %}[DelegateCommand](http://www.telerik.com/help/wpf/t_telerik_windows_controls_delegatecommand.html){% endif %}.	  

## Example

The following example demonstrates how to use commands in an MVVM scenario.

1. Define the command. The command is located in the __SampleViewModel__ class:		

	__Example 1: Defining a command__
	```C#
	public class SampleViewModel
	{
		public SampleViewModel()
		{
			MyCommand = new DelegateCommand(OnCommandExecuted);
		}
		public ICommand MyCommand { get; set; }

		private void OnCommandExecuted(object obj)
		{
			MessageBox.Show("MyCommand Executed");
		} 
	}
	```
```VB.NET
		Public Class SampleViewModel
			Public Sub New()
				MyCommand = New DelegateCommand(AddressOf OnCommandExecuted)
			End Sub

			Public Property MyCommand As ICommand

			Private Sub OnCommandExecuted(ByVal obj As Object)
				MessageBox.Show("MyCommand Executed")
			End Sub
		End Class
	```

1. Set the __SampleViewModel__ as the __DataContext__ of your __UserControl__:		

	__Example 2: Setting up the DataContext__  
	```C#
		public Example()
		{
			InitializeComponent();
			this.DataContext = new SampleViewModel();
		}
	```
```VB.NET
		Public Sub New()
			InitializeComponent()
			Me.DataContext = New SampleViewModel()
		End Sub
	```

1. In the XAML provide the bindings for the command and set the command parameter:

	__Example 3: Setting up the Command and CommandParameter properties__  
	```XAML
		<telerik:RadButton Content="My Button"
						Command="{Binding MyCommand}"
						CommandParameter="ParameterValue" />
	```

   >__RadButtons__ are located in the __Telerik.Windows.Controls.dll__ assembly. To use them in your project, add a reference to the assembly.{% if site.site_name == 'WPF' %} For more information, see the [Controls Dependencies](https://docs.telerik.com/devtools/wpf/common-information/installation-installing-dependencies-wpf) article.{% endif %}{% if site.site_name == 'Silverlight' %} For more information, see the [Controls Dependencies](https://docs.telerik.com/devtools/silverlight/common-information/installation-installing-dependencies) article.{% endif %}

   >Then in XAML you have to declare the namespace: `xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"`

This is a very basic sample, but you can apply this approach to any type of commands that implement the __ICommand__ interface.		  

## See Also
 * [Appearance]({%slug radbuttons-features-appearance%})
 * [Button]({%slug radbuttons-features-button%})
 * [Events]({%slug radbuttons-events%})
