---
title: Office2016Touch Theme
page_title: Office2016Touch Theme
description: Check our Office2016Touch Theme for Telerik UI for {{ site.framework_name }}.
slug: common-styling-appearance-office2016touch-theme
tags: office2016touch,theme,dynamic,fontsize,fontfamily
published: True
position: 8
---

<style>
.theme-palette-color {
	width:20px;
	height:20px;
	margin: auto;
	border: 1px solid black;
}

.office2016-mainbrush {	
	background: #FFFFFF;
}
.office2016-primarybrush {	
	background: #E6E6E6;
}
.office2016-complementarybrush {	
	background: #E1E1E1;
}
.office2016-alternativebrush {	
	background: #F1F1F1;
}
.office2016-basicbrush {	
	background: #ABABAB;
}
.office2016-markerbrush {	
	background: #444444;
}
.office2016-markerinvertedbrush {	
	background: #F9F9F9;
}
.office2016-iconbrush {	
	background: #444444;
}
.office2016-validationbrush {	
	background: #E81123;
}
.office2016-accentbrush {	
	background: #2A579A;
}
.office2016-accentmouseoverbrush {	
	background: #3E6DB6;
}
.office2016-accentpressedbrush {	
	background: #19478A;
}
.office2016-accentfocusedbrush {	
	background: #88C3FF;
}
.office2016-mouseoverbrush {	
	background: #C5C5C5;
}
.office2016-pressedbrush {	
	background: #AEAEAE;
}
.office2016-selectedbrush {	
	background: #EBEBEB;
}
.office2016-readonlybackgroundbrush {	
	background: #FFFFFF;
}
.office2016-readonlyborderbrush {	
	background: #ABABAB;
}

article table
{
    table-layout: auto;
}
</style>

# Office2016Touch Theme

The `Office2016Touch` theme is a variation of the [Office2016 theme]({%slug common-styling-appearance-office2016-theme%}), especially created to be suitable for touch interfaces and to provide larger and more easily accessible components. Part of the controls are simply larger, but some of them are redesigned for easier touch manipulation.

Jump to the following topics to learn about the specifics of the theme's palette and features.

* [Differences From the Office2016 Theme](#differences-from-the-office2016-theme)
* [Default Theme Colors](#default-theme-colors)
* [Default Theme Brushes](#default-theme-brushes)
* [Changing Palette Colors](#changing-palette-colors)
* [Changing Font Properties](#changing-font-properties)
* [Changing FocusThickness](#changing-focusthickness)
* [Changing Corner Radius](#changing-corner-radius)
* [Using Glyphs](#using-glyphs)
* [Changing Opacity](#changing-opacity)

## Differences From the Office2016 Theme

The Office2016Touch theme is, as the name suggests, very similar to the Office2016 theme but with larger controls and wider spaces for easier interaction. There are several controls that differ significantly and the following figures shows some of them.

__RadNumericUpDown__ 

![RadNumericUpDown with Office2016Touch theme](images/common-styling-appearance-office2016touch-theme-0.png)

__RadOutlookBar__

![RadOutlookBar with Office2016Touch theme](images/common-styling-appearance-office2016touch-theme-1.png)

__RadRibbonView__ 

![RadRibbonView with Office2016Touch theme](images/common-styling-appearance-office2016touch-theme-2.png)

## Default Theme Colors

Office2016Touch has one color variation, designed to be easily modified via the exposed colors in the theme palette. The default values of the brushes in the theme are the same as in the Office2016 theme.

|Color name|Hex code||
|----------|-----------|---|
|MainColor|#FFFFFFFF|<div class="theme-palette-color office2016-mainbrush"></div>|
|PrimaryColor|#FFE6E6E6|<div class="theme-palette-color office2016-primarybrush"></div>|
|ComplementaryColor|#FFE1E1E1|<div class="theme-palette-color office2016-complementarybrush"></div>|
|AlternativeColor|#FFF1F1F1|<div class="theme-palette-color office2016-alternativebrush"></div>|
|BasicColor|#FFABABAB|<div class="theme-palette-color office2016-basicbrush"></div>|
|MarkerColor|#FF444444|<div class="theme-palette-color office2016-markerbrush"></div>|
|MarkerInvertedColor|#FFF9F9F9|<div class="theme-palette-color office2016-markerinvertedbrush"></div>|
|IconColor|#FF444444|<div class="theme-palette-color office2016-iconbrush"></div>|
|ValidationColor|#FFE81123|<div class="theme-palette-color office2016-validationbrush"></div>|
|AccentColor|#FF2A579A|<div class="theme-palette-color office2016-accentbrush"></div>|
|AccentMouseOverColor|#FF3E6DB6|<div class="theme-palette-color office2016-accentmouseoverbrush"></div>|
|AccentPressedColor|#FF19478A|<div class="theme-palette-color office2016-accentpressedbrush"></div>|
|AccentFocusedColor|#FF88C3FF|<div class="theme-palette-color office2016-accentfocusedbrush"></div>|
|MouseOverColor|#FFC5C5C5|<div class="theme-palette-color office2016-mouseoverbrush"></div>|
|PressedColor|#FFAEAEAE|<div class="theme-palette-color office2016-pressedbrush"></div>|
|SelectedColor|#FFEBEBEB|<div class="theme-palette-color office2016-selectedbrush"></div>|
|ReadOnlyBackgroundColor|#FFFFFFFF|<div class="theme-palette-color office2016-readonlybackgroundbrush"></div>|
|ReadOnlyBorderColor|#FFABABAB|<div class="theme-palette-color office2016-readonlyborderbrush"></div>|

## Default Theme Brushes

The usage of the theme palette’s brushes is the same as in the [Office2016 theme]({%slug common-styling-appearance-office2016-theme%}).

## Changing Palette Colors

The Office2016Touch theme provides dynamic change of the palette colors responsible for the brushes used in our controls. Their defaults are stated above. This mechanism is used to modify the color variation of the theme. 

The general naming convention is: `Office2016TouchPalette.Palette.[name]Color` is responsible for `[name]Brush` – e.g. `Office2016TouchPalette.Palette.AccentColor` sets the color for `telerik:Offie2016TouchResource ResourceKey=AccentBrush`

Changing the colors can be achieved in code behind.

__Setting palette colors__
```C#
	Office2016TouchPalette.Palette.AccentColor = Color.FromRgb(255, 0, 0);
```

## Changing Font Properties

When using the Office2016Touch theme you can dynamically change the `FontSize` and `FontFamily` properties of all components in the application the same way as you do in all other [Available Themes]({%slug common-styling-appearance-available-themes%}) which support ThemePalette.

The FontSize and FontFamily properties are public so you can easily modify the theme resources at a single point. The most commonly used font size in the theme is named FontSize and its default value is __12__.

> For complex scenarios we strongly recommend setting the `FontSize` property only initially before the application is initialized. Also, we recommend values between __11px__ and __19px__ for it.

__Default FontSize and FontFamily__
```C#
	Office2016TouchPalette.Palette.FontSizeS = 12;
	Office2016TouchPalette.Palette.FontSize = 14;
	Office2016TouchPalette.Palette.FontSizeL = 16;
	Office2016TouchPalette.Palette.FontFamily = new FontFamily("Segoe UI");
```

The following examples show how to change the default FontFamily from "Segoe UI" to "Calibri" and the FontSize from __14__ to __16__ on a click of a button:

__Example view definition__
```XAML
	<StackPanel>
		<telerik:RadCalendar HorizontalAlignment="Center" />
		<telerik:RadButton Content="Change Font" Click="OnButtonChangeFontSizeClick" />
	</StackPanel>
```

__Changing the theme's FontSize and FontFamily__
```C#
	private void OnButtonChangeFontSizeClick(object sender, RoutedEventArgs e)
	{
		Office2016TouchPalette.Palette.FontSize = 16;
		Office2016TouchPalette.Palette.FontFamily = new FontFamily("Calibri");
	}
```

__Setting FontSize and FontFamily__

![Setting FontSize and FontFamily](images/common-styling-appearance-office2016touch-theme-3.png)	

## Changing FocusThickness

The `Office2016Touch` theme’s palette includes a `FocusThickness` property. It defines the thickness of the buttons’ focus border. As our design is inspired by the Microsoft Office, the focus border of the buttons is thicker than the one of the other controls and elements. By default the FocusThickness is set to __2__, but it can be easily changed in a similar way as the other palette properties.

__Changing the theme's FocusThickness__
```C#
	Office2016TouchPalette.Palette.FocusThickness = new Thickness(1);
```

__Setting FocusThickness__ 

![Setting FocusThickness](images/common-styling-appearance-office2016touch-theme-4.png)	

## Changing Corner Radius

The Office2016Touch theme exposes an easy way to modify the corner radius of many elements in your application. You can use corner radius properties of the palette. Their default value is __0__.

__Setting corner radius__
```C#
	Office2016TouchPalette.Palette.CornerRadius = new CornerRadius(0,0,0,0);
	Office2016TouchPalette.Palette.CornerRadiusTop = new CornerRadius(0,0,0,0);
	Office2016TouchPalette.Palette.CornerRadiusBottom = new CornerRadius(0,0,0,0);
	Office2016TouchPalette.Palette.CornerRadiusLeft = new CornerRadius(0,0,0,0);
	Office2016TouchPalette.Palette.CornerRadiusRight = new CornerRadius(0,0,0,0);
```

__Changing the default corner radius__
```C#
	Office2016TouchPalette.Palette.CornerRadius = new CornerRadius(3); 
	Office2016TouchPalette.Palette.CornerRadiusBottom = new CornerRadius(0, 0, 3, 3);
	Office2016TouchPalette.Palette.CornerRadiusLeft = new CornerRadius(3, 0, 0, 3);
	Office2016TouchPalette.Palette.CornerRadiusRight = new CornerRadius(0, 3, 3, 0);
	Office2016TouchPalette.Palette.CornerRadiusTop = new CornerRadius(3, 3, 0, 0);
```

__Setting corner radius__ 

![Setting corner radius](images/common-styling-appearance-office2016touch-theme-theme-5.png)	

## Using Glyphs

The font glyphs that have been introduced with the Office2016 theme are built-in for the Office2016Touch theme as well. They provide a number of ready-to-use vector icons from the `TelerikWebUI` font. You can learn more about them and the usage from the [Font Glyphs Overview]({%slug common-styling-appearance-glyphs-overview%}) article.

## Changing Opacity

You can easily change the opacity of any disabled element by using the `DisabledOpacity` property of the `Office2016TouchPalette`. The default value of the property is __0.5__.

__Changing the disabled opacity__
```C#
	Office2016TouchPalette.Palette.DisabledOpacity = 0.3;
```

__Setting the disabled opacity__ 

![Setting the disabled opacity](images/common-styling-appearance-office2016touch-theme-theme-6.png)	

## Merging Modified Palette Resources With StyleManager Theming Approach

When modifying fonts, colors, or other resources from the `Office2016TouchPalette` and `StyleManager` is used as theming mechanism, the theme's `ResourceDictionary` needs to be merged in __App.xaml__ file to apply the changes.

__Merging the theme's ResourceDictionary in App.xaml__
```XAML
	<Application.Resources> 
	    <ResourceDictionary> 
	        <ResourceDictionary.MergedDictionaries> 
	            <telerik:Office2016TouchResourceDictionary/> 
	        </ResourceDictionary.MergedDictionaries> 
	    </ResourceDictionary> 
	</Application.Resources>
```

## See Also
 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
 * [Office2016 Theme]({%slug common-styling-appearance-office2016-theme%})
 * [VisualStudio2013 Theme]({%slug common-styling-appearance-visualstudio2013-theme%})
 * [Green Theme]({%slug common-styling-appearance-green-theme%})
