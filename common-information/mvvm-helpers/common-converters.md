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

The Telerik suite provides a set of built-in `IValueConverters` which can be used to perform conversion between different types. Some of the converters will have to be defined as resources, in order to be used. 

The converters are located in the __Telerik.Windows.Controls.dll__ assembly.

>important To use the `CultureToLocalizationStringConverter` converter, include the following namespace `xmlns:telerikLocalization="clr-namespace:Telerik.Windows.Controls.Localization;assembly=Telerik.Windows.Controls"`.

__Declare the converters as resources__
```XAML
	<ResourceDictionary xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	                    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" 
	                    xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation" 
	                    xmlns:telerikLocalization="clr-namespace:Telerik.Windows.Controls.Localization;assembly=Telerik.Windows.Controls">
	    <telerik:BooleanToOpacityConverter x:Key="BooleanToOpacityConverter"/>
	    <telerik:InvertedBooleanToOpacityConverter x:Key="InvertedBooleanToOpacityConverter"/>
	    <telerik:BooleanToVisibilityConverter x:Key="BooleanToVisibilityConverter"/>
	    <telerik:InvertedBooleanToVisibilityConverter x:Key="InvertedBooleanToVisibilityConverter"/>
	    <telerik:VisibilityToBooleanConverter x:Key="VisibilityToBooleanConverter"/>
	    <telerik:EnumToBooleanConverter x:Key="EnumToBooleanConverter"/>
	    <telerik:EnumToVisibilityConverter x:Key="EnumToVisibilityConverter"/>
	    <telerik:ColorToBrushConverter x:Key="ColorToBrushConverter"/>
	    <telerik:CornerRadiusConverter x:Key="CornerRadiusConverter"/>
	    <telerik:NullToVisibilityConverter x:Key="NullToVisibilityConverter"/>
	    <telerik:DateTimeTypeConverter x:Key="DateTimeTypeConverter"/>
	    <telerik:UppercaseConverter x:Key="UppercaseConverter"/>
	    <telerik:LinearGradientToSolidColorBrushConverter x:Key="LinearGradientToSolidColorBrushConverter"/>
	    <telerik:BinaryImageConverter x:Key="BinaryImageConverter"/>
	    <telerik:DoubleToThicknessConverter x:Key="DoubleToThicknessConverter"/>
	    <telerik:OpacityConverter x:Key="OpacityConverter"/>
	    <telerik:ThicknessToOrientedThicknessConverter x:Key="ThicknessToOrientedThicknessConverter"/>
	    <telerik:StringToGlyphConverter x:Key="StringToGlyphConverter"/>
	    <telerik:BrushToColorConverter x:Key="BrushToColorConverter"/>
	    <telerik:MultiBindingBooleanOrConverter x:Key="MultiBindingBooleanOrConverter"/>
	    <telerik:NumberToVisibilityConverter x:Key="NumberToVisibilityConverter"/>
	    <telerik:ColorToBrushWithOpacityConverter x:Key="ColorToBrushWithOpacityConverter"/>
	    <telerikLocalization:CultureToLocalizationStringConverter x:Key="CultureToLocalizationStringConverter"/>
	</ResourceDictionary>
```

__Merge the created ResourceDictionary that contains the declared converters__
```XAML
	<Application> 
		<Application.Resources>
			<ResourceDictionary Source="MyConvertersResourceDictionary.xaml"/> 
		</Application.Resources> 
	</Application> 
```

### BooleanToOpacityConverter

This converter converts __Boolean__ values to 1 or 0 opacity. If the __Boolean__ value is __false__ the converter will return 0 opacity.

### InvertedBooleanToOpacityConverter

This converter converts __Boolean__ values to 1 or 0 opacity. If the __Boolean__ value is __false__ the converter will return 1 opacity.

### BooleanToVisibilityConverter

This converter converts __Boolean__ values to __Visibility__ enumeration values. If the __Boolean__ value is __false__ the `Convert()` method will return __Visibility.Collapsed__.

### InvertedBooleanToVisibilityConverter

This converter converts __Boolean__ values to __Visibility__ enumeration values. If the Boolean value is __true__ the `Convert()` method will return __Visibility.Collapsed__.

### VisibilityToBooleanConverter

This converter converts values from the __Visibility__ enumeration to __Boolean__ values. The `Convert()` method returns __true__ if the passed value is __Visibility.Visible__ and __false__ otherwise.

To invert the results of the converter, set the `IsInverted` property. This way, __Visibility.Visible__ will be converted to __false__ and __Visibility.Collapsed__ to __true__.

__Setting the IsInverted property__
```C#
	<FrameworkElement.Resources>
		<telerik:VisibilityToBooleanConverter x:Key="InvertedVisibilityToBooleanConverter" IsInverted="True"/>
	</FrameworkElement.Resources>
```

### EnumToBooleanConverter

The `EnumToBooleanConverter` converts an __Enum__ to a __Boolean__ value. The `Convert()` method returns __true__ if the provided value matches the __Enum__ value that is provided in the `CommandParameter` property. If the values do not match, the method will return __false__. Multiple enum values could be specified in the converter parameter, separated using `,` or `;`.

__Setting the view model__
```C#
	public class MainViewModel
	{
    	public Visibility Visibility { get; set; }
	}
```

__Setting the converter to the IsChecked property__
```XAML
	<CheckBox IsChecked="{Binding Visibility, Converter={StaticResource EnumToBooleanConverter}, ConverterParameter=Visible}"/>
```

### EnumToVisibilityConverter

Converts an __Enum__ value to __Visibility__ enumeration values. If the enum value is one of the values specified in the converter parameter, the `Convert()` method will return __Visibility.Visible__, otherwise it will return __Visibility.Collapsed__. Multiple enum values could be specified in the converter parameter, separated using `,` or `;`.

__Setting the view model__
```C#
	public class MainViewModel
	{
		public Gender Gender { get; set; }
	}

	public enum Gender
	{
		Female,
		Male
	}
```

__Setting the converter to the Visibility property__

```XAML
	<telerik:RadRadioButton Visibility="{Binding MyGender, Converter={StaticResource EnumToVisibilityConverter}, ConverterParameter=Male}"/>
```

### ColorToBrushConverter

This converter converts __Color__ values to __Brush__ values.

### NullToVisibilityConverter

This converter converts __Null__ or __empty string__ values to __Visibility__ enumeration values. If the input value is __Null__ or __empty string__, the converter will return __Visibility.Collapsed__.

### NumberToVisibilityConverter

This converter converts a __number (double or integer)__ value to __Visibility__ enumeration value. If the value is less than or equal to 0, returns __Visibility.Collapsed__, otherwise returns __Visibility.Visible__.

### DateTimeTypeConverter

The converter converts __string__ to a __DateTime__ format value.

### UppercaseConverter

This converter converts all __lowcase__ to __uppercase__ letters.

### BinaryImageConverter

The converter converts __byte array__ to __System.Windows.Media.Imaging.BitmapImage__ object.

### DoubleToThicknessConverter

The converter converts __numeric__ value to __Thickness__ based on the parameter.

__Setting the view model__
```C#
	public class MainViewModel
	{
		public double Thickness { get; set; }
	}
```

__Setting the converter to the BorderThickness property__
```XAML
	 <Border Background="Green" BorderThickness="{Binding Thickness,Converter={StaticResource DoubleToThicknessConverter},ConverterParameter=LeftRight}" BorderBrush="Black"/>
```

### OpacityConverter

The converter applies opacity to a __Color__ or __Brush__ value based on the parameter.

__Setting the view model__
```C#
	public class MainViewModel
	{
		public MainViewModel()
		{
			this.Color = Brushes.Red;
		}
		public SolidColorBrush Color { get; set; }
	}
```

__Setting the converter to the Background property__
```XAML
	<Border Background="{Binding Color, Converter={StaticResource OpacityConverter},ConverterParameter=8}"  />
```

### ThicknessToOrientedThicknessConverter

The converter applies __Thickness__ to a property of type `Thickness` based on the parameter. The parameter expects string value which represents on which side you want to place border __(LeftTopRightBottom)__. You can specify only two sides for example (LeftTop).  __The parameter is required.__

__Setting the ViewModel__
```C#
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
```

__Setting the converter to the BorderThickness property__
```XAML
	<Border BorderThickness="{Binding Value,Converter={StaticResource ThicknessToOrientedThicknessConverter},ConverterParameter=LeftTop}" BorderBrush="Red" Width="200" Height="200" Background="Bisque"/>
```	

### StringToGlyphConverter

The converter accepts a glyph string value (ex: &amp;#xe501&#59;) and converts it to the corresponding `char` representation. The converter is useful when you store the glyph string value in your model and want to data bind it to the UI.

> See all available glyphs in the [Glyphs Reference Sheet]({%slug common-styling-appearance-glyphs-reference-sheet%}) article.

__Setting the view model__
```C#
	public class MainViewModel
	{
		public MainViewModel()
		{
			this.GlyphString = "&#xe501;";
		}
		public string GlyphString { get; set; }
	}
```

__Using the StringToGlyphConverter converter__
```XAML
	<telerik:RadGlyph Glyph="{Binding GlyphString, Converter={StaticResource StringToGlyphConverter}}" />	
```

> StringToGlyphConverter is available since R1 2019. If you use a previous version you can implement the converter on your own. See its implementation in the [Font Glyphs Overview]({%slug common-styling-appearance-glyphs-overview%}#binding-glyphs) article.

### BrushToColorConverter

The BrushToColorConverter converts a [SolidColorBrush object](https://docs.microsoft.com/en-us/dotnet/api/system.windows.media.solidcolorbrush?view=netcore-3.1) to a [Color object](https://docs.microsoft.com/en-us/dotnet/api/system.windows.media.colors?view=netcore-3.1). The returned color comes from the [Color property](https://docs.microsoft.com/en-us/dotnet/api/system.windows.media.solidcolorbrush.color?view=netcore-3.1#System_Windows_Media_SolidColorBrush_Color) of the brush. The converter supports TwoWay bindings. If an empty or invalid value is passed to the Convert() method, the returned result is `null`.

### ColorToBrushWithOpacityConverter

The ColorToBrushWithOpacityConverter converts a [Color object](https://docs.microsoft.com/en-us/dotnet/api/system.windows.media.colors?view=netcore-3.1) with opacity to 
[SolidColorBrush object](https://docs.microsoft.com/en-us/dotnet/api/system.windows.media.solidcolorbrush?view=netcore-3.1). The opacity need to be pass as a parameter. This converter require the __Value__ parameter to be of type `Color` and the __Parameter__ to be different from null.

### LinearGradientToSolidColorBrushConverter

The LinearGradientToSolidColorBrushConverter converts a `LinearGradientBrush` object to `SolidColorBrush` object. If the `GradientStops` collection of the LinearGradientBrush contains entries, the first one will be set to the `Color` property of the returned SolidColorBrush instance. The converter will return a different gradient stop if the index passed to the ConverterParameter is a valid one.

__Using the LinearGradientToSolidColorBrushConverter converter__
```XAML
	<Grid>
		<Grid.Resources>
		    <telerik:LinearGradientToSolidColorBrushConverter x:Key="LinearGradientToSolidColorBrushConverter"/>

		    <LinearGradientBrush x:Key="LinearGradientBrush" EndPoint="0.5,1" StartPoint="0.5,0">
		        <GradientStop Color="White" Offset="0"/>
		        <GradientStop Color="Orange" Offset="0.375"/>
		        <GradientStop Color="DarkOrange" Offset="0.375"/>
		        <GradientStop Color="Red" Offset="1"/>
		    </LinearGradientBrush>
		</Grid.Resources>

		<Button Background="{Binding Source={StaticResource LinearGradientBrush}, Converter={StaticResource LinearGradientToSolidColorBrushConverter}, ConverterParameter=1}"/>
	</Grid>
```

### CultureToLocalizationStringConverter

The CultureToLocalizationStringConverter will return the related localization string by providing its key.

### MultiBindingBooleanOrConverter

The MultiBindingBooleanOrConverter expects boolean values and it will return __true__ if at least one of the bindings evaluates to __true__. This converter implements the `IMultiValueConverter` interface.

### CornerRadiusConverter

The CornerRadiusConverter expects a CornerRadius value and returns a new CornerRadius instance with the desired directions. To specify the directions that will retain their values, use the `ConverterParameter` property.

__Using the CornerRadiusConverter converter__
```XAML
	<Grid>
	    <Grid.Resources>
	        <telerik:CornerRadiusConverter x:Key="CornerRadiusConverter"/>

	        <CornerRadius x:Key="CornerRadius" TopLeft="10" TopRight="10" BottomLeft="10" BottomRight="10"/>
	    </Grid.Resources>
	    <Border Background="Red" CornerRadius="{Binding Source={StaticResource CornerRadius}, Converter={StaticResource CornerRadiusConverter}, ConverterParameter=TopLeft}"/>
	</Grid>
```

### TicksToDateTimeConverter

The `TicksToDateTimeConverter` converts a numeric or string (exponential) value representing date-time ticks to a `System.DateTime` object.

__Defining model with tick values__
```C#
	public class DataItem
 	{
  		public long DateTimeTicks { get; set; } = 638355044051158302L;
    		public string DateTimeTicksAsString { get; set; } = "6.383550E+017";
 	}
```

__Using the TicksToDateTimeConverter converter__
```XAML
	<StackPanel>
	    <StackPanel.Resources>
	        <telerik:TicksToDateTimeConverter x:Key="TicksToDateTimeConverter"/>
	    </StackPanel.Resources>
	    <telerik:RadDateTimePicker SelectedValue="{Binding DateTimeTicks, Converter={StaticResource TicksToDateTimeConverter}}" /> 
            <telerik:RadDateTimePicker SelectedValue="{Binding DateTimeTicksAsString, Converter={StaticResource TicksToDateTimeConverter}}" /> 
	</StackPanel>
```

## See Also  
* [EventToCommandBehavior]({%slug common-event-to-command-behavior%})
* [Attached Behavior]({%slug common-mvvm-attached-behavior%})
* [DelegateCommand]({%slug common-mvvm-delegate-command-implementation%})
