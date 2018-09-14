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

The __RadTimePicker__ is a control that displays a range of times from which the user can select a single time. It essentially inherits the [RadDateTimePicker]({%slug raddatetimepicke-getting-started%}) and sets the __InputMode__ property to __TimePicker__.

## Assembly References

In order to use the __RadTimePicker__ control in your projects, you have to add references to the following assemblies:
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Input__

You can find more info {% if site.site_name == 'Silverlight' %}[here]({%slug installation-installing-controls-dependencies%}){% endif %}{% if site.site_name == 'WPF' %}[here]({%slug installation-installing-controls-dependencies-wpf%}){% endif %}.

## Setting the SelectedTime

The __SelectedTime__ property holds the selected time. Examples 1 and 2 demonstrate how you can set this property in xaml and code behind. For more information, check out the [Selection]({%slug raddatetimepicker-features-selection%}) article of the __RadDateTimePicker__.

#### __[XAML] Example 1: Setting the SelectedTime in xaml__

{{region xaml-radtimepicker-timepicker-populating_0}}
 	<telerik:RadTimePicker x:Name="timePicker" SelectedTime="15:00" />
{{endregion}}

#### __[C#] Example 2: Setting the SelectedTime in code__

{{region cs-radtimepicker-timepicker-populating_1}}
	timePicker.SelectedTime = new TimeSpan(15,0,0);
{{endregion}}

#### __[VB.NET] Example 2: Setting the SelectedTime in code__

{{region vb-radtimepicker-timepicker-populating_2}}
	timePicker.SelectedTime = New TimeSpan(15,0,0)
{{endregion}}

> In order to take some action when the SelectedTime is changed, you can handle the __SelectionChanged__ event. You can check out all of the available events in the [Events]({%slug raddatetimepicker-events%}) article of the RadDateTimePicker.

## StartTime, EndTime and TimeInterval

You can limit the times that can be selected by setting the __StartTime__ and __EndTime__ properties. The __TimeInterval__ property allows user to specify the interval between time slots available for selection. For more information, check out the [Clock Items]({%slug raddatetimepicker-features-clock-items%}#using-the-starttime-endtime-and-timeinterval-features).

#### __[XAML] Example 2: Setting the StartTime, EndTime and TimeInterval__

{{region xaml-radtimepicker-timepicker-populating_3}}
	<telerik:RadTimePicker x:Name="timePicker" TimeInterval="0:30:0" StartTime="0:0:0" EndTime="7:0:0" />
{{endregion}}

## Setting the ClockItemsSource

You can also populate the RadTimePicker from code behind by setting its ClockItemsSource property to a collection of TimeSpan objects. **Example 3** demonstrates how you can achieve this. 

#### __[C#] Example 3: Setting the ClockItemsSource__

{{region cs-radtimepicker-timepicker-populating_4}}
	public DataBinding()
	{
	    this.radTimePicker.ClockItemsSource = this.LoadDataObjects();
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

#### __[VB.NET] Example 3: Setting the ClockItemsSource__

{{region vb-radtimepicker-timepicker-populating_5}}
	Public Sub New()
		Me.radTimePicker.ClockItemsSource = Me.LoadDataObjects()
	End Sub
	Public Function LoadDataObjects() As ObservableCollection(Of TimeSpan)
		Dim times As New ObservableCollection(Of TimeSpan)() From {
			New TimeSpan(9,0,0),
			New TimeSpan(10,0,0),
			New TimeSpan(10,5,0),
			New TimeSpan(10,22,0)
		}
		Return times
	End Function
{{endregion}}

## See also 

* [Layout Support]({%slug radtimepicker-layout-support%})
* [Keyboard Support]({%slug raddatetimepicker-features-keyboard-support%})
* [Parsing Without Separators]({%slug raddatetimepicker-features-parsing-without-separators%}#parsing-the-time-part)