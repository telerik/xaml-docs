---
title: Material Theme
page_title: Material Theme
description: Material Theme
slug: common-styling-appearance-material-theme
tags: material,theme,dynamic,fontsize,fontfamily
published: True
position: 7
---

# Material Theme

With the **R2 2017** release of the **UI for WPF** suite we have introduced the brand ne Material Theme. 

The following topic explains the specifics of the theme's palette and features.

* [Default theme colors](#default-theme-colors)
* [Material Palette Brushes](#office2016-palette-brushes)
* [Changing Fonts](#changing-fonts)
* [Glyphs](#glyphs)
* [Material Assist](#material-assist)
* [Shadow Control](#shadow-control)
* [Material Control](#material-control)


## Default Theme Brushes

The **Material Theme** has one color variation, but it is designed to be easily modified via the exposed colors in the theme palette. Furthermore, the introduction of the MaterialAssist helper class makes it easier than ever to modify appearance-related properties. 

The default values of the brushes in the theme are listed below:

|Brush name|Brush value||
|----------|-----------|---|
|MainBrush|#FFFFFFFF|<div class="theme-palette-color materialtheme-mainbrush" color:></div>|
|PrimaryBrush|#FFFAFAFA|<div class="theme-palette-color materialtheme-primarybrush"></div>|
|ComplementaryBrush|#FFE0E0E0|<div class="theme-palette-color materialtheme-complementarybrush"></div>|
|AlternativeBrush|#FFF5F5F5|<div class="theme-palette-color materialtheme-alternativebrush"></div>|
|DividerBrush|#1E000000|<div class="theme-palette-color materialtheme-dividerbrush"></div>|
|MarkerBrush|#FF000000|<div class="theme-palette-color materialtheme-markerbrush"></div>|
|MarkerInvertedBrush|#FFFFFFFF|<div class="theme-palette-color materialtheme-markerinvertedbrush"></div>|
|IconBrush|#FF000000|<div class="theme-palette-color materialtheme-iconbrush"></div>|
|ValidationBrush|#FFD50000|<div class="theme-palette-color materialtheme-validationbrush"></div>|
|AccentNormalBrush|#FFFFAB40|<div class="theme-palette-color materialtheme-accentnormalbrush"></div>|
|AccentHoverBrush|#FFFFD180|<div class="theme-palette-color materialtheme-accenthoverbrush"></div>|
|AccentPressedBrush|#FFFF9100|<div class="theme-palette-color materialtheme-accentpressedbrush"></div>|
|PrimaryNormalBrush|#FF3F51B5|<div class="theme-palette-color materialtheme-primarynormalbrush"></div>|
|PrimaryHoverBrush|#FF303F9F|<div class="theme-palette-color materialtheme-primaryhoverbrush"></div>|
|PrimaryPressedBrush|#FF1A237E|<div class="theme-palette-color materialtheme-primarypressedbrush"></div>|
|PrimaryFocusBrush|#FF9FA8DA|<div class="theme-palette-color materialtheme-primaryfocusbrush"></div>|
|RippleBrush|#FFFFFFFF|<div class="theme-palette-color materialtheme-ripplebrush"></div>|
|DividerSolidBrush|#FFE1E1E1|<div class="theme-palette-color materialtheme-dividersolidbrush"></div>|


## MaterialPalette Brushes

Below you can find more details about each brush and where it is usually applied.

* MainBrush: This brush is white by default and it is mainly used as background of the controls.
* PrimaryBrush: This brush is dark by default and it is used as foregound color. 
* ComplementaryBrush: This brush is a light color by default and it is mostly used as foreground color while you 
* AlternativeBrush:
* DividerBrush:
* MarkerBrush:
* MarkerInvertedBrush:
* IconBrush:
* ValidationBrush:
* AccentNormalBrush:
* AccentHoverBrush:
* AccentPressedBrush:
* PrimaryNormalBrush:
* PrimaryHoverBrush:
* PrimaryPressedBrush:
* PrimaryFocusBrush:
* RippleBrush:
* DividerSolidBrush:

#### __Figure 1: Theme colors__
![](../images/materialthemecolors.png)	

## Font Family and Font Size

When using the Material theme you can dynamically change the __FontSize__ and __FontFamily__ properties of all components in the application the same way as you do in Windows8, Windows8Touch, Office2013, VisualStudio2013, Office2016 and Green themes.

The __FontSize__ and __FontFamily__ properties are public so you can easily modify the theme resources at a single point. The most commonly used font size in the theme is named **FontSize** and its default value is 14. 

The default font used by the theme is [Roboto](https://fonts.google.com/specimen/Roboto) font.

>important For complex scenarios we strongly recommend setting the **FontSize** property only** before the application is initialized**. Also, we recommend values between 11px and 19px for it.

__Example 1__ shows the default font sizes and families.

#### __[C#] Example 1: Default FontSize and FontFamily properties:__

	MaterialPalette.Palette.FontSizeS = 12;
	MaterialPalette.Palette.FontSize = 14;
	MaterialPalette.Palette.FontSizeL = 18;
	MaterialPalette.Palette.FontFamily = new FontFamily(“Roboto”);

The __Examples 2 and 3__ shows how to change the default FontFamily from "Roboto" to "Times New Roman" and the FontSize from 14 to 12 on a click of a button.

#### __[XAML] Example 2: Example view definition__
	<StackPanel>
		<telerik:RadCalendar HorizontalAlignment="Center" />
		<telerik:RadButton Content="Change Font" Click="OnButtonChangeFontSizeClick" HorizontalAlignment="Center" VerticalAlignment="Center" Margin="0 5 0 0"/>
	</StackPanel>
	
#### __[C#] Example 3: Changing the theme's FontSize and FontFamily__
	private void OnButtonChangeFontSizeClick(object sender, RoutedEventArgs e)
	{
		MaterialPalette.Palette.FontSize = 14;
		MaterialPalette.Palette.FontFamily = new FontFamily("Calibri");
	}

#### __Figure 2: Setting FontSize and FontFamily__
![](../images/MaterialThemeFontChange.png)	

## Glyphs

With Office2016 theme we are introducing a new approach to add icons and icon-like images. Instead of images or paths we are using a font of glyphs by default. The __TelerikWebUI__ font provides over 400 scalable vector glyphs that are available for use to our clients. We have chosen this approach because it provides a number of advantages and benefits.
* The glyphs are vector paths which are easily scalable without loss of quality.

* There is a wide range of different beautiful built-in glyphs to choose from.

* They are easily colored – since they are text shapes. It is achieved by setting a Foreground color, which allows their usage in scenarios where the background of the control changes between light and dark color in different interaction states – e.g. buttons.

* They are all contained in the small font file and available for use with the inclusion of the Telerik.Windows.Controls assembly and merging the needed resource dictionary for easier referencing.

* They are available for use in any of our themes, when the needed resources are included. They are not specific for the Office2016 theme.

Since each glyph’s string value is ambiguous and not related to its shape, we are providing a resource dictionary with key-value pairs for easier usage and referencing in projects. It also provides compatibility for future inclusions of new glyphs as it is updated to any shifts in the string values of the existing glyphs with no need to change the references in the projects.

#### __[XAML] Example 4: Adding the ResourceDictionary with the glyphs__
	<ResourceDictionary Source="/Telerik.Windows.Controls;component/Themes/FontResources.xaml"/> 

#### __[XAML] Example 5: Using glyphs__
	<TextBlock FontFamily=”{StaticResource TelerikWebUI}”
			   Foreground=”{telerik:Office2016Resource ResourceKey=IconBrush}”
			   Text=”{StaticResource GlyphHeart}” 			   			   
			   FontWeight=”Normal” 
			   FontSize=”16” />

#### __Figure 3: Heart glyph__
![](../images/common-styling-appearance-office2016-theme-2.png)	

> You can read more about the usage of the new glyph's feature and see the available glyphs in [this article]({%slug common-styling-appearance-glyphs-overview%}).

## Changing FocusThickness

A new feature of the Office2016 theme’s palette is the __FocusThickness__ property. It defines the thickness of the buttons’ focus border. As our design is inspired by the Microsoft Office, the focus border of the buttons is thicker than the one of the other controls and elements. By default the FocusThickness is set to 2, but it is easily changeable in a similar way to the other palette properties.

#### __[C#] Example 6: Setting focus border thickness__
	Office2016Palette.Palette.FocusThickness = new Thickness(1);
	
#### __Figure 4: Setting the focus border thickness__
![](../images/common-styling-appearance-office2016-theme-3.png)	

## Changing CornerRadius

The Office2016 theme exposes an easy way to modify the corner radius of many elements in your application. You can use the corner radius properties of the palette. By default all radius values are 0.

#### __[C#] Example 7: Setting corner radius__
	Office2016Palette.Palette.CornerRadius = new CornerRadius(0,0,0,0);
	Office2016Palette.Palette.CornerRadiusTop = new CornerRadius(0,0,0,0);
	Office2016Palette.Palette.CornerRadiusBottom = new CornerRadius(0,0,0,0);
	Office2016Palette.Palette.CornerRadiusLeft = new CornerRadius(0,0,0,0);
	Office2016Palette.Palette.CornerRadiusRight = new CornerRadius(0,0,0,0);

__Example 8__ shows how to change the default corner radius from 0 to 2.

#### __[C#] Example 8: Changing the default corner radius__
	Office2016Palette.Palette.CornerRadius = new CornerRadius(2); 
	Office2016Palette.Palette.CornerRadiusBottom = new CornerRadius(0, 0, 2, 2);
	Office2016Palette.Palette.CornerRadiusLeft = new CornerRadius(2, 0, 0, 2);
	Office2016Palette.Palette.CornerRadiusRight = new CornerRadius(0, 2, 2, 0);
	Office2016Palette.Palette.CornerRadiusTop = new CornerRadius(2, 2, 0, 0);

#### __Figure 5: Setting the corner radius__
![](../images/common-styling-appearance-office2016-theme-4.png)	

## ReadOnlyBackgroundBrush and ReadOnlyBorderBrush

You can now easily change the read-only background and border brush of all text input controls (Syste.Windows.TextBox, RadDateTimePicker, RadMaskedInput and RadWatermarkTextBox) using the __ReadOnlyBackgroundColor__ and __ReadOnlyBorderColor__ properties of __Office2016Palette__.

#### __[C#] Example 9: Setting the read-only colors__
	Office2016Palette.Palette.ReadOnlyBackgroundColor = (Color)ColorConverter.ConvertFromString("#FFFBDD");
	Office2016Palette.Palette.ReadOnlyBorderColor = (Color)ColorConverter.ConvertFromString("#5F5F5F");

## Changing DisabledOpacity

If you need to change the opacity of disabled elements, you can easily do it via the __DisabledOpacity__ property of __Office2016Palette__. The default value of the property is 0.5.

#### __[C#] Example 10: Setting the disabled opacity__
	Office2016Palette.Palette.DisabledOpacity = 0.3;

#### __Figure 6: Setting the disabled opacity__
![](../images/common-styling-appearance-office2016-theme-5.png)	

## See Also
 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
 * [Office2013 Theme]({%slug common-styling-appearance-office2013-theme%})
 * [VisualStudio2013 Theme]({%slug common-styling-appearance-visualstudio2013-theme%})
 * [Green Theme]({%slug common-styling-appearance-green-theme%})
