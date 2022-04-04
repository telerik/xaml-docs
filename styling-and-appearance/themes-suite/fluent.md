---
title: Fluent Theme
page_title: Fluent Theme
description: Add transparency, acrylic effects, shadows, animations and more to modernize your app with the latest UX and UI trends by using the Fluent theme.
slug: common-styling-appearance-fluent-theme
tags: fluent,theme,acrylic,glyphs,fontsize,fontfamily,shadow
published: True
position: 9
---

<style>
.theme-palette-color {
	width:20px;
	height:20px;
	margin: auto;
	border: 1px solid black;
}

.fluenttheme-accentcolor-light {
	background: #0099BC;
}
.fluenttheme-accentmouseovercolor-light {
	background: #00BFE8;
}
.fluenttheme-accentpressedcolor-light {
	background: #0087A4
}
.fluenttheme-accentfocusedcolor-light {
	background: #15D7FF;
}
.fluenttheme-basiccolor-light {
	background: #CCCCCC;
}
.fluenttheme-basiccolor-dark {
	background: #FFFFFF;
}
.fluenttheme-basicsolidcolor-light {
	background: #CCCCCC;
}
.fluenttheme-basicsolidcolor-dark {
	background: #4C4C4C;
}
.fluenttheme-iconcolor-light {
	background: #333333;
}
.fluenttheme-iconcolor-dark {
	background: #FFFFFF;
}
.fluenttheme-maincolor-light {
	background: #E6E6E6;
}
.fluenttheme-maincolor-dark {
	background: #FFFFFF;
}
.fluenttheme-markercolor-light {
	background: #000000;
}
.fluenttheme-markercolor-dark {
	background: #FFFFFF;
}
.fluenttheme-markermouseovercolor-light {
	background: #000000;
}
.fluenttheme-validationcolor-light {
	background: #E81123;
}
.fluenttheme-complementarycolor-light {
	background: #CCCCCC;
}
.fluenttheme-complementarycolor-dark {
	background: #333333;
}
.fluenttheme-mouseovercolor-light {
	background: #CCCCCC;
}
.fluenttheme-mouseovercolor-dark {
	background: #FFFFFF;
}
.fluenttheme-pressedcolor-light {
	background: #B3B3B3;
}
.fluenttheme-pressedcolor-dark {
	background: #FFFFFF;
}
.fluenttheme-alternativecolor-light {
	background: #F2F2F2;
}
.fluenttheme-alternativecolor-dark {
	background: #2B2B2B;
}
.fluenttheme-markerinvertedcolor-light {
	background: #FFFFFF;
}
.fluenttheme-primarycolor-light {
	background: #FFFFFF;
}
.fluenttheme-primarybackgroundcolor-light {
	background: #FFFFFF;
}
.fluenttheme-primarybackgroundcolor-dark {
	background: #000000;
}
.fluenttheme-primarymouseovercolor-light {
	background: #FFFFFF;
}
.fluenttheme-readonlybackgroundcolor-light {
	background: #FFFFFF;
}
.fluenttheme-readonlybordercolor-light {
	background: #CDCDCD;
}
.fluenttheme-readonlybordercolor-dark {
	background: #4C4C4C;
}

article table
{
    table-layout: auto;
}
</style>

# Fluent Theme

With the __R1 2018__ release of the __UI for WPF__ suite we have introduced the brand new `Fluent theme`. It comes with built-in elements that provide interaction feedback, with easy-to-customize colors and beautiful interpretation of the Fluent design system.

## Default Theme Colors

The `Fluent Theme` has two color variations, that are designed to be easily modified via the exposed colors in the theme palette.

The default values of the brushes in the theme are listed below:

| Brush name | Light || Dark ||
| ---------- | ----------- | --- | --- | --- |
| AccentColor | #FF0099BC | <div class="theme-palette-color fluenttheme-accentcolor-light"></div> |#FF0099BC | <div class="theme-palette-color fluenttheme-accentcolor-light"></div>|
| AccentMouseOverColor | #FF00BFE8 | <div class="theme-palette-color fluenttheme-accentmouseovercolor-light"></div> |#FF00BFE8 | <div class="theme-palette-color fluenttheme-accentmouseovercolor-light"></div>|
| AccentPressedColor | #FF0087A4 | <div class="theme-palette-color fluenttheme-accentpressedcolor-light"></div> |#FF0087A4 | <div class="theme-palette-color fluenttheme-accentpressedcolor-light"></div>|
| AccentFocusedColor | #FF15D7FF | <div class="theme-palette-color fluenttheme-accentfocusedcolor-light"></div> |#FF15D7FF | <div class="theme-palette-color fluenttheme-accentfocusedcolor-light"></div>|
| BasicColor | #33000000 | <div class="theme-palette-color fluenttheme-basiccolor-light"></div> |#4CFFFFFF | <div class="theme-palette-color fluenttheme-basiccolor-dark"></div>|
| BasicSolidColor | #FFCCCCCC | <div class="theme-palette-color fluenttheme-basicsolidcolor-light"></div> |#FF4C4C4C | <div class="theme-palette-color fluenttheme-basicsolidcolor-dark"></div>|
| IconColor | #CC000000 | <div class="theme-palette-color fluenttheme-iconcolor-light"></div> |#CCFFFFFF | <div class="theme-palette-color fluenttheme-iconcolor-dark"></div>|
| MainColor | #19000000 | <div class="theme-palette-color fluenttheme-maincolor-light"></div> |#33FFFFFF | <div class="theme-palette-color fluenttheme-maincolor-dark"></div>|
| MarkerColor | #FF000000 | <div class="theme-palette-color fluenttheme-markercolor-light"></div> |#FFFFFFFF | <div class="theme-palette-color fluenttheme-markercolor-dark"></div>|
| MarkerMouseOverColor | #FF000000 | <div class="theme-palette-color fluenttheme-markermouseovercolor-light"></div> |#FF000000 | <div class="theme-palette-color fluenttheme-markermouseovercolor-light"></div>|
| ValidationColor | #FFE81123 | <div class="theme-palette-color fluenttheme-validationcolor-light"></div> |#FFE81123 | <div class="theme-palette-color fluenttheme-validationcolor-light"></div>|
| ComplementaryColor | #FFCCCCCC | <div class="theme-palette-color fluenttheme-complementarycolor-light"></div> |#FF333333 | <div class="theme-palette-color fluenttheme-complementarycolor-dark"></div>|
| MouseOverColor | #33000000 | <div class="theme-palette-color fluenttheme-mouseovercolor-light"></div> |#4CFFFFFF | <div class="theme-palette-color fluenttheme-mouseovercolor-dark"></div>|
| PressedColor | #4C000000 | <div class="theme-palette-color fluenttheme-pressedcolor-light"></div> |#26FFFFFF | <div class="theme-palette-color fluenttheme-pressedcolor-dark"></div>|
| AlternativeColor | #FFF2F2F2 | <div class="theme-palette-color fluenttheme-alternativecolor-light"></div> |#FF2B2B2B | <div class="theme-palette-color fluenttheme-alternativecolor-dark"></div>|
| MarkerInvertedColor | #FFFFFFFF | <div class="theme-palette-color fluenttheme-markerinvertedcolor-light"></div> |#FFFFFFFF | <div class="theme-palette-color fluenttheme-markerinvertedcolor-light"></div>|
| PrimaryColor | #66FFFFFF | <div class="theme-palette-color fluenttheme-primarycolor-light"></div> |#66FFFFFF | <div class="theme-palette-color fluenttheme-primarycolor-light"></div>|
| PrimaryBackgroundColor | #FFFFFFFF | <div class="theme-palette-color fluenttheme-primarybackgroundcolor-light"></div> |#FF000000 | <div class="theme-palette-color fluenttheme-primarybackgroundcolor-dark"></div>|
| PrimaryMouseOverColor | #FFFFFFFF | <div class="theme-palette-color fluenttheme-primarymouseovercolor-light"></div> |#FFFFFFFF | <div class="theme-palette-color fluenttheme-primarymouseovercolor-light"></div>|
| ReadOnlyBackgroundColor | #00FFFFFF | <div class="theme-palette-color fluenttheme-readonlybackgroundcolor-light"></div> |#00FFFFFF | <div class="theme-palette-color fluenttheme-readonlybackgroundcolor-light"></div>|
| ReadOnlyBorderColor | #FFCDCDCD | <div class="theme-palette-color fluenttheme-readonlybordercolor-light"></div> |#FF4C4C4C | <div class="theme-palette-color fluenttheme-readonlybordercolor-dark"></div>|

__Theme colors represented in RadOutlookBar__

![Fluent theme colors represented in RadOutlookBar](images/fluent-theme-outlook.PNG)	

## FluentPalette Brushes

### Transparent Brushes

* `PrimaryBrush`&mdash;Used in backgrounds of inputs.
* `MouseOver`&mdash;Used for an interaction of buttons.
* `PressedBrush`&mdash;Used for interaction of button-like controls.
* `BasicBrush`&mdash;Used in the majority of the normal state borders.
* `BasicSolidBrush`&mdash;Used for borders in the cases when several would overlap (in complex grid-structured controls) and is calculated automatically when the `BasicBrush` is changed by overlaying it on top of the `PrimaryBackgroundBrush`.
* `MainBrush`&mdash;Used for backgrounds of buttons, headers and footers.
* `IconBrush`&mdash;Used for glyph and path icons, which should be 80% of black/white and for the light/dark variation respectfully.

### Opaque Brushes

* `PrimaryBackgroundBrush`&mdash;Used when backgrounds need to be solid white/black
* `AlternativeBrush`&mdash;Used for backgrounds of popups, windows, listboxes etc and is slightly darker/lighter.
* `ComplementaryBrush`&mdash;Slightly darker/lighter than the alternative in case of collisions.
* `AccentBrush`&mdash;Used for coloring the primary accent elements.
* `AccentMouseOverBrush`&mdash;Variation of the `AccentBrush` that is used for the hovered states of primary accent elements.
* `AccentPressedBrush`&mdash;Variation of the `AccentBrush` that is used for the pressed states of primary accent elements.
* `AccentFocusedBrush`&mdash;Variation of the `AccentBrush` that is used for the focused states of primary accent elements.
* `MarkerBrush`&mdash;Used for the majority of foregrounds which are black/white.
* `MarkerInvertedBrush`&mdash;Used for interactions states - white in both variations.
* `MarkerMouseOverBrush`&mdash;Used for mouse over and focused states of inputs which is black/black.
* `ValidationBrush`&mdash;A bright red brush that is used for the invalid elements, and validation tooltips.
* `DisabledOpacity`&mdash;Used for texts when they are disabled. Backgrounds are usually `AlternativeBrush` when disabled.
* `InputOpacity`&mdash;Used for texts in input controls (`TextBox`, `RadMaskedInput`, etc.) when they are in normal state.
* `ReadOnlyOpacity`&mdash;Used for texts in inputs when they are in a read-only state.
* `FocusThickness`&mdash;The default value is __2, 2, 2, 2__. It is used for the thickness of the focus border as well as the thickness of the read only borders of inputs where applicable.
* `FontFamily`&mdash;The global font family used for the theme. By default it is `Segoe UI`.

## Theme Variation Changing

You can switch between the color palettes by calling the LoadPreset method as shown below:

#### __[C#] Changing the color variantion of the theme__
{{region styling-appearance-fluent-theme-0}}	
	//default color variation
	FluentPalette.LoadPreset(FluentPalette.ColorVariation.Light);  

	//dark color variation
	FluentPalette.LoadPreset(FluentPalette.ColorVariation.Dark);
{{endregion}}

>The `Dark` variation of the theme is designed with a dark background in mind and it is recommended to use such a background in your application when working with it.

## Font Family and Font Size

When using the `Fluent theme` you can dynamically change the `FontSize` and `FontFamily` properties of all components in the application the same way as you do in Windows8, Windows8Touch, Office2013, VisualStudio2013, Office2016, Green and Material themes.

The FontSize and FontFamily properties are public so you can easily modify the theme resources at a single point. The most commonly used font size in the theme is with value 12 and can be modified through the `FluentPalette.Palette.FontSize` property in the same manner as in the other themes that support a theme palette. 

The default font used in the theme is [Segoe UI](https://www.microsoft.com/typography/fonts/family.aspx?FID=331).

>important For complex scenarios we strongly recommend setting the `FontSize` properties only __before the application is initialized__. 

#### __[C#] Default FontSize and FontFamily__
{{region styling-appearance-fluent-theme-1}}
	FluentPalette.Palette.FontSizeS = 10;
	FluentPalette.Palette.FontSize = 12;
	FluentPalette.Palette.FontSizeL = 13;
	FluentPalette.Palette.FontSizeXL = 14;
	FluentPalette.Palette.FontFamily = new FontFamily("Segoe UI");
{{endregion}}

#### __[C#] Changing the theme's FontSize and FontFamily__
{{region styling-appearance-fluent-theme-3}}
	private void OnButtonChangeFontSizeClick(object sender, RoutedEventArgs e)
	{
		FluentPalette.Palette.FontSize = 13;
		FluentPalette.Palette.FontFamily = new FontFamily("Calibri Italic");
	}
{{endregion}}

__Setting FontSize and FontFamily__

![RadCalendar with default FontSize and FontFamiliy](images/fluent-theme-calendar-font-change-1.png)![RadCalendar with modified FontSize and FontFamiliy](images/fluent-theme-calendar-font-change-2.png)	

## Glyphs

The `Fluent Theme` also uses the `Telerik Web UI` [font glyphs](({%slug common-styling-appearance-glyphs-overview%})) by default. With this theme we are introducting the `RadGlyph` which provides a lightweight, flexble and design-time-friendly implementation of out glyph font.  

> You can read more about the RadGlyph in the [RadGlyph Overview article]({%slug common-styling-appearance-radglyph%}) and about the range of the font glyphs in the [Font Glyphs Overview article]({%slug common-styling-appearance-glyphs-reference-sheet%}).
 
## Set Corner Radius

The Fluent Theme exposes an easy way to modify the corner radius of many elements in your application. You can directly use the corner radius property of the palette. By default the `CornerRadius` value is __0__.

#### __[C#] Changing the default corner radius__
{{region styling-appearance-fluent-theme-6}}
	FluentPalette.Palette.CornerRadius = new CornerRadius(10); 	
{{endregion}}

__Apperance of a RadButton control after changing the default corner radius__

![RadButton with a CornerRadius of 10](images/fluent-theme-button-cornerradius.png)	

## Visual Effects Helpers

### Acrylic effect

With the Fluent Theme we are introducting a `ThemeEffectsHelper` static class that is responsible for the iconic transparent and blurred effect that is associated with the design system. The `ThemeEffectsHelper.IsAcrylic` attached property can be applied to a `Window`, `RadWindow`, `Popup` and window-derivate controls to achieve this translucent effect. It is __supported currently only under Windows 10__. In any other operating system it would simply result in a transparent window/popup.

>important For the acrylic effect to properly apply, the control that it is used on needs to be __transparent__ (i.e., the Window and Popup controls need to have their `AllowsTransparency` property set to True).

>important The acrylic effect is __disabled__ for windows which have their `CornerRadius` property set.

> `ThemeEffectsHelper.IsAcrylicEnabled` is used to turn off globally the setting of the effect and set opaque backgrounds in our controls. You can detect the version of the OS that the application is currently running and disable the effect for versions prior to `Windows 10`. For more information about achieving that you can review the following MSDN articles: 
[Operating System Version](https://msdn.microsoft.com/library/windows/desktop/ms724832.aspx) and [Targeting your application for Windows](https://msdn.microsoft.com/en-us/library/windows/desktop/dn481241.aspx) (if the application is not targeting Windows 10, the version number returned would be always 6.2)

>important Applying the `ThemeEffectsHelper.IsAcrylic` to a control could result in unexpected visual issues.

### Material Assist

The `MaterialAssist` static class comes from the Material theme and it is reused in the Fluent theme. It exposes a set of attached properties and can be used to directly modify the appearance of a specific basic control without the need to alter its control template. Below is a list of the dependency properties which can be set directly in XAML:

* `MouseOverBrush`&mdash;Sets the value of the background Brush applied when the mouse is over the control. 
* `PressedBrush`&mdash;Sets the value of the background Brush applied when the control is pressed.
* `CheckedBrush`&mdash;Sets the value of the background Brush applied when the element is in Checked state. It will have effect when used on elements that expose a "checked" state(ToggleButton, RadListBoxItem, etc.)
* `FocusBrush`&mdash;Sets the value of the background Brush applied when the element is focused.
* `ShadowDepth`&mdash;Enum property that indicates the depth of the shadow effect over the control. There are 5 values that can be selected.
* `IsShadowDisabled`&mdash;The property is used to control the visibility of the shadow effect.
* `CornerRadius`&mdash;Used to set the corner radius of commonly used basic controls that could need corner radius customizations but don't expose such property by default (e.g. Button, RepeatButton, ListBox, RadComboBox, etc.).

#### __[XAML] Declare the namespace for the Material components__
{{region styling-appearance-fluent-theme-7}}
	xmlns:mat="clr-namespace:Telerik.Windows.Controls.MaterialControls;assembly=Telerik.Windows.Controls"
{{endregion}}

#### __[XAML] Set RadToggleButton's visual appearance through the MaterialAssist class__
{{region styling-appearance-fluent-theme-8}}
	  <telerik:RadToggleButton Content="RadButton" 
                               Margin="10"
                               mat:MaterialAssist.MouseOverBrush="{telerik:FluentResource ResourceKey=AccentMouseOverBrush}"
                               mat:MaterialAssist.PressedBrush="{telerik:FluentResource ResourceKey=AccentPressedBrush}"
							   mat:MaterialAssist.CheckedBrush="{telerik:FluentResource ResourceKey=ValidationBrush}"/>
{{endregion}}

__Appearance of the RadToggleButton in the different states__

![RadToggleButton Pressed](images/fluent-theme-togglebutton-pressed-brush.png)![RadToggleButton MouseOver](images/fluent-theme-togglebutton-mouseover-brush.png)![RadToggleButton Checked](images/fluent-theme-togglebutton-checked-brush.png) 

## Fluent Control

The `FluentControl` is an element designed for the Fluent theme and used to display the interaction of the users with some of the controls. It is mainly used within the template of controls that suggest user actions such as the RadButton, RadToggleButton, etc. It adds "Ripple" and "Glow" effects and exposes several properties which you can use to modify the ripple/glow functionality and its appearance:

* `IsRippleEnabled`&mdash;Indicates whether the ripple effect is enabled.
* `IsRippleCentered`&mdash;Controls the initial position from where the ripple effect starts. Setting the property to true will cause the effect to always start from the center of the control. Otherwise, the cursor position is respected. 
* `IsSmartClipped`&mdash;Sets whether the ripple should be within the boundaries of the corner radius.
* `RippleBrush`&mdash;Sets the brush used for the ripple effect. The default is a RadialGradientBrush that is moved and transformed runtime.
* `RippleOpacity`&mdash;Sets the opacity of the ripple effect.
* `BorderGradient`&mdash;Sets the border gradient brush. This brush should be RadialGradientBrush and is cloned in code because it is modified runtime and should not be frozen.
* `EffectMode`&mdash;Sets the opacity of the ripple effect mode of the control - Ripple or Glow. The default effect is Ripple.

__Ripple effect оn RadDropDownButton__

![Ripple effect оn RadDropDownButton](images/fluent-light-dropdown.gif)![Ripple effect оn RadDropDownButton with Dark Variation](images/fluent-dark-dropdown.gif)

The following code snippets show how you can integrate the FluentControl with a RadButton  
  					
#### __[XAML] RadButton's Style declaration__
{{region styling-appearance-fluent-theme-09}}
	 <Style TargetType="telerik:RadButton" x:Key="custom">
        <Setter Property="Foreground" Value="{telerik:FluentResource ResourceKey=MarkerBrush}" />
        <Setter Property="Background" Value="{telerik:FluentResource ResourceKey=MainBrush}" />
        <Setter Property="BorderBrush" Value="{telerik:FluentResource ResourceKey=MainBrush}" />
        <Setter Property="BorderThickness" Value="1" />
        <Setter Property="Padding" Value="10 5" />
        <Setter Property="HorizontalAlignment" Value="Center" />
        <Setter Property="HorizontalContentAlignment" Value="Center" />
        <Setter Property="MinWidth" Value="64" />
        <Setter Property="Template">
            <Setter.Value>
                <ControlTemplate TargetType="telerik:RadButton">
                    <Grid>
                        <Border Background="{TemplateBinding Background}" />
                        <mat:FluentControl EffectMode="{TemplateBinding Tag}"
                                           BorderThickness="{TemplateBinding BorderThickness}">
                            <ContentPresenter Focusable="False"
                                              HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}"
                                              TextBlock.Foreground="{TemplateBinding Foreground}"
                                              Margin="{TemplateBinding Padding}"
                                              Content="{TemplateBinding Content}" />
                        </mat:FluentControl>
                    </Grid>
                    <ControlTemplate.Triggers>
                        <Trigger Property="IsMouseOver" Value="True">
                            <Setter Property="Background" Value="{telerik:FluentResource ResourceKey=MouseOverBrush}" />
                        </Trigger>
                        <Trigger Property="IsPressed" Value="True">
                            <Setter Property="Background" Value="{telerik:FluentResource ResourceKey=PressedBrush}" />
                        </Trigger>
                    </ControlTemplate.Triggers>
                </ControlTemplate>
            </Setter.Value>
        </Setter>
    </Style>
{{endregion}} 

#### __[XAML] RadButton's instancing__
{{region styling-appearance-fluent-theme-10}}
     <StackPanel VerticalAlignment="Center">
        <telerik:RadButton VerticalAlignment="Center" Content="Ripple"
                           Tag="{x:Static mat:FluentControlEffectMode.Ripple}"
                           Style="{StaticResource custom}" />
        <telerik:RadButton VerticalAlignment="Center" Content="Glow" Margin="0 10 0 0"
                           Tag="{x:Static mat:FluentControlEffectMode.Glow}"
                           Style="{StaticResource custom}" />
    </StackPanel>
{{endregion}}

__FluentControl used within a custom template applied to a RadButton__

![FluentControl used within a custom template applied to a RadButton](images/fluent-theme-light-effect.gif)![FluentControl used within a custom template applied to a RadButton in Dark variation](images/fluent-theme-dark-effect.gif)

#### __[XAML] Disabling the Ripple effect__
{{region styling-appearance-fluent-theme-11}}
	 <!--If you are using the NoXaml binaries you should base the style on the default one for the theme like so
        <Style TargetType="mat:FluentControl" BasedOn="{StaticResource FluentControlStyle}" > 
        -->
        
	<Style TargetType="mat:FluentControl" >
		<Setter Property="IsRippleEnabled" Value="False" />
	</Style>
{{endregion}}

## Change ScrollBarsMode

By default, the scrollbars in the Fluent theme change their size depending on whether the mouse is currently over them. They are normally smaller in size to take less space and become wider when hovered. You have the option of setting the `ScrollBarsMode` property of the Fluent palette in order to control this behavior. It is of type `ScrollViewerScrollBarsMode` and can be set to one of the following values: 

*  `ScrollViewerScrollBarsMode.Auto`&mdash;The ScrollBars appear as a narrow sliver and expand to normal size on MouseOver. This is the default value.
*  `ScrollViewerScrollBarsMode.Compact`&mdash;The ScrollBars appear always as a narrow sliver.
*  `ScrollViewerScrollBarsMode.Normal`&mdash;The ScrollBars appear always with their normal size.

>important The `ScrollBarMode` property and the `ScrollViewerScrollBarsMode` enumeration of the FluentPalette, introduced with the  __2019.1.121__ version of our dlls, are __obsolete__ and __replaced__ by the `ScrollBarsMode` property of the palette and the `ScrollViewerScrollBarsMode` enum under the `Telerik.Windows.Controls.Theming` namespace.

__ScrollBar behavior in Auto, Compact and Normal ScrollBarsMode__

![ScrollBar in Auto, Compact and Normal ScrollBarsMode](images/fluent-light-scrollbarmode.gif)

#### __[C#] Setting the ScrollBarsMode property of the palette to Compact__
{{region styling-appearance-fluent-theme-12}}	
	FluentPalette.Palette.ScrollBarsMode = Telerik.Windows.Controls.Theming.ScrollViewerScrollBarsMode.Compact;
{{endregion}}

## Changing Opacity 

If you need to change the opacity of the disabled and read-only elements, you can now easily do so by using the `DisabledOpacity` and __ReadOnlyOpacity__ properties of the FluentPalette. The default values are __0.3__ and __0.5__ respectively. 

#### __[C#] Changing the opacity__		
{{region cs-styling-appearance-fluent-theme-13}}
	FluentPalette.Palette.DisabledOpacity = 0.5;
	FluentPalette.Palette.ReadOnlyOpacity = 0.4;
{{endregion}}
	
#### __[VB.NET] Changing the opacity__		
{{region vb-styling-appearance-material-theme-14}}
	FluentPalette.Palette.DisabledOpacity = 0.5
	FluentPalette.Palette.ReadOnlyOpacity = 0.4
{{endregion}}

## Merging Modified Palette Resources With StyleManager Theming Approach

When modifying fonts, colors, or other resources from the `FluentPalette` and `StyleManager` is used as theming mechanism, the theme's `ResourceDictionary` needs to be merged in __App.xaml__ file to apply the changes.

#### __[XAML] Merging the theme's ResourceDictionary in App.xaml__
{{region styling-appearance-material-theme-15}}
	<Application.Resources> 
	    <ResourceDictionary> 
	        <ResourceDictionary.MergedDictionaries> 
	            <telerik:FluentResourceDictionary/> 
	        </ResourceDictionary.MergedDictionaries> 
	    </ResourceDictionary> 
	</Application.Resources>
{{endregion}}

## See Also  
 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
 * [Style Manager]({%slug common-styling-apperance-setting-theme-wpf%})
 * [Glyphs Overview]({%slug common-styling-appearance-glyphs-overview%})
 * [Office2016 Theme]({%slug common-styling-appearance-office2016-theme%})
 * [Material Theme]({%slug common-styling-appearance-material-theme%})
