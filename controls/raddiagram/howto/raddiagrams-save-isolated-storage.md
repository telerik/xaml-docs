---
title: Save the Diagram in Isolated Storage
page_title: Save the Diagram in Isolated Storage
description: Save the Diagram in Isolated Storage
slug: raddiagrams-howto-save-isolated-storage
tags: save,the,diagram,in,isolated,storage
published: True
position: 5
site_name: Silverlight
---

# Save the Diagram in Isolated Storage

The following article will show how you can save the RadDiagram in IsolatedStorage and load it.       

## Save the Diagram to Storage and Load

Let's first configure our XAML. We'll keep it simple - two buttons for Save and Load and a Diagram with one shape.

In code behind we are using the Click event handlers of our Save/Load Buttons. On Save, we get an __IsolatedStorage__ and create a folder and a file in it.		

Then we use the __RadDiagram.Save()__ - this returns a string with the serialized Diagram. Having this string, the final step is to use __StreamWriter__ to write the string into the file from the storage.		

On Load, we open the created file from storage and use __StreamReader__ and __RadDiagram.Load()__ method.

# See Also
 * [Serialization]({%slug raddiagrams-features-serialization%})
 * [Commands]({%slug raddiagrams-features-commands%})
