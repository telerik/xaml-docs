---
title: SDK Examples
page_title: SDK Examples
description: SDK Examples
slug: raddiagram-sdk-examples
tags: sdk,examples
published: True
position: 3
---

# SDK Examples



The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadDiagram__.

## List of all RadDiagram SDK examples:{% if site.site_name == 'WPF' %}

* __Control shape__ - This sample demonstrates how to use any XAML control in a Diagram Shape. You can put any content directly in a shape either in XAML or using C# code.

* __Custom connectors__ - The sample demonstrates that you can easily define your own connector points for every RadDiagramShape. For more information read the Connectors section in the help.

* __Custom services__ - This example shows how you could customize some of the buld-in diagram services.  The Diagramming Framework exposes a set of services that control and confugure different diagramming tools and features.  This is why the services come in handy in scenarios requiring significant customizations in the default behavior of the RadDiagram and its elements

* __Custom settings pane__ - The CustomSettingsPane example highlights the following features of RadDiagram and DiagramExtensions: 	-Binding the DiagramToolBox 	-Drawing Tools in MVVM Diagram 	-Customizing Settings Pane: 		-Adding new tabs 		-Binding to ViewModel's properties 		-Binding to App's MainViewModel's Commands 		-Adding custom shapes in toolbox from SettingsPane

* __Custom toolbox drag drop__ - The sample demonstrates how to populate a RadDiagramToolbox with a custom business collection of objects.  It also implements a sample drag/drop scenario between the toolbox and a RadDiagram instance.

* __Custom tools__ - This example shows how you could customize some of the buld-in diagram tools and add new ones.  The Diagramming Framework exposes a set of tools that handle the main user interactions.  Overriding the mouse/key events in the default tools you can easily customize their behaviour. 

* __Diagram ribbon uI__ - The sample demonstrates how to create RibbonUI for most of the Diagramming framework functionality. The sample can be used for first steps to any Diagramming application.  It is a strip version of the QSF Diagrams FirstLook sample.

* __Diagram tool box__ - The DesignToolBox example allows you to drag & drop various shapes from a custom toolbox control. The example also supports the standard available diagram features such as: 	- Drag & Drop of shapes and connections 	- Shapes Rotation & Resizing 	- Cut/Copy/Paste/Delete/Undo/Redo  	- Pan and Zoom 	- Snap to Grid  	- Align Items  	- Graph Layout  	- Read-only Diagrams   	- Optimized performance through Virtualization  	- Save/Load Layout through Serialization  	- Various Mouse tools  	- Rich Commands and Events Model  	- MVVM Support  This is a strip version of the QSF sample DiagramToolBox.

* __Docking integration__ - This example demonstrates how to take advantage of the RadDocking control structure to display the RadDiagram, RadDiagramRuler, RadDiagramToolbox and RadDiagramNavigationPane in one view.

* __Gliding connector__ - The sample demonstrates that you can easily define different Gliding styles for every RadDiagramShapes.

* __Hide bezier handles__ - This sample demonstrates how you can hide the bezier handles using two custom styles.

* __Layout__ - The layout sample highlights two areas or RadDiagram which are somewhat hidden in the API although it comprises a considerable amount of code and power: - the graph analysis API which implements the typical graph algorithms - the graph layout API which auto-organizes a graph  The sample allows you to: - create random graphs and visualize them. The code shows you how various methods are available in RadDiagram to create (pseudo-random) graphs with certain constraints like connectedness, tree-connected, single component, incidence constraints and so on. - see how certain parameters affect the graph layout and how different layout algorithms give a different result - see how certain well-known questions about graphs can be answered using the graph API; what is the shortest path between two nodes, what is a spanning tree in a graph, what is the longest routed between nodes, how many components does the graph have...and more. - understand the generic way to approach graph analysis using RadDiagram While this sample is certainly not a full application examplifying a graph-theoretic textbook it is a stepping stone if you wish to go into this direction. 

* __MVVM__ - The sample demonstrates that you can easily use RadDiagram framework using the MVVM pattern.  It could serve as a starting point for your MVVM based Diagram applications.

* __Org chart__ - The Telerik OrgChart demo brings a great new visualization to organizational structures and hierarchies.  DiagramOrgchart demonstrates the following RadDiagram  features:    - Shapes Layout. Different Layout types. Customizing the Layout with properties    - Connection Routing    - Custom Connectors    - Custom Templates changed with Semantic Zoom    - BringIntoView functionality    - Diagram NavigationPane    - Search for a node    - Animations when templates are changed    

* __Panning without using ctrl__ - The idea is to create a diagram in which panning happens without using the "Ctrl" button (only using the mouse) and holding the "Shift" button allows user to select items in the diagram (activates the PointerTool).

* __Pascal triangle__ - The sample demonstrates how you can create GraphSource with custom layout, based on your ViewModels instead of using built-in Diagram layouts.

* __Paste on mouse position__ - The Diagram Custom Paste Demonstrates thw following requested customizations / features: 	- Pasting on exact Mouse Position 	- Pasting connection on hovered Shape Connector attaches the coonnection to the connector This is acheived with overriding the RadDiagram and its Paste() method. On paste the copied items are pasted on the Mouse Position. If the Mouse is above a Shape Connector, the copied Connections are attached to this connector 

* __Style selectors__ - This example demonstrates how to use MVVM to create a collection of shapes and connections in the RadDiagram control and take advantage of the ShapeStyleSelector and ConnectionStyleSelector properties to apply different styles on the shapes and the connections based on their type.

* __Win form__ - The idea is to create easy-to-use infrastructure with developer focused examples for all XAML controls.  The goal is to become high-quality help resource that will ultimately replace our Knowledge Base articles, Code Libraries and "How to" articles in the help.  It differs from our QSF in that it should be targeting developers and will not be a marketing tool. {% endif %}{% if site.site_name == 'Silverlight' %}

* __Control shape__ - This sample demonstrates how to use any XAML control in a Diagram Shape. You can put any content directly in a shape either in XAML or using C# code.

* __Custom connectors__ - The sample demonstrates that you can easily define your own connector points for every RadDiagramShape. For more information read the Connectors section in the help.

* __Custom services__ - This example shows how you could customize some of the buld-in diagram services.  The Diagramming Framework exposes a set of services that control and confugure different diagramming tools and features.  This is why the services come in handy in scenarios requiring significant customizations in the default behavior of the RadDiagram and its elements

* __Custom settings pane__ - The CustomSettingsPane example highlights the following features of RadDiagram and DiagramExtensions: 	-Binding the DiagramToolBox 	-Drawing Tools in MVVM Diagram 	-Customizing Settings Pane: 		-Adding new tabs 		-Binding to ViewModel's properties 		-Binding to App's MainViewModel's Commands 		-Adding custom shapes in toolbox from SettingsPane

* __Custom toolbox drag drop__ - The sample demonstrates how to populate a RadDiagramToolbox with a custom business collection of objects.  It also implements a sample drag/drop scenario between the toolbox and a RadDiagram instance.

* __Custom tools__ - This example shows how you could customize some of the buld-in diagram tools and add new ones.  The Diagramming Framework exposes a set of tools that handle the main user interactions.  Overriding the mouse/key events in the default tools you can easily customize their behaviour. 

* __Diagram ribbon uI__ - The sample demonstrates how to create RibbonUI for most of the Diagramming framework functionality. The sample can be used for first steps to any Diagramming application.  It is a strip version of the QSF Diagrams FirstLook sample.

* __Diagram tool box__ - The DesignToolBox example allows you to drag & drop various shapes from a custom toolbox control. The example also supports the standard available diagram features such as: 	- Drag & Drop of shapes and connections 	- Shapes Rotation & Resizing 	- Cut/Copy/Paste/Delete/Undo/Redo  	- Pan and Zoom 	- Snap to Grid  	- Align Items  	- Graph Layout  	- Read-only Diagrams   	- Optimized performance through Virtualization  	- Save/Load Layout through Serialization  	- Various Mouse tools  	- Rich Commands and Events Model  	- MVVM Support  This is a strip version of the QSF sample DiagramToolBox.

* __Docking integration__ - This example demonstrates how to take advantage of the RadDocking control structure to display the RadDiagram, RadDiagramRuler, RadDiagramToolbox and RadDiagramNavigationPane in one view.

* __Gliding connector__ - The sample demonstrates that you can easily define different Gliding styles for every RadDiagramShapes.

* __Hide bezier handles__ - This sample demonstrates how you can hide the bezier handles using two custom styles.

* __Layout__ - The layout sample highlights two areas or RadDiagram which are somewhat hidden in the API although it comprises a considerable amount of code and power: - the graph analysis API which implements the typical graph algorithms - the graph layout API which auto-organizes a graph  The sample allows you to: - create random graphs and visualize them. The code shows you how various methods are available in RadDiagram to create (pseudo-random) graphs with certain constraints like connectedness, tree-connected, single component, incidence constraints and so on. - see how certain parameters affect the graph layout and how different layout algorithms give a different result - see how certain well-known questions about graphs can be answered using the graph API; what is the shortest path between two nodes, what is a spanning tree in a graph, what is the longest routed between nodes, how many components does the graph have...and more. - understand the generic way to approach graph analysis using RadDiagram While this sample is certainly not a full application examplifying a graph-theoretic textbook it is a stepping stone if you wish to go into this direction. 

* __MVVM__ - The sample demonstrates that you can easily use RadDiagram framework using the MVVM pattern.  It could serve as a starting point for your MVVM based Diagram applications.

* __Org chart__ - The Telerik OrgChart demo brings a great new visualization to organizational structures and hierarchies.  DiagramOrgchart demonstrates the following RadDiagram  features:    - Shapes Layout. Different Layout types. Customizing the Layout with properties    - Connection Routing    - Custom Connectors    - Custom Templates changed with Semantic Zoom    - BringIntoView functionality    - Diagram NavigationPane    - Search for a node    - Animations when templates are changed    

* __Panning without using ctrl__ - The idea is to create a diagram in which panning happens without using the "Ctrl" button (only using the mouse) and holding the "Shift" button allows user to select items in the diagram (activates the PointerTool).

* __Pascal triangle__ - The sample demonstrates how you can create GraphSource with custom layout, based on your ViewModels instead of using built-in Diagram layouts.

* __Paste on mouse position__ - The Diagram Custom Paste Demonstrates thw following requested customizations / features: 	- Pasting on exact Mouse Position 	- Pasting connection on hovered Shape Connector attaches the coonnection to the connector This is acheived with overriding the RadDiagram and its Paste() method. On paste the copied items are pasted on the Mouse Position. If the Mouse is above a Shape Connector, the copied Connections are attached to this connector 

* __Style selectors__ - This example demonstrates how to use MVVM to create a collection of shapes and connections in the RadDiagram control and take advantage of the ShapeStyleSelector and ConnectionStyleSelector properties to apply different styles on the shapes and the connections based on their type.{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).
