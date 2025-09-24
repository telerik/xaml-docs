---
title: Services
page_title: Services
description: Check our &quot;Services&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagram-features-services
tags: services
published: True
position: 16
---

# Services

This tutorial describes the __Diagramming Framework Services__.	  

The __Diagramming Framework__ exposes a set of services that control and configure different diagramming tools and features. This is why the services come in handy in scenarios requiring significant customizations in the default behavior of the __RadDiagram__ and its elements.	  

## Service Locator

In order to manipulate, change or access a __Diagramming Service__, you have to use the __RadDiagram.ServiceLocator__. This property allows you to get a service instance, register new service or register the default diagramming services. The members exposed by the __ServiceLocator__ are listed below:		

* __RegisterDefaultServices()__ - this method registers the default Diagramming services. However, please note that the __RadDiagram__ constructor internally calls this method during initialization. This is why the method is usefull mostly in scenarios where custom services are registered within a __RadDiagram__ instance and you need to dynamically revert back to the default services.			

	```C#
		xDiagram.ServiceLocator.RegisterDefaultServices();
	```
	```VB.NET
		xDiagram.ServiceLocator.RegisterDefaultServices()
	```
		
* __GetService<T>()__ where __T__ represents a service interface - this method returns a service instance used by a __RadDiagram__. The type parameter allows you to specify the interface of the service you need to access. For example, if you want to get the resizing service currently used in a RadDiagram instance, you need to ask for the service implementing the __IResizingService__ interface:

	```C#
		xDiagram.ServiceLocator.GetService<IResizingService>();
	```
	```VB.NET
		xDiagram.ServiceLocator.GetService(Of IResizingService)()
	```
	
* __Register<T>(T service)__ - this method allows you to register a new service in a __RadDiagram__. Please note that the type parameter __T__ represents the service interface type, while the method argument allows you to provide a new service class.
	For instance, if you create a custom resizing service, you can register it in a __RadDiagram__ instance:
	
	```C#
		public class CustomResizingService : ResizingService
		{
			public CustomResizingService(IGraphInternal graph):base(graph)
			{
			}
			   
			...
		}	
			
		public partial class Services : UserControl
		{
			public Services()
			{
				InitializeComponent();
				
				xDiagram.ServiceLocator.Register<IResizingService>(new CustomResizingService(this.xDiagram));
			}
		}
	```
	```VB.NET
		Public Class CustomResizingService
			Inherits ResizingService
			Public Sub New(graph As IGraphInternal)
				MyBase.New(graph)
			End Sub
		End Class

		Public Partial Class Services
			Inherits UserControl
			Public Sub New()
				InitializeComponent()

				xDiagram.ServiceLocator.Register(Of IResizingService)(New CustomResizingService(Me.xDiagram))
			End Sub
		End Class	
	```

	When registering a new [SerializationService](#serializationservice), you also have to recreate and register the [DataTransferService](#datatransferservice) in the service locator:

	```C#
		xDiagram.ServiceLocator.Register<ISerializationService>(new CustomSerializationService(this.xDiagram));
		xDiagram.ServiceLocator.Register<IDataTransferService>(new DataTransferService(this.xDiagram));
	```
	```VB.NET
		xDiagram.ServiceLocator.Register(Of ISerializationService)(New CustomSerializationService(Me.xDiagram))
    		xDiagram.ServiceLocator.Register(Of IDataTransferService)(New DataTransferService(Me.xDiagram))
	```


* __ServiceRegistered__ - this event occurs when a service is registered. You can handle it to keep track of the services changes in a __RadDiagram__ instance.

## AdornerService

This service manages the __ManipulationAdroner__ and specifically how it should be rendered and where it should be displayed. The service implements the __IAdornerService__ interface.		

The __AdornerService__ class exposes the following virtual methods, which can get overridden in order to customize the behavior of the service:		

* __UpdateAdornerBounds__ - this method updates the bounds of the __ManipulationAdroner__. It has two different overloads - the first one allows you to pass the new bounds through a __Rect__ argument, while the second overload of the method allows you to provide position (argument of type Point), Width and Height that are used to calculate the new bounds of the __ManipulationAdroner__.			

* __UpdateAdornerAngle__ - this method determines the rotation angle of the __ManipulationAdroner__.			

## DataTransferService

This service handles:

* clipboard operations within the RadDiagram

* application-level drag and drop operations between a __RadDiagram__ and another control			

* drag and drop operations between the __RadDiagram__ and elements from external applications			

The __DataTranferService__ implements the __IDataTransferService__ interface. It exposes the following virtual methods, which can get overridden in order to customize the behavior of the service:		

* __HandleDrop__ - this method handles the transfer of data when there is a drop action. This can be both an internal drop (from one control to another within the same application) as well as an external drop operation (from one application to another or from the file system to an application).			

* __HandlePaste__ - this method handles the transfer of data when a copy-paste or cut-paste operation is performed.			

* __CreateShapeFromImage__ - this method creates a __RadDiagramShape__ for a given image.			

## DraggingService

This service manages the translation of items on the surface. It exposes the following members:

_Events_:
* __StartDragging__ - occurs when user has done MouseDown on top of an item and has moved the mouse further than the __DiagramConstants.StartDragDelta__ constant.
* __Dragging__ - invoked on every MouseMove while the mouse is still pressed and the StartDragging has occured.
>tipIf grid snapping is activated this event will be invoked when a new snapped position is available.
* __CompleteDragging__ - occures on mouse up if the __StartDragging__ has been raised.
    
>importantThe following events are only triggered for items that implement __IDragDropAware__ interface. Currently, only the __RadDiagramContainerShapes__ implement this interface by default.

* __DragEnter__ - occurs when an object is dragged into the drop target's boundary.
* __DragLeave__ - occurs when an object is dragged out of the drop target's boundary.
* __Drop__ -  occurs when an object is dropped on the drop target.
    
    
_Properties_:
* __DragOverShape__ - of type IDragDropAware which gets the item that the user has dragged over.
* __DraggingModels__ - of type IEnumerable<IDiagramItem> and gets the items that are being dragged.
* __IsDragging__ - boolean flag indicating if a dragging operation is being currently executed.

    
_Methods_:
* __InitializeDrag__ - this method accepts a point as parameter and prepares a drag operation from that point.
* __StartDrag__ - a boolean method which starts a drag operation and invokes the StartDragging event. Returns __true__ if a drag can begin and __false__ if the Dragging event has not being handled.
* __Drag__ - triggers the actual dragging logic and invokes the Dragging, DragEnter or DragLeave events.
* __CompleteDrag__ - invokes the Drop and CompleteDragging events.
* __CanDrag__ - a boolean method determing if a drag operation is possible. By default a drag is possible when the item is dragged further then the __DiagramConstants.StartDragDelta__ constant.

   
## GroupService

This service manages the grouping and ungrouping of items. More information about the __RadDiagram__ grouping feature you can find in the [Grouping]({%slug raddiagram-features-grouping%}) tutorial.		

The __GroupService__ implements the __IGroupService__ interface and it provides the __GroupsChanged__ event. The event occurs when a root level logical group is created or destroyed through a new group or ungroup operation.		

## HitTestService

This service handles the hit-testing of diagram elements. It implements the __IHitTestService__ interface and exposes the following members:

_Properties_:
* __ShapeUnderMouse__ - gets the shape that is currently under the mouse.
* __ItemUnderMouse__ - gets the item that is currently under the mouse.

_Methods_:
* __GetTopShapesUnderPoint__ - accepts a point as a parameter and returns the shape/s with the highest ZIndex under that point.
* __GetShapesNearPoint__ - accepts a point and a delta of type double as a parameter and returns the nearest shape/s within that delta.
* __GetItemsNearPoint__ -  accepts a point and a delta of type double as a parameter and returns the nearest item/s within that delta.
* __GetTopItemNearPoint__ - accepts a point a and a delta of type double as a parameter and returns the item with the highest ZIndex within that delta.
* __GetShapesUnderRect__ - accepts a Rect as a paramater and returns the shapes under that rectangle.
* __GetConnectionsUnderRect__ - accepts a Rect as a parameter and returns the connections intersecting that rectangle.
* __GetItemsUnderRect__ - accepts a Rect as a parameter and returns the items under that rectangle.

## ManipulationPointService

This service packages the undoable actions performed by the ConnectionTool and the ConnectionManipulationTool on a connection. It keeps a reference to the ConnectionEditorPoint which is being manipulated and which acts as a key binding element between the RadDiagramConnection, the ConnectionManipulationAdorner and the tools. 

## ResizingService

The __ResizingService__ handles the scaling or resizing of diagram items. The service implements the	__IResizingService__ interface and exposes the following events:		

* __StartResizing__ - this event occurs when a resize operation is about to begin. The event provides a __CancelingManipulationEventArgs__ argument, which you can use to cancel the operation based on custom logic.			

* __Resizing__ - this event occurs during a resize operation. It has an argument of type __ResizingEventArgs__ which provides information about the new bounds of the __DiagramItem__ that is being resized.			

* __CompleteResizing__ - this event occurs when a resize operation has ended. It has an argument of type __ResizingEventArgs__ which provides information about the new bounds of the __DiagramItem__ that is being resized.			

## RotationService

The __RotationService__ handles the rotation of one or more __DiagramItems__. The service implements the __IRotationService__ interface and provides the following events:		

* __StartRotating__ - this event occurs when a rotation is about to begin. The event provides an argument of type __CancelingManipulationEventArgs__, which you can use to cancel the operation based on custom logic.			

* __Rotating__ - this event occurs during a rotation operation. It has an argument of type __RotatingEventArgs__ which provides both the new and old value of the rotation angle.			

* __CompleteRotating__ - this event occurs when a rotation is over. It has an argument of type __RotatingEventArgs__ which provides both the new and old value of the rotation angle.

## SegmentationService

The __SegmentationService__ is responsible for the logical segmentation of the Diagram. This allows for iterating over only a portion of the "nearby" shapes in some scenarios instead of over the entire collection. The service implements the __ISegmentationService__ interface the following members:

_Properties_:
* __IsSegmentationEnabled__: Gets a value indicating whether segmentation enabled.

_Methods_:
* __void MapShapes(IEnumerable<IShape> shapes)__: Maps the collection of shapes to different segments.
* __void MapShape(IShape shape)__: Maps the shape to its corresponding segment. 
* __void MapShape(IShape shape, Rect bounds)__: Maps the shape according to the passed bounds. 
* __void UnmapShape(IShape shape);__: Unmap the passed shape from the saved segments.
* __IEnumerable<IShape> GetShapes(Point point, double delta);__: Get the shapes around a Point.
* __IEnumerable<IShape> GetShapes(Rect rect);__: Get the shapes inside a Rectangle. 

## SelectionService

The __SelectionService__ manages the selection of __RadDiagramItems__. It implements the __ISelectionService<IDiagramItem>__ interface and provides the following events:		

* __PreviewSelectionChanged__ - this event occurs before changing the selection in a __RadDiagram__ instance. It provides an argument of type __DiagramSelectionChangedEventArgs__, which holds the collection of previously selected items as well the new selection. This argument has a __Handled__ property, which can be set to __True__ to cancel the selection.			

* __SelectionChanged__ - this event occurs when a new selection is performed in a __RadDiagram__. Its __DiagramSelectionChangedEventArgs__ argument provides access to the newly selected and the previously selected __DiagramItems__.			

You can also use this service to get:

* the currently selected diagram items through the __SelectedItems__ property. 

* the currently selected shapes through the __SelectedShapes__ property.			

* the currently selected connections through the __SelectedConnections__ property.			

## SerializationService

The __SerializationService__ manages the serialization and deserialization of items. It implements the __ISerializationService__ interface and exposes the following events:	  

* __ItemSerializing__ - this event occurs when a __RadDiagramItem__ is getting serialized. 			

* __ItemDeserializing__ - this event occurs when a __RadDiagramItem__ is being deserialized.

>tip Please have in mind that the __RadDiagram__ uses a separate instance of the __SerializationService__, while external components, such as the __RadDiagramToolbox__ use the default instance of the service. This is why, if you use the __RadDiagram.ServiceLocator__ to get the default instance of the service and attach event handlers for the above events, you'll notice that they are only executed when external component serialize or deserialize __RadDiagramItems__. And if you want to handle the diagram internal serialization, it is better to use the __RadDiagram__ [serialization events]({%slug raddiagrams-features-serialization%}).		  

## SnappingService

The __SnappingService__ manages the __Diagramming Framework__ snapping. It implements the __ISnappingService__ interface and exposes the __SnappingLinesCalculated__ event. The event provides an argument of type __SnappingLinesCalculatedEventArgs__ which holds the collections of vertical and horizontal snapping lines.	  

The __SnappingService__ internally uses a __SnappingEngine__ to handle the snap operations. You can find more information about the engine in the [Align and Snap]({%slug raddiagrams-features-snap%}) article.	  

## ToolService

The __ToolService__ manages the tools which react to a particular user action. It doesn't activate the tools but rather holds the instances of all diagramming tools and manages their actions accordingly. The service implements the __IToolService__ interface and provides access to the currently active tool as well as to the primary tool in a __RadDiagram__. The service also provides the following list of __Boolean__ properties:

* __IsControlDown__ - gets or sets whether the control-key is pressed.			

* __IsAltDown__ - gets or sets whether the alt-key is pressed.			

* __IsMouseDown__ - gets or sets whether the left mouse button is pressed.			

You can also use an instance of this service to activate or deactivate a given Diagramming tool:		

* __ActivateTool__ - this method takes a tool instance as an argument and activates it			

* __DeactivateTool__ - this method takes a tool instance as an argument and deactivates it			

## UndoRedoService

The __UndoRedoService__ manages the UndoRedo stack of undoable actions and commands. It implements the __IUndoRedoService__ interface and provides:	  

* __UndoStack__ - this property holds the stack of undone actions			

* __RedoStack__ - this property holds the stack of redone actions			

* __IsActive__- this is a __Boolean__ property which determines whether the undoRedo service is executing undo or redo action at the moment.			

* __RedoBufferSize__ - this property gets or sets the size of the __RedoStack__.			

* __UndoBufferSize__ - this property gets or sets the size of the __UndoStack__.			

The service also exposes an __ActionExecuted__ event that occurs when either a do or an undo command is executed.		

## VirtualizationService

The __VirtualizationService__ manages the virtualization of the diagramming items. It implements the __IVirtualizationService__ interface and exposes the following virtual methods, which can get overridden in order to customize the behavior of the service:		

* __Realize__ - this method realizes the items contained in provided bounds and virtualizes the others.			

* __Virtualize__ - this method virtualizes a list of specified items.			
