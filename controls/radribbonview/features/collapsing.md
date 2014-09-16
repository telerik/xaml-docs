---
title: Collapsing
page_title: Collapsing
description: Collapsing
slug: radribbonview-collapsing
tags: collapsing
publish: True
position: 6
---

# Collapsing



__RadRibbonView__ supports collapsing, which means that the ribbon may automatically collapse to save space when the application is resized to a smaller size.
			

## Properties

The following properties are related to the collapse functionality:

* __RadRibbonView.IsCollapsed__ - gives you information about the current state of the __RadRibbonView__ control. The value of the __IsCollapsed__ property is __True__ if the ribbon bar is collapsed. Respectively - __False__, if the ribbon is __not__ collapsed. The __RadRibbonView__'s __IsCollapsed__ property is __read-only__.
					

* __RadRibbonView.CollapseThresholdSize__ - allows you to control the size under which the __RadRibbonView__ will collapse.
					

#### __XAML__

{{region radribbonview-collapsing_0}}
	<telerik:RadRibbonView x:Name="radRibbonView" CollapseThresholdSize="100,100">
	    ...
	</telerik:RadRibbonView>
	{{endregion}}



## Events

You can use the __CollapsedChanged__ event to be notified when the ribbon collapse state is changed.
				

#### __XAML__

{{region radribbonview-collapsing_1}}
	<telerik:RadRibbonView x:Name="radRibbonView" CollapseThresholdSize="100,100" CollapsedChanged="radRibbonView_CollapsedChanged">
	 ...
	</telerik:RadRibbonView>
	{{endregion}}



#### __C#__

{{region radribbonview-collapsing_2}}
	private void radRibbonView_CollapsedChanged(object sender, Telerik.Windows.RadRoutedEventArgs e)
	{
	 RadRibbonView ribbonView = sender as RadRibbonView;
	 bool isCollapsed = ribbonView.IsCollapsed;
	}
	{{endregion}}



#### __VB.NET__

{{region radribbonview-collapsing_3}}
	Private Sub radRibbonView_CollapsedChanged(sender As Object, e As Telerik.Windows.RadRoutedEventArgs)
		Dim ribbonView As RadRibbonView = TryCast(sender, RadRibbonView)
		Dim isCollapsed As Boolean = ribbonView.IsCollapsed
	
	End Sub
	{{endregion}}



For more information about the events, exposed by the __RadRibbonView__, check out the [Events - Overview]({%slug radribbonview-events-overview%}) topic.
				
