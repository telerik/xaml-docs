---
title: Services
page_title: Services
description: Services
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

	#### __C#__
		xDiagram.ServiceLocator.RegisterDefaultServices();

	#### __VB.NET__
		xDiagram.ServiceLocator.RegisterDefaultServices()

* __GetService<T>()__ where __T__ represents a service interface - this method returns a service instance used by a __RadDiagram__. The type parameter allows you to specify the interface of the service you need to access. For example, if you want to get the resizing service currently used in a RadDiagram instance, you need to ask for the service implementing the __IResizingService__ interface:

	#### __C#__
		xDiagram.ServiceLocator.GetService<IResizingService>();

	#### __VB.NET__
		xDiagram.ServiceLocator.GetService(Of IResizingService)()

* __Register<T>(T service)__ - this method allows you to register a new service in a __RadDiagram__. Please note that the type parameter __T__ represents the service interface type, while the method argument allows you to provide a new service class.
	For instance, if you create a custom resizing service, you can register it in a __RadDiagram__ instance:
	
	#### __C#__	
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

	#### __VB.NET__		
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

This service manages the translation of items on the surface.

## GroupService

This service manages the grouping and ungrouping of items. More information about the __RadDiagram__ grouping feature you can find in the [Grouping]({%slug raddiagram-features-grouping%}) tutorial.		

The __GroupService__ implements the __IGroupService__ interface and it provides the __GroupsChanged__ event. The event occurs when a root level logical group is created or destroyed through a new group or ungroup operation.		

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

>tip Please have in mind that the __RadDiagram__ uses a separate instance of the __SerializationService__, while external components, such as the __RadDiagramToolbox__ use the default instance of the service. This is why, if you use the __RadDiagram.ServiceLocator__ to get the default instance of the service and attach event handlers for the above events, you'll notice that they are only executed when external component serialize or deserialize __RadDiagramItems__. And if you want to handle the diagram internal serialization, it is better to use the __RadDiagram__ [serialization events](466077a9-dece-4adf-88b8-4509c39deed9#Serialization).		  

## SnappingService

The __SnappingService__ manages the __Diagramming Framework__ snapping. It implements the __ISnappingService__ interface and exposes the __SnappingLinesCalculated__ event. The event provides an argument of type __SnappingLinesCalculatedEventArgs__ which holds the collections of vertical and horizontal snapping lines.	  

The __SnappingService__ internally uses a __SnappingEngine__ to handle the snap operations. You can find more information about the engine in the [Align and Snap](9a62098d-d288-4f6a-971d-43e839452b09#SnappingEngine) article.	  

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