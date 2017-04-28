---
title: Material Theme
page_title: Material Theme
description: Material Theme
slug: common-styling-appearance-material-theme
tags: material,theme,glyphs,fontsize,fontfamily,shadow
published: True
position: 6
---

# Material Theme

With the **R2 2017** release of the **UI for WPF** suite we have introduced the brand new **Material Theme**. It comes with built-in elements that provide interaction feedback, with easy-to-customize colors and Material design drop shadows with beautiful and smooth transitions between the states. 

The following topic explains the specifics of the theme's palette and features.

* [Default theme colors](#default-theme-colors)
* [Material Palette Brushes](#materialpalette-brushes)
* [Changing Fonts](#font-family-and-font-size)
* [Glyphs](#glyphs)
* [Changing Corner Radius](#set-corner-radius)
* [Material Assist](#material-assist)
* [Shadow](#shadow)
* [Material Control](#material-control)

## Default Theme Colors

The **Material Theme** has one color variation, but it is designed to be easily modified via the exposed colors in the theme palette. Furthermore, the introduction of the **MaterialAssist** helper class makes it easier than ever to modify appearance-related properties directly in the instance of the control without the need to extract and modify the default control templates of the basic controls. 

The default values of the brushes in the theme are listed below:

|Brush name|Brush value||
|----------|-----------|---|
|**MainBrush**|#FFFFFFFF|<div class="theme-palette-color materialtheme-mainbrush" color:></div>|
|**PrimaryBrush**|#FFFAFAFA|<div class="theme-palette-color materialtheme-primarybrush"></div>|
|**ComplementaryBrush**|#FFE0E0E0|<div class="theme-palette-color materialtheme-complementarybrush"></div>|
|**AlternativeBrush**|#FFF5F5F5|<div class="theme-palette-color materialtheme-alternativebrush"></div>|
|**DividerBrush**|#1E000000|<div class="theme-palette-color materialtheme-dividerbrush"></div>|
|**MarkerBrush**|#FF000000|<div class="theme-palette-color materialtheme-markerbrush"></div>|
|**MarkerInvertedBrush**|#FFFFFFFF|<div class="theme-palette-color materialtheme-markerinvertedbrush"></div>|
|**IconBrush**|#FF000000|<div class="theme-palette-color materialtheme-iconbrush"></div>|
|**ValidationBrush**|#FFD50000|<div class="theme-palette-color materialtheme-validationbrush"></div>|
|**AccentNormalBrush**|#FFFFAB40|<div class="theme-palette-color materialtheme-accentnormalbrush"></div>|
|**AccentHoverBrush**|#FFFFD180|<div class="theme-palette-color materialtheme-accenthoverbrush"></div>|
|**AccentPressedBrush**|#FFFF9100|<div class="theme-palette-color materialtheme-accentpressedbrush"></div>|
|**PrimaryNormalBrush**|#FF3F51B5|<div class="theme-palette-color materialtheme-primarynormalbrush"></div>|
|**PrimaryHoverBrush**|#FF303F9F|<div class="theme-palette-color materialtheme-primaryhoverbrush"></div>|
|**PrimaryPressedBrush**|#FF1A237E|<div class="theme-palette-color materialtheme-primarypressedbrush"></div>|
|**PrimaryFocusBrush**|#FF9FA8DA|<div class="theme-palette-color materialtheme-primaryfocusbrush"></div>|
|**RippleBrush**|#FFFFFFFF|<div class="theme-palette-color materialtheme-ripplebrush"></div>|
|**DividerSolidBrush**|#FFE1E1E1|<div class="theme-palette-color materialtheme-dividersolidbrush"></div>|


#### __Figure 1: Theme colors represented in RadOutlookBar__
![material theme colors](images/materialOutlook.PNG)	

## MaterialPalette Brushes

Below you can find more details about each brush and where it is usually applied. They can be divided in 4 groups based on their color:

* [Neutral Brushes](#neutral-brushes)
* [Primary Brushes](#primary-brushes)
* [Accent Brushes](#primary-brushes)
* [Special Brushes](#special-brushes)

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

### **Primary brushes**
Indigo

* **PrimaryNormalBrush**: By default, it is blue (indigo) and is used for coloring the primary accent elements - headers, important, selected or checked elements (RadListBoxItem, RadToggleButton, checked CheckBox background), slider thumbs etc.
* **PrimaryHoverBrush**: Variation of the PrimaryNormalBrush that is used for the hovered states of primary accent elements – raised/flat buttons. 
* **PrimaryPressedBrush**: Darker blue than the previous two brushes for pressed states of primary accent elements – pressed RadToggleButton/RadRadioButton, pressed state of raised/flat buttons.
* **PrimaryFocusBrush**: Light variation of the indigo color scheme which is used as a main brush for backgrounds and underlines, indicating focused states, as well as selection and dragging layovers – underlines for the input controls in focused states (TextBox, RadNumericUpDown, RadWatermarkTextBox etc.), backgrounds in normal states of buttons, RadListBoxItems and similar, focus halos for CheckBox and RadioButton.

### **Accent brushes**
Amber

* **AccentNormalBrush**: Bright amber-orange brush used as a background for the secondary accent element (RadScheduleView’s Appointments, RadGanttView Summary containers), hover state for checked/selected elements (selected RadListBoxItem hover, checked RadToggleButton hover), tab items focus underline (focused RadTabItem, focused LayoutControlTabGroupItem, selected docked RadDocumenPane), RadDiagramShape fill, RadDocking’s selected docked/undocked pinned RadPane/ToolWindow.
* **AccentHoverBrush**: Lighter variation of the amber color for the elements that have AccentNormalBrush as a background in their default state (RadScheduleView’s Appointments, header buttons in selected RadPane/ToolWindow in RadDocking), RadGridView frozen columns splitter, checked CheckBox and RadioButton, RadDiagramShade stroke.
* **AccentPressedBrush**: Darker amber color for the pressed/selected states of secondary accent controls - RadScheduleView’s Appointments, pressed or checked CheckBox and RadioButton, pressed states for header buttons in RadDocking’s RadDocking’s selected docked/undocked pinned RadPane/ToolWindow.

### **Special brushes**

* **ValidationBrush**: A bright red brush used for indicating validation errors - for the underline of the invalid control and as a background for the error tooltip, background for invalid rows and cells as well as for clear buttons' mouse over states.
* **RippleBrush**: A white by default brush which is used for the ripple effect of the MaterialControl. By itself it is a solid color, the opacity of the ripple comes from the MaterialControl’s RippleOpacity property.

## Font Family and Font Size

When using the **Material theme** you can dynamically change the **FontSize** and **FontFamily** properties of all components in the application the same way as you do in **Windows8**, **Windows8Touch**, **Office2013**, **VisualStudio2013**, **Office2016** and **Green** themes.

The **FontSize** and **FontFamily** properties are public so you can easily modify the theme resources at a single point. The most commonly used font size in the theme is with value 14 and can be modified through the **MaterialPalette.Palette.FontSize** property. 

The default font used in the theme is [Roboto](https://fonts.google.com/specimen/Roboto).

>important For complex scenarios we strongly recommend setting the **FontSize** property only **before the application is initialized**. Also, we recommend values between **11px** and **19px** for it.

__Example 1__ shows the default font sizes and families.

#### __[C#] Example 1: Default FontSize and FontFamily properties:__

	MaterialPalette.Palette.FontSizeS = 12;
	MaterialPalette.Palette.FontSize = 14;
	MaterialPalette.Palette.FontSizeL = 18;
	MaterialPalette.Palette.FontFamily = new FontFamily(“Roboto”);

The __Examples 2 and 3__ show how to change the default FontFamily from "Roboto" to "Calibri" and the FontSize from 14 to 12 on a click of a button.

#### __[XAML] Example 2: Example view definition__
	
	<telerik:RadCalendar HorizontalAlignment="Center" />
	<telerik:RadButton Content="Change Font" Click="OnButtonChangeFontSizeClick" 
		     HorizontalAlignment="Center" VerticalAlignment="Center"/>
	
#### __[C#] Example 3: Changing the theme's FontSize and FontFamily__
	private void OnButtonChangeFontSizeClick(object sender, RoutedEventArgs e)
	{
		MaterialPalette.Palette.FontSize = 12;
		MaterialPalette.Palette.FontFamily = new FontFamily("Calibri");
	}

#### __Figure 2: Setting FontSize and FontFamily__
![font changed](images/MaterialThemeFontChange.png)	

## Glyphs

The **Material Theme** uses and supports the same approach for adding icons and icon-like images introduced with the **Office2016** Theme. Instead of images or paths we are using a font of glyphs by default. The **TelerikWebUI** font provides over 400 scalable vector glyphs that are available for use to our clients.

> You can read more about the usage and range of the new glyphs in the [Font Glyphs Overview article]({%slug common-styling-appearance-glyphs-overview%}).

**Example 4** show how to merge the font resources.

#### __[XAML] Example 4: Adding the ResourceDictionary with the glyphs__
	<ResourceDictionary Source="/Telerik.Windows.Controls;component/Themes/FontResources.xaml"/> 

**Example 10** in the [Material Control](#material-control) section shows the usage of a glyph in a TextBlock.
 
## Set Corner Radius

The **Material Theme** exposes an easy way to modify the corner radius of many elements in your application. You can directly use the corner radius property of the palette. By default the **CornerRadius** value is **2** as shown in **Example 5**. 

#### __[C#] Example 5: Default corner radius values__
	  MaterialPalette.Palette.CornerRadius = new CornerRadius(2);
      MaterialPalette.Palette.CornerRadiusTop = new CornerRadius(2, 2, 0, 0);
      MaterialPalette.Palette.CornerRadiusBottom = new CornerRadius(0, 0, 2, 2);
      MaterialPalette.Palette.CornerRadiusLeft = new CornerRadius(2, 0, 0, 2);
      MaterialPalette.Palette.CornerRadiusRight = new CornerRadius(0, 2, 2, 0);
	
**Example 6** shows how to change the default corner radius from 2 to 10. Note that you don't have to explicitly change all 5 corner radius properties as they will inherit the value from the **CornerRadius** main property.

#### __[C#] Example 6: Changing the default corner radius__
	MaterialPalette.Palette.CornerRadius = new CornerRadius(10); 	

#### __Figure 3: Apperance of a RadButton control after changing the default corner radius__
![corner radius](images/materialtheme-corner-radius.png)	

## Material Assist

The **Material Assist** static class exposes a set of attached properties and can be used to directly modify the appearance of a specific basic control without the need to alter its control template. Below is a list of the dependency properties which can be set directly in XAML:

* **CheckedBrush:** Sets the value of the background Brush applied when the element is in Checked state. It will have effect when used on elements that expose a "checked" state(ToggleButton, RadListBoxItem, etc.)  
* **FocusBrush:** Sets the value of the background Brush applied when the element is focused.
* **IsShadowDisabled:** The property is used to control the visibility of the shadow effect.
* **MouseOverBrush:** Sets the value of the background Brush applied when the mouse is over the control. 
* **PressedBrush:** Sets the value of the background Brush applied when the control is pressed.
* **ShadowDepth:** Enum property that indicates the depth of the shadow effect over the control. There are 5 values that can be selected.
* **CornerRadius:** Used to set the corner radius of commonly used basic controls that could need corner radius customizations but don't expose such property by default (e.g. Button, RepeatButton, ListBox, RadComboBox, etc.). **Example 11** shows how to set corner radius to a default Button element.

**Example 8** shows a **RadToggleButton** control with modified brushes for its different states through the **MaterialAssist** class:

#### __[XAML] Example 7: Declare the namespace for the Material components__
	xmlns:mat="clr-namespace:Telerik.Windows.Controls.MaterialControls;assembly=Telerik.Windows.Controls"


#### __[XAML] Example 8: Set RadToggleButton's visual appearance through the MaterialAssist class__
	  <telerik:RadToggleButton Content="RadButton" 
                               Margin="10"
                               mat:MaterialAssist.MouseOverBrush="{telerik:MaterialResource ResourceKey=AccentHoverBrush}"
                               mat:MaterialAssist.PressedBrush="{telerik:MaterialResource ResourceKey=AccentPressedBrush}"
							   mat:MaterialAssist.CheckedBrush="{telerik:MaterialResource ResourceKey=ValidationBrush}" 
							   mat:MaterialAssist.FocusBrush="{telerik:MaterialResource ResourceKey=PrimaryNormalBrush}"/>

#### **Figure 4: Appearance of the RadToggleButton in the different states**

![pressed brush](images/materialtheme-pressed-brush.png)![mouseover brush](images/materialtheme-mouseover-brush.png)![checked brush](images/materialtheme-checked-brush.png) ![focusedbrush](images/materialtheme-modifiedfocused-brush.png)

## Shadow 

The **Shadow** is one of the newly introduced elements designed specifically for the needs of the **Material Theme**. It is used to add a shadow effect around another control or element. 

>important The Shadow element **is not intended to directly host other elements** as the WPF drop shadow effect affects any nested texts and results in blurry characters. 

If you would like to use it separately in your application, you should work with its Width/Height properties so that it appears around the desired element as shown in **Example 9**.

#### **[XAML] Example 9: Using a Shadow component separately**

	 <Grid>
                <mat:Shadow Background="White" Width="150" Height="30" ShadowDepth="Depth5"/>
                <TextBlock Text="Some Text"
                           HorizontalAlignment="Center"
                           VerticalAlignment="Center"/>
     </Grid>

>important The Shadow element should have a background set for the effect to appear.

The element exposes a **ShadowDepth** enum property which takes one of the following values: **Depth5**, **Depth4**, **Depth3**, **Depth2**, **Depth1**, **Depth0**. The larger the depth number is the stronger the shadow effect will be. 

**Figure 5** shows the effect that the shadow element adds around a **TextBlock** element. 

#### **Figure 5: Shadow effect applied over a TextBlock**

![shadow](images/materialtheme-shadow-control.png)

## Material Control

Another element specifically designed for the Material theme and used to display the interaction of the users with some of the controls is the **Material Control**. It is mainly used within the template of controls that suggest user actions such as the RadButton, RadToggleButton, etc. It adds a "ripple" effect and exposes several properties which you can use to modify the ripple functionality and its appearance:

* **IsRippleEnabled:** Indicates whether the ripple effect is enabled.
* **IsRippleCentered:** Controls the initial position from where the ripple effect starts. Setting the property to true will cause the effect to always start from the center of the control. Otherwise, the cursor position is respected. 
* **IsSmartClipped:** Sets whether the ripple should be within the boundaries of the corner radius.
* **RippleBrush:** Sets the brush used for the ripple effect.
* **RippleOpacity:** Sets the opacity of the ripple effect.

#### **Figure 6: Ripple effect оn RadDropDownButton**

![ripple effect](images/RadDropDownButton.gif)

The following code snippets show how you can integrate the Material Control with a RadButton  

#### **[XAML] Example 10: Declaration of the Button element with a glyph as text**

		 <Button VerticalAlignment="Center" HorizontalAlignment="Center" Style="{StaticResource RoundRadButtonStyle}">
                <TextBlock FontFamily="{StaticResource TelerikWebUI}"
                           FontSize="32" FontWeight="Normal" FontStyle="Normal"
                           Text="{StaticResource GlyphEdit}" VerticalAlignment="Center" HorizontalAlignment="Center" />
         </Button>
  					
#### **[XAML] Example 11: Button's Style declaration**

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

#### **Figure 7: Material Control used within a custom template applied to a Button**

![custom button](images/custombtngif.gif)

> Note that the **MaterialAssist.MouseOverBrush** and **MaterialAssist.PressedBrush** properties, which are responsible for the mouse over and pressed animations, are automatically bound to the templated parent.

## See Also

 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
 * [Style Manager]({%slug common-styling-apperance-setting-theme-wpf%})
 * [Glyphs Overview]({%slug common-styling-appearance-glyphs-overview%})
 * [Office2016 Theme]({%slug common-styling-appearance-office2016-theme%})
 * [Green Theme]({%slug common-styling-appearance-green-theme%})
