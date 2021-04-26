---
title: Material Theme
page_title: Material Theme
description: The article shows the Telerik WPF Material theme and its features and colors.
slug: common-styling-appearance-material-theme
tags: material,theme,glyphs,fontsize,fontfamily,shadow
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

With the **R2 2017** release of the **UI for WPF** suite we have introduced the brand new **Material Theme**. It comes with built-in elements that provide interaction feedback, with easy-to-customize colors and Material design drop shadows with beautiful and smooth transitions between the states.

With the **R2 2021** release of the **UI for WPF** suite, we have designed and delivered a brand new color variation of the Material theme - the Dark one. In addition to it, the theme palette expanded its brushes collection with the DialogBackgroundBrush and the SelectedUnfocusedBrush, which are available for both color variations and are described below.

The following topic explains the specifics of the theme's palette and features.

* [Default theme colors](#default-theme-colors)
* [Material Palette Brushes](#materialpalette-brushes)
* [Theme Variation Changing](#theme-variation-changing)
* [Changing Fonts](#font-family-and-font-size)
* [Glyphs](#glyphs)
* [Changing Corner Radius](#set-corner-radius)
* [Material Assist](#material-assist)
* [Shadow](#shadow)
* [Material Control](#material-control)

## Default Theme Colors

Since the **R2 2021** release of the **UI for WPF** suite, the **Material Theme** has two color variations. The theme is designed to be easily modified via the exposed colors in the theme palette. Additionally, the introduction of the **MaterialAssist** helper class makes it easier than ever to modify appearance-related properties directly in the instance of the control without the need to extract and modify the default control templates of the basic controls. 

The default values of the brushes in the theme are listed below:

|Brush name|   |Light|   |Dark|
|----------|---|-----|---|----|
|**MainBrush**|#FFFFFFFF|<div class="theme-palette-color materialtheme-mainbrush"></div>|#FF303030|<div class="theme-palette-color materialtheme-mainbrush-dark"></div>|
|**PrimaryBrush**|#FFFAFAFA|<div class="theme-palette-color materialtheme-primarybrush"></div>|#FF424242|<div class="theme-palette-color materialtheme-primarybrush-dark"></div>|
|**ComplementaryBrush**|#FFE0E0E0|<div class="theme-palette-color materialtheme-complementarybrush"></div>|#FF171717|<div class="theme-palette-color materialtheme-complementarybrush-dark"></div>|
|**AlternativeBrush**|#FFF5F5F5|<div class="theme-palette-color materialtheme-alternativebrush"></div>|#FF212121|<div class="theme-palette-color materialtheme-alternativebrush-dark"></div>|
|**DividerBrush**|#1E000000|<div class="theme-palette-color materialtheme-dividerbrush"></div>|#1FFFFFFF|<div class="theme-palette-color materialtheme-dividerbrush-dark"></div>|
|**MarkerBrush**|#FF000000|<div class="theme-palette-color materialtheme-markerbrush"></div>|#FFF1F1F1|<div class="theme-palette-color materialtheme-markerbrush-dark"></div>|
|**MarkerInvertedBrush**|#FFFFFFFF|<div class="theme-palette-color materialtheme-markerinvertedbrush"></div>|#FFFFFFFF|<div class="theme-palette-color materialtheme-markerinvertedbrush-dark"></div>|
|**IconBrush**|#FF000000|<div class="theme-palette-color materialtheme-iconbrush"></div>|#FFFFFFFF|<div class="theme-palette-color materialtheme-iconbrush-dark"></div>|
|**ValidationBrush**|#FFD50000|<div class="theme-palette-color materialtheme-validationbrush"></div>|#FFCF6679|<div class="theme-palette-color materialtheme-validationbrush-dark"></div>|
|**AccentNormalBrush**|#FFFFAB40|<div class="theme-palette-color materialtheme-accentnormalbrush"></div>|#FF00ACC1|<div class="theme-palette-color materialtheme-accentnormalbrush-dark"></div>|
|**AccentHoverBrush**|#FFFFD180|<div class="theme-palette-color materialtheme-accenthoverbrush"></div>|#FF26C6DA|<div class="theme-palette-color materialtheme-accenthoverbrush-dark"></div>|
|**AccentPressedBrush**|#FFFF9100|<div class="theme-palette-color materialtheme-accentpressedbrush"></div>|#FF0097A7|<div class="theme-palette-color materialtheme-accentpressedbrush-dark"></div>|
|**PrimaryNormalBrush**|#FF3F51B5|<div class="theme-palette-color materialtheme-primarynormalbrush"></div>|#FF7986CB|<div class="theme-palette-color materialtheme-primarynormalbrush-dark"></div>|
|**PrimaryHoverBrush**|#FF303F9F|<div class="theme-palette-color materialtheme-primaryhoverbrush"></div>|#FF5C6BC0|<div class="theme-palette-color materialtheme-primaryhoverbrush-dark"></div>|
|**PrimaryPressedBrush**|#FF1A237E|<div class="theme-palette-color materialtheme-primarypressedbrush"></div>|#FF3F51B5|<div class="theme-palette-color materialtheme-primarypressedbrush-dark"></div>|
|**PrimaryFocusBrush**|#FF9FA8DA|<div class="theme-palette-color materialtheme-primaryfocusbrush"></div>|#FF536DFE|<div class="theme-palette-color materialtheme-primaryfocusbrush-dark"></div>|
|**RippleBrush**|#FFFFFFFF|<div class="theme-palette-color materialtheme-ripplebrush"></div>|#FFFFFFFF|<div class="theme-palette-color materialtheme-ripplebrush-dark"></div>|
|**DividerSolidBrush**|#FFE1E1E1|<div class="theme-palette-color materialtheme-dividersolidbrush"></div>|#FF474747|<div class="theme-palette-color materialtheme-dividersolidbrush-dark"></div>|
|**ReadOnlyBackgroundBrush**|#00FFFFFF|<div class="theme-palette-color materialtheme-readonlybackgroundbrush"></div>|#00FFFFFF|<div class="theme-palette-color materialtheme-readonlybackgroundbrush-dark"></div>|
|**ReadOnlyBorderBrush**|#FFABABAB|<div class="theme-palette-color materialtheme-readonlyborderbrush"></div>|#FFABABAB|<div class="theme-palette-color materialtheme-readonlyborderbrush-dark"></div>|
|**DialogBackgroundBrush**|#FFFFFFFF|<div class="theme-palette-color materialtheme-dialogbackgroundbrush"></div>|#FF262626|<div class="theme-palette-color materialtheme-dialogbackgroundbrush-dark"></div>|
|**SelectedUnfocusedBrush**|#FFEEEEEE|<div class="theme-palette-color materialtheme-selectedunfocusedbrush"></div>|#FF262626|<div class="theme-palette-color materialtheme-selectedunfocusedbrush-dark"></div>|


#### __Figure 1: Theme colors represented in RadOutlookBar__
![material theme colors](images/materialOutlook.PNG)	

## MaterialPalette Properties

Below you can find more details about each brush and where it is usually applied. They can be divided in 4 groups based on their color:

* [Neutral Brushes](#neutral-brushes)
* [Primary Brushes](#primary-brushes)
* [Accent Brushes](#primary-brushes)
* [Special Brushes](#special-brushes)
* [Other Properties](#other-properties)

### **Neutral Brushes**
White, Gray, Black 

>They are used for backgrounds, non-intrusive interaction states, glyphs and icons, borders and separators, text.

* **MainBrush**:  White by default and it is mainly used as background of the controls.
* **PrimaryBrush**: This brush is very light gray by default and it is used as secondary background color (background of RadDocking, CarouselItem).
* **AlternativeBrush**: A slightly darker gray brush that is used for the Mouse Over states of buttons, button-like controls and ListBoxItems. It is also used as a background in the RadRibbonBackstage and PrintPreview controls and dialogs.
* **ComplementaryBrush**: Even darker gray brush that is used for the Pressed states of the buttons, button-like controls and ListBoxItems.
* **DividerBrush**: A black brush with 12% opacity that is used for borders and separators. It is transparent, so that it could allow for the background color to pass through since it is very light grey.
* **DividerSolidBrush**: This is a special brush that is the solid color variation of the DividerBrush. It is calculated by overlaying the DividerBrush on top of the MainBrush. It is created for scenarios that the border or the separator should not be transparent, because it overlaps with other borders, lines or separators but should be the same color as the DividerBrush. It is used in controls which have stacked lines on top of each other like RadGridView, RadScheduleView, RadPivotGrid, RadPropertyGrid. 
* **MarkerBrush**: A standard black brush for the text elements.
* **MarkerInvertedBrush**: A white brush for text elements that are on a dark background.
* **IconBrush**: A black brush that is used for the icon paths and glyphs when they are on light backgrounds. It is often combined with opacity to achieve the desired shade of black.
* **DialogBackgroundBrush**: White by default brush that is used for the background of the window and dialog elements.

>important The **DialogBackgroundBrush** is **not** available with versions prior to the **R2 2021** release of the **UI for WPF** suite.

### **Primary brushes**
Indigo

* **PrimaryNormalBrush**: By default, it is blue (indigo) and is used for coloring the primary accent elements - headers, important, selected or checked elements (RadListBoxItem, RadToggleButton, checked CheckBox background), slider thumbs etc.
* **PrimaryHoverBrush**: Variation of the PrimaryNormalBrush that is used for the hovered states of primary accent elements – raised/flat buttons. 
* **PrimaryPressedBrush**: Darker blue than the previous two brushes for pressed states of primary accent elements – pressed RadToggleButton/RadRadioButton, pressed state of raised/flat buttons.
* **PrimaryFocusBrush**: Light variation of the indigo color scheme which is used as a main brush for backgrounds and underlines, indicating focused states, as well as selection and dragging layovers – underlines for the input controls in focused states (TextBox, RadNumericUpDown, RadWatermarkTextBox etc.), backgrounds in normal states of buttons, RadListBoxItems and similar, focus halos for CheckBox and RadioButton.

### **Accent brushes**
Amber

* **AccentNormalBrush**: Bright amber-orange brush used as a background for the secondary accent element (RadScheduleView’s Appointments, RadGanttView Summary containers), hover state for checked/selected elements (selected RadListBoxItem hover, checked RadToggleButton hover), tab items focus underline (focused RadTabItem, focused LayoutControlTabGroupItem, selected docked RadDocumentPane), RadDiagramShape fill, RadDocking’s selected docked/undocked pinned RadPane/ToolWindow.
* **AccentHoverBrush**: Lighter variation of the amber color for the elements that have AccentNormalBrush as a background in their default state (RadScheduleView’s Appointments, header buttons in selected RadPane/ToolWindow in RadDocking), RadGridView frozen columns splitter, checked CheckBox and RadioButton, RadDiagramShade stroke.
* **AccentPressedBrush**: Darker amber color for the pressed/selected states of secondary accent controls - RadScheduleView’s Appointments, pressed or checked CheckBox and RadioButton, pressed states for header buttons in RadDocking’s RadDocking’s selected docked/undocked pinned RadPane/ToolWindow.

### **Special brushes**

* **ValidationBrush**: A bright red brush used for indicating validation errors - for the underline of the invalid control and as a background for the error tooltip, background for invalid rows and cells as well as for clear buttons' mouse over states.
* **RippleBrush**: A white by default brush which is used for the ripple effect of the MaterialControl. By itself it is a solid color, the opacity of the ripple comes from the MaterialControl’s RippleOpacity property.
* **ReadOnlyBackgroundBrush**: Used for the background of the controls in their read-only state.
* **ReadOnlyBorderBrush**: Used for the border color of the controls in their read-only state.
* **SelectedUnfocusedBrush**: Used for the background color of the controls in their selected, not focused state (e.g., the GridViewRow, TreeListViewRow and the TreeViewItem).

>important The **SelectedUnfocusedBrush** is **not** available with versions prior to the **R2 2021** release of the **UI for WPF** suite.

## Other Properties

* **DisabledOpacity**: Used for text when they are disabled. Backgrounds usually use the  **AlternativeBrush** when disabled.
* **ReadOnlyOpacity**: Used for text in inputs when they are in a **read-only** state.

## Theme Variation Changing

Since the **R2 2021** release of the **UI for WPF** suite the Material theme offers two color variations. Both variations correspond to the [Material Design color palettes](https://material.io/design/color/the-color-system.html#tools-for-picking-colors). The **Light** variation is the default one and is based on the Indigo and Amber colors, and the **Dark** - based on the Indigo and Cyan colors. The following example demonstrates the ability to switch between the supported **Light** and **Dark** color palettes by calling the **LoadPreset()** method as shown below:

#### __[C#] Example 1: Changing the color variation of the theme__
{{region cs-styling-appearance-material-theme-1}}
	//default color variation 
	MaterialPalette.LoadPreset(MaterialPalette.ColorVariation.Light);   

	//Dark color variation 
	MaterialPalette.LoadPreset(MaterialPalette.ColorVariation.Dark); 
{{endregion}}

#### __Figure 2: Material theme color variations__
![Material theme colors represented in RadCardView](images/Material-theme-variations.PNG)

## Font Family and Font Size

When using the **Material theme** you can dynamically change the **FontSize** and **FontFamily** properties of all components in the application the same way as you do in all other [Available Themes]({%slug common-styling-appearance-available-themes%}) which support ThemePalette.

The **FontSize** and **FontFamily** properties are public so you can easily modify the theme resources at a single point. The most commonly used font size in the theme is with value 14 and can be modified through the **MaterialPalette.Palette.FontSize** property. 

The default font used in the theme is [Roboto](https://fonts.google.com/specimen/Roboto).

>important For complex scenarios we strongly recommend setting the **FontSize** property only **before the application is initialized**. Also, we recommend values between **11px** and **19px** for it.

__Example 2__ shows the default font sizes and families.

#### __[C#] Example 2: Default FontSize and FontFamily properties:__
{{region styling-appearance-material-theme-2}}
	MaterialPalette.Palette.FontSizeS = 12;
	MaterialPalette.Palette.FontSize = 14;
	MaterialPalette.Palette.FontSizeL = 18;
	MaterialPalette.Palette.FontFamily = new FontFamily("Roboto");
{{endregion}}

The __Examples 3 and 4__ show how to change the default FontFamily from "Roboto" to "Calibri" and the FontSize from 14 to 12 on a click of a button.

#### __[XAML] Example 3: Example view definition__
{{region styling-appearance-material-theme-3}}
	<telerik:RadCalendar HorizontalAlignment="Center" />
	<telerik:RadButton Content="Change Font" Click="OnButtonChangeFontSizeClick" 
		     HorizontalAlignment="Center" VerticalAlignment="Center"/>
{{endregion}}
	
#### __[C#] Example 4: Changing the theme's FontSize and FontFamily__
{{region styling-appearance-material-theme-4}}
	private void OnButtonChangeFontSizeClick(object sender, RoutedEventArgs e)
	{
		MaterialPalette.Palette.FontSize = 12;
		MaterialPalette.Palette.FontFamily = new FontFamily("Calibri");
	}
{{endregion}}

#### __Figure 3: Setting FontSize and FontFamily__
![font changed](images/MaterialThemeFontChange.png)	

## Glyphs

The **Material Theme** uses and supports the same approach for adding icons and icon-like images introduced with the **Office2016** Theme. Instead of images or paths we are using a font of glyphs by default. The **TelerikWebUI** font provides over 400 scalable vector glyphs that are available for use to our clients.

> You can read more about the usage and range of the new glyphs in the [Font Glyphs Overview article]({%slug common-styling-appearance-glyphs-overview%}).

**Example 5** shows how to merge the font resources.

#### __[XAML] Example 5: Adding the ResourceDictionary with the glyphs__
{{region styling-appearance-material-theme-5}}
	<ResourceDictionary Source="/Telerik.Windows.Controls;component/Themes/FontResources.xaml"/> 
{{endregion}}

**Example 10** in the [Material Control](#material-control) section shows the usage of a glyph in a TextBlock.
 
## Set Corner Radius

The **Material Theme** exposes an easy way to modify the corner radius of many elements in your application. You can directly use the corner radius property of the palette. By default the **CornerRadius** value is **2** as shown in **Example 6**. 

#### __[C#] Example 6: Default corner radius values__
{{region styling-appearance-material-theme-6}}
	  MaterialPalette.Palette.CornerRadius = new CornerRadius(2);
      MaterialPalette.Palette.CornerRadiusTop = new CornerRadius(2, 2, 0, 0);
      MaterialPalette.Palette.CornerRadiusBottom = new CornerRadius(0, 0, 2, 2);
      MaterialPalette.Palette.CornerRadiusLeft = new CornerRadius(2, 0, 0, 2);
      MaterialPalette.Palette.CornerRadiusRight = new CornerRadius(0, 2, 2, 0);
{{endregion}}
	
**Example 7** shows how to change the default corner radius from 2 to 10. Note that you don't have to explicitly change all 5 corner radius properties as they will inherit the value from the **CornerRadius** main property.

#### __[C#] Example 7: Changing the default corner radius__
{{region styling-appearance-material-theme-7}}
	MaterialPalette.Palette.CornerRadius = new CornerRadius(10); 	
{{endregion}}

#### __Figure 4: Appearance of a RadButton control after changing the default corner radius__
![corner radius](images/materialtheme-corner-radius.png)	

## Changing Opacity 

If you need to change the opacity of the disabled and read-only elements, you can now easily do so by using the __DisabledOpacity__ and __ReadOnlyOpacity__ properties of the MaterialPalette. The default values are 0.26 and 1 respectively. 

#### __[C#] Example 8: Changing the opacity__		
{{region cs-styling-appearance-material-theme-8}}
	MaterialPalette.Palette.DisabledOpacity = 0.5;
	MaterialPalette.Palette.ReadOnlyOpacity = 0.5;
{{endregion}}
	
#### __[VB.NET] Example 8: Changing the opacity__		
{{region vb-styling-appearance-material-theme-8}}
	MaterialPalette.Palette.DisabledOpacity = 0.5
	MaterialPalette.Palette.ReadOnlyOpacity = 0.5
{{endregion}}

## Material Assist

The **Material Assist** static class exposes a set of attached properties and can be used to directly modify the appearance of a specific basic control without the need to alter its control template. Below is a list of the dependency properties which can be set directly in XAML:

* **CheckedBrush:** Sets the value of the background Brush applied when the element is in Checked state. It will have effect when used on elements that expose a "checked" state(ToggleButton, RadListBoxItem, etc.)  
* **FocusBrush:** Sets the value of the background Brush applied when the element is focused.
* **IsShadowDisabled:** The property is used to control the visibility of the shadow effect.
* **MouseOverBrush:** Sets the value of the background Brush applied when the mouse is over the control. 
* **PressedBrush:** Sets the value of the background Brush applied when the control is pressed.
* **ShadowDepth:** Enum property that indicates the depth of the shadow effect over the control. There are 5 values that can be selected.
* **CornerRadius:** Used to set the corner radius of commonly used basic controls that could need corner radius customizations but don't expose such property by default (e.g. Button, RepeatButton, ListBox, RadComboBox, etc.). **Example 11** shows how to set corner radius to a default Button element.

The following examples show a **RadToggleButton** control with modified brushes for its different states through the **MaterialAssist** class:

#### __[XAML] Example 9: Declare the namespace for the Material components__
{{region styling-appearance-material-theme-9}}
	xmlns:mat="clr-namespace:Telerik.Windows.Controls.MaterialControls;assembly=Telerik.Windows.Controls"
{{endregion}}

#### __[XAML] Example 10: Set RadToggleButton's visual appearance through the MaterialAssist class__
{{region styling-appearance-material-theme-10}}
	  <telerik:RadToggleButton Content="RadButton" 
                               Margin="10"
                               mat:MaterialAssist.MouseOverBrush="{telerik:MaterialResource ResourceKey=AccentHoverBrush}"
                               mat:MaterialAssist.PressedBrush="{telerik:MaterialResource ResourceKey=AccentPressedBrush}"
							   mat:MaterialAssist.CheckedBrush="{telerik:MaterialResource ResourceKey=ValidationBrush}" 
							   mat:MaterialAssist.FocusBrush="{telerik:MaterialResource ResourceKey=PrimaryNormalBrush}"/>
{{endregion}}

#### **Figure 5: Appearance of the RadToggleButton in the different states**

![pressed brush](images/materialtheme-pressed-brush.png)![mouseover brush](images/materialtheme-mouseover-brush.png)![checked brush](images/materialtheme-checked-brush.png) ![focusedbrush](images/materialtheme-modifiedfocused-brush.png)

## Shadow 

The **Shadow** is one of the newly introduced elements designed specifically for the needs of the **Material Theme**. It is used to add a shadow effect around another control or element.

>important The Shadow element **is not intended to directly host other elements** as the WPF drop shadow effect affects any nested texts and results in blurry characters. 

If you would like to use it separately in your application, you should work with its Width/Height properties so that it appears around the desired element as shown in the following example.

#### **[XAML] Example 11: Using a Shadow component separately**
{{region styling-appearance-material-theme-11}}
	 <Grid>
                <mat:Shadow Background="White" Width="150" Height="30" ShadowDepth="Depth5"/>
                <TextBlock Text="Some Text"
                           HorizontalAlignment="Center"
                           VerticalAlignment="Center"/>
     </Grid>
{{endregion}}

>important The Shadow element should have a background set for the effect to appear.

The element exposes a **ShadowDepth** enum property which takes one of the following values: **Depth5**, **Depth4**, **Depth3**, **Depth2**, **Depth1**, **Depth0**. The larger the depth number is the stronger the shadow effect will be. 

**Figure 6** shows the effect that the shadow element adds around a **TextBlock** element. 

#### **Figure 6: Shadow effect applied over a TextBlock**

![shadow](images/materialtheme-shadow-control.png)

## Material Control

Another element specifically designed for the Material theme and used to display the interaction of the users with some of the controls is the **Material Control**. It is mainly used within the template of controls that suggest user actions such as the RadButton, RadToggleButton, etc. It adds a "ripple" effect and exposes several properties which you can use to modify the ripple functionality and its appearance:

* **IsRippleEnabled:** Indicates whether the ripple effect is enabled.
* **IsRippleCentered:** Controls the initial position from where the ripple effect starts. Setting the property to true will cause the effect to always start from the center of the control. Otherwise, the cursor position is respected. 
* **IsSmartClipped:** Sets whether the ripple should be within the boundaries of the corner radius.
* **RippleBrush:** Sets the brush used for the ripple effect.
* **RippleOpacity:** Sets the opacity of the ripple effect.

#### **Figure 7: Ripple effect on RadDropDownButton**

![ripple effect](images/RadDropDownButton.gif)

The following code snippets show how to integrate the Material Control with a RadButton.

#### **[XAML] Example 12: Declaration of the Button element with a glyph as text**
{{region styling-appearance-material-theme-12}}
		 <Button VerticalAlignment="Center" HorizontalAlignment="Center" Style="{StaticResource RoundRadButtonStyle}">
                <TextBlock FontFamily="{StaticResource TelerikWebUI}"
                           FontSize="32" FontWeight="Normal" FontStyle="Normal"
                           Text="{StaticResource GlyphEdit}" VerticalAlignment="Center" HorizontalAlignment="Center" />
         </Button>
{{endregion}}
  					
#### **[XAML] Example 13: Button's Style declaration**
{{region styling-appearance-material-theme-13}}
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
{{endregion}}

#### **Figure 8: Material Control used within a custom template applied to a Button**

![custom button](images/custombtngif.gif)

> Note that the **MaterialAssist.MouseOverBrush** and **MaterialAssist.PressedBrush** properties, which are responsible for the mouse over and pressed animations, are automatically bound to the templated parent.

It is possible to disable the ripple effect of the MaterialControl through a style. __Example 14__ demonstrates how this can be achieved. The style can be included in the scope of the Telerik control(s) whose ripple effect needs to be disabled. 

#### **[XAML] Example 14: Disabling the Ripple effect**
{{region styling-appearance-material-theme-14}}
	 <!--If you are using the NoXaml binaries you should base the style on the default one for the theme like so
        <Style TargetType="mat:MaterialControl" BasedOn="{StaticResource MaterialControlStyle}" > 
        -->
        
	<Style TargetType="mat:MaterialControl" >
		<Setter Property="IsRippleEnabled" Value="False" />
	</Style>
{{endregion}}

## See Also

 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
 * [Style Manager]({%slug common-styling-apperance-setting-theme-wpf%})
 * [Glyphs Overview]({%slug common-styling-appearance-glyphs-overview%})
 * [Office2016 Theme]({%slug common-styling-appearance-office2016-theme%})
 * [Green Theme]({%slug common-styling-appearance-green-theme%})
