---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radtimespanpicker-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

This topic will walk you through the creating of  __RadTimeSpanPicker__.    

>In order to use __RadTimeSpanPicker__ in your project you have to add references to the following two assemblies:
> * Telerik.Windows.Controls.dll
> * Telerik.Windows.Controls.Input.dll

You can include the control in your page by either dragging it from the toolbox in Visual Studio, or manually creating the control. Below is an example of how to create __RadTimeSpanPicker__ in XAML

#### __[XAML] Creating RadTimeSpanPicker__

{{region xaml-radtimespanpicker-getting-started_0}}
	<UserControl xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
	    <Grid x:Name="LayoutRoot" Background="White">
	        <telerik:RadTimeSpanPicker GenerateDefaultComponents="True"/>
	    </Grid>
	</UserControl>
{{endregion}}

You can also create __RadTimeSpanPicker__ in code-behind:

#### __[C#]  Creating RadTimeSpanPicker in code__

{{region cs-radtimespanpicker-getting-started_0}}
	RadTimeSpanPicker timeSpanPicker = new RadTimeSpanPicker();
	timeSpanPicker.GenerateDefaultComponents = true;
{{endregion}}

#### __[VB]  Creating RadTimeSpanPicker in code__

{{region vb-radtimespanpicker-getting-started_0}}
	Dim timeSpanPicker As New RadTimeSpanPicker()
	timeSpanPicker.GenerateDefaultComponents = True
{{endregion}}

By setting the __GenerateDefaultComponents__ property to __True__ the control will use the default components for hours, minutes and seconds. If you need to visualize some of the other built-in components or a custom component of your own you could add them as shown below to the TimeSpanComponents collection:

#### __[XAML] Adding TimeSpanComponents__

{{region xaml-radtimespanpicker-getting-started_1}}
	<UserControl xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
	    <Grid x:Name="LayoutRoot1" Background="White">
	        <telerik:RadTimeSpanPicker>
	            <telerik:RadTimeSpanPicker.TimeSpanComponents>
	                <telerik:DayTimeSpanComponent/>
	                <telerik:HourTimeSpanComponent/>
	                <telerik:MinuteTimeSpanComponent/>
	                <telerik:SecondTimeSpanComponent/>
	                <telerik:MillisecondTimeSpanComponent/>
	            </telerik:RadTimeSpanPicker.TimeSpanComponents>
	        </telerik:RadTimeSpanPicker>
	    </Grid>
	</UserControl>
{{endregion}}

## See Also

 * [Overview]({%slug radtimespanpicker-overview%})

 * [Visual Structure]({%slug radtimespanpicker-visual-structure%})
