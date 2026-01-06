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

The __RadButtons__ provide a standard `ICommandSource` implementation and allow you to bind your buttons to commands that will be executed on click. To take advantage of the `ICommandSource` implementation, use the following properties:	  

* `Command`&mdash;Gets the command that will be executed when the command source is invoked.		

* `CommandParameter`&mdash;Represents a user-defined data value that can be passed to the command when it is executed.		

* `CommandTarget`&mdash;The object on which the command is being executed.		

RadButtons implement the `ICommandSource`, so you can use them with any command that implements the `ICommand` interface. For example, the [DelegateCommand]({%slug common-mvvm-delegate-command-implementation%}) class.	  

## Using Commands in MVVM

The following example demonstrates how to use commands in an MVVM scenario.

1. Define the command in a sample view model class.

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

1. Set a `SampleViewModel` object instance as the `DataContext` of your corresponding view (the UserControl or Window).

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

1. In the XAML set the bindings for the command and set the command parameter.

	```XAML
		<telerik:RadButton Content="My Button"
						Command="{Binding MyCommand}"
						CommandParameter="ParameterValue" />
	```

	`RadButton` is located in the `Telerik.Windows.Controls.dll` assembly. To use them in your project, add a reference to the assembly or install the `Telerik.Windows.Controls.for.Wpf.Xaml` NuGet package (or its NoXaml alternative). For more information, see the [Controls Dependencies](https://docs.telerik.com/devtools/wpf/common-information/installation-installing-dependencies-wpf) article.

	Then in XAML you have to declare the namespace: `xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"`

This is a very basic sample, but you can apply this approach to any type of commands that implement the `ICommand` interface.		  

## See Also
 * [Button]({%slug radbuttons-features-button%})
 * [Events]({%slug radbuttons-events%})
