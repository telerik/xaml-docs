---
title: DragDropBehavior
page_title: DragDropBehavior
description: DragDropBehavior
slug: dragdropmanager-behaviors-dragdropbehavior
tags: dragdropbehavior
publish: True
position: 0
---

# DragDropBehavior



## DragDropBehavior

The DragDropBehavior is the base class of the Telerik drag-drop behaviors and provides the high level API for handling drag-drop operations. Its methods are automatically called when the corresponding drag-drop event occurs. The DragDropBehavior class inherits from DependencyObject and thus can be bound to other objects.

>When deriving from DragDropBehavior it is advisable not to keep any state in the class, in the form of member variables, because the DragDropBehavior could potentially be shared between several controls.
      	

The most important methods of DragDropBehavior are:

* CanStartDrag – This method is called in the context of the drag source control, just before the drag operation is started. If you return false the drag operation will not start.

* CanDrop – This method is called in the context of the drop target control on each mouse move event and before the call to the Drop method. If you return false the drop will not be allowed and the mouse cursor will change accordingly.

* Drop – This method is called in the context of the drop target control when the mouse button is released, but only if the previous CanDrop call returned true. It is useful when you want to perform additional actions when the drop operation is complete.

* DragDropCompleted – This method is called in the context of the drag source control when the mouse button is released, but only when the previous CanDrop call returned true. It is useful when you want to perform additional actions when the drag is complete. In case the drag source and the drop target are the same control, this method is called after the call to Drop.

* DragDropCanceled – This method is called in the context of the drag source control when the mouse button is released, but only when the previous CanDrop call returned false.

## DragDropState

The context for each of the DragDropBehavior methods is provided in the form of a DragDropState object. It contains references to the source control’s ItemsSource, destination control’s ItemsSource and the dragged items.
      

To determine whether the drag source and the drop target are the same control you could use the IsSameControl property.

>When the context is the drag source control, the DestinationItemsSource property will be undefined; when the context is the drop target control, the SourceItemsSource property will be undefined. In other words, you should use SourceAppointmentsSource only in CanStartDrag and DragDropCompleted/DragDropCanceled, and DestinationAppointmentsSource only in Drop and CanDrop.
      

## IDragVisualProvider

The IDragVisualProvider interface should be implemented in a class when you want to customize the drag visual element, that is moved with the mouse cursor.
      	

* CreateDragVisual – inside this method you should create and return an element that will represent the dragged data.

* GetDragVisualOffset – inside this method you should calculate the offset between the mouse cursor and the drag visual element.

Both methods above receive a single parameter of type DragVisualProviderState, that contains information about the drag operation.



There are several default implementations of IDragVisualProvider:

* ScreenshotDragVisualProvider – drag visual provider that creates screenshots of the dragged elements and puts them into a StackPanel.

* DefaultDragVisualProvider (not implemented yet) – drag visual provider that creates the standard Telerik drag visual (used in RadTreeView and RadScheduleView).

## DataConverter

DataConverter provides basic data conversion API for converting the dragged data into different formats – ConvertTo(), CanConvertTo() and GetConvertToFormats(). The two scenarios this class is used are:

* Drag to a control having items of different Type than the source or a third party application - when the target requests data from the carried IDataObject, the request is redirected through the DataConverter, so it can be handled without overriding the IDataObject itself.

* Drop from a control having items of different Type than the target or from a third party application – when the DragDropBehavior cannot find appropriate data in the carried IDataObject it tries to convert the data to a useful Type using its DataConverter instance if present.

In both cases GetConvertToFormats() should return formats acceptable by the target and when a certain format is requested, ConvertTo() should return the correct data.

>The DataObjectHelper class provides helper methods for retrieving data from the provided DataObject, that work in both Full and Partial trust modes.

>tipYou can download some runnable projects from our online SDK repository
              [here](https://github.com/telerik/xaml-sdk), the examples are listed bellow __DragDrop__ folder.
            
