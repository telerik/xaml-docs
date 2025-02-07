---
title: Creating Numeric Gauge
page_title: Creating Numeric Gauge
description: Check our &quot;Creating Numeric Gauge&quot; documentation article for the RadGauge {{ site.framework_name }} control.
slug: radgauge-getting-started-creating-numeric-gauge
tags: creating,numeric,gauge
published: True
position: 2
---

# Creating {{ site.framework_name }} Numeric Gauge

One of the gauges you can create with the __RadGauge__ control, is a numeric gauge. It is represented by a container with a numerical scale in it. The numerical scale uses a numerical indicator to display the desired value. This topic will walk you through the creation of a sample application that contains a numeric RadGauge.

* [Assembly References](#assembly-references)
* [Defining a Numeric Gauge with a NumericScale](#defining-a-numeric-gauge-with-a-numericscale)
* [Defining a Numeric Indicator](#defining-a-numeric-indicator)
* [Set Indicator's Position](#set-indicators-position)

## Assembly References

In order to use the __RadGauge__ control in your projects, you have to add references to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.DataVisualization__

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

### Adding Telerik Assemblies Using NuGet

To use __RadGauge__ when working with NuGet packages, install the `Telerik.Windows.Controls.DataVisualization.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

## Defining a Numeric Gauge with a NumericScale

Unlike the [radial]({%slug radgauge-getting-started-creating-radial-gauge%}#defining-a-radialgauge-with-a-radialscale) and [linear]({%slug radgauge-getting-started-creating-linear-gauge%}#defining-a-linear-gauge-with-a-linear-scale) scales, the numeric scale doesn't require a special container. However you can use any of the 9 radial gauge and 2 linear gauge controls to wrap the __NumericScale__ control. Additionally, you can put a __NumericScale__ in a __Grid__ container too. In order to define a numerical scale inside the __Gauge__ control, you have to use the __NumericScale__ control. The __Gauge__ works as an __ItemsControl__, which takes __NumericScale__ controls as items. This means that you can have more than one scale inside the gauge.

>To use the __RadGauge__ control and its components in XAML you have to declare the following namespace:
>`xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"`

#### __[XAML] Example 1: Creating RadHorizontalLinearGauge with a NumericScale__
{{region xaml-radgauge-getting-started-creating-numeric-gauge_2}}
	<telerik:RadHorizontalLinearGauge Width="200" Height="50">
	    <telerik:NumericScale Min="0" Max="999">
	    </telerik:NumericScale>
	</telerik:RadHorizontalLinearGauge>
{{endregion}}

>tip To learn more about the usage of the __NumericScale__ control read the [Numeric Scale]({%slug numeric-scale-overview%}) topic.

## Defining a Numeric Indicator

The __NumericScale__ control allows you to display numeric indicators that represent a value on the scale. To specify an indicator use the __Indicators__ property, which is of type __ItemCollection__. This means that the __Indicators__ property can hold more than one indicator.

#### __[XAML] Example 2: Adding Indicators__
{{region xaml-radgauge-getting-started-creating-numeric-gauge_3}}
	<telerik:RadHorizontalLinearGauge Width="200" Height="50">
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

> The examples in this article are styled with the [Windows8]({%slug common-styles-appearance-colorizing-metro-theme%}) theme.

## Set Indicator's Position

To make the indicator display a certain value on the scale, you have to use the __Value__ property of the indicator.

#### __[XAML] Example 3: Setting indicator's position__
{{region xaml-radgauge-getting-started-creating-numeric-gauge_4}}
	<telerik:RadHorizontalLinearGauge Width="200" Height="50">
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

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF Gauge Component](https://www.telerik.com/products/wpf/gauge.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}


## See Also

* [Ranges]({%slug radgauge-features-ranges-gauge-range%})
* [Numeric Indicator]({%slug radgauge-features-indicators-numeric-indicator%})
* [State Indicator]({%slug radgauge-features-indicators-state-indicator%})