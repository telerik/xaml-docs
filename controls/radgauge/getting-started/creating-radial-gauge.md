---
title: Creating Radial Gauge
page_title: Creating Radial Gauge
description: Check our &quot;Creating Radial Gauge&quot; documentation article for the RadGauge {{ site.framework_name }} control.
slug: radgauge-getting-started-creating-radial-gauge
tags: creating,radial,gauge
published: True
position: 0
---

# Creating {{ site.framework_name }} Radial Gauge

One of the gauges you can create with the __RadGauge__ control, is a radial gauge. It is represented by a circle container with a scale in it. Additionally, it can display various indicators that point to a certain value on the scale. This topic will walk you through the creation of a sample application that contains a radial RadGauge.  

* [Adding Telerik Assemblies Using NuGet](#adding-telerik-assemblies-using-nuget)
* [Adding Assembly References Manually](#adding-assembly-references-manually)  
* [Defining a RadialGauge with a Radial Scale](#defining-a-radialgauge-with-a-radialscale)
* [Defining an Indicator](#defining-an-indicator)
* [Set Indicator's Position](#set-indicators-position)

## Adding Telerik Assemblies Using NuGet

To use __RadGauge__ when working with NuGet packages, install the `Telerik.Windows.Controls.DataVisualization.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.DataVisualization__

## Defining a RadialGauge with a RadialScale

The radial gauge type is represented by the __RadRadialGauge__ class. The __RadRadialGauge__ control is used for wrapping radial scales. You can place one or more __RadialScale__ objects inside of it. In order to define a scale inside the RadialGauge control you have to use the RadialScale control. The RadialGauge works as an ItemsControl, which takes RadialScale controls as items. This means that you can have more than one scale inside the radial gauge. 

>To use the __RadGauge__ control and its components in XAML you have to declare the following namespace:
>`xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"`	

__Example 1: Creating RadRadialGauge with a RadialScale__
```XAML
	<telerik:RadRadialGauge x:Name="radialGauge"
	                        Width="300"
	                        Height="300">
	    <telerik:RadialScale Min="1"
	                         Max="12">
	    </telerik:RadialScale>
	</telerik:RadRadialGauge>
```

>tip To learn more about the usage of the __RadialScale__ control read the [Radial Scale]({%slug radgauge-features-radial-scale%}) topic.  

#### __Image 1: Result from Example 1__

![RadRadialGauge with a RadialScale](images/RadGauge_GettingStarted_RadialGauge_02.png)

> The examples in this article are styled with the [Windows8]({%slug common-styles-appearance-colorizing-metro-theme%}) theme.

## Defining an Indicator

The __RadialScale__ control allows you to display different types of indicators that point to a value on the scale. To specify an indicator, use the __Indicators__ property, which is of type __UIElementCollection__. This means that the __Indicators__ property can hold more than one indicator. Example 2 shows a RadialScale that uses a __Needle__ indicator to mark the current value as well as __Pinpoint__ to mark the center of the Gauge.        

__Example 2: Adding Indicators__
```XAML
	 <telerik:RadRadialGauge x:Name="radialGauge"
	                        Width="300"
	                        Height="300">
	    <telerik:RadialScale Min="1"
	                         Max="12">
	        <telerik:RadialScale.Indicators>
	            <telerik:Needle />
	            <telerik:Pinpoint/>
	        </telerik:RadialScale.Indicators>
	    </telerik:RadialScale>
	</telerik:RadRadialGauge>
```

#### __Image 2: Result from Example 2__

![RadRadialGauge with indicator](images/RadGauge_GettingStarted_RadialGauge_03.png)

## Set Indicator's Position

To make the indicator point to a certain value from the scale, you have to use the __Value__ property of the indicator. Example 3 shows how you can work with this property:        

__Example 3: Setting indicator's position__
```XAML
	<telerik:RadRadialGauge Name="radialGauge"
	                    Width="300"
	                    Height="300">
	    <telerik:RadialScale Name="scale"
	                    Min="1"
	                    Max="11">
	        <telerik:RadialScale.Indicators>
	            <telerik:Needle Name="needle" Value="6" />
	            <telerik:Pinpoint />
	        </telerik:RadialScale.Indicators>
	    </telerik:RadialScale>
	</telerik:RadRadialGauge>
```

#### __Image 3: Result from Example 3__

![RadRadialGauge with Indicator position](images/RadGauge_GettingStarted_RadialGauge_04.png)

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


## See also

* [Ranges]({%slug radgauge-features-ranges-gauge-range%})
* [Indicators]({%slug radgauge-features-indicators-basics%})
* [Ticks]({%slug radgauge-features-ticks-basics%})
* [Labels]({%slug radgauge-features-labels-basics%})