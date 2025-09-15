---
title: Templating the ToolTip
page_title: Templating the ToolTip
description: Check our &quot;Templating the ToolTip&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-styles-and-templates-templating-tooltip
tags: templating,the,tooltip
published: True
position: 6
---

# Templating the ToolTip

This help article will show you how to set a custom Appointment ToolTip by using the __ToolTipTemplate__ property of __RadScheduleView__.      

If you have for example __RadScheduleView__ set up the following way:

#### __XAML__

```XAML
	<telerik:RadScheduleView AppointmentsSource="{Binding Appointments}">
	    <telerik:RadScheduleView.ViewDefinitions>
	        <telerik:DayViewDefinition />
	    </telerik:RadScheduleView.ViewDefinitions>
	    <telerik:RadScheduleView.ResourceTypesSource>
	        <telerik:ResourceTypeCollection>
	            <telerik:ResourceType Name="Location">
	                <telerik:Resource ResourceName="Room 1" />
	                <telerik:Resource ResourceName="Room 2" />
	            </telerik:ResourceType>
	        </telerik:ResourceTypeCollection>
	    </telerik:RadScheduleView.ResourceTypesSource>
	    <telerik:RadScheduleView.GroupDescriptionsSource>
	        <telerik:GroupDescriptionCollection>
	            <telerik:DateGroupDescription />
	            <telerik:ResourceGroupDescription ResourceType="Location" />
	        </telerik:GroupDescriptionCollection>
	    </telerik:RadScheduleView.GroupDescriptionsSource>
	</telerik:RadScheduleView>
```

And you want to replace the default ToolTip with custom one which shows the full information of the Appointment including the location of the Appoinment. In this case you can use the ToolTipTemplate property of the __RadScheduleView__. Firstly you need to define appropriate DataTemplate as a resource like shown below:       

#### __XAML__

```XAML
	<DataTemplate x:Key="ToolTipTemplate">
	    <Grid>
	        <Grid.RowDefinitions>
	            <RowDefinition />
	            <RowDefinition />
	            <RowDefinition />
	            <RowDefinition />
	        </Grid.RowDefinitions>
	        <StackPanel Grid.Row="0" Orientation="Horizontal">
	            <TextBlock Text="Subject: " />
	            <TextBlock Text="{Binding Subject}" TextWrapping="Wrap"  FontWeight="Bold" />
	        </StackPanel>
	        <StackPanel Grid.Row="1" Orientation="Horizontal">
	            <TextBlock Text="Body: " />
	            <TextBlock Text="{Binding Body}" TextWrapping="Wrap" />
	        </StackPanel>
	        <StackPanel Grid.Row="2" Orientation="Horizontal">
	            <TextBlock Text="Location: " />
	            <TextBlock Text="{Binding Appointment.Resources[0].ResourceName}" />
	        </StackPanel>
	        <StackPanel Grid.Row="3" Margin="0 5 0 0">
	            <StackPanel Orientation="Horizontal" Margin="0 0 0 0">
	                <TextBlock Text="{Binding Start, StringFormat='hh:mm tt'}" TextWrapping="Wrap" FontSize="10" />
	                <TextBlock Text=" - " FontSize="10" />
	                <TextBlock Text="{Binding End, StringFormat='hh:mm tt'}" TextWrapping="Wrap" FontSize="10" />
	            </StackPanel>
	            <TextBlock Text="{Binding Start, StringFormat='dddd dd MMM yyyy'}" Margin="0 3" FontSize="10" />
	        </StackPanel>
	    </Grid>
	</DataTemplate>
```

>Note that the ToolTip receives object of type AppointmentItemProxy as a DataContext which contains the actual Appointment. You can easily bind to its properties like shown above.          

>importantIf you are using a custom Appointment with custom properties you won't be able to bind directly to them. You should access them through the Appointment property of the AppointmentItemProxy object the following way: Appointment.*CustomProperty*.          

Aftewards you just need to set the DataTemplate as a __ToolTipTemplate__ the following way:        

#### __XAML__

```XAML
	<telerik:RadScheduleView ToolTipTemplate="{StaticResource ToolTipTemplate}" ... >
	    ...
	</telerik:RadScheduleView>
```
And here is the final result:

![radscheduleview-styles-and-templates-templating-tooltip](images/radscheduleview-styles-and-templates-templating-tooltip.png)

## See Also

 * [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%})