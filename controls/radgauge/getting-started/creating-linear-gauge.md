---
title: Creating Linear Gauge
page_title: Creating Linear Gauge
description: Creating Linear Gauge
slug: radgauge-getting-started-creating-linear-gauge
tags: creating,linear,gauge
published: True
position: 1
---

# Creating Linear Gauge

One of the gauges you can create with the __RadGauge__ control, is a linear gauge. It is represented by a rectangular container with a linear scale in it. Additionally it can display various indicators that point to a certain value off the scale. This topic will guide you in creating a trivial linear gauge and will explain the following:

* [Defining a LinearGauge](#defining-a-linear-gauge)

* [Defining a LinearScale](#defining-a-linearscale)

* [Defining an Indicator](#defining-an-indicator)

* [Set Indicator's Position](#set-indicators-position)

* [Configuring the Gauge](#configuring-the-gauge)

## Defining a Linear Gauge

>In order to use the __RadGauge__ control and its components you have to reference the following assemblies:
>	- __Telerik.Windows.Controls.DataVisualization.dll__
>	- __Telerik.Windows.Controls.dll__

The linear gauge type is represented by the __HorizontalLinearGauge__ or __VerticalLinearGauge__ class. You can use either of them to have vertical or horizontal orientated gauges. The linear gauge control is used for wrapping linear scales. You can place one or more __LinearScale__ objects inside of it. Here is an example of an instance of the __LinearGauge__ control with dimensions __100x300__.

>To use the __RadGauge__ control and its components in XAML you have to declare the following namespace:  
>`xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"`

## Defining a LinearScale

In order to define a scale inside the __LinearGauge__ control you have to use the __LinearScale__ control. The __LinearGauge__ works as an __ItemsControl__, which takes __LinearScale__ controls as items. This means that you can have more than one scale inside the linear gauge.

>tip To learn more about the usage of the __LinearScale__ control read the Linear Scale topic.

Here is an example of a single __LinearScale__:

#### __XAML__
{{region radgauge-getting-started-creating-linear-gauge_2}}
	<telerik:RadVerticalLinearGauge Width="100" Height="200" telerik:StyleManager.Theme="Windows8">
	    <telerik:VerticalLinearScale Min="0" 
	                    Max="20"
	                    RelativeHeight="1"
	                    RelativeY="0"
	                    MiddleTickRelativeWidth="0.05*"
	                    MiddleTickRelativeHeight="0.003*"
	                    MinorTickRelativeHeight="0.003*"
	                    MajorTickRelativeHeight="0.003*">
	    </telerik:VerticalLinearScale>
	</telerik:RadVerticalLinearGauge>
{{endregion}}

Here is a snapshot of the result:

![](images/RadGauge_GettingStarted_LinearGauge_02.png)

## Defining an Indicator

The __LinearScale__ control allows you to display different types of indicators that point to a value off the scale. To specify an indicator use the __Indicators__ property, which is of type __ItemCollection__. This means that the __Indicators__ property can hold more than one indicator. Here is an example of LinearScale that uses a Marker indicator to mark the current value.

#### __XAML__
{{region radgauge-getting-started-creating-linear-gauge_3}}
	<telerik:RadVerticalLinearGauge Width="100" Height="200" telerik:StyleManager.Theme="Windows8">
	    <telerik:VerticalLinearScale Min="0" 
	                         Max="20"
	                         RelativeHeight="1"
	                         RelativeY="0"
	                         MiddleTickRelativeWidth="0.05*"
	                         MiddleTickRelativeHeight="0.003*"
	                         MinorTickRelativeHeight="0.003*"
	                         MajorTickRelativeHeight="0.003*">
	        <telerik:VerticalLinearScale.Indicators>
	            <telerik:Marker telerik:LinearScale.RotateForVertical="True"
	                            telerik:ScaleObject.RelativeWidth="0.08*"
	                            telerik:ScaleObject.RelativeHeight="0.03*" 
	                            telerik:ScaleObject.Location="OverCenter" />
	        </telerik:VerticalLinearScale.Indicators>
	    </telerik:VerticalLinearScale>
	</telerik:RadVerticalLinearGauge>
{{endregion}}

Here is a snapshot of the result.

![](images/RadGauge_GettingStarted_LinearGauge_03.png)

## Set Indicator's Position

To make the indicator point to a certain value off the scale, you have to use the Value property of the indicator. Here is an example:

#### __XAML__
{{region radgauge-getting-started-creating-linear-gauge_4}}
	<telerik:RadVerticalLinearGauge Width="100" Height="200" telerik:StyleManager.Theme="Windows8">
	    <telerik:VerticalLinearScale Min="0" 
	                         Max="20"
	                         RelativeHeight="1"
	                         RelativeY="0"
	                         MiddleTickRelativeWidth="0.05*"
	                         MiddleTickRelativeHeight="0.003*"
	                         MinorTickRelativeHeight="0.003*"
	                         MajorTickRelativeHeight="0.003*">
	        <telerik:VerticalLinearScale.Indicators>
	            <telerik:Marker Value="5"
	                            telerik:LinearScale.RotateForVertical="True"
	                            telerik:ScaleObject.RelativeWidth="0.08*"
	                            telerik:ScaleObject.RelativeHeight="0.03*" 
	                            telerik:ScaleObject.Location="OverCenter" />
	        </telerik:VerticalLinearScale.Indicators>
	    </telerik:VerticalLinearScale>
	</telerik:RadVerticalLinearGauge>
{{endregion}}

Here is a snapshot of the result.

![](images/RadGauge_GettingStarted_LinearGauge_04.png)

## Configuring the Gauge

To configure and setup the linear gauge you can use the various properties of the elements inside of it. In order to get familiar with them read the following topics: 

* [Ranges]({%slug radgauge-features-ranges-gauge-range%})
* [Indicators]({%slug radgauge-features-indicators-basics%})
* [Ticks]({%slug radgauge-features-ticks-basics%})
* [Labels]({%slug radgauge-features-labels-basics%})