---
title: Analytics Support
page_title: Analytics Support
description: This article explains how to trace certain features of the Telerik UI for {{ site.framework_name }} controls and get statistics about their usage.
slug: analytics-support
tags: analytics,support
published: True
position: 1
---

# Analytics Support

When you are creating an application for a broad audience, integrating some kind of analytics framework is crucial, because you will need to analyze the usage data of the application and its features and most probably you will need to know about any application crashes or other errors that occurred during the execution. Using analytics you will be able to trace certain features of the controls and get statistics about their usage.

The analytics support is implemented through the `TraceMonitor` static class and its `AnalyticsMonitor`. To enable this feature, the `ITraceMonitor` interface should be implemented and assigned to the `TraceMonitor.AnalyticsMonitor` property.

## Implementing ITraceMonitor

The `ITraceMonitor` interface provides the following set of methods.

* `TrackAtomicFeature`: This method is called when an atomic feature is executed.
* `TrackFeatureStart`: This method is called when a feature is initiated.
* `TrackFeatureEnd`: This method is called when a feature finishes execution.
* `TrackFeatureCancel`: This method is called when a feature is canceled.
* `TrackError`: Traces an error in a specified feature.
* `TrackValue`: This method is called when a value connected with a specific feature is tracked.

The methods are invoked automatically by some of the Telerik controls (the ones supporting the trace monitor). A different method will be called based on the executed action. For all other cases (where Telerik doesn't automatically call the methods), you can call the methods manually on the corresponding action. 

__Implementing the ITraceMonitor__
```C#
	public class ApplicationTraceMonitor : ITraceMonitor
	{
		 public void TrackAtomicFeature(string feature)
		 {           
			// The 'feature' parameter of the methods gives the analytics name of the corresponding control along with the action name. For example, if the analytics name of the control is "MyCloseButton" and the executed action is "Click" you will get "MyCloseButton.Click" as the 'feature'.
			
			// Send the feature information to the analytics service you are using (example: Google Analytics or similar)
		 }

		 public void TrackError(string feature, Exception exception)
		 {
			 // Send the feature information to the analytics service you are using (example: Google Analytics or similar)
		 }

		 public void TrackFeatureCancel(string feature)
		 {
			 // Send the feature information to the analytics service you are using (example: Google Analytics or similar)
		 }

		 public void TrackFeatureEnd(string feature)
		 {
			 // Send the feature information to the analytics service you are using (example: Google Analytics or similar)
		 }

		 public void TrackFeatureStart(string feature)
		 {
			 // Send the feature information to the analytics service you are using (example: Google Analytics or similar)
		 }

		 public void TrackValue(string feature, long value)
		 {
			 // Send the feature information to the analytics service you are using (example: Google Analytics or similar)
		 }
	}
```

To enable the implemented trace monitor, set the static `TraceMonitor.AnalyticsMonitor` property.

__Setting the TraceMonitor.AnalyticsMonitor__  
```C#
	public MainWindow()
	{
		TraceMonitor.AnalyticsMonitor = new ApplicationTraceMonitor();
		InitializeComponent();
	}
```
```VB.NET
	TraceMonitor.AnalyticsMonitor = New MyMonitor()
```

To __include a control in the analytics tracking__, set the `Analytics.Name` attached property on it.

__Setting Analytics.Name property__
```XAML
	<StackPanel Orientation="Horizontal"> 
	    <telerik:RadComboBox Width="200" telerik:Analytics.Name="ComboBoxSelection"> 
	        <telerik:RadComboBoxItem Content="WinUI" /> 
	        <telerik:RadComboBoxItem Content="WPF" /> 
	        <telerik:RadComboBoxItem Content="Blazor" /> 
	        <telerik:RadComboBoxItem Content="WinForms" /> 
	    </telerik:RadComboBox> 
	    <telerik:RadButton telerik:Analytics.Name="SelectButton" Content="Select" /> 
	</StackPanel>
```

In the example above, if you click on the `RadButton` the `TrackAtomicFeature` method of the `ITraceMonitor` will be invoked. The `feature` string will be "SelectButton.Click". Opening and closing the `RadComboBox` will call the `TrackAtomicFeature` method with the `feature` set to "ComboBoxSelection.DropDownOpened" and "ComboBoxSelection.DropDownClosed". 
The different Telerik controls will report different actions and may use the other methods of the monitor.

To add a feature tracking outside of the features tracked by default, you can manually call the methods of the `ITraceMonitor`.

__Tracking features manually__
```C#
	private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
	{
		string featureContent = "WPFApplication.Exception";
		TraceMonitor.AnalyticsMonitor.TrackError(featureContent, e.Exception);
	}

	private void RadPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
	{
		string featureContent = "LoginPasswordBox.PasswordChanged";
		TraceMonitor.AnalyticsMonitor.TrackAtomicFeature(featureContent);
	}
```

## Traceable Features in Telerik Controls

Currently, only a few controls support analytics out of the box. Note that only user interactions will be tracked - initial values and values from bindings are not supported.
       
### Supported controls and features
	   
Feature Action	|	Feature Name
---	|	---
__RadBusyIndicator__	|	
Show	|	ShowIndicator
__RadCalendar__ |
SelectionChanged	|	SelectionChanged
__RadCarousel__ |
SelectionChanged	|	SelectionChanged
__RadColorEditor__ |
SelectionChanged	|	SelectionChanged
__RadColorPicker__ |
SelectionChanged	|	SelectionChanged
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
SelectionChanged	|	SelectionChanged
__RadListBox__ |
SelectionChanged	|	SelectionChanged
__RadMenu__	|	
Click	|	Click
__RadRadioButton__ |	
Checked	|	Checked
UnChecked	|	UnChecked	
__RadRibbonView__ |
SelectionChanged	|	SelectionChanged
__RadRichTextBox__	|	
Open Document	|	Open Document
Save Document	|	Save Document
Print	|	Print
__RadSpreadsheet__ |	
Open Document	|	Open Document
Save Document	|	Save Document
Load Image	|	LoadImage
Save Image	|	SaveImage	
__RadTabControl__ |
SelectionChanged	|	SelectionChanged
__RadTileView__	|
SelectionChanged	|	SelectionChanged
__RadToggleButton__	|	
Checked	|	Checked
UnChecked	|	UnChecked
__RadTreeListView__	|	
Sort	|	Sorted
Group	|	Grouped
Filter	|	Filtered
SelectionChanged	|	SelectionChanged
__RadTreeView__ |
SelectionChanged	|	SelectionChanged
__RadVirtualGrid__ |
SelectionChanged	|	SelectionChanged

>important With the [discontinuation of the Telerik Platform](https://www.telerik.com/platform-next-level) as of **R2 2018 SP1** we've also removed the two dependent assemblies from our suite - **EQATEC.Analytics.Monitor.dll** and **Telerik.Windows.Analytics.dll**. The respective NuGet packages have been removed as well. Instead, the **ITraceMonitor** interface should be used as explained below.

{% if site.site_name == 'WPF' %}
## See Also  
* [Google Analytics Integration]({%slug google-analytics-integration%})
{% endif %}
