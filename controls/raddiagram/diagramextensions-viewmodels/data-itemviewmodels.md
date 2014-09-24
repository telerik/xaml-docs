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
		
<table><th><tr><td>

Name</td><td>

Description</td></tr></th><tr><td>

<b>Visibility</b></td><td>

Gets or sets the Visibility of an item. It is of type <b>Visibility</b>.
			</td></tr><tr><td>

<b>Position</b></td><td>

Gets or sets the coordinates of a <b>Point</b> that represents the position of an item on the diagramming surface.</td></tr><tr><td>

<b>Content</b></td><td>

Gets or sets an <b>object</b> that represents the content of an item.</td></tr><tr><td>

<b>IsSelected</b></td><td>

Gets or sets a <b>Boolean</b> value indicating whether an item is selected.</td></tr></table>

# See Also

 * [NodeViewModelBase]({%slug raddiagram-data-nodeviewmodel%})

 * [LinkViewModelBase]({%slug raddiagram-data-linkviewmodel%})

 * [ContainerNodeViewModelBase]({%slug raddiagram-data-containernodeviewmodel%})

 * [HierarchicalNodeViewModel]({%slug raddiagram-data-hierarchicalnodeviewmodel%})

 * [GraphSourceBase]({%slug raddiagram-data-graphsourcebase%})

 * [ObservableGraphSourceBase]({%slug raddiagram-data-observablegraphsource%})

 * [SerializableGraphSourceBase]({%slug raddiagram-data-serializablegraphsource%})
