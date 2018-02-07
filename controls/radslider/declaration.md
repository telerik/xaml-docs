---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radslider-declaration
tags: getting,started
published: True
position: 1
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains a __RadSlider__. 

* [Assembly References](#assembly-references)
* [Adding RadSlider to the Project](#adding-radslider-to-the-project)
* [Key Properties](#key-properties)


## Assembly References

In order to use the __RadSlider__ control in your projects, you have to add references to the following assemblies:

* __Telerik.Windows.Controls__
				
## Adding RadSlider to the Project

You can add __RadSlider__ in XAML or in code as demonstrated in examples 1 and 2 respectively. 

> In order to use the RadSlider control, you need to declare the following namespace: xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"

#### __[XAML] Example 1: Adding RadSlider in XAML__
{{region xaml-radslider-declaration_0}}
	<telerik:RadSlider Value="5" Minimum="0" SmallChange="1" Maximum="100"/>
{{endregion}}

#### __[C#] Example 2: Adding RadSlider in code__
{{region cs-radslider-declaration_1}}
	RadSlider slider = new RadSlider();
	slider.Maximum = 100;
	slider.Minimum = 0;
	slider.Value = 5;
	slider.SmallChange = 1;
{{endregion}}

#### __[VB.NET] Example 2: Adding RadSlider in code__
{{region vb-radslider-declaration_2}}
	Dim slider As New RadSlider()
	slider.Maximum = 100
	slider.Minimum = 0
	slider.Value = 5
	slider.SmallChange = 1
{{endregion}}

#### Figure 1: Result from Examples 1 and 2
![RadSlider](images/radslider_gettingstarted.png)

## Key Properties

The __RadSlider__ control derives from the [DoubleRangeBase](https://docs.telerik.com/devtools/silverlight/api/html/t_telerik_windows_controls_doublerangebase.htm) class which in turn derives from the [RangeBase](https://msdn.microsoft.com/en-us/library/system.windows.controls.primitives.rangebase(v=vs.110).aspx) class. In addition to the inherited properties, these are some of the properties the RadSlider defines:

* __EnableSideTicks__: Gets or sets a value indicating whether side ticks are enabled.
* __Delay__: Gets or sets the Delay property of the Increase and Decrease handles.
* __Orientation__: Gets or sets the orientation of a RadSlider. This is a dependency property.
* __TickFrequency__: Gets or sets the interval between tick marks. This is a dependency property.
* __ThumbVisibility__:  Gets or sets the visibility of the thumb(s) in RadSlider.
* __IsDirectionReversed__: Gets or sets the direction of increasing value. This is a dependency property.

## See Also
* [Visual Structure]({%slug radslider-visual-structure%})
* [Events]({%slug radslider-events-overview%})
* [Orientation]({%slug radslider-orientation%})
* [Ticks and tick frequency]({%slug radslider-ticks-and-tick-frequency%})