---
title: Keyboard Support
page_title: Keyboard Support
description: Check our &quot;Keyboard Support&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagrams-features-shortcuts
tags: keyboard,support
published: True
position: 8
---

# Keyboard Support

Using the __Telerik Diagramming Framework__ allows you to trigger most of its features using key combinations. Below you can find a list of all supported key combinations and information about the features they trigger:		

* You can use the __Ctrl__ key to change the active mouse tool in the __RadDiagram__. The default tool is the __PointerTool__ but holding down the __Ctrl__ key allows you to use the __PanTool__.			

* __Ctrl + C__ - triggers the __DiagramCommands.Copy__ command			

* __Ctrl + X__ - triggers the __DiagramCommands.Cut__ command			

* __Ctrl + V__ - triggers the __DiagramCommands.Paste__ command			

* __Ctrl + Z__ - triggers the __DiagramCommands.Undo__ command			

* __Ctrl + Y__ - triggers the __DiagramCommands.Redo__ command			

* __Ctrl + A__ - triggers the __DiagramCommands.SelectAll__ command			

* __Ctrl + D__ - triggers the __DiagramCommands.Duplicate__ command			

* __Ctrl + G__ - triggers the __DiagramCommands.Group__ command			

* __Ctrl + U__ - triggers the __DiagramCommands.Ungroup__ command			

* __F2__ - triggers the __DiagramCommands.BeginEdit__ command			

* __Enter__ - triggers the __DiagramCommands.CommitEdit__ command			

* __Escape__ - triggers the __DiagramCommands.CancelEdit__ command			

* __Delete__ - triggers the __DiagramCommands.Delete__ command			

* __Ctrl + arrow__ - triggers the __DiagramCommands.Nudge__ command to slightly nudge the selection. 			

* __Ctrl + Shift + arrow__ - triggers the __DiagramCommands.Nudge__ command with command parameters that make sure to move the selection further.			

>You can find a list of all __DiagramCommands__ in the [Commands]({%slug raddiagrams-features-commands%}) tutorial.		  

These key gestures are defined in the __RadDiagram InputBindings__ collection. You can easily add and remove items from that collection thus creating custom key combinations.		

For example if you want to create a custom key combination that triggers the __DiagramCommands.Layout__ command, you can add a new __KeyBinding__ to the __RadDiagram InputBindings__ collection as follows:
	  

```XAML
    <telerik:RadDiagram x:Name="diagram" />		  
```
		  

```C#
    diagram.InputBindings.Add(new KeyBinding(DiagramCommands.Layout, Key.L, ModifierKeys.Control));		  
```
		  
 
```VB.NET
    diagram.InputBindings.Add(New KeyBinding(DiagramCommands.Layout, Key.L, ModifierKeys.Control))		  
```
		  
## See Also
 * [Getting Started]({%slug raddiagram-getting-started%})
 * [Populating with Data]({%slug raddiagram-data-overview%})
 * [Shapes]({%slug raddiagrams-features-shapes%})
 * [Connections]({%slug raddiagrams-features-connections%})
 * [Commands]({%slug raddiagrams-features-commands%})
 * [Clipboard Operations]({%slug raddiagrams-features-clipboard%})
 * [Removing Items]({%slug raddiagrams-features-delete%})
 * [Selection]({%slug raddiagrams-features-selection%})