---
title: Selection
page_title: Selection
description: Check our &quot;Selection&quot; documentation article for the RadTaskBoard {{ site.framework_name }} control.
slug: radtaskboard-features-selection
tags: selection
published: True
position: 2
---

# Selection

RadTaskBoard provides you with selection functionality, which allows the user to select an item from the data displayed in the columns. 

Users can select an item through the control's UI by clicking somewhere on a given task.

#### Figure 1: RadTaskBoard Selection
![Telerik TaskBoard Selection 0](images/taskboard_selected_task_0.png)

## Disabling Selection

To disable the selection functionality you can set the __CanUserSelect__ property to **False**.

>This will disable the selection only for the end-user. It will still be possible to manipulate the selection programmatically.
          
__Example 1: Set the CanUserSelect property in XAML__

<snippet id='radtaskboard-features-selection-block_1-xaml' />

__Example 1: Set the CanUserSelect property in code-behind__

<snippet id='radtaskboard-features-selection-block_2-cs' />
<snippet id='radtaskboard-features-selection-block_3-vb' />

## Events

The control exposes a __SelectionChanged__ which is fired each time an item has been selected.

__Example 2: Subscribing to the SelectionChanged event__

<snippet id='radtaskboard-features-selection-block_4-cs' />
<snippet id='radtaskboard-features-selection-block_5-vb' />
