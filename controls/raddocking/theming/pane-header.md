---
title: Theming the Pane Header
page_title: Theming the Pane Header
description: Check our &quot;Theming the Pane Header&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-theming-pane-header
tags: theming,the,pane,header
published: True
position: 1
---

# Theming the Pane Header

To modify the appearance of the __PaneHeader__ you have to create a custom theme and place a style that targets the __PaneHeader__ control in it. The topic assumes that you have already created {% if site.site_name == 'WPF' %}a theme with{% endif %}{% if site.site_name == 'WPF' %}{% endif %} a __ResourceDictionary__ that will host the styles and the resources for your custom theme. If not take a look at the overview section about [creating the theme]({%slug raddocking-theming-overview%}#creating-the-theme). The topic also assumes that you have already created the style that will be used for the __PaneHeader__ control. To learn how to style it take a look at the [Styling the Pane Header]({%slug raddocking-styling-the-pane-header%}) topic.

Copy the created style with all of the resources it uses and place it in the __ResourceDictionary__ that represents the theme for your __RadDocking__ control.



```XAML
	<ResourceDictionary xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
	    <!--Paste the style and all of the resources it uses here. -->
	    <Style x:Key="PaneHeaderStyle" TargetType="telerik:PaneHeader">
	        <!--...-->
	    </Style>
	</ResourceDictionary>
```

The next step is to declare the required namespaces in the __ResourceDictionary__.



```XAML
	<ResourceDictionary xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	    xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
	    <!--...-->
	</ResourceDictionary>
```

{% if site.site_name == 'Silverlight' %}

Finally in order to make the style default for all of the __PaneHeader__ controls you have to leave it without a key. Remove the key from the style.{% endif %}



```XAML
	<Style TargetType="telerik:PaneHeader">
	    <!--...-->
	</Style>
```

{% if site.site_name == 'Silverlight' %}

To apply the theme go to the UserControl that hosts your __RadDocking__ control and set it through the code-behind.{% endif %}



```C#
	public App()
	{
	    InitializeComponent();
	    StyleManager.SetTheme(this.radDocking, new RadDockingTheme());
	}
```



```VB.NET
	Public Sub New()
		InitializeComponent()
		StyleManager.SetTheme(Me.radDocking, New Theme())
	End Sub
	
	Private Property radDocking As DependencyObject
```

{% if site.site_name == 'WPF' %}

Finally in order to make the style default for all of the __PaneHeader__ controls you have to set it to the following value.{% endif %}



```XAML
	<Style x:Key="{telerik:ThemeResourceKey ThemeType={x:Type local:RadDockingTheme}, ElementType={x:Type telerik:PaneHeader}}"
	       TargetType="{x:Type telerik:PaneHeader}">
	    <!--...-->
	</Style>
```

{% if site.site_name == 'WPF' %}

To see how to apply the theme read [here](#ApplyingTheme).{% endif %}

Here is a snapshot of a sample result.

![{{ site.framework_name }} RadDocking Themed Pane Header](images/RadDocking_ThemingPaneHeader_01.png)

## See Also

 * [Theming - Overview]({%slug raddocking-theming-overview%})

 * [Styling the Pane Header]({%slug raddocking-styling-the-pane-header%})

 * [How to Add Icon to the RadPane's Header]({%slug raddocking-how-to-add-icon-pane-header%})

 * [How to Add Buttons to the Pane Header]({%slug raddocking-how-to-add-buttons-to-the-pane-headers%})
