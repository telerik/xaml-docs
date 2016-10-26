---
title: Global Settings
page_title: Global Settings
description: Global Settings
slug: raddiagram-features-global-settings
tags: global,settings
published: True
position: 15
---

# Global Settings

This article describes the global settings applied in the __Diagramming Framework__.

The __Diagramming Framework__ provides a list of constants that are applied throughout the different diagramming tools and items. You can change their default values to customize the global settings in the __RadDiagram__ elements.	  

* __BezierAutoOffset__ - gets or sets the default offset between the Bezier handle points and the endpoints of the connection when the handle points coordinates are automatically calculated according to a connector's position. The default value of this constant is 30px. [Read More]({%slug raddiagrams-features-connections%}).			

* __ConnectionCornerRadius__ - gets or sets the connection corner radius that is used to create a rounded polyline connection. The default value of this constant is 10px. [Read More]({%slug raddiagrams-features-connections%}).		  
* __ConnectorActivationRadius__ - gets or sets the distance, within which the shape's connectors are visible. Its default value is 15px. Read more about the __RadDiagramShape__ connectors in the [Shapes]({%slug raddiagrams-features-shapes%})  tutorial.			

* __ConnectorHitTestRadius__ - gets or sets the radius around the connector where connection can attach. The default value of this constant is 5px. Read more about the __RadDiagramShape__ connectors in the [Shapes]({%slug raddiagrams-features-shape%})  tutorial.			

* __ContainerMargin__ - gets or sets the margin that is applied around the __Items__ collection of the __RadDiagramContainerShape__. The default value of this constant is 10px. [Read More]({%slug raddiagram-features-container-shapes%}#connectors).		  

* __CrossingRadius__ - gets or sets the radius of the connection bridge or gap. This feature is further described in the [Connections]({%slug raddiagrams-features-connections%}) tutorial. The default value of this constant is 5px.			

* __InflatedRouterMinimumMargin__ - The margin around the shapes, which the __Telerik.Windows.Diagrams.Core.InflatedRectRouter__ inflates the shapes with. This constant is used in the routing algorithm to make sure that a connection doesn't collide with a shape. This is why we don't recommend setting the value of this constant to 0px. The default value of this constant is 20px.			

* __ZoomScaleFactor__ - The default zoom factor that is used as a multiplier or divider to produce the next step in a zoom operation. The default value of this constant is 1.2. Read more about zooming in the [Pan and Zoom]({%slug raddiagrams-features-pan-zoom%}) tutorial.			

* __MaximumZoom__ - The maximum zoom level. The default value of this constant is 5. Read more about zooming in the  [Pan and Zoom]({%slug raddiagrams-features-pan-zoom%}#zoom) tutorial.			

* __MinimumZoom__ - The minimum zoom level. The default value of this constant is 0.5. Read more about zooming in the [Pan and Zoom]({%slug raddiagrams-features-pan-zoom%}#zoom) tutorial.			

* __RotationAngleSnap__ - Gets or sets the snapping angle when rotating items. The default value of this constant is 5 degrees. Read more about rotation in the [Rotation]({%slug raddiagrams-features-rotation%}) tutorial.			

* __RotationHitTestRadius__ - gets or sets the radius around the rotation thumb where a click operation activates the thumb. The default value of this constant is 7px. Read more about rotation in the [Rotation]({%slug raddiagrams-features-rotation%}) tutorial.			

* __RoutingGridSize__ - gets or sets the routing grid cell size. The value of this constant is used in the layout algorithm used to layout the __RadDiagramConnections__. The default value of this constant is 40px.			

* __SelectionHitTestRadius__ - The radius of the area around each item which is considered selectable. The default value of this constant is 10px.			

* __StartDragDelta__ - The minimum distance that a mouse move operation has to cover to start a drag action. The default value of this constant is 4px.			
