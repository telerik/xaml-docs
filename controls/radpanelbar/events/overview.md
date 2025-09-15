---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadPanelBar {{ site.framework_name }} control.
slug: radpanelbar-events-overview
tags: overview
published: True
position: 0
---

# Overview

This topic covers the specific events exposed by the __RadPanelBar__control. The events are grouped by their general purpose.	  

## Click Events

__RadPanelBar__ exposes the following events when a __RadPanelBarItem__ is clicked with the Mouse left button:		

* __ItemClick__ – raised on __MouseLeftButtonUp__ when a __RadPanelBarItem__ is clicked with Mouse left button.			

* __ItemDoubleClick__ – raised on __MouseLeftButtonUp__ when a __RadPanelBarItem__ is double clicked with Mouse left button. The time slot between two clicks must be less than or equal to 300ms in order to be registered as a double click.			

__RadPanelBarItem__ exposes the following events:		

* __Click__ – raised on __MouseLeftButtonUp__ when the item is clicked with Mouse left button.			

* __DoubleClick__ – raised on __MouseLeftButtonUp__ when the item is double clicked with Mouse left button. The time slot between the two clicks must be less than or equal to 300ms to register these clicks as a double click. 

## Click Events sequence.  

Currently a successful __RadPanelBarItem__ double click fires the following events:  

* __ItemClick__ event of the __RadPanelBar__

* __DoubleClick__ event of the __RadPanelBarItem__

* __ItemDoubleClick__ event of the __RadPanelBar__

* __Click__ event of the __RadPanelBarItem__

* __ItemClick__ event of the __RadPanelBar__

## Selection Events

__RadPanelBar__ exposes the following events regarding the selection:		

* __PreviewSelected__ - occurs before a child item is selected. The __PreviewSelected__ event handler receives two arguments:			
	* The sender argument contains the __RadPanelBar__. This argument is of type object, but can be cast to the __RadPanelBar__ type.
	* A __RadRoutedEventArgs__ object.				

* __Selected__ - occurs when a child __RadPanelBarItem__ has been selected. The __Selected__ event handler receives two arguments:
	* The sender argument contains the __RadPanelBar__. This argument is of type object, but can be cast to the __RadPanelBar__ type.
	* A __RadRoutedEventArgs__ object.			

* __SelectionChanged__ - occurs after the value of the __SelectedItems__ property of a panel bar is changed. The __SelectionChanged__ event handler receives two arguments:			
	* The sender argument contains the __RadPanelBar__. This argument is of type object, but can be cast to the __RadPanelBar__ type.
	* A __SelectionChangedEventArgs__ object.				

* __PreviewUnselected__ - occurs before a child item is unselected. The __PreviewUnselected__ event handler receives two arguments:
	* The sender argument contains the __RadPanelBar__. This argument is of type object, but can be cast to the __RadPanelBar__ type.
	* A __RadRoutedEventArgs__ object.				

* __Unselected__ - occurs when a child item has been unselected. The __Unselected__ event handler receives two arguments:
	* The sender argument contains the __RadPanelBar__. This argument is of type object, but can be cast to the __RadPanelBar__ type.
	* A __RadRoutedEventArgs__ object.				

>When working with selection the lifecycle of the raised events is:
> 1. __PreviewSelected__
> 2. __Selected__
> 3. __SelectionChanged__
> 4. __PreviewUnselected__
> 5. __Unselected__

## Expand\Collapse Events

__RadPanelBar__ exposes the following events regarding the expanding and collapsing of panelbar items:		

* __PreviewExpanded__ - occurs before a child item is expanded. The __PreviewExpanded__ event handler receives two arguments:
	* The sender argument contains the __RadPanelBar__. This argument is of type object, but can be cast to the __RadPanelBar__ type.
	* A __RadRoutedEventArgs__ object.				

* __Expanded__ - occurs when a child item has been expanded. The __Expanded__ event handler receives two arguments:
	* The sender argument contains the __RadPanelBar__. This argument is of type object, but can be cast to the __RadPanelBar__ type.
	* A __RadRoutedEventArgs__ object.				

* __PreviewCollapsed__ - occurs before a child item is collapsed. The __PreviewCollapsed__ event handler receives two arguments:
	* The sender argument contains the __RadPanelBar__. This argument is of type object, but can be cast to the __RadPanelBar__ type.
	* A __RadRoutedEventArgs__ object.				

* __Collapsed__ - occurs when a child item has been collapsed. The __Collapsed__ event handler receives two arguments:
	* The sender argument contains the __RadPanelBar__. This argument is of type object, but can be cast to the __RadPanelBar__ type.
	* A __RadRoutedEventArgs__ object.					

>When expanding and collapsing items the lifecycle of the raised events is:
> 1. __PreviewExpanded__
> 2. __Expanded__
> 3. __PreviewCollapsed__
> 4. __Collapsed__

## Drag and Drop Events

__RadPanelBar__ exposes the following events regarding the drag and drop:		

* __PreviewDragStarted__ - occurs before the drag is started. The __PreviewDragStarted__ event handler receives two arguments:			
	* The sender argument contains the __RadPanelBar__. This argument is of type object, but can be cast to the __RadPanelBar__ type.
	* A __RadPanelBarDragEventArgs__ object.				

* __DragStarted__ - occurs when the drag has started. The __DragStarted__ event handler receives two arguments:
	* The sender argument contains the __RadPanelBar__. This argument is of type object, but can be cast to the __RadPanelBar__ type.
	* A __RadPanelBarDragEventArgs__ object.			

* __PreviewDragEnded__ - occurs before the drag has been ended. The __PreviewDragEnded__ event handler receives two arguments:
	* The sender argument contains the __RadPanelBar__. This argument is of type object, but can be cast to the __RadPanelBar__ type.
	* A __RadPanelBarDragEndedEventArgs__ object.				

* __DragEnded__ - occurs when the drag has ended. The __DragEnded__ event handler receives two arguments:
	* The sender argument contains the __RadPanelBar__. This argument is of type object, but can be cast to the __RadPanelBar__ type.
	* A __RadPanelBarDragEndedEventArgs__ object.				

>When working with drag and drop the lifecycle of the raised events is:
> 1. __PreviewDragStarted__
> 2. __DragStarted__
> 3. __PreviewDragEnded__
> 4. __DragEnded__

>tip Handling the __PreviewDragEnded__ event will cancel the __drop__ operation. This is useful, when you want to cancel adding/removing items from the __RadPanelBar__'s __ItemsCollection__.		  

#### __C#__
```C#
	private void RadPanelBar_PreviewDragEnded(object sender, RadTreeViewDragEndedEventArgs e)
	{
	    e.Handled = true;
	}
```
#### __VB.NET__
```VB.NET
	Private Sub RadPanelBar_PreviewDragEnded(sender As Object, e As RadTreeViewDragEndedEventArgs)
	    e.Handled = True
	End Sub
```