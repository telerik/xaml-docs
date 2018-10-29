---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radbulletgraph-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

This tutorial will walk you through the creation of a RadBulletGraph.

## Assembly References
 
In order to use RadBulletGraph in your project you have to add a reference to the following assemblies:
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.DataVisualization__ 
* __Telerik.Windows.Data__

You can find the required assemblies for each control from the suite in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% else %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

## Defining the RadBulletGraph

There are two main types of bullet graphs - horizontal and vertical, depending on the direction in which the control is drawn.

#### __[XAML] Example 1: Defining horizontal bulletgraph control__
{{region radbulletgraph-getting-started-0}}
	<telerik:RadHorizontalBulletGraph Width="300" Height="60" Minimum="0" Maximum="100" FeaturedMeasure="60" ComparativeMeasure="65" ProjectedValue="75">
		<telerik:RadHorizontalBulletGraph.QualitativeRanges>
			<telerik:QualitativeRange Brush="#A8A8A8" Value="150" />
			<telerik:QualitativeRange Brush="#C6C8C8" Value="225" />
			<telerik:QualitativeRange Brush="#E8E8E8" />
		</telerik:RadHorizontalBulletGraph.QualitativeRanges>
	</telerik:RadHorizontalBulletGraph>
{{endregion}}

#### __Figure 1: RadHorizontalBulletGraph__
![](images/radbulletgraph_getting_started_0.png)

#### __[XAML] Example 1: Defining vertical bulletgraph control__
{{region radbulletgraph-getting-started-1}}
	<telerik:RadVerticalBulletGraph Width="60" Height="300" Minimum="0" Maximum="100" FeaturedMeasure="60" ComparativeMeasure="65" ProjectedValue="75">
		<telerik:RadVerticalBulletGraph.QualitativeRanges>
			<telerik:QualitativeRange Brush="#A8A8A8" Value="150" />
			<telerik:QualitativeRange Brush="#C6C8C8" Value="225" />
			<telerik:QualitativeRange Brush="#E8E8E8" />
		</telerik:RadVerticalBulletGraph.QualitativeRanges>
	</telerik:RadVerticalBulletGraph>
{{endregion}}

#### __Figure 2: RadVerticalBulletGraph__
![](images/radbulletgraph_getting_started_1.png)

## See Also
* [Overview]({%slug radbulletgraph_overview%})
* [Properties]({%slug radbulletgraph_properties%})
* [Creating a BulletGraph Programmatically]({%slug radbulletgraph_creating_a_bulletgraph_programmatically%})