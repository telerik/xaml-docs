---
title: Customizing Drag Drop Behavior
page_title: Customizing Drag Drop Behavior
description: Check our &quot;Customizing Drag Drop Behavior&quot; documentation article for the RadFileDialogs {{ site.framework_name }} control.
slug: radfiledialogs-features-dragdrop-customizing-drag-drop-behavior
tags: features,dragdropbehavior,custom
published: True
position: 1
---

# Customizing Drag Drop Behavior

The drag and drop functionality of the file browser is implemented via a [DragDropBehavior]({%slug dragdropmanager-behaviors-dragdropbehavior%}). The default behavior is a class of type __FileBrowserDragDropBehavior__ and can be accessed or replaced through the __DragDropBehavior__ property of the dialog control.

To customize the behavior, you can create a new class that derives from FileBrowserDragDropBehavior and override its virtual methods. 

The following example will show you how to create a behavior that allows you to drag files only, but not folders. To do so you will need to override the CanDragStart method of the behavior and based on the information received from the __DragDropState__ class return true or false.

__Example 1: Custom drag drop behavior__ 
```C#
	public class CustomFileBrowserDragDropBehavior : FileBrowserDragDropBehavior
	{
		public override bool CanStartDrag(DragDropState state)
		{
			// Here we implement the custom logic that checks if the dragged item is a file or a folder.
			string draggedFilePath = state.DraggedFiles.FirstOrDefault();
			FileAttributes fileAttributes = File.GetAttributes(draggedFilePath);
			if ((fileAttributes & FileAttributes.Directory) == FileAttributes.Directory)
			{
				return false;
			}
			else
			{
				return base.CanStartDrag(state);
			}
		}
	}
```

__Example 2: Setting the custom behavior__
```C#
	RadOpenFileDialog openFileDialog = new RadOpenFileDialog();
	openFileDialog.Owner = theOwnerWindow;
	openFileDialog.DragDropBehavior = new CustomFileBrowserDragDropBehavior();	
	openFileDialog.ShowDialog();
```

> This example was designed for the scenario where you can drag/drop only a single item. For multiple selection you will need to extend the example.

## See Also  
* [Getting Started]({%slug radfiledialogs-getting-started%})
* [Drag Drop Overview]({%slug radfiledialogs-features-dragdrop-overview%})
