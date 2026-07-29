---
title: How to serialize ViewPort after Save/Load operation
page_title: How to serialize ViewPort after Save/Load operation
description: This article explains how you can serialize RadDiagram ViewPort after save and load operation.
slug: raddiagrams-howto-serialize-viewport-save-load
tags: save,the,diagram,in,the,file,system, metadataserialized, MetadataDeserialized
published: True
position: 6
site_name: WPF
---

# How to serialize ViewPort after Save/Load operation

The following article will demonstrate how you can save the __RadDiagram__ current ViewPort position in the file system and load it again.	  

Let's first configure our XAML. We'll keep it simple - two buttons for save and Load and a Diagram with one shape.

__Example 1: RadDiagram with a single shape and two buttons for save and load__
<snippet id='raddiagram-howto-howto-serialize-viewport-example_1_raddiagram_with_a_single_shape_and_two_buttons_for_save_and_load-xaml' />


In code behind we are subscribing to the Execute method of the Open/Save DiagramCommands. Then using the [DiagramExtension FileManager]({%slug raddiagram-extensions-filemanager%}) class you can export the diagram into file and load it again from it.

The next step is to subscribe to the __MetadataSerialized__ and __MetadataDeserialized__ events of the diagram control. In the MetadataSerialized event handler you can add a __Key__ to the __SerializationInfo__ object which will hold the __ViewPort.TopLeft__ property before the control is saved. Then in the __MetadataDeserialized__ event handler you can get the value of this property and call the __BringIntoView()__ method of the RadDiagram when the __DiagramCommands.Open__ command execute. __Example 2__ shows the whole logic for performing this approach.

__Example 2: Code-Behind logic__
<snippet id='raddiagram-howto-howto-serialize-viewport-example_2_code_behind_logic-cs' />


## See Also
 * [Serialization]({%slug raddiagrams-features-serialization%})
 * [Commands]({%slug raddiagrams-features-commands%})