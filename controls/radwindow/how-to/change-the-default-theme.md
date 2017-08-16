---
title: Change the Default Theme
page_title: Change the Default Theme
description: Change the Default Theme
slug: radwindow-how-to-change-the-default-theme
tags: change,the,default,theme
published: True
position: 1
---

# Change the Default Theme

You can easily change the theme of __RadWindow__ to one of the predefined themes for UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} using the [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}).

So, in order to set a theme to the Window, you should merge the following xaml files in App.xaml file: 

* Telerik.Windows.Controls.xaml

* Telerik.Windows.Controls.Navigation.xaml

>As RadWindow is placed in a different visual tree than the UserControl it is opened from, the xaml files should be merged in App.xaml, if you merge them locally in the UserControl Resources, RadWindow will not receive its Style.

So merging the mentioned xaml files, for example, for __Windows8__ theme:

#### __XAML__

{{region xaml-radwindow-how-to-change-the-default-theme_0}}
	<Application>
	    <Application.Resources>
	        <ResourceDictionary>
	            <ResourceDictionary.MergedDictionaries>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml"/>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.Navigation.xaml"/>
	            </ResourceDictionary.MergedDictionaries>
	        </ResourceDictionary>
	    </Application.Resources>
	</Application>
{{endregion}}

And opening a RadWindow:

#### __C#__

{{region cs-radwindow-how-to-change-the-default-theme_1}}
	var window = new RadWindow()
	{
	    Width = 300,
	    Height = 300
	};
	window.Show();
{{endregion}}

#### __VB.NET__

{{region vb-radwindow-how-to-change-the-default-theme_4}}
	Dim newWindow As New RadWindow() With {
	    .Width = 300,
	    .Height = 300
	}
	newWindow.Show()
{{endregion}}

Here is a snapshot of the result.

![](images/RadWindow_How_To_Change_the_Default_Theme_01.png)

If you have __RadWindow__ as an user control like this:

#### __XAML__

{{region xaml-radwindow-how-to-change-the-default-theme_2}}
	<telerik:RadWindow x:Class="RadWindowSamples.RadWindowControl"
	   xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	   xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	   xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
	</telerik:RadWindow>
{{endregion}}

it will not receive automatically the Window style. You should add the following Style after the merged dictionaries to fix this:

#### __XAML__

{{region xaml-radwindow-how-to-change-the-default-theme_3}}
	<Application>
	    <Application.Resources>
	        <ResourceDictionary>
	            <ResourceDictionary.MergedDictionaries>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml"/>
	                <ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.Navigation.xaml"/>
	            </ResourceDictionary.MergedDictionaries>
	            <Style TargetType="local:RadWindowControl" BasedOn="{StaticResource RadWindowStyle}" />
	        </ResourceDictionary>
	    </Application.Resources>
	</Application>
{{endregion}}

The important part is setting __TargetType__ property to the type of the user control.

>tipTo learn more about how to use the __RadWindow__ as user control read [this topic]({%slug radwindow-how-to-use-radwindow-as-user-control%}).

## See Also

 * [Styles and Templates - Overview]({%slug radwindow-styles-and-templates-overview%})

 * [Template Structure]({%slug radwindow-styles-and-templates-template-structure%})

 * [Styling the RadWindow]({%slug radwindow-styles-and-templates-styling-the-radwindow%})

 * [Styling the Predefined Windows]({%slug radwindow-styles-and-templates-styling-the-predefined-windows%})
