---
title: Save the Diagram in the File System
page_title: Save the Diagram in the File System
description: Save the Diagram in the File System
slug: raddiagrams-howto-save
tags: save,the,diagram,in,the,file,system
published: True
position: 6
site_name: WPF
---

# Save the Diagram in the File System



The following article will show how you can save the __RadDiagram__ in the File System and load it.
	  

## Save the Diagram to the File System and Load

Let's first configure our XAML. We'll keep it simple - two buttons for Save and Load and a Diagram with one shape.





In code behind we are using the Click event handlers of our Save/Load Buttons. On Save, we use a __SaveFileDialog__ and we can create new or overwrite an existing text file.
		

Then we use the __RadDiagram.Save()__ - this returns a string with the serialized Diagram. Having this string, the final step is to use __StreamWriter__ to write the string into
		  the chosen file.
		

On Load, we open the created file by __OpenFileDialog__ and use __StreamReader__ and __RadDiagram.Load()__ method.
		









# See Also

 * [Serialization]({%slug raddiagrams-features-serialization%})

 * [Commands]({%slug raddiagrams-features-commands%})
