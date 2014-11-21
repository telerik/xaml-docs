---
title: Use StyleManager to Apply Theme on MS Controls
page_title: Use StyleManager to Apply Theme on MS Controls
description: Use StyleManager to Apply Theme on MS Controls
slug: common-styling-themes-mscontrols
tags: use,stylemanager,to,apply,theme,on,ms,controls
published: True
position: 3
---

# Use StyleManager to Apply Theme on MS Controls

 The __Telerik themes__ are designed to work mainly with our controls and some native {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} controls. Our theming mechanism cannot cover the full control list included in {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}.
    

## Native controls supported by the Telerik theming mechanism

Below is the full control list of native {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} controls supported by the Telerik theming mechanism:
        

* System.Windows.Button
          

* System.Windows.ScrollViewer
          

* System.Windows.CheckBox
          

* System.Windows.TextBox
          

* System.Windows.RadioButton
          

* System.Windows.ListBox
          

* System.Windows.PasswordBox
          

* System.Windows.RepeatButton
          

* System.Windows.Tooltip
          

For all of those controls you may __specify the theme for them__ as you may for any Telerik control.

When you apply an __Application theme__ at runtime, though, only Telerik controls will be styled - not the native ones supported by our theming mechanism. If you want to style those native controls based on the current application theme, you should manually set the corresponding theme. For example, the code for a Button would be like so: {% if site.site_name == 'Silverlight' %}



#### __XAML__

{{region common-styling-themes-mscontrols_1}}
	<Application xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	             xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	             x:Class="RadCalcTest.App">
	    <Application.Resources>
	        <Style TargetType="Button"/>
	    </Application.Resources>
	</Application>
	{{endregion}}





#### __C#__

{{region common-styling-themes-mscontrols_2}}
	public App()
      {
          this.Startup += this.Application_Startup;
          this.Exit += this.Application_Exit;
          this.UnhandledException += this.Application_UnhandledException;
          StyleManager.ApplicationTheme = new Windows7Theme();
          InitializeComponent();
         StyleManager.SetBasedOn(((Style)Current.Resources[typeof(Button)]), StyleManager.ApplicationTheme);
      }
	{{endregion}}



#### __VB.NET__

{{region common-styling-themes-mscontrols_3}}
    Public Sub New()
        Me.Startup += Me.Application_Startup
        Me.[Exit] += Me.Application_Exit
        Me.UnhandledException += Me.Application_UnhandledException
        StyleManager.ApplicationTheme = New Windows7Theme()
        InitializeComponent()
        StyleManager.SetBasedOn(DirectCast(Current.Resources(GetType(Button)), Style), StyleManager.ApplicationTheme)
    End Sub
	{{endregion}}

{% endif %}{% if site.site_name == 'WPF' %}



#### __XAML__

{{region common-styling-themes-mscontrols_4}}
	<Window.Resources>
		<telerik:Expression_DarkTheme x:Key="Theme" />
		<Style TargetType="Button">
	        <Setter Property="telerik:StyleManager.Theme" Value="{StaticResource Theme}"/>
	    </Style>
	</Window.Resources>
	{{endregion}}

{% endif %}

# See Also

 * [Setting a Theme on MS Controls using Implicit Styles]({%slug styling-apperance-themes-mscontrols%})

 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})

 * [Setting a Theme with StyleManager]({%slug common-styling-apperance-setting-theme%})

 * [Modifying a Built-In Theme]({%slug common-styling-apperance-modifying-built-in-theme%})
