---
title: Display ScrollViewer Inside the Diagram
page_title: Display ScrollViewer Inside the Diagram
description: Check our &quot;Display ScrollViewer Inside the Diagram&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagram-howto-display-scroll
tags: display,scrollviewer,inside,the,diagram
published: True
position: 2
---

# Display ScrollViewer Inside the Diagram

This tutorial describes how to display the RadDiagram built-in ScrollViewer.

For the purpose of this tutorial we'll examine the following simple Diagramming structure:


<snippet id='raddiagram-howto-display-scroll-block_1-xaml' />


As the __Grid__ hosting our __RadDiagram__ has a limited size, we can't see the second shape in the viewport:
![Rad Diagram How To Scroll No Scroll](images/RadDiagram_HowTo_Scroll_NoScroll.png)

In such scenarios it's useful to use the __RadDiagram__ built-in __ScrollViewer__, which you can display to get a better view of the area described by the position and size of your __RadDiagramItems__. 
![Rad Diagram How To Scroll Scroll](images/RadDiagram_HowTo_Scroll_Scroll.png)

In order to enable the horizontal and/or vertical __ScrollBar__ you need to add the following attribute(s) to the __RadDiagram__ declaration:		


<snippet id='raddiagram-howto-display-scroll-block_2-xaml' />


The same operation can be done in code-behind as well:


<snippet id='raddiagram-howto-display-scroll-block_3-cs' />

<snippet id='raddiagram-howto-display-scroll-block_3-vb' />


## See Also
 * [Getting Started]({%slug raddiagram-getting-started%})
 * [Create Custom Shape]({%slug raddiagram-howto-create-custom-shape%})
 * [Overview]({%slug raddiagram-data-overview%})
 * [Use MVVM in RadDiagram]({%slug raddiagrams-howto-mvvm%})