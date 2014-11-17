---
title: Selection Range
page_title: Selection Range
description: Selection Range
slug: radslider-selection-range
tags: selection,range
published: True
position: 2
---

# Selection Range



## 

__RadSlider__ supports the functionality of having two thumbs, thus enabling range selection. To enable the selection range you have to set the __IsSelectionRangeEnabled__ property to __true__.
        

#### __XAML__

{{region radslider-selection-range_0}}
	<telerik:RadSlider x:Name="slider" IsSelectionRangeEnabled="True" />
	{{endregion}}

![](images/radslider_features_default_range.png)

Modifying the range can be done either via the __SelectionStart__ and __SelectionEnd__ properties or through the __Selection__ property.
        

* __SelectionStart__ - sets the start of the selection range and is of type __double__

* __SelectionEnd__- sets the end of the selection range and is of type __double__

#### __XAML__

{{region radslider-selection-range_1}}
	<telerik:RadSlider x:Name="slider" IsSelectionRangeEnabled="True" SelectionStart="0.2" SelectionEnd="0.4" />
	{{endregion}}



* __Selection__ - is of type __SelectionRange<double>__ and it sets __Start__ and __End__ double values to define the selection range
            

#### __C#__

{{region radslider-selection-range_2}}
	slider.Selection = new SelectionRange<double>(0.2,0.4);
	{{endregion}}



#### __VB.NET__

{{region radslider-selection-range_3}}
	slider.Selection = New SelectionRange(Of Double)(0.2, 0.4)
	{{endregion}}

![](images/radslider_features_custom_range.png)

With the __QX 2014__ release we exposed the __MiddleThumbClickMode__ property. It controls the behavior of the thumbs defining the __SelectionStart__ and __SelectionStart__ properties of the control when you click on the selection range. This property is en enumeration exposing the following options:
        

* __None__ – clicking on the selection range will not affect the current selection of the control.
            

* __DecreaseNearestThumb__ – clicking on the selection range will move the nearest thumb towards the mouse pointer with value defined by the __LargeChange__ property.
            
