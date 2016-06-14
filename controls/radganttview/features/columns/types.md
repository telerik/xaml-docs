---
title: Overview
page_title: Overview
description: Overview
slug: radganttview-features-columns-types
tags: overview
published: True
position: 0
---

# Overview

In __RadGanttView__ displaying the Tasks fields is done with the use of different columns. There are two types of columns that could be defined in the control: __TreeColumn__ and a normal __Column__. The TreeColumn is a special type of column that is used to visualize the tasks and their children as a tree. Both types of columns have the following customizable Templates: CellTemplate, CellEditTemplate, CellHighlightTemplate and CellSelectionTemplate.

>Before proceeding with the following example you should get familiar with [Implementing View-ViewModel]({%slug radganttview-populating-with-data-viewmodel%}). 

<!-- -->

>With our official Q1 2013 release of __RadGanttView__ you can set each ColumnDefinition’s Width to a set of predefined values (__50__, __100__, __150__, __200__, __250__, __300__, __AutoHeader__ and __AutoHeaderAndContent__). The AutoHeader and AutoHeaderAndContent calculate the necessary Width automatically in the code of the control.
>	* The 50 to 300 values are predefined values in inches.
>	* The AutoHeader is a predefined value that will set the Width of the ColumnDefinition to the __Width__ that is required in order to render its Header.
>	* The AutoHeaderAndContent is a predefined value that will set the Width of the ColumnDefinition to the Width that is required in order to render its Header and content. If one is bigger than the other the bigger value will be used.

We will go to the following sections:

* [Defining columns](#defining-columns)

* [Frozen columns](#frozen-columns)

## Defining columns

In order to define columns in the RadGanttView control all that is needed is to add them to the Columns collection of the control.

* First you will need to declare the RadGanttView control and populate it with some data:

#### __[XAML] Example 1: Declaring RadGanttView__

{{region radganttview-features-columns-types_0}}
	<telerik:RadGanttView TasksSource="{Binding Tasks}"
						  VerticalAlignment="Top"
						  VisibleRange="{Binding VisibleTime}">
	</telerik:RadGanttView>
{{endregion}}

* Then define the needed columns to the Columns collection of the control:

#### __[XAML] Example 2: Adding columns__

{{region radganttview-features-columns-types_1}}
	<telerik:RadGanttView TasksSource="{Binding Tasks}"
						  VerticalAlignment="Top"
						  VisibleRange="{Binding VisibleTime}">
		<telerik:RadGanttView.Columns>
			<telerik:TreeColumnDefinition/>
			<telerik:ColumnDefinition/>
			<telerik:ColumnDefinition/>
		</telerik:RadGanttView.Columns>
	</telerik:RadGanttView>
{{endregion}}

* Finally set the Header, MemberBinding and any other properties of the columns: 

#### __[XAML] Example 3: Setting column properties__

{{region radganttview-features-columns-types_2}}
	<telerik:RadGanttView TasksSource="{Binding Tasks}"
				VerticalAlignment="Top"
				VisibleRange="{Binding VisibleTime}">
		<telerik:RadGanttView.Columns>
			<telerik:TreeColumnDefinition Header="Title" MemberBinding="{Binding Title}" Width="AutoHeaderAndContent"/>
			<telerik:ColumnDefinition MemberBinding="{Binding Start}" Header="Start" Width="AutoHeaderAndContent"/>
			<telerik:ColumnDefinition MemberBinding="{Binding End}" Header="End" Width="AutoHeaderAndContent"/>
		</telerik:RadGanttView.Columns>
	</telerik:RadGanttView>
{{endregion}}

__Figure 1__ shows the final result.

#### __Figure 1: RadGanttView with the defined columns__

![radganttview-features-columns-overview](images/radganttview-features-columns-overview.png)

## Frozen columns

__RadGanttView__ provides a way to exclude one or more columns from the horizontal scrolling by setting their __IsFrozenColumn__ property. The frozen columns stay static on top of the horizontal scrolling. 

Let's, for example, set the first "Title" column to be frozen as shown in __Example 4__.

#### __[XAML] Example 4: Setting IsFrozenColumn property__

{{region radganttview-features-columns-types_3}}
	<telerik:RadGanttView TasksSource="{Binding Tasks}">
		<telerik:RadGanttView.Columns>
			<telerik:TreeColumnDefinition Header="Title" IsFrozenColumn="True" MemberBinding="{Binding Title}" Width="AutoHeaderAndContent" />
			<telerik:ColumnDefinition MemberBinding="{Binding Start}" Header="Start" Width="AutoHeaderAndContent"/>
			<telerik:ColumnDefinition MemberBinding="{Binding End}" Header="End" Width="AutoHeaderAndContent"/>
		</telerik:RadGanttView.Columns>  
	</telerik:RadGanttView>
{{endregion}}

__Figure 2__ illustrates how the "Title" column stays visible while horizontally scrolling the Grid part of RadGanttView.

#### __Figure 2: Scrolling the Grid part with frozen column__

![RadGanttView Frozen Column](images/radganttview-features-columns-overview_01.png)

# See Also

 * [Customizing the CellTemplate]({%slug radganttview-features-columns-cell-template%})

 * [Customizing the CellEditTemplate]({%slug radganttview-features-columns-editing-cells%})

 * [Customizing the CellHighlightTemplate]({%slug radganttview-features-columns-highlight-template%})

 * [Customizing the CellSelectionTemplate]({%slug radganttview-features-columns-selection-template%})
