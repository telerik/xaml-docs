---
title: Theme Helper
page_title: Theme Helper
description: Style and Appearance / Themes Hepler. Themes Helper. The UI for {{ site.framework_name }} suite 
comes with a theming helper class which you can use to bring the theming of your application to a next level. 
slug: styling-appearance-theme-helper
tags: theming,theme,helper
published: False
position: 4
---

# Theme Helper

The **VisualStudio2019**, **Crystal**, **Fluent**, **Material**, **Office2016Touch**, **Office2016**, **Green**, **VisualStudio2013**, **Office2013**, **Windows8Touch** and **Windows8** themes are fully customizable using the theme palettes' available brushes to adjust each color. 

For seamless color customization that looks great and works with the full variety of our predefined themes, we created the **ThemeHelper** class.

## What is the Theme Helper?

The **Theme Helper** enables you to directly modify the appearance of a specific basic control without the need to alter its control template. The class contains the following list of dependency properties, which can be set directly in XAML for each of the themes:

* **MouseOverBrush**: Can be used to set the value of the background/border Brush applied when the mouse is over the control.
* **PressedBrush**: Can be used to set the value of the background/border Brush applied when the control is pressed.
* **CheckedBrush**: Can be used to set the value of the background/border Brush applied when the element is in Checked state. It will have effect when used on elements that expose a "checked" state(ToggleButton, RadListBoxItem, etc.)
* **FocusBrush**: Can be used to set the value of the background/border Brush applied when the element is focused.
* **ReadOnlyBrush**: Can be used to set the value of the background/border Brush applied when the control is in its read-only state (if such is available for it).
* **DisabledBrush**: Can be used to set the value of the background/border Brush applied when the control is in its disabled state.
* **CornerRadius**: Can be used to set the corner radius of commonly used basic controls that could need corner radius customizations but don't expose such property by default (e.g. Button, RepeatButton, ListBox, RadComboBox, etc.).

## How to use the Theme Helper?

It only takes a few simple steps:

* Declare the namespace for the theming helpers.
* Set any of the above listed properties directly to the desired control.
* If you need to apply it to a several (or a lot of) control instances, we recommend creating implicit styles.

The next examples show how to apply these steps to modify the brushes for the different states of a **RadToggleButton** through the **ThemeHelper** class:

#### __[XAML] Example 1: Declare the namespace for the ThemeHelper components__
{{region styling-appearance-theme-helper-1}}
	xmlns:helpers="clr-namespace:Telerik.Windows.Controls.Theming.Helpers;assembly=Telerik.Windows.Controls"
{{endregion}}

#### __[XAML] Example 2: Set RadToggleButton's visual appearance through the ThemeHelper class__
{{region styling-appearance-theme-helper-2}}
	<telerik:RadToggleButton Content="RadButton" 
							Margin="10"
							helpers:ThemeHelper.MouseOverBrush="{telerik:VisualStudio2019Resource ResourceKey=AccentMouseOverBrush}"
							helpers:ThemeHelper.PressedBrush="{telerik:VisualStudio2019Resource ResourceKey=ValidationBrush}"
							helpers:ThemeHelper.CheckedBrush="{telerik:VisualStudio2019Resource ResourceKey=AccentMainBrush}"/>
{{endregion}}


#### **Figure 1: Appearance of the RadToggleButton in the different states**
![RadToggleButton States](themes-suite/images/visualstudio2019-theme-togglebutton-states.png)