---
title: NodeViewModelBase
page_title: NodeViewModelBase
description: NodeViewModelBase
slug: raddiagram-data-nodeviewmodel
tags: nodeviewmodelbase
published: True
position: 2
---

# NodeViewModelBase



Telerik Diagramming Framework provides a list of __ViewModels__ defined in the __Telerik.Windows.Controls.Diagrams.Extensions.dll__.
	  

This article describes the __NodeViewModelBase__ defined in the Diagramming Extensions.
	  

## Overview

__NodeViewModelBase__ is a __ViewModel__ designed to serve as a base __ViewModel__ for __RadDiagramShapes__ in a data-bound __RadDiagram__. The class is defined to expose properties that allow you to track and save the state of a shape in business models. It derives from the  [ItemViewModelBase]({%slug raddiagram-data-itemviewmodels%}) class.
		


                  NodeViewModelBase Inheritance Model
              ![raddiagram-data-nodeviewmodel](images/raddiagram-data-nodeviewmodel.png)

__NodeViewModelBase__ has a single constructor - NodeViewModelBase() that initializes a new instance of the class.
		

## Properties
<table>Properties<th><tr><td>

Name</td><td>

Description</td></tr></th><tr><td>

<b>Width</b></td><td>

Gets or sets a <b>Double</b> value indicating the <b>Width</b> of the represented shape.
			  </td></tr><tr><td>

<b>Height</b></td><td>

Gets or sets a <b>Double</b> value indicating the <b>Height</b> of the represented shape.
			  </td></tr><tr><td>

<b>RotationAngle</b></td><td>

Gets or sets a <b>Double</b> value indicating the rotation angle of the represented shape.
			  </td></tr></table>
<table>Inherited Properties:<th><tr><td>

Name</td><td>

Description</td></tr></th><tr><td>

<b>Visibility</b></td><td>

Gets or sets the Visibility of the represented shape. The property is of type <b>Visibility</b>.
			  </td></tr><tr><td>

<b>Position</b></td><td>

Gets or sets the coordinates of a <b>Point</b> that represents the position of the represented shape.
			  </td></tr><tr><td>

<b>Content</b></td><td>

Gets or sets an <b>object</b> that represents the content of a shape.
			  </td></tr><tr><td>

<b>IsSelected</b></td><td>

Gets or sets a <b>boolean</b> value indicating whether the represented shape is selected.
			  </td></tr></table>

# See Also

 * [ItemViewModelBase]({%slug raddiagram-data-itemviewmodels%})

 * [ContainerNodeViewModelBase]({%slug raddiagram-data-containernodeviewmodel%})

 * [LinkViewModelBase]({%slug raddiagram-data-linkviewmodel%})

 * [HierarchicalNodeViewModel]({%slug raddiagram-data-hierarchicalnodeviewmodel%})

 * [GraphSourceBase]({%slug raddiagram-data-graphsourcebase%})

 * [ObservableGraphSourceBase]({%slug raddiagram-data-observablegraphsource%})

 * [SerializableGraphSourceBase]({%slug raddiagram-data-serializablegraphsource%})
