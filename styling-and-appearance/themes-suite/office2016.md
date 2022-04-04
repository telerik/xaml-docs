---
title: Office2016 Theme
page_title: Office2016 Theme
description: Achieve an appearance similar to the Microsoft Office 2016 productivity suite by using the Office2016 theme.
slug: common-styling-appearance-office2016-theme
tags: office2016,theme,dynamic,fontsize,fontfamily
published: True
position: 6
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

# Office2016 Theme

The official __R3 2016__ release of UI for WPF includes a brand new `Office2016 Theme`. 

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

* `MainBrush`&mdash;This brush is white by default and it is mainly used as background of the controls.
* `MarkerBrush`&mdash;This brush is dark by default and it is used as foregound color. 
* `MarkerInvertedBrush`&mdash;This brush is a light color by default and it is mostly used as foreground color while you interact with the control. If the control has accent interaction states, we apply the brush for better contrast.

The Office2016 palette provides both accent and non-accent brushes for the different interaction states. 

The __accent brushes__ are by default deep blue brushes and are used to highlight input and interaction elements - e.g. buttons.

* `AccentBrush`&mdash;This is the main accent brush and it is used mainly for headers and interaction feedback.
* `AccentMouseOverBrush`&mdash;This brush is brighter shade of blue and it is used for controls in accent-colored mouse over state.
* `AccentPressedBrush`&mdash;This is the darkest shade of blue and it is used for controls in accent-colored pressed state.

The __non-accent brushes__ are different shades of grey by default and are used for interaction feedback in secondary input or navigation elements and other components which do not need accenting – e.g. RadListBox, buttons in RadRibbonView.

* `MouseOverBrush`&mdash;This is the non-accent brush for the background of the control while in mouse over state.
* `PressedBrush`&mdash;This is the non-accent brush for the background of the control while in pressed state.
* `SelectedBrush`&mdash;This is the non-accent brush for the background of the control while in selected state.
* `AccentFocusedBrush`&mdash;This brush is light blue and it's the default brush for the focused visual and rarely for any other interaction.
* `ValidatonBrush`&mdash;This brush is red by default and it is used for failed validation where such is applicable in our controls.

There are several brushes used as background color other than the MainBrush.

* `PrimaryBrush`&mdash;This brush is used as a background of the input controls in disabled state.
* `AlternativeBrush`&mdash;This brush is used as an alternative background – i.e. for popups or if we want to distinguish one element from another and for more complex controls – RadRichTextBox, RadImageEditor, RadTabControlItem. 
* `ComplementaryBrush`&mdash;This is used for background of components in more complex controls or their states. For example in RadOutlookBar, RadPanelBar, RadTreeView.

There are two read-only brushes in the Office2016 palette:

* `ReadOnlyBackgroundBrush`&mdash;This brush is white by default and it is used as a background brush of the controls while in read-only state.
* `ReadOnlyBorderBrush`&mdash;This brush is light gray by default and it is used as a border brush of the controls while in read-only state.

<!-- -->
* `BasicBrush`&mdash;This brush is grey and it is used as the default border brush of the controls while in normal state.
* `IconBrush`&mdash;This brush is black by default and it is used for glyphs and paths.

__Theme colors__

![](../images/common-styling-appearance-office2016-theme-0.png)	

## Changing Fonts

When using the Office2016 theme you can dynamically change the `FontSize` and `FontFamily` properties of all components in the application the same way as you do in Windows8, Windows8Touch, Office2013, VisualStudio2013, and Green themes.

The FontSize and FontFamily properties are public so you can easily modify the theme resources at a single point. The most commonly used font size in the theme is named FontSize and its default value is __12__. 

>important For complex scenarios we strongly recommend setting the FontSize property only initially before the application is initialized. Also, we recommend values between __11px__ and __19px__ for it.

The following example shows the default font sizes and families.

#### __[C#] Default FontSize and FontFamily__
{{region styling-appearance-office2016-0}}
	Office2016Palette.Palette.FontSizeS = 10;
	Office2016Palette.Palette.FontSize = 12;
	Office2016Palette.Palette.FontSizeL = 14;
	Office2016Palette.Palette.FontFamily = new FontFamily(“Segoe UI”);
{{endregion}}

The following examples show how to change the default FontFamily from "Segoe UI" to "Times New Roman" and the FontSize from __12__ to __14__ on a click of a button.

#### __[XAML] Example view definition__
{{region styling-appearance-office2016-1}}
	<StackPanel>
		<telerik:RadCalendar HorizontalAlignment="Center" />
		<telerik:RadButton Content="Change Font" Click=" OnButtonChangeFontSizeClick " HorizontalAlignment="Center" VerticalAlignment="Center" Margin="0 5 0 0"/>
	</StackPanel>
{{endregion}}
	
#### __[C#] Changing the theme's FontSize and FontFamily__
{{region styling-appearance-office2016-2}}
	private void OnButtonChangeFontSizeClick(object sender, RoutedEventArgs e)
	{
		Office2016Palette.Palette.FontSize = 14;
		Office2016Palette.Palette.FontFamily = new FontFamily("Calibri");
	}
{{endregion}}

__Setting FontSize and FontFamily__

![](../images/common-styling-appearance-office2016-theme-1.png)	

## Glyphs

With Office2016 theme we are introducing a new approach to add icons and icon-like images. Instead of images or paths we are using a font of glyphs by default. The `TelerikWebUI` font provides over 400 scalable vector glyphs that are available for use to our clients. We have chosen this approach because it provides a number of advantages and benefits.
* The glyphs are vector paths which are easily scalable without loss of quality.

* There is a wide range of different beautiful built-in glyphs to choose from.

* They are easily colored – since they are text shapes. It is achieved by setting a Foreground color, which allows their usage in scenarios where the background of the control changes between light and dark color in different interaction states – e.g. buttons.

* They are all contained in the small font file and available for use with the inclusion of the Telerik.Windows.Controls assembly and merging the needed resource dictionary for easier referencing.

* They are available for use in any of our themes, when the needed resources are included. They are not specific for the Office2016 theme.

Since each glyph’s string value is ambiguous and not related to its shape, we are providing a resource dictionary with key-value pairs for easier usage and referencing in projects. It also provides compatibility for future inclusions of new glyphs as it is updated to any shifts in the string values of the existing glyphs with no need to change the references in the projects.

#### __[XAML] Adding the ResourceDictionary with the glyphs__
{{region styling-appearance-office2016-3}}
	<ResourceDictionary Source="/Telerik.Windows.Controls;component/Themes/FontResources.xaml"/> 
{{endregion}}

#### __[XAML] Using glyphs__
{{region styling-appearance-office2016-4}}
	<TextBlock FontFamily=”{StaticResource TelerikWebUI}”
			   Foreground=”{telerik:Office2016Resource ResourceKey=IconBrush}”
			   Text=”{StaticResource GlyphHeart}” 			   			   
			   FontWeight=”Normal” 
			   FontSize=”16” />
{{endregion}}

__Heart glyph__

![](../images/common-styling-appearance-office2016-theme-2.png)	

> You can read more about the usage of the new glyph's feature and see the available glyphs in [this article]({%slug common-styling-appearance-glyphs-overview%}).

## Changing FocusThickness

A new feature of the Office2016 theme’s palette is the `FocusThickness` property. It defines the thickness of the buttons’ focus border. As our design is inspired by the Microsoft Office, the focus border of the buttons is thicker than the one of the other controls and elements. By default the FocusThickness is set to __2__, but it is easily changeable in a similar way to the other palette properties.

#### __[C#] Setting focus border thickness__
{{region styling-appearance-office2016-5}}
	Office2016Palette.Palette.FocusThickness = new Thickness(1);
{{endregion}}
	
__Setting the focus border thickness__

![](../images/common-styling-appearance-office2016-theme-3.png)	

## Changing CornerRadius

The Office2016 theme exposes an easy way to modify the corner radius of many elements in your application. You can use the corner radius properties of the palette. By default all radius values are 0.

#### __[C#] Setting corner radius__
{{region styling-appearance-office2016-6}}
	Office2016Palette.Palette.CornerRadius = new CornerRadius(0,0,0,0);
	Office2016Palette.Palette.CornerRadiusTop = new CornerRadius(0,0,0,0);
	Office2016Palette.Palette.CornerRadiusBottom = new CornerRadius(0,0,0,0);
	Office2016Palette.Palette.CornerRadiusLeft = new CornerRadius(0,0,0,0);
	Office2016Palette.Palette.CornerRadiusRight = new CornerRadius(0,0,0,0);
{{endregion}}

The following example shows how to change the default corner radius from 0 to 2.

#### __[C#] Changing the default corner radius__
{{region styling-appearance-office2016-7}}
	Office2016Palette.Palette.CornerRadius = new CornerRadius(2); 
	Office2016Palette.Palette.CornerRadiusBottom = new CornerRadius(0, 0, 2, 2);
	Office2016Palette.Palette.CornerRadiusLeft = new CornerRadius(2, 0, 0, 2);
	Office2016Palette.Palette.CornerRadiusRight = new CornerRadius(0, 2, 2, 0);
	Office2016Palette.Palette.CornerRadiusTop = new CornerRadius(2, 2, 0, 0);
{{endregion}}

__Setting the corner radius__

![](../images/common-styling-appearance-office2016-theme-4.png)	

## ReadOnlyBackgroundBrush and ReadOnlyBorderBrush

You can now easily change the read-only background and border brush of all text input controls (Syste.Windows.TextBox, RadDateTimePicker, RadMaskedInput and RadWatermarkTextBox) using the `ReadOnlyBackgroundColor` and `ReadOnlyBorderColor` properties of `Office2016Palette`.

#### __[C#] Setting the read-only colors__
{{region styling-appearance-office2016-8}}
	Office2016Palette.Palette.ReadOnlyBackgroundColor = (Color)ColorConverter.ConvertFromString("#FFFBDD");
	Office2016Palette.Palette.ReadOnlyBorderColor = (Color)ColorConverter.ConvertFromString("#5F5F5F");
{{endregion}}

## Changing DisabledOpacity

If you need to change the opacity of disabled elements, you can easily do it via the `DisabledOpacity` property of the `Office2016Palette`. The default value of the property is 0.5.

#### __[C#] Setting the disabled opacity__
{{region styling-appearance-office2016-9}}
	Office2016Palette.Palette.DisabledOpacity = 0.3;
{{endregion}}

__Setting the disabled opacity__

![](../images/common-styling-appearance-office2016-theme-5.png)	

>important When modifying fonts, colors, or other resources from the `Office2016Palette` and `StyleManager` is used as theming mechanism, the theme's `ResourceDictionary` needs to be merged in __App.xaml__ file to apply the changes.

#### __[XAML] Merging the theme's ResourceDictionary in App.xaml__
{{region styling-appearance-office2016-10}}
	<Application.Resources> 
	    <ResourceDictionary> 
	        <ResourceDictionary.MergedDictionaries> 
	            <telerik:Office2016ResourceDictionary/> 
	        </ResourceDictionary.MergedDictionaries> 
	    </ResourceDictionary> 
	</Application.Resources>
{{endregion}}

## See Also
 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
 * [Office2013 Theme]({%slug common-styling-appearance-office2013-theme%})
 * [VisualStudio2013 Theme]({%slug common-styling-appearance-visualstudio2013-theme%})
 * [Green Theme]({%slug common-styling-appearance-green-theme%})
