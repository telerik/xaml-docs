---
title: Exclude shape from serialization
page_title: Exclude shape from serialization
description: This article explains how you can exclude shapes from serialization.
slug: raddiagrams-howto-exclude-shape-from-serialization
tags: save,the,diagram,in,the,file,system, serialization,serialize,
published: True
position: 6
site_name: WPF
---

# How to Exclude Shapes from Serialization

The following article will demonstrate how to exclude shapes from serialization.

>With the __2024 Q3 SP1__ release, the RadDiagram control requires registering the custom types of shapes, connections, and connectors, in order to deserialize them successfully. Read more about this change [here]({%slug raddiagrams-features-serialization%}#allowing-safe-types-and-assemblies).

For the purpose of this example, we will create the following view models.

* __Node__: A class deriving from the [NodeViewModelBase]({%slug raddiagram-data-nodeviewmodel%}) class that represents a node. The class will implement two additional properties: bool __IsStatic__ and Guid __ID__. The serialization of the shapes will depends on the first property. The __Guid__ property will be returned in the __GetNodeUniqueId()__ to cache the serialized shapes and connections.

* __Link__: A class deriving from the [LinkViewModelBase]({%slug raddiagram-data-linkviewmodel%}) that represent a connection.

* __MyGraphSource__: A class deriving from the [SerializableGraphSourceBase]({%slug raddiagram-data-serializablegraphsource%}) class that represent the RadDiagram GraphSource.

__Example 1: Creating view models__
<snippet id='raddiagram-howto-howto-exclude-shapes-from-serialization-example_1_creating_view_models-cs' />


Next to exclude a shape from serialization, create a custom class which derives from __SerializationService__ and override the __SerializeShapes__ method. Inside the method you can create custom logic to filter which shapes to be serialize and pass it to the __base.SerializeShapes()__ method.

__Example 2: Creating custom SerializationService__
<snippet id='raddiagram-howto-howto-exclude-shapes-from-serialization-example_2_creating_custom_serializationservice-cs' />


Next, define a RadDiagram control in the Xaml view. We'll keep it simple - two buttons for save and load and a diagram with two shapes.

__Example 2: Defining RadDiagram in XAML__
<snippet id='raddiagram-howto-howto-exclude-shapes-from-serialization-example_2_defining_raddiagram_in_xaml-xaml' />


Finally, set the RadDiagram __GraphSource__ property, register the custom __SerializationService__ class and override the __Open and Save commands__ from the DiagramCommands class. Then using the [DiagramExtension FileManager]({%slug raddiagram-extensions-filemanager%}) class you can export the diagram into a file and load it again from it.

__Example 2: Register the custom SerializationService__
<snippet id='raddiagram-howto-howto-exclude-shapes-from-serialization-example_2_register_the_custom_serializationservice-cs' />


## See Also
 * [Serialization]({%slug raddiagrams-features-serialization%})
 * [Commands]({%slug raddiagrams-features-commands%})
