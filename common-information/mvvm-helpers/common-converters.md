---
title: Converters
page_title: Converters 
description: This article describe Telerik built-in converters which can be used.
slug: common-converters
tags: converter
published: True
position: 2
---

# Converters

Telerik controls provide a set of different built-in __IValueConverters__ which can be used to perform conversion between different types.

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
* [StringToGlyphConverter](#stringtoglyphconverter)
* [ThicknessToOrientedThicknessConverter](#thicknesstoorientedthicknessconverter )

#### __[XAML] Example 1: Specifying converters in XAML__
	{{region xaml-common-converters_0}}
		<FrameworkElement>
		  <FrameworkElement.Resources>
			  <telerik:BooleanToOpacityConverter x:Key="BooleanToOpacityConverter"/>
			  <telerik:InvertedBooleanToOpacityConverter x:Key="InvertedBooleanToOpacityConverter"/>
			  <telerik:BooleanToVisibilityConverter x:Key="BooleanToVisibilityConverter"/>
			  <telerik:InvertedBooleanToVisibilityConverter x:Key="InvertedBooleanToVisibilityConverter"/>
			  <telerik:EnumToVisibilityConverter x:Key="EnumToVisibilityConverter"/>
			  <telerik:ColorToBrushConverter x:Key="ColorToBrushConverter"/>
			  <telerik:NullToVisibilityConverter x:Key="NullToVisibilityConverter"/>
			  <telerik:DateTimeTypeConverter x:Key="DateTimeTypeConverter"/>
			  <telerik:UppercaseConverter x:Key="UppercaseConverter"/>
			  <telerik:BinaryImageConverter x:Key="BinaryImageConverter"/>
			  <telerik:DoubleToThicknessConverter x:Key="DoubleToThicknessConverter"/>
			  <telerik:OpacityConverter x:Key="OpacityConverter"/>
			  <telerik:ThicknessToOrientedThicknessConverter x:Key="ThicknessToOrientedThicknessConverter"/>
			  <telerik:StringToGlyphConverter x:Key="StringToGlyphConverter"/>
		  </FrameworkElement.Resources>
		</FrameworkElement>
	{{endregion}}


## BooleanToOpacityConverter

This converter converts __Boolean__ values to 1 or 0 opacity. If the __Boolean__ value is __false__ the converter will return 0 opacity.

## InvertedBooleanToOpacityConverter

This converter converts __Boolean__ values to 1 or 0 opacity. If the __Boolean__ value is __false__ the converter will return 1 opacity.

## BooleanToVisibilityConverter

This converter converts __Boolean__ values to __Visibility__ enumeration values. If the __Boolean__ value is __false__ the __Convert()__ method will return __Visibility.Collapsed__.

## InvertedBooleanToVisibilityConverter

This converter converts __Boolean__ values to __Visibility__ enumeration values. If the Boolean value is __true__ the __Convert()__ method will return __Visibility.Collapsed__.

## EnumToVisibilityConverter

Converts an __Enum__ value to __Visibility__ enumeration values. If the enum value is one of the values specified in the converter parameter, the __Convert()__ method will return __Visibility.Visible__, otherwise it will return __Visibility.Collapsed__. Multiple enum values could be specified in the converter parameter, separated using `,` or `;`.

#### __[C#] Example 2: Setting the view model__
{{region cs-common-converters_1}}
	public class MainViewModel
	{
		public Gender Gender { get; set; }
	}

	public enum Gender
	{
		Female,
		Male
	}
{{endregion}}

#### __[XAML] Example 3: Setting the converter to the Visibility property__
	{{region xaml-common-converters_2}}
		<telerik:RadRadioButton Visibility="{Binding MyGender, Converter={StaticResource EnumToVisibilityConverter}, ConverterParameter=Male}"/>
	{{endregion}}

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

The converter converts __byte array__ to __System.Windows.Media.Imaging.BitmapImage__ object.

## DoubleToThicknessConverter

The converter converts __numeric__ value to __Thickness__ based on the parameter.

#### __[C#] Example 4: Setting the view model__
{{region cs-common-converters_3}}
	public class MainViewModel
	{
		public double Thickness { get; set; }
	}
{{endregion}}

#### __[XAML] Example 5: Setting the converter to the BorderThickness property__
{{region xaml-common-converters_4}}
	 <Border Background="Green" BorderThickness="{Binding Thickness,Converter={StaticResource DoubleToThicknessConverter},ConverterParameter=LeftRight}" BorderBrush="Black"/>
{{endregion}}

## OpacityConverter

The converter applies opacity to a __Color__ or __Brush__ value based on the parameter.

#### __[C#] Example 6: Setting the view model__
{{region cs-common-converters_5}}
	public class MainViewModel
	{
		public MainViewModel()
		{
			this.Color = Brushes.Red;
		}
		public SolidColorBrush Color { get; set; }
	}
{{endregion}}

#### __[XAML] Example 7: Setting the converter to the Background property__
{{region xaml-common-converters_6}}
	<Border Background="{Binding Color, Converter={StaticResource OpacityConverter},ConverterParameter=8}"  />
{{endregion}}

## ThicknessToOrientedThicknessConverter

The converter applies __Thickness__ to a property of type __Thickness__ based on the parameter. The parameter expects string value which represents on which side you want to place border __(LeftTopRightBottom)__. You can specify only two sides for example (LeftTop).  __The parameter is required.__

#### __[C#] Example 6: Setting the ViewModel__
	{{region cs-common-converters_5}}
		public class MainWindow
		{
			 public MainWindow()
			{
				InitializeComponent();

				this.DataContext = this;
				Value = new Thickness(2, 3, 4, 5);				
			}
			public Thickness Value { get; set; }
		}
	{{endregion}}

#### __[XAML] Example 7: Setting the converter to the BorderThickness property__
	{{region xaml-common-converters_6}}
		<Border BorderThickness="{Binding Value,Converter={StaticResource ThicknessToOrientedThicknessConverter},ConverterParameter=LeftTop}" BorderBrush="Red" Width="200" Height="200" Background="Bisque"/>
	{{endregion}}	

## StringToGlyphConverter

The converter accepts a glyph string value (ex: &amp;#xe501&#59;) and converts it to the corresponding `char` represantation. The converter is useful when you store the glyph string value in your model and want to data bind it to the UI.

> See all available glyphs in the [Glyphs Reference Sheet]({%slug common-styling-appearance-glyphs-reference-sheet%}) article.

#### __[C#] Example 8: Setting the view model__
{{region cs-common-converters_7}}
	public class MainViewModel
	{
		public MainViewModel()
		{
			this.GlyphString = "&#xe501;";
		}
		public string GlyphString { get; set; }
	}
{{endregion}}

#### __[XAML] Example 9: Using the StringToGlyphConverter converter__
{{region xaml-common-converters_8}}
	<telerik:RadGlyph Glyph="{Binding GlyphString, Converter={StaticResource StringToGlyphConverter}}" />	
{{endregion}}

## See Also  
* [EventToCommandBehavior]({%slug common-event-to-command-behavior%})
* [Attached Behavior]({%slug common-mvvm-attached-behavior%})
* [DelegateCommand]({%slug common-mvvm-delegate-command-implementation%})
