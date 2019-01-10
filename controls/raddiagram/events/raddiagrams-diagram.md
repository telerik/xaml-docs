---
title: Diagram Events
page_title: Diagram Events
description: This article describes the events of the RadDiagram.
slug: raddiagrams-events-diagram
tags: diagram,events
published: True
position: 0
---

# Diagram Events

This topic covers the specific events exposed by the __RadDiagram__. The events are grouped by their general purpose.	  

## Selection Events

* __PreviewSelectionChanged__: Occurs when the selection of the diagram starts changing.			

* __SelectionChanged__: Occurs when the selected item/items are changed.			

* __SelectionBoundsChanged__: Occurs when the selection adorner rectangle is changed.			

## Resizing Events

* __PreviewResize__: Occurs when item/items is/are about to be resized.			

* __Resize__: Occurs when item/items is/are resized.			

## Rotation Events

* __PreviewRotate__: Occurs when item/items is/are about to be rotated.			

* __Rotate__: Occurs when item/items is/are rotated.			

## Drag Events

* __PreviewDrag__: Occurs when dragging operation is about to be performed.			

* __Drag__: Occurs when dragging operation is performed.			

## Serialization Events

* __Deserialized__: Occurs when deserialization process end.			

* __Serialized__: Occurs when serialization process end.			

* __ShapeDeserialized__: Occurs when shape is deserialized.			

* __ShapeSerialized__: Occurs when shape is serialized.			

* __ConnectionDeserialized__: Occurs when connection is deserialized.			

* __ConnectionSerialized__: Occurs when connection is serialized.			

* __MetadataDeserialized__: Occurs when metadata is deserialized.			

* __MetadataSerialized__: Occurs when metadata is serialized.			

## Click Events

* __ShapeClicked__: Occurs when shape is clicked.			

* __ShapeDoubleClicked__: Occurs when shape is double clicked.			

## Command Events

* __CommandExecuted__: Occurs when DiagramCommand is executed.			

## Items Collection Events

* __ItemsChanging__: Occurs while the Items collection is changing its items.			

* __ItemsChanged__: Occurs when Items collection is changed.			

## Connector Events

* __ConnectorActivationChanged__: Occurs after a connector have been activated or deactivated.

## Connection Manipulation Events

* __ConnectionManipulationStarted__: This event is raised by a __RadDiagram__ to inform that a connection manipulation is starting.			

* __ConnectionManipulationCompleted__: This event is raised by a __RadDiagram__ to inform that a connection manipulation is ending.			

When you manipulate a connection you have two different stages of the process - start of the manipulation and end of the manipulation. When you start manipulating a connection - for instance creating a new connection or detaching a connection, the __ConnectionManipulationStarted__ event is fired. When the manipulation is in its ending stage - the __ConnectionManipulationCompleted__ event is fired. And it is important to work with both events in order to cover all parts of a single connection manipulation. And it is also very crucial to note that both events are designed to represent __preview__ events and their purpose is to allow you to __cancel a connection manipulation__.		

This means that the __ConnectionManipulationStarted__ event is fired before the manipulation of a connection is truly started - in this case the __EventArgs (e)__ of the event hold the __e.Connection__ that is going to be manipulated (or created), and the __e.Shape__ and the __e.Connector__ that are part of the manipulation. In case you're starting to drag a new connection out of the connector of a shape, then the __ConnectionManipulationStarted__ will be fired before the connection is created. This way you can cancel the process and therefore the __e.Connection__ property will be null, while the __e.Shape__ and __e.Connector__ properties will hold the shape and the connector where the drag is originating from. And if you're detaching a connection, again you'll have to handle the __ConnectionManipulationStarted__ event as you're starting a new manipulation of a connection. When detaching a connection, the __e.Connection__ property will reflect the connection that is being detached and the __e.Shape__ property will reflect the shape from which the connection is detached. However, please note that in this case the __e.Shape IncomingLinks/OutgoingLinks__ collections will still hold a reference of the current connection as the __ConnectionManipulationStarted__ event is a preview event and when it is fired, the connection isn't really detached yet.		

The same logic applies for the __ConnectionManipulationCompleted__ event - it is fired just before a connection manipulation is over - for example when attaching a connection to a shape. Again you'll have a reference of the __e.Connection__ that is being attached and the __e.Shape__ to which the connection will be attached, but at this point the connection is still not attached and therefore its __SourceShape/TargetShape__ properties are not updated. 		

The arguments of both events expose a __ManipulationStatus__ property. It serves as an indicator for the status of the current connection manipulation. This property is an enumeration that provides the following members:	  

* __Attaching__: This represents the status of a connection that is currently being attached to a shape. This is the status indicated by a __ConnectionManipulationStarted__ event when a connection is created by dragging it out of a connector or in a __ConnectionManipulationCompleted__ when a connection is being attached to a new connector.			

* __Detaching__: This represents the status of a connection that is currently being detached from a shape. Please note that this status can only be indicated by a __ConnectionManipulationStarted__ event as the detaching of a connection can only be in the beginning of a manipulation.			

* __Moving__: This represents the status of a connection that is currently being moved. Usually this is a status indicated by a __ConnectionManipulationStarted__ while moving a floating connection.			

* __Moved__: This represents the status of a connection that was moved. Usually this is a status indicated by a __ConnectionManipulationCompleted__ event fired after releasing the mouse to create a floating connection.			

## Layout Events

* __DiagramLayoutComplete__: Occurs when the Layout operation has completed.			

## Grouping Events

* __GroupsChanged__: Occurs when the root level logical group is created or ungrouped.			

## Pan and Zoom Events

* __PreviewPan__: Occurs before a pan operation have been performed.

* __Pan__: Occurs when a pan operation has been performed.

* __PositionChanged__: Occurs when the position of the diagram is changed.			

* __ViewportChanged__: Occurs when the viewport of the diagram is changed.	

* __PreviewZoom__: Occurs before a zoom operation have been performed.		

* __ZoomChanged__: Occurs when a zoom operation has been performed.	
 		

## Container Generation Events

* __VisualChildrenChanged__: Occurs when a visual object (RadDiagramShape or RadDiagramConnection) is added or removed in the ItemsHost of the Diagram.			

* __GraphSourceChanged__: Occurs when the GraphSource is changed and all DiagramItems are properly measured.			

* __GraphSourceChanging__: Occurs when the GraphSource starts changing.			

## AdditionalContent Events

* __PreviewAdditionalContentActivated__: This event is raised by a __RadDiagram__ to inform layouts that the additional content is going to be activated. The event handler receives two arguments:			

	* The __sender__ argument contains the __RadDiagram__ This argument is of type __object__, but can be cast to the __RadDiagram__ type.				

	* An __AdditionalContentActivatedEventArgs__ object, that gives you access to a __ContextItems__ collection. This collection of __IDiagramItem__ objects represents the items that have activated the additional content. In most cases it contains a single item - the __RadDiagramItem__ that has activated the __SettingsPane__.				

	>tip Please note that you can handle this event in order to disable the __AdditionalContent (SettingsPane)__ from displaying on certain __RadDiagramItems__.			  

* __AdditionalContentActivated__: This event is raised by a __RadDiagram__ to inform layouts that the additional content has been activated. The event handler receives two arguments:			

	* The __sender__ argument contains the __RadDiagram__ This argument is of type __object__, but can be cast to the __RadDiagram__ type.				

	* An __AdditionalContentActivatedEventArgs__ object, that gives you access to a __ContextItems__ collection. This collection of __IDiagramItem__ objects represents the items that have activated the additional content. In most cases it contains a single item - the __RadDiagramItem__ that has activated the __SettingsPane__.				

## See Also
 * [Getting Started]({%slug raddiagram-getting-started%})
 * [Populating with Data]({%slug raddiagram-data-overview%})
 * [Shapes]({%slug raddiagrams-features-shapes%})
 * [Connections]({%slug raddiagrams-features-connections%})
 * [Clipboard Operations]({%slug raddiagrams-features-clipboard%})
 * [Removing Items]({%slug raddiagrams-features-delete%})
 * [Undo and Redo]({%slug raddiagrams-features-undo-redo%})
 * [Items Events]({%slug raddiagrams-events-item%})