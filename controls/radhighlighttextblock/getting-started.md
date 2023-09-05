---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadHighlightTextBlock control.
slug: radhighlighttextblock-getting-started
tags: getting started, radhighlighttextblock
published: True
position: 2
---

# Getting Started with {{ site.framework_name }} RadHighlightTextBlock

This tutorial will walk you through the creation of a sample application that contains a `RadHighlightTextBlock` control.

## Assembly References

To use RadHighlightTextBlock, add a reference to the following assembly:

* __Telerik.Windows.Controls__

## Defining the RadHighlightTextBlock as a Stand-Alone Component

You can add RadHighlightTextBlock manually in XAML as demonstrated in the following example:

#### __[XAML] Adding RadHighlightTextBlock in XAML__
{{region radhighlighttextblock-getting-started-0}}
    <telerik:RadHighlightTextBlock/>
{{endregion}}

## Setting Text and Highlighting Part of It

The RadHighlightTextBlock control displays a text via its `Text` property. It will match and highlight part of the presented text by the value that is set to its `HighlightText` property.

#### __[XAML] Setting text and highlighting part of it__
{{region radhighlighttextblock-getting-started-1}}
    <telerik:RadHighlightTextBlock Text="Thank you for choosing Telerik UI for WPF." HighlightText="Telerik UI for WPF"/>
{{endregion}}

__RadHighlightTextBlock with a highlighted match__

![{{ site.framework_name }} RadHighlightTextBlock with a highlighted match](images/radhighlighttextblock-getting-started-0.png)

## Changing the Highlight Background and the Highlight Foreground Colors

The RadHighlightTextBlock exposes two properties that will allow you to change the color of the foreground and background of the highlighted matches. To do so, set the `HighlightBackground` and `HighlightForeground` properties.

#### __[XAML] Setting the HighlightBackground and HighlightForeground properties__
{{region radhighlighttextblock-getting-started-2}}
	<telerik:RadHighlightTextBlock Text="Thank you for choosing Telerik UI for WPF." 
	                               HighlightText="Telerik UI for WPF"
	                               HighlightBackground="LightCyan"
	                               HighlightForeground="Red"/>
{{endregion}}

__RadHighlightTextBlock with custom brushes for the HighlightBackground and HighlightForeground properties__

![{{ site.framework_name }} RadHighlightTextBlock with custom brushes for the HighlightBackground and HighlightForeground properties](images/radhighlighttextblock-getting-started-1.png)

## Highlighting Mode

RadHighlightTextBlock allows you to control how the highlighting will be applied. To the first found match, the last found one, or all occurrences. To control this behavior, set the `HighlightMode` property. The available options are `FirstMatch`, `LastMatch`, and `AllMatches`. The default value is `FirstMatch`.

#### __[XAML] Setting the HighlightMode to AllMatches__
{{region radhighlighttextblock-getting-started-3}}
	<telerik:RadHighlightTextBlock HighlightMode="AllMatches"
                               	   Text="Thank you for choosing Telerik UI for WPF. To learn mode please visit the Telerik UI for WPF product overview page."
                                   HighlightText="Telerik UI for WPF"/>
{{endregion}}

__RadHighlightTextBlock with highlighting all the matches__

![{{ site.framework_name }} RadHighlightTextBlock with highlighting all the matches](images/radhighlighttextblock-getting-started-2.png)

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

* Choose between the themes and add reference to the corresponding theme assembly (ex: __Telerik.Windows.Themes.Windows8.dll__). You can see the different themes applied in the __Theming__ examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#PanelBar/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the RadHighlightTextBlock, you will need to merge the following resources:

	* __Telerik.Windows.Controls__

The following example demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Merge the ResourceDictionaries__
{{region radhighlighttextblock-getting-started-4}}
    <Application.Resources>
    	<ResourceDictionary>
    		<ResourceDictionary.MergedDictionaries>
    			<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/System.Windows.xaml"/>
    			<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml"/>
    		</ResourceDictionary.MergedDictionaries>
    	</ResourceDictionary>
    </Application.Resources>
{{endregion}}

>Alternatively, you can change the theme of the control via the [StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf).

## See Also
* [Custom HighlightTextBlock]({%slug radhighlighttextblock-custom-highlighttextblock%})