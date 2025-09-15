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

```XAML
	<telerik:RadTaskBoard x:Name="radTaskBoard" CanUserSelect="False" />	
```

__Example 1: Set the CanUserSelect property in code-behind__

```C#
	this.radTaskBoard.CanUserSelect = false;
```
```VB.NET
	Me.radTaskBoard.CanUserSelect = False
```

## Events

The control exposes a __SelectionChanged__ which is fired each time an item has been selected.

__Example 2: Subscribing to the SelectionChanged event__

```C#
	private void SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		var selectedItem = e.AddedItems[0];
	}
```
```VB.NET
	Private Sub SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
		Dim selectedItem = e.AddedItems(0)
	End Sub
```

