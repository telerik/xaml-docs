---
title: Add / Remove Items
page_title: Add / Remove Items
description: Check our &quot;Add / Remove Items&quot; documentation article for the RadGanttView {{ site.framework_name }} control.
slug: radganttview-features-items-addremove
tags: add,/,remove,items
published: True
position: 1
---

# Add / Remove Items

>Before proceding with adding/removing items, check [Types of Items]({%slug radganttview-features-items-types%}) topic.

## Add Items

In order to add new item to __RadGanttView__, first you have to create an instance of the class __Telerik.Windows.Controls.GanttView.GanttTask__, set its properties like Start, End, Title etc, and then add it to the __TasksSource__ collection of the control. 



<snippet id='radganttview-features-items-addremove-block_1-cs' />


In case you need to add a child to a __summary task__, you should add it to its Children collection:



<snippet id='radganttview-features-items-addremove-block_2-cs' />


## Remove Items

In order to remove a task you have to remove it from the __TasksSource__ collection of the control or __Children__ collection of a summary task:



<snippet id='radganttview-features-items-addremove-block_3-cs' />


>Note that when removing a task, you should also remove programmatically the relations to this item.

## See Also

 * [Types of Items]({%slug radganttview-features-items-types%})

 * [Items Relations]({%slug radganttview-features-items-relations%})
