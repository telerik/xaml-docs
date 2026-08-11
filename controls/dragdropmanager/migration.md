---
title: DragDropManager Migration
page_title: DragDropManager Migration
description: Check our &quot;DragDropManager Migration&quot; documentation article for the DragDropManager {{ site.framework_name }} control.
slug: dragdropmanager-migration
tags: dragdropmanager,migration
published: True
position: 5
---

# DragDropManager Migration

The article explains the events of the __DragDropManager__.

## Events and API migration

The event that was fired when the drag Starts was __DragQuery__ for the RadDragAndDropManager. Now it is __OnDragInitialize__.

Bellow is the code for the DragQuery event is its corresponding code for the OnDragInitialize event:


<snippet id='dragdropmanager-migration-block_1-cs' />


<snippet id='dragdropmanager-migration-block_2-cs' />

The event corresponding to the __DragInfo__ event in RadDragAndDropManager is now __DragDropComplete__. The __DragDropComplete__ event is the equivalent of the __DragQuery with status DropComplete__.


<snippet id='dragdropmanager-migration-block_3-cs' />


<snippet id='dragdropmanager-migration-block_4-cs' />

The __Drop__ event in DragDropManager corresponds to the __DropInfo event with status DropCompleted__.



<snippet id='dragdropmanager-migration-block_5-cs' />


<snippet id='dragdropmanager-migration-block_6-cs' />

The __DragInfo__ event corresponds to the __GiveFeedback__ event. Basically the GiveFeedback event can be used on the DragSource control to update the Cursor, and the DragEffects for the DragOperation.        

The __DropInfo__ event corresponds to the __DragOver__ event of DradDropManager. The __DragOver__ event can be used as a replacement for the __DropQuery/Info__ events for various purposes, one of which is to __update the AllowedEffects__ for the drag drop operation.  Works both on Source and Destination.


<snippet id='dragdropmanager-migration-block_7-cs' />

The __CancelDrag__ event corresponds to the __QueryContinueDrag__ event. The CancelDrag() method logic can be replaced by subscribing to the QueryContinueDrag event and manipulating the Action property in the QueryContinueEventArgs.        

The control cursor can be set in the GiveFeedbackEventArgs.


<snippet id='dragdropmanager-migration-block_8-cs' />

## Events without analogue

* PreviewGiveFeedback

* PreviewQueryContinueDrag

* PreviewDragEnter

* PreviewDragLeave

* PreviewDragOver

* PreviewDrop

## Missing Functionality

* There is no AutoScrollBehavior out of the box

* There is no DragArrow Cue