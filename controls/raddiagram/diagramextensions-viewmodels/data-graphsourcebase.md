---
title: GraphSourceBase
page_title: GraphSourceBase
description: GraphSourceBase
slug: raddiagram-data-graphsourcebase
tags: graphsourcebase
published: True
position: 5
---

# GraphSourceBase



Telerik Diagramming Framework provides a list of __ViewModels__ defined in the __Telerik.Windows.Controls.Diagrams.Extensions.dll__.
	  

This article describes the __GraphSourceBase<TNode, TLink>__ class defined in the Diagramming Extensions.
	  

## Overview

The __GraphSourceBase<TNode, TLink>__ class is designed to serve as a base __ViewModel__ that represents the collections of nodes and shapes in a data-bound __RadDiagram__. In a __RadDiagram__ you always need to consider the fact that it consists of different types of items - __RadDiagramConnections__ and __RadDiagramShapes__. This is why the __RadDiagram GraphSource__ should be set to an instance of a class that implements the
		  {% if site.site_name == 'Silverlight' %}[IGraphSource](http://www.telerik.com/help/silverlight/t_telerik_windows_diagrams_core_igraphsource_1.html){% endif %}{% if site.site_name == 'WPF' %}[IGraphSource](http://www.telerik.com/help/wpf/t_telerik_windows_diagrams_core_igraphsource_1.html){% endif %} interface. This interface defines two collections - one with Items and one with Links.
		

The __GraphSourceBase__ class implements the __IGraphSource__ interface and it also provides methods that work with the __Items__ and __Links__ collections. 
		

>Please keep in mind that in the __GraphSourceBase<TNode, TLink>__ implementation, __TLink__ should derive from the {% if site.site_name == 'Silverlight' %}[ILink<T>](http://www.telerik.com/help/silverlight/t_telerik_windows_diagrams_core_ilink_1.html){% endif %}{% if site.site_name == 'WPF' %}[ILink<T>](http://www.telerik.com/help/wpf/t_telerik_windows_diagrams_core_ilink_1.html){% endif %} interface.
		

GraphSourceBase<TNode, TLink> Inheritance Model![raddiagram-data-graphsource](images/raddiagram-data-graphsource.png)

__GraphSourceBase__ has one constructor - GraphSourceBase() that initializes a new instance of the class.
		

## Properties

__GraphSourceBase__ exposes the following properties:
		
<table><th><tr><td>

Name</td><td>

Description</td></tr></th><tr><td>

<b>InternalItems</b></td><td>

Gets the internal <b>ObservableCollection</b> of business nodes.
			  </td></tr><tr><td>

<b>InternalLinks</b></td><td>

Gets the internal <b>ObservableCollection</b> of business links.
			  </td></tr><tr><td>

<b>Items</b></td><td>

Gets an <b>IEnumerable</b> collection of business nodes.
			  </td></tr><tr><td>

<b>Links</b></td><td>

Gets an <b>IEnumerable</b> collection of business links.
			  </td></tr></table>

## Methods

__GraphSourceBase__ exposes the following virtual methods:
		
<table><th><tr><td>

Name</td><td>

Description</td></tr></th><tr><td>

<b>AddNode(TNode)</b></td><td>

Adds a specified business node to the <b>InternalItems</b> collection.
			  </td></tr><tr><td>

<b>AddLink(TLink)</b></td><td>

Adds a specified business link to the <b>InternalLinks</b> collection.
			  </td></tr><tr><td>

<b>RemoveLink(TLink)</b></td><td>

Removes a specified business link from the <b>InternalLinks</b> collection and returns a boolean value indicating whether the operation was successful.
			  </td></tr><tr><td>

<b>RemoveItem(TNode)</b></td><td>

Removes a specified business node from the <b>InternalItems</b> collection and returns a boolean value indicating whether the operation was successful.
			  </td></tr><tr><td>

<b>Clear</b></td><td>

Removes all nodes and links from the <b>InternalItems</b>	and <b>InternalLinks</b> collections.
			  </td></tr></table>

>Please note that in your solution it is best to create a custom class deriving from __GraphSourceBase__. Once you do so, you will be able to override all of the above virtual methods and describe a custom __RadDiagram GraphSource__ implementation.
		  

# See Also

 * [ItemViewModelBase]({%slug raddiagram-data-itemviewmodels%})

 * [NodeViewModelBase]({%slug raddiagram-data-nodeviewmodel%})

 * [LinkViewModelBase]({%slug raddiagram-data-linkviewmodel%})

 * [ContainerNodeViewModelBase]({%slug raddiagram-data-containernodeviewmodel%})

 * [HierarchicalNodeViewModel]({%slug raddiagram-data-hierarchicalnodeviewmodel%})

 * [ObservableGraphSourceBase]({%slug raddiagram-data-observablegraphsource%})

 * [SerializableGraphSourceBase]({%slug raddiagram-data-serializablegraphsource%})
