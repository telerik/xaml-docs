---
title: Fluent Theme
page_title: Fluent Theme
description: Fluent Theme
slug: common-styling-appearance-fluent-theme
tags: fluent,theme,glyphs,fontsize,fontfamily,shadow
published: True
position: 6
---

# Fluent Theme

With the **R1 2018** release of the **UI for WPF** suite we have introduced the brand new **Fluent Theme**. It comes with built-in elements that provide interaction feedback, with easy-to-customize colors and Fluent design with beautiful and smooth transitions between the states. 

The following topic explains the specifics of the theme's palette and features.

* [Default theme colors](#default-theme-colors)
* [Theme Variation Changing](#theme-variation-changing)
* [Changing Fonts](#font-family-and-font-size)
* [Glyphs](#glyphs)
* [Changing Corner Radius](#set-corner-radius)
* [Material Assist](#material-assist)
* [Shadow](#shadow)
* [Fluent Control](#fluent-control)

## Default Theme Colors

The **Fluent Theme** has two color variations, that are designed to be easily modified via the exposed colors in the theme palette.

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

#### __Figure 1: Theme colors represented in RadOutlookBar__
![fluent theme colors](images/fluent-theme-outlook.PNG)	

## Theme Variation Changing

You can switch between the color palettes by calling the LoadPreset method as shown below:

#### **[C#] Example 1: Changing the color variantion of the theme**
{{region styling-appearance-fluent-theme-0}}	
	//default color variation
	FluentPalette.LoadPreset(FluentPalette.ColorVariation.Dark);  

	//light color variation
	FluentPalette.LoadPreset(FluentPalette.ColorVariation.Light);
{{endregion}}

## Font Family and Font Size

When using the **Fluent theme** you can dynamically change the **FontSize** and **FontFamily** properties of all components in the application the same way as you do in **Windows8**, **Windows8Touch**, **Office2013**, **VisualStudio2013**, **Office2016**, **Green** and **Material** themes.

The **FontSize** and **FontFamily** properties are public so you can easily modify the theme resources at a single point. The most commonly used font size in the theme is with value 12 and can be modified through the **MaterialPalette.Palette.FontSize** property. 

The default font used in the theme is [Segoe UI](https://www.microsoft.com/typography/fonts/family.aspx?FID=331).

>important For complex scenarios we strongly recommend setting the **FontSize** property only **before the application is initialized**. 

__Example 1__ shows the default font sizes and families.

#### __[C#] Example 2: Default FontSize and FontFamily__
{{region styling-appearance-fluent-theme-1}}
	FluentPalette.Palette.FontSizeS = 10;
	FluentPalette.Palette.FontSize = 12;
	FluentPalette.Palette.FontSizeL = 13;
	FluentPalette.Palette.FontFamily = new FontFamily("Segoe UI");
{{endregion}}

The __Examples 2 and 3__ show how to change the default FontFamily from "Segoe UI" to "Calibri" and the FontSize from 12 to 11 on a click of a button.

#### __[XAML] Example 3: Example view definition__
{{region styling-appearance-fluent-theme-2}}
	<telerik:RadCalendar HorizontalAlignment="Center" />
	<telerik:RadButton Content="Change Font" Click="OnButtonChangeFontSizeClick" 
		     HorizontalAlignment="Center" VerticalAlignment="Center"/>
{{endregion}}
	
#### __[C#] Example 4: Changing the theme's FontSize and FontFamily__
{{region styling-appearance-fluent-theme-3}}
	private void OnButtonChangeFontSizeClick(object sender, RoutedEventArgs e)
	{
		FluentPalette.Palette.FontSize = 11;
		FluentPalette.Palette.FontFamily = new FontFamily("Calibri");
	}
{{endregion}}

#### __Figure 2: Setting FontSize and FontFamily__
![font changed](images/fluent-theme-calendar-font-change.png)	

## Glyphs

The **Fluent Theme** uses and supports adding icons and icon-like images which was introduced with the **Office2016** theme. Instead of images or paths we are using a font of glyphs by default. The **TelerikWebUI** font provides over 400 scalable vector glyphs that are available for use to our clients.

> You can read more about the usage and range of the new glyphs in the [Font Glyphs Overview article]({%slug common-styling-appearance-glyphs-overview%}).

**Example 4** show how to merge the font resources.

#### __[XAML] Example 5: Adding the ResourceDictionary with the glyphs__
{{region styling-appearance-fluent-theme-4}}
	<ResourceDictionary Source="/Telerik.Windows.Controls;component/Themes/FontResources.xaml"/> 
{{endregion}}

**Example 10** in the [Fluent Control](#fluent-control) section shows the usage of a glyph in a TextBlock.
 
## Set Corner Radius

The **Fluent Theme** exposes an easy way to modify the corner radius of many elements in your application. You can directly use the corner radius property of the palette. By default the **CornerRadius** value is **0** as shown in **Example 5**. 

#### __[C#] Example 6: Default corner radius values__
{{region styling-appearance-fluent-theme-5}}
	FluentPalette.Palette.CornerRadius = new CornerRadius(0);
	FluentPalette.Palette.CornerRadiusTop = new CornerRadius(0);
	FluentPalette.Palette.CornerRadiusBottom = new CornerRadius(0);
	FluentPalette.Palette.CornerRadiusLeft = new CornerRadius(0);
	FluentPalette.Palette.CornerRadiusRight = new CornerRadius(0);
{{endregion}}
	
**Example 6** shows how to change the default corner radius from 0 to 10. Note that you don't have to explicitly change all 5 corner radius properties as they will inherit the value from the **CornerRadius** main property.

#### __[C#] Example 7: Changing the default corner radius__
{{region styling-appearance-fluent-theme-6}}
	FluentPalette.Palette.CornerRadius = new CornerRadius(10); 	
{{endregion}}

#### __Figure 3: Apperance of a RadButton control after changing the default corner radius__
![corner radius](images/fluent-theme-button-cornerradius.png)	

## Material Assist

The **MaterialAssist** static class comes from the Material theme and it is reused in the Fluent theme. It exposes a set of attached properties and can be used to directly modify the appearance of a specific basic control without the need to alter its control template. Below is a list of the dependency properties which can be set directly in XAML:

* **CheckedBrush:** Sets the value of the background Brush applied when the element is in Checked state. It will have effect when used on elements that expose a "checked" state(ToggleButton, RadListBoxItem, etc.)  
* **FocusBrush:** Sets the value of the background Brush applied when the element is focused.
* **IsShadowDisabled:** The property is used to control the visibility of the shadow effect.
* **MouseOverBrush:** Sets the value of the background Brush applied when the mouse is over the control. 
* **PressedBrush:** Sets the value of the background Brush applied when the control is pressed.
* **ShadowDepth:** Enum property that indicates the depth of the shadow effect over the control. There are 5 values that can be selected.
* **CornerRadius:** Used to set the corner radius of commonly used basic controls that could need corner radius customizations but don't expose such property by default (e.g. Button, RepeatButton, ListBox, RadComboBox, etc.). **Example 11** shows how to set corner radius to a default Button element.

**Example 8** shows a **RadToggleButton** control with modified brushes for its different states through the **MaterialAssist** class:

#### __[XAML] Example 8: Declare the namespace for the Material components__
{{region styling-appearance-fluent-theme-7}}
	xmlns:mat="clr-namespace:Telerik.Windows.Controls.MaterialControls;assembly=Telerik.Windows.Controls"
{{endregion}}

#### __[XAML] Example 9: Set RadToggleButton's visual appearance through the MaterialAssist class__
{{region styling-appearance-fluent-theme-8}}
	  <telerik:RadToggleButton Content="RadButton" 
                               Margin="10"
                               mat:MaterialAssist.MouseOverBrush="{telerik:FluentResource ResourceKey=AccentMouseOverBrush}"
                               mat:MaterialAssist.PressedBrush="{telerik:FluentResource ResourceKey=AccentPressedBrush}"
							   mat:MaterialAssist.CheckedBrush="{telerik:FluentResource ResourceKey=ValidationBrush}"/>
{{endregion}}

#### **Figure 4: Appearance of the RadToggleButton in the different states**  
![pressed brush](images/fluent-theme-togglebutton-pressed-brush.png)![mouseover brush](images/fluent-theme-togglebutton-mouseover-brush.png)![checked brush](images/fluent-theme-togglebutton-checked-brush.png) 

## Shadow 

The **Shadow** is an element that is used to add a shadow effect around another control or element. 

>important The Shadow element **is not intended to directly host other elements** as the WPF drop shadow effect affects any nested texts and results in blurry characters. 

If you would like to use it separately in your application, you should work with its Width/Height properties so that it appears around the desired element as shown in **Example 9**.

#### **[XAML] Example 10: Using a Shadow component separately**
{{region styling-appearance-fluent-theme-9}}
	 <Grid>
		<mat:Shadow Background="White" Width="150" Height="30" ShadowDepth="Depth5"/>
		<TextBlock Text="Some Text"
				   HorizontalAlignment="Center"
				   VerticalAlignment="Center"/>
     </Grid>
{{endregion}}

>important The Shadow element should have a background set for the effect to appear.

The element exposes a **ShadowDepth** enum property which takes one of the following values: **Depth5**, **Depth4**, **Depth3**, **Depth2**, **Depth1**, **Depth0**. The larger the depth number is the stronger the shadow effect will be. 

**Figure 5** shows the effect that the shadow element adds around a **TextBlock** element. 

#### **Figure 5: Shadow effect applied over a TextBlock**  
![shadow](images/materialtheme-shadow-control.png)

## Fluent Control

The **FluentControl** is an element designed for the Fluent theme and used to display the interaction of the users with some of the controls. It is mainly used within the template of controls that suggest user actions such as the RadButton, RadToggleButton, etc. It adds a "ripple" and "Glow" effects and exposes several properties which you can use to modify the ripple/glow functionality and its appearance:

* **IsRippleEnabled:** Indicates whether the ripple effect is enabled.
* **IsRippleCentered:** Controls the initial position from where the ripple effect starts. Setting the property to true will cause the effect to always start from the center of the control. Otherwise, the cursor position is respected. 
* **IsSmartClipped:** Sets whether the ripple should be within the boundaries of the corner radius.
* **RippleBrush:** Sets the brush used for the ripple effect.
* **RippleOpacity:** Sets the opacity of the ripple effect.
* **BorderGradient:** Sets the border gradient brush.
* **EffectMode:** Sets the opacity of the ripple effect mode of the control - Ripple or Glow. The default effect is Ripple.

#### **Figure 6: Ripple effect оn RadDropDownButton**  
![ripple effect](images/fluent-theme-dropdownbutton-rippleanimation.gif)

The following code snippets show how you can integrate the FluentControl with a RadButton  

#### **[XAML] Example 11: Declaration of the Button element with a glyph as text**
{{region styling-appearance-fluent-theme-10}}
		 <Button VerticalAlignment="Center" HorizontalAlignment="Center" Style="{StaticResource RoundRadButtonStyle}">
                <TextBlock FontFamily="{StaticResource TelerikWebUI}"
                           FontSize="32" FontWeight="Normal" FontStyle="Normal"
                           Text="{StaticResource GlyphEdit}" VerticalAlignment="Center" HorizontalAlignment="Center" />
         </Button>
{{endregion}}
  					
#### **[XAML] Example 12: Button's Style declaration**
{{region styling-appearance-fluent-theme-11}}
	 <Style x:Key="RoundRadButtonStyle" TargetType="Button">
            <Setter Property="Background" Value="#FF2196F3" />
            <Setter Property="Foreground" Value="{telerik:FluentResource ResourceKey=MarkerInvertedBrush}" />
            <Setter Property="mat:MaterialAssist.MouseOverBrush" Value="#FF1976D2" />
            <Setter Property="mat:MaterialAssist.PressedBrush" Value="#FF1565C0" />
            <Setter Property="mat:MaterialAssist.CornerRadius" Value="30" />
            <Setter Property="Width" Value="60" />
            <Setter Property="Height" Value="60" />
            <Setter Property="Padding" Value="14" />
            <Setter Property="Template">
                <Setter.Value>
                    <ControlTemplate TargetType="Button">
                        <Grid>
                            <mat:Shadow Background="{TemplateBinding Background}"
                                        ShadowDepth="Depth4"
                                        CornerRadius="{TemplateBinding mat:MaterialAssist.CornerRadius}" />
                            <mat:FluentControl IsRippleCentered="True"
                                                 RippleBrush="#FF82B1FF"
                                                 RippleOpacity="0.8"
                                                 IsSmartClipped="True"
                                                 CornerRadius="{TemplateBinding mat:MaterialAssist.CornerRadius}">  
                                <ContentPresenter Focusable="False"
											      TextBlock.Foreground="{TemplateBinding Foreground}"
											      Margin="{TemplateBinding Padding}"
                                                  Content="{TemplateBinding Content}" />
                            </mat:FluentControl>
                        </Grid>
                    </ControlTemplate>
                </Setter.Value>
            </Setter>
      </Style>
{{endregion}}

#### **Figure 7: FluentControl used within a custom template applied to a Button**  
![custom button](images/custombtngif.gif)

> Note that the **MaterialAssist.MouseOverBrush** and **MaterialAssist.PressedBrush** properties, which are responsible for the mouse over and pressed animations, are automatically bound to the templated parent.

## See Also  
 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
 * [Style Manager]({%slug common-styling-apperance-setting-theme-wpf%})
 * [Glyphs Overview]({%slug common-styling-appearance-glyphs-overview%})
 * [Office2016 Theme]({%slug common-styling-appearance-office2016-theme%})
 * [Material Theme]({%slug common-styling-appearance-material-theme%})
