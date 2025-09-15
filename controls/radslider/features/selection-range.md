---
title: Selection Range
page_title: Selection Range
description: Check our &quot;Selection Range&quot; documentation article for the RadSlider {{ site.framework_name }} control.
slug: radslider-selection-range
tags: selection,range
published: True
position: 2
---

# Selection Range

__RadSlider__ supports the functionality of having two thumbs, thus enabling range selection. To enable the selection range you have to set the __IsSelectionRangeEnabled__ property to __true__.

__Example 1: Enabling Selection Range__

```XAML
	<telerik:RadSlider x:Name="slider" IsSelectionRangeEnabled="True" />
```

![{{ site.framework_name }} RadSlider Default Selection Range](images/radslider_features_default_range.png)

Modifying the range can be done either via the __SelectionStart__ and __SelectionEnd__ properties or through the __Selection__ property.

* __SelectionStart__: Sets the start of the selection range and is of type __double__

* __SelectionEnd__: Sets the end of the selection range and is of type __double__

__Example 2: Setting SelectionStart and SelectionEnd in XAML__

```XAML
	<telerik:RadSlider IsSelectionRangeEnabled="True" SelectionStart="0.2" SelectionEnd="0.4" />
```

* __Selection__: It is of type __SelectionRange<double>__ and it sets __Start__ and __End__ double values to define the selection range

__Example 3: Setting Selection in code-behind__

```C#
	slider.Selection = new SelectionRange<double>(0.2, 0.4);
```
```VB.NET
	slider.Selection = New SelectionRange(Of Double)(0.2, 0.4)
```

![{{ site.framework_name }} RadSlider Custom Selection Range](images/radslider_features_custom_range.png)

## MiddleThumbClickMode

The __MiddleThumbClickMode__ property controls the behavior of the thumbs defining the __SelectionStart__ and __SelectionEnd__ properties of the control when you click on the selection range. This property is an enumeration exposing the following options:

* __None__: Clicking on the selection range will not affect the current selection of the control.

* __DecreaseNearestThumb__: Clicking on the selection range will move the nearest thumb towards the mouse pointer with value defined by the __LargeChange__ property.

## MinimumRangeSpan and MaximumRangeSpan

The RadSlider control also exposes properties to control the minimum and maximum distance between its **SelectionStart** and **SelectionEnd** values. This distance can be set through the **MinimumRangeSpan** and **MaximumRangeSpan** properties.

__Example 4: Setting MinimumRangeSpan and MaximumRangeSpan in XAML__

```XAML
	<telerik:RadSlider IsSelectionRangeEnabled="True" MinimumRangeSpan="5" MaximumRangeSpan="30" />
```

__Example 5: Setting MinimumRangeSpan and MaximumRangeSpan in code-behind__

```C#            
	slider.MinimumRangeSpan = 5;
    slider.MaximumRangeSpan = 30;
```
```VB.NET	
	slider.MinimumRangeSpan = 5
    slider.MaximumRangeSpan = 30
```

## Suppress Coercion

Through the **IsCoercionSuppressed** property you can control whether the slider should coerce the setting of related properties like **Selection**, **SelectionStart**, **SelectionEnd**, **MinimumRangeSpan** and **MaximumRangeSpan**.

__Example 6: Setting IsCoercionSuppressed in XAML__

```XAML
	<telerik:RadSlider IsCoercionSuppressed="True" IsSelectionRangeEnabled="True" MinimumRangeSpan="5" MaximumRangeSpan="30" />
```

__Example 7: Setting IsCoercionSuppressed in code-behind__

```C#            
	slider.IsCoercionSuppressed = true;
```
```VB.NET	
	slider.IsCoercionSuppressed = true
```

If set to **True**, the coercion is done only when the user manipulates the slider and not if the related properties are set in code or through bindings.

## See Also
* [Increase/decrease Handles]({%slug radslider-handles%})
* [Direction]({%slug radslider-direction%})
