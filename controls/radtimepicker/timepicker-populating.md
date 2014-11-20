---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radtimepicker-timepicker-populating
tags: getting,started
published: True
position: 2
---

# Getting Started

RadTimePicker is a control that displays a time representation from which the user can select a single time.

>In order to use __RadTimePicker__ control in your projects you have to add references to the following assemblies:
>	1. __Telerik.Windows.Controls__
>	1. __Telerik.Windows.Controls.Input__
>	You can find more info {% if site.site_name == 'Silverlight' %}[here]({%slug installation-installing-controls-dependencies%}){% endif %}{% if site.site_name == 'WPF' %}[here]({%slug installation-installing-controls-dependencies-wpf%}){% endif %}.

__HeaderText:__

__HeaderContent__ property can be used to customize the TimePickers header. You can use for header almost all types of controls.

__Selection:__

The __SelectedTime__ property holds the selected time.  

#### __C#__

{{region radtimepicker-timepicker-populating_0}}
	timePicker.SelectedTime = new TimeSpan(3,0,0);
{{endregion}}

__Populating:__

You can limit the times that can be selected by setting the __StartTime__ and __EndTime__ properties. The __TimeInterval__property allows user to specify the interval between time slots available for selection. RadTimePicker also allows binding to various data source types through __ClockItemSource__ property.

#### __XAML__

{{region radtimepicker-timepicker-populating_1}}
	<telerik:RadTimePicker TimeInterval="0:30:0" StartTime="0:0:0" EndTime="7:0:0" />
{{endregion}}

The following example demonstrate how to bind RadTimePicker to observable collection from TimeSpan objects.

#### __C#__

{{region radtimepicker-timepicker-populating_2}}
	public DataBinding()
	{
		this.radTimePicker.ClockItemSource = this.LoadDataObjects(); 
	}
	public ObservableCollection<TimeSpan> LoadDataObjects()
	{
		ObservableCollection<TimeSpan> times = new ObservableCollection<TimeSpan>()
		{ 
		   new TimeSpan(9,0,0),
		   new TimeSpan(10,0,0),
		   new TimeSpan(10,5,0),
		   new TimeSpan(10,22,0),
		};
		return times;
	}
{{endregion}}

For more information on the handling the selection events, see the Binding section.

__Clock:__

If you need a clock that takes less space, use the RadClock control which in its essence is a panel with header and times and have almost all of the properties of TimePicker.

![](images/Clock.jpg)

__Styling and Appearance:__

The TimePicker control has __IconButtonStyle__ property that can be used to style the toggle button of the control and also support different layouts for the Clock using __ClockPanel__property. For more information see the Styling and Appearance section.