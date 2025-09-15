---
title: Office2013 Theme
page_title: Office2013 Theme
description: This article provides an overview of the Office2013 theme from the UI for {{ site.framework_name }} suite.
slug: common-styling-appearance-office2013-theme
tags: office2013,theme,dynamic,fontsize,fontfamily
published: True
position: 12
---

<style>
.theme-palette-color {
	width:20px;
	height:20px;
	margin: auto;
	border: 1px solid black;
}

article table
{
    table-layout: auto;
}
</style>

# Office2013 Theme

The `Office2013` theme delivers a flat modern UI and three built-in color variations – `White`, `Light Gray`, `Dark Gray`.

Jump to the following topics to learn about the specifics of the theme's palette and features.

* [Default Theme Colors](#default-theme-colors)
* [Changing Palette Colors](#changing-palette-colors)
* [Changing Theme Variation](#changing-theme-variation)
* [Changing Font Properties](#changing-font-properties)
* [Changing Opacity](#changing-opacity)

## Default Theme Colors

|Color name|White| |Light Gray| |Dark Gray| |
|----------|-----|---|----------|---|---------|---|
|AccentMainColor|FF0072C6|<div class="theme-palette-color" style="background: #0072C6"></div>|FF0072C6|<div class="theme-palette-color" style="background: #0072C6"></div>|FF0072C6|<div class="theme-palette-color" style="background: #0072C6"></div>|
|AccentColor|FF0072C6|<div class="theme-palette-color" style="background: #0072C6"></div>|FF0072C6|<div class="theme-palette-color" style="background: #0072C6"></div>|FF444444|<div class="theme-palette-color" style="background: #444444"></div>|
|MainColor|FFFFFFFF|<div class="theme-palette-color" style="background: #FFFFFF"></div>|FFFFFFFF|<div class="theme-palette-color" style="background: #FFFFFF"></div>|FFFFFFFF|<div class="theme-palette-color" style="background: #FFFFFF"></div>|
|InvertedColor|FF000000|<div class="theme-palette-color" style="background: #000000"></div>|FF000000|<div class="theme-palette-color" style="background: #000000"></div>|FF000000|<div class="theme-palette-color" style="background: #000000"></div>|
|BasicColor|FFFDFDFD|<div class="theme-palette-color" style="background: #FDFDFD"></div>|FFFDFDFD|<div class="theme-palette-color" style="background: #"></div>|FFFDFDFD|<div class="theme-palette-color" style="background: #FDFDFD"></div>|
|StrongColor|FF767676|<div class="theme-palette-color" style="background: #767676"></div>|FF767676|<div class="theme-palette-color" style="background: #767676"></div>|FF767676|<div class="theme-palette-color" style="background: #767676"></div>|
|ValidationColor|FFFF0000|<div class="theme-palette-color" style="background: #FF0000"></div>|FFFF0000|<div class="theme-palette-color" style="background: #FF0000"></div>|FFFF0000|<div class="theme-palette-color" style="background: #FF0000"></div>|
|LowLightMainColor|FFF1F1F1|<div class="theme-palette-color" style="background: #F1F1F1"></div>|FFF1F1F1|<div class="theme-palette-color" style="background: #F1F1F1"></div>|FFF1F1F1|<div class="theme-palette-color" style="background: #F1F1F1"></div>|
|LowLightColor|FFFFFFFF|<div class="theme-palette-color" style="background: #FFFFFF"></div>|FFF1F1F1|<div class="theme-palette-color" style="background: #F1F1F1"></div>|FFE5E5E5|<div class="theme-palette-color" style="background: #E5E5E5"></div>|
|LowDarkColor|FFFFFFFF|<div class="theme-palette-color" style="background: #FFFFFF"></div>|FFFAFAFA|<div class="theme-palette-color" style="background: #FAFAFA"></div>|FFF3F3F3|<div class="theme-palette-color" style="background: #F3F3F3"></div>|
|MediumLightColor|FFE1E1E1|<div class="theme-palette-color" style="background: #E1E1E1"></div>|FFE1E1E1|<div class="theme-palette-color" style="background: #E1E1E1"></div>|FFE1E1E1|<div class="theme-palette-color" style="background: #E1E1E1"></div>|
|MediumDarkColor|FFC6C6C6|<div class="theme-palette-color" style="background: #C6C6C6"></div>|FFC6C6C6|<div class="theme-palette-color" style="background: #C6C6C6"></div>|FFC6C6C6|<div class="theme-palette-color" style="background: #C6C6C6"></div>|
|HighLightColor|FFD4D4D4|<div class="theme-palette-color" style="background: #D4D4D4"></div>|FFC6C6C6|<div class="theme-palette-color" style="background: #C6C6C6"></div>|FFABABAB|<div class="theme-palette-color" style="background: #ABABAB"></div>|
|HighDarkColor|FFABABAB|<div class="theme-palette-color" style="background: #ABABAB"></div>|FFABABAB|<div class="theme-palette-color" style="background: #ABABAB"></div>|FFABABAB|<div class="theme-palette-color" style="background: #ABABAB"></div>|
|EffectLowColor|33FFFFFF|<div class="theme-palette-color" style="background: #FFFFFF"></div>|33FFFFFF|<div class="theme-palette-color" style="background: #FFFFFF"></div>|FF0072C6|<div class="theme-palette-color" style="background: #0072C6"></div>|
|EffectHighColor|33000000|<div class="theme-palette-color" style="background: #000000"></div>|33000000|<div class="theme-palette-color" style="background: #000000"></div>|800072C6|<div class="theme-palette-color" style="background: #0072C6"></div>|
|EffectAccentLowColor|330072C6|<div class="theme-palette-color" style="background: #0072C6"></div>|330072C6|<div class="theme-palette-color" style="background: #0072C6"></div>|330072C6|<div class="theme-palette-color" style="background: #0072C6"></div>|
|EffectAccentHighColor|800072C6|<div class="theme-palette-color" style="background: #0072C6"></div>|800072C6|<div class="theme-palette-color" style="background: #0072C6"></div>|800072C6|<div class="theme-palette-color" style="background: #0072C6"></div>|

## Changing Palette Colors

Office2013 provides dynamic change of the palette colors responsible for the brushes used in our controls. Their defaults are stated above. This mechanism is used to modify the color variation of the theme. 

The general naming convention is: `Office2013Palette.Palette.[name]Color` is responsible for `[name]Brush` – e.g. `Office2013Palette.Palette.AccentColor` sets the color for `telerik:Offie2013Resource ResourceKey=AccentBrush`

Changing the colors can be achieved in code behind.

__Setting palette colors__
```XAML
	Office2013Palette.Palette.AccentColor = Color.FromRgb(255, 0, 0);
```

## Changing Theme Variation

The following are the supported color variations of the Office2013 theme:

* `White`&mdash;White color theme palette. This is also the default variation of the theme.
![Common Styling Appearance Office 2013 Theme 01](../images/Common_Styling_Appearance_Office2013_Theme_01.png)

* `LightGray`&mdash;Light gray theme palette.
![Common Styling Appearance Office 2013 Theme 02](../images/Common_Styling_Appearance_Office2013_Theme_02.png)

* `DarkGray`&mdash;Dark gray theme palette.
![Common Styling Appearance Office 2013 Theme 03](../images/Common_Styling_Appearance_Office2013_Theme_03.png)

This is how the `ColorVariation` enumeration looks:


```C#
	/// <summary>
	/// Represents theme color variations.
	/// </summary>
	public enum ColorVariation
	{
		/// <summary>
		/// Represents Dark Gray Office2013 theme palette.
		/// </summary>
		DarkGray,

		/// <summary>
		/// Represents Light Gray Office2013 theme palette.
		/// </summary>
		LightGray,

		/// <summary>
		/// Represents the default White Office2013 theme palette.
		/// </summary>
		White
	}
```

The `Office2013` theme offers a very intuitive and easy way to change its color variation. You can change the variation by using the `LoadPreset` method of `Office2013Palette` in the entry point of your application. You just have to pass to the method the desired color variation as a parameter.

For example, if you want to set the `DarkGray` color variation, you should have the following code-block in your application:
{% if site.site_name == 'WPF' %}


```C#
    public MainWindow()
    {
        Office2013Palette.LoadPreset(Office2013Palette.ColorVariation.DarkGray);

        InitializeComponent();
    }
```

{% endif %}
{% if site.site_name == 'Silverlight' %}



```C#
    public UserControl()
    {
        Office2013Palette.LoadPreset(Office2013Palette.ColorVariation.DarkGray);

        InitializeComponent();
    }
```
{% endif %}

>The `DarkGray` variation of the theme is designed with a dark background in mind and it is recommended to use such a background in your application when choosing it.

## Changing Font Properties

When using the `Office2013` theme you can dynamically change the `FontSize` and `FontFamily` properties of all components in the application the same way as you do in all other [Available Themes]({%slug common-styling-appearance-available-themes%}) which support ThemePalette.

These properties are public so you can easily modify the theme resources at one single point. The most commonly used FontSize in the theme is named `FontSizeL` and its default value is __15__. The bigger font sizes are used for headers and footers while smaller ones are used inside complex controls such as `RadRibbonView`, `RadGauge`, `RadGanttView`, etc. As for the FontFamily - there is only one FontFamily resource which is named FontFamily and it is set to `Calibri`.

>Please note that for complex scenarios we strongly recommend setting font size only initially before the application is initialized. We recommend font sizes between 11px and 19px for the __FontSize__ property.

All the available __FontSizes__ and __FontFamily__ as well as their __default values__:


```C#
	Office2013Palette.Palette.FontSizeXXS = 10;
	Office2013Palette.Palette.FontSizeXS = 12; 
	Office2013Palette.Palette.FontSizeS = 13;
	Office2013Palette.Palette.FontSize = 14;
	Office2013Palette.Palette.FontSizeL = 15;
	Office2013Palette.Palette.FontSizeXL = 16;
	Office2013Palette.Palette.FontFamily = new FontFamily("Calibri");
```

More details regarding the usage of the rarely used font sizes inside the different controls can be found below:

* `Office2013Palette.Palette.FontSizeXXS` is used:
	* GridViewNewRow in Telerik.Windows.Controls.GridView
	
* `Office2013Palette.Palette.FontSizeXL` is used:
	* ExpressionEditor in Telerik.Windows.Controls.Expressions
	* WizzardPage in Telerik.Windows.Controls.Navigation 
	* ScheduleView's MonthView items in Telerik.Windows.Controls.ScheduleView
	
As the following example shows, you can change the default FontFamily from "Calibri" to "MonoType Corsiva" and the FontSize from __15__ to __16__ on a click of a button:


```XAML
	<StackPanel>
		<telerik:RadCalendar x:Name="Calendar" Width="250" Height="250" Margin="4 10"/>
		<telerik:RadButton HorizontalAlignment="Center" Content="Change Font" Click="OnButtonChangeFontSizeClick" />
	</StackPanel>
```


```C#
	private void OnButtonChangeFontSizeClick(object sender, RoutedEventArgs e)
	{
		Office2013Palette.Palette.FontSizeL = 24;
		Office2013Palette.Palette.FontSizeS = 16;
		Office2013Palette.Palette.FontFamily = new FontFamily("MonoType Corsiva");
	}
```

This will be the final result:

![Common Styling Appearance Office 2013 Theme 03](../images/Common_Styling_Appearance_Office2013_Theme_04.png)

## Changing Opacity 

If you need to change the opacity of the disabled elements, you can now easily do so by using the `DisabledOpacity` property of the `Office2013Palette`. Its default value is __0.3__.

__Changing the opacity__
```C#
	Office2013Palette.Palette.DisabledOpacity = 0.5;
```
```VB.NET
	Office2013Palette.Palette.DisabledOpacity = 0.5
```

## Merging Modified Palette Resources With StyleManager Theming Approach

When modifying fonts, colors, or other resources from the `Office2013Palette` and `StyleManager` is used as theming mechanism, the theme's `ResourceDictionary` needs to be merged in __App.xaml__ file to apply the changes.

__Merging the theme's ResourceDictionary in App.xaml__
```XAML
	<Application.Resources> 
	    <ResourceDictionary> 
	        <ResourceDictionary.MergedDictionaries> 
	            <telerik:Office2013ResourceDictionary/> 
	        </ResourceDictionary.MergedDictionaries> 
	    </ResourceDictionary> 
	</Application.Resources>
```

## See Also
 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
