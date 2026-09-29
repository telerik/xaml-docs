---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadContextMenu {{ site.framework_name }} control.
components: ["contextmenu"]
slug: contextmenu-getting-started
tags: getting,started
published: True
position: 2
---

# Getting Started

This tutorial walks you through the creation of a __RadContextMenu__.

>note Before reading this tutorial you should get familiar with the [Visual Structure]({%slug radcontextmenu-visual-structure%}) of the standard __RadContextMenu__ control.

## Adding Telerik Assemblies Using NuGet

To use __RadContextMenu__ when working with NuGet packages, install the `Telerik.Windows.Controls.Navigation.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. Learn more in [Installing the License Key]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Navigation__

You can find the required assemblies for each control from the suite in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) help article.

## Attaching Context Menu to UI Element

In order to add a __RadContextMenu__ control to your __UserControl__ you have to declare the following namespace:

__Declare the Telerik Namespace__
```XAML
xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
```

This tutorial will show you how to attach a __RadContextMenu__ to a TextBox control. Here is the TextBox control definition.

__Define the TextBox__
```XAML
<Grid x:Name="LayoutRoot"
      Background="White">
    <TextBox x:Name="InputBox"
             Width="200"
             VerticalAlignment="Top">
    </TextBox>
</Grid>
```

The next step is to set the __ContextMenu__ attached property of the __RadContextMenu__ class to the __TextBox__ control.

>note *ContextMenu="{x:Null}"* is needed to override the default context menu of the textbox.

__Attach RadContextMenu to the TextBox__
```XAML
<Grid xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
    Background="White">
    <TextBox Width="200"
             VerticalAlignment="Top"
             ContextMenu="{x:Null}">
        <telerik:RadContextMenu.ContextMenu>
            <telerik:RadContextMenu />
        </telerik:RadContextMenu.ContextMenu>
    </TextBox>
</Grid>
```

If you run the application and right-click on the TextBox you will see an empty context menu.

__RadContextMenu with an Empty Context Menu__
![WPF RadContextMenu with Empty Context Menu](images/RadContextMenu_Getting_Started_01.png)

## Adding Menu Items

>note The class that represents the menu item is __Telerik.Windows.Controls.RadMenuItem__. To learn more about it, please take a look at the [RadMenu help content]({%slug radmenu-overview%}).

The __RadContextMenu__ accepts __RadMenuItems__ as child items. Here is a sample declaration of several child menu items.

__Define RadMenuItems__
```XAML
<TextBox xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
         Width="200"
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
```

Here is a snapshot of the result.

__RadContextMenu with Menu Items__
![WPF RadContextMenu with Populated Context Menu](images/RadContextMenu_Getting_Started_02.png)

## Populating the RadContextMenu with Data

The scenario described in the previous sections covers the usage of static items, declared directly in XAML.

However, in most of the cases you have to bind your __RadContextMenu__ to a collection of business objects. Check out the [Data Binding]({%slug radcontextmenu-features-data-binding%}) article which describes in detail how to work with dynamic data, including the supported data sources and the __ItemContainerStyle__ mechanism.

To adjust the appearance of the __RadContextMenu's__ items depending on the data they hold, read the [Item Template and Style Selectors]({%slug radcontextmenu-features-template-and-style-selectors%}) article.

## Working with the RadContextMenu

In order to learn how to use the __RadContextMenu__ and what capabilities it holds, read the various topics that describe its features.

* [Setting the Opening Event]({%slug radcontextmenu-features-opening-on-specific-event%})

* [Keyboard Support]({%slug radcontextmenu-key-modifiers%})

* [Menu Placement]({%slug radcontextmenu-features-placement%})

* [Opening and Closing Delays]({%slug radcontextmenu-features-opening-and-closing-delays%})

* [Data Binding]({%slug radcontextmenu-features-data-binding%})

* [Item Template and Style Selectors]({%slug radcontextmenu-features-template-and-style-selectors%})

* [Context Menu Owner]({%slug radcontextmenu-features-context-menu-owner%})

* [Customizing the Icon Column]({%slug radcontextmenu-features-icon-column%})

## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF ContextMenu Component](https://www.telerik.com/products/wpf/contextmenu.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-guide%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf)
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)

## See Also

* [Visual Structure]({%slug radcontextmenu-visual-structure%})

* [Events - Overview]({%slug radcontextmenu-events-overview%})

* [Item Template and Style Selectors]({%slug radcontextmenu-features-template-and-style-selectors%})

* [Use RadContextMenu with a RadGridView]({%slug kb-contextmenu-use-with-radgridview%})

* [Select the Clicked Item of a RadTreeView]({%slug kb-contextmenu-select-clicked-item-radtreeview%})

* [Create Menu Button with RadContextMenu and ToggleButton]({%slug kb-contextmenu-create-menu-button-with-togglebutton%})

* [Use Commands with the RadContextMenu]({%slug kb-contextmenu-use-commands%})

* [Handle Item Clicks]({%slug kb-contextmenu-handle-item-clicks%})

