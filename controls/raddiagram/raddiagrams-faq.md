---
title: FAQ
page_title: FAQ
description: Check our &quot;FAQ&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagrams-faq
tags: faq
published: True
position: 16
---

# FAQ

This section answers commonly asked questions regarding the usage and implementation of Telerik RadDiagram

## Q: How far can RadDiagram go in terms of scalability and performance 

Before discussing the scalability of the RadDiagram in particular, we need to take a broader look at the rendering options Windows graphics provide. At the moment there are two types or modes of rendering technologies:

* __Retained graphics mode__ - the drawing (code) is not done immediately but updates an internal model (the scene graph). This internal model is maintained by the operating system and all optimizations and fine details are handled transparently by the graphics pipeline. All variations of XAML (WPF, Silverlight, Windows Phone) use retained graphics. In essence the XAML code is a partial mirror of the visual tree maintained by XAML and this visual tree is organized by .NET.			

* __Immediate (or direct) graphics mode__ - the code draws directly on a canvas and the operation system does not keep a scene graph of what is being drawn. Usually the application or API has its own internal model of the scene. By default the objects drawn in immediate mode are not interactive. XAML, on the other hand, has a rich API which allows you to add animations, style and interactivity.			

Next we need to consider the different categories of graph (or diagramming) interfaces: 

* __Diagrams where individual shapes and connections matter__ - these are diagrams where the user needs to click and select individual shapes, alter their properties, create new connections and so on. This is __the Visio-like and RadDiagram paradigm__. The API is rich and offers a framework which can be modeled accordingly to the needs of the business context. Diagrams in this category benefit from the retained graphics pipeline (XAML, SVG…) since it articulates a RAD-methodology and adapts to the widely different business contexts in which diagrams are used.			

* __Diagrams which aim at giving a global (bird's eye) view of a certain topic, where global topology matters more than local links__ - these diagrams are about seeing clusters and broad relationships, about graph layout on a large scale, about how particle systems represent the dynamics of a certain (business) system.  This is the data visualization paradigm aiming at representing data and giving insights into big data sets. This paradigm benefits from the direct rendering pipeline (Canvas, bitmap, GDI…) and the result is often quite static.			

Having the above information in mind and considering the wide range of scenarios where the __RadDiagram__ and its tools can be used, we have designed __Telerik Diagramming Framework__ to rapidly create great diagrams with a minimum knowledge about diagramming drawing and graph theory. It is not developed in function of large scale – instead its items, like the __RadDiagramShape__ and __RadDiagramConnection__, are rich controls which on top of the already loaded .Net framework API (i.e. the __ContentControl__ and __Control__ classes) add an additional layer of interactivity and customization to enable rich, interactive diagram solutions. It is important to note that the design of the __Diagramming Framework__ is constantly focused on the breadth and scope of applications (workflow, organization charts and so on) rather than on scalability.		

This is why __RadDiagram__ can articulate a wide variety of diagramming tasks but at the same time it does not focus on any type in particular. The graph layout and internal engine managing shapes and connections is not geared to anything in particular while there are definitely shortcuts possible if some knowledge (properties) of the to-be displayed data is known. That is, if your application is all about tree graphs and large hierarchies then there are ways in which the tree-layout code could be optimized in function of the data you wish to display. For example, testing for graph cycles in the layout could be omitted if the data is guaranteed to be acyclic. There are on many levels ways in which a custom implementation could give specific applications a performance or scalability boost.		

[ This blog post](http://www.orbifold.net/default/telerik-raddiagram-scalability-and-performance/) digs deeper into the matters of scalability and performance of the __RadDiagram__ and it also tries to answer the question *How  to display huge diagrams and keep the interactivity to the max. *

## Q: How to display the DiagramToolbox items in a PanelBar

If you want to display galleries with __DiagramShapes__ in different panels, you can use the __RadPanelBar__ control. As the control is essentially a hierarchical control, you can populate it with the built-in __HierarchicalGalleryItemsCollection__. This approach is demonstrated in the __RadDiagram__{% if site.site_name == 'Silverlight' %}[FirstLook demo](https://demos.telerik.com/silverlight/#Diagrams/FirstLook){% endif %}{% if site.site_name == 'WPF' %}[FirstLook demo](https://demos.telerik.com/wpf/#Diagrams/FirstLook){% endif %}.		

## Q: How to display the RadDiagramItems properties pane

The __Diagramming Framework__ provides a built-in __SettingsPane__ that allows the users to examine and modify the settings of the diagramming items. It can be displayed through the __ItemInformationAdorner.AdditionalContent__ attached property:		


```XAML
	<telerik:RadDiagram x:Name="xDiagram">
		<primitives:ItemInformationAdorner.AdditionalContent>
			<telerik:SettingsPane Diagram="{Binding ElementName=xDiagram}"/>
		</primitives:ItemInformationAdorner.AdditionalContent>
	</telerik:RadDiagram>
```

## Q: Can I create Custom Connectors

__RadDiagram__ supports custom connectors along with the list of predefined connectors. You can find detailed description of how to create and apply custom connectors on your shapes in [this tutorial]({%slug raddiagram-features-custom-connectors%}).	  

## Q: How to create custom shapes

You can create custom controls deriving from the __RadDiagramShapeBase__ or the __RadDiagramShape__ classes. These controls can then be used in a __RadDiagram__ as demonstrated in [this tutorial]({%slug raddiagram-howto-create-custom-shape%}).	  

## Q: How to create collapsible containers in my diagram

You can define a __RadDiagramContainerShape__ and set its __IsCollapsible__ property to __True__. The collapsible containers provided withing __RadDiagram__ are further discussed in the [ContainerShapes]({%slug raddiagram-features-container-shapes%}) article.	  

## Q: Can I use a ScrollViewer in RadDiagram

The __RadDiagram__ has a built-in __ScrollViewer__ control. This feature is further described in [this tutorial]({%slug raddiagram-howto-display-scroll%}).	  

## Q: Can I print RadDiagram

__RadDiagram__ supports printing out-of-the-box. [This article]({%slug raddiagram-features-printing%}) describes in more details the priniting functionalities implemented in the Diagramming Framework.		

## Q: Does RadDiagram support touch gestures

__RadDiagram__ supports [this list]({%slug raddiagram-features-touch-support%}) of touch gestures.
		
## Q: Can I hide the rotation thumb

The rotation thumb is part of the __RadDiagram ManipulationAdorner__ and you can hide it by setting the __IsManipulationAdornerVisible__ property to __False__. The [Customize Appearance]({%slug raddiagram-styling-appearance%}) article describes the properties that allow you to easily customize the default look and feel of __RadDiagram__.		

## Q: How to drop shapes from a ListBox displaying custom collection of shapes

You can implement a custom drag/drop operation between the __RadDiagram__ and any external control following the guidelines described in [this tutorial]({%slug raddiagrams-features-drag-drop%}).	  

## Q: How to enable the connection routing

The Connection Routing feature can be enabled through the __RadDiagram RouteConnections__ property. When set to __True__, it uses a built-in routing mechanism to route the connections. You can examine the [Connections]({%slug raddiagrams-features-connections%}) tutorial for further information. 	  

## Q: How to group and ungroup DiagramItems using the keyboard	

You can trigger a grouping operation through the __Ctrl+G__ key combination. And you can ungroup a grouped set of items using the __Ctrl+U__ combination. Please refer to the [Keyboard Support article]({%slug raddiagrams-features-shortcuts%}) for further information.	  

## Q: How to dynamically create a polyline connection	  

If you hold down the __Ctrl__ key and click on a __Polyline__ connection, you will be able to dynamically create connection points. These points can then be used to change the path of the connection. In order to remove a connection point, you can hold the __Ctrl__ key and click on the point. Please refer to the [DiagramConnections]({%slug raddiagrams-features-connections%}) tutorial to get a better understanding of the connection types and their features.		

## Q: How to dynamically duplicate a selected DiagramItem	  

You can dynamically duplicate a selected __RadDiagramItem__ through the __Ctrl+D__ key combination. Please refer to the [Keyboard Support article]({%slug raddiagrams-features-shortcuts%}) for further information.		

## Q: How to slightly move the selected item/items on the diagramming surface	  

You can slightly move (nudge) the currently selected item or items using the __Ctrl+arrow__ key combination. The __Ctrl+Shift+arrow__ key combination, on the other hand, nudges the selection five times more. Please refer to the [Keyboard Support article]({%slug raddiagrams-features-shortcuts%}) for further information.		

## See Also
 * [Shapes]({%slug raddiagrams-features-shapes%})
 * [Connections]({%slug raddiagrams-features-connections%})
 * [Layout]({%slug raddiagram-features-diagram-layout%})
 * [Virtualization]({%slug raddiagrams-features-virtualization%})