---
title: Office2016 Theme
page_title: Office2016 Theme
description: Office2016 Theme
slug: common-styling-appearance-office2016-theme
tags: office2016,theme,dynamic,fontsize,fontfamily
published: True
position: 6
---

# Office2016 Theme

The official R3 2016 release of UI for WPF includes a brand new __Office2016__ theme. 

>important The Office2016 theme can only be applied using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}). For this purpose you need to add NoXaml binaries to your application.

The following topic explains the specifics of the theme's palette and features.

* [Default theme colors](#default-theme-colors)
* [Office2016 Palette Brushes](#office2016-palette-brushes)
* [Changing Fonts](#changing-fonts)
* [Glyphs](#glyphs)
* [Changing FocusThickness](#changing-focusthickness)
* [Changing CornerRadius](#changing-cornerradius)
* [ReadOnlyBackgroundBrush and ReadOnlyBorderBrush](#readonlybackgroundbrush-and-readonlyborderbrush)
* [Changing DisabledOpacity](#changing-disabledopacity)

## Default theme colors

The Office2016 has one color variation, but it is designed to be easily modified via the exposed colors in the theme palette. The default values of the brushes in the theme are listed below:

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

## Office2016 Palette Brushes

Below you can find more details about each brush and where it is usually applied.

* __MainBrush__: This brush is white by default and it is used for the backgrounds of the controls.
* __MarkerBrush__: This brush is black by default and it is used for the foregounds. 
* __MarkerInvertedBrush__: This brush is white by default and it is used for the foregrounds while you interact with the control. If the control has accent interactions states, the brush used in the changing states.

The __Office2016__ palette provides both accent and non-accent brushes for the different interaction states. 

The __accent brushes__ are by default deep blue background brushes and are used to highlight input and interaction elements - e.g. buttons.

* __AccentBrush__: This is the main accent brush and it is used mainly for headers and interaction feedback.
* __AccentMouseOverBrush__: This brush is brighter blue which is the color applied to the controls with accent-colored states while in mouse over state.
* __AccentPressedBrush__: This is the darkest blue and it is used for the pressed states of the controls.

The __non-accent brushes__ are different shades of grey by default and are used for interaction feedback in secondary input or navigation elements and other components which do not need accent – e.g. RadListBox, buttons in RadRibbonView.

* __MouseOverBrush__: This is the non-accent brush for the background of the control while in mouse over state.
* __PressedBrush__: This is the non-accent brush for the background of the control while in pressed state.
* __SelectedBrush__: This is the non-accent brush for the background of the control while in pressed state.
* __AccentFocusedBrush__: This brush is light blue and it's the default brush for the focused visual and rarely for any other interaction.
* __ValidatonBrush__: This brush is red by default and it is used for failed validation where such is applicable in our controls.

There are several brushes used as background color other than the MainBrush.

* __ReadOnlyBackgroundBrush__: This brush white by default and it is used as a background brush of the controls while in read-only state.
* __ReadOnlyBorderBrush__: This brush is light gray by default and it is used as a border brush of the controls while in read-only state.
* __BasicBrush__: This brush is grey and it is used as the default border brush of the controls while in normal state.
* __IconBrush__: This brush is black by default and it is used for glyphs and paths.

#### __Figure 1: Theme colors__
![](images/common-styling-appearance-office2016-theme-0.png)	

## Changing Fonts

When using the Office2016 theme you can dynamically change the __FontSize__ and __FontFamily__ properties of all components in the application the same way as you do in Windows8, Windows8Touch, Office2013, VisualStudio2013, and Green themes.

The __FontSize__ and __FontFamily__ properties are public so you can easily modify the theme resources at a single point. The most commonly used font size in the theme is named FontSize and its default value is 12. 

>important For complex scenarios we strongly recommend setting the FontSize property only initially before the application is initialized. Also, we recommend values between 11px and 19px for it.

__Example 1__ shows the default font sizes and families.

#### __[C#] Example 1: Default FontSize and FontFamily__
	Office2016Palette.Palette.FontSizeS = 10;
	Office2016Palette.Palette.FontSize = 12;
	Office2016Palette.Palette.FontSizeL = 14;
	Office2016Palette.Palette.FontFamily = new FontFamily(“Segoe UI”);

The __Examples 2 and 3__ shows how to change the default FontFamily from "Segoe UI" to "Times New Roman" and the FontSize from 12 to 14 on a click of a button.

#### __[XAML] Example 2: Example view definition__
	<StackPanel>
		<telerik:RadCalendar HorizontalAlignment="Center" />
		<telerik:RadButton Content="Change Font" Click=" OnButtonChangeFontSizeClick " HorizontalAlignment="Center" VerticalAlignment="Center" Margin="0 5 0 0"/>
	</StackPanel>
	
#### __[C#] Example 3: Changing the theme's FontSize and FontFamily__
	private void OnButtonChangeFontSizeClick(object sender, RoutedEventArgs e)
	{
		Office2016Palette.Palette.FontSize = 14;
		Office2016Palette.Palette.FontFamily = new FontFamily("Calibri");
	}

#### __Figure 2: Setting FontSize and FontFamily__
![](images/common-styling-appearance-office2016-theme-1.png)	

## Glyphs

With Office2016 theme we are introducing a new approach to add icons and icon-like images. Instead of images or paths we are using a font of glyphs by default. The __TelerikWebUI__ font provides over 400 scalable vector glyphs that are available for use to our clients. We have chosen this approach to the icons in this theme because it provides a number of advantages and benefits.
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
![](images/common-styling-appearance-office2016-theme-2.png)	

> You can read more about the usage and the different available glyphs in [our article]() about this new feature.

## Changing FocusThickness

A new feature of the Office2016 theme’s palette is the __FocusThickness__ property. It defines the thickness of the buttons’ focus border. As our design is inspired by the Microsoft Office, the focus border of the buttons is thicker than the one of the other controls and elements. By default the FocusThickness is set to 2, but it is easily changeable in a similar way to the other palette properties.

#### __[C#] Example 6: Setting focus border thickness__
	Office2016Palette.Palette.FocusThickness = new Thickness(1);
	
#### __Figure 4: Setting the focus border thickness__
![](images/common-styling-appearance-office2016-theme-3.png)	

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
![](images/common-styling-appearance-office2016-theme-4.png)	

## ReadOnlyBackgroundBrush and ReadOnlyBorderBrush

In the Office2016 theme there are two brushes that define Background and BorderBrush for the read-only states of RadMaskedInput and TextBox. The default colors are __#FFFFFFFF__ for __ReadOnlyBackgroundBrush__ and __#FFABABAB__ for __ReadOnlyBorderBrush__.

## Changing DisabledOpacity

If you need to change the opacity of disabled elements, you can easily do it via the __DisabledOpacity__ property of __Office2016Palette__. The default value of the property is 0.5.

#### __[C#] Example 9: Setting the disabled opacity__
	Office2016Palette.Palette.DisabledOpacity = 0.3;

#### __Figure 6: Setting the disabled opacity__
![](images/common-styling-appearance-office2016-theme-5.png)	

# See Also
 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
 * [Office2013 Theme]({%slug common-styling-appearance-office2013-theme%})
 * [VisualStudio2013 Theme]({%slug common-styling-appearance-visualstudio2013-theme%})
 * [Green Theme]({%slug common-styling-appearance-green-theme%})