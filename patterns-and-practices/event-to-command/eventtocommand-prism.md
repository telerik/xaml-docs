---
title: Prism Option
page_title: Prism Option
description: Prism Option
slug: patterns-and-practices-eventtocommand-prism
tags: prism,option
publish: True
position: 4
---

# Prism Option



As mentioned at the end of the previous tutorial, if everything that you need is covered by MVVM Light then you will not need to read any further.  However, if you happen to be using Prism for your Silverlight or WPF development, the method in this help article might be helpful for creating reusable attached behaviors that bind to our ViewModel (VM) commands.

## Getting Started

This tutorial builds upon many of the concepts already covered in the Blend and MVVM Light tutorials, except this time we will utilize the CommandBehaviorBase class found in the Prism libraries.  For more information on Prism, check out the Codeplex site for the complete download, forums, and other useful information.

Begin by adding the Prism assemblies to your project:

* Microsoft.Practices.Prism

Now create a new user control named GridPrismAttachedBehavior.xaml. Once this is in place we will want to add both the Telerik and local namespaces:
      	{% if site.site_name == 'Silverlight' %}

#### __XAML__

{{region patterns-and-practices-eventtocommand-prism_0}}
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	xmlns:local="clr-namespace:RadEventToCommandExamples"
	{{endregion}}

{% endif %}{% if site.site_name == 'WPF' %}

#### __XAML__

{{region patterns-and-practices-eventtocommand-prism_0_1}}
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	xmlns:local="clr-namespace:RadEventToCommand.WPF"
	{{endregion}}

{% endif %}

As well as this code taken from the MVVM Light example.  Note we removed the trigger implementation and now only have the bound RadGridView and ListBox:

#### __XAML__

{{region patterns-and-practices-eventtocommand-prism_1}}
	<UserControl.Resources>
		<local:ExampleViewModel x:Key="xVM" />
	</UserControl.Resources>
	
	<Grid x:Name="LayoutRoot"
	          Background="White"
	          DataContext="{StaticResource xVM}">
		<Grid.ColumnDefinitions>
			<ColumnDefinition />
			<ColumnDefinition />
		</Grid.ColumnDefinitions>
	
		<telerik:RadGridView x:Name="xRadGridView"
	                ItemsSource="{Binding GridItems, Mode=TwoWay}">
		</telerik:RadGridView>
	
		<ListBox x:Name="xDetailListBox"
	                Grid.Column="1"
	                ItemsSource="{Binding ListItems, Mode=OneWay}" />
	</Grid>
	{{endregion}}



We’ll also do a quick build and add the requisite code to our MainPage control to allow for loading this example:

#### __XAML__

{{region patterns-and-practices-eventtocommand-prism_2}}
	<telerik:RadButton x:Name="xGridPrismCommand"
	               Grid.Column="3"
	               Content="Grid Prism Attached Behavior"
	               Click="xGridPrismCommand_Click" />
	
	{{endregion}}



#### __C#__

{{region patterns-and-practices-eventtocommand-prism_3}}
	private void xGridPrismCommand_Click(object sender, RoutedEventArgs e)
	{
	    xContentBorder.Child = new GridPrismAttachedBehavior();
	}
	{{endregion}}



Now we’re ready to dive into Prism Attached Behaviors.

## Creating a Command Behavior

The concept for the Prism Attached Command Behavior comes from the folks over at Microsoft Patterns & Practices, so for more information on the full implementation as well as a cool snippet to add this to Visual Studio quickly, check the following links:
      

[http://blogs.southworks.net/dschenkelman/2009/04/18/commands-with-attached-behavior-for-silverlight-3-dataform/](http://blogs.southworks.net/dschenkelman/2009/04/18/commands-with-attached-behavior-for-silverlight-3-dataform/)

[http://blogs.southworks.net/dschenkelman/2009/08/13/c-code-snippet-to-create-commands-with-attached-behaviors-using-prism/](http://blogs.southworks.net/dschenkelman/2009/08/13/c-code-snippet-to-create-commands-with-attached-behaviors-using-prism/)

Here we’ll cover our utilization with RadGridView and the RowEditEnded event.  First, create a new folder named PrismCommands to hold any commands you’ll be adding to your project.  Next, create the easier of the two classes, RowEditEndedCommandBehavior.cs.  This class will derive from CommandBehaviorBase<RadGridView>, so be sure to add both the Telerik.Windows.Controls and Microsoft.Practices.Prism.Commands using references to your class (or use something like Fix Usings from JustCode to take care of that for you).
		

The implementation for this is rather simple, so rather than stepping through everything we’ll paste the complete class code and then detail what we’ve done:
		

#### __C#__

{{region patterns-and-practices-eventtocommand-prism_4}}
	public class RowEditEndedCommandBehavior : CommandBehaviorBase<RadGridView>
	{
		public RowEditEndedCommandBehavior(RadGridView gridView)
			: base(gridView)
		{
			gridView.RowEditEnded += new EventHandler<GridViewRowEditEndedEventArgs>(gridView_RowEditEnded);
		}
	
		void gridView_RowEditEnded(object sender, GridViewRowEditEndedEventArgs e)
		{
			CommandParameter = e;
	
			ExecuteCommand();
		}
	}
	{{endregion}}



As you can see, we reference RadGridView several times as the control we are using.  This enables us to set an event handler for any event that we need to utilize, in our case RowEditEnded, which is handled in the initialization of the command behavior.  Within the event handler itself we define a CommandParameter to be the entire GridViewRowEditEndedEventArgs, although the parameter is optional as you could perform any other operations you would like here.  Finally, we call ExecuteCommand to then fire the command that is bound to our new behavior.
       

The second piece of this is RowEditEndedCommand.cs.  The links from P&P above go over the details, but to save on possible copy and paste errors here is the full listing for that class:
       

#### __C#__

{{region patterns-and-practices-eventtocommand-prism_5}}
	public static class RowEditEndedCommand
	{
		private static readonly DependencyProperty RowEditEndedCommandBehaviorProperty
			= DependencyProperty.RegisterAttached(
			"RowEditEndedCommandBehavior",
			typeof(RowEditEndedCommandBehavior),
			typeof(RowEditEndedCommand),
			null);
	
		public static readonly DependencyProperty CommandProperty
			= DependencyProperty.RegisterAttached(
			"Command",
			typeof(ICommand),
			typeof(RowEditEndedCommand),
			new PropertyMetadata(OnSetCommandCallback));
	
		public static readonly DependencyProperty CommandParameterProperty
			= DependencyProperty.RegisterAttached(
		   "CommandParameter",
		   typeof(object),
		   typeof(RowEditEndedCommand),
		   new PropertyMetadata(OnSetCommandParameterCallback));
	
		public static ICommand GetCommand(RadGridView gridView)
		{
			return gridView.GetValue(CommandProperty) as ICommand;
		}
	
	    public static void SetCommand(RadGridView gridView, object parameter)
	    {
	        gridView.SetValue(CommandProperty, parameter);
	    }
	
		public static void SetCommandParameter(RadGridView gridView, object parameter)
		{
			gridView.SetValue(CommandParameterProperty, parameter);
		}
	
		public static object GetCommandParameter(RadGridView gridView)
		{
			return gridView.GetValue(CommandParameterProperty);
		}
	
		private static void OnSetCommandCallback
			(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
		{
			RadGridView gridView = dependencyObject as RadGridView;
			if (gridView != null)
			{
				RowEditEndedCommandBehavior behavior = GetOrCreateBehavior(gridView);
				behavior.Command = e.NewValue as ICommand;
			}
		}
	
		private static void OnSetCommandParameterCallback
			(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
		{
			RadGridView gridView = dependencyObject as RadGridView;
			if (gridView != null)
			{
				RowEditEndedCommandBehavior behavior = GetOrCreateBehavior(gridView);
				behavior.CommandParameter = e.NewValue;
			}
		}
	
		private static RowEditEndedCommandBehavior GetOrCreateBehavior(RadGridView gridView)
		{
			RowEditEndedCommandBehavior behavior =
				gridView.GetValue(RowEditEndedCommandBehaviorProperty) as RowEditEndedCommandBehavior;
			if (behavior == null)
			{
				behavior = new RowEditEndedCommandBehavior(gridView);
				gridView.SetValue(RowEditEndedCommandBehaviorProperty, behavior);
			}
			return behavior;
		}
	}
	{{endregion}}



Of note with the above – the snippet is so useful for this code because making new commands really only requires doing a quick find/replace, i.e., replace RowEditEnded with CellEditEnded and you have a brand new command.  The only other place you need to replace anything is to ensure that instance of the control are modified, so if we wanted to make a RadScheduleView command we would replace instances of RadGridView with RadScheduleView and replace any of the named instances (in this case they’re all gridView) with like-named instances, say scheduleView.  Everything else stays exactly the same as the logic for creating one of these attached behavior commands won’t change.
      	

The end result here is to produce like-named classes, so in our case we have RowEditEndedCommand and RowEditEndedCommandBehavior.  Not necessary, but when making lots of these the convention will definitely save you time and headaches trying to track down rogue code.
      	

## Implementing Prism Attached Behavior Commands

While this seemed like a lot of work, the end result is very powerful, highly customizable, and definitely re-usable across your project.  Before going any further do a quick build, allowing us to add the prismcommands namespace to our XAML file:
      {% if site.site_name == 'Silverlight' %}

#### __XAML__

{{region patterns-and-practices-eventtocommand-prism_6}}
	xmlns:prismcommands="clr-namespace:RadEventToCommandExamples.PrismCommands"
	{{endregion}}

{% endif %}{% if site.site_name == 'WPF' %}

#### __XAML__

{{region patterns-and-practices-eventtocommand-prism_6_1}}
	xmlns:prismcommands="clr-namespace:RadEventToCommand.WPF.PrismCommands"
	{{endregion}}

{% endif %}

Now we only have one more step and we’re set.  In the RadGridView definition, add the following attached behavior and bind it to TestCommand2 (if you recall, this one expects the RowEditEnded event arguments to be passed as the object):

#### __XAML__

{{region patterns-and-practices-eventtocommand-prism_7}}
	prismcommands:RowEditEndedCommand.Command="{Binding TestCommand2}"
	{{endregion}}



>You may get a Visual Studio designer error stating ‘Object reference not set to an instance of an object’ that causes the designer to fail loading.  Don’t worry, the code is 100% good and good for you, but this is a case where the VS parser doesn’t adequately handle good code.
        

Now, run your application, click the RadButton to load this new example, and start editing records.  You should see something like the following:



Neat, right?  The benefits here for Prism developers are that you can easily create commands that handle things like logging, checking global conditions, etc., and re-use them across views and modules.  Plus, since you can choose to put anything you would like as the CommandParameter that you are sending to your VM, you can perform other operations or do different checks on data to ensure everything works as expected.  The added flexibility delivers more power to you as a developer.
        



You can download the complete project from 
        {% if site.site_name == 'Silverlight' %}[here](http://www.telerik.com/community/code-library/silverlight/general/event-to-command-example.aspx){% endif %}{% if site.site_name == 'WPF' %}[here](http://www.telerik.com/community/code-library/wpf/general/event-to-command-example.aspx){% endif %}.

This concludes the Telerik Patterns and Practices Event-To-Command series.  Thank you for reading!
