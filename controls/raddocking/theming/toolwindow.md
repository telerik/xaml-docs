---
title: Theming the ToolWindow
page_title: Theming the ToolWindow
description: Theming the ToolWindow
slug: raddocking-theming-toolwindow
tags: theming,the,toolwindow
published: True
position: 3
---

# Theming the ToolWindow

To modify the appearance of the ToolWindow you __have__ to create a custom theme and place a style that targets the __ToolWindow__ control in it. The topic assumes that you have already created {% if site.site_name == 'WPF' %}a theme with{% endif %}{% if site.site_name == 'WPF' %}{% endif %}a __ResourceDictionary__ that will host the styles and the resources for your custom theme. If not take a look at the overview section about [creating the theme](#CreatingTheme). The topic also assumes that you have created the style that will be used for the __ToolWindow__ control. To learn how to style it take a look at the [Styling the ToolWindow]({%slug raddocking-theming-toolwindow%}) topic.

Copy the created style with all of the resources it uses and place it in the __ResourceDictionary__ that represents the theme for your __RadDocking__ control.

#### __XAML__

{{region xaml-raddocking-theming-toolwindow_0}}
	<ResourceDictionary xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	                    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
	    <!--Paste the style and all of the resources it uses here. --> 
	    <Style x:Key="ToolWindowStyle" TargetType="telerik:ToolWindow">
	        ...
	    </Style>
	</ResourceDictionary>
{{endregion}}

The next step is to declare the required namespaces in the resource dictionary.

#### __XAML__

{{region xaml-raddocking-theming-toolwindow_1}}
	<ResourceDictionary xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	                    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	                    xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
	      ...
	</ResourceDictionary>
{{endregion}}

{% if site.site_name == 'Silverlight' %}

Finally, in order to make the style default for all of the __ToolWindow__ controls you have to leave it without a key. Remove the key from the style.{% endif %}

#### __XAML__

{{region xaml-raddocking-theming-toolwindow_2}}
	<Style TargetType="telerik:ToolWindow">
	        ...
	</Style>
{{endregion}}

{% if site.site_name == 'Silverlight' %}

To apply the theme go to the UserControl that hosts your __RadDocking__ control and set it through the code-behind.{% endif %}

#### __C#__

{{region cs-raddocking-theming-toolwindow_3}}
	public StylingRadPaneGroup()
	{
	    InitializeComponent();
	    StyleManager.SetTheme( this.radDocking, new Theme( new Uri( "/RadDockingSample;component/Themes/RadDockingTheme.xaml", UriKind.Relative ) ) );
	}
{{endregion}}

#### __VB.NET__

{{region vb-raddocking-theming-toolwindow_4}}
	Public Sub New()
	    InitializeComponent()
	    StyleManager.SetTheme(Me.radDocking, New Theme(New Uri("/RadDockingSample;component/Themes/RadDockingTheme.xaml", UriKind.Relative)))
	End Sub
{{endregion}}

{% if site.site_name == 'WPF' %}

Finally in order to make the style default for all of the __ToolWindow__controls you have to set it to the following value.{% endif %}

#### __XAML__

{{region xaml-raddocking-theming-toolwindow_5}}
	<Style x:Key="{telerik:ThemeResourceKey ThemeType={x:Type local:RadDockingTheme}, ElementType={x:Type telerik:ToolWindow}}"
	       TargetType="{x:Type telerik:ToolWindow}">
	    ...
	</Style>
{{endregion}}

{% if site.site_name == 'WPF' %}

To see how to apply the theme read [here](#ApplyingTheme).{% endif %}

Here is a snapshot of a sample result.

![](images/RadDocking_ThemingToolWindow_01.png)

# See Also

 * [Theming - Overview]({%slug raddocking-theming-overview%})

 * [Styling the ToolWindow]({%slug raddocking-styling-the-toolwindow%})

 * [Tool Window]({%slug raddocking-features-tool-window%})

 * [Docked/Floating Panes]({%slug raddocking-features-panes-docked-floating-panes%})
