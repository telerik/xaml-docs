---
title: Use StyleManager to Apply Theme on MS Controls
page_title: Use StyleManager to Apply Theme on MS Controls
description: This article demonstrates how to use the StyleManager theming mechanism to apply a theme on MS controls.
slug: common-styling-themes-mscontrols
tags: use,stylemanager,to,apply,theme,on,ms,controls
published: True
position: 3
---

# Use StyleManager to Apply Theme on MS Controls

 The __Telerik themes__ are designed to work mainly with our controls and some native WPF controls. Our theming mechanism cannot cover the full control list included in WPF.    

## Native controls supported by the Telerik theming mechanism

Below is the full control list of native WPF controls supported by the Telerik theming mechanism:        

* System.Windows.Controls.Button

* System.Windows.Controls.ScrollViewer

* System.Windows.Controls.CheckBox

* System.Windows.Controls.TextBox

* System.Windows.Controls.RadioButton

* System.Windows.Controls.ListBox

* System.Windows.Controls.PasswordBox

* System.Windows.Controls.Primitives.RepeatButton

* System.Windows.Controls.Tooltip

* System.Windows.Documents.Hyperlink

* System.Windows.Controls.Primitives.StatusBar

* System.Windows.Controls.GridSplitter

* System.Windows.Controls.Separator

For all of those controls you may __specify the theme for them__ as you may for any Telerik control.

When you apply an __Application theme__ at runtime, though, only Telerik controls will be styled - not the native ones supported by our theming mechanism. If you want to style those native controls based on the current application theme, you should manually set the corresponding theme. For example, the code for a Button would be like so:

```XAML
	<Window.Resources>
		<telerik:Expression_DarkTheme x:Key="Theme" />
		<Style TargetType="Button">
	        <Setter Property="telerik:StyleManager.Theme" Value="{StaticResource Theme}"/>
	    </Style>
	</Window.Resources>
```

## See Also  
 * [Setting a Theme on MS Controls using Implicit Styles]({%slug styling-apperance-themes-mscontrols%})
 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
 * [Setting a Theme with StyleManager]({%slug common-styling-apperance-setting-theme%})
