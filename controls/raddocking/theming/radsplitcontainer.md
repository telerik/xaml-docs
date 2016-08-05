---
title: Theming the RadSplitContainer
page_title: Theming the RadSplitContainer
description: Theming the RadSplitContainer
slug: raddocking-theming-radsplitcontainer
tags: theming,the,radsplitcontainer
published: True
position: 4
---

# Theming the RadSplitContainer

To modify the appearance of the __RadSplitContainer__ you have to create a custom theme and place a style that targets the __RadSplitContainer__ control in it. The topic assumes that you have already created {% if site.site_name == 'WPF' %}a theme with {% endif %}a __ResourceDictionary__ that will host the styles and the resources for your custom theme. If not take a look at the overview section about [creating the theme](#CreatingTheme). The topic also assumes that you have already created the style that will be used for the __RadSplitContainer__ control. To learn how to style it take a look at the [Styling the RadSplitContainer]({%slug raddocking-styling-the-radsplitcontainer%}) topic.

Copy the created style with all of the resources it uses and place it in the __ResourceDictionary__ that represents the theme for your __RadDocking__ control.

#### __XAML__

{{region xaml-raddocking-theming-radsplitcontainer_0}}
	<ResourceDictionary xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	                    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
	    <!--Paste the style and all of the resources it uses here. --> 
	    <Style x:Key="RadSplitContainerStyle" TargetType="telerik:RadSplitContainer">
	        ...
	    </Style>
	</ResourceDictionary>
{{endregion}}

The next step is to declare the required namespaces in the resource dictionary.

#### __XAML__

{{region xaml-raddocking-theming-radsplitcontainer_1}}
	<ResourceDictionary xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	                    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	                    xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
	      ...
	</ResourceDictionary>
{{endregion}}

{% if site.site_name == 'Silverlight' %}

Finally, in order to make the style default for all of the __RadSplitContainer__ controls you have to leave it without a key. Remove the key from the style.{% endif %}

#### __XAML__

{{region xaml-raddocking-theming-radsplitcontainer_2}}
	<Style TargetType="telerik:RadSplitContainer">
	        ...
	</Style>
{{endregion}}

{% if site.site_name == 'Silverlight' %}

To apply the theme got to the UserControl that hosts your __RadDocking__ control and set it through the code-behind.{% endif %}

#### __C#__

{{region cs-raddocking-theming-radsplitcontainer_3}}
	public StylingRadPaneGroup()
	{
	    InitializeComponent();
	    StyleManager.SetTheme( this.radDocking, new Theme( new Uri( "/RadDockingSample;component/Themes/RadDockingTheme.xaml", UriKind.Relative ) ) );
	}
{{endregion}}

#### __VB.NET__

{{region vb-raddocking-theming-radsplitcontainer_4}}
	Public Sub New()
	    InitializeComponent()
	    StyleManager.SetTheme(Me.radDocking, New Theme(New Uri("/RadDockingSample;component/Themes/RadDockingTheme.xaml", UriKind.Relative)))
	End Sub
{{endregion}}

{% if site.site_name == 'WPF' %}

Finally in order to make the style default for all of the __RadSplitContainer__controls you have to set it to the following value.{% endif %}

#### __XAML__

{{region xaml-raddocking-theming-radsplitcontainer_5}}
	<Style x:Key="{telerik:ThemeResourceKey ThemeType={x:Type local:RadDockingTheme}, ElementType={x:Type telerik:RadSplitContainer}}"
	       TargetType="{x:Type telerik:RadSplitContainer}">
	    ...
	</Style>
{{endregion}}

{% if site.site_name == 'WPF' %}

To see how to apply the theme read [here](#ApplyingTheme).{% endif %}

Here is a snapshot of a sample result.

![](images/RadDocking_ThemingSplitContainer_01.png)

# See Also

 * [Theming - Overview]({%slug raddocking-theming-overview%})

 * [Styling the RadSplitContainer]({%slug raddocking-styling-the-radsplitcontainer%})

 * [Split Container]({%slug raddocking-features-split-container%})
