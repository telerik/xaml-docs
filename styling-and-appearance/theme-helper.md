---
title: Theme Helper
page_title: Theme Helper
description: The UI for {{ site.framework_name }} suite comes with a theming helper class which you can use to bring the theming of your application to a next level. 
slug: styling-appearance-theme-helper
tags: theming,theme,helper
published: True
position: 5
---

# Theme Helper

The **Theme Helper** enables you to directly modify the appearance of a specific basic control without the need to alter its control template. The class contains the following list of dependency properties, which can be set directly in XAML for each of the themes:

* **MouseOverBrush**: Can be used to set the value of the background/border Brush applied when the mouse is over the control.
* **PressedBrush**: Can be used to set the value of the background/border Brush applied when the control is pressed.
* **CheckedBrush**: Can be used to set the value of the background/border Brush applied when the element is in Checked state. It will have effect when used on elements that expose a "checked" state (ToggleButton, RadListBoxItem, etc.)
* **FocusBrush**: Can be used to set the value of the background/border Brush applied when the element is focused.
* **ReadOnlyBrush**: Can be used to set the value of the background/border Brush applied when the control is in its read-only state (if such is available for it).
* **DisabledBrush**: Can be used to set the value of the background/border Brush applied when the control is in its disabled state.
* **CornerRadius**: Can be used to set the corner radius of commonly used basic controls that could need corner radius customizations but don't expose such property by default (e.g. Button, RepeatButton, ListBox, RadComboBox, etc.)

> The ThemeHelper class currently works out-of-the-box with the **VisualStudio2019**, **Crystal**, **Fluent**, **Material** themes. Please note that not all properties will work for any given control at the moment. To see which properties are fully supported for a specific control, please check its [ControlTemplate]({%slug styling-apperance-editing-control-templates%}).

## How to Use the Theme Helper?

It only takes a few simple steps:

* Declare the namespace for the theming helpers.
* Set any of the above listed properties directly to the desired control.
* If you need to apply it to a several (or a lot of) control instances, we recommend creating implicit styles.

The next examples show how to apply these steps to modify the brushes for the different states of a **RadToggleButton** through the **ThemeHelper** class:

#### __[XAML] Example 1: Declare a SolidColorBrush to use as a StaticResource__
{{region styling-appearance-theme-helper-1}}
	<SolidColorBrush x:Key="MyCheckedBrush" Color="#FFFF86B1"/>
{{endregion}}

#### __[XAML] Example 2: Set RadToggleButton's visual appearance through the ThemeHelper class__
{{region styling-appearance-theme-helper-2}}
	<telerik:RadToggleButton Content="RadButton" 
							Margin="10"
							xmlns:helpers="clr-namespace:Telerik.Windows.Controls.Theming.Helpers;assembly=Telerik.Windows.Controls"
							helpers:ThemeHelper.MouseOverBrush="LightGoldenrodYellow"
							helpers:ThemeHelper.PressedBrush="{telerik:VisualStudio2019Resource ResourceKey=ValidationBrush}"
							helpers:ThemeHelper.CheckedBrush="{StaticResource MyCheckedBrush}"/>
{{endregion}}

#### **Figure 1: Appearance of the RadToggleButton in the different states**
![RadToggleButton States](/styling-and-appearance/images/styling-appearance-theme-helper-toggle-button-states.png)

## See Also

 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
 * [Style Manager]({%slug common-styling-apperance-setting-theme-wpf%})
 * [Themes Suite]({%slug common-styling-appearance-available-themes%})
 * [VisualStudio2019 Theme]({%slug common-styling-appearance-visualstudio2019-theme%})
 * [Material Theme]({%slug common-styling-appearance-material-theme%})
