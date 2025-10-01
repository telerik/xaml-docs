---
title: Material Theme
page_title: Material Theme
description: The article shows the Telerik WPF Material theme and its features and colors.
slug: common-styling-appearance-material-theme
tags: material,theme,glyphs,fontsize,fontfamily,shadow
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

/* Material Light */
.materialtheme-mainbrush{
	background: #FFFFFF;
}
.materialtheme-primarybrush{
	background: #FAFAFA;
}
.materialtheme-complementarybrush{
	background: #E0E0E0;
}
.materialtheme-alternativebrush{
	background: #F5F5F5;
}
.materialtheme-dividerbrush{
	background: #E1E1E1;
}
.materialtheme-markerbrush{
	background: #000000;
}
.materialtheme-markerinvertedbrush{
	background: #FFFFFF;
}
.materialtheme-iconbrush{
	background: #000000;
}
.materialtheme-validationbrush{
	background: #D50000;
}
.materialtheme-accentnormalbrush{
	background: #FFAB40;
}
.materialtheme-accenthoverbrush{
	background: #FFD180;
}
.materialtheme-accentpressedbrush{
	background: #FF9100;
}
.materialtheme-primarynormalbrush{
	background: #3F51B5;
}
.materialtheme-primaryhoverbrush{
	background: #303F9F;
}
.materialtheme-primarypressedbrush{
	background: #1A237E;
}
.materialtheme-primaryfocusbrush{
	background: #9FA8DA;
}
.materialtheme-ripplebrush{
	background: #FFFFFF;
}
.materialtheme-dividersolidbrush{
	background: #E1E1E1;
}
.materialtheme-readonlybackgroundbrush{
	background: #FFFFFF;
}
.materialtheme-readonlyborderbrush{
	background: #ABABAB;
}
.materialtheme-dialogbackgroundbrush{
	background: #FFFFFF;
}
.materialtheme-selectedunfocusedbrush{
	background: #EEEEEE;
}

/* Material Dark */
.materialtheme-mainbrush-dark{
	background: #303030;
}
.materialtheme-primarybrush-dark{
	background: #424242;
}
.materialtheme-complementarybrush-dark{
	background: #171717;
}
.materialtheme-alternativebrush-dark{
	background: #212121;
}
.materialtheme-dividerbrush-dark{
	background: #474747;
}
.materialtheme-markerbrush-dark{
	background: #F1F1F1;
}
.materialtheme-markerinvertedbrush-dark{
	background: #FFFFFF;
}
.materialtheme-iconbrush-dark{
	background: #FFFFFF;
}
.materialtheme-validationbrush-dark{
	background: #CF6679;
}
.materialtheme-accentnormalbrush-dark{
	background: #00ACC1;
}
.materialtheme-accenthoverbrush-dark{
	background: #26C6DA;
}
.materialtheme-accentpressedbrush-dark{
	background: #0097A7;
}
.materialtheme-primarynormalbrush-dark{
	background: #7986CB;
}
.materialtheme-primaryhoverbrush-dark{
	background: #5C6BC0;
}
.materialtheme-primarypressedbrush-dark{
	background: #3F51B5;
}
.materialtheme-primaryfocusbrush-dark{
	background: #536DFE;
}
.materialtheme-ripplebrush-dark{
	background: #FFFFFF;
}
.materialtheme-dividersolidbrush-dark{
	background: #474747;
}
.materialtheme-readonlybackgroundbrush-dark{
	background: #FFFFFF;
}
.materialtheme-readonlyborderbrush-dark{
	background: #ABABAB;
}
.materialtheme-dialogbackgroundbrush{
	background: #262626;
}
.materialtheme-selectedunfocusedbrush{
	background: #262626;
}

article table
{
    table-layout: auto;
}
</style>

# Material Theme

The `Material Theme` comes with built-in elements that provide interaction feedback, with easy-to-customize colors and Material design drop shadows with beautiful and smooth transitions between the states.

With the __R2 2021__ release of the __UI for WPF__ suite, we have designed and delivered a brand new color variation of the Material theme - the `Dark` one. In addition to it, the theme palette expanded its brushes collection with the `DialogBackgroundBrush` and the `SelectedUnfocusedBrush`, which are available for both color variations and are described below.

Jump to the following topics to learn about the specifics of the theme's palette and features.

* [Default Theme Colors](#default-theme-colors)
* [Default Theme Brushes](#default-theme-brushes)
* [Changing Palette Colors](#changing-palette-colors)
* [Changing Theme Variation](#changing-theme-variation)
* [Changing Font Properties](#changing-font-properties)
* [Using Glyphs](#using-glyphs)
* [Changing Corner Radius](#changing-corner-radius)
* [Theme Helper](#theme-helper)
* [Material Control](#material-control)
* [Changing Opacity](#changing-opacity)

## Default Theme Colors

Since the __R2 2021__ release of the __UI for WPF__ suite, the Material Theme has two color variations. The theme is designed to be easily modified via the exposed colors in the theme palette. Additionally, the introduction of the `MaterialAssist` helper class makes it easier than ever to modify appearance-related properties directly in the instance of the control without the need to extract and modify the default control templates of the basic controls. 

The default values of the brushes in the theme are listed below:

|Color name|   |Light|   |Dark|
|----------|---|-----|---|----|
|MainColor|#FFFFFFFF|<div class="theme-palette-color materialtheme-mainbrush"></div>|#FF303030|<div class="theme-palette-color materialtheme-mainbrush-dark"></div>|
|PrimaryColor|#FFFAFAFA|<div class="theme-palette-color materialtheme-primarybrush"></div>|#FF424242|<div class="theme-palette-color materialtheme-primarybrush-dark"></div>|
|ComplementaryColor|#FFE0E0E0|<div class="theme-palette-color materialtheme-complementarybrush"></div>|#FF171717|<div class="theme-palette-color materialtheme-complementarybrush-dark"></div>|
|AlternativeColor|#FFF5F5F5|<div class="theme-palette-color materialtheme-alternativebrush"></div>|#FF212121|<div class="theme-palette-color materialtheme-alternativebrush-dark"></div>|
|DividerColor|#1E000000|<div class="theme-palette-color materialtheme-dividerbrush"></div>|#1FFFFFFF|<div class="theme-palette-color materialtheme-dividerbrush-dark"></div>|
|MarkerColor|#FF000000|<div class="theme-palette-color materialtheme-markerbrush"></div>|#FFF1F1F1|<div class="theme-palette-color materialtheme-markerbrush-dark"></div>|
|MarkerInvertedColor|#FFFFFFFF|<div class="theme-palette-color materialtheme-markerinvertedbrush"></div>|#FFFFFFFF|<div class="theme-palette-color materialtheme-markerinvertedbrush-dark"></div>|
|IconColor|#FF000000|<div class="theme-palette-color materialtheme-iconbrush"></div>|#FFFFFFFF|<div class="theme-palette-color materialtheme-iconbrush-dark"></div>|
|ValidationColor|#FFD50000|<div class="theme-palette-color materialtheme-validationbrush"></div>|#FFCF6679|<div class="theme-palette-color materialtheme-validationbrush-dark"></div>|
|AccentNormalColor|#FFFFAB40|<div class="theme-palette-color materialtheme-accentnormalbrush"></div>|#FF00ACC1|<div class="theme-palette-color materialtheme-accentnormalbrush-dark"></div>|
|AccentHoverColor|#FFFFD180|<div class="theme-palette-color materialtheme-accenthoverbrush"></div>|#FF26C6DA|<div class="theme-palette-color materialtheme-accenthoverbrush-dark"></div>|
|AccentPressedColor|#FFFF9100|<div class="theme-palette-color materialtheme-accentpressedbrush"></div>|#FF0097A7|<div class="theme-palette-color materialtheme-accentpressedbrush-dark"></div>|
|PrimaryNormalColor|#FF3F51B5|<div class="theme-palette-color materialtheme-primarynormalbrush"></div>|#FF7986CB|<div class="theme-palette-color materialtheme-primarynormalbrush-dark"></div>|
|PrimaryHoverColor|#FF303F9F|<div class="theme-palette-color materialtheme-primaryhoverbrush"></div>|#FF5C6BC0|<div class="theme-palette-color materialtheme-primaryhoverbrush-dark"></div>|
|PrimaryPressedColor|#FF1A237E|<div class="theme-palette-color materialtheme-primarypressedbrush"></div>|#FF3F51B5|<div class="theme-palette-color materialtheme-primarypressedbrush-dark"></div>|
|PrimaryFocusColor|#FF9FA8DA|<div class="theme-palette-color materialtheme-primaryfocusbrush"></div>|#FF536DFE|<div class="theme-palette-color materialtheme-primaryfocusbrush-dark"></div>|
|RippleColor|#FFFFFFFF|<div class="theme-palette-color materialtheme-ripplebrush"></div>|#FFFFFFFF|<div class="theme-palette-color materialtheme-ripplebrush-dark"></div>|
|DividerSolidColor|#FFE1E1E1|<div class="theme-palette-color materialtheme-dividersolidbrush"></div>|#FF474747|<div class="theme-palette-color materialtheme-dividersolidbrush-dark"></div>|
|ReadOnlyBackgroundColor|#00FFFFFF|<div class="theme-palette-color materialtheme-readonlybackgroundbrush"></div>|#00FFFFFF|<div class="theme-palette-color materialtheme-readonlybackgroundbrush-dark"></div>|
|ReadOnlyBorderColor|#FFABABAB|<div class="theme-palette-color materialtheme-readonlyborderbrush"></div>|#FFABABAB|<div class="theme-palette-color materialtheme-readonlyborderbrush-dark"></div>|
|DialogBackgroundColor|#FFFFFFFF|<div class="theme-palette-color materialtheme-dialogbackgroundbrush"></div>|#FF262626|<div class="theme-palette-color materialtheme-dialogbackgroundbrush-dark"></div>|
|SelectedUnfocusedColor|#FFEEEEEE|<div class="theme-palette-color materialtheme-selectedunfocusedbrush"></div>|#FF262626|<div class="theme-palette-color materialtheme-selectedunfocusedbrush-dark"></div>|


__Theme colors represented in RadOutlookBar__

![material theme colors](images/materialOutlook.PNG)	

## Default Theme Brushes

Below you can find more details about each brush and where it is usually applied. The brushes can be divided in 4 groups based on their color:

* [Neutral Brushes](#neutral-brushes)
* [Primary Brushes](#primary-brushes)
* [Accent Brushes](#primary-brushes)
* [Special Brushes](#special-brushes)
* [Other Properties](#other-properties)

### Neutral Brushes
White, Gray, Black 

>They are used for backgrounds, non-intrusive interaction states, glyphs and icons, borders and separators, text.

* `MainBrush`&mdash;White by default and it is mainly used as background of the controls.
* `PrimaryBrush`&mdash;This brush is very light gray by default and it is used as secondary background color (background of RadDocking, CarouselItem).
* `AlternativeBrush`&mdash;A slightly darker gray brush that is used for the Mouse Over states of buttons, button-like controls and ListBoxItems. It is also used as a background in the RadRibbonBackstage and PrintPreview controls and dialogs.
* `ComplementaryBrush`&mdash;Even darker gray brush that is used for the Pressed states of the buttons, button-like controls and ListBoxItems.
* `DividerBrush`&mdash;A black brush with 12% opacity that is used for borders and separators. It is transparent, so that it could allow for the background color to pass through since it is very light grey.
* `DividerSolidBrush`&mdash;This is a special brush that is the solid color variation of the DividerBrush. It is calculated by overlaying the DividerBrush on top of the MainBrush. It is created for scenarios that the border or the separator should not be transparent, because it overlaps with other borders, lines or separators but should be the same color as the DividerBrush. It is used in controls which have stacked lines on top of each other like RadGridView, RadScheduleView, RadPivotGrid, RadPropertyGrid. 
* `MarkerBrush`&mdash;A standard black brush for the text elements.
* `MarkerInvertedBrush`&mdash;A white brush for text elements that are on a dark background.
* `IconBrush`&mdash;A black brush that is used for the icon paths and glyphs when they are on light backgrounds. It is often combined with opacity to achieve the desired shade of black.
* `DialogBackgroundBrush`&mdash;White by default brush that is used for the background of the window and dialog elements.

>important The `DialogBackgroundBrush` is __not__ available with versions prior to the __R2 2021__ release of the __UI for WPF__ suite.

### Primary brushes
Indigo

* `PrimaryNormalBrush`&mdash;By default, it is blue (indigo) and is used for coloring the primary accent elements - headers, important, selected or checked elements (RadListBoxItem, RadToggleButton, checked CheckBox background), slider thumbs etc.
* `PrimaryHoverBrush`&mdash;Variation of the PrimaryNormalBrush that is used for the hovered states of primary accent elements – raised/flat buttons. 
* `PrimaryPressedBrush`&mdash;Darker blue than the previous two brushes for pressed states of primary accent elements – pressed RadToggleButton/RadRadioButton, pressed state of raised/flat buttons.
* `PrimaryFocusBrush`&mdash;Light variation of the indigo color scheme which is used as a main brush for backgrounds and underlines, indicating focused states, as well as selection and dragging layovers – underlines for the input controls in focused states (TextBox, RadNumericUpDown, RadWatermarkTextBox etc.), backgrounds in normal states of buttons, RadListBoxItems and similar, focus halos for CheckBox and RadioButton.

### Accent brushes
Amber

* `AccentNormalBrush`&mdash;Bright amber-orange brush used as a background for the secondary accent element (RadScheduleView’s Appointments, RadGanttView Summary containers), hover state for checked/selected elements (selected RadListBoxItem hover, checked RadToggleButton hover), tab items focus underline (focused RadTabItem, focused LayoutControlTabGroupItem, selected docked RadDocumentPane), RadDiagramShape fill, RadDocking’s selected docked/undocked pinned RadPane/ToolWindow.
* `AccentHoverBrush`&mdash;Lighter variation of the amber color for the elements that have AccentNormalBrush as a background in their default state (RadScheduleView’s Appointments, header buttons in selected RadPane/ToolWindow in RadDocking), RadGridView frozen columns splitter, checked CheckBox and RadioButton, RadDiagramShade stroke.
* `AccentPressedBrush`&mdash;Darker amber color for the pressed/selected states of secondary accent controls - RadScheduleView’s Appointments, pressed or checked CheckBox and RadioButton, pressed states for header buttons in RadDocking’s RadDocking’s selected docked/undocked pinned RadPane/ToolWindow.

### Special brushes

* `ValidationBrush`&mdash;A bright red brush used for indicating validation errors - for the underline of the invalid control and as a background for the error tooltip, background for invalid rows and cells as well as for clear buttons' mouse over states.
* `RippleBrush`&mdash;A white by default brush which is used for the ripple effect of the MaterialControl. By itself it is a solid color, the opacity of the ripple comes from the MaterialControl’s RippleOpacity property.
* `ReadOnlyBackgroundBrush`&mdash;Used for the background of the controls in their read-only state.
* `ReadOnlyBorderBrush`&mdash;Used for the border color of the controls in their read-only state.
* `SelectedUnfocusedBrush`&mdash;Used for the background color of the controls in their selected, not focused state (e.g., the GridViewRow, TreeListViewRow and the TreeViewItem).

>important The `SelectedUnfocusedBrush` is __not__ available with versions prior to the __R2 2021__ release of the __UI for WPF__ suite.

## Other Properties

* `DisabledOpacity`&mdash;Used for disabled text. Backgrounds usually use the  `AlternativeBrush` when disabled.
* `ReadOnlyOpacity`&mdash;Used for text in inputs when they are in a __read-only__ state.

## Changing Palette Colors

The Material theme provides dynamic change of the palette colors responsible for the brushes used in the controls. Their defaults are stated above. This mechanism is used to modify the color variation of the theme. 

The general naming convention is: `MaterialPalette.Palette.[name]Color` is responsible for `[name]Brush` – e.g. `MaterialPalette.Palette.AccentNormalColor` sets the color for `telerik:MaterialResource ResourceKey=AccentNormalBrush`

Changing the colors can be achieved in code behind.

__Setting palette colors__
```C#
	MaterialPalette.Palette.AccentNormalColor = Color.FromRgb(255, 0, 0);
```

## Changing Theme Variation

Since the __R2 2021__ release of the __UI for WPF__ suite the Material theme offers two color variations. Both variations correspond to the [Material Design color palettes](https://material.io/design/color/the-color-system.html#tools-for-picking-colors). The `Light` variation is the default one and is based on the Indigo and Amber colors, and the `Dark` - based on the Indigo and Cyan colors. The following example demonstrates the ability to switch between the supported Light and Dark color palettes by calling the `LoadPreset` method as shown below:

__Changing the color variation of the theme__
```C#
	//default color variation 
	MaterialPalette.LoadPreset(MaterialPalette.ColorVariation.Light);   

	//Dark color variation 
	MaterialPalette.LoadPreset(MaterialPalette.ColorVariation.Dark); 
```

__Material theme color variations__

![Material theme colors represented in RadCardView](images/Material-theme-variations.PNG)

>important The `Dark` variation of the theme is designed with a dark background in mind. It is recommended to use such a background in your application when working with it.

## Changing Font Properties

When using the `Material` theme you can dynamically change the `FontSize` and `FontFamily` properties of all components in the application the same way as you do in all other [Available Themes]({%slug common-styling-appearance-available-themes%}) which support ThemePalette.

The FontSize and FontFamily properties are public so you can easily modify the theme resources at a single point. The most commonly used font size in the theme is with value __14__ and can be modified through the `MaterialPalette.Palette.FontSize` property. 

The default font used in the theme is [Roboto](https://fonts.google.com/specimen/Roboto).

>important For complex scenarios we strongly recommend setting the FontSize property only __before the application is initialized__ Also, we recommend values between __11px__ and __19px__ for it.

__Example 2__ shows the default font sizes and families.

__Default FontSize and FontFamily properties:__
```C#
	MaterialPalette.Palette.FontSizeS = 12;
	MaterialPalette.Palette.FontSize = 14;
	MaterialPalette.Palette.FontSizeL = 18;
	MaterialPalette.Palette.FontFamily = new FontFamily("Roboto");
```

__Example view definition__
```XAML
	<telerik:RadCalendar HorizontalAlignment="Center" />
	<telerik:RadButton Content="Change Font" Click="OnButtonChangeFontSizeClick" 
		     HorizontalAlignment="Center" VerticalAlignment="Center"/>
```
	
__Changing the theme's FontSize and FontFamily__
```C#
	private void OnButtonChangeFontSizeClick(object sender, RoutedEventArgs e)
	{
		MaterialPalette.Palette.FontSize = 12;
		MaterialPalette.Palette.FontFamily = new FontFamily("Calibri");
	}
```

__Setting FontSize and FontFamily__

![font changed](images/MaterialThemeFontChange.png)	

## Using Glyphs

The Material Theme uses and supports the same approach for adding icons and icon-like images introduced with the `Office2016 Theme`. Instead of images or paths we are using a font of glyphs by default. The `TelerikWebUI` font provides over 400 scalable vector glyphs that are available for use to our clients.

> You can read more about the usage and range of the new glyphs in the [Font Glyphs Overview article]({%slug common-styling-appearance-glyphs-overview%}).

__Adding the ResourceDictionary with the glyphs__
```XAML
	<ResourceDictionary Source="/Telerik.Windows.Controls;component/Themes/FontResources.xaml"/> 
```
 
## Changing Corner Radius

The Material Theme exposes an easy way to modify the corner radius of many elements in your application. You can directly use the corner radius property of the palette. By default the `CornerRadius` value is __2__. 

__Default corner radius values__
```C#
	  MaterialPalette.Palette.CornerRadius = new CornerRadius(2);
      MaterialPalette.Palette.CornerRadiusTop = new CornerRadius(2, 2, 0, 0);
      MaterialPalette.Palette.CornerRadiusBottom = new CornerRadius(0, 0, 2, 2);
      MaterialPalette.Palette.CornerRadiusLeft = new CornerRadius(2, 0, 0, 2);
      MaterialPalette.Palette.CornerRadiusRight = new CornerRadius(0, 2, 2, 0);
```

__Changing the default corner radius__
```C#
	MaterialPalette.Palette.CornerRadius = new CornerRadius(10); 	
```

__Appearance of a RadButton control after changing the default corner radius__

![corner radius](images/materialtheme-corner-radius.png)	

### Material Assist

The `MaterialAssist` static class comes from the Material theme and it is reused in the Fluent theme. It exposes a set of attached properties and can be used to directly modify the appearance of a specific basic control without the need to alter its control template. You can use the following dependency properties directly in XAML:

* `ShadowDepth`&mdash;Enum property that indicates the depth of the shadow effect over the control. There are 5 values that can be selected.
* `IsShadowDisabled`&mdash;The property is used to control the visibility of the shadow effect.

### Theme Helper

The [ThemeHelper]({%slug styling-appearance-theme-helper%}) class is used in the Windows11 theme. It exposes a set of attached properties and can be used to directly modify the appearance of a specific basic control without the need to alter its control template.

The following examples show a `RadToggleButton` control with modified brushes for its different states through the above helper classes:

__Declare the namespace for the helpers__
```XAML
	xmlns:mat="clr-namespace:Telerik.Windows.Controls.MaterialControls;assembly=Telerik.Windows.Controls"
	xmlns:helpers="clr-namespace:Telerik.Windows.Controls.Theming.Helpers;assembly=Telerik.Windows.Controls"
```

__Set RadToggleButton's visual appearance through the helpers__
```XAML
	  <telerik:RadToggleButton Content="RadButton" 
                               Margin="10"
                               helpers:ThemeHelper.MouseOverBrush="{telerik:MaterialResource ResourceKey=AccentHoverBrush}"
                               helpers:ThemeHelper.PressedBrush="{telerik:MaterialResource ResourceKey=AccentPressedBrush}"
							   helpers:ThemeHelper.CheckedBrush="{telerik:MaterialResource ResourceKey=ValidationBrush}" 
							   helpers:ThemeHelper.FocusBrush="{telerik:MaterialResource ResourceKey=PrimaryNormalBrush}"/>
```

__Appearance of the RadToggleButton in the different states__

![pressed brush](images/materialtheme-pressed-brush.png)![mouseover brush](images/materialtheme-mouseover-brush.png)![checked brush](images/materialtheme-checked-brush.png) ![focusedbrush](images/materialtheme-modifiedfocused-brush.png)

### Shadow 

The `Shadow` is one of the newly introduced elements designed specifically for the needs of the Material Theme. It is used to add a shadow effect around another control or element.

>important The Shadow element __is not intended to directly host other elements_ as the WPF drop shadow effect affects any nested texts and results in blurry characters. 

If you would like to use it separately in your application, you should work with its Width/Height properties so that it appears around the desired element as shown in the following example.

__Using a Shadow component separately__
```XAML
	 <Grid>
                <mat:Shadow Background="White" Width="150" Height="30" ShadowDepth="Depth5"/>
                <TextBlock Text="Some Text"
                           HorizontalAlignment="Center"
                           VerticalAlignment="Center"/>
     </Grid>
```

>important The Shadow element should have a background set for the effect to appear.

The element exposes a `ShadowDepth` enum property which takes one of the following values: `Depth5`, `Depth4`, `Depth3`, `Depth2`, `Depth1`, `Depth0`. The larger the depth number is the stronger the shadow effect will be. 

__Shadow effect applied over a TextBlock__

![shadow](images/materialtheme-shadow-control.png)

## Material Control

Another element specifically designed for the Material theme and used to display the interaction of the users with some of the controls is the `Material Control`. It is mainly used within the template of controls that suggest user actions such as the RadButton, RadToggleButton, etc. It adds a "ripple" effect and exposes several properties which you can use to modify the ripple functionality and its appearance:

* `IsRippleEnabled`&mdash;Indicates whether the ripple effect is enabled.
* `IsRippleCentered`&mdash;Controls the initial position from where the ripple effect starts. Setting the property to true will cause the effect to always start from the center of the control. Otherwise, the cursor position is respected. 
* `IsSmartClipped`&mdash;Sets whether the ripple should be within the boundaries of the corner radius.
* `RippleBrush`&mdash;Sets the brush used for the ripple effect.
* `RippleOpacity`&mdash;Sets the opacity of the ripple effect.

__Ripple effect on RadDropDownButton__

![ripple effect](images/RadDropDownButton.gif)

__Declaration of the Button element with a glyph as text__
```XAML
		 <Button VerticalAlignment="Center" HorizontalAlignment="Center" Style="{StaticResource RoundRadButtonStyle}">
                <TextBlock FontFamily="{StaticResource TelerikWebUI}"
                           FontSize="32" FontWeight="Normal" FontStyle="Normal"
                           Text="{StaticResource GlyphEdit}" VerticalAlignment="Center" HorizontalAlignment="Center" />
         </Button>
```
  					
__Button's Style declaration__
```XAML
	 <Style x:Key="RoundRadButtonStyle" TargetType="Button">
            <Setter Property="Background" Value="#FF2196F3" />
            <Setter Property="Foreground" Value="{telerik:MaterialResource ResourceKey=MarkerInvertedBrush}" />
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
                            <mat:MaterialControl IsRippleCentered="True"
                                                 RippleBrush="#FF82B1FF"
                                                 RippleOpacity="0.8"
                                                 IsSmartClipped="True"
                                                 CornerRadius="{TemplateBinding mat:MaterialAssist.CornerRadius}">  
                                <ContentPresenter Focusable="False"
											      TextBlock.Foreground="{TemplateBinding Foreground}"
											      Margin="{TemplateBinding Padding}"
                                                  Content="{TemplateBinding Content}" />
                            </mat:MaterialControl>
                        </Grid>
                    </ControlTemplate>
                </Setter.Value>
            </Setter>
      </Style>
```

__Material Control used within a custom template applied to a Button__

![custom button](images/custombtngif.gif)

> Note that for this button the `MouseOverBrush` and the `PressedBrush` properties from the above listed helpers are modified. They are are responsible for the mouse over and pressed animations and are automatically bound to the templated parent.

It is possible to disable the ripple effect of the MaterialControl through a style. The following example demonstrates how this can be achieved. The style can be included in the scope of the Telerik control(s) whose ripple effect needs to be disabled. 

__Disabling the Ripple effect__
```XAML
	 <!--If you are using the NoXaml binaries you should base the style on the default one for the theme like so
        <Style TargetType="mat:MaterialControl" BasedOn="{StaticResource MaterialControlStyle}" > 
        -->
        
	<Style TargetType="mat:MaterialControl" >
		<Setter Property="IsRippleEnabled" Value="False" />
	</Style>
```

## Changing Opacity 

If you need to change the opacity of the disabled and read-only elements, you can now easily do so by using the `DisabledOpacity` and `ReadOnlyOpacity` properties of the `MaterialPalette`. The default values are __0.26__ and __1__ respectively. 

__Changing the opacity__		
```C#
	MaterialPalette.Palette.DisabledOpacity = 0.5;
	MaterialPalette.Palette.ReadOnlyOpacity = 0.5;
```
```VB.NET
	MaterialPalette.Palette.DisabledOpacity = 0.5
	MaterialPalette.Palette.ReadOnlyOpacity = 0.5
```

## Merging Modified Palette Resources With StyleManager Theming Approach

When modifying fonts, colors, or other resources from the `MaterialPalette` and `StyleManager` is used as theming mechanism, the theme's `ResourceDictionary` needs to be merged in __App.xaml__ file to apply the changes.

__Merging the theme's ResourceDictionary in App.xaml__
```XAML
	<Application.Resources> 
	    <ResourceDictionary> 
	        <ResourceDictionary.MergedDictionaries> 
	            <telerik:MaterialResourceDictionary/> 
	        </ResourceDictionary.MergedDictionaries> 
	    </ResourceDictionary> 
	</Application.Resources>
```

## See Also

 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
 * [Style Manager]({%slug common-styling-apperance-setting-theme-wpf%})
 * [Glyphs Overview]({%slug common-styling-appearance-glyphs-overview%})
 * [Office2016 Theme]({%slug common-styling-appearance-office2016-theme%})
 * [Green Theme]({%slug common-styling-appearance-green-theme%})
