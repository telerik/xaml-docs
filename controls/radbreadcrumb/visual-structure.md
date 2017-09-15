---
title: Visual Structure
page_title: Visual Structure
description: Visual Structure
slug: radbreadcrumb-visual-structure
tags: visual,structure
published: True
position: 2
---

# Visual Structure

This section defines terms and concepts used in the scope of __RadBreadcrumb__ you have to get familiar with prior to continue reading this help.

__RadBreadcrumb__ is a powerful control which lets you create navigation systems and display hierarchical structures, such as directories. Below you can see a snapshot and explanation of the main visual elements of the standard __RadBreadcrumb__ control.

![](images/breadcrumb_visual_structure.png)

The structure of the __RadBreadcrumb__ is pretty simple. It consists of the following main elements:		

* __BreadcrumbItems__ - __RadBreadcrumb__ control provides a way to display information in a hierarchical structure by using collapsible items. Each __Breadcrumb__ item is an instance of the __RadBreadcrumbItem__ class. You can navigate between these items using either your mouse device or your keyboard.

* __Breadcrumb Header__ - The __Breadcrumb__ control has a __Header__ property which is the root of the breadcrumb navigation [Read More]({%slug radbreadcrumb-features-overview%})

* __Header__ and __DropDownHeader__ - each __BreadcrumbItem__ has a Header and a __DropDownHeader__ property. The __DropDownHeader__ is used when the item is displayed in the __DropDown__ content of its parent item, while the __Header__ is used when the item is displayed in the __Breadcrumb__ control. [Read More]({%slug radbreadcrumb-features-overview%})

* __Image__ - the __CurrentItem__ 's __Image__ is displayed in front of the __Breadcrumb Header__. If no __BreadcrumbItem__ is selected, the __Breadcrumb Header__ item's __Image__ is displayed. You can easily show/hide the __Image__, using a single property to do so - __IsIconVisible__.			

* __History ToggleButton__ - displays the list of __RadBreadcrumb.HistoryItems__

## See Also
 * [Features Overview]({%slug radbreadcrumb-features-overview%})