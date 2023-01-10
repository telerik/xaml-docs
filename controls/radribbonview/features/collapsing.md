---
title: Collapsing
page_title: Collapsing
description: This article describes the collapsing feature of the RadRibbonView.
slug: radribbonview-collapsing
tags: collapsing
published: True
position: 6
---

# {{ site.framework_name }} RadRibbonView Collapsing

__RadRibbonView__ supports collapsing, which means that the control will automatically set the __Visibility__ of its main panel to __Collapsed__ to save space. This happens when the window in which the control is hosted is resized to a size smaller than the __CollapseThresholdSize__.

#### __Figure 1: RadRibbonView collapsing functionality__
![RadRibbonView collapsing functionality](images/RibbonView_Collapsing.gif)

## Properties

The following properties are related to the collapse functionality:

* __IsCollapsed__: A property of type __bool__, which gives information about the current state of the __RadRibbonView__ control. This property is __read-only__.  

* __CollapseThresholdSize__: A property of type [Size](https://docs.microsoft.com/en-us/dotnet/api/system.windows.size?view=netframework-4.8), which allows you to control the threshold for collapsing. The default value is __300, 250__.  

	#### __[XAML] Example 1: Setting the CollapseThresholdSize__
	{{region radribbonview-collapsing_0}}
		<telerik:RadRibbonView x:Name="radRibbonView" CollapseThresholdSize="100,100">
			...
		</telerik:RadRibbonView>
	{{endregion}}

## Events

You can use the __CollapsedChanged__ event to be notified when collapsed state of the ribbon is changed.				

#### __[XAML] Example 2: Adding a handler to the CollapsedChanged event__
{{region radribbonview-collapsing_1}}
	<telerik:RadRibbonView x:Name="radRibbonView" CollapseThresholdSize="100,100" CollapsedChanged="radRibbonView_CollapsedChanged">
	 ...
	</telerik:RadRibbonView>
{{endregion}}

#### __[C#] Example 3: Handling the CollapsedChanged event__
{{region radribbonview-collapsing_2}}
	private void radRibbonView_CollapsedChanged(object sender, Telerik.Windows.RadRoutedEventArgs e)
	{
		RadRibbonView ribbonView = sender as RadRibbonView;
		bool isCollapsed = ribbonView.IsCollapsed;
	}
{{endregion}}

#### __[VB.NET] Example 3: Handling the CollapsedChanged event__
{{region radribbonview-collapsing_3}}
	Private Sub radRibbonView_CollapsedChanged(sender As Object, e As Telerik.Windows.RadRoutedEventArgs)
		Dim ribbonView As RadRibbonView = TryCast(sender, RadRibbonView)
		Dim isCollapsed As Boolean = ribbonView.IsCollapsed	
	End Sub
{{endregion}}

> For more information about the events exposed by the __RadRibbonView__, check out the [Events - Overview]({%slug radribbonview-events-overview%}) topic.