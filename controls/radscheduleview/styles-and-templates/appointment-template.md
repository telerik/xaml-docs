---
title: Appointment Template
page_title: Appointment Template
description: Check our &quot;Appointment Template&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-styles-and-templates-appointment-template
tags: appointment,template
published: True
position: 1
---

# Appointment Template

This help topic explains in details how you can customize the template of the appointments using AppointmentItemContentTemplate or AppointmentItemContentTemplateSelector properties. The second approach is used when you need to apply different templates according to some custom logic.

## Setting AppointmentItemContentTemplate

RadScheduleView provides an easy way to change the appointment template through its __AppointmentContentTemplate__ property.

The DataContext of the defined DataTemplate that we will be set to __AppointmentContentTemplate__ is of type __AppointmentProxy__ - it holds the most important properties of the Appointment and the Appointment itself. 

Let's for example have a [Custom Appointment]({%slug radscheduleview-features-appointments-custom-appointment%}) with IsDone custom property:



```C#
	public class Task : Appointment
	{
	    private bool isDone;
	    public bool IsDone
	    {
	        get
	        {
	            return this.Storage<Task>().isDone;
	        }
	        set
	        {
	            var storage = this.Storage<Task>();
	            if (storage.isDone != value)
	            {
	                storage.isDone = value;
	                this.OnPropertyChanged(() => this.IsDone);
	            }
	        }
	    }
		...
	}
```

We will create the following DataTemplate in order to show some additional information about the appointment:



```XAML
	<telerik:BooleanToVisibilityConverter x:Key="BooleanToVisibilityConverter" />
	<DataTemplate x:Key="AppointmentTemplate">
		<StackPanel>
			<TextBlock Text="{Binding Subject}" TextWrapping="Wrap" TextTrimming="WordEllipsis"/>
			<TextBlock Text="{Binding Body}" FontStyle="Italic" TextWrapping="Wrap" TextTrimming="WordEllipsis"/>
			<TextBlock Text="Finished" Foreground="Red" Visibility="{Binding Appointment.IsDone, Converter={StaticResource BooleanToVisibilityConverter}}" />            
		</StackPanel>
	</DataTemplate>
```

>Note that custom properties should be bound through Appointment property of the DataContext.

Then the DataTemplate should be set to __AppointmentContentTemplate__ property of the ScheduleView control:        



```XAML
	<telerik:RadScheduleView 
			AppointmentsSource="{Binding Appointments}"						
			AppointmentItemContentTemplate="{StaticResource AppointmentTemplate}">
		...
	</telerik:RadScheduleView>
```

Here is the end result:

![radscheduleview appointment template 1](images/radscheduleview_appointment_template_1.png)

## Setting AppointmentItemContentTemplateSelector

In some cases there is a need to apply different templates to the appointments according to some condition - this can be achieved by setting __AppointmentItemContentTemplateSelector__ property of the ScheduleView control.

Let's, for example create separate appointment templates for the different ViewDefinitions of the control - a more detailed template for DayViewDefinition and a simple template for WeekViewDefinition.

First, we will have to create a custom class which inherits from Telerik.Windows.Controls.ScheduleViewDataTemplateSelector, define the needed DataTemplates in it and override SelectTemplate method:



```C#
	public class CustomAppointmentTemplateSelector : Telerik.Windows.Controls.ScheduleViewDataTemplateSelector
	{
	    public DataTemplate DayAppointmentTemplate { get; set; }
		public DataTemplate DefaultAppointmentTemplate { get; set; }
			
	
		public override DataTemplate SelectTemplate(object item, DependencyObject container, Telerik.Windows.Controls.ViewDefinitionBase activeViewDefinition)
		{
	        if (activeViewDefinition is WeekViewDefinition)
	            return this.DefaultAppointmentTemplate;
	
			if (activeViewDefinition is DayViewDefinition)
				return this.DayAppointmentTemplate;		
	
			return base.SelectTemplate(item, container, activeViewDefinition);
		}
	}
```

Then define the CustomAppointmentTemplateSelector and the DataTemplates in XAML:



```XAML
	<local:CustomAppointmentTemplateSelector x:Key="CustomAppointmentTemplateSelector">
	    <local:CustomAppointmentTemplateSelector.DayAppointmentTemplate>
	        <DataTemplate>
	            <StackPanel>
	                <TextBlock Text="{Binding Subject}" TextWrapping="Wrap" TextTrimming="WordEllipsis"/>
	                <TextBlock Text="{Binding Body}" TextWrapping="Wrap" TextTrimming="WordEllipsis"/>
	                <TextBlock Text="Finished" Foreground="Red" Visibility="{Binding Appointment.IsDone, Converter={StaticResource BooleanToVisibilityConverter}}" />
	            </StackPanel>
	        </DataTemplate>
	    </local:CustomAppointmentTemplateSelector.DayAppointmentTemplate>
	    <local:CustomAppointmentTemplateSelector.DefaultAppointmentTemplate>
	        <DataTemplate>
	            <TextBlock Text="{Binding Subject}" TextWrapping="Wrap" TextTrimming="WordEllipsis"/>
	        </DataTemplate>
	    </local:CustomAppointmentTemplateSelector.DefaultAppointmentTemplate>
	</local:CustomAppointmentTemplateSelector>
```

And apply it to the ScheduleView:



```XAML
	<telerik:RadScheduleView 
			AppointmentsSource="{Binding Appointments}"						
			AppointmentItemContentTemplateSelector="{StaticResource CustomAppointmentTemplateSelector}">
			...
	</telerik:RadScheduleView>
```

The following screenshot shows how the same appointment looks in different ViewDefinitions:

![radscheduleview appointment template 2](images/radscheduleview_appointment_template_2.png)