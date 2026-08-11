---
title: Drag and Drop
page_title: Drag and Drop
description: Learn how to use the DragDropManager property to implement the drag and drop functionality of RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-drag-drop-scenario
tags: drag,and,drop
published: True
position: 0
---

# Drag and Drop

> Full implementation of __Drag__ and __Drop__ between __GridView__ and __TreeView__ is available in this {% if site.site_name == 'WPF' %}[online demo](https://demos.telerik.com/wpf/#DragAndDrop/TreeToGrid){% endif %}
{% if site.site_name == 'Silverlight' %}[online demo](https://demos.telerik.com/silverlight/#DragAndDrop/TreeToGrid){% endif %}

You can implement drag and drop functionality by integrating RadGridView with [DragDropManager]({%slug dragdropmanager-overview%}). The following snippet demonstrates how this can be achieved via an [attached behavior]({%slug common-mvvm-attached-behavior%}). The full demo can be reviewed in the [Drag and Drop within RadGridView]({%slug dragdropmanager-howto-draganddrop-within-radgridview%}) article of the **DragDropManager** documentation or in the **Drag And Drop Within RadGridView** demo from the [SDK Samples Browser](https://demos.telerik.com/xaml-sdkbrowser/).

__Example 1: Implementing an Attached Behavior for the Drag and Drop Operations__
<snippet id='radgridview-how-to-drag-drop-scenario-example_1_implementing_an_attached_behavior_for_the_drag_and_drop_operations-cs' />


## See Also

* [DragDropManager Getting Started]({%slug dragdropmanager-getting-started%})
* [Drag and Drop from RadGridView to RadDiagram]({%slug drag-and-drop-from-radgridview-to-raddiagram%})
      

