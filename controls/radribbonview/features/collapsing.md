---
title: Collapsing
page_title: Collapsing
description: This article describes the collapsing feature of the RadRibbonView.
slug: radribbonview-collapsing
tags: collapsing
published: True
position: 6
---

# Collapsing

__RadRibbonView__ supports collapsing, which means that the control will automatically set the __Visibility__ of its main panel to __Collapsed__ to save space. This happens when the window in which the control is hosted is resized to a size smaller than the __CollapseThresholdSize__.

#### __Figure 1: RadRibbonView collapsing functionality__
![RadRibbonView collapsing functionality](images/RibbonView_Collapsing.gif)

## Properties

The following properties are related to the collapse functionality:

* __IsCollapsed__: A property of type __bool__, which gives information about the current state of the __RadRibbonView__ control. This property is __read-only__.  

* __CollapseThresholdSize__: A property of type [Size](https://docs.microsoft.com/en-us/dotnet/api/system.windows.size?view=netframework-4.8), which allows you to control the threshold for collapsing. The default value is __300, 250__.  

	__Example 1: Setting the CollapseThresholdSize__
	<snippet id='radribbonview-features-collapsing-block_1-xaml' />

## Events

You can use the __CollapsedChanged__ event to be notified when collapsed state of the ribbon is changed.				

__Example 2: Adding a handler to the CollapsedChanged event__
<snippet id='radribbonview-features-collapsing-block_2-xaml' />

__Example 3: Handling the CollapsedChanged event__
<snippet id='radribbonview-features-collapsing-block_3-cs' />
<snippet id='radribbonview-features-collapsing-block_4-vb' />

> For more information about the events exposed by the __RadRibbonView__, check out the [Events - Overview]({%slug radribbonview-events-overview%}) topic.