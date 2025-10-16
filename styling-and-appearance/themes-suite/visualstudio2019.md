---
title: VisualStudio2019 Theme
page_title: VisualStudio2019 Theme
description: Bring the Visual Studio 2019 appearance to your desktop applications by using the VisualStudio2019 theme.
slug: common-styling-appearance-visualstudio2019-theme
tags: visualstudio2019,theme,glyphs,fontsize,fontfamily,cornerradius
published: True
position: 4
---

<style>
.theme-palette-color {
	width:20px;
	height:20px;
	margin: auto;
	border: 1px solid black;
}

/* Blue color variation */
.visualstudio2019theme-accentbrush{
	background: #F5CC84;
}
.visualstudio2019theme-accentdarkbrush{
	background: #5F6FA4;
}
.visualstudio2019theme-accentfocusedbrush{
	background: #D2A85E;
}
.visualstudio2019theme-accentforegroundbrush{
	background: #5F6FA4;
}
.visualstudio2019theme-accentmainbrush{
	background: #AAC0FF;
}
.visualstudio2019theme-accentmouseoverbrush{
	background: #C4D5FF;
}
.visualstudio2019theme-accentsecondarydarkbrush{
	background: #40508D;
}
.visualstudio2019theme-alternativebrush{
	background: #F7F9FE;
}
.visualstudio2019theme-basicbrush{
	background: #94A6CA;
}
.visualstudio2019theme-complementarybrush{
	background: #D9E0F8;
}
.visualstudio2019theme-dockingbackgroundbrush{
	background: #5F6FA4;
}
.visualstudio2019theme-headerbrush{
	background: #40568D;
}
.visualstudio2019theme-iconbrush{
	background: #414141;
}
.visualstudio2019theme-mainbrush{
	background: #FCFCFC;
}
.visualstudio2019theme-markerbrush{
	background: #1E1E1E;
}
.visualstudio2019theme-markerinvertedbrush{
	background: #FFFFFF;
}
.visualstudio2019theme-mouseoverbrush{
	background: #FFF8DF;
}
.visualstudio2019theme-primarybrush{
	background: #F2F5FC;
}
.visualstudio2019theme-readonlybackgroundbrush{
	background: #FCFCFC;
}
.visualstudio2019theme-readonlyborderbrush{
	background: #94A6CA;
}
.visualstudio2019theme-secondarybrush{
	background: #FFFFFF;
}
.visualstudio2019theme-semibasicbrush{
	background: #C0CAE9;
}
.visualstudio2019theme-validationbrush{
	background: #FF3333;
}

/* Dark color variation */
.visualstudio2019theme-accentbrush-dark{
	background: #007ACC;
}
.visualstudio2019theme-accentdarkbrush-dark{
	background: #006EB8;
}
.visualstudio2019theme-accentfocusedbrush-dark{
	background: #33BBFF;
}
.visualstudio2019theme-accentforegroundbrush-dark{
	background: #98C5E3;
}
.visualstudio2019theme-accentmainbrush-dark{
	background: #3399FF;
}
.visualstudio2019theme-accentmouseoverbrush-dark{
	background: #40AFFF;
}
.visualstudio2019theme-accentsecondarydarkbrush-dark{
	background: #005791;
}
.visualstudio2019theme-alternativebrush-dark{
	background: #1B1B1C;
}
.visualstudio2019theme-basicbrush-dark{
	background: #555555;
}
.visualstudio2019theme-complementarybrush-dark{
	background: #434346;
}
.visualstudio2019theme-dockingbackgroundbrush-dark{
	background: #111112;
}
.visualstudio2019theme-headerbrush-dark{
	background: #2B71A0;
}
.visualstudio2019theme-iconbrush-dark{
	background: #F1F1F1;
}
.visualstudio2019theme-mainbrush-dark{
	background: #252526;
}
.visualstudio2019theme-markerbrush-dark{
	background: #F1F1F1;
}
.visualstudio2019theme-markerinvertedbrush-dark{
	background: #FFFFFF;
}
.visualstudio2019theme-mouseoverbrush-dark{
	background: #3E3E40;
}
.visualstudio2019theme-primarybrush-dark{
	background: #2D2D30;
}
.visualstudio2019theme-readonlybackgroundbrush-dark{
	background: #252526;
}
.visualstudio2019theme-readonlyborderbrush-dark{
	background: #555555;
}
.visualstudio2019theme-secondarybrush-dark{
	background: #3F3F46;
}
.visualstudio2019theme-semibasicbrush-dark{
	background: #656565;
}
.visualstudio2019theme-validationbrush-dark{
	background: #E51400;
}

article table
{
    table-layout: auto;
}
</style>

# VisualStudio2019 Theme

Inspired by the refreshed Visual Studio 2019 IDE, the VisualStudio2019 theme delivers a lot cleaner and smoother look and feel to your WPF apps. The team at Microsoft are well known for their eagerness to deliver the best possible user experience that we encounter every day and with the VisualStudio2019 theme you will be able to easily bring it to your own apps.

With the __R2 2021__ release of the __UI for WPF__ suite, we have designed and delivered a brand new color variation of the VisualStudio2019 theme - the `Dark` one. In addition to it, the theme palette expanded its brushes collection with the `AccentForegroundBrush` and the `DockingBackgroundBrush`, which are available for both color variations.

Jump to the following topics to learn about the specifics of the theme's palette and features.

* [Default Theme Colors](#default-theme-colors)
* [Default Theme Brushes](#default-theme-brushes)
* [Changing Palette Colors](#changing-palette-colors)
* [Changing Theme Variation](#changing-theme-variation)
* [Changing Font Properties](#changing-font-properties)
* [Using Glyphs](#using-glyphs)
* [Using Theme Helper](#using-theme-helper)
* [Changing Opacity](#changing-opacity)

## Default Theme Colors

The **VisualStudio2019 Theme** is designed to be easily modified via the exposed colors in the theme palette.
The default values of the brushes in the theme are listed below.

|Color name|   |Light|   |Dark|
|----------|---|-----|---|----|
|AccentColor|#F5CC84|<div class="theme-palette-color visualstudio2019theme-accentbrush"></div>|#007ACC|<div class="theme-palette-color visualstudio2019theme-accentbrush-dark"></div>|
|AccentDarkColor|#5F6FA4|<div class="theme-palette-color visualstudio2019theme-accentdarkbrush"></div>|#006EB8|<div class="theme-palette-color visualstudio2019theme-accentdarkbrush-dark"></div>|
|AccentFocusedColor|#D2A85E|<div class="theme-palette-color visualstudio2019theme-accentfocusedbrush"></div>|#33BBFF|<div class="theme-palette-color visualstudio2019theme-accentfocusedbrush-dark"></div>|
|AccentForegroundColor|#5F6FA4|<div class="theme-palette-color visualstudio2019theme-accentforegroundbrush"></div>|#98C5E3|<div class="theme-palette-color visualstudio2019theme-accentforegroundbrush-dark"></div>|
|AccentMainColor|#AAC0FF|<div class="theme-palette-color visualstudio2019theme-accentmainbrush"></div>|#3399FF|<div class="theme-palette-color visualstudio2019theme-accentmainbrush-dark"></div>|
|AccentMouseOverColor|#C4D5FF|<div class="theme-palette-color visualstudio2019theme-accentmouseoverbrush"></div>|#40AFFF|<div class="theme-palette-color visualstudio2019theme-accentmouseoverbrush-dark"></div>|
|AccentSecondaryDarkColor|#40508D|<div class="theme-palette-color visualstudio2019theme-accentsecondarydarkbrush"></div>|#005791|<div class="theme-palette-color visualstudio2019theme-accentsecondarydarkbrush-dark"></div>|
|AlternativeColor|#F7F9FE|<div class="theme-palette-color visualstudio2019theme-alternativebrush"></div>|#1B1B1C|<div class="theme-palette-color visualstudio2019theme-alternativebrush-dark"></div>|
|BasicColor|#94A6CA|<div class="theme-palette-color visualstudio2019theme-basicbrush"></div>|#555555|<div class="theme-palette-color visualstudio2019theme-basicbrush-dark"></div>|
|ComplementaryColor|#D9E0F8|<div class="theme-palette-color visualstudio2019theme-complementarybrush"></div>|#434346|<div class="theme-palette-color visualstudio2019theme-complementarybrush-dark"></div>|
|DockingBackgroundColor|#5F6FA4|<div class="theme-palette-color visualstudio2019theme-headerbrush"></div>|#111112|<div class="theme-palette-color visualstudio2019theme-headerbrush-dark"></div>|
|HeaderColor|#40568D|<div class="theme-palette-color visualstudio2019theme-headerbrush"></div>|#2B71A0|<div class="theme-palette-color visualstudio2019theme-headerbrush-dark"></div>|
|IconColor|#414141|<div class="theme-palette-color visualstudio2019theme-iconbrush"></div>|#F1F1F1|<div class="theme-palette-color visualstudio2019theme-iconbrush-dark"></div>|
|MainColor|#FCFCFC|<div class="theme-palette-color visualstudio2019theme-mainbrush"></div>|#252526|<div class="theme-palette-color visualstudio2019theme-mainbrush-dark"></div>|
|MarkerColor|#1E1E1E|<div class="theme-palette-color visualstudio2019theme-markerbrush"></div>|#F1F1F1|<div class="theme-palette-color visualstudio2019theme-markerbrush-dark"></div>|
|MarkerInvertedColor|#FFFFFF|<div class="theme-palette-color visualstudio2019theme-markerinvertedbrush"></div>|#FFFFFF|<div class="theme-palette-color visualstudio2019theme-markerinvertedbrush-dark"></div>|
|MouseOverColor|#FFF8DF|<div class="theme-palette-color visualstudio2019theme-mouseoverbrush"></div>|#3E3E40|<div class="theme-palette-color visualstudio2019theme-mouseoverbrush-dark"></div>|
|PrimaryColor|#F2F5FC|<div class="theme-palette-color visualstudio2019theme-primarybrush"></div>|#2D2D30|<div class="theme-palette-color visualstudio2019theme-primarybrush-dark"></div>|
|ReadOnlyBackgroundColor|#FCFCFC|<div class="theme-palette-color visualstudio2019theme-readonlybackgroundbrush"></div>|#252526|<div class="theme-palette-color visualstudio2019theme-readonlybackgroundbrush-dark"></div>|
|ReadOnlyBorderColor|#94A6CA|<div class="theme-palette-color visualstudio2019theme-readonlyborderbrush"></div>|#555555|<div class="theme-palette-color visualstudio2019theme-readonlyborderbrush-dark"></div>|
|SecondaryColor|#FFFFFF|<div class="theme-palette-color visualstudio2019theme-secondarybrush"></div>|#3F3F46|<div class="theme-palette-color visualstudio2019theme-secondarybrush-dark"></div>|
|SemiBasicColor|#C0CAE9|<div class="theme-palette-color visualstudio2019theme-semibasicbrush"></div>|#656565|<div class="theme-palette-color visualstudio2019theme-semibasicbrush-dark"></div>|
|ValidationColor|#FF3333|<div class="theme-palette-color visualstudio2019theme-validationbrush"></div>|#E51400|<div class="theme-palette-color visualstudio2019theme-validationbrush-dark"></div>|

__Theme colors represented in RadOutlookBar__

![VisualStudio2019 theme colors represented in RadOutlookBar](images/visualstudio2019-theme-outlook.PNG)	

## Default Theme Brushes

### Primary Brushes 
* `PrimaryBrush`&mdash;Used for background of inputs. 
* `MainBrush`&mdash;Used for background of buttons. 
* `AlternativeBrush`&mdash;Used for background of popups, windows, list boxes etc. 
* `BasicBrush`&mdash;Used in the majority of the normal state borders and for the borders of windows as well. 
* `ComplementaryBrush`&mdash;Slightly darker than the alternative in case of collisions.
* `MarkerBrush`&mdash;Used for the majority of foregrounds which are black. 
* `MarkerInvertedBrush`&mdash;Used for interaction states - mainly where change of the foreground to white is required. 
* `IconBrush`&mdash;Used for glyph and path icons. 

### Interaction State Brushes 
* `AccentBrush`&mdash;Used for borders of the hovered states of the elements as well as for backgrounds of toggled/checked buttons.
* `AccentDarkBrush`&mdash;Used in backgrounds for the pressed states of the elements.
* `AccentFocusedBrush`&mdash;Variation of the AccentBrush that is used for the focused states of the elements.
* `AccentForegroundBrush`&mdash;Variation of the AccentBrush that is used for the foreground of some elements that need to stand out - e.g., the headers of the Spreadsheet control's dialogs.
* `AccentMainBrush`&mdash;Used for the selected states of selected elements (e.g. menu items, dropdown items, list box items).
* `AccentMouseOverBrush`&mdash;Variation of AccentMainBrush that is used for the hovered states of the above mentioned selected elements.
* `AccentSecondaryDarkBrush`&mdash;Variation of AccentDarkBrush that is used for the foreground of the picker control buttons - DatePicker, DateTimePicker, CalculatorPicker, etc., as well as for the points in the data visualization controls - BulletGraph, Sparkline, etc.
* `MouseOverBrush`&mdash;Used for background of the hovered states of non-accent elements.

### Special Brushes
* `DockingBackgroundBrush`&mdash;A special brush used for the background of the Docking control - one of the most specific UI controls for the look and feel of the VisualStudio2019 theme. 
* `HeaderBrush`&mdash;A dark blue brush that is used for the background of the header elements. 
* `ReadOnlyBackgroundBrush`&mdash;A white brush that is used for the background of the read only state of the elements.
* `ReadOnlyBorderBrush`&mdash;A polo blue brush that is used for the border of the read only state of the elements.
* `ValidationBrush`&mdash;A bright red brush that is used for indicating validation errors - for the underline of the invalid control and as a border for the error tooltip, border for invalid rows and cells. 

>important The `AccentFocusedBrush` and the `DockingBackgroundBrush` are __not__ available with versions prior to the __R2 2021__ release of the __UI for WPF__ suite.

## Changing Palette Colors

The VisualStudio2019 theme provides dynamic change of the palette colors responsible for the brushes used in our controls. Their defaults are stated above. This mechanism is used to modify the color variation of the theme. 

The general naming convention is: `VisualStudio2019Palette.Palette.[name]Color` is responsible for `[name]Brush` – e.g. `VisualStudio2019Palette.Palette.AccentColor` sets the color for `telerik:VisualStudio2019Resource ResourceKey=AccentBrush`

Changing the colors can be achieved in code behind.

__Setting palette colors__
```C#
	VisualStudio2019Palette.Palette.AccentColor = Color.FromRgb(255, 0, 0);
```

## Other Properties

* `DisabledOpacity`&mdash;Used for controls when they are in a disabled state. Backgrounds usually use the  `ComplementaryBrush` when disabled.
* `ReadOnlyOpacity`&mdash;Used for controls when they are in a __read-only__ state.

## Changing Theme Variation

Since the __R2 2021__ release of the __UI for WPF__ suite the VisualStudio2019 theme offers two color variations. The `Blue` variation corresponds to the Visual Studio 2019 IDE's Blue theme, and the `Dark` - to the Dark theme. The following example demonstrates the ability to switch between the supported Blue and Dark color palettes by calling the `LoadPreset` method as shown below:

__Changing the color variation of the theme__
```C#
	//default color variation 
	VisualStudio2019Palette.LoadPreset(VisualStudio2019Palette.ColorVariation.Blue);   

	//Dark color variation 
	VisualStudio2019Palette.LoadPreset(VisualStudio2019Palette.ColorVariation.Dark); 
```

__VisualStudio2019 theme color variations__

![VisualStudio2019 theme colors represented in RadTaskBoard](images/VisualStudio2019-theme-variations.PNG)

>important The `Dark` variation of the theme is designed with dark background in mind. It is recommended to use such a background in your application when working with it. 

## Changing Font Properties

When using the `VisualStudio2019` theme you can dynamically change the `FontSize` and `FontFamily` properties of all components in the application the same way as you do in all other [Available Themes]({%slug common-styling-appearance-available-themes%}) which support ThemePalette.

The FontSize and FontFamily properties are public so you can easily modify the theme resources at a single point. The most commonly used font size in the theme is with value __12__ and can be modified through the `VisualStudio2019Palette.Palette.FontSize` property in the same manner as in the other themes that support a theme palette. 

The default font used in the theme is `Segoe UI`.

>important For complex scenarios we strongly recommend setting the `FontSize` properties __only before the application is initialized__. 

The following shows the default font sizes and families.

__Default FontSize__
```C#
	VisualStudio2019Palette.Palette.FontSizeXS = 10;
	VisualStudio2019Palette.Palette.FontSizeS = 11;
	VisualStudio2019Palette.Palette.FontSize = 12;
	VisualStudio2019Palette.Palette.FontSizeL = 13;
	VisualStudio2019Palette.Palette.FontSizeXL = 20;
```

This example shows how to change the default FontFamily from "Segoe UI" to "Calibri Italic" and the FontSize from __12__ to __16__.

__Changing the theme's FontSize and FontFamily__
```C#
	private void OnButtonChangeFontSizeClick(object sender, RoutedEventArgs e)
	{
		VisualStudio2019Palette.Palette.FontSize = 16;
		VisualStudio2019Palette.Palette.FontFamily = new FontFamily("Calibri Italic");
	}
```

__Setting FontSize and FontFamily__

![RadCalendar with modified FontSize and FontFamiliy](images/visualstudio2019-theme-calendar-font-change.png)	

## Using Glyphs

The VisualStudio2019 theme also uses the `Telerik Web UI` [font glyphs]({%slug common-styling-appearance-glyphs-overview%}) by default. The `RadGlyph` provides a lightweight, flexible and design-time-friendly implementation of our glyph font.  

> You can read more about the RadGlyph in the [RadGlyph Overview article]({%slug common-styling-appearance-radglyph%}) and about the range of the font glyphs in the [Font Glyphs Overview article]({%slug common-styling-appearance-glyphs-reference-sheet%}).

## Using Theme Helper

The [ThemeHelper]({%slug styling-appearance-theme-helper%}) class is used in the VisualStudio2019 theme. It exposes a set of attached properties and can be used to directly modify the appearance of a specific basic control without the need to alter its control template.

This example shows a `RadToggleButton` control with modified brushes for its different states through the `ThemeHelper` class:

__Set RadToggleButton's visual appearance through the ThemeHelper class__
```XAML
	<telerik:RadToggleButton Content="RadButton" 
							 Margin="10"
							 xmlns:helpers="clr-namespace:Telerik.Windows.Controls.Theming.Helpers;assembly=Telerik.Windows.Controls"
							 helpers:ThemeHelper.MouseOverBrush="{telerik:VisualStudio2019Resource ResourceKey=AccentMouseOverBrush}"
							 helpers:ThemeHelper.PressedBrush="{telerik:VisualStudio2019Resource ResourceKey=ValidationBrush}"
							 helpers:ThemeHelper.CheckedBrush="{telerik:VisualStudio2019Resource ResourceKey=AccentMainBrush}"/>
```

__Appearance of the RadToggleButton in the different states__
![RadToggleButton States](images/visualstudio2019-theme-togglebutton-states.png)

## Changing Opacity 

If you need to change the opacity of the disabled and read-only elements, you can easily do so by using the `DisabledOpacity` and `ReadOnlyOpacity` properties of the VisualStudio2019Palette. The default values are __0.3__ and __0.6__ respectively. 

__Changing the opacity__		
```C#
	VisualStudio2019Palette.Palette.DisabledOpacity = 0.5;
	VisualStudio2019Palette.Palette.ReadOnlyOpacity = 0.5;
```
```VB.NET
	VisualStudio2019Palette.Palette.DisabledOpacity = 0.5
	VisualStudio2019Palette.Palette.ReadOnlyOpacity = 0.5
```

## Merging Modified Palette Resources With StyleManager Theming Approach

When modifying fonts, colors, or other resources from the `VisualStudio2019Palette` and `StyleManager` is used as theming mechanism, the theme's `ResourceDictionary` needs to be merged in __App.xaml__ file to apply the changes.

__Merging the theme's ResourceDictionary in App.xaml__
```XAML
	<Application.Resources> 
	    <ResourceDictionary> 
	        <ResourceDictionary.MergedDictionaries> 
	            <telerik:VisualStudio2019ResourceDictionary/> 
	        </ResourceDictionary.MergedDictionaries> 
	    </ResourceDictionary> 
	</Application.Resources>
```

## See Also  
 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
 * [Style Manager]({%slug common-styling-apperance-setting-theme-wpf%})
 * [Glyphs Overview]({%slug common-styling-appearance-glyphs-overview%})
 * [VisualStudio2013 Theme]({%slug common-styling-appearance-visualstudio2013-theme%})
