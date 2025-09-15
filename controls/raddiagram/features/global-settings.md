---
title: Global Settings
page_title: Global Settings
description: Check our &quot;Global Settings&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagram-features-global-settings
tags: global,settings
published: True
position: 15
---

# Global Settings

This article describes the global settings applied in the __Diagramming Framework__.

The __Diagramming Framework__ provides a list of constants that are applied throughout the different diagramming tools and items. You can change their default values to customize the global settings in the __RadDiagram__ elements. The constants can be accessed via the __DiagramConstants__ class.	

__Example 1: Setting diagram constants__
```C#
	DiagramConstants.MinimumZoom = 0.5;
	DiagramConstants.MaximumZoom = 4;
	DiagramConstants.StartDragDelta = 10;
```
	
* __BezierAutoOffset__: Gets or sets the default offset between the Bezier handle points and the endpoints of the connection when the handle points coordinates are automatically calculated according to a connector's position. The default value of this constant is 30px. [Read More]({%slug raddiagrams-features-connections%}).			

* __ConnectionCornerRadius__: Gets or sets the connection corner radius that is used to create a rounded polyline connection. The default value of this constant is 10px. [Read More]({%slug raddiagrams-features-connections%}).		  

* __ConnectorActivationRadius__: Gets or sets the distance, within which the shape's connectors are visible. Its default value is 15px. Read more about the __RadDiagramShape__ connectors in the [Shapes]({%slug raddiagrams-features-shapes%})  tutorial.			

* __ConnectorHitTestRadius__: Gets or sets the radius around the connector where connection can attach. The default value of this constant is 5px. Read more about the __RadDiagramShape__ connectors in the [Shapes]({%slug raddiagrams-features-shapes%})  tutorial.			

* __ContainerMargin__: Gets or sets the margin that is applied around the __Items__ collection of the __RadDiagramContainerShape__. The default value of this constant is 10px. [Read More]({%slug raddiagram-features-container-shapes%}#connectors).		  

* __CrossingRadius__: Gets or sets the radius of the connection bridge or gap. This feature is further described in the [Connections]({%slug raddiagrams-features-connections%}) tutorial. The default value of this constant is 5px.			

* __InflatedRouterMinimumMargin__: Gets or sets the margin around the shapes, which the __Telerik.Windows.Diagrams.Core.InflatedRectRouter__ inflates the shapes with. This constant is used in the routing algorithm to make sure that a connection doesn't collide with a shape. This is why we don't recommend setting the value of this constant to 0px. The default value of this constant is 20px.	
	
	> This property is obsolete. Use __RouterInflationValue__ instead.

* __RouterInflationValue__: Gets or sets the distance around the shapes which the router inflates the shapes with, if implemented. This property is used by the __InflatedRectRouted__ and __AStarRouter__.
	
* __ZoomScaleFactor__: Gets or sets the default zoom factor that is used as a multiplier or divider to produce the next step in a zoom operation. The default value of this constant is 1.2. Read more about zooming in the [Pan and Zoom]({%slug raddiagrams-features-pan-zoom%}) tutorial.			

* __MaximumZoom__: Gets or sets the maximum zoom level. The default value of this constant is 5. Read more about zooming in the [Pan and Zoom]({%slug raddiagrams-features-pan-zoom%}#zoom) tutorial.			

* __MinimumZoom__: Gets or sets the minimum zoom level. The default value of this constant is 0.5. Read more about zooming in the [Pan and Zoom]({%slug raddiagrams-features-pan-zoom%}#zoom) tutorial.			

* __RotationAngleSnap__: Gets or sets the snapping angle when rotating items. The default value of this constant is 5 degrees. Read more about rotation in the [Rotation]({%slug raddiagrams-features-rotation%}) tutorial.			

* __RotationHitTestRadius__: Gets or sets the radius around the rotation thumb where a click operation activates the thumb. The default value of this constant is 7px. Read more about rotation in the [Rotation]({%slug raddiagrams-features-rotation%}) tutorial.			

* __RoutingGridSize__: Gets or sets the routing grid cell size. The value of this constant is used in the algorithm used to layout the __RadDiagramConnections__. The default value of this constant is 40px.			

* __SelectionHitTestRadius__: Gets or sets the radius of the area around each item which is considered selectable. The default value of this constant is 10px.			

* __SelectionRectInflationValue__: Gets of sets the margin around the selected shapes. The default value of this constant is 7px.

* __StartDragDelta__: Gets or sets the minimum distance that a mouse move operation has to cover to start a drag action. The default value of this constant is 4px.

* __MinimumShapeDistanceOnConnectionManipulationSnap__: Gets or sets a __double__ value that determines he minimum distance from a connection to a given shape so that snapping occurs.	

* __MinimumAdornerSize__: Gets or sets a __double__ value that determines the minimum size of the diagram items adorner.

* __MinimumShapeSize__: Gets or sets a __double__ value that determines the minimum size of the diagram shapes.

> We recommend to use matching values for the __MinimumShapeSize__ and __MinimumAdornerSize__ properties. Otherwise, the adorner won't match the shape's size when its minimum value is reached.
