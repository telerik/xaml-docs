---
title: UI Virtualization
page_title: UI Virtualization
description: Learn more about the horizontal and vertical virtualization in Telerik's {{ site.framework_name }} DataGrid that help speed up the loading time and enhance the UI performance.
slug: radgridview-features-ui-virtualization
tags: ui,virtualization
published: True
position: 13
---

# UI Virtualization

__RadGridView's API__ supports __UI Virtualization__ which processes only these visual elements that are loaded in its viewable area. This reduces the memory footprint of the application and speeds up the loading time, thus immensely enhancing the **UI performance**. 

The grid control utilizes **horizontal** and **vertical** virtualization and introduces container recycling for speed improvement and reduction in memory usage. This is of great importance when the control is bound to large data sets. The container recycling pushes further the speed of horizontal and vertical scrolling, allowing **RadGridView** to reuse the existing containers for the different data items from the source collection instead of creating new ones.

>important You should **not work** with the visual elements of **RadGridView**(GridViewCell, GridViewRow, etc.) directly as this will result in inconsistent behavior due to the containers recycling mechanism. Instead, you should use the underlying data items as explained in the [Style Selectors]({%slug gridview-cell-style-selector%}) section.

These techniques, combined with the outstanding LINQ-based data engine, guarantee fast performance.
        
>tip Both **EnableColumnVirtualization** and **EnableRowVirtualization** properties of **RadGridView** are set to **True** by default.     

>In case the **UI Virtualization** is disabled, then all the visual elements will be loaded once **RadGridView** is visualized and its items are populated. This can lead to huge performance issues and additional loading time. Disabling the virtualization is **highly** not recommended.

>important **Do not** place RadGridView in controls/panels which will measure it with infinity as this will disable the **UI Virtualization**. For example, __ScrollViewer__, __StackPanel__ and __Grid__ with __Row.Height=Auto__ or __Column.Width=Auto__ will measure it in that way. You can place it in RowDefinition with Height="*" instead. 

You can check the topic on [Styling or content mixed-up on scrolling]({%slug gridview-troubleshooting-style-disappears-scrolling%}) on some issues with styling the visual elements.
        
## See Also  
 * [Performance Tips and Tricks]({%slug radgridview-performance-tips-tricks%})
 * [Styling or content mixed-up on scrolling]({%slug gridview-troubleshooting-style-disappears-scrolling%}) 
