---
title: Setting a Theme with StyleManager
page_title: Setting a Theme with StyleManager
description: How to set a Telerik theme with StyleManager.
slug: common-styling-apperance-setting-theme-wpf
tags: setting,a,theme,with,stylemanager
published: True
position: 0
site_name: WPF
---

# Setting a Theme with StyleManager

This help article will show you how to set a built-in theme to Telerik UI for WPF. 

See the Telerik themes in the [Avilable Themes]({%slug common-styling-appearance-available-themes%}) article.

In order to use one of the themes with the StyleManager you need to add references to the Telerik assemblies in your WPF project. You can find more information about the control dependencies in the [Control Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) topic.

## Setting a Theme per Control

In order to change the theme of a single control in XAML you need to set the `StyleManager.Theme` attached property.

__Changing the theme of a RadSlider to Windows11 in XAML__  
```XAML	
	<telerikControls:RadSlider telerikControls:StyleManager.Theme="Windows11"/>	
```

The following example shows how to change the theme of a single control in code-behind. 

__Changing the theme of a RadSlider to Windows11 in code__  
```C#
	StyleManager.SetTheme(this.radSlider, new Windows11Theme() );
```
```VB.NET
	StyleManager.SetTheme(Me.radSlider, New Windows11Theme())
```

__RadSlider with Windows11 theme applied__  

![Common Styling Theming Setting Built In Theme 020 WPF](images/Common_StylingThemingSettingBuiltInTheme_020_WPF.png)

## Setting Application-Wide Theme

Changing the application theme is similar to changing the theme of single controls in WPF. However, changing the application theme has a much bigger impact as it affects all controls in the scope of your application. You can use the constructor of your application or the main window to set the desired theme. 

__Set application-specific theme in the MainWindow constructor__  
```C#
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			StyleManager.ApplicationTheme = new Windows11Theme();
			InitializeComponent();
		}
	}
```
```VB.NET
	Public Partial Class MainWindow
		Inherits Window
		Public Sub New()
			StyleManager.ApplicationTheme = New Windows11Theme()
			InitializeComponent()
		End Sub
	End Class
```

__Set application-specific theme in the App constructor__  
```C#	
	public App()
	{
		StyleManager.ApplicationTheme = new Windows11Theme();
		InitializeComponent();
	}
```
```VB.NET
	Public Class App
		Inherits Application
		Public Sub New()
			StyleManager.ApplicationTheme = New Windows11Theme()
			InitializeComponent()
		End Sub
	End Class
```
	
## See Also
 * [Setting a Theme (Using Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})