---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadRadialMenu {{ site.framework_name }} control.
slug: radradialmenu-getting-started
tags: getting,started
published: True
position: 1
---

# {{ site.framework_name }} RadRadialMenu Getting Started

This topic will walk you through the creating of __RadRadialMenu__.    

>In order to use __RadRadialMenu__ in your project you have to add references to the following two assemblies:
> * Telerik.Windows.Controls.dll
> * Telerik.Windows.Controls.Navigation.dll

## RadRadialMenu as a Normal Menu

You can include the control in your page by either dragging it from the toolbox in Visual Studio, or manually creating the control. Below is an example of how to create the RadRadialMenu control in code behind and XAML code: 

#### __[XAML]  Creating RadRadialMenu__

{{region xaml-radradialmenu-getting-started_0}}
	<telerik:RadRadialMenu>
	    <telerik:RadRadialMenuItem Header="Item 1" />
	    <telerik:RadRadialMenuItem Header="Item 2" />
	    <telerik:RadRadialMenuItem Header="Item 3" />
	</telerik:RadRadialMenu>
{{endregion}}

where *telerik* namespace is defined like this:        

#### __[XAML]__

{{region xaml-radradialmenu-getting-started_1}}
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
{{endregion}}

#### __[C#] Creating RadRadialMenu with code__

{{region cs-radradialmenu-getting-started_2}}
	var radialMenu = new RadRadialMenu();
	
	radialMenu.Items.Add(new RadRadialMenuItem() { Header = "Item 1" });
	radialMenu.Items.Add(new RadRadialMenuItem() { Header = "Item 2" });
	radialMenu.Items.Add(new RadRadialMenuItem() { Header = "Item 3" });
{{endregion}}

## RadRadialMenu as a Context Menu

Here is a simple example demonstrating how to declare a __RadRadialMenu__ instance as a context menu for a TextBox using its __ShowEventName__ and __HideEventName__ properties.

#### __[XAML] RadialMenu as a ContextMenu__

{{region xaml-radradialmenu-getting-started_3}}
	<TextBox Text="Some Text">
	    <telerik:RadRadialMenu.RadialContextMenu>
	        <telerik:RadRadialMenu ShowEventName="GotFocus" HideEventName="LostFocus">
	            <telerik:RadRadialMenuItem Header="Item 1" />
	            <telerik:RadRadialMenuItem Header="Item 2" />
	            <telerik:RadRadialMenuItem Header="Item 3" />
	        </telerik:RadRadialMenu>
	    </telerik:RadRadialMenu.RadialContextMenu>
	</TextBox>
{{endregion}}

For further reference check [RadRadialMenu as a ContextMenu]({%slug radradialmenu-features-contextmenu%}) topic.

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#RadialMenu/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the RadRadialMenu, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Navigation__

__Example 1__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 1: Merge the ResourceDictionaries__  
{{region RadPivotGrid-getting-started_7}}
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/System.Windows.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.Navigation.xaml"/>
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
{{endregion}}

>Alternatively, you can use the theme of the control via the {% if site.site_name == 'WPF' %}[StyleManager](https://docs.telerik.com/devtools/wpf/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme-wpf){% else %}[StyleManager](https://docs.telerik.com/devtools/silverlight/styling-and-appearance/stylemanager/common-styling-apperance-setting-theme){% endif %}.

__Figure 1__ shows a RadRadialMenu with the **Windows8** theme applied.

#### __Figure 1: RadRadialMenu with the Windows8 theme__
![RadRadialMenu with Windows8 theme](images/radradialmenu-setting-theme.png)

## See Also

 * [Getting Started]({%slug radradialmenu-getting-started%})

 * [RadRadialMenu as a ContextMenu]({%slug radradialmenu-features-contextmenu%})
