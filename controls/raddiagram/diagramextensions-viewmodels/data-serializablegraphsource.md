---
title: SerializableGraphSourceBase
page_title: SerializableGraphSourceBase
description: SerializableGraphSourceBase
slug: raddiagram-data-serializablegraphsource
tags: serializablegraphsourcebase
publish: True
position: 7
---

# SerializableGraphSourceBase



Telerik Diagramming Framework provides a list of __ViewModels__ defined in the __Telerik.Windows.Controls.Diagrams.Extensions.dll__.
	  

This article describes the __SerializableGraphSourceBase<TNode, TLink>__ class defined in the Diagramming Extensions.
	  

## Overview

The __SerializableGraphSourceBase<TNode, TLink>__ class is an __abstract__ class which is designed to provide a base __ViewModel__ implementation that supports item serialization. It derives from __SerializableGraphSourceBase<TNode, TLink>__ and it implements the {% if site.site_name == 'Silverlight' %}[ISerializableGraphSource](http://www.telerik.com/help/silverlight/t_telerik_windows_diagrams_core_iserializablegraphsource.html){% endif %}{% if site.site_name == 'WPF' %}[ISerializableGraphSource](http://www.telerik.com/help/wpf/t_telerik_windows_diagrams_core_iserializablegraphsource.html){% endif %} interface.
		

SerializableGraphSourceBase<TNode, TLink> Inheritance Model![raddiagram-data-graphsource-hierarchy](images/raddiagram-data-graphsource-hierarchy.png)

>tipIf you need to define a data-bound __RadDiagram__ that has to support cut, copy and paste, you need to make sure that your custom __GraphSource__ implementation derives from the __SerializableGraphSourceBase<TNode, TLink>__ class. The clipboard operations internally use the serialization strings of the diagramming items and therefore you need to create a __GraphSource ViewModel__ that can serialize its business items. 
		  Also, please note that as __SerializableGraphSourceBase<TNode, TLink>__ derives from  __ObservableGraphSourceBase<TNode, TLink>__, it supports __TwoWay__ binding to the __RadDiagram GraphSource__, as well as drag and drop operations.
        

## Inherited Properties

The __SerializableGraphSourceBase<TNode, TLink>__ class exposes all properties it inherits from the __GraphSourceBase__ class:
		
<table>Inherited Properties<th><tr><td>

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

The __SerializableGraphSourceBase<TNode, TLink>__ class exposes the following __virtual__ methods:
		
<table>Virtual Methods<th><tr><td>

Name</td><td>

Description</td></tr></th><tr><td>

<b>GetNodeUniqueId(TNode)</b></td><td>

This is an abstract method that gets a node's unique id. This id should be always unique and should not rely on the object's reference. Please note that you <b>have to override</b> this method to define a custom <b>unique ID</b> for a specified node. </td></tr><tr><td>

<b>DeserializeLink(IConnection, SerializationInfo)</b></td><td>

By default this method creates a new instance of the <b>TLink</b> type. However when overridden, this method should create a new instance of an <b>TLink</b> associated with the specified <b>IConnection</b> and restore any saved information from the specified <b>SerializationInfo</b>.
			</td></tr><tr><td>

<b>DeserializeNode(IShape,SerializationInfo)</b></td><td>

By default this method creates a new instance of the <b>TNode</b> type. However when overridden, this method should create a new instance of an <b>TLink</b> associated with the specified <b>IShape</b> and restore any saved information from the specified <b>SerializationInfo</b>.
			  </td></tr><tr><td>

<b>SerializeNode(TNode, SerializationInfo)</b></td><td>

By default this method uses the <b>GetNodeUniqueId()</b> to serialize the unique ID of the node in the <b>SerializationInfo</b>. However when overridden, it should save important information about the node in the specified <b>SerializationInfo</b>.</td></tr><tr><td>

<b>SerializeLink(TLink, SerializationInfo)</b></td><td>

By default this method uses the <b>GetNodeUniqueId()</b> to serialize the unique ID of the source and target nodes of the specified link in the <b>SerializationInfo</b>. However when overridden, it should also save important information about the link in the specified <b>SerializationInfo</b>.
			  </td></tr><tr><td>

<b>ClearCache</b></td><td>

Clears the deserialization cache that contains the items generated during the deserialization of the saved data. The cache should be cleared either before or after the deserialization of the GraphSource.</td></tr></table>

# See Also

 * [ItemViewModelBase]({%slug raddiagram-data-itemviewmodels%})

 * [NodeViewModelBase]({%slug raddiagram-data-nodeviewmodel%})

 * [LinkViewModelBase]({%slug raddiagram-data-linkviewmodel%})

 * [ContainerNodeViewModelBase]({%slug raddiagram-data-containernodeviewmodel%})

 * [HierarchicalNodeViewModel]({%slug raddiagram-data-hierarchicalnodeviewmodel%})

 * [GraphSourceBase]({%slug raddiagram-data-graphsourcebase%})

 * [ObservableGraphSourceBase]({%slug raddiagram-data-observablegraphsource%})
