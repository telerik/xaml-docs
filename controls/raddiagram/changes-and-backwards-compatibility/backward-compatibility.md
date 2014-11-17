---
title: Backwards Compatibility
page_title: Backwards Compatibility
description: Backwards Compatibility
slug: raddiagram-backward-compatibility
tags: backwards,compatibility
published: True
position: 0
---

# Backwards Compatibility



This article describes the __breaking changes__ introduced in the __RadDiagram__ framework.
	  

## Q1 2014
	  

__Changed__

* IConnector now inherits ISerializable interface by default
			

__What to do now:__

If you implement __IConnector__ interface in your solution to create a custom connector, you will have to extend your implementation to also implement the __ISerializable__ interface.
		

## Q1 2013 

During __Q1 2013__ we worked on improving our RadDiagram and especially the RadDiagramConnections. We added a connection editing points which you can easily set programmatically or manually with Ctrl + MouseClick.
		  Below you can find the breaking changes related to connections:
		

* __Straight__ connection type is marked __Obsolete__. Instead of it, you can use __Polyline__ connection type which is straight by default.
			

* __RoundedPolyline__ connection type is marked __Obsolete__. The way to achieve the rounded connection effect is to use the __Polyline__ connection type and set the __ConnectionRoundedCorners__ property of the RadDiagram to __True__.
			

* __Routing of the Polyline connections__ is not automatic anymore. The way to turn on the routing is setting the __RouteConnections__ property of the RadDiagram to __True__.
			

* __Bezier Handle Points__ are not initially positioned in the middle of the distance between the start and end of the connection. To position them , you can use the __BezierAutoOffset__ DiagramConstant or the method __SetBezierHandles__ of the RadDiagramConnnection class. The DiagramConstant __BezierHandleMinimumDistance__ is removed. You should use only BezierAutoOffset.
			

We also improved our MVVM mechanism and the following method should not be used when using __SerializableGraphSourceBase__.
		

* __GetLinkUniqueId__ method is removed. Now you don't need to provide a unique id for the links - this is done automatically.
			

In Q1 2013 our __RadDiagramContainerShapes__ are also refactored.	We added style and style selectors properties and we also improved the drop behavior. The __ContainerLayout__ property is marked __Obsolete__ and you can consider that it is always set to __Auto__.
		

The __Print__ Command from __DiagramCommands__ is marked __Obsolete__. You have to use the __Print Command__ from Telerik.Windows.Controls.Diagrams.Extensions.DiagramExtensionCommands. Setting its CommandParameter to __True__ will activate our PrintPreviewDialog from the Diagram Extensions.
		

__GeometryFactory__ class is marked __Obsolete__ and will be deleted in Q2 2013. The methods in it are also available in the class __GeometryExtensions__.
		

## Q3 2012

With the Q3 2012 release we introduced the following set of changes in the __Diagramming Framework__:
		

* The __CommandNames.ResizeShape__ constant is now renamed to __CommandNames.ResizeItem__.
			

* The __CommandNames.ResizeShapes__ constant is now renamed to __CommandNames.ResizeItems__.
			

* The order of the arguments in the __RotatingEventArgs__ class constructor - __RotatingEventArgs(Double oldPosition, Double newPosition,__ are changed to __RotatingEventArgs__

* The __RotateRoutedEventArgs__ class constructor - __RotateRoutedEventArgs(RoutedEvent routedEvent, IEnumerable<IDiagramItem> items, Double oldPostion, Double newPostion)__ is removed. You can instead use the other constructors of the class to create an instance of it.
			

With this release we significantly improved the implementation, performance and extensibility of the __RadDiagramRuler__. However, we couldn't have done that without introducing some changes in its definition. You can take a look at the new implementation and features of the control in the [Ruler]({%slug raddiagram-extensions-ruler%}) article. However, if you've used its old version, please bear in mind that we've removed the following __RadDiagramRuler__ properties:
		

* LabelInterval (LabelIntervalProperty)

* LabelTemplate (LabelTemplateProperty)

* Labels (LabelsProperty)

* TickInterval (TickIntervalProperty)

* TickTemplateSelector (TickTemplateSelectorProperty)

* Ticks (TicksProperty)

* Zero (ZeroProperty)

Due to the improvements in the control, the following classes are no more needed and therefore we removed their definitions:

* MeasurementUnitConverter

* ReversedDoubleToPercentageConverter

* RulerLabelPanel

* RulerPanelBase

* RulerTickInfo

* RulerTickPanel

* RulerTickTemplateSelector

And we changed the name of the device-independent pixels measurement unit from __MeasurementUnit.DIP__ to __MeasurementUnit.Dip__.
		

## Q2 2012

With its official release, the Diagramming framework extends its __Connectors__ support by adding the possibility to create custom connectors. However, in order to implement this feature we had to remove the __ConnectorPosition__ enumeration. Instead the position of a connector can now be defined through a __string__ property. But as we wanted to limit the effect of this breaking change, we matched the members of the enumeration to string constants, which are internally resolved to allow you to set up the __RadDiagramConnection.Source(Target)ConnectorPosition__ as __Auto, Left, Right, Top__ or __Bottom__ as before. Below you can find all __RadDiagram__ members affected by the changes in the connectors implementation:
		

* The __ConnectorPosition__ enumeration is removed
			

* The __AddConnection(source, target, sourceConnectorPosition, targetConnectorPosition, isUndoable)__ method arguments are changed as follows:
			

* __sourceConnectorPosition__ argument type is changed to __string__

* __targetConnectorPosition__ argument type is changed to __string__

* The __AddConnection(source, target, connectorsPosition)__ method arguments are changed as follows:
			

* __connectorsPosition__ argument type is changed to __string__

* The __Attach(source, sourceConnectorPosition, target, targetConnectorPosition)__ method arguments are changed so that it now takes only two arguments:
			

* __Source__ argument of type __IConnector__

* __Target__ argument of type __IConnector__

* __GetConnectionsForShape(shape)__ method is __removed__

* __GetIncomingConnectionsForShape(shape)__ method is __removed__

* __GetOutgoingConnectionsForShape(shape)__ method is __removed__

* __RadDiagramConnection.SourceConnectorPosition__ type is changed to __string__

* __RadDiagramConnection.TargetConnectorPosition__ type is changed to __string__

The other changes introduced in the Diagramming tools' implementation are listed below: 

* __RadDiagram.IsSnapEnabled__ property is __removed__. Instead two new properties are introduced:
			

* Boolean __IsSnapToGridEnabled__

* Boolean __IsSnapToItemsEnabled__

* __RadDiagram.PositionX__ and __RadDiagram.PositionY__ properties are __removed__. Instead one new property is introduced:
			

* Point __Position__

* __RadDiagram.SnapValue__ is __removed__. Instead two new properties are introduced:
			

* Int32 __SnapX__

* Int32 __SnapY__

* __RadDiagram.Layout(settings)__ method arguments are __changed__ so that now the method has two arguments:
			

* LayoutType __type__

* object __settings__

* __RadDiagramShapeBase.ConnectorActivated__ event is __removed__. Instead you can handle the __RadDiagramConnector.ActivationChanged__ event.
			

* __RadDiagramShapeBase.ConnectorPoints__ collection is __removed__. Instead you can use the __RadDiagramShapeBase.Connectors__ collection
			

## Q1 2012 SP1

The __Xml__ property of the __RadDiagramShapeBase__ is removed. Instead you should use the __GetXml()__ method. The reason behind this change is to avoid the performance impact when using the getter of the property.

