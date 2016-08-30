---
title: Setting a Theme with StyleManager
page_title: Setting a Theme with StyleManager
description: Setting a Theme with StyleManager
slug: common-styling-apperance-setting-theme-wpf
tags: setting,a,theme,with,stylemanager
published: True
position: 0
site_name: WPF
---

# Setting a Theme with StyleManager



This help article will show you how to set a built-in theme to Telerik UI for WPF. You  will also see code examples for these related topics:
      

* [Setting Instance-Specific Built-in Theme in XAML](#setting-instance-specific-built-in-theme-in-xaml)

* [Setting Instance-Specific Built-in Theme in the Code-Behind](#setting-instance-specific-built-in-theme-in-the-code-behind)

* [Setting Application-Wide Built-in Theme in the Code-Behind](#setting-application-wide-built-in-theme-in-the-code-behind)

Telerik __WPF controls__ support the following themes:
      

* __Office_Black__

* __Office_Blue__

* __Office_Silver__

* __Expression_Dark__

* __Summer__

* __Vista__

* __Windows 7__

* __Transparent__

* __Windows8__

* __Windows8Touch__

>The __Silverlight themes__ are located in separate assemblies so that the size of the control assembly is optimized (smaller). The __WPF themes__ are embedded in the control assemblies.

>important With **Q1 2014** the **Themes** folder, containing the standard themes used with StyleManager, is not provided in the installation package anymore. They can be separately downloaded from the UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} download page in your [Telerik account](http://www.telerik.com/account.aspx).        

In order to use one of the themes with the StyleManager you need to create a new WPF application or open an existing one and add a references to the assemblies with the desired Telerik __WPF controls__.
      

>You can reed more information about the control dependencies in the [Control Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) topic.
        

Now you are ready to use the themes either for a single control or for all controls in your application scope.

>The following examples use the __Vista__ theme.
        

## Setting Instance-Specific Built-in Theme in XAML

In order to change the theme of a single control in XAML you have to declare a resource of type __Theme__ and set an appropriate key. To complete this procedure, follow the instructions below.
        

1. Open the user control that hosts your control.
        

2. Declare one of the Telerik WPF controls and set the attached property __StyleManager.Theme__ value to __Vista__.
        

3. After executing all steps your code should be similar to __Example 1__:
        

#### __[XAML] Example 1: Changing the theme of a RadSlider to Vista in XAML__

{{region common-styling-apperance-setting-theme-wpf_0}}
	<UserControl x:Class="Test.SampeControl"
	    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	    xmlns:telerikControls="clr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls">
	    <Grid>
	
	        <telerikControls:RadSlider x:Name="radSlider"
	            telerikControls:StyleManager.Theme="Vista"/>
	
	    </Grid>
	</UserControl>
	{{endregion}}



## Setting Instance-Specific Built-in Theme in the Code-Behind

You can also choose to change the theme for the Telerik WPF controls in code-behind. To achieve this follow the brief steps described below.
        

1. Open your user control.
        

2. Make sure you have explicitly named the target control in XAML.
        

3. In the constructor of your user control place the following code:
        

#### __C#__

{{region common-styling-apperance-setting-theme-wpf_1}}
	StyleManager.SetTheme( radSlider, new VistaTheme() );
	{{endregion}}



#### __VB.NET__

{{region common-styling-apperance-setting-theme-wpf_2}}
	StyleManager.SetTheme(radSlider, New VistaTheme())
	{{endregion}}



__Figure 1__ shows the result of this approach.
        

Figure 1: RadSlider with Vista theme applied
![Common Styling Theming Setting Built In Theme 020 WPF](images/Common_StylingThemingSettingBuiltInTheme_020_WPF.png)

## Setting Application-Wide Built-in Theme in the Code-Behind

Changing the application theme is similar to changing the theme of single controls in WPF. However, changing the application theme has a much bigger impact as it affects all controls in the scope of your application. You should use the constructor of your application to set the desired theme. The steps below describe how to change the application theme:
        

1 Open your existing application or create a new one.
        

2 Open __MainWindow.xaml.cs__

>In this case __MainWindow.xaml.cs__ is your entry point for the application. If you wonder which is your startup window, open the __App.xaml__ file and see the __StartupUri__ attribute:
          

#### __XAML__

{{region common-styling-apperance-setting-theme-wpf_3}}
	<Application x:Class="Test.App"
	    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	    StartupUri="Window1.xaml">
	    <Application.Resources>
	
	    </Application.Resources>
	</Application>
	{{endregion}}



3 Declare the following code __before the InitializeComponent()__ call, depending on the name of your theme as follows:
        

#### __C#__

{{region common-styling-apperance-setting-theme-wpf_4}}
	StyleManager.ApplicationTheme = new VistaTheme();
	{{endregion}}



#### __VB.NET__

{{region common-styling-apperance-setting-theme-wpf_5}}
	StyleManager.ApplicationTheme = New VistaTheme()
	{{endregion}}



4 After properly executing the steps your __MainWindow__ class should be similar to __Example 2__:
        

#### __[C#] Example 2: Set application-specific theme__

{{region common-styling-apperance-setting-theme-wpf_6}}
	public partial class Window1 : Window
	{
	    public Window1()
	    {
	        StyleManager.ApplicationTheme = new VistaTheme();
	        InitializeComponent();
	    }
	}
	{{endregion}}



#### __[VB.NET] Example 2: Set application-specific theme__

{{region common-styling-apperance-setting-theme-wpf_7}}
	Public Partial Class Window1
	    Inherits Window
	    Public Sub New()
	        StyleManager.ApplicationTheme = New VistaTheme()
	        InitializeComponent()
	    End Sub
	End Class
	{{endregion}}



# See Also

 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})

 * [Setting a Theme on a Custom Control]({%slug styling-apperance-custom-control%})
