---
title: Switching Themes at Design-time
page_title: Switching Themes at Design-time
description: Switching Themes at Design-time
slug: styling-apperance-swiching-themes-design-time
tags: styling,apperance,switch,switching,theme,themes,time,design,design-time,vs
published: True
position: 2
---

# Switching Themes at Design-time

With R2 2016 we introduced a mechanism that allows you to change the application theme at design-time with a few clicks.

> This mechanism is available only when the [implicit styles theming]({%slug styling-apperance-implicit-styles-overview%}) is used. In order to use it you will need to reference the NoXaml version of the Telerik assemblies. 

The following example demonstrates how the feature works in few easy steps.

1. Select a Rad-control in the Visual Studio designer at design-time. This will display the Theme button at the designer's top right corner.  
	![](images/styling-apperance-switching-themes-design-time-01.png)
	
2. Click on the __Theme__ button. This will open the Themes window where you can choose a theme.  
	![](images/styling-apperance-switching-themes-design-time-02.png)
	
3. Select a theme and click __OK__. 

This will automatically add the new theme dll in the references of the project and merge the required resource dictionaries in the __App.xaml resources__.

#### __Figure 1: The added theme assembly reference__
![](images/styling-apperance-switching-themes-design-time-03.png)

#### __[XAML] Example 1: The merged theme resources__
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Green;component/Themes/System.Windows.xaml" />
				<ResourceDictionary Source="/Telerik.Windows.Themes.Green;component/Themes/Telerik.Windows.Controls.xaml" />
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>

{% if site.site_name == 'WPF' %}> You can change the theme also by using the [Project Configuration Wizard]({%slug radcontrols-for-wpf-vs-extensions-project-configuration%}).{% endif %}
	
## See Also
* [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%})
* [Switching Themes at Runtime]({%slug styling-apperance-themes-runtime%})
* [Editing Control Templates]({%slug styling-apperance-editing-control-templates%})
