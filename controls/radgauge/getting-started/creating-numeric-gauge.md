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

One of the gauges you can create with the __RadGauge__ control, is a numeric gauge. It is represented by a container with a numerical scale in it. The numerical scale uses a numerical indicator to display the desired value. This topic will walk you through the creation of a sample application that contains a numeric RadGauge.

* [Assembly References](#assembly-references)
* [Defining a Numeric Gauge with a NumericScale](#defining-a-numeric-gauge-with-a-numericscale)
* [Defining a Numeric Indicator](#defining-a-numeric-indicator)
* [Set Indicator's Position](#set-indicators-position)

## Assembly References

In order to use the __RadGauge__ control in your projects, you have to add references to the following assemblies:			

* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.DataVisualization__

## Defining a Numeric Gauge with a NumericScale

There is no special container for the numeric scale, as for the radial or linear scales. However you can use any of the 9 radial gauge and 2 linear gauge controls to wrap the __NumericScale__ control. Additionally you can put a NumericScale in a Grid container too. In order to define a numerical scale inside the __Gauge__ control you have to use the __NumericScale__ control. The __Gauge__ works as an __ItemsControl__, which takes __NumericScale__ controls as items. This means that you can have more than one scale inside the gauge.

>To use the __RadGauge__ control and its components in XAML you have to declare the following namespace:
>`xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"`

#### __[XAML] Example 1: Creating RadHorizontalLinearGauge with a NumericScale__
{{region xaml-radgauge-getting-started-creating-numeric-gauge_2}}
	<telerik:RadHorizontalLinearGauge Width="200" Height="50" telerik:StyleManager.Theme="Windows8">
	    <telerik:NumericScale Min="0" Max="999">
	    </telerik:NumericScale>
	</telerik:RadHorizontalLinearGauge>
{{endregion}}

>tip To learn more about the usage of the __NumericScale__ control read the [Numeric Scale]({%slug numeric-scale-overview%}) topic.

## Defining a Numeric Indicator

The __NumericScale__ control allows you to display numeric indicators that represent a value on the scale. To specify an indicator use the __Indicators__ property, which is of type __ItemCollection__. This means that the __Indicators__ property can hold more than one indicator. Here is an example.

#### __[XAML] Example 2: Adding Indicators__
{{region xaml-radgauge-getting-started-creating-numeric-gauge_3}}
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

>tip To learn more about the usage of the __NumericIndicator__ control, read the [Numeric Indicator]({%slug radgauge-features-indicators-numeric-indicator%}) topic.

#### __Image 1: Result from Example 2__

![RadHorizontalLinearGauge with indicator](images/RadGauge_GettingStarted_NumericGauge_03.png)

## Set Indicator's Position

To make the indicator display a certain value on the scale, you have to use the __Value__ property of the indicator. Here is an example.

#### __[XAML] Example 3: Setting indicator's position__
{{region xaml-radgauge-getting-started-creating-numeric-gauge_4}}
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

#### __Image 2: Result from Example 3__

![RadHorizontalLinearGauge with Indicator position](images/RadGauge_GettingStarted_NumericGauge_04.png)

## See Also

* [Ranges]({%slug radgauge-features-ranges-gauge-range%})
* [Numeric Indicator]({%slug radgauge-features-indicators-numeric-indicator%})
* [State Indicator]({%slug radgauge-features-indicators-state-indicator%})