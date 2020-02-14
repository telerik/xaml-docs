---
title: TaskBoardColumnDragDropBehavior
page_title: TaskBoardColumnDragDropBehavior
description: Check our &quot;TaskBoardColumnDragDropBehavior&quot; documentation article for the RadTaskBoard WPF control.
slug: radtaskborad-features-taskboardcolumndragdropbehavior
tags: reordering,the,task,drag-drop
published: True
position: 4
---

# TaskBoardColumnDragDropBehavior

The TaskBoardColumnDragDropBehavior provides drag-drop capabilities for standard RadTaskBoard control. It automatically recognizes its host control item Type and automatically adds the dragged items that are of this type. In some cases, the __TaskBoardColumnDragDropBehavior__ will be unable to recognize its host’s item Type correctly. The ItemType property is provided for such cases.

> The TaskBoardColumnDragDropBehavior is located in the following namespace: __xmlns:drag="clr-namespace:Telerik.Windows.Controls.TaskBoard;assembly=Telerik.Windows.Controls"__

#### __[C#] Example 1: Specified the typed of the dragged item__
	{{region xaml-radtaskborad-features-reordering-items_0}}
		<telerik:RadTaskBoard x:Name="taskBoard">
			<telerik:RadTaskBoard.DragDropBehavior>
				<dragBehavior:TaskBoardColumnDragDropBehavior ItemType="{x:Type local:CustomTask}"/>
			</telerik:RadTaskBoard.DragDropBehavior>   
		</telerik:RadTaskBoard>		
	{{endregion}}

The most important methods of __TaskBoardColumnDragDropBehavior__ are:

* __CanStartDrag:__ This method is called in the context of the drag source control, just before the drag operation is started. If you return false the drag operation will not start.

* __CanDrop:__ This method is called in the context of the drop target control on each mouse move event and before the call to the Drop method. If you return false the drop will not be allowed and the mouse cursor will change accordingly.

* __Drop:__ This method is called in the context of the drop target control when the mouse button is released, but only if the previous CanDrop call returned true. It is useful when you want to perform additional actions when the drop operation is complete.

* __DragDropCompleted:__ This method is called in the context of the drag source control when the mouse button is released, but only when the previous CanDrop call returned true. It is useful when you want to perform additional actions when the drag is complete. In case the drag source and the drop target are the same control, this method is called after the call to Drop.

* __DragDropCanceled:__ This method is called in the context of the drag source control when the mouse button is released, but only when the previous CanDrop call returned false.

## TaskBoardColumnDragDropState

The context for each of the TaskBoardColumnDragDropBehavior __CanDrop, Drop, DragDropCanceled, DragDropCompleted, GetDragDropEffects, IsMovingItems__ methods is provided in the form of a TaskBoardColumnDragDropState object. It contains references to the target column, source control’s ItemsSource, destination control’s ItemsSource and the dragged items. 

>In a scenario, when the default TaskBoardColumnDragDropBehavior behavior need to be customized, you need to cast the __DragDropState state__ parameter to __TaskBoardColumnDragDropState__ object so you can get access to the __TargetColumn__.

#### __[C#] Example 2: Disable Reordering of the Items__
	{{region csharp-radtaskborad-features-reordering-items_1}}
		public class CustomDragDropBehavior : TaskBoardColumnDragDropBehavior
		{
			public override bool CanDrop(DragDropState state)
			{
				var taskBoardColumnDragDropState = state as TaskBoardColumnDragDropState;
				if(taskBoardColumnDragDropState.TargetColumn.Header.ToString() == "Done")
				{
					return false;
				}
				return base.CanDrop(state);
			}
		}
	{{endregion}}

## Cancel Drag Operation 

To cancel the dragging of specific items you can modify the TaskBoardColumnDragDropBehavior functionality. You can create custom class that derives from TaskBoardColumnDragDropBehavior class and override the __CanStartDrag()__ method. In this method the __state parameter is not__ TaskBoardColumnDragDropState. To get the dragged items you can use the __DraggedItems__ collection property. Then depending on your condition, you can return false if this item is not allowed to be moved anymore. __Example 2__ demonstrates how we can forbid the user from dragging items from a particular column.

#### __[C#] Example 3: Disable dragging from a TaskBoardColumn__
	{{region csharp-radtaskborad-features-reordering-items_2}}
		public class CustomDragDropBehavior : TaskBoardColumnDragDropBehavior
		{         
			public override bool CanStartDrag(DragDropState state)
			{
				var draggedItem = (state.DraggedItems as List<object>)[0] as TaskBoardCardModel;
				if (draggedItem.State == "Done")
				{
					return false;
				}
				return base.CanStartDrag(state);
			}
		}
	{{endregion}}

## See Also
 * [Getting Started]({%slug radtaskboard-getting-started%})
 * [Binding to TaskBoardCardModel]({%slug radtaskboard-populating-with-data-binding-taskboardcardmodel%})
 * [Binding to CollectionViewSource]({%slug radtaskboard-populating-with-data-data-binding-to-collectionviewsource%})
