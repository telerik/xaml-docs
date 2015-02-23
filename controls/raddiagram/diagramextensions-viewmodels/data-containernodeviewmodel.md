---
title: ContainerNodeViewModelBase
page_title: ContainerNodeViewModelBase
description: ContainerNodeViewModelBase
slug: raddiagram-data-containernodeviewmodel
tags: containernodeviewmodelbase
published: True
position: 4
---

# ContainerNodeViewModelBase

Telerik Diagramming Framework provides a list of __ViewModels__ defined in the __Telerik.Windows.Controls.Diagrams.Extensions.dll__.	  

This article describes the __ContainerNodeViewModelBase__ defined in the Diagramming Extensions.  

## Overview

__ContainerNodeViewModelBase__ is a __ViewModel__ designed to serve as a base __ViewModel__ for __RadDiagramContainerShapes__ in a data-bound __RadDiagram__. The class is defined to expose properties that allow you to track and save the state of a ContainerShape in business models. It derives from the  [NodeViewModelBase]({%slug raddiagram-data-nodeviewmodel%}) class and implements the {% if site.site_name == 'Silverlight' %}[IContainerItem](http://www.telerik.com/help/silverlight/t_telerik_windows_diagrams_core_icontaineritem.html){% endif %}{% if site.site_name == 'WPF' %}[IContainerItem](http://www.telerik.com/help/wpf/t_telerik_windows_diagrams_core_icontaineritem.html){% endif %} interface.

ContainerNodeViewModelBase Inheritance Model
![raddiagram-data-containernodeviewmodel](images/raddiagram-data-containernodeviewmodel.png)

__ContainerNodeViewModelBase__ has a single constructor - ContainerNodeViewModelBase() that initializes a new instance of the class.		

## Properties

The __ContainerNodeViewModelBase__ class exposes the following properties:
		
Properties:

|Name|Description|
|----|-----------|
|InternalItems|Gets the internal ObservableCollection of nodes that are wrapped in the container.|

And as the class derives from the __NodeViewModelBase__, it also inherits all of its properties:
		
Inherited Properties

|Name|Description|
|----|-----------|
|Width|Gets or sets a Double value indicating the Width of the represented shape.|
|Height|Gets or sets a Double value indicating the Height of the represented shape.|
|RotationAngle|Gets or sets a Double value indicating the rotation angle of the represented shape.|
|Visibility|Gets or sets the Visibility of the represented shape. The property is of type Visibility.|
|Position|Gets or sets the coordinates of a Point that represents the position of the represented shape.|
|Content|Gets or sets an object that represents the content of a shape.|
|IsSelected|Gets or sets a Boolean value indicating whether the represented shape is selected.|

## Methods

The __ContainerNodeViewModelBase__ class exposes the following methods:
		  
|Name|Description|
|----|-----------|
|AddItem|Adds an object to the InternalItems collection.|
|RemoveItem|Removes an object from the InternalItems collection.|

# See Also
 * [ItemViewModelBase]({%slug raddiagram-data-itemviewmodels%})
 * [NodeViewModelBase]({%slug raddiagram-data-nodeviewmodel%})
 * [LinkViewModelBase]({%slug raddiagram-data-linkviewmodel%})
 * [HierarchicalNodeViewModel]({%slug raddiagram-data-hierarchicalnodeviewmodel%})
 * [GraphSourceBase]({%slug raddiagram-data-graphsourcebase%})
 * [ObservableGraphSourceBase]({%slug raddiagram-data-observablegraphsource%})
 * [SerializableGraphSourceBase]({%slug raddiagram-data-serializablegraphsource%})