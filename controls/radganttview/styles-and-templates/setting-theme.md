---
title: Setting a Theme
page_title: Setting a Theme
description: Check our &quot;Setting a Theme&quot; documentation article for the RadGanttView {{ site.framework_name }} control.
slug: radganttview-styles-and-templates-setting-theme
tags: setting,a,theme
published: True
position: 0
---

# Setting a Theme

The purpose of this article is to show you how to set a built-in theme to __RadGanttView__ for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}.

>tip Detailed information about the use of implicit styles can be found {% if site.site_name == 'Silverlight' %}[here](http://www.telerik.com/help/silverlight/styling-apperance-implicit-styles-overview.html){% endif %}{% if site.site_name == 'WPF' %}[here](http://www.telerik.com/help/wpf/styling-apperance-implicit-styles-overview.html){% endif %}.

So, in order to set a theme to the GanttView, you should merge the following xaml files in App.xaml file:

* System.Windows.xaml

* Telerik.Windows.Controls.xaml

* Telerik.Windows.Controls.GanttView.xaml

There are two ways to reference the needed xaml files:

* Directly from the theme assembly:

	Let's, for example, apply Windows8 theme to the control. This means that we should add a reference to Telerik.Windows.Themes.Windows8.dll as well:

	![ganttview setting theme 1](images/ganttview_setting_theme_1.png)

	Then merge the xaml files in the App.xaml like this:

	```XAML
		<Application.Resources>
		    <ResourceDictionary>
		        <ResourceDictionary.MergedDictionaries>
		            <ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/System.Windows.xaml"/>
		            <ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml"/>
		            <ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.GanttView.xaml"/>
		        </ResourceDictionary.MergedDictionaries>
		    </ResourceDictionary>
		</Application.Resources>
	```

* Copy the xaml files to a folder in the project:

	Create a Theme folder and copy the required files from __Themes.Implicit/../Windows8/../Themes/__ folder located in the installation folder of UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}:
	
	![ganttview setting theme 2](images/ganttview_setting_theme_2.png)
	
	Then merge the xaml files in the App.xaml like this:

	```XAML
		<Application.Resources>
		    <ResourceDictionary>
		        <ResourceDictionary.MergedDictionaries>
		            <ResourceDictionary Source="Themes/System.Windows.xaml" />
		            <ResourceDictionary Source="Themes/Telerik.Windows.Controls.xaml" />
		            <ResourceDictionary Source="Themes/Telerik.Windows.Controls.GanttView.xaml" />
		        </ResourceDictionary.MergedDictionaries>
		    </ResourceDictionary>
		</Application.Resources>
	```

Either way you choose, the end result will be the following:

![ganttview metro theme](images/ganttview_metro_theme.png)