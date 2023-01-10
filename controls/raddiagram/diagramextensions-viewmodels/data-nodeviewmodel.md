---
title: NodeViewModelBase
page_title: NodeViewModelBase
description: Check our &quot;NodeViewModelBase&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagram-data-nodeviewmodel
tags: nodeviewmodelbase
published: True
position: 2
---

# {{ site.framework_name }} RadDiagram NodeViewModelBase

Telerik Diagramming Framework provides a list of __ViewModels__ defined in the __Telerik.Windows.Controls.Diagrams.Extensions.dll__.	  

This article describes the __NodeViewModelBase__ defined in the Diagramming Extensions.	  

## Overview

__NodeViewModelBase__ is a __ViewModel__ designed to serve as a base __ViewModel__ for __RadDiagramShapes__ in a data-bound __RadDiagram__. The class is defined to expose properties that allow you to track and save the state of a shape in business models. It derives from the  [ItemViewModelBase]({%slug raddiagram-data-itemviewmodels%}) class.		

NodeViewModelBase Inheritance Model
![raddiagram-data-nodeviewmodel](images/raddiagram-data-nodeviewmodel.png)

__NodeViewModelBase__ has a single constructor - NodeViewModelBase() that initializes a new instance of the class.		

## Properties

Properties

|Name|Description|
|----|-----------|
|Width|Gets or sets a Double value indicating the Width of the represented shape.|
|Height|Gets or sets a Double value indicating the Height of the represented shape.|
|RotationAngle|Gets or sets a Double value indicating the rotation angle of the represented shape.|

Inherited Properties

|Name|Description|
|----|-----------|
|Visibility|Gets or sets the Visibility of the represented shape. The property is of type Visibility.|
|Position|Gets or sets the coordinates of a Point that represents the position of the represented shape.|
|Content|Gets or sets an object that represents the content of a shape.|
|IsSelected|Gets or sets a boolean value indicating whether the represented shape is selected.|

## Serialize NodeViewModelBase With Custom Properties

When specifying custom properties, the name of the properties must differ from the names declared in the __SerializationConstants.cs__ class. Otherwise, the serialization mechanism of the RadDiagram won't work as expected.

## See Also
 * [ItemViewModelBase]({%slug raddiagram-data-itemviewmodels%})
 * [ContainerNodeViewModelBase]({%slug raddiagram-data-containernodeviewmodel%})
 * [LinkViewModelBase]({%slug raddiagram-data-linkviewmodel%})
 * [HierarchicalNodeViewModel]({%slug raddiagram-data-hierarchicalnodeviewmodel%})
 * [GraphSourceBase]({%slug raddiagram-data-graphsourcebase%})
 * [ObservableGraphSourceBase]({%slug raddiagram-data-observablegraphsource%})
 * [SerializableGraphSourceBase]({%slug raddiagram-data-serializablegraphsource%})