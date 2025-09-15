---
title: Reordering the Items
page_title: Reordering the Items
description: Check our &quot;Reordering the Items&quot; documentation article for the RadTaskBoard {{ site.framework_name }} control.
slug: radtaskborad-features-reordering-items
tags: reordering,the,task,drag-drop
published: True
position: 3
---

# Reordering the Items

You can move one item to a different group by using the built-in drag-drop functionality. The reordering of the items is enabled by default. To disable it you can set the __IsDragDropEnabled__ property of the __RadTaskBoard__ to false.

__Example 1: Disable Reordering of the Items__
	```XAML
	   <telerik:RadTaskBoard x:Name="taskBoard" GroupMemberPath="State" IsDragDropEnabled="False" />
	```
	
## Drag Visual Providers

The __DragVisualProvider__ enriches the drag-drop functionality of __RadTaskBoard__ control by providing a different visual DragCue to the dragged item. The DragVisualProvider can be set to:

__Example 2: Set DragVisualProvider__
	```XAML
	   <telerik:RadTaskBoard x:Name="taskBoard" GroupMemberPath="State" ItemsSource="{Binding Data}">
			<telerik:RadTaskBoard.DragVisualProvider>
				<telerik:ScreenshotDragVisualProvider />
			</telerik:RadTaskBoard.DragVisualProvider>
	   </telerik:RadTaskBoard>
	```

* __ScreenshotDragVisualProvider__: Provides the exact visual representation of the dragged item. This provider is set by default to the __DragVisualProvider__ property.

![radtaskborad features dragdrop 1](images/taskboard-screenshot-drag-visual.PNG)

* __EmptyDragVisualProvider__: This provider doesn't provide any visual representation of the dragged item.

![radtaskborad features dragdrop 2](images/taskboard-empty-drag-visual.PNG)

* __DefaultDragVisualProvider__: Provides the string representation of the dragged item.

![radtaskborad features dragdrop 3](images/taskboard-defaultstring-drag-visual.PNG)

## See Also
 * [Getting Started]({%slug radtaskboard-getting-started%})
 * [Binding to TaskBoardCardModel]({%slug radtaskboard-populating-with-data-binding-taskboardcardmodel%})
 * [Binding to CollectionViewSource]({%slug radtaskboard-populating-with-data-data-binding-to-collectionviewsource%})

