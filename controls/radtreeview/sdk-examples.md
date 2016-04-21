---
title: Developer Focused Examples
page_title: Developer Focused Examples
description: Developer Focused Examples
slug: radtreeview-sdk-examples
tags: sdk,examples
published: True
position: 1
---

# Developer Focused Examples

The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadTreeView__.

## List of all RadTreeView SDK examples:

{% if site.site_name == 'WPF' %}

* __[Add context menu](https://github.com/telerik/xaml-sdk/tree/master/TreeView/AddContextMenu)__ - This project demonstrates how you can add a ContextMenu to root level items and implement add sibling, add child and delete functionality.
* __[Bind to self referencing data](https://github.com/telerik/xaml-sdk/tree/master/TreeView/BindToSelfReferencingData)__ - This example shows how to display a self referencing data from a flat collection in a RadTreeView.
* __[Bring into view](https://github.com/telerik/xaml-sdk/tree/master/TreeView/BringIntoView)__ - This example demonstrates how to bring an item into view when the RadTreeView UIVirtualization feature is used.
* __[Deny drop visual feedback](https://github.com/telerik/xaml-sdk/tree/master/TreeView/DenyDropVisualFeedback)__ - This example demonstrates how to deny a drop operation over a specific item (of type Division) and modify the visual feedback to indicate that the operation is not allowed.
* __[Drag drop between tree views](https://github.com/telerik/xaml-sdk/tree/master/TreeView/DragDropBetweenTreeViews)__ - This example demonstrates drag and drop between two RadTreeView controls with different view models.
* __[Drag drop tree view to controls](https://github.com/telerik/xaml-sdk/tree/master/TreeView/DragDropTreeViewToControls)__ - This example demonstrates how to implement drag and drop between a RadTreeView and a ListBox, using the RadTreeView built-in DragDrop functionality.
* __[Enable only drop inside item](https://github.com/telerik/xaml-sdk/tree/master/TreeView/EnableOnlyDropInsideItem)__ - This example demonstrates how to enable dropping inside the RadTreeViewItems, but not around them. 
* __[Filter search sort](https://github.com/telerik/xaml-sdk/tree/master/TreeView/FilterSearchSort)__ - This example demonstrates how to implement filtering and sorting logic on the collection displayed inside the RadTreeView control. The example also showcases how to implement a search functionality traversing the data displayed in the RadTreeView to find a specific item.
* __[Tree list view bring item into view](https://github.com/telerik/xaml-sdk/tree/master/TreeView/TreeListViewBringItemIntoView)__ - TreeListBringItem sample demonstrates how you can bring a particular, deeply nested TreeListViewRow into view. This might be helpful if you need a fast hierarchy control with many nested levels and RadTreeView is slow in your particular scenario with bring into view. This example is configured in such way that the TreeListView behaves and feels much like RadTreeView.
The first button will bring an item which is 20 levels deep with updating the UI on every level expansion. The second button will update the UI only when the bring operation is finished.
Please have in mind that running the application without debugger (Ctrl + F5 when in VS) will result in faster user experience.

* __[Windows explorer like tree view](https://github.com/telerik/xaml-sdk/tree/master/TreeView/WindowsExplorerLikeTreeView)__ - This project is available only for WPF because in Silverlight we do not have access to the file system. Description: This project demonstrates how you can create a TreeView similar to the Windows Explorer's one. The application traverses the file system of the user and displays all available drives, folders and files. Also it applies different styles to the different items.
{% endif %}
{% if site.site_name == 'Silverlight' %}
* __[Add context menu](https://github.com/telerik/xaml-sdk/tree/master/TreeView/AddContextMenu)__ - This project demonstrates how you can add a ContextMenu to root level items and implement add sibling, add child and delete functionality.
* __[Bind to self referencing data](https://github.com/telerik/xaml-sdk/tree/master/TreeView/BindToSelfReferencingData)__ - This example shows how to display a self referencing data from a flat collection in a RadTreeView.
* __[Bring into view](https://github.com/telerik/xaml-sdk/tree/master/TreeView/BringIntoView)__ - This example demonstrates how to bring an item into view when the RadTreeView UIVirtualization feature is used.
* __[Deny drop visual feedback](https://github.com/telerik/xaml-sdk/tree/master/TreeView/DenyDropVisualFeedback)__ - This example demonstrates how to deny a drop operation over a specific item (of type Division) and modify the visual feedback to indicate that the operation is not allowed.
* __[Drag drop between tree views](https://github.com/telerik/xaml-sdk/tree/master/TreeView/DragDropBetweenTreeViews)__ - This example demonstrates drag and drop between two RadTreeView controls with different view models.
* __[Drag drop tree view to controls](https://github.com/telerik/xaml-sdk/tree/master/TreeView/DragDropTreeViewToControls)__ - This example demonstrates how to implement drag and drop between a RadTreeView and a ListBox, using the RadTreeView built-in DragDrop functionality.
* __[Enable only drop inside item](https://github.com/telerik/xaml-sdk/tree/master/TreeView/EnableOnlyDropInsideItem)__ - This example demonstrates how to enable dropping inside the RadTreeViewItems, but not around them. 
* __[Filter search sort](https://github.com/telerik/xaml-sdk/tree/master/TreeView/FilterSearchSort)__ - This example demonstrates how to implement filtering and sorting logic on the collection displayed inside the RadTreeView control. The example also showcases how to implement a search functionality traversing the data displayed in the RadTreeView to find a specific item.
* __[Tree list view bring item into view](https://github.com/telerik/xaml-sdk/tree/master/TreeView/TreeListViewBringItemIntoView)__ - TreeListBringItem sample demonstrates how you can bring a particular, deeply nested TreeListViewRow into view. This might be helpful if you need a fast hierarchy control with many nested levels and RadTreeView is slow in your particular scenario with bring into view. This example is configured in such way that the TreeListView behaves and feels much like RadTreeView.
The first button will bring an item which is 20 levels deep with updating the UI on every level expansion. The second button will update the UI only when the bring operation is finished.
Please have in mind that running the application without debugger (Ctrl + F5 when in VS) will result in faster user experience.

{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).