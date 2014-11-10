---
title: Maintain the Items' Positions When the Diagram is Resized
page_title: Maintain the Items' Positions When the Diagram is Resized
description: Maintain the Items' Positions When the Diagram is Resized
slug: raddiagram-howto-maintain-shapes-positions-when-resizing-the-diagram
tags: maintain,the,items',positions,when,the,diagram,is,resized
published: True
position: 3
---

# Maintain the Items' Positions When the Diagram is Resized



The purpose of this article is to show how a user can maintain the RadDiagramItems' Position, Width and Height when the Diagram is being resized.
            

## Maintaining the Items' Positions When Resizing the RadDiagram

Consider the following scenario. We are working with RadDiagram used over an Image. When we resize the Window/UserControl which contains the RadDiagram and the Image, we want to preserve the relative positions of the Shapes we use.Here is the XAML of a RadDiagram used with Image:

We can use the __RadDiagram.SizeChanged__ event, iterate over the __Shapes__ collection and update the shapes' Position, Width and Height like so:

Below you can see this in action. The Window or UserControl is resized and the Shapes' Position and size are updated:
![raddiagrams howto preserverpositions 1](images/raddiagrams_howto_preserverpositions1.png)
![raddiagrams howto preserverpositions 2](images/raddiagrams_howto_preserverpositions2.png)

# See Also

 * [Resizing]({%slug raddiagrams-features-resizing%})
