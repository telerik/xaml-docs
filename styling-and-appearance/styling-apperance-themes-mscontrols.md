---
title: Setting a Theme on MS Controls
page_title: Setting a Theme on MS Controls
description: This article explains how to set the theme on MS controls which are not supported by the Telerik theming mechanism.
slug: styling-apperance-themes-mscontrols
tags: setting,a,theme,on,ms,controls
published: False
position: 9
---

# Setting a Theme on MS Controls

The __Telerik themes__ are designed to work mainly with our controls and some native {{ site.framework_name }} controls. Our theming mechanism cannot cover the full control list included in {{ site.framework_name }}.
	

## Native controls supported by the Telerik theming mechanism

Below is the full control list of native {{ site.framework_name }} controls supported by the Telerik theming mechanism:
		

* System.Windows.Button

* System.Windows.ScrollViewer

* System.Windows.CheckBox

* System.Windows.TextBox

* System.Windows.RadioButton

* System.Windows.ListBox

* System.Windows.PasswordBox

* System.Windows.RepeatButton

* System.Windows.Tooltip{% if site.site_name == 'WPF' %}

* System.Windows.Controls.Primitives.StatusBar

* System.Windows.Controls.Separator

* System.Windows.Controls.GridSplitter{% endif %}

For all of those controls you may __specify a Theme for them__ as you may for any Telerik control.
		

>Before proceeding with this tutorial, please check the [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%}) topic.
		  

If you want to style those native controls based on the current application theme using [Implicit Styles and NoXaml Binaries]({%slug styling-apperance-implicit-styles-overview%}), you should also merge the __System.Windows.xaml__ resource dictionary. For example:
		

#### __XAML__

```XAML
	<Application.Resources>
	  <ResourceDictionary>
	    <ResourceDictionary.MergedDictionaries>
	      <ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/System.Windows.xaml"/>
	      ...
	    </ResourceDictionary.MergedDictionaries>
	  </ResourceDictionary>
	</Application.Resources>
	```

> If you want to customize the style of the native controls and keep the Telerik theming you should base your custom styles on the default style that the theme provides as explained in the [Styling the Controls article]({%slug implicit-styles-styling-the-controls%}). For example, the x:Key of the TextBox style is __TextBoxStyle__.

## See Also

 * [Use StyleManager to Apply Theme on MS Controls]({%slug common-styling-themes-mscontrols%})

 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})

 * [Switching Themes at Runtime]({%slug styling-apperance-themes-runtime%})
