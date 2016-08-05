---
title: Theming the RadPaneGroup
page_title: Theming the RadPaneGroup
description: Theming the RadPaneGroup
slug: raddocking-theming-radpane-group
tags: theming,the,radpanegroup
published: True
position: 2
---

# Theming the RadPaneGroup

To modify the appearance of the __RadPaneGroup__ you have to create a custom theme and place a style that targets the __RadPaneGroup__ control in it. The topic assumes that you have created {% if site.site_name == 'WPF' %}a theme with{% endif %}{% if site.site_name == 'WPF' %}{% endif %}a __ResourceDictionary__ that will host the styles and the resources for your custom theme. If not take a look at the overview section about [creating the theme](#CreatingTheme). The topic also assumes that you have created the style that will be used for the __RadPaneGroup__ control. To learn how to style it read the [Styling the RadPaneGroup]({%slug raddocking-styling-the-radpanegroup%}) topic.

Copy the created style with all of the resources it uses and place it in the __ResourceDictionary__ that represents the theme for your __RadDocking__ control.

#### __XAML__

{{region xaml-raddocking-theming-radpane-group_0}}
	<ResourceDictionary xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	                    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
	    <!--Paste the style and all of the resources it uses here. -->
	    <Style x:Key="RadPaneGroupStyle" TargetType="telerik:RadPaneGroup">
	        <!--...-->
	    </Style>
	</ResourceDictionary>
{{endregion}}

The next step is to declare the required namespaces in the resource dictionary.

#### __XAML__

{{region xaml-raddocking-theming-radpane-group_1}}
	<ResourceDictionary xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	    xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
	    <!--...-->
	</ResourceDictionary>
{{endregion}}

{% if site.site_name == 'Silverlight' %}

Finally, in order to make the style default for all of the __RadPaneGroup__ controls you have to leave it without a key. Remove the key from the style.{% endif %}

#### __XAML__

{{region xaml-raddocking-theming-radpane-group_2}}
	<Style TargetType="telerik:RadPaneGroup">
	    <!--...-->
	</Style>
{{endregion}}

{% if site.site_name == 'Silverlight' %}

To apply the theme go to the UserControl that hosts your __RadDocking__ control and set it through the code-behind.{% endif %}

#### __C#__

{{region cs-raddocking-theming-radpane-group_3}}
	public App()
	{
	    InitializeComponent();
	    StyleManager.SetTheme( this.radDocking, new RadDockingTheme());
	}
{{endregion}}

#### __VB.NET__

{{region vb-raddocking-theming-radpane-group_4}}
	Public Sub New()
		InitializeComponent()
		StyleManager.SetTheme(Me.radDocking, New Theme())
	End Sub
{{endregion}}

{% if site.site_name == 'WPF' %}

Finally in order to make the style default for all of the __RadPaneGroup__ controls you have to set it to the following value.{% endif %}

#### __XAML__

{{region xaml-raddocking-theming-radpane-group_5}}
	<Style x:Key="{telerik:ThemeResourceKey ThemeType={x:Type local:RadDockingTheme}, ElementType={x:Type telerik:RadPaneGroup}}"
	TargetType="{x:Type telerik:RadPaneGroup}">
	    <!--...-->
	</Style>
{{endregion}}

{% if site.site_name == 'WPF' %}

To see how to apply the theme read [here](#ApplyingTheme).{% endif %}

Here is a snapshot of a sample result.

![](images/RadDocking_ThemingRadPaneGroup_01.png)

# See Also

 * [Theming - Overview]({%slug raddocking-theming-overview%})

 * [Styling the RadPaneGroup]({%slug raddocking-styling-the-radpanegroup%})

 * [Pane Groups]({%slug raddocking-features-pane-groups%})
