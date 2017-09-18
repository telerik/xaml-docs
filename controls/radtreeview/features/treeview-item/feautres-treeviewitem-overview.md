---
title: Overview
page_title: Overview
description: Overview
slug: radtreeview-feautres-treeviewitem-overview
tags: overview
published: True
position: 0
---

# Overview

The __RadTreeView__ control provides a way to display information in a hierarchical structure by using collapsible items (nodes). Each treeview item is an instance of the __RadTreeViewItem__ class and it is the only building block of the __RadTreeView__  control. For more information about the structure of a treeview see the [visual structure topic]({%slug radtreeview-visual-structure%}).

Here is a list of the most important treeview item features:

* The appearance of a treeview items can be changed using either [styling]({%slug radtreeview-styling-and-appearance-overview2%}) or [templates]({%slug radtreeview-styles-and-templates-tesmplates-structure%}). You can set the specific templates using the properties __HeaderTemplate__ or __Template__.

* [Populate]({%slug radtreeview-getting-started-populating-with-data%}) your treeview control with items using one of the following approaches: [declaratively]({%slug radtreeview-populating-with-data-declaratively%}), [programmatically]({%slug radtreeview-populating-with-data-in-code-behind%}) or using [data binding]({%slug radtreeview-populating-with-data-data-binding-to-xml%}). 

* Item Editing - use the treeview __IsEditable__ property to enable/disable this behavior. Press __F2__ on the selected node to enable text editing mode. After entering the new text, press the __Enter__ key to save the changes. [Read more]({%slug radtreeview-feautres-treeviewitem-item-editing%})

* Item Images - __RadTreeView__ gives you the ability to define images for each item state. [Read more]({%slug radtreeview-feautres-treeviewitem-item-images%})

* Enable and Disable Items - to disable or enable a node you can use the __IsEnabled__ boolean property. [Read more]({%slug radtreeview-feautres-treeviewitem-enable-disable-items%})

* Selection - __RadTreeView__ supports multiple selection by setting the __SelectionMode__ property. The __RadTreeViewItem__ and __RadTreeView__ classes expose a couple of events for working with selection. [Read more]({%slug radtreeview-feautres-treeviewitem-selection%})

* Expanding and Collapsing Items - you can expand an item by either clicking on the expander icon or by using the code-behind and setting the __IsExpanded__ property. The __RadTreeView__ API gives you the ability to expand or collapse all the items recursively. [Read more]({%slug radtreeview-feautres-treeviewitem-expanding-and-collapsing-items%})

## See Also
 * [How to Edit An Item]({%slug radtreeview-feautres-treeviewitem-item-editing%})
 * [Item Images]({%slug radtreeview-feautres-treeviewitem-item-images%})
 * [Enable and Disable Items]({%slug radtreeview-feautres-treeviewitem-enable-disable-items%})
 * [Working with Selection]({%slug radtreeview-feautres-treeviewitem-selection%})
 * [Expanding and Collapsing Items]({%slug radtreeview-feautres-treeviewitem-expanding-and-collapsing-items%})
 * [BringIntoView Support]({%slug radtreeview-features-treeviewitem-bring-into-view-support%})