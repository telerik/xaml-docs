---
title: Alignment
page_title: Alignment
description: Check our &quot;Alignment&quot; documentation article for the RadExpander {{ site.framework_name }} control.
slug: radexpander-features-alignment
tags: alignment
published: True
position: 2
---

# Alignment

You can control the alignment of the __RadExpander__ control through the __HorizontalAlignment__ and __VerticalAlignment__ properties. Moreover, if you need to further customize the __RadExpander__'s __Content__ alignment you can take advantage of the __HorizontalContentAlignment__ and __VerticalContentAlignment__ properties. And if you want to control the alignment of the __RadExpander__'s __Header__, you can use the __HorizontalHeaderAlignment__ and __VerticalHeaderAlignment__ properties. By default all these properties are set to __Stretch__ so that the __RadExpander__ control is always stretch thus taking up all available space.

>The alignment properties depend on the __ExpandDirection__ of the control. Therefore before setting the alignment properties, you should carefully plan how you need to render the control depending on the available area as well as the __ExpandDirection__ of the control. 

__Example 1: Setting ExpandDirection property__
<snippet id='radexpander-features-alignment-example_1_setting_expanddirection_property-xaml' />


#### Figure 2: RadExpander directions
![{{ site.framework_name }} RadExpander RadExpander directions](images/RadExpander_Features_Alignment_default.png)

## HorizontalAlignment and VerticalAlignment properties

You can control the vertical and horizontal alignment of the control through the __HorizontalAlignment__ and __VerticalAlignment__ properties. By default both properties are set to __Stretch.__ However, if you want the control to take up only as much space as it needs, you can define the __VerticalAlignment__ and __HorizontalAlignment__ properties accordingly to the __ExpandDirection__ of the control:

__Example 2: Setting HorizontalAlignment and VerticalAlignment properties__
<snippet id='radexpander-features-alignment-example_2_setting_horizontalalignment_and_verticalalignment_properties-xaml' />


#### Figure 2: HorizontalAlignment and VerticalAlignment properties visual appearance
![{{ site.framework_name }} RadExpander HorizontalAlignment and VerticalAlignment properties visual appearance](images/RadExpander_Features_Vertical_HorizontalAlignment_shrink.png)

>Please note that when the __VerticalAlignment__/__HorizontalAlignment__ properties match the __ExpandDirection__, the __Header__ will move aside as the content is expanded. 

## HorizontalContentAlignment and VerticalContentAlignment properties

You can use the __HorizontalContentAlignment__ and __VerticalContentAlignment__ properties to control how the __RadExpander's__ __Content__ will be rendered. For example you can use the properties to set the __RadExpander's__ __Content__ to take up only as much space as it needs:

__Example 3: Setting HorizontalContentAlignment and VerticalContentAlignment properties__
<snippet id='radexpander-features-alignment-example_3_setting_horizontalcontentalignment_and_verticalcontentalignment_properties-xaml' />


#### Figure 2: 
![{{ site.framework_name }} RadExpander Different Alignments](images/RadExpander_Features_Alignment_shrink.png)

## HorizontalHeaderAlignment and VerticalHeaderAlignment properties

You can control how to render the __RadExpander's__ __Header__ through the __HorizontalHeaderAlignment__ and __VerticalHeaderAlignment__ properties. These properties should be set accordingly to the __ExpandDirection__ value. 

If the __RadExpander's__ __ExpandDirection__ is __Up__ or __Down__, you can control the __Header's__ alignment through the __HorizontalHeaderAlignment.__ The property exposes the following enumeration: 

* __Center:__ The __RadExpander.Header's__ content will be centered in the header part of the __RadExpander ControlTemplate__

* __Right:__ The __RadExpander.Header's__ content will be right-aligned in the header part of the __RadExpander ControlTemplate__

* __Left:__ The __RadExpander.Header's__ content will be left-aligned in the header part of the __RadExpander ControlTemplate__

* __Stretch:__ The __RadExpander.Header's__ content will be stretched throughout the header part of the __RadExpander ControlTemplate__

__Example 4: Setting HorizontalHeaderAlignment property__
<snippet id='radexpander-features-alignment-example_4_setting_horizontalheaderalignment_property-xaml' />


#### Figure 3: HorizontalHeaderAlignment with ExpandDirection set to Down and Up
![{{ site.framework_name }} RadExpander HorizontalHeaderAlignment with ExpandDirection set to Down and Up](images/RadExpander_Features_Alignment_HorizontalHeaderAlignment.png)

If the __RadExpander's__ __ExpandDirection__ is __Right__ or __Left__, you can control the position of the __Header's__ content through again the __HorizontalHeaderAlignment__ property.

__Example 5: Setting HorizontalHeaderAlignment property__
<snippet id='radexpander-features-alignment-example_5_setting_horizontalheaderalignment_property-xaml' />


#### Figure 4: HorizontalHeaderAlignment with ExpandDirection set to Right and Left
![{{ site.framework_name }} RadExpander HorizontalHeaderAlignment with ExpandDirection set to Right and Left](images/RadExpander_Features_Alignment_VerticalHeader.png)

## See Also  
* [Getting Started]({%slug expander-getting-started%})
* [Expand Direction]({%slug radexpander-features-expand_direction%})
