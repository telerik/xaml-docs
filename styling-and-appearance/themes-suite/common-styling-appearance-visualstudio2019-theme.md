---
title: VisualStudio2019 Theme
page_title: VisualStudio2019 Theme
description: VisualStudio2019 Theme
slug: common-styling-appearance-visualstudio2019-theme
tags: visualstudio2019,theme,glyphs,fontsize,fontfamily,cornerradius
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

.visualstudio2019theme-accentbrush{
	background: #F5CC84;
}
.visualstudio2019theme-accentdarkbrush{
	background: #5F6FA4;
}
.visualstudio2019theme-accentfocusedbrush{
	background: #D2A85E;
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

article table
{
    table-layout: auto;
}
</style>

# VisualStudio2019 Theme

With the **R3 2019** release of the **UI for WPF** suite we have introduced the brand new **VisualStudio2019 theme**. Inspired by the new refreshed Visual Studio 2019 IDE, the VisualStudio2019 theme delivers a lot cleaner and smoother look and feel to your WPF apps. The team at Microsoft are well known for their eagerness to deliver the best possible user experience that we encounter every day and with the VisualStudio2019 theme you will be able to easily bring it to your own apps.

The following topic explains the specifics of the theme's palette and features.

* [Default Theme Colors](#default-theme-colors)
* [VisualStudio2019Palette Properties](#visualstudio2019palette-properties)
* [Changing Fonts](#font-family-and-font-size)
* [Glyphs](#glyphs)
* [Theme Helper](#theme-helper)

## Default Theme Colors

The **VisualStudio2019 Theme** is designed to be easily modified via the exposed colors in the theme palette.
The default values of the brushes in the theme are listed below.

|Brush name|Brush value||
|----------|-----------|---|
|**AccentBrush**|#F5CC84|<div class="theme-palette-color visualstudio2019theme-accentbrush" color:></div>|
|**AccentDarkBrush**|#5F6FA4|<div class="theme-palette-color visualstudio2019theme-accentdarkbrush"></div>|
|**AccentFocusedBrush**|#D2A85E|<div class="theme-palette-color visualstudio2019theme-accentfocusedbrush"></div>|
|**AccentMainBrush**|#AAC0FF|<div class="theme-palette-color visualstudio2019theme-accentmainbrush"></div>|
|**AccentMouseOverBrush**|#C4D5FF|<div class="theme-palette-color visualstudio2019theme-accentmouseoverbrush"></div>|
|**AccentSecondaryDarkBrush**|#40508D|<div class="theme-palette-color visualstudio2019theme-accentsecondarydarkbrush"></div>|
|**AlternativeBrush**|#F7F9FE|<div class="theme-palette-color visualstudio2019theme-alternativebrush"></div>|
|**BasicBrush**|#94A6CA|<div class="theme-palette-color visualstudio2019theme-basicbrush"></div>|
|**ComplementaryBrush**|#D9E0F8|<div class="theme-palette-color visualstudio2019theme-complementarybrush "></div>|
|**HeaderBrush**|#40568D|<div class="theme-palette-color visualstudio2019theme-headerbrush"></div>|
|**IconBrush**|#414141|<div class="theme-palette-color visualstudio2019theme-iconbrush"></div>|
|**MainBrush**|#FCFCFC|<div class="theme-palette-color visualstudio2019theme-mainbrush"></div>|
|**MarkerBrush**|#1E1E1E|<div class="theme-palette-color visualstudio2019theme-markerbrush"></div>|
|**MarkerInvertedBrush**|#FFFFFF|<div class="theme-palette-color visualstudio2019theme-markerinvertedbrush"></div>|
|**MouseOverBrush**|#FFF8DF|<div class="theme-palette-color visualstudio2019theme-mouseoverbrush"></div>|
|**PrimaryBrush**|#F2F5FC|<div class="theme-palette-color visualstudio2019theme-primarybrush"></div>|
|**ReadOnlyBackgroundBrush**|#FCFCFC|<div class="theme-palette-color visualstudio2019theme-readonlybackgroundbrush"></div>|
|**ReadOnlyBorderBrush**|#94A6CA|<div class="theme-palette-color visualstudio2019theme-readonlyborderbrush"></div>|
|**SecondaryBrush**|#FFFFFF|<div class="theme-palette-color visualstudio2019theme-secondarybrush"></div>|
|**SemiBasicBrush**|#C0CAE9|<div class="theme-palette-color visualstudio2019theme-semibasicbrush"></div>|
|**ValidationBrush**|#FF3333|<div class="theme-palette-color visualstudio2019theme-validationbrush"></div>|

#### __Figure 1: Theme colors represented in RadOutlookBar__
![VisualStudio2019 theme colors represented in RadOutlookBar](images/visualstudio2019-theme-outlook.PNG)	

## VisualStudio2019Palette Properties

### Primary Brushes 

* **PrimaryBrush**: Used for background of inputs. 
* **MainBrush**: Used for background of buttons. 
* **AlternativeBrush**: Used for background of popups, windows, list boxes etc. 
* **BasicBrush**: Used in the majority of the normal state borders and for the borders of windows as well. 
* **ComplementaryBrush**: Slightly darker than the alternative in case of collisions.
* **MarkerBrush**: Used for the majority of foregrounds which are black. 
* **MarkerInvertedBrush**: Used for interaction states - mainly where change of the foreground to white is required. 
* **IconBrush**: Used for glyph and path icons. 

### Interaction State Brushes 
* **AccentBrush**: Used for borders of the hovered states of the elements as well as for backgrounds of toggled/checked buttons. 
* **AccentDarkBrush**: Used in backgrounds for the pressed states of the elements. 
* **AccentFocusedBrush**: Variation of the AccentBrush that is used for the focused states of the elements.  
* **AccentMainBrush**: Used for the selected states of selected elements (e.g. menu items, dropdown items, list box items). 
* **AccentMouseOverBrush**: Variation of AccentMainBrush that is used for the hovered states of the above mentioned selected elements. 
* **AccentSecondaryDarkBrush**: Variation of AccentDarkBrush that is used for the foreground of the picker control buttons - DatePicker, DateTimePicker, CalculatorPicker, etc., as well as for the points in the data visualization controls - BulletGraph, Sparkline, etc. 
* **MouseOverBrush**: Used for background of the hovered states of non-accent elements.

### Special Brushes

* **HeaderBrush**: A dark blue brush that is used for the background of the header elements. 
* **ReadOnlyBackgroundBrush**: A white brush that is used for the background of the read only state of the elements.
* **ReadOnlyBorderBrush**: A polo blue brush that is used for the border of the read only state of the elements.
* **ValidationBrush**:  A bright red brush that is used for indicating validation errors - for the underline of the invalid control and as a border for the error tooltip, border for invalid rows and cells. 

## Other Properties

* **DisabledOpacity**: Used for controls when they are in a disabled state. Backgrounds usually use the  **ComplementaryBrush** when disabled.
* **ReadOnlyOpacity**: Used for controls when they are in a **read-only** state.

## Font Family and Font Size

When using the **VisualStudio2019 theme** you can dynamically change the **FontSize** and **FontFamily** properties of all components in the application the same way as you do in **Windows8**, **Windows8Touch**, **Office2013**, **VisualStudio2013**, **Office2016**, **Green**, **Material**, **Fluent** and **Crystal** themes.

The **FontSize** and **FontFamily** properties are public so you can easily modify the theme resources at a single point. The most commonly used font size in the theme is with value **12** and can be modified through the **VisualStudio2019Palette.Palette.FontSize** property in the same manner as in the other themes that support a theme palette. 

The default font used in the theme is **Segoe UI**.

>important For complex scenarios we strongly recommend setting the **FontSize** properties **only before the application is initialized**. 

__Example 1__ shows the default font sizes and families.

#### __[C#] Example 1: Default FontSize__
{{region cs-styling-appearance-visualstudio2019-theme-1}}
	VisualStudio2019Palette.Palette.FontSizeXS = 10;
	VisualStudio2019Palette.Palette.FontSizeS = 11;
	VisualStudio2019Palette.Palette.FontSize = 12;
	VisualStudio2019Palette.Palette.FontSizeL = 13;
	VisualStudio2019Palette.Palette.FontSizeXL = 20;
{{endregion}}

__Example 2__ shows how to change the default FontFamily from "Segoe UI" to "Calibri Italic" and the FontSize from 12 to 16.

#### __[C#] Example 2: Changing the theme's FontSize and FontFamily__
{{region cs-styling-appearance-visualstudio2019-theme-2}}
	private void OnButtonChangeFontSizeClick(object sender, RoutedEventArgs e)
	{
		VisualStudio2019Palette.Palette.FontSize = 16;
		VisualStudio2019Palette.Palette.FontFamily = new FontFamily("Calibri Italic");
	}
{{endregion}}

#### __Figure 2: Setting FontSize and FontFamily__
![RadCalendar with modified FontSize and FontFamiliy](images/visualstudio2019-theme-calendar-font-change.png)	

## Glyphs

The **VisualStudio2019 Theme** also uses the **Telerik Web UI** [font glyphs](({%slug common-styling-appearance-glyphs-overview%})) by default. The **RadGlyph** provides a lightweight, flexible and design-time-friendly implementation of our glyph font.  

> You can read more about the RadGlyph in the [RadGlyph Overview article]({%slug common-styling-appearance-radglyph%}) and about the range of the font glyphs in the [Font Glyphs Overview article]({%slug common-styling-appearance-glyphs-reference-sheet%}).

## Theme Helper

The [ThemeHelper]({%slug styling-appearance-theme-helper%}) class that comes with the **R3 2019** release is used in the VisualStudio2019 theme. It exposes a set of attached properties and can be used to directly modify the appearance of a specific basic control without the need to alter its control template.

**Example 3** shows a **RadToggleButton** control with modified brushes for its different states through the **ThemeHelper** class:

#### __[XAML] Example 3: Set RadToggleButton's visual appearance through the ThemeHelper class__
{{region xaml-styling-appearance-visualstudio2019-theme-3}}
	<telerik:RadToggleButton Content="RadButton" 
							 Margin="10"
							 xmlns:helpers="clr-namespace:Telerik.Windows.Controls.Theming.Helpers;assembly=Telerik.Windows.Controls"
							 helpers:ThemeHelper.MouseOverBrush="{telerik:VisualStudio2019Resource ResourceKey=AccentMouseOverBrush}"
							 helpers:ThemeHelper.PressedBrush="{telerik:VisualStudio2019Resource ResourceKey=ValidationBrush}"
							 helpers:ThemeHelper.CheckedBrush="{telerik:VisualStudio2019Resource ResourceKey=AccentMainBrush}"/>
{{endregion}}

#### **Figure 3: Appearance of the RadToggleButton in the different states**  
![RadToggleButton States](images/visualstudio2019-theme-togglebutton-states.png)

## Changing Opacity 

If you need to change the opacity of the disabled and read-only elements, you can easily do so by using the __DisabledOpacity__ and __ReadOnlyOpacity__ properties of the VisualStudio2019Palette. The default values are **0.3** and **0.6** respectively. 

#### __[C#] Example 4: Changing the opacity__		
{{region cs-styling-appearance-visualstudio2019-theme-4}}
	VisualStudio2019Palette.Palette.DisabledOpacity = 0.5;
	VisualStudio2019Palette.Palette.ReadOnlyOpacity = 0.5;
{{endregion}}
	
#### __[VB.NET] Example 4: Changing the opacity__		
{{region vb-styling-appearance-visualstudio2019-theme-4}}
	VisualStudio2019Palette.Palette.DisabledOpacity = 0.5
	VisualStudio2019Palette.Palette.ReadOnlyOpacity = 0.5
{{endregion}}

## See Also  
 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
 * [Style Manager]({%slug common-styling-apperance-setting-theme-wpf%})
 * [Glyphs Overview]({%slug common-styling-appearance-glyphs-overview%})
 * [VisualStudio2013 Theme]({%slug common-styling-appearance-visualstudio2013-theme%})