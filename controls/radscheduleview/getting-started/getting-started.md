---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radscheduleview-getting-started
tags: getting,started
published: True
position: 0
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains __RadScheduleView__ and will show you how to:      

* [Add RadScheduleView in your projects](#adding-radscheduleview-to-the-project)

* [Add a ViewDefinition to the RadScheduleView control](#adding-a-viewdefinition-to-the-radscheduleview-control)

* [Bind your RadScheduleView control to a collection of appointments](#bind-your-radscheduleview-control-to-a-collection-of-appointments)

## Adding RadScheduleView to the project

For the purpose of this example, you will need to create an empty {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} Application project and open it in Visual Studio.

>In order to add RadScheduleView control in your projects you have to add references to the following assemblies:
>1. __Telerik.Windows.Controls__
>2. __Telerik.Windows.Controls.Input__
>3. __Telerik.Windows.Controls.Navigation__
>4. __Telerik.Windows.Controls.ScheduleView__
>5. __Telerik.Windows.Data__

* Now add a __RadScheduleView__ control to the MainWindow control. You can add the control by dragging it from the __Toolbox__ and dropping it over the XAML or do it manually by writing the XAML code that is shown below:

#### __XAML__

{{region radscheduleview-getting-started_0}}
	<Window x:Class="GettingStarted.MainWindow"         
	 xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"         
	 xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"         
	 xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"         
	 Title="MainWindow" Height="350" Width="790">     
	 <Grid>           
	  <telerik:RadScheduleView />     
	 </Grid>
	</Window>
{{endregion}}

Two lines of code are important here:

* First is the import of the Telerik URL namespace:

#### __XAML__

{{region radscheduleview-getting-started_1}}
	xmlns:telerik=http://schemas.telerik.com/2008/xaml/presentation
{{endregion}}

* And second is the declaration of the __RadScheduleView__ control inside the Grid:

#### __XAML__

{{region radscheduleview-getting-started_2}}
	<telerik:RadScheduleView />
{{endregion}}

There are two things you should do in order to use __RadScheduleView__ control:

1. First is to set a __ViewDefinition__ to the __RadScheduleView__ control.

1. Second is to set a collection of Appointments for __AppointmentsSource__.

## Adding a ViewDefinition to the RadScheduleView control

The following lines will add a DayViewDefinition to the __RadScheduleView__ control:

>You can add more than only one ViewDefinition. There are four view definitions available:
>* DayViewDefinition
>* WeekViewDefinition
>* TimelineViewDefinition
>* MonthViewDefinition
>* CustomViewDefinition

## Bind your RadScheduleView control to a collection of appointments

Now, lets bind the __AppointmentsSource__ to a collection of appointments in our ViewModel, named Appointments:

#### __XAML__

{{region radscheduleview-getting-started_3}}
	<telerik:RadScheduleView AppointmentsSource="{Binding Appointments}">             
	 <telerik:RadScheduleView.ViewDefinitions>                  
	  <telerik:DayViewDefinition />                  
	  <telerik:MonthViewDefinition />             
	 </telerik:RadScheduleView.ViewDefinitions>
	</telerik:RadScheduleView>
{{endregion}}

To learn more about the Appointments of the RadScheduleView take a look at the [Getting Started - Add/Edit/Delete Appointments]({%slug radscheduleview-getting-started-add-edit-delete-appointment%}) topic.

# See Also

 * [Understanding Appointments]({%slug radscheduleview-getting-started-add-edit-delete-appointment%})