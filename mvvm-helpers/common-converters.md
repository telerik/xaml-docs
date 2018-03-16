---
title: Converters
page_title: Converters 
description: This article describe built-in converter which can be used.
slug: common-converters
tags: converter
published: True
position: 2
---

# Converters

Telerik controls provides a set of different built-in __IValueConverters__ which can be used to perform conversion between different types.

>To get access to these converters you can add reference to the __Telerik.Windows.Controls.dll__.

* [BooleanToOpacityConverter](#booleantoopacityconverter)
* [InvertedBooleanToOpacityConverter](#invertedbooleantoopacityconverter)
* [BooleanToVisibilityConverter](#booleantovisibilityconverter)
* [InvertedBooleanToVisibilityConverter](#invertedbooleantovisibilityconverter)
* [EnumToVisibilityConverter](#enumtovisibilityconverter)
* [ColorToBrushConverter](#colortobrushconverter)
* [NullToVisibilityConverter](#nulltovisibilityconverter)
* [NumberToVisibilityConverter](#numbertovisibilityconverter)
* [DateTimeTypeConverter](#datetimetypeconverter)
* [UppercaseConverter](#uppercaseconverter)
* [BinaryImageConverter](#binaryimageconverter)
* [DoubleToThicknessConverter](#doubletothicknessconverter)
* [OpacityConverter](#opacityconverter)


## BooleanToOpacityConverter

This converter converts __Boolean__ values to 1 or 0 opacity. If the __Boolean__ value is __false__ the converter will return 0 opacity.

## InvertedBooleanToOpacityConverter

This converter converts __Boolean__ values to 1 or 0 opacity. If the __Boolean__ value is __false__ the converter will return 1 opacity.

## BooleanToVisibilityConverter

This converter converts __Boolean__ values to __Visibility__ enumeration values. If the __Boolean__ value is __false__ the __Convert()__ method will return __Visibility.Collapsed__.

## InvertedBooleanToVisibilityConverter

This converter converts __Boolean__ values to __Visibility__ enumeration values. If the Boolean value is __true__ the __Convert()__ method will return __Visibility.Collapsed__.

## EnumToVisibilityConverter

Converts an __Enum__ value to a __Boolean__ one if it is one from the specified in the parameter values.

## ColorToBrushConverter

This converter converts __Color__ values to __Brush__ values.

## NullToVisibilityConverter

This converter converts __Null__ or __empty string__ values to __Visibility__ enumeration values. If the input value is __Null__ or __empty string__, the converter will return __Visibility.Collapsed__.

## NumberToVisibilityConverter

This converter converts a __number (double or integer)__ value to __Visibility__ enumeration value. If the value is less than or equal to 0, returns __Visibility.Collapsed__, otherwise returns __Visibility.Visible__.

## DateTimeTypeConverter

The converter converts __string__ to a __DateTime__ format value.

## UppercaseConverter

This converter converts all __lowcase__ to __uppercase__ letters.

## BinaryImageConverter

The converter convert __byte array__ to __image__.

## DoubleToThicknessConverter

The converter converts __numeric__ value to __Thickness__ based on the parameter.

## OpacityConverter

The converter apply opacity to a __Color__ or __Brush__ value based on the parameter.

## See Also

* [EventToCommandBehavior]({%slug common-event-to-command-behavior%})
* [Attached Behavior]({%slug common-mvvm-attached-behavior%})
* [DelegateCommand]({%slug common-mvvm-delegate-command-implementation%})
