---
title: GanttTask Deadline
page_title: GanttTask Deadline
description: Check our &quot;GanttTask Deadline&quot; documentation article for the RadGanttView {{ site.framework_name }} control.
slug: radganttview-features-items-gantttask-deadline
tags: gantttask,deadline
published: True
position: 5
---

# GanttTask Deadline

RadGanttView tasks allow you to display an indicator showing whether the task is expired or not. You can enable this by setting the __Deadline__ property of the __GanttTask__ object. This help topic will describe the Deadline property in more details as well as how you could customize its behavior.

## Overview

Setting the __Deadline__ property of the GanttTask visualizes a vertical line showing the deadline for finishing the task as well as an indicator showing whether the task is on time or delayed.

__Example 1__ shows how the Deadline can be set.

```C#
	var task = new GanttTask()
	{
	    Start = new DateTime(2014, 6, 6),
	    End = new DateTime(2014, 6, 8),
	    Deadline = new DateTime(2014, 6, 9),
	    Title = "Gantt Rendering"
	};
```
```VB
	Dim task = New GanttTask() With { _
	    .Start = New DateTime(2014, 6, 6), _
	    .[End] = New DateTime(2014, 6, 8), _
	    .Deadline = New DateTime(2014, 6, 9), _
	    .Title = "Gantt Rendering" _
	}
```

When the __End__ time is before the set __Deadline__ of the Task, the Indicator is in green color, however, as soon as you expand the task after the __End__, the Indicator is replaced with one that has red color.

__Figure 1__ shows how the Deadline and the Indicator are visualized in the Timeline part of the control.

Figure 1: Deadline and Indicator![ganttview gantttaskdeadline 01](images/ganttview_gantttaskdeadline_01.png)

## Customization

There may be cases when you need to add different logic for marking tasks as expired. The default implementation is as soon as the __End__ goes after the __Deadline__, the task is marked as delayed.

In order to change this behavior, you will need to create a custom GanttTask and override its __CheckIsExpired__  method. __Example 2__ demonstrates how to override this method, so that the task is marked as expired only when its __Start__ property goes after the set __Deadline__:

__Example 2__ shows how to override CheckIsExpired method.

```C#
	public class CustomGanttTask : GanttTask
	{
	    protected override bool CheckIsExpired()
	    {
	        return this.Deadline < this.Start;
	    }
	}
```
```VB
	Public Class CustomGanttTask
	    Inherits GanttTask
	    Protected Overrides Function CheckIsExpired() As Boolean
	        Return Me.Deadline < Me.Start
	    End Function
	End Class
```

__Figure 2__ and __Figure 3__ show the result:

Figure 2: Even if the End is after the Deadline, the task is not marked as expired.

![ganttview gantttaskdeadline 02](images/ganttview_gantttaskdeadline_02.png)

Figure 3: As soon as the Start goes after the Deadline, the task is marked as delayed.

![ganttview gantttaskdeadline 03](images/ganttview_gantttaskdeadline_03.png)

## See Also

 * [Custom GanttTask]({%slug radganttview-features-items-custom-gantttask%})

