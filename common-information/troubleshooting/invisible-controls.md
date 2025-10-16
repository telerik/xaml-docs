---
title: Missing Controls in the UI
page_title: Missing Controls in the UI
description: The article describes a common issue where Telerik controls are not visible in the view when usin NoXaml dlls.
slug: troubleshooting-invisible-controls
tags: missing, controls, invisible, troubleshooting
published: True
position: 0
---

# Missing Controls in the UI

This article will show you how to resolve the issue where the Telerik controls are missing from the UI. In specific cases some or all the Telerik controls could be missing from the application. In other words they are not displayed. This could happen in the following cases:

* When you set up a project for the first time.

* After upgrade to a newer version of UI for {{ site.framework_name }}.

* When you create a custom style that targets a Telerik control.

Usually, this means that you are using [NoXaml]({%slug xaml-vs-noxaml%}) dlls. But the concrete reason behind the missing controls could be different.

## Missing Resources

The most common reason behind this is a missing resource(s) in the application Resources collection. When using NoXaml dlls you will need to explicitly merge the corresponding resources as shown in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview %}) article. 

If you are upgrading or creating a project you could miss the fact that the referenced dlls are NoXaml and to miss merging the resources. In this case the Styles of the controls are not added in the application and therefore they don't have any UI defined. This is why the controls are missing.

__Example 1: Merging the resources required by RadCartesianChart in order to be displayed__
```XAML
	<Application>
		<Application.Resources>
			<ResourceDictionary>
				<ResourceDictionary.MergedDictionaries>
					<ResourceDictionary Source="/Telerik.Windows.Themes.Office2016;component/Themes/System.Windows.xaml"/>
					<ResourceDictionary Source="/Telerik.Windows.Themes.Office2016;component/Themes/Telerik.Windows.Controls.xaml"/>
					<ResourceDictionary Source="/Telerik.Windows.Themes.Office2016;component/Themes/Telerik.Windows.Controls.ChartView.xaml"/>
				</ResourceDictionary.MergedDictionaries>
			</ResourceDictionary>
		</Application.Resources>
	</Application>
```

>important Make sure that the ResourceDictionary files for all assemblies with UI components referenced in your project are merged in the resources.

## Missing BasedOn Setting

Sometimes only few controls could be missing. In that case it is highly possible that there is a Style that targets the controls but it doesn't inherit the default style. This happens because in NoXaml (implicit styles) scenario, the custom style completely overrides the default one. This means that the ControlTemplate of the element will be cleared unless you set it explicitly or [base the style on the default one]({%slug implicit-styles-styling-the-controls%}).

__Example 1: Base a custom RadComboBox Style to its default Style__
```XAML	
	<Style TargetType="telerik:RadComboBox" BasedOn="{StaticResource RadComboBoxStyle}">
    	<Setter Property="Foreground" Value="Red" />
	</Style>
```

> Generally, the Key of the control's default Style uses the following naming convention: *ControlName + Style*. Examples: *RadComboBoxStyle*, *BarSeriesStyle*, *GridViewRowStyle*, *RadTreeViewItemStyle*, etc.

# Clean and Build Your Project

After any Style related changes or dlls replacement in the project make sure that any information cached by Visual Studio is cleared. To do this you can manually delete the *bin* and *obj* folders of the project and then *Clean*, and *Build* it again.
