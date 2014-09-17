---
title: LinkViewModelBase
page_title: LinkViewModelBase
description: LinkViewModelBase
slug: raddiagram-data-linkviewmodel
tags: linkviewmodelbase
published: True
position: 2
---

# LinkViewModelBase



Telerik Diagramming Framework provides a list of __ViewModels__ defined in the __Telerik.Windows.Controls.Diagrams.Extensions.dll__.
	  

This article describes the __LinkViewModelBase__ defined in the Diagramming Extensions.
	  

## Overview

The __LinkViewModelBase__ class is a __ViewModel__ designed to serve as a base __ViewModel__ for __RadDiagramConnections__ in a data-bound __RadDiagram__. As the connection can start from one shape and end in another one, the __LinkViewModelBase__ class is defined to expose properties that track these source and target shapes.
	  

Essentially the __LinkViewModelBase__ derives from [ItemViewModelBase]({%slug raddiagram-data-itemviewmodels%}) and therefore the class exposes all properties defined in the __ItemViewModelBase__ class. Moreover, the __LinkViewModelBase__ class inherits the {% if site.site_name == 'Silverlight' %}[ILink<T>](http://www.telerik.com/help/silverlight/t_telerik_windows_diagrams_core_ilink_1.html){% endif %}{% if site.site_name == 'WPF' %}[ILink<T>](http://www.telerik.com/help/wpf/t_telerik_windows_diagrams_core_ilink_1.html){% endif %} interface, where __T__ should derive from [NodeViewModelBase]()


                  LinkViewModelBase Inheritance Model
              ![raddiagram-data-linkviewmodel](images/raddiagram-data-linkviewmodel.png)

## Constructors
<table><th><tr><td>

Name</td><td>

Description</td></tr></th><tr><td>

<b>LinkViewModelBase()</b></td><td>

Initializes a new instance of the <b>LinkViewModelBase</b> class that represents a link on the diagramming surface.
			</td></tr><tr><td>

<b>LinkViewModelBase(T source, T target)</b></td><td>

Initializes a new instance of the <b>LinkViewModelBase</b> class that represents a link starting from the specified source node and ending at the specified target node.
			</td></tr></table>

## Properties

The __LinkViewModelBase__ class exposes the following properties:
		
<table>Properties:<th><tr><td>

Name</td><td>

Description</td></tr></th><tr><td>

<b>Source</b></td><td>

Gets or sets the source of the connection which should be of type deriving from <b>NodeViewModelBase</b>.
			</td></tr><tr><td>

<b>Target</b></td><td>

Gets or sets the target of the connection which should be of type deriving from <b>NodeViewModelBase</b>.
			  </td></tr><tr><td>

<b>SourceCapType</b></td><td>

Gets or sets the <b>CapType</b> of the start of the represented connection. You can find more information regarding the different <b>CapTypes</b> in the [Connections](5a2d6cbf-4f5c-466c-baec-19360d30803d#CapTypes) article.
			</td></tr><tr><td>

<b>TargetCapType</b></td><td>

Gets or sets the <b>CapType</b> of the end of the represented connection. You can find more information regarding the different <b>CapTypes</b> in the [Connections](5a2d6cbf-4f5c-466c-baec-19360d30803d#CapTypes) article.
			  </td></tr></table>
<table>Inherited Properties<th><tr><td>

Name</td><td>

Description</td></tr></th><tr><td>

<b>Visibility</b></td><td>

Gets or sets the Visibility of the represented connection. The property is of type <b>Visibility</b>.
			  </td></tr><tr><td>

<b>Position</b></td><td>

Gets or sets the coordinates of a <b>Point</b> that represents the position of a connection.
			  </td></tr><tr><td>

<b>Content</b></td><td>

Gets or sets an <b>object</b> that represents the content of the represented connection.
			  </td></tr><tr><td>

<b>IsSelected</b></td><td>

Gets or sets a <b>Boolean</b> value indicating whether the represented connection is selected.
			  </td></tr></table>

# See Also

 * [ItemViewModelBase]({%slug raddiagram-data-itemviewmodels%})

 * [NodeViewModelBase]({%slug raddiagram-data-nodeviewmodel%})

 * [ContainerNodeViewModelBase]({%slug raddiagram-data-containernodeviewmodel%})

 * [HierarchicalNodeViewModel]({%slug raddiagram-data-hierarchicalnodeviewmodel%})

 * [GraphSourceBase]({%slug raddiagram-data-graphsourcebase%})

 * [ObservableGraphSourceBase]({%slug raddiagram-data-observablegraphsource%})

 * [SerializableGraphSourceBase]({%slug raddiagram-data-serializablegraphsource%})
