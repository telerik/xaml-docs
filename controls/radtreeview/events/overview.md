---
title: Overview
page_title: Overview
description: Overview
slug: radtreeview-events-overview
tags: overview
published: True
position: 0
---

# Overview



This topic covers the specific events exposed by the __RadTreeView__ control. The events are grouped by their general purpose.
	  

## Click Events

__RadTreeView__ exposes the following events when a __RadTreeViewItem__ is clicked with the Mouse left button:
		

* __ItemClick__ – raised on __MouseLeftButtonUp__ when a __RadTreeViewItem__ is clicked with Mouse left button.
			

* __ItemDoubleClick__ – raised on __MouseLeftButtonUp__ when a __RadTreeViewItem__ is double clicked with Mouse left button. The time slot between two clicks must be less than or equal to 300ms in order to be registered as a double click.
			

__RadTreeViewItem__ exposes the following events:
		

* __Click__ – raised on __MouseLeftButtonUp__ when the item is clicked with Mouse left button.
			

* __DoubleClick__ – raised on __MouseLeftButtonUp__ when the item is double clicked with Mouse left button. The time slot between the two clicks must be less than or equal to 300ms to register these clicks as a double click.
			

## Click Events sequence. 

Currently a successful __RadTreeViewItem__ double click fires the following events:
		

* __ItemClick__ event of the __RadTreeView__

* __DoubleClick__ event of the __RadTreeViewItem__

* __ItemDoubleClick__ event of the __RadTreeView__

* __Click__ event of the __RadTreeViewItem__

* __ItemClick__ event of the __RadTreeView__

## Edit Events

__RadTreeView__exposes the following events regarding the data manipulation:
		

* __PreviewEditStarted____-__raised just before the editing of an item has started. This is a wrapper for the __EditableHeaderedItemsControl.PreviewEditStarted__ routed event. The __PreviewEditStarted__ event handler receives two arguments:
			

* The sender argument contains the __RadTreeView__. This argument is of type object, but can be cast to the __RadTreeView__ type.
				

* A __RadTreeViewItemEditedEventArgs__ object.
				

* __EditStarted__ - raised when the editing of an item has just started. This is a wrapper for the __EditableHeaderedItemsControl.EditStarted__ routed event. The __EditStarted__ event handler receives two arguments:
			

* The sender argument contains the __RadTreeView__. This argument is of type object, but can be cast to the __RadTreeView__ type.
				

* A __RadTreeViewItemEditedEventArgs__ object.
				

* __PreviewEdited__ - occurs before a treeview item has accepted the new __Edited__data. The __PreviewEdited__ event handler receives two arguments:
			

* The sender argument contains the __RadTreeView__. This argument is of type object, but can be cast to the __RadTreeView__ type.
				

* A __RadTreeViewItemEditedEventArgs__ object.
				

* __Edited__- raised when the editing of an item has been committed. The __Edited__event handler receives two arguments:
			

* The sender argument contains the __RadTreeView__. This argument is of type object, but can be cast to the __RadTreeView__ type.
				

* A __RadTreeViewItemEditedEventArgs__ object.
				

* __PreviewEditCanceled__ - raised just before the item editing has been canceled. This is a wrapper for the __EditableHeaderedItemsControl.__

* __PreviewEditCanceled__ routed event. The __PreviewEditCanceled__ event handler receives two arguments:
			

* The sender argument contains the __RadTreeView__. This argument is of type object, but can be cast to the __RadTreeView__ type.
				

* A __RadTreeViewItemEditedEventArgs__ object.
				

* __EditCanceled__ - raised when the item editing has been canceled. This is a wrapper for the __EditableHeaderedItemsControl.EditCanceled__ routed event. The __EditCanceled__ event handler receives two arguments:
			

* The sender argument contains the __RadTreeView__. This argument is of type object, but can be cast to the __RadTreeView__ type.
				

* A __RadTreeViewItemEditedEventArgs__ object.
				

>tipWhen a __RadTreeViewItem__ is edited and the changes are __committed__, the lifecycle of the raised events is:
		  

1. __PreviewEditStarted__

1. __EditStarted__

1. __PreviewEdited__

1. __Edited__

>tipWhen a __RadTreeViewItem__ is edited and the changes are __canceled__, the lifecycle of the raised events is:
		  

1. __PreviewEditStarted__

1. __EditStarted__

1. __PreviewEditCanceled__

1. __EditCanceled__

## Selection Events

__RadTreeView__exposes the following events regarding the selection:
		

* __PreviewSelected__ - occurs before a child treeview item is selected. The __PreviewSelected__ event handler receives two arguments:
			

* The sender argument contains the __RadTreeView__. This argument is of type object, but can be cast to the __RadTreeView__ type.
				

* A __RadRoutedEventArgs__ object.
				

* __Selected__ - occurs when a child __RadTreeView__ item has been selected. The __Selected__ event handler receives two arguments:
			

* The sender argument contains the __RadTreeView__. This argument is of type object, but can be cast to the __RadTreeView__ type.
				

* A __RadRoutedEventArgs__ object.
				

* __SelectionChanged__ - occurs after the value of the __SelectedItems__ property of a tree is changed. The __SelectionChanged__ event handler receives two arguments:
			

* The sender argument contains the __RadTreeView__. This argument is of type object, but can be cast to the __RadTreeView__ type.
				

* A __SelectionChangedEventArgs__ object.
				

* __PreviewUnselected__ - occurs before a child treeview item is unselected. The __PreviewUnselected__ event handler receives two arguments:
			

* The sender argument contains the __RadTreeView__. This argument is of type object, but can be cast to the __RadTreeView__ type.
				

* A __RadRoutedEventArgs__ object.
				

* __Unselected__ - occurs when a child treeview item has been unselected. The __Unselected__ event handler receives two arguments:
			

* The sender argument contains the __RadTreeView__. This argument is of type object, but can be cast to the __RadTreeView__ type.
				

* A __RadRoutedEventArgs__ object.
				

>tipWhen working with selection the lifecycle of the raised events is:

1. __PreviewSelected__

1. __Selected__

1. __SelectionChanged__

1. __PreviewUnselected__

1. __Unselected__

## Expand\Collapse Events

__RadTreeView__ exposes the following events regarding the expanding and collapsing of treeview items:
		

* __PreviewExpanded__ - occurs before a child treeview item is expanded. The __PreviewExpanded__ event handler receives two arguments:
			

* The sender argument contains the __RadTreeView__. This argument is of type object, but can be cast to the __RadTreeView__ type.
				

* A __RadRoutedEventArgs__ object.
				

* __Expanded__ - occurs when a child treeview item has been expanded. The __Expanded__ event handler receives two arguments:
			

* The sender argument contains the __RadTreeView__. This argument is of type object, but can be cast to the __RadTreeView__ type.
				

* A __RadRoutedEventArgs__ object.
				

* __PreviewCollapsed__ - occurs before a child treeview item is collapsed. The __PreviewCollapsed__ event handler receives two arguments:
			

* The sender argument contains the __RadTreeView__. This argument is of type object, but can be cast to the __RadTreeView__ type.
				

* A __RadRoutedEventArgs__ object.
				

* __Collapsed__ - occurs when a child treeview item has been collapsed. The __Collapsed__ event handler receives two arguments:
			

* The sender argument contains the __RadTreeView__. This argument is of type object, but can be cast to the __RadTreeView__ type.
				

* A __RadRoutedEventArgs__ object.
				

>tipWhen expanding and collapsing items the lifecycle of the raised events is:

1. __PreviewExpanded__

1. __Expanded__

1. __PreviewCollapsed__

1. __Collapsed__

## Check\Uncheck Events

__RadTreeView__ exposes the following events regarding the checking and unchecking of treeview items:
		

* __PreviewChecked__ - occurs before a child treeview item is checked. The __PreviewChecked__ event handler receives two arguments:
			

* The sender argument contains the __RadTreeView__. This argument is of type object, but can be cast to the __RadTreeView__ type.
				

* A __RadRoutedEventArgs__ object.
				

* __Checked__ - occurs when a child treeview item has been checked. The __Checked__ event handler receives two arguments:
			

* The sender argument contains the __RadTreeView__. This argument is of type object, but can be cast to the __RadTreeView__ type.
				

* A __RadRoutedEventArgs__ object.
				

* __PreviewUnchecked__ - occurs before a child treeview item is unchecked. The __PreviewUnchecked__ event handler receives two arguments:
			

* The sender argument contains the __RadTreeView__. This argument is of type object, but can be cast to the __RadTreeView__ type.
				

* A __RadRoutedEventArgs__ object.
				

* __Unchecked__ - occurs when a child treeview item has been unchecked. The __Unchecked__  event handler receives two arguments:
			

* The sender argument contains the __RadTreeView__. This argument is of type object, but can be cast to the __RadTreeView__ type.
				

* A __RadRoutedEventArgs__ object.
				

>tipWhen checking and unchecking items the lifecycle of the raised events is:

1. __PreviewChecked__

1. __Checked__

1. __PreviewUnchecked__

1. __Unchecked__

## Other Events

* __LoadOnDemand__ - occurs when a child treeview item is loading its child items on demand. The __LoadOnDemand__event handler receives two arguments:
			

* The sender argument contains the __RadTreeView__. This argument is of type object, but can be cast to the __RadTreeView__ type.
				

* A __RadRoutedEventArgs__ object, that gives you access to the source and the original source of the event as follows:
				

* __OriginalSource__ - the original source of the event
					

* __Source__ - {% if site.site_name == 'Silverlight' %}the original source of the event{% endif %}{% if site.site_name == 'WPF' %} the control that is currently handling the event.{% endif %}

>For more information about the load on demand feature, take a look at the [Load on Demand]({%slug radtreeview-features-load-on-demand%}) topic.
		  

* __ItemPrepared__ - occurs when a child __RadTreeViewItem__ has been prepared and is now ready for use.
			

* The sender argument contains the __RadTreeView__. This argument is of type object, but can be cast to the __RadTreeView__ type.
				

* A __RadRoutedEventArgs__ object.
				

>The __ItemPrepared__ event is a very important event. It is used to perform binding of __RadTreeViewItem__ properties to the data objects. For more information, take a look at the [Working with ItemPrepared Event]({%slug radtreeview-events-working-with-item-prepared-event%}) topic.
		  

# See Also

 * [Overview]({%slug radtreeview-overview2%})

 * [Visual Structure]({%slug radtreeview-visual-structure%})

 * [Populating with Data]({%slug radtreeview-populating-with-data-overview%})
