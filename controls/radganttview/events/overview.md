---
title: Overview
page_title: Overview
description: This article shows the events exposed by RadGanttView.
slug: radganttview-events-overview
tags: overview
published: True
position: 0
---

# Overview

This topic covers the specific events exposed by __RadGanttView__.

__RadGanttView__ raises the following events, when a task is edited through the UI, in the order that they are shown below:

* __TaskEditing__: Occurs when the task editing is initiated through the UI. __Example 1__ demonstrates how you can handle the event in order to cancel the editing based on a specific condition.

	__Example 1: Canceling the editing of a task__
	<snippet id='radganttview-events-overview-example_1_canceling_the_editing_of_a_task-cs' />

	<snippet id='radganttview-events-overview-example_1_canceling_the_editing_of_a_task-vb' />


* __TaskSaving__: Occurs when an edit operation is being committed through the UI. Please, note that you can handle this event to cancel the editing similarly to __Example 1__.

	The __TaskEditing__ and __TaskSaving__ events receive the following two arguments:

	* The sender argument contains the __RadGanttView__. This argument is of type object, but can be cast to __RadGanttView__ type.

	* A __TaskEditingEventArgs__ object. It contains the task that is being edited.
	
* __TaskEdited__: Occurs when a task has been edited through the UI. __Example 2__ demonstrates how you can handle the event in order to show a MessageBox indicating the __Duration__ of the task after it has been edited.

	* The sender argument contains the __RadGanttView__. This argument is of type object, but can be cast to __RadGanttView__ type.

	* A __TaskEditedEventArgs__ object. It contains the task that has been edited.

	__Example 2: Show Task duration after it has been edited__
	<snippet id='radganttview-events-overview-example_2_show_task_duration_after_it_has_been_edited-cs' />

	<snippet id='radganttview-events-overview-example_2_show_task_duration_after_it_has_been_edited-vb' />


## See Also

 * [Getting Started]({%slug radganttview-getting-started%})
 
 * [Visual Structure]({%slug radganttview-visual-structure%})
