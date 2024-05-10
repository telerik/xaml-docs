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

This help article will show you how to set a built-in theme to Telerik UI for WPF. You will also see code examples for these related topics:      

* [Setting Instance-Specific Built-in Theme in XAML](#setting-instance-specific-built-in-theme-in-xaml)

* [Setting Instance-Specific Built-in Theme in the Code-Behind](#setting-instance-specific-built-in-theme-in-the-code-behind)

* [Setting Application-Wide Built-in Theme in the Code-Behind](#setting-application-wide-built-in-theme-in-the-code-behind)

See the Telerik themes in the [Avilable Themes]({%slug common-styling-appearance-available-themes%}) article.

In order to use one of the themes with the StyleManager you need to add references to the Telerik assemblies in your WPF project. You can find more information about the control dependencies in the [Control Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) topic.

## Setting a Theme per Control

In order to change the theme of a single control in XAML you need to set the `StyleManager.Theme` attached property.

#### __[XAML] Changing the theme of a RadSlider to Windows11 in XAML__  
{{region common-styling-apperance-setting-theme-wpf_0}}	
	<telerikControls:RadSlider telerikControls:StyleManager.Theme="Windows11"/>	
{{endregion}}

The following example shows how to change the theme of a single control in code-behind. 

#### __[C#] Changing the theme of a RadSlider to Windows11 in code__  
{{region common-styling-apperance-setting-theme-wpf_1}}
	StyleManager.SetTheme(this.radSlider, new Windows11Theme() );
{{endregion}}

#### __[VB.NET] Changing the theme of a RadSlider to Windows11 in code__  
{{region common-styling-apperance-setting-theme-wpf_2}}
	StyleManager.SetTheme(Me.radSlider, New Windows11Theme())
{{endregion}}

__RadSlider with Windows11 theme applied__  

![Common Styling Theming Setting Built In Theme 020 WPF](images/Common_StylingThemingSettingBuiltInTheme_020_WPF.png)

## Setting Application-Wide Theme

Changing the application theme is similar to changing the theme of single controls in WPF. However, changing the application theme has a much bigger impact as it affects all controls in the scope of your application. You can use the constructor of your application or the main window to set the desired theme. 

#### __[C#] Set application-specific theme in the MainWindow constructor__  
{{region common-styling-apperance-setting-theme-wpf_3}}
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			StyleManager.ApplicationTheme = new Windows11Theme();
			InitializeComponent();
		}
	}
{{endregion}}

#### __[VB.NET] Set application-specific theme in the MainWindow constructor__  
{{region common-styling-apperance-setting-theme-wpf_4}}
	Public Partial Class MainWindow
		Inherits Window
		Public Sub New()
			StyleManager.ApplicationTheme = New Windows11Theme()
			InitializeComponent()
		End Sub
	End Class
{{endregion}}

#### __[C#] Set application-specific theme in the App constructor__  
{{region common-styling-apperance-setting-theme-wpf_5}}	
	public App()
	{
		StyleManager.ApplicationTheme = new Windows11Theme();
		InitializeComponent();
	}
{{endregion}}

#### __[VB.NET] Set application-specific theme in the App constructor__  
{{region common-styling-apperance-setting-theme-wpf_6}}
	Public Class App
		Inherits Application
		Public Sub New()
			StyleManager.ApplicationTheme = New Windows11Theme()
			InitializeComponent()
		End Sub
	End Class
{{endregion}}
	
## See Also
 * [Setting a Theme (Using Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})