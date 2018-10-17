---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radbulletgraph_getting_started
tags: getting,started
published: True
position: 0
---

# Getting Started

This tutorial will walk you through the creation of a RadBulletGraph.

* [Assembly References](#assembly-references)
* [Defining the RadBulletGraph](#defining-the-radbulletgraph)

## Assembly References
> In order to use RadBulletGraph in your project you have to add a reference to the following assemblies:
>	1. __Telerik.Windows.Controls__
>	2. __Telerik.Windows.Controls.DataVisualization__
>	3. __Telerik.Windows.Data__

## Defining the RadBulletGraph

There are two main types of bullet graphs - horizontal and vertical, depending on the direction in which the control is drawn.

#### __[XAML] Example 1: Defining horizontal bulletgraph control__
{{region radbulletgraph_getting_started_0}}
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
{{region radbulletgraph_getting_started_1}}
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