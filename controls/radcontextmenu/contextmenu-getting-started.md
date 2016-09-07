---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: contextmenu-getting-started
tags: getting,started
published: True
position: 3
---

# Getting Started

This tutorial will walk you through the creation of a __RadContextMenu__ and will show you how to:

* [Add RadContextMenu](#add-radcontextmenu)

* [Add Menu Items](#add-menu-items)

* [Populating the RadContextMenu with Data](#populating-the-radcontextmenu-with-data)

* [Styles and Templates](#styles-and-templates)

* [Working with the RadContextMenu](#work-with-the-radcontextmenu)

>Before reading this tutorial you should get familiar with the [Visual Structure]({%slug radcontextmenu-visual-structure%}) of the standard __RadContextMenu__ control.

For the purpose of this tutorial, you will need to create an empty {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} Application project.

>In order to use __RadContextMenu__ control in your projects you have to add references to the following assemblies:
> 1. __Telerik.Windows.Controls.Navigation.dll__
> 2. __Telerik.Windows.Controls.dll__

## Add RadContextMenu

In order to add a __RadContextMenu__ control to your __UserControl__ you have to declare the following namespace:

#### __XAML__

{{region xaml-contextmenu-getting-started_0}}
	<UserControl ...
	            xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
	    <Grid x:Name="LayoutRoot">
	
	    </Grid>
	</UserControl>
{{endregion}}

This tutorial will show you how to attach a __RadContextMenu__ to a TextBox control. Here is the TextBox control definition.

#### __XAML__

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

#### __XAML__

{{region xaml-contextmenu-getting-started_2}}
	<Grid x:Name="LayoutRoot"
	      Background="White">
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
#### __XAML__

{{region xaml-contextmenu-getting-started_3}}
	<Grid x:Name="LayoutRoot"
	      Background="White">
	    <TextBox Width="200"
	             VerticalAlignment="Top">
	        <telerik:RadContextMenu.ContextMenu>
	            <telerik:RadContextMenu />
	        </telerik:RadContextMenu.ContextMenu>
	    </TextBox>
	</Grid>
{{endregion}}
{% endif %}

If you run the application and right-click on the TextBox you will see an empty context menu.

![](images/RadContextMenu_Getting_Started_01.png)

## Add Menu Items

>The class that represents the menu item is __Telerik.Windows.Controls.RadMenuItem__. To learn more about it, please take a look at the [RadMenu help content]({%slug radmenu-overview%}).

The __RadContextMenu__ accepts __RadMenuItems__ as child items. Here is a sample declaration of several child menu items.

{% if site.site_name == 'Silverlight' %}
#### __XAML__

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
#### __XAML__

{{region xaml-contextmenu-getting-started_3}}
	<TextBox Width="200" VerticalAlignment="Top" ContextMenu="{x:Null}">
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

![](images/RadContextMenu_Getting_Started_02.png)

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

# See Also

 * [Visual Structure]({%slug radcontextmenu-visual-structure%})

 * [Populating with Data - Overview]({%slug radcontextmenu-populating-with-data-overview%})

 * [Events - Overview]({%slug radcontextmenu-events-overview%})

 * [Styles and Templates - Overview]({%slug radcontextmenu-styles-and-templates-overview%})

 * [Use RadContextMenu with a RadGridView]({%slug radcontextmenu-how-to-use-radcontextmenu-with-radgridview%})

 * [Select  the clicked Item of a RadTreeView]({%slug radcontextmenu-how-to-select-the-clicked-item-of-radtreeview%})

 * [Create Menu Button with RadContextMenu and ToggleButton]({%slug radcontextmenu-how-to-create-menu-button-with-radcontextmenu-and-togglebutton%})

 * [Use Commands with the RadContextMenu]({%slug radcontextmenu-how-to-use-commands-with-the-radcontextmenu%})

 * [Handle Item Clicks]({%slug radcontextmenu-how-to-handle-item-clicks%})
