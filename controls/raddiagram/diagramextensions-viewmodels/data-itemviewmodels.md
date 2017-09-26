---
title: ItemViewModelBase
page_title: ItemViewModelBase
description: ItemViewModelBase
slug: raddiagram-data-itemviewmodels
tags: itemviewmodelbase
published: True
position: 1
---

# ItemViewModelBase

Telerik Diagramming Framework provides a list of __ViewModels__ defined in the __Telerik.Windows.Controls.Diagrams.Extensions.dll__.	  

This article describes the __ItemViewModelBase__ class defined in the Diagramming Extensions.

## Overview

The __ItemViewModelBase__ class is designed to serve as a base __ViewModel__ that can describe any __RadDiagramItem__. It implements the {% if site.site_name == 'Silverlight' %}[ViewModelBase](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_viewmodelbase.html){% endif %}{% if site.site_name == 'WPF' %}[ViewModelBase](http://www.telerik.com/help/wpf/t_telerik_windows_controls_viewmodelbase.html){% endif %} class.

ItemViewModelBase Inheritance Model
                  
![raddiagram-data-itemviewmodelbase](images/raddiagram-data-itemviewmodelbase.png)

__ItemViewModelBase__ exposes one constructor - ItemViewModelBase() that initializes a new instance of the class.	  

## Properties

The __ItemViewModelBase__ class exposes the following properties:
		
|Name|Description|
|----|-----------|
|Visibility|Gets or sets the Visibility of an item. It is of type Visibility.|
|Position|Gets or sets the coordinates of a Point that represents the position of an item on the diagramming surface.|
|Content|Gets or sets an object that represents the content of an item.|
|IsSelected|Gets or sets a Boolean value indicating whether an item is selected.|


## See Also
 * [NodeViewModelBase]({%slug raddiagram-data-nodeviewmodel%})
 * [LinkViewModelBase]({%slug raddiagram-data-linkviewmodel%})
 * [ContainerNodeViewModelBase]({%slug raddiagram-data-containernodeviewmodel%})
 * [HierarchicalNodeViewModel]({%slug raddiagram-data-hierarchicalnodeviewmodel%})
 * [GraphSourceBase]({%slug raddiagram-data-graphsourcebase%})
 * [ObservableGraphSourceBase]({%slug raddiagram-data-observablegraphsource%})
 * [SerializableGraphSourceBase]({%slug raddiagram-data-serializablegraphsource%})