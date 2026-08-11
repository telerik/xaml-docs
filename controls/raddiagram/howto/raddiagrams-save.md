---
title: Save the Diagram in the File System
page_title: Save the Diagram in the File System
description: This article explains how you can save and load the RadDiagram control to and from an XML file on your system.
slug: raddiagrams-howto-save
tags: save,the,diagram,in,the,file,system
published: True
position: 6
site_name: WPF
---

# Save the Diagram in the File System

The following article will demonstrate how you can save the __RadDiagram__ in the file system and load it.	  

## Save the Diagram to the File System and Load

Let's first configure our XAML. We'll keep it simple - two buttons for save and Load and a Diagram with one shape.

__Example 1: RadDiagram with a single shape and two buttons for save and load__
<snippet id='raddiagram-howto-raddiagrams-save-example_1_raddiagram_with_a_single_shape_and_two_buttons_for_save_and_load-xaml' />


In the code behind we are using the Click event handlers of our save/load buttons. On save, we use a __SaveFileDialog__ to create a new file or overwrite an existing text file.		

Then we use the __RadDiagram.Save()__ method which returns a string with the serialized RadDiagram. Having this string, the final step is to use __StreamWriter__ to write the string into the chosen file.

On Load, we open the created file using an __OpenFileDialog__ and use the __StreamReader__ and the __RadDiagram.Load()__ method to load the serialized XML.

__Example 2: The Save and Load handlers__
<snippet id='raddiagram-howto-raddiagrams-save-example_2_the_save_and_load_handlers-cs' />

<snippet id='raddiagram-howto-raddiagrams-save-example_2_the_save_and_load_handlers-vb' />


> You can also replace the OpenFileDialog and SaveFileDialog with Telerik's [RadOpenFileDialog]({%slug radfiledialogs-radopenfiledialog%}) and [RadSaveFileDialog]({%slug radfiledialogs-radsavefiledialog%}) for a more consistent look.

## See Also
 * [Serialization]({%slug raddiagrams-features-serialization%})
 * [Commands]({%slug raddiagrams-features-commands%})