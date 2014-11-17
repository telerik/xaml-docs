---
title: ObservableGraphSourceBase
page_title: ObservableGraphSourceBase
description: ObservableGraphSourceBase
slug: raddiagram-data-observablegraphsource
tags: observablegraphsourcebase
published: True
position: 7
---

# ObservableGraphSourceBase



Telerik Diagramming Framework provides a list of __ViewModels__ defined in the __Telerik.Windows.Controls.Diagrams.Extensions.dll__.
	  

This article describes the __ObservableGraphSourceBase<TNode, TLink>__ class defined in the Diagramming Extensions.
	  

## Overview

The __ObservableGraphSourceBase<TNode, TLink>__ derives from the [GraphSourceBase]({%slug raddiagram-data-graphsourcebase%}) class and it also implements the {% if site.site_name == 'Silverlight' %}[IObservableGraphSource](http://www.telerik.com/help/silverlight/t_telerik_windows_diagrams_core_iobservablegraphsource.html){% endif %}{% if site.site_name == 'WPF' %}[IObservableGraphSource](http://www.telerik.com/help/wpf/t_telerik_windows_diagrams_core_iobservablegraphsource.html){% endif %} interface. Its main purpose is to provide an out-of-the-box ViewModel implementation that supports __TwoWay__ binding to the __RadDiagram GraphSource__ property.
		

ObservableGraphSourceBase<TNode, TLink> Inheritance Model
raddiagram-data-observablegraphsource](images/raddiagram-data-observablegraphsource.png)

>tipIf you need to define a data-bound __RadDiagram__ that has to support drag and drop of items, then you need to make sure that your custom __GraphSource__ implementation derives from the __ObservableGraphSourceBase<TNode, TLink>__ or from a class inheriting the __ObservableGraphSourceBase<TNode, TLink>__ class (for instance the [SerializableGraphSourceBase<TNode, TLink>]({%slug raddiagram-data-serializablegraphsource%}) class).  Only then the drag/drop operations will be reflected in your __ViewModels__.
		

## Inherited Properties

The __ObservableGraphSourceBase<TNode, TLink>__ class exposes all properties it inherits from the __GraphSourceBase__ class:
		
Inherited Properties

|Name|Description|
|----|-----------|
|InternalItems|Gets the internal ObservableCollection of business nodes.|
|InternalLinks|Gets the internal ObservableCollection of business links.|
|Items|Gets an IEnumerable collection of business nodes.|
|Links|Gets an IEnumerable collection of business links.|


## Methods

The __ObservableGraphSourceBase<TNode, TLink>__ class exposes the following virtual methods:
		
Virtual Methods

|Name|Description|
|CreateLink(object source, object target)|Creates a new ILink object associated with the specified source and target nodes.|
|CreateNode(IShape shape)|Creates a new instance of the TNode type. And as it receives an IShape object, when you override it, you can use the IShape argument to create a TNode instance associated with the specified shape.|

Inherited Virtual Methods

|Name|Description|
|----|-----------|
|AddNode(TNode)|Adds a specified business node to the InternalItems collection.|
|AddLink(TLink)|Adds a specified business link to the InternalLinks collection.|
|RemoveLink(TLink)|Removes a specified business link from the InternalLinks collection and returns a boolean value indicating whether the operation was successful.|
|RemoveItem(TNode)|Removes a specified business node from the InternalItems collection and returns a boolean value indicating whether the operation was successful.|
|Clear|Removes all nodes and links from the InternalItems and InternalLinks collections.|


>Please note that in your solution it is best to create a custom class deriving from __ObservableGraphSourceBase__. Once you do so, you will be able to override all of the above virtual methods. This will allow you to describe a custom __RadDiagram GraphSource__ class that supports __TwoWay__ binding scenarios where any changes in the __RadDiagram__ UI are reflected in your __GraphSource__ implementation.
		  

# See Also

 * [ItemViewModelBase]({%slug raddiagram-data-itemviewmodels%})

 * [NodeViewModelBase]({%slug raddiagram-data-nodeviewmodel%})

 * [LinkViewModelBase]({%slug raddiagram-data-linkviewmodel%})

 * [ContainerNodeViewModelBase]({%slug raddiagram-data-containernodeviewmodel%})

 * [HierarchicalNodeViewModel]({%slug raddiagram-data-hierarchicalnodeviewmodel%})

 * [GraphSourceBase]({%slug raddiagram-data-graphsourcebase%})

 * [SerializableGraphSourceBase]({%slug raddiagram-data-serializablegraphsource%})
