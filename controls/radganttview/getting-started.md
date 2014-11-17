---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radganttview-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains __RadGanttView__ and will show you how to:

* [Add RadGanttView to your project](#add-radganttview-to-your-project)

* [Define Columns](#define-columns)

* [Bind the GanttView to a simple Tasks collection](#bind-the-ganttview)

>In order to use the __RadGanttView__ control in your projects you have to add references to the following assemblies:
>	* Telerik.Windows.Controls
>	* Telerik.Windows.Controls.GanttView
>	* Telerik.Windows.Scheduling.Core

## Add RadGanttView to your project

* Create new {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} project.

* Now add a __RadGanttView__ control to the user control. You can add the control by dragging it from the Toolbox and dropping it over the XAML or do it manually by writing the XAML code that is shown below. 

#### __XAML__

{{region radganttview-getting-started_0}}
	<UserControl
	   ...
	   xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	   ...>
	      <Grid>
	         <telerik:RadGanttView x:Name="ganttView" />
	      </Grid>
	</UserControl>
{{endregion}}

* Now if you run the application you will see an empty GanttView:

![ganttview gettingstarted 010](images/ganttview_gettingstarted_010.png)

## Define columns

You should manually define the columns of the data grid in order to show additional details of the task:

#### __XAML__

{{region radganttview-getting-started_3}}
	<telerik:RadGanttView x:Name="ganttView">
		<telerik:RadGanttView.Columns>
			<telerik:TreeColumnDefinition Header="Title" Width="AutoHeaderAndContent"/>
			<telerik:ColumnDefinition MemberBinding="{Binding Start}" Header="Start" Width="AutoHeaderAndContent"/>
			<telerik:ColumnDefinition MemberBinding="{Binding End}" Header="End" Width="AutoHeaderAndContent"/>
		</telerik:RadGanttView.Columns>
	</telerik:RadGanttView>
{{endregion}}

>Check the [Columns Overview]({%slug radganttview-features-columns-types%}) topic for more information about the columns of the data grid.    

## Bind the GanttView

* In order to populate your GanttView control with some sample data, first you should create a collection of __GanttTask__ objects: 

#### __C#__

{{region radganttview-getting-started_1}}
	var date = DateTime.Now;
	
	var task1 = new GanttTask( date, date.AddDays(1), "task 1");
	var task2 = new GanttTask( date.AddDays(1), date.AddDays(1).AddHours(15), "task 2");
	
	var mainTask = new GanttTask(date, date.AddDays(2), "my task")
	{
		Children = { task1, task2 }
	};
	
	var Tasks = new ObservableCollection<GanttTask>() { mainTask };
{{endregion}}

* Then bind Tasks collection to __TasksSource__ property of the RadGanttView:

#### __XAML__

{{region radganttview-getting-started_2}}
	<telerik:RadGanttView x:Name="ganttView" TasksSource="{Binding Tasks}">
	...
	</telerik:RadGanttView>
	{{endregion}}

Now run your application and see the result:

![ganttview gettingstarted 020](images/ganttview_gettingstarted_020.png)
