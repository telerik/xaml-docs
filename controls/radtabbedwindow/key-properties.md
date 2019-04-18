---
title: Key Properties
page_title: Key Properties
description: Key Properties
slug: radtabbedwindow-key-properties
tags: key, properties
published: True
position: 2
---

# Key Properties

This article will list the key properties provided by the RadTabbedWindow control.

## Header

RadTabbedWindow allows you to display a header in the top-left part of it. To specify the header you can use either the **Header** or the **HeaderTemplate** properties.

#### [XAML] Example 1: Set RadTabbedWindow header

{{region xaml-radtabbedwindow-key-properties_0}}
    <telerik:RadTabbedWindow.Header>
        <TextBlock Text="RadTabbedWindow" Margin="0 0 10 0" />
    </telerik:RadTabbedWindow.Header>
{{endregion}}

## Icon

Via the **Icon** and the **IconTemplate** properties, you can also define an **icon** for your RadTabbedWindow.

#### [XAML] Example 2: Set window icon

{{region xaml-radtabbedwindow-key-properties_1}}
    <telerik:RadTabbedWindow.Icon>
        <Image Source="/Icons/WindowIcon.png" Stretch="None" />
    </telerik:RadTabbedWindow.Icon>
{{endregion}}

## DisplayMemberPath

By default, when in a data-bound scenario, the content of the tab items will be set to the value returned by the __ToString()__ method of the underlying business objects.

As this is rarely the desired behavior, RadTabbedWindow exposes a __DisplayMemberPath__ property. Its purpose is to specify a property of the source object to serve as the visual representation of the RadTabItem.

**Example 3** demonstrates how to set the __RadTabbedWindow__'s __DisplayMemberPath__ property to point to the __Header__ property of the underlying objects.

#### __[XAML] Example 3: Set the DisplayMemberPath property__

{{region xaml-radtabbedwindow-key-properties_2}}
    <telerik:RadTabbedWindow ... DisplayMemberPath="Header" />
{{endregion}}

## ItemsPanel

Through the **ItemsPanel** property, you can define a custom panel for the tab items. If you wish to have tabs with different widths, for example, you can use the default panel of the RadTabControl - the **TabWrapPanel** - as shown in **Example 4**.

#### __[XAML] Example 4: Set the ItemsPanel property__

{{region xaml-radtabbedwindow-styles-and-templates_3}}
    <telerik:RadTabbedWindow.ItemsPanel>
        <ItemsPanelTemplate>
            <telerikNavigationPrimitives:TabWrapPanel />
        </ItemsPanelTemplate>
    </telerik:RadTabbedWindow.ItemsPanel>
{{endregion}}

## ItemWidth and ItemMinWidth

Through the ItemWidth and ItemMinWidth, you can control the default **Width** and **MinWidth** of the window's RadTabItems. **Example 5** shows how to set these properties and their default values.

#### [C#] Example 5: Set ItemWidth and ItemMinWidth

{{region cs-radtabbedwindow-key-properties_4}}
    tabbedWindow.ItemWidth = 120;
    tabbedWindow.ItemMinWidth = 80;
{{endregion}}

#### [VB.NET] Example 5: Set ItemWidth and ItemMinWidth

{{region vb-radtabbedwindow-key-properties_5}}
    tabbedWindow.ItemWidth = 120
    tabbedWindow.ItemMinWidth = 80
{{endregion}}

## AllowDragReorder

Setting the window's **AllowDragReorder** property to **True** or **False** to allow/disallow the user to reorder the tab items of your tab control using Drag & Drop.

#### [C#] Example 6: Enable the reorder of tabs via drag and drop

{{region cs-radtabbedwindow-key-properties_6}}
    tabbedWindow.AllowDragReorder = true;
{{endregion}}

#### [VB.NET] Example 6: Enable the reorder of tabs via drag and drop

{{region vb-radtabbedwindow-key-properties_7}}
    tabbedWindow.AllowDragReorder = true
{{endregion}}

## ScrollMode

When the width of the window does not allow all tabs to be displayed, two scrolling buttons appear to the left and to the right side of the tab items. You can choose one of the **ScrollMode** values in order to control how the tab items should be scrolled. More information about the different modes can be found in [this article]({%slug radtabcontrol-features-tabs-scrollmode%}).

#### [C#] Example 7: Enable the reorder of tabs via drag and drop

{{region cs-radtabbedwindow-key-properties_8}}
    tabbedWindow.ScrollMode = TabControlScrollMode.Viewport;
{{endregion}}

#### [VB.NET] Example 7: Enable the reorder of tabs via drag and drop

{{region vb-radtabbedwindow-key-properties_9}}
    tabbedWindow.ScrollMode = TabControlScrollMode.Viewport
{{endregion}}

## AddButtonVisibility

You can determine whether users will be able to add new tabs through the UI be specifying the **AddButtonVisibility** property.

#### [C#] Example 8: Enable the reorder of tabs via drag and drop

{{region cs-radtabbedwindow-key-properties_10}}
    tabbedWindow.AddButtonVisibility = Visibility.Collapsed;
{{endregion}}

#### [VB.NET] Example 8: Enable the reorder of tabs via drag and drop

{{region vb-radtabbedwindow-key-properties_11}}
    tabbedWindow.AddButtonVisibility = Visibility.Collapsed
{{endregion}}

## See Also

* [Events](%slug radtabbedwindow-events%)
* [Styles and Templates](%slug radtabbedwindow-styles-and-templates%)