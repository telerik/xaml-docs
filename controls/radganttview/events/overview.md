---
title: Overview
page_title: Overview
description: Overview
slug: radganttview-events-overview
tags: overview
published: True
position: 0
---

# Overview

This topic covers the specific events exposed by __RadGanttView__.

__RadGanttView__ raises the following specific events:

* __TaskEditing__ - occurs when a task editing is initiated through the UI.

* __TaskSaving__ - occurs when an edit operation is being committed through the UI.

	Both events receive two arguments:

	* The sender argument contains __RadGanttView__. This argument is of type object, but can be cast to __RadGanttView__ type.

	* A __TaskEditingEventArgs__ object.
	
* __TaskEdited__ - occurs when a task has been edited through the UI.

	* The sender argument contains __RadGanttView__. This argument is of type object, but can be cast to __RadGanttView__ type.

	* A __TaskEditedEventArgs__ object.

## See Also

 * [Getting Started]({%slug radganttview-getting-started%})
 
 * [Visual Structure]({%slug radganttview-visual-structure%})

