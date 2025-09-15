---
title: Theme Helper
page_title: Theme Helper
description: The UI for WPF suite comes with a theming helper class which you can use to bring the theming of your application to a next level. 
slug: styling-appearance-theme-helper
tags: theming,theme,helper
published: True
position: 5
---

# Theme Helper

The `ThemeHelper` class allows you to directly modify the appearance of a specific basic control without the need to alter its control template. 

The class contains the following list of dependency properties, which can be set directly in XAML:

* `MouseOverBrush`&mdash;Can be used to set the value of the border Brush applied when the mouse is over the control.
* `MouseOverBackgroundBrush`&mdash;Can be used to set the value of the background Brush applied when the mouse is over the control.
* `PressedBrush`&mdash;Can be used to set the value of the border Brush applied when the control is pressed.
* `PressedBackgroundBrush`&mdash;Can be used to set the value of the background Brush applied when the control is pressed.
* `CheckedBrush`&mdash;Can be used to set the value of the border Brush applied when the element is in Checked state. It will have effect when used on elements that expose a "checked" state (ToggleButton, RadListBoxItem, etc.)
* `CheckedBackgroundBrush`&mdash;Can be used to set the value of the background Brush applied when the element is in Checked state.
* `FocusBrush`&mdash;Can be used to set the value of the border Brush applied when the element is focused.
* `FocusBackgroundBrush`&mdash;Can be used to set the value of the background Brush applied when the element is focused.
* `ReadOnlyBrush`&mdash;Can be used to set the value of the border Brush applied when the control is in its read-only state (if such is available for it).
* `ReadOnlyBackgroundBrush`&mdash;Can be used to set the value of the background Brush applied when the control is in its read-only state (if such is available for it).
* `DisabledBrush`&mdash;Can be used to set the value of the border Brush applied when the control is in its disabled state.
* `DisabledForegroundBrush`&mdash;Can be used to set the value of the foreground Brush applied when the control is in its disabled state.
* `DisabledBackgroundBrush`&mdash;Can be used to set the value of the background Brush applied when the control is in its disabled state.
* `ScrollBarsMode`&mdash;Can be used to set the mode of the scrollbars of a ScrollViewer. This mode takes effect for themes like Fluent and Crystal, which by design have thin scrollbars that expand their size on MouseOver.
* `FocusVisualMargin`&mdash;Sets a margin for the focus visual element.
* `CornerRadius`&mdash;Can be used to set the corner radius of commonly used basic controls that could need corner radius customizations but don't expose such property by default (e.g. Button, RepeatButton, ListBox, RadComboBox, etc.)

>important The ThemeHelper class currently works out-of-the-box with the __Windows 11__, __Office2019__, __VisualStudio2019__, __Crystal__, __Fluent__, and __Material__ themes. Please note that not all properties will work for any given control at the moment. To see which properties are fully supported for a specific control, please check its [ControlTemplate]({%slug styling-apperance-editing-control-templates%}).

## How to Use the Theme Helper?

It only takes a few simple steps:

* Declare the namespace for the theming helpers.
* Set any of the above listed properties directly to the desired control.
* If you need to apply it to a several (or a lot of) control instances, we recommend creating implicit styles.

The next examples show how to apply these steps to modify the brushes for the different states of a `RadToggleButton` through the ThemeHelper class:

__Declare a SolidColorBrush to use as a StaticResource__
```XAML
	<SolidColorBrush x:Key="MyCheckedBrush" Color="#FFFF86B1"/>
```

__Set RadToggleButton's visual appearance through the ThemeHelper class__
```XAML
	<telerik:RadToggleButton Content="RadButton" 
							Margin="10"
							xmlns:helpers="clr-namespace:Telerik.Windows.Controls.Theming.Helpers;assembly=Telerik.Windows.Controls"
							helpers:ThemeHelper.MouseOverBrush="LightGoldenrodYellow"
							helpers:ThemeHelper.PressedBrush="{telerik:VisualStudio2019Resource ResourceKey=ValidationBrush}"
							helpers:ThemeHelper.CheckedBrush="{StaticResource MyCheckedBrush}"/>
```

__Appearance of the RadToggleButton in the different states__

![RadToggleButton States](/styling-and-appearance/images/styling-appearance-theme-helper-toggle-button-states.png)

## See Also

 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
 * [Style Manager]({%slug common-styling-apperance-setting-theme-wpf%})
 * [Themes Suite]({%slug common-styling-appearance-available-themes%})
 * [VisualStudio2019 Theme]({%slug common-styling-appearance-visualstudio2019-theme%})
 * [Material Theme]({%slug common-styling-appearance-material-theme%})
