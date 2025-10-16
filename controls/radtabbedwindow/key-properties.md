---
title: Key Properties
page_title: Key Properties
description: This article lists the main properties exposed by the RadTabbedWindow control.
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

```XAML
    <telerik:RadTabbedWindow.Header>
        <TextBlock Text="RadTabbedWindow" Margin="0 0 10 0" />
    </telerik:RadTabbedWindow.Header>
```

## Icon

Via the **Icon** and the **IconTemplate** properties, you can also define an **icon** for your RadTabbedWindow.

#### [XAML] Example 2: Set window icon

```XAML
    <telerik:RadTabbedWindow.Icon>
        <Image Source="/Icons/WindowIcon.png" Stretch="None" />
    </telerik:RadTabbedWindow.Icon>
```

## DisplayMemberPath

By default, when in a data-bound scenario, the content of the tab items will be set to the value returned by the __ToString()__ method of the underlying business objects.

As this is rarely the desired behavior, RadTabbedWindow exposes a __DisplayMemberPath__ property. Its purpose is to specify a property of the source object to serve as the visual representation of the RadTabItem.

**Example 3** demonstrates how to set the __RadTabbedWindow__'s __DisplayMemberPath__ property to point to the __Header__ property of the underlying objects.

__Example 3: Set the DisplayMemberPath property__

```XAML
    <telerik:RadTabbedWindow ... DisplayMemberPath="Header" />
```

## ItemsPanel

Through the **ItemsPanel** property, you can define a custom panel for the tab items. If you wish to have tabs with different widths, for example, you can use the default panel of the RadTabControl - the **TabWrapPanel** - as shown in **Example 4**.

__Example 4: Set the ItemsPanel property__

```XAML
    <telerik:RadTabbedWindow.ItemsPanel>
        <ItemsPanelTemplate>
            <telerikNavigationPrimitives:TabWrapPanel />
        </ItemsPanelTemplate>
    </telerik:RadTabbedWindow.ItemsPanel>
```

## ItemWidth and ItemMinWidth

Through the ItemWidth and ItemMinWidth, you can control the default **Width** and **MinWidth** of the window's RadTabItems. **Example 5** shows how to set these properties and their default values.

#### [C#] Example 5: Set ItemWidth and ItemMinWidth

```C#
    tabbedWindow.ItemWidth = 120;
    tabbedWindow.ItemMinWidth = 80;
```

#### [VB.NET] Example 5: Set ItemWidth and ItemMinWidth

```VB.NET
    tabbedWindow.ItemWidth = 120
    tabbedWindow.ItemMinWidth = 80
```

## Pinned Items

The control also exposes a **PinnedItems** property of type **ReadOnlyObservableCollection<RadTabItem>**. You can use it to get ahold of all the pinned tabs. To enable the pinning functionality, you should set the **PinButtonVisibility** of the tab items to **Visible** via the **ItemContainerStyle** property of the window as shown in [this article]({%slug radtabbedwindow-styles-and-templates%}#itemcontainerstyle).

## DragDropMode

By default, the RadTabbedWindow allows reordering of its tabs as well as creating new windows via drag and drop. This drag-drop behavior can be controlled via the **DragDropMode** property which can have any of the following values:

* **None**: Drag drop is disabled.
* **Reorder**: Reorder in tab strip is allowed only.
* **Default**: DragReorder and drag out of TabControl is allowed (like in modern browsers).

#### [C#] Example 6: Allow only the reorder of tabs via drag and drop

```C#
    tabbedWindow.DragDropMode = DragDropMode.Reorder;
```

#### [VB.NET] Example 6: Allow only the reorder of tabs via drag and drop

```VB.NET
    tabbedWindow.DragDropMode = DragDropMode.Reorder
```

## ScrollMode

When the width of the window does not allow all tabs to be displayed, two scrolling buttons appear to the left and to the right side of the tab items. You can choose one of the **ScrollMode** values in order to control how the tab items should be scrolled. More information about the different modes can be found in [this article]({%slug radtabcontrol-features-tabs-scrollmode%}).

#### [C#] Example 7: Enable the reorder of tabs via drag and drop

```C#
    tabbedWindow.ScrollMode = TabControlScrollMode.Viewport;
```

#### [VB.NET] Example 7: Enable the reorder of tabs via drag and drop

```VB.NET
    tabbedWindow.ScrollMode = TabControlScrollMode.Viewport
```

## AddButtonVisibility

You can determine whether users will be able to add new tabs through the UI be specifying the **AddButtonVisibility** property.

#### [C#] Example 8: Set AddButtonVisibility

```C#
    tabbedWindow.AddButtonVisibility = Visibility.Collapsed;
```

#### [VB.NET] Example 8: Set AddButtonVisibility

```VB.NET
    tabbedWindow.AddButtonVisibility = Visibility.Collapsed
```

## SelectedItemRemoveBehaviour

The __SelectedItemRemoveBehaviour__ property allows you to choose which __RadTabItem__ should be selected next in case the currently selected __RadTabItem__ is removed. The property can have one of the following values:

* __SelectNone__: No action is performed. Use it to set the __SelectedItem__ to **null**.

* __SelectFirst__: The **first** non-disabled and visible item in the **Items** collection is selected.

* __SelectLast__: The **last** non-disabled and visible item in the **Items** collection is selected.

* __SelectPrevious__: The **previous** non-disabled and visible item in the **Items** collection is selected. If there is no such item, the **next** non-disabled and visible item is selected. If there is no such item, **no action** is performed.

* __SelectNext__: The **next** non-disabled and visible item in the **Items** collection is selected. If there is no such item, the **previous** non-disabled and visible item is selected. If there is no such item, **no action** is performed.

#### [C#] Example 9: Set SelectedItemRemoveBehaviour

```C#
    tabbedWindow.SelectedItemRemoveBehaviour = SelectedItemRemoveBehaviour.SelectLast;
```

#### [VB.NET] Example 9: Set SelectedItemRemoveBehaviour

```VB.NET
    tabbedWindow.SelectedItemRemoveBehaviour = SelectedItemRemoveBehaviour.SelectLast
```

## IsContentPreserved

For performance reasons the **ControlTemplate** of the **TabbedWindowTabControl** inside the RadTabbedWindow defines a single **ContentPresenter** which holds only the currently selected **RadTabItem**'s **Content**. Therefore each time the selection is changed, the content of the last active item is unloaded in order to load the content of the newly-selected item. Since the load/unload operations involve add/remove actions in the visual tree, the content does not keep its state.

However, if you need to keep each **RadTabItem**'s content you can set the **IsContentPreserved** property to **True**.

#### [C#] Example 10: Preserve tab item content

```C#
    tabbedWindow.IsContentPreserved = true;
```

#### [VB.NET] Example 10: Preserve tab item content

```VB.NET
    tabbedWindow.IsContentPreserved = True
```

## See Also

* [Events]({%slug radtabbedwindow-events%})
* [Styles and Templates]({%slug radtabbedwindow-styles-and-templates%})
