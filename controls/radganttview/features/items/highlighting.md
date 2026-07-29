---
title: Highlighting Items
page_title: Highlighting Items
description: Check our &quot;Highlighting Items&quot; documentation article for the RadGanttView {{ site.framework_name }} control.
slug: radganttview-features-items-highlighting
tags: highlighting,items
published: True
position: 3
---

# Highlighting Items

With __RadGanttView__ you can easily highlight certain tasks in order to make them distinguishable on the Gantt chart.They can be, for example, late tasks or tasks participating in the critical path.

In this topic we will explain how you can define a collection of highlighted tasks and bind it to the __HighlightedItemsSource__ property of the __RadGanttView__.

>Before proceding with the tutorial, check [Implementing View-ViewModel]({%slug radganttview-populating-with-data-viewmodel%}) topic where it is explained how to bind the GanttView with a ViewModel.

* First, define a property in the ViewModel which should hold the highlighted tasks:



<snippet id='radganttview-features-items-highlighting-block_1-cs' />


* Then add the needed tasks to the HighlightedTasks:



<snippet id='radganttview-features-items-highlighting-block_2-cs' />


* Finally, bind the HighlightedTasks to __HighlightedItemsSource__ property:



<snippet id='radganttview-features-items-highlighting-block_3-xaml' />


The end result should look like this:

![ganttview items highlighting](images/ganttview_items_highlighting.png)
