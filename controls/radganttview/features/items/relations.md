---
title: Items Relations
page_title: Items Relations
description: Items Relations
slug: radganttview-features-items-relations
tags: items,relations
published: True
position: 2
---

# Items Relations

Project plans normally require tasks to be performed in a certain order. To achieve this, __RadGanttView__ lets you create relations between the tasks, so that they depend on each other.

The relation is set through __Dependencies__ property of the __GanttTask__ class:

#### __C#__

{{region cs-radganttview-features-items-relations_0}}
	var task1 = new GanttTask(date, date.AddDays(1), "task 1");
	var task2 = new GanttTask(date.AddDays(1), date.AddDays(1).AddHours(15), "task 2");
	
	task2.Dependencies.Add(new Dependency() { FromTask = task1 });
{{endregion}}

Here is the result in the Gantt chart:

![ganttview items relations](images/ganttview_items_relations.png)
