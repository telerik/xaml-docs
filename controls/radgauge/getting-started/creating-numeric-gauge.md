---
title: Creating Numeric Gauge
page_title: Creating Numeric Gauge
description: Creating Numeric Gauge
slug: radgauge-getting-started-creating-numeric-gauge
tags: creating,numeric,gauge
published: True
position: 2
---

# Creating Numeric Gauge



One of the gauges you can create with the __RadGauge__ control, is a numeric gauge. It is represented by a container with a numerical scale in it. The numerical scale uses a numerical indicator to display the desired value. This topic will guide you in creating a trivial numeric gauge and will explain the following:

* [Defining a Numeric Gauge](#Defining_a_Numeric_Gauge)

* [Defining a NumericScale](#Defining_a_NumericScale)

* [Defining a Numeric Indicator](#Defining_a_Numeric_Indicator)

* [Set Indicator's Position](#Set_Indicator's_Position)

* [Configuring the Gauge](#Configuring_the_Gauge)

## Defining a Numeric Gauge

>

In order to use the __RadGauge__ control and its components you have to reference the following assemblies:

* __Telerik.Windows.Controls.DataVisualization.dll__

* __Telerik.Windows.Controls.dll__

There is no special container for the numeric scale, as for the radial or linear scales. However you can use any of the 9 radial gauge and 2 linear gauge controls to wrap the __NumericScale__ control. Additionally you can put NumericScale to the Grid container too. Here is an example:

>



To use the __RadGauge__ control and its components in XAML you have to declare the following namespace:

#### __XAML__

{{region radgauge-getting-started-creating-numeric-gauge_0}}
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	{{endregion}}



## Defining a NumericScale

In order to define a numerical scale inside the __Gauge__ control you have to use the __NumericScale__ control. The __Gauge__ works as an __ItemsControl__, which takes __NumericScale__ controls as items. This means that you can have more than one scale inside the gauge. Here is an example of a single __NumericScale__.

>tipTo learn more about the usage of the __NumericScale__ control read the Numeric Scale topic.

#### __XAML__

{{region radgauge-getting-started-creating-numeric-gauge_2}}
	<telerik:RadHorizontalLinearGauge Width="200" Height="50" telerik:StyleManager.Theme="Windows8">
	    <telerik:NumericScale Min="0" Max="999">
	    </telerik:NumericScale>
	</telerik:RadHorizontalLinearGauge>
	{{endregion}}



## Defining a Numeric Indicator

The __NumericScale__ control allows you to display numeric indicators that represent a value off the scale. To specify an indicator use the __Indicators__ property, which is of type __ItemCollection__. This means that the __Indicators__ property can hold more than one indicator. Here is an example.

>tipTo learn more about the usage of the __NumericIndicator__ control, read the Numeric Indicator topic.

#### __XAML__

{{region radgauge-getting-started-creating-numeric-gauge_3}}
	<telerik:RadHorizontalLinearGauge Width="200" Height="50" telerik:StyleManager.Theme="Windows8">
	    <telerik:NumericScale Min="0" Max="999">
	        <telerik:NumericScale.Indicators>
	            <telerik:NumericIndicator telerik:ScaleObject.RelativeX="0.05"
	                                telerik:ScaleObject.RelativeY="0.05"
	                                telerik:ScaleObject.RelativeHeight="0.9*"
	                                telerik:ScaleObject.RelativeWidth="0.9*"
	                                FontSize="30">
	                <telerik:NumericIndicator.Positions>
	                    <telerik:FontNumberPosition Background="#FFD6D4D4" />
	                    <telerik:FontNumberPosition Background="#FFD6D4D4" />
	                    <telerik:FontNumberPosition Background="#FFD6D4D4" />
	                    <telerik:FontNumberPosition Background="#FFD6D4D4" />
	                    <telerik:FontNumberPosition Background="#FFD6D4D4" />
	                    <telerik:FontNumberPosition Background="#FFD6D4D4" />
	                </telerik:NumericIndicator.Positions>
	            </telerik:NumericIndicator>
	        </telerik:NumericScale.Indicators>
	    </telerik:NumericScale>
	</telerik:RadHorizontalLinearGauge>
	{{endregion}}



Here is a snapshot of the result.

![](images/RadGauge_GettingStarted_NumericGauge_03.png)

## Set Indicator's Position

To make the indicator display a certain value off the scale, you have to use the __Value__ property of the indicator. Here is an example.

#### __XAML__

{{region radgauge-getting-started-creating-numeric-gauge_4}}
	<telerik:RadHorizontalLinearGauge Width="200" Height="50" telerik:StyleManager.Theme="Windows8">
	    <telerik:NumericScale Min="0" Max="999">
	        <telerik:NumericScale.Indicators>
	            <telerik:NumericIndicator telerik:ScaleObject.RelativeX="0.05"
	                                telerik:ScaleObject.RelativeY="0.05"
	                                telerik:ScaleObject.RelativeHeight="0.9*"
	                                telerik:ScaleObject.RelativeWidth="0.9*"
	                                FontSize="30"
	                                Value="100">
	                <telerik:NumericIndicator.Positions>
	                    <telerik:FontNumberPosition Background="#FFD6D4D4" />
	                    <telerik:FontNumberPosition Background="#FFD6D4D4" />
	                    <telerik:FontNumberPosition Background="#FFD6D4D4" />
	                    <telerik:FontNumberPosition Background="#FFD6D4D4" />
	                    <telerik:FontNumberPosition Background="#FFD6D4D4" />
	                    <telerik:FontNumberPosition Background="#FFD6D4D4" />
	                </telerik:NumericIndicator.Positions>
	            </telerik:NumericIndicator>
	        </telerik:NumericScale.Indicators>
	    </telerik:NumericScale>
	</telerik:RadHorizontalLinearGauge>
	{{endregion}}



Here is a snapshot of the result.

![](images/RadGauge_GettingStarted_NumericGauge_04.png)

## Configuring the Gauge

To configure and setup the numeric gauge you can use the various properties of the elements inside of it. In order to get familiar with them read the following topics:

* [Ranges]({%slug radgauge-features-ranges-gauge-range%})

* [Numeric Indicator]({%slug radgauge-features-indicators-numeric-indicator%})

* [State Indicator]({%slug radgauge-features-indicators-state-indicator%})
