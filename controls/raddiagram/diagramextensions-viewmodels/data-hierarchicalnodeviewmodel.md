---
title: HierarchicalNodeViewModel
page_title: HierarchicalNodeViewModel
description: HierarchicalNodeViewModel
slug: raddiagram-data-hierarchicalnodeviewmodel
tags: hierarchicalnodeviewmodel
published: True
position: 5
---

# HierarchicalNodeViewModel

Telerik Diagramming Framework provides a list of __ViewModels__ defined in the __Telerik.Windows.Controls.Diagrams.Extensions.dll__.	  

This article describes the __HierarchicalNodeViewModel__ defined in the Diagramming Extensions.	  

## Overview

__HierarchicalNodeViewModel__ is a __ViewModel__ designed to serve as a base __ViewModel__ for hierarchical __RadDiagramShapes__ in a data-bound __RadDiagram__. The class is defined to expose properties that allow you to track and save the children of a hierarchical shape. It derives from the  [NodeViewModelBase]({%slug raddiagram-data-nodeviewmodel%}) class.		

HierarchicalNodeViewModel Inheritance Model
![raddiagram-data-hierarchicalnodeviewmodel](images/raddiagram-data-hierarchicalnodeviewmodel.png)

__HierarchicalNodeViewModel__ has a single constructor - HierarchicalNodeViewModel() that initializes a new instance of the class.		

## Properties

The __HierarchicalNodeViewModel__ class exposes the following properties:
		
|Name|Description|
|----|----|
|Children|Gets or sets an ObservableCollection of HierarchicalNodeViewModel items that represent the children of the current node.|
|HasChildren|Gets a Boolean value indicating whether a HierarchicalNodeViewModel item has any children.|

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

# See Also
 * [ItemViewModelBase]({%slug raddiagram-data-itemviewmodels%})
 * [NodeViewModelBase]({%slug raddiagram-data-nodeviewmodel%})
 * [LinkViewModelBase]({%slug raddiagram-data-linkviewmodel%})
 * [ContainerNodeViewModelBase]({%slug raddiagram-data-containernodeviewmodel%})
 * [GraphSourceBase]({%slug raddiagram-data-graphsourcebase%})
 * [ObservableGraphSourceBase]({%slug raddiagram-data-observablegraphsource%})
 * [SerializableGraphSourceBase]({%slug raddiagram-data-serializablegraphsource%})