---
title: Analytics Support
page_title: Analytics Support
description: Analytics Support
slug: analytics-support
tags: analytics,support
published: True
position: 1
---

# Analytics Support

When you are creating an application for a broad audience, integrating some kind of analytics framework is crucial, because you will need to analyze the usage data of the application and its features and most probably you will need to know about any application crashes or other errors that occurred during the execution. Using analytics you will be able to trace certain features of the controls and get statistics about their usage.

This article will discuss the following topics:

* [ITraceMonitor Interface](#itracemonitor-interface)
* [How Analytics Works](#how-analytics-works)
* [Traceable Features](#traceable-features)

## ITraceMonitor Interface

As of **R2 2017 SP1**, the UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} suite exposes the **ITraceMonitor** interface which represents a monitor which receives trace events from the controls.

You need to implement the following methods in order to receive trace events from the controls used in your application:

* **TrackAtomicFeature**: This method is called when an atomic feature is executed.
* **TrackFeatureStart**: This method is called when a feature is initiated.
* **TrackFeatureEnd**: This method is called when a feature finishes execution.
* **TrackFeatureCancel**: This method is called when a feature is canceled.
* **TrackError**: Traces an error in a specified feature.
* **TrackValue**: This method is called when a value connected with a specific feature is tracked.

Once you've created your implementation of the interface in accordance to your provider of choice you need to set the static **TraceMonitor.AnalyticsMonitor** property as shown in **Example 1**.

#### __[C#] Example 1: Set TraceMonitor.AnalyticsMonitor__

{{region cs-application-analytics_1}}
	TraceMonitor.AnalyticsMonitor = new MyMonitor();
{{endregion}}

#### __[VB.NET] Example 1: Set TraceMonitor.AnalyticsMonitor__

{{region vb-application-analytics_1}}
	TraceMonitor.AnalyticsMonitor = New MyMonitor()
{{endregion}}

## How Analytics Works
      
Let's first define a couple of controls.

#### __[XAML] Example 2: Add controls__

{{region xaml-application-analytics_2}}
	<StackPanel Orientation="Horizontal"> 
	    <telerik:RadComboBox Width="200"> 
	        <telerik:RadComboBoxItem Content="Silverlight" /> 
	        <telerik:RadComboBoxItem Content="WPF" /> 
	        <telerik:RadComboBoxItem Content="ASP.NET AJAX" /> 
	        <telerik:RadComboBoxItem Content="WinForms" /> 
	    </telerik:RadComboBox> 
	    <telerik:RadButton Content="Select" Click="Select_Click" /> 
	</StackPanel> 
{{endregion}}

All that is needed to enable analytics for these controls is to set the __telerik:Analytics.Name__ attached property. This has been demonstrated in __Example 4__. Note that the set values will be used in the dashboard.

#### __[XAML] Example 3: Set Analytics.Name property__

{{region application-analytics_3}}
	<StackPanel Orientation="Horizontal"> 
	    <telerik:RadComboBox Width="200" telerik:Analytics.Name="ComboBoxSelection"> 
	        <telerik:RadComboBoxItem Content="Silverlight" /> 
	        <telerik:RadComboBoxItem Content="WPF" /> 
	        <telerik:RadComboBoxItem Content="ASP.NET AJAX" /> 
	        <telerik:RadComboBoxItem Content="WinForms" /> 
	    </telerik:RadComboBox> 
	    <telerik:RadButton telerik:Analytics.Name="SelectButton" Content="Select" Click="Select_Click" /> 
	</StackPanel>
{{endregion}}

You can then go to the dashboard of your analytics provider, where you will find information and statistics for the registered features for different periods of time.

## Traceable Features

Currently only a few controls support analytics out of the box. Note that only user interactions will be tracked - initial values and values from bindings are not supported.

#### __Table 1: Supported controls and features__
        
Feature	|	Feature Name
---	|	---
__RadBusyIndicator__	|	
Show	|	ShowIndicator
__RadComboBox__	|	
SelectionChanged	|	SelectionChanged
DropDownOpened	|	DropDownOpened
DropDownClosed	|	DropDownClosed	
__RadContextMenu__	|	
Open	|	Opened
Close	|	Closed
Click	|	Click
__RadDropDownButton__|	
DropDownOpened	|	DropDownOpened
DropDownClosed	|	DropDownClosed
__RadExpander__ |	
Expanded	|	Expanded
Collapsed	|	Collapsed
__RadGridView__	|	
Sort	|	Sorted
Group	|	Grouped
Filter	|	Filtered
__RadMenu__	|	
Click	|	Click
__RadRadioButton__ |	
Checked	|	Checked
UnChecked	|	UnChecked	
__RadRichTextBox__	|	
Open Document	|	Open Document
Save Document	|	Save Document
Print	|	Print
__RadSpreadsheet__ |	
Open Document	|	Open Document
Save Document	|	Save Document
Load Image	|	LoadImage
Save Image	|	SaveImage	
__RadToggleButton__	|	
Checked	|	Checked
UnChecked	|	UnChecked
__RadTreeListView__	|	
Sort	|	Sorted
Group	|	Grouped
Filter	|	Filtered

## See Also

* [Google Analytics Integration]({%slug google-analytics-integration%})