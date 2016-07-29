---
title: Commands
page_title: Commands
description: Commands
slug: radbuttons-features-commands
tags: commands
published: True
position: 5
---

# Commands

The __RadButtons__ provide you with a standard __ICommandSource__ implementation. This means that you can bind your buttons to commands that will be executed when the button is clicked. In order to take advantage of the __ICommandSource__ implementation you can use the following properties:	  

* __Command__ - gets the command that will be executed when the command source is invoked.		

* __CommandParameter__ - represents a user defined data value that can be passed to the command when it is executed.		

* __CommandTarget__ - the object on which the command is being executed.		

>tip As the __RadButtons__ implement the __ICommandSource__, you can use them with any command that implements the __ICommand__ interface, for example Telerik {% if site.site_name == 'Silverlight' %}[DelegateCommand](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_delegatecommand.html){% endif %}{% if site.site_name == 'WPF' %}[DelegateCommand](http://www.telerik.com/help/wpf/t_telerik_windows_controls_delegatecommand.html){% endif %}.	  

## Example

Here is an example of a command usage in a MVVM scenario. The command is located in the __SampleViewModel__ class.		

#### __[C#] Example 1: Defining a command__
{{region cs-radbuttons-features-commands_0}}
	public class SampleViewModel
	{
	   public SampleViewModel()
	   {
	   }
	   public ICommand MyCommand
	   {
	       get;
	       set;
	   }
	}
{{endregion}}

#### __[VB.NET] Example 1: Defining a command__
{{region vb-radbuttons-features-commands_1}}
	Public Class SampleViewModel
	    Public Sub New()
	    End Sub
	    Public Property MyCommand() As ICommand
	        Get
	            Return m_MyCommand
	        End Get
	        Set(value As ICommand)
	            m_MyCommand = Value
	        End Set
	    End Property
	    Private m_MyCommand As ICommand
	End Class
{{endregion}}

Set the __SampleViewModel__ as the __DataContext__ of your __UserControl__.		

#### __[C#] Example 2: Setting up the DataContext__  
{{region cs-radbuttons-features-commands_2}}
	public Example()
	{
	    InitializeComponent();
	    this.DataContext = new SampleViewModel();
	}
{{endregion}}

#### __[VB.NET] Example 2: Setting up the DataContext__  
{{region vb-radbuttons-features-commands_3}}
	Public Sub New()
	    InitializeComponent()
	    Me.DataContext = New SampleViewModel()
	End Sub
{{endregion}}

In the XAML provide the bindings for the command and set the command parameter.

>__RadButtons__ are located in the __Telerik.Windows.Controls.dll__ and in order to use them in your project you have to add a reference to the assembly.{% if site.site_name == 'WPF' %} You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).{% endif %}{% if site.site_name == 'Silverlight' %} You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).{% endif %}

>Then in XAML you have to declare the namespace: `xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"`

#### __[XAML] Example 3: Setting up the Command and CommandParameter properties__  
{{region xaml-radbuttons-features-commands_4}}
	<telerik:RadButton Content="My Button"
	                   Command="{Binding MyCommand}"
	                   CommandParameter="ParameterValue" />
{{endregion}}

>This is a very basic sample, but you can apply this approach to any type of commands that implement the __ICommand__ interface.		  

## See Also
 * [Appearance]({%slug radbuttons-features-appearance%})
 * [Button]({%slug radbuttons-features-button%})
 * [Events]({%slug radbuttons-events%})