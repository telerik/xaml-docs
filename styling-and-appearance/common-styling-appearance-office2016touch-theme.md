---
title: Office2016Touch Theme
page_title: Office2016Touch Theme
description: Office2016Touch Theme
slug: common-styling-appearance-office2016touch-theme
tags: office2016touch,theme,dynamic,fontsize,fontfamily
published: True
position: 6
---

# Office2016Touch Theme

The official R3 2016 release of UI for WPF includes a brand new Office2016Touch theme.

>important The __Office2016Touch__ theme can only be applied using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}). For this purpose you need to add NoXaml binaries to your application.

__Office2016Touch__ is a variation of the [Office2016 theme]({%slug common-styling-appearance-office2016-theme%}), especially created to be suitable for touch interfaces and to provide larger and more easily accessible components. Part of the controls are simply larger, but some of them are redesigned for easier touch manipulation.

The following topic explains the specifics of the theme's palette and features.

* [Differences from Office2016 theme](#differences-from-office2016-theme)
* [Default theme colors](#default-theme-colors)
* [Palette Brushes](#palette-brushes)
* [Glyphs](#glyphs)
* [Changing Palette Brushes](#changing-palette-brushes)
* [Changing Fonts](#changing-fonts)
* [Changing FocusThickness](#changing-focusthickness)
* [Changing CornerRadius](#changing-cornerradius)
* [ReadOnlyBackgroundBrush and ReadOnlyBorderBrush](#readonlybackgroundbrush and readonlyborderbrush)
* [Changing DisbledOpacity](#changing-disbledopacity)

## Differences from Office2016 theme

The __Office2016Touch__ theme is, as the name suggests, very similar to the __Office2016__ theme but with larger controls and wider spaces for easier interaction. There are several controls that differ significantly and the following figures shows some of them.

#### __Figure 1: RadNumericUpDown__ 
![](images/common-styling-appearance-office2016touch-theme-0.png)

#### __Figure 2: RadOutlookBar__ 
![](images/common-styling-appearance-office2016touch-theme-2.png)

#### __Figure 3: RadRibbonView__ 
![](images/common-styling-appearance-office2016touch-theme-3.png)

## Default theme colors

__Office2016Touch__ has one color variation, designed to be easily modified via the exposed colors in the theme palette. The default values of the brushes in the theme are the same as in the Office2016 theme.

|Brush name|Brush value||
|----------|-----------|---|
|MainBrush|#FFFFFFFF|<div class="theme-palette-color office2016-mainbrush"></div>|
|PrimaryBrush|#FFE6E6E6|<div class="theme-palette-color office2016-primarybrush"></div>|
|ComplementaryBrush|#FFE1E1E1|<div class="theme-palette-color office2016-complementarybrush"></div>|
|AlternativeBrush|#FFF1F1F1|<div class="theme-palette-color office2016-alternativebrush"></div>|
|BasicBrush|#FFABABAB|<div class="theme-palette-color office2016-basicbrush"></div>|
|MarkerBrush|#FF444444|<div class="theme-palette-color office2016-markerbrush"></div>|
|MarkerInvertedBrush|#FFF9F9F9|<div class="theme-palette-color office2016-markerinvertedbrush"></div>|
|IconBrush|#FF444444|<div class="theme-palette-color office2016-iconbrush"></div>|
|ValidationBrush|#FFE81123|<div class="theme-palette-color office2016-validationbrush"></div>|
|AccentBrush|#FF2A579A|<div class="theme-palette-color office2016-accentbrush"></div>|
|AccentMouseOverBrush|#FF3E6DB6|<div class="theme-palette-color office2016-accentmouseoverbrush"></div>|
|AccentPressedBrush|#FF19478A|<div class="theme-palette-color office2016-accentpressedbrush"></div>|
|AccentFocusedBrush|#FF88C3FF|<div class="theme-palette-color office2016-accentfocusedbrush"></div>|
|MouseOverBrush|#FFC5C5C5|<div class="theme-palette-color office2016-mouseoverbrush"></div>|
|PressedBrush|#FFAEAEAE|<div class="theme-palette-color office2016-pressedbrush"></div>|
|SelectedBrush|#FFEBEBEB|<div class="theme-palette-color office2016-selectedbrush"></div>|
|ReadOnlyBackgroundBrush|#FFFFFFFF|<div class="theme-palette-color office2016-readonlybackgroundbrush"></div>|
|ReadOnlyBorderBrush|#FFABABAB|<div class="theme-palette-color office2016-readonlyborderbrush"></div>|

## Palette Brushes

The usage of the theme palette’s brushes is the same as in the [Office2016 theme]({%slug common-styling-appearance-office2016-theme%}).

## Glyphs

The font glyphs we have introduced with the Office2016 theme are built-in the Office2016Touch theme as well. They provide a number of ready-to-use vector icons from the TelerikWebUI font. You can learn more about them and the usage from the [Font Glyphs Overview]({%slug common-styling-appearance-glyphs-overview%}) article.

## Changing Palette Brushes

Office2016Touch provides as well, what is now standard for our themes, dynamic change of the palette colors responsible for the brushes used in our controls. Their defaults are stated above. This mechanism is used to modify the color variation of the theme. 

The general naming convention is: __Office2016TouchPalette.Palette.[name]Color__ is responsible for __[name]Brush__ – e.g. __Office2016TouchPalette.Palette.BasicColor__ sets the color for __telerik:Offie2016TouchResource ResourceName=AccentBrush__

Changing the colors can be achieved in code behind.

#### __[XAML] Example 1: Setting palette colors__
	Office2016TouchPalette.Palette.AccentColor = Color.FromRgb(255, 0, 0);

## Changing Fonts

When using the Office2016Touch theme you can dynamically change the __FontSize__ and __FontFamily__ properties of all components in the application the same way as you do in Windows8, Windows8Touch, Office2013, VisualStudio2013, and Green themes.
	
The FontSize and FontFamily properties are public so you can easily modify the theme resources at a single point. The most commonly used font size in the theme is named FontSize and its default value is 12.
 
> For complex scenarios we strongly recommend setting the __FontSize__ property only initially before the application is initialized. Also, we recommend values between __11px__ and __19px__ for it.
 
__Example 2__ shows the default font sizes and families.

#### __[C#] Example 2: Default FontSize and FontFamily__
	Office2016TouchPalette.Palette.FontSizeS = 10;
	Office2016TouchPalette.Palette.FontSize = 12;
	Office2016TouchPalette.Palette.FontSizeL = 14;
	Office2016TouchPalette.Palette.FontFamily = new FontFamily(“Segoe UI”);

__Examples 3 and 4__ shows how to change the default FontFamily from "Segoe UI" to "Calibri" and the FontSize from 12 to 16 on a click of a button:

#### __[XAML] Example 3: Example view definition__
	<StackPanel>
		<telerik:RadCalendar HorizontalAlignment="Center" />
		<telerik:RadButton Content="Change Font" Click="OnButtonChangeFontSizeClick" />
	</StackPanel>

#### __[C#] Example 4: Changing the theme's FontSize and FontFamily__
	private void OnButtonChangeFontSizeClick(object sender, RoutedEventArgs e)
	{
		Office2016TouchPalette.Palette.FontSize = 16;
		Office2016TouchPalette.Palette.FontFamily = new FontFamily("Calibri");
	}

#### __Figure 4: Setting FontSize and FontFamily__ 
![](images/common-styling-appearance-office2016touch-theme-3.png)	

## Changing FocusThickness

A new feature of the Office2016Touch theme’s palette is the __FocusThickness__ property. It defines the thickness of the buttons’ focus border. As our design is inspired by the Microsoft Office, the focus border of the buttons is thicker than the one of the other controls and elements. By default the FocusThickness is set to __2__, but it can be easily changed in a similar way as the other palette properties.

#### __[C#] Example 5: Changing the theme's FocusThickness__
	Office2016TouchPalette.Palette.FocusThickness = new Thickness(1);

#### __Figure 5: Setting FocusThickness__ 
![](images/common-styling-appearance-office2016touch-theme-4.png)	

## Changing CornerRadius

The Office2016Touch theme exposes an easy way to modify the corner radius of many elements in your application. You can use corner radius properties of the palette. Their default values are __0__.

#### __[C#] Example 6: Setting corner radius__
	Office2016TouchPalette.Palette.CornerRadius = new CornerRadius(0,0,0,0);
	Office2016TouchPalette.Palette.CornerRadiusTop = new CornerRadius(0,0,0,0);
	Office2016TouchPalette.Palette.CornerRadiusBottom = new CornerRadius(0,0,0,0);
	Office2016TouchPalette.Palette.CornerRadiusLeft = new CornerRadius(0,0,0,0);
	Office2016TouchPalette.Palette.CornerRadiusRight = new CornerRadius(0,0,0,0);

__Example 7__ shows how to change the default corner radius from 0 to 3:

#### __[C#] Example 7: Changing the default corner radius__
	Office2016TouchPalette.Palette.CornerRadius = new CornerRadius(3); 
	Office2016TouchPalette.Palette.CornerRadiusBottom = new CornerRadius(0, 0, 3, 3);
	Office2016TouchPalette.Palette.CornerRadiusLeft = new CornerRadius(3, 0, 0, 3);
	Office2016TouchPalette.Palette.CornerRadiusRight = new CornerRadius(0, 3, 3, 0);
	Office2016TouchPalette.Palette.CornerRadiusTop = new CornerRadius(3, 3, 0, 0);

#### __Figure 6: Setting corner radius__ 
![](images/common-styling-appearance-office2016touch-theme-5.png)	

## ReadOnlyBackgroundBrush and ReadOnlyBorderBrush

In the Office2016Touch theme there are two brushes that define background and border brush for the read-only states of the input controls (RadMaskedInput and TextBox). You can do that via the __ReadOnlyBackgroundBrush__ (default value: #FFFFFFFF) and __ReadOnlyBorderBrush__ (default value: #FFABABAB) properties. They are changed in the same manner as the rest of the palette colors.

## Changing DisbledOpacity

If you need to change the opacity of disabled elements, you can easily do it by using the __DisabledOpacity__ property of __Office2016TouchPalette__. The default value of the property is 0.5.

#### __[XAML] Example 8: Changing the disabled opacity__
	Office2016TouchPalette.Palette.DisabledOpacity = 0.3;

#### __Figure 7: Setting the disabled opacity__ 
![](images/common-styling-appearance-office2016touch-theme-6.png)	

## See Also
 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
 * [Office2016 Theme]({%slug common-styling-appearance-office2016-theme%})
 * [VisualStudio2013 Theme]({%slug common-styling-appearance-visualstudio2013-theme%})
 * [Green Theme]({%slug common-styling-appearance-green-theme%})
