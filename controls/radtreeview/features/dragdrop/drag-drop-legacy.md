---
title: Legacy Drag Drop Mode
page_title: Legacy Drag Drop Mode
description: Check our &quot;Legacy Drag Drop Mode&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-features-drag-and-drop-legacy
tags: drag,and,drop
published: True
position: 2
---

# Legacy Drag Drop Mode

The RadTreeView's drag drop feature works with the Telerik DragDropManager, but originally it was implemented with the legacy RadDragAndDropManager.

[DragDropManager]({%slug dragdropmanager-overview%}) is the newer implementation of RadDragAndDropManager used across the Telerik controls. In RadTreeView the legacy drag/drop customization entry points are still available for backwards compatibility. However, we recommend using the new DragDropManager implementation (available since Q2 2013).

The default drag drop execution mode is using the new DragDropManager (since Q2 2014), but this can be changed by setting the  __TreeViewSettings.DragDropExecutionMode__ property to __Legacy__. This is useful in case you upgrade from a very old version of Telerik UI for WPF to a more recent one and you have heavy customization on the drag/drop functionality using the drag/drop events of RadTreeView.

#__Example 1: Setting DragDropExecutionMode__
<snippet id='radtreeview-features-dragdrop-drag-drop-legacy-block_1-xaml' />

The `treeView` namespace points to `xmlns:treeView="clr-namespace:Telerik.Windows.Controls.TreeView;assembly=Telerik.Windows.Controls.Navigation"`

The main difference between the DragDropManager and RadDragAndDropManager in the context of RadTreeView is that they provide different events for customization of the drag and drop actions. Read more in the [DragDropManager Migration]({%slug dragdropmanager-migration%}) article. 

The legacy mode works with the following set of RadTreeView drag/drop events which are propagated to the drag/drop events of RadDragAndDropManager:

* __PreviewDragStarted__
* __DragStarted__
* __PreviewDragEnded__
* __DragEnded__

>tip Note that the legacy drag/drop events are not invoked in case you use the default __DragDropExecutionMode__ which is called __New__.

__RadTreeView__ actually handles the drag/drop events of RadDragAndDropManager which means that in order to subscribe new event handlers, you will need to use the __AddHandler__ method of the control.

`public void AddHandler( RoutedEvent routedEvent, Delegate handler, bool handledEventsToo );`

When RadTreeView detects a valid drag operation, it invokes the __PreviewDragStarted__ and __DragStarted__  events. When a valid drop operation (the selected Item is dropped onto another Item or in between Items) is detected, the __PreviewDragEnded__ and __DragEnded__ events are invoked. Both __PreviewDragStarted__ and __PreviewDragEnded__ events can be cancelled by setting the __Handled__ property of the event argument to __True__ in the event handler.

__Example 2: Cancel drag operation__  
<snippet id='radtreeview-features-dragdrop-drag-drop-legacy-block_2-cs' />
<snippet id='radtreeview-features-dragdrop-drag-drop-legacy-block_3-vb' />

>tip Handling the __PreviewDragStarted__ event will cancel the __drag__ operation. This is equivalent to set the __RadTreeView__'s __IsDragDropEnabled__ property to __False__. 'e.Handled = True' - where 'e' is the RadTreeViewDragEventArgs class passed as an argument of the event handler.

>tip Handling the __PreviewDragEnded__ event will cancel the __drop__ operation. This is useful, when you want to cancel adding/removing items from the __RadTreeView__'s __ItemsCollection__. 'e.Handled = True' - where 'e' is the RadTreeViewDragEventArgs class passed as an argument of the event handler.

The type of the event arguments for the __PreviewDragStarted__ and __DragStarted__ events is __RadTreeViewDragEventArgs__. Via the __RadTreeViewDragEventArgs__ you can get access to the items being dragged:

__Example 3: Get current dragged items__  
<snippet id='radtreeview-features-dragdrop-drag-drop-legacy-block_4-cs' />
<snippet id='radtreeview-features-dragdrop-drag-drop-legacy-block_5-vb' />

The type of the event arguments for the __PreviewDragEnded__ and __DragEnded__ events is __RadTreeViewDragEndedEventArgs__. Via the __RadTreeViewDragEndedEventArgs__ you can get access to the following items and properties:

* __DraggedItems__: A collection of Items being dragged (this is useful when multi-selection is enabled - __SelectionMode__ property of the __RadTreeView__ is set to __True__). SelectionMode is enumeration.
* __DropPosition__: Indicates the relationship of the Items being dropped and can be a __DropPosition__ enumeration value __After__, __Below__ or __Inside.__
* __TargetDropItem__: The Item being dragged to.
* __IsCanceled__: A boolean property, indicates whether the drag and drop operation is cancelled or not.

__Example 4: Subscribing to the DragEnded event__  
<snippet id='radtreeview-features-dragdrop-drag-drop-legacy-block_6-cs' />
<snippet id='radtreeview-features-dragdrop-drag-drop-legacy-block_7-vb' />

Note that the __TargetDropItem__ property may be null if the drop is in an empty treeview. That's why when you use that property it always has to be checked:

__Example 5: Checking TargetDropItem property__  
<snippet id='radtreeview-features-dragdrop-drag-drop-legacy-block_8-cs' />

## See Also
 * [Enable Only Drop Inside]({%slug radtreeview-how-to-enabled-drop-inside-only%})
 * [Disable Drop at Specific Location]({%slug radtreeview-how-to-disable-drop-specific-location%})
 * [Implement Copy Drag]({%slug radtreeview-how-to-implement-copy-drag%})
 * [Auto Expand on Drag Over]({%slug radtreeview-how-to-enable-auto-expand-drag-over%})