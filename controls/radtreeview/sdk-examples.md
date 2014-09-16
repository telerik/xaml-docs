---
title: SDK Examples
page_title: SDK Examples
description: SDK Examples
slug: radtreeview-sdk-examples
tags: sdk,examples
publish: True
position: 1
---

# SDK Examples



The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadTreeView__.

## List of all RadTreeView SDK examples:{% if site.site_name == 'WPF' %}

* __Add context menu__ - This project demonstrates how you can add a ContextMenu to root level items and implement add sibling, add child and delete functionality.

* __Bind to self referencing data__ - This example shows how to display a self referencing data from a flat collection in a RadTreeView.

* __Bring into view__ - This example demonstrates how to bring an item into view when the RadTreeView UIVirtualization feature is used.

* __Deny drop visual feedback__ - This example demonstrates how to deny a drop operation over a specific item (of type Division) and modify the visual feedback to indicate that the operation is not allowed.

* __Drag drop between tree views__ - This example demonstrates drag and drop between two RadTreeView controls with different view models.

* __Drag drop tree view to controls__ - This example demonstrates how to implement drag and drop between a RadTreeView and a ListBox, using the RadTreeView built-in DragDrop functionality.

* __Enable only drop inside item__ - This example demonstrates how to enable dropping inside the RadTreeViewItems, but not around them. 

* __Filter search sort__ - This example demonstrates how to implement filtering and sorting logic on the collection displayed inside the RadTreeView control. The example also showcases how to implement a search functionality traversing the data displayed in the RadTreeView to find a specific item.

* __Tree list view bring item into view__ - TreeListBringItem sample demonstrates how you can bring a particular, deeply nested TreeListViewRow into view. This might be helpful if you need a fast hierarchy control with many nested levels and RadTreeView is slow in your particular scenario with bring into view. This example is configured in such way that the TreeListView behaves and feels much like RadTreeView. The first button will bring an item which is 20 levels deep with updating the UI on every level expansion. The second button will update the UI only when the bring operation is finished. Please have in mind that running the application without debugger (Ctrl + F5 when in VS) will result in faster user experience. 

* __Windows explorer like tree view__ - This project is available only for WPF because in Silverlight we do not have access to the file system. Description: This project demonstrates how you can create a TreeView similar to the Windows Explorer's one. The application traverses the file system of the user and displays all available drives, folders and files. Also it applies different styles to the different items.{% endif %}{% if site.site_name == 'Silverlight' %}

* __Add context menu__ - This project demonstrates how you can add a ContextMenu to root level items and implement add sibling, add child and delete functionality.

* __Bind to self referencing data__ - This example shows how to display a self referencing data from a flat collection in a RadTreeView.

* __Bring into view__ - This example demonstrates how to bring an item into view when the RadTreeView UIVirtualization feature is used.

* __Deny drop visual feedback__ - This example demonstrates how to deny a drop operation over a specific item (of type Division) and modify the visual feedback to indicate that the operation is not allowed.

* __Drag drop between tree views__ - This example demonstrates drag and drop between two RadTreeView controls with different view models.

* __Drag drop tree view to controls__ - This example demonstrates how to implement drag and drop between a RadTreeView and a ListBox, using the RadTreeView built-in DragDrop functionality.

* __Enable only drop inside item__ - This example demonstrates how to enable dropping inside the RadTreeViewItems, but not around them. 

* __Filter search sort__ - This example demonstrates how to implement filtering and sorting logic on the collection displayed inside the RadTreeView control. The example also showcases how to implement a search functionality traversing the data displayed in the RadTreeView to find a specific item.

* __Tree list view bring item into view__ - TreeListBringItem sample demonstrates how you can bring a particular, deeply nested TreeListViewRow into view. This might be helpful if you need a fast hierarchy control with many nested levels and RadTreeView is slow in your particular scenario with bring into view. This example is configured in such way that the TreeListView behaves and feels much like RadTreeView. The first button will bring an item which is 20 levels deep with updating the UI on every level expansion. The second button will update the UI only when the bring operation is finished. Please have in mind that running the application without debugger (Ctrl + F5 when in VS) will result in faster user experience. {% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).

# See Also
