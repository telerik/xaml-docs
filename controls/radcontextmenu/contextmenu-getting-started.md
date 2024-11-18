---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadContextMenu {{ site.framework_name }} control.
slug: contextmenu-getting-started
tags: getting,started
published: True
position: 3
---

# Getting Started with {{ site.framework_name }} ContextMenu

This tutorial will walk you through the creation of a __RadContextMenu__ and will show you how to:

>Before reading this tutorial you should get familiar with the [Visual Structure]({%slug radcontextmenu-visual-structure%}) of the standard __RadContextMenu__ control.

## Assembly References

To use the __RadContextMenu__ in your projects you have to add references to the following assemblies:

* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Navigation__

You can find the required assemblies for each control from the suite in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% else %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

### Adding Telerik Assemblies Using NuGet

To use __RadContextMenu__ when working with NuGet packages, install the `Telerik.Windows.Controls.Input.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

## Add RadContextMenu

In order to add a __RadContextMenu__ control to your __UserControl__ you have to declare the following namespace:

#### __[XAML] Example 1__

{{region xaml-contextmenu-getting-started_0}}
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
{{endregion}}

This tutorial will show you how to attach a __RadContextMenu__ to a TextBox control. Here is the TextBox control definition.

#### __[XAML] Example 2__

{{region xaml-contextmenu-getting-started_1}}
	<Grid x:Name="LayoutRoot"
	      Background="White">
	    <TextBox x:Name="InputBox"
	             Width="200"
	             VerticalAlignment="Top">
	    </TextBox>
	</Grid>
{{endregion}}

The next step is to set the __ContextMenu__ attached property of the __RadContextMenu__ class to the __TextBox__ control.

{% if site.site_name == 'WPF' %}
>*ContextMenu="{x:Null}"* is needed to override the default context menu of the textbox.

#### __[XAML] Example 3__

{{region xaml-contextmenu-getting-started_2}}
	<Grid Background="White">
	    <TextBox Width="200"
	             VerticalAlignment="Top"
	             ContextMenu="{x:Null}">
	        <telerik:RadContextMenu.ContextMenu>
	            <telerik:RadContextMenu />
	        </telerik:RadContextMenu.ContextMenu>
	    </TextBox>
	</Grid>
{{endregion}}
{% endif %}

{% if site.site_name == 'Silverlight' %}
#### __[XAML] Example 3__

{{region xaml-contextmenu-getting-started_3}}
	<TextBox Width="200"
	         VerticalAlignment="Top"
	         ContextMenu="{x:Null}">
	    <telerik:RadContextMenu.ContextMenu>
	        <telerik:RadContextMenu>
	            <telerik:RadMenuItem Header="Copy" />
	            <telerik:RadMenuItem Header="Paste" />
	            <telerik:RadMenuItem Header="Cut" />
	            <telerik:RadMenuItem IsSeparator="True" />
	            <telerik:RadMenuItem Header="Select All" />
	        </telerik:RadContextMenu>
	    </telerik:RadContextMenu.ContextMenu>
	</TextBox>
{{endregion}}
{% endif %}

If you run the application and right-click on the TextBox you will see an empty context menu.

#### __Figure 1__
![{{ site.framework_name }} RadContextMenu with Empty Context Menu](images/RadContextMenu_Getting_Started_01.png)

## Add Menu Items

>The class that represents the menu item is __Telerik.Windows.Controls.RadMenuItem__. To learn more about it, please take a look at the [RadMenu help content]({%slug radmenu-overview%}).

The __RadContextMenu__ accepts __RadMenuItems__ as child items. Here is a sample declaration of several child menu items.

{% if site.site_name == 'Silverlight' %}
#### __[XAML] Example 4__

{{region xaml-contextmenu-getting-started_5}}
	<TextBox Width="200"
	         VerticalAlignment="Top">
	    <telerik:RadContextMenu.ContextMenu>
	        <telerik:RadContextMenu>
	            <telerik:RadMenuItem Header="Copy" />
	            <telerik:RadMenuItem Header="Paste" />
	            <telerik:RadMenuItem Header="Cut" />
	            <telerik:RadMenuItem IsSeparator="True" />
	            <telerik:RadMenuItem Header="Select All" />
	        </telerik:RadContextMenu>
	    </telerik:RadContextMenu.ContextMenu>
	</TextBox>
{{endregion}}
{% endif %}

{% if site.site_name == 'WPF' %}
#### __[XAML] Example 4__

{{region xaml-contextmenu-getting-started_3}}
	<TextBox Width="200"
	         VerticalAlignment="Top"
	         ContextMenu="{x:Null}">
	    <telerik:RadContextMenu.ContextMenu>
	        <telerik:RadContextMenu>
	            <telerik:RadMenuItem Header="Copy" />
	            <telerik:RadMenuItem Header="Paste" />
	            <telerik:RadMenuItem Header="Cut" />
	            <telerik:RadMenuItem IsSeparator="True" />
	            <telerik:RadMenuItem Header="Select All" />
	        </telerik:RadContextMenu>
	    </telerik:RadContextMenu.ContextMenu>
	</TextBox>
{{endregion}}
{% endif %}

Here is a snapshot of the result.

#### __Figure 2__
![{{ site.framework_name }} RadContextMenu with Populated Context Menu](images/RadContextMenu_Getting_Started_02.png)

## Populating the RadContextMenu with Data

The scenario described in the previous sections covers the usage of static items. To learn more about these type of scenarios read [here]({%slug radcontextmenu-populating-with-data-using-static-items%}).

However, in most of the cases you have to bind your __RadContextMenu__ to a collection of business objects. Check out the following topics which describe in details how to work with dynamic data.

* [Data Binding Support Overview]({%slug radcontextmenu-populating-with-data-data-binding-support-overview%}) - describes the various data sources for the __RadContextMenu__ and shows you many tips and tricks. Read this topics in order to achieve basic knowledge about how the binding mechanism works at the __RadContextMenu__. 

* [Binding to Dynamic Data]({%slug radcontextmenu-populating-with-data-using-static-items%}) - shows you how to bind the __RadContextMenu__ to a collection of business objects. 

* [Template and Styles Selectors]({%slug radcontextmenu-populating-with-data-template-and-style-selectors%}) - describes the possibilities to adjust the appearance of the __RadContextMenu's__ items depending on the data they hold. 

## Styles and Templates

Read the [Styles and Templates]({%slug radcontextmenu-styles-and-templates-overview%}) section which is entirely dedicated to styling and templating the __RadContextMenu__ control.

## Work with the RadContextMenu

In order to learn how to use the __RadContextMenu__ and what capabilities it holds, read the various topics that describe its features.

* [Working with the RadContextMenu]({%slug radcontextmenu-features-working-with-radcontext-menu%})

* [Opening on a Specific Event]({%slug radcontextmenu-features-opening-on-specific-event%})

* [Key Modifiers]({%slug radcontextmenu-key-modifiers%})

* [Placement]({%slug radcontextmenu-features-placement%})

* [Opening and Closing Delays]({%slug radcontextmenu-features-opening-and-closing-delays%})

* [Data Binding]({%slug radcontextmenu-features-data-binding%})
{% if site.site_name == 'Silverlight' %}
* [Boundaries Detection]({%slug radcontextmenu-features-boundaries-detection%})
{% endif %}

## Setting a Theme

The controls from our suite support different themes. You can see how to apply a theme different than the default one in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) help article.

>important Changing the theme using implicit styles will affect all controls that have styles defined in the merged resource dictionaries. This is applicable only for the controls in the scope in which the resources are merged. 

To change the theme, you can follow the steps below:

* Choose between the themes and add reference to the corresponding theme assembly (ex: **Telerik.Windows.Themes.Windows8.dll**). You can see the different themes applied in the **Theming** examples from our {% if site.site_name == 'WPF' %}[WPF Controls Examples](https://demos.telerik.com/wpf/){% else %}[Silverlight Controls Examples](https://demos.telerik.com/silverlight/#ContextMenu/Theming){% endif %} application.

* Merge the ResourceDictionaries with the namespace required for the controls that you are using from the theme assembly. For the __RadContextMenu__, you will need to merge the following resources:

	* __Telerik.Windows.Controls__
	* __Telerik.Windows.Controls.Navigation__

__Example 5__ demonstrates how to merge the ResourceDictionaries so that they are applied globally for the entire application.

#### __[XAML] Example 5: Merge the ResourceDictionaries__  
{{region xaml-radcontextmenu-getting-started_7}}
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

__Figure 3__ shows a __RadContextMenu__ with the **Windows8** theme applied.
	
#### __Figure 3: RadContextMenu with the Windows8 theme__
![RadContextMenu with Windows8 theme](images/radcontextmenu-setting-theme.png)

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF ContextMenu Component](https://www.telerik.com/products/wpf/contextmenu.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also

 * [Visual Structure]({%slug radcontextmenu-visual-structure%})

 * [Events - Overview]({%slug radcontextmenu-events-overview%})

 * [Styles and Templates - Overview]({%slug radcontextmenu-styles-and-templates-overview%})

 * [Use RadContextMenu with a RadGridView]({%slug radcontextmenu-how-to-use-radcontextmenu-with-radgridview%})

 * [Select  the clicked Item of a RadTreeView]({%slug radcontextmenu-how-to-select-the-clicked-item-of-radtreeview%})

 * [Create Menu Button with RadContextMenu and ToggleButton]({%slug radcontextmenu-how-to-create-menu-button-with-radcontextmenu-and-togglebutton%})

 * [Use Commands with the RadContextMenu]({%slug radcontextmenu-how-to-use-commands-with-the-radcontextmenu%})

 * [Handle Item Clicks]({%slug radcontextmenu-how-to-handle-item-clicks%})
