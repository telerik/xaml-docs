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

One of the gauges you can create with the __RadGauge__ control, is a linear gauge. It is represented by a rectangular container with a linear scale in it. Additionally, it can display various indicators that point to a certain value on the scale. This topic will walk you through the creation of a sample application that contains a linear RadGauge.

* [Assembly References](#assembly-references)
* [Defining a Linear Gauge with a Linear Scale](#defining-a-linear-gauge-with-a-linear-scale)
* [Defining an Indicator](#defining-an-indicator)
* [Set Indicator's Position](#set-indicators-position)

## Assembly References

In order to use the __RadGauge__ control in your projects, you have to add references to the following assemblies:			

* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.DataVisualization__

## Defining a Linear Gauge with a Linear Scale

The linear gauge type is represented by the __HorizontalLinearGauge__ or __VerticalLinearGauge__ class. You can use either of them to have vertical or horizontal orientated gauges. The linear gauge control is used for wrapping linear scales. You can place one or more __LinearScale__ objects inside of it. In order to define a scale inside the __LinearGauge__ control, you have to use the __LinearScale__ control. The __LinearGauge__ works as an __ItemsControl__, which takes __LinearScale__ controls as items. This means that you can have more than one scale inside the linear gauge.

>To use the __RadGauge__ control and its components in XAML you have to declare the following namespace:  
>`xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"`

#### __[XAML] Example 1: Creating RadVerticalLinearGauge with a VerticalLinearScale__
{{region xaml-radgauge-getting-started-creating-linear-gauge_2}}
	<telerik:RadVerticalLinearGauge Width="100" Height="200">
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

>tip To learn more about the usage of the __LinearScale__ control, read the [Linear Scale]({%slug linear-scale-overview%}) topic.

#### __Image 1: Result from Example 1__

![RadVerticalLinearGauge with a VerticalLinearScale](images/RadGauge_GettingStarted_LinearGauge_02.png)

> The examples in this article are styled with the [Windows8]({%slug common-styles-appearance-colorizing-metro-theme%}) theme.

## Defining an Indicator

The __LinearScale__ control allows you to display different types of indicators that point to a value on the scale. To specify an indicator use the __Indicators__ property, which is of type __ItemCollection__. This means that the __Indicators__ property can hold more than one indicator. Example 2 shows how you can define a LinearScale that uses a Marker indicator to mark the current value.

#### __[XAML] Example 2: Adding Indicators__
{{region xaml-radgauge-getting-started-creating-linear-gauge_3}}
	<telerik:RadVerticalLinearGauge Width="100" Height="200">
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

#### __Image 2: Result from Example 2__

![RadVerticalLinearGauge with Indicator](images/RadGauge_GettingStarted_LinearGauge_03.png)

## Set Indicator's Position

To make the indicator point to a certain value on the scale, you have to use the Value property of the indicator. 

#### __[XAML] Example 3: Setting indicator's position__
{{region xaml-radgauge-getting-started-creating-linear-gauge_4}}
	<telerik:RadVerticalLinearGauge Width="100" Height="200">
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

#### __Image 3: Result from Example 3__

![RadVerticalLinearGauge with Indicator position](images/RadGauge_GettingStarted_LinearGauge_04.png)

## See Also

* [Ranges]({%slug radgauge-features-ranges-gauge-range%})
* [Indicators]({%slug radgauge-features-indicators-basics%})
* [Ticks]({%slug radgauge-features-ticks-basics%})
* [Labels]({%slug radgauge-features-labels-basics%})