---
title: Crystal Theme
page_title: Crystal Theme
description: Crystal Theme
slug: common-styling-appearance-crystal-theme
tags: crystal,theme,glyphs,fontsize,fontfamily,cornerradius
published: True
position: 7
---

<style>
.theme-palette-color {
	width:20px;
	height:20px;
	margin: auto;
	border: 1px solid black;
}

.crystaltheme-accenthighcolor {
	background: #56A9FD;
}
.crystaltheme-accentlowcolor {
	background: #087EFF;
}
.crystaltheme-accentmouseoverhighcolor {
	background: #2590FB;
}
.crystaltheme-accentmouseoverlowcolor {
	background: #0072EE;
}
.crystaltheme-accentpressedcolor {
	background: #0060CF;
}
.crystaltheme-accentfocusedcolor {
	background: #7CB7F9;
}
.crystaltheme-accentselectedcolor {
	background: #1C83FF;
}
.crystaltheme-basichighcolor {
	background: #CCCCCC;
}
.crystaltheme-basiclowcolor {
	background: #A4A3A4;
}
.crystaltheme-accentbasichighcolor {
	background: #2390FD;
}
.crystaltheme-accentbasiclowcolor {
	background: #0052E6;
}
.crystaltheme-iconcolor {
	background: #505050;
}
.crystaltheme-mainhighcolor {
	background: #FFFFFF;
}
.crystaltheme-mainlowcolor {
	background: #F3F3F3;
}
.crystaltheme-markercolor {
	background: #020202;
}
.crystaltheme-validationcolor {
	background: #D40012;
}
.crystaltheme-complementarycolor {
	background: #DEDEDE;
}
.crystaltheme-complementarybasichighcolor {
	background: #ADADAD;
}
.crystaltheme-complementarybasiclowcolor {
	background: #8D8D8D;
}
.crystaltheme-mouseoverhighcolor {
	background: #F3F3F3;
}
.crystaltheme-mouseoverlowcolor {
	background: #EEEEEE;
}
.crystaltheme-pressedhighcolor {
	background: #DCDCDC;
}
.crystaltheme-pressedlowcolor {
	background: #CDCDCD;
}
.crystaltheme-alternativecolor {
	background: #EAEAEA;
}
.crystaltheme-alternativebasiccolor {
	background: #D3D3D3;
}
.crystaltheme-markerinvertedcolor {
	background: #FFFFFF;
}
.crystaltheme-primarybackgroundcolor {
	background: #FFFFFF;
}
.crystaltheme-headerhighcolor {
	background: #E8E6E6;
}
.crystaltheme-headerlowcolor {
	background: #D4D0D0;
}
.crystaltheme-readonlybackgroundcolor {
	background: #FFFFFF;
}
.crystaltheme-readonlybordercolor {
	background: #A4A3A4;
}

.crystaltheme-accenthighcolor-dark {
	background: #56A9FD;
}
.crystaltheme-accentlowcolor-dark {
	background: #087EFF;
}
.crystaltheme-accentmouseoverhighcolor-dark {
	background: #2590FB;
}
.crystaltheme-accentmouseoverlowcolor-dark {
	background: #0072EE;
}
.crystaltheme-accentpressedcolor-dark {
	background: #0060CF;
}
.crystaltheme-accentfocusedcolor-dark {
	background: #7CB7F9;
}
.crystaltheme-accentselectedcolor-dark {
	background: #1C83FF;
}
.crystaltheme-basichighcolor-dark {
	background: #818181;
}
.crystaltheme-basiclowcolor-dark {
	background: #4F4F4F;
}
.crystaltheme-accentbasichighcolor-dark {
	background: #2390FD;
}
.crystaltheme-accentbasiclowcolor-dark {
	background: #0052E6;
}
.crystaltheme-iconcolor-dark {
	background: #FFFFFF;
}
.crystaltheme-mainhighcolor-dark {
	background: #686868;
}
.crystaltheme-mainlowcolor-dark {
	background: #5F5F5F;
}
.crystaltheme-markercolor-dark {
	background: #FFFFFF;
}
.crystaltheme-validationcolor-dark {
	background: #D40012;
}
.crystaltheme-complementarycolor-dark {
	background: #252525;
}
.crystaltheme-complementarybasichighcolor-dark {
	background: #646464;
}
.crystaltheme-complementarybasiclowcolor-dark {
	background: #4D4D4D;
}
.crystaltheme-mouseoverhighcolor-dark {
	background: #898989;
}
.crystaltheme-mouseoverlowcolor-dark {
	background: #818181;
}
.crystaltheme-pressedhighcolor-dark {
	background: #5B5B5B;
}
.crystaltheme-pressedlowcolor-dark {
	background: #4B4B4B;
}
.crystaltheme-alternativecolor-dark {
	background: #3A3A3A;
}
.crystaltheme-alternativebasiccolor-dark {
	background: #4D4D4D;
}
.crystaltheme-markerinvertedcolor-dark {
	background: #FFFFFF;
}
.crystaltheme-primarybackgroundcolor-dark {
	background: #2C2C2C;
}
.crystaltheme-headerhighcolor-dark {
	background: #5B5B5B;
}
.crystaltheme-headerlowcolor-dark {
	background: #494949;
}
.crystaltheme-readonlybackgroundcolor-dark {
	background: #2C2C2C;
}
.crystaltheme-readonlybordercolor-dark {
	background: #4D4D4D;
}

article table
{
    table-layout: auto;
}
</style>

# Crystal Theme

With the **R3 2018** release of the **UI for WPF** suite we have introduced the brand new **Crystal theme**. Inspired by MacOS, the Crystal theme delivers the renown Mac OS look and feel to your WPF apps. The team at Apple have been a trend setter with their clean UI and with the Crystal theme you will be able to bring that style to your own apps.

The following topic explains the specifics of the theme's palette and features.

* [Default Theme Colors](#default-theme-colors)
* [CrystalPalette Properties](#crystalpalette-properties)
* [Theme Variation Changing](#theme-variation-changing)
* [Changing Fonts](#font-family-and-font-size)
* [Glyphs](#glyphs)
* [Changing Corner Radius](#set-corner-radius)
* [Material Assist](#material-assist)
* [Window Buttons Alignment](#window-buttons-alignment)

## Default Theme Colors

The **Crystal Theme** is designed to be easily modified via the exposed colors in the theme palette.

The default values of the brushes in the theme are listed below. Please note that as the theme uses a number of gradients, most of the colors have a **low** and **high** value which indicates the colors at both stops of the gradient.

|Color name|Light||Dark||
|----------|-----------|---|-----------|---|
|**AccentHighColor**|#FF56A9FD|<div class="theme-palette-color crystaltheme-accenthighcolor" color:></div>|#FF56A9FD|<div class="theme-palette-color crystaltheme-accenthighcolor-dark" color:></div>|
|**AccentLowColor**|#FF087EFF|<div class="theme-palette-color crystaltheme-accentlowcolor"></div>|#FF087EFF|<div class="theme-palette-color crystaltheme-accentlowcolor-dark"></div>|
|**AccentMouseOverHighColor**|#FF2590FB|<div class="theme-palette-color crystaltheme-accentmouseoverhighcolor"></div>|#FF2590FB|<div class="theme-palette-color crystaltheme-accentmouseoverhighcolor-dark"></div>|
|**AccentMouseOverLowColor**|#FF0072EE|<div class="theme-palette-color crystaltheme-accentmouseoverlowcolor"></div>|#FF0072EE|<div class="theme-palette-color crystaltheme-accentmouseoverlowcolor-dark"></div>|
|**AccentPressedColor**|#FF0060CF|<div class="theme-palette-color crystaltheme-accentpressedcolor"></div>|#FF0060CF|<div class="theme-palette-color crystaltheme-accentpressedcolor-dark"></div>|
|**AccentFocusedColor**|#FF7CB7F9|<div class="theme-palette-color crystaltheme-accentfocusedcolor"></div>|#FF7CB7F9|<div class="theme-palette-color crystaltheme-accentfocusedcolor-dark"></div>|
|**AccentSelectedColor**|#FF1C83FF|<div class="theme-palette-color crystaltheme-accentselectedcolor"></div>|#FF1C83FF|<div class="theme-palette-color crystaltheme-accentselectedcolor-dark"></div>|
|**BasicHighColor**|#FFCCCCCC|<div class="theme-palette-color crystaltheme-basichighcolor"></div>|#FF818181|<div class="theme-palette-color crystaltheme-basichighcolor-dark"></div>|
|**BasicLowColor**|#FFA4A3A4|<div class="theme-palette-color crystaltheme-basiclowcolor"></div>|#FF4F4F4F|<div class="theme-palette-color crystaltheme-basiclowcolor-dark"></div>|
|**AccentBasicHighColor**|#FF2390FD|<div class="theme-palette-color crystaltheme-accentbasichighcolor"></div>|#FF2390FD|<div class="theme-palette-color crystaltheme-accentbasichighcolor-dark"></div>|
|**AccentBasicLowColor**|#FF0052E6|<div class="theme-palette-color crystaltheme-accentbasiclowcolor"></div>|#FF0052E6|<div class="theme-palette-color crystaltheme-accentbasiclowcolor-dark"></div>|
|**IconColor**|#FF505050|<div class="theme-palette-color crystaltheme-iconcolor"></div>|#FFFFFFFF|<div class="theme-palette-color crystaltheme-iconcolor-dark"></div>|
|**MainHighColor**|#FFFFFFFF|<div class="theme-palette-color crystaltheme-mainhighcolor"></div>|#FF686868|<div class="theme-palette-color crystaltheme-mainhighcolor-dark"></div>|
|**MainLowColor**|#FFF3F3F3|<div class="theme-palette-color crystaltheme-mainlowcolor"></div>|#FF5F5F5F|<div class="theme-palette-color crystaltheme-mainlowcolor-dark"></div>|
|**MarkerColor**|#FF020202|<div class="theme-palette-color crystaltheme-markercolor"></div>|#FFFFFFFF|<div class="theme-palette-color crystaltheme-markercolor-dark"></div>|
|**ValidationColor**|#FFD40012|<div class="theme-palette-color crystaltheme-validationcolor"></div>|#FFD40012|<div class="theme-palette-color crystaltheme-validationcolor-dark"></div>|
|**ComplementaryColor**|#FFDEDEDE|<div class="theme-palette-color crystaltheme-complementarycolor"></div>|#FF252525|<div class="theme-palette-color crystaltheme-complementarycolor-dark"></div>|
|**ComplementaryBasicHighColor**|#FFADADAD|<div class="theme-palette-color crystaltheme-complementarybasichighcolor"></div>|#FF646464|<div class="theme-palette-color crystaltheme-complementarybasichighcolor-dark"></div>|
|**ComplementaryBasicLowColor**|#FF8D8D8D|<div class="theme-palette-color crystaltheme-complementarybasiclowcolor"></div>|#FF4D4D4D|<div class="theme-palette-color crystaltheme-complementarybasiclowcolor-dark"></div>|
|**MouseOverHighColor**|#FFF3F3F3|<div class="theme-palette-color crystaltheme-mouseoverhighcolor"></div>|#FF898989|<div class="theme-palette-color crystaltheme-mouseoverhighcolor-dark"></div>|
|**MouseOverLowColor**|#FFEEEEEE|<div class="theme-palette-color crystaltheme-mouseoverlowcolor"></div>|#FF818181|<div class="theme-palette-color crystaltheme-mouseoverlowcolor-dark"></div>|
|**PressedHighColor**|#FFDCDCDC|<div class="theme-palette-color crystaltheme-pressedhighcolor"></div>|#FF5B5B5B|<div class="theme-palette-color crystaltheme-pressedhighcolor-dark"></div>|
|**PressedLowColor**|#FFCDCDCD|<div class="theme-palette-color crystaltheme-pressedlowcolor"></div>|#FF4B4B4B|<div class="theme-palette-color crystaltheme-pressedlowcolor-dark"></div>|
|**AlternativeColor**|#FFEAEAEA|<div class="theme-palette-color crystaltheme-alternativecolor"></div>|#FF3A3A3A|<div class="theme-palette-color crystaltheme-alternativecolor-dark"></div>|
|**AlternativeBasicColor**|#FFD3D3D3|<div class="theme-palette-color crystaltheme-alternativebasiccolor"></div>|#FF4D4D4D|<div class="theme-palette-color crystaltheme-alternativebasiccolor-dark"></div>|
|**MarkerInvertedColor**|#FFFFFFFF|<div class="theme-palette-color crystaltheme-markerinvertedcolor"></div>|#FFFFFFFF|<div class="theme-palette-color crystaltheme-markerinvertedcolor-dark"></div>|
|**PrimaryBackgroundColor**|#FFFFFFFF|<div class="theme-palette-color crystaltheme-primarybackgroundcolor"></div>|#FF2C2C2C|<div class="theme-palette-color crystaltheme-primarybackgroundcolor-dark"></div>|
|**HeaderHighColor**|#FFE8E6E6|<div class="theme-palette-color crystaltheme-headerhighcolor"></div>|#FF5B5B5B|<div class="theme-palette-color crystaltheme-headerhighcolor-dark"></div>|
|**HeaderLowColor**|#FFD4D0D0|<div class="theme-palette-color crystaltheme-headerlowcolor"></div>|#FF494949|<div class="theme-palette-color crystaltheme-headerlowcolor-dark"></div>|
|**ReadOnlyBackgroundColor**|#FFFFFFFF|<div class="theme-palette-color crystaltheme-readonlybackgroundcolor"></div>|#FF2C2C2C|<div class="theme-palette-color crystaltheme-readonlybackgroundcolor-dark"></div>|
|**ReadOnlyBorderColor**|#FFA4A3A4|<div class="theme-palette-color crystaltheme-readonlybordercolor"></div>|#FF4D4D4D|<div class="theme-palette-color crystaltheme-readonlybordercolor-dark"></div>|

#### __Figure 1: Theme colors represented in RadOutlookBar__
![Crystal theme colors represented in RadOutlookBar](images/crystal-theme-outlook.PNG)	

## CrystalPalette Properties

### Primary Brushes 

* **PrimaryBackgroundBrush**: Used in backgrounds of inputs. 
* **MainBrush**: Used for backgrounds of buttons. 
* **AlternativeBrush**: Used for backgrounds of popups, windows, listboxes etc. 
* **AlternativeBasicBrush**: Used for borders in the cases when several would overlap (in complex grid-structured controls) and is calculated automatically when the BasicBrush is changed by overlaying it on top of the PrimaryBackgroundBrush 
* **BasicBrush**: Used in the majority of the normal state borders. 
* **ComplementaryBrush**: Slightly darker than the alternative in case of collisions. Used for background of footers as well. 
* **ComplementaryBasicBrush**: Used for borders of windows. 
* **MarkerBrush**: Used for the majority of foregrounds which are black. 
* **MarkerInvertedBrush**: Used for interactions states - white in both variations. 
* **IconBrush**: Used for glyph and path icons, which should be 80% of black. 
* **AccentBrush**: Used for backgrounds of radio, repeat, split, toggle buttons, as well as picker control buttons – DatePicker, DateTimePicker, CalculatorPicker, etc. 
* **AccentBasicBrush**: Used for border of the above-mentioned controls, that have AccentBrush for their background. 

### Interaction State Brushes 
* **AccentFocusedBrush**: Variation of the AccentBrush that is used for the focused states of primary accent elements.  
* **AccentMouseOverBrush**: Variation of the AccentBrush that is used for the hovered states of primary accent elements. 
* **AccentSelectedBrush**: Variation of the AccentBrush that is used for the selected states of primary accent elements. 
* **AccentPressedBrush**: Variation of the AccentBrush that is used for the pressed states of primary accent elements. 
* **MouseOverBrush**: Used in backgrounds for the hovered states of non-accent elements. 
* **PressedBrush**: Used in backgrounds for the pressed states of non-accent elements. 

### Special Brushes

* **HeaderBrush**: Used in backgrounds of header elements. 
* **ValidationBrush**:  A bright red brush used for indicating validation errors - for the underline of the invalid control and as a background for the error tooltip, background for invalid rows and cells as well as for clear buttons' mouse over states. 

## Other Properties

* **DisabledOpacity**: Used for text when they are disabled. Backgrounds usually use the  **AlternativeBrush** when disabled.
* **InputOpacity**: Used for text in masked input controls and watermark elements.
* **ReadOnlyOpacity**: Used for text in inputs when they are in a **read-only** state.
* **FocusThickness**: The default value is **2, 2, 2, 2**. It is used for the thickness of the focus border.

## Theme Variation Changing

You can switch between the color palettes by calling the LoadPreset method as shown below:

#### **[C#] Example 1: Changing the color variantion of the theme**
{{region styling-appearance-crystal-theme-0}}	
	//default color variation
	CrystalPalette.LoadPreset(CrystalPalette.ColorVariation.Light);  

	//dark color variation
	CrystalPalette.LoadPreset(CrystalPalette.ColorVariation.Dark);
{{endregion}}

>The **Dark** variation of the theme is designed with a dark background in mind and it is recommended to use such a background in your application when working with it.

## Font Family and Font Size

When using the **Crystal theme** you can dynamically change the **FontSize** and **FontFamily** properties of all components in the application the same way as you do in **Windows8**, **Windows8Touch**, **Office2013**, **VisualStudio2013**, **Office2016**, **Green**, **Material** and **Fluent** themes.

The **FontSize** and **FontFamily** properties are public so you can easily modify the theme resources at a single point. The most commonly used font size in the theme is with value **13** and can be modified through the **CrystalPalette.Palette.FontSize** property in the same manner as in the other themes that support a theme palette. 

The default font used in the theme is [Roboto](https://fonts.google.com/specimen/Roboto).

>important For complex scenarios we strongly recommend setting the **FontSize** properties only **before the application is initialized**. 

__Example 1__ shows the default font sizes and families.

#### __[C#] Example 2: Default FontSize__
{{region cs-styling-appearance-crystal-theme-1}}
	CrystalPalette.Palette.FontSizeXS = 11;
	CrystalPalette.Palette.FontSizeS = 12;
	CrystalPalette.Palette.FontSize = 13;
	CrystalPalette.Palette.FontSizeL = 14;
	CrystalPalette.Palette.FontSizeXL = 15;
{{endregion}}

__Example 2__ shows how to change the default FontFamily from "Roboto" to "Calibri Italic" and the FontSize from 13 to 14.

#### __[C#] Example 3: Changing the theme's FontSize and FontFamily__
{{region cs-styling-appearance-crystal-theme-2}}
	private void OnButtonChangeFontSizeClick(object sender, RoutedEventArgs e)
	{
		CrystalPalette.Palette.FontSize = 16;
		CrystalPalette.Palette.FontFamily = new FontFamily("Calibri Italic");
	}
{{endregion}}

#### __Figure 2: Setting FontSize and FontFamily__
![RadCalendar with modified FontSize and FontFamiliy](images/crystal-theme-calendar-font-change.png)	

## Glyphs

The **Crystal Theme** also uses the **Telerik Web UI** [font glyphs](({%slug common-styling-appearance-glyphs-overview%})) by default. The **RadGlyph** provides a lightweight, flexble and design-time-friendly implementation of our glyph font.  

> You can read more about the RadGlyph in the [RadGlyph Overview article]({%slug common-styling-appearance-radglyph%}) and about the range of the font glyphs in the [Font Glyphs Overview article]({%slug common-styling-appearance-glyphs-reference-sheet%}).
 
## Set Corner Radius

The **Crystal Theme** exposes an easy way to modify the corner radius of many elements in your application. You can directly use the corner radius property of the palette. By default the **CornerRadius** value is **5**.
	
**Example 3** shows how to change the default corner radius from 5 to 0. Note that you don't have to explicitly change all 5 corner radius properties as they will inherit the value from the main **CornerRadius** property.

#### __[C#] Example 4: Changing the default corner radius__
{{region cs-styling-appearance-crystal-theme-3}}
	CrystalPalette.Palette.CornerRadius = new CornerRadius(0); 	
{{endregion}}

#### __Figure 3: Apperance of a RadButton control after changing the default corner radius__
![RadButton with a CornerRadius of 0](images/crystal-theme-button-cornerradius.png)	

## Material Assist

The **MaterialAssist** static class comes from the Material theme and it is reused in the Crystal theme. It exposes a set of attached properties and can be used to directly modify the appearance of a specific basic control without the need to alter its control template. Below is a list of the dependency properties which can be set directly in XAML:

* **MouseOverBrush:** Sets the value of the background Brush applied when the mouse is over the control. 
* **PressedBrush:** Sets the value of the background Brush applied when the control is pressed.
* **CheckedBrush:** Sets the value of the background Brush applied when the element is in Checked state. It will have effect when used on elements that expose a "checked" state(ToggleButton, RadListBoxItem, etc.)
* **FocusBrush:** Sets the value of the background Brush applied when the element is focused.
* **ShadowDepth:** Enum property that indicates the depth of the shadow effect over the control. There are 5 values that can be selected.
* **IsShadowDisabled:** The property is used to control the visibility of the shadow effect.
* **CornerRadius:** Used to set the corner radius of commonly used basic controls that could need corner radius customizations but don't expose such property by default (e.g. Button, RepeatButton, ListBox, RadComboBox, etc.).

**Example 6** shows a **RadToggleButton** control with modified brushes for its different states through the **MaterialAssist** class:

#### __[XAML] Example 5: Declare the namespace for the Material components__
{{region xaml-styling-appearance-crystal-theme-4}}
	xmlns:mat="clr-namespace:Telerik.Windows.Controls.MaterialControls;assembly=Telerik.Windows.Controls"
{{endregion}}

#### __[XAML] Example 6: Set RadToggleButton's visual appearance through the MaterialAssist class__
{{region xaml-styling-appearance-crystal-theme-5}}
	  <telerik:RadToggleButton Content="RadButton" 
                               Margin="10"
                               mat:MaterialAssist.MouseOverBrush="{telerik:CrystalResource ResourceKey=AccentMouseOverBrush}"
                               mat:MaterialAssist.PressedBrush="{telerik:CrystalResource ResourceKey=AccentPressedBrush}"
							   mat:MaterialAssist.CheckedBrush="{telerik:CrystalResource ResourceKey=ValidationBrush}"/>
{{endregion}}

#### **Figure 4: Appearance of the RadToggleButton in the different states**  
![RadToggleButton States](images/crystal-theme-togglebutton-states.png)

## Window Buttons Alignment

In accordance to the MacOS design, by default the minimize, maximize, restore and close buttons of the RadWindow controls are displayed on the left of the window's title in the Crystal theme. This can be easily modified via the **WindowButtonsAlignment** property of the Crystal palette.

#### __[C#] Example 7: Changing the WindowButtonsAlignment__
{{region cs-styling-appearance-crystal-theme-6}}
	CrystalPalette.Palette.WindowButtonsAlignment = ButtonsAlignment.Right; 	
{{endregion}}

#### **Figure 5: Appearance of the RadWindow with the different alignments**  
![RadToggleButton States](images/crystal-theme-window-buttons-alignment.png)

## See Also  
 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
 * [Style Manager]({%slug common-styling-apperance-setting-theme-wpf%})
 * [Glyphs Overview]({%slug common-styling-appearance-glyphs-overview%})
 * [Office2016 Theme]({%slug common-styling-appearance-office2016-theme%})
 * [Material Theme]({%slug common-styling-appearance-material-theme%})
 * [Fluent Theme]({%slug common-styling-appearance-fluent-theme%})
