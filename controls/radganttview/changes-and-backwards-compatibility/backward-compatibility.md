---
title: Backwards Compatibility
page_title: Backwards Compatibility
description: Backwards Compatibility
slug: radganttview-backward-compatibility
tags: backwards,compatibility
published: True
position: 1
---

# Backwards Compatibility

This article lists the breaking changes of the control.

## Q3 2013

__Changed__

* In the __Telerik.Windows.Controls.Scheduling.ZIndexManager__ class the __GetZIndex__ has been changed.

__What to do now:__

This method was returning wrong Framework element type. It is now fixed and returns the correct Integer type. __No changes are required.__

## Q3 2012

### Common Changes

__Changed__

* Now the tree with the tasks' titles is not shown by default.  

__What to do now:__

To show the tree with tasks' titles in the GanttView control, you need to define a column of type __TreeColumnDefinition__ with MemberBinding set to {Binding Title}. You can specify whether this column is Frozen or not, editable or not and to set CellTemplate/CellEditTemplate as well as CellHighlightTemplate and CellSelectionTemplate.

### Theme Changes

* The ControlTemplate of the GanttItemsPresenter is now changed:

	* it doesn’t contain TreeRenderingPanel to display the Tree structure;

	* it doesn’t have ScrollContentPresenters for each area (and the ScrollContentPresenter class is deleted);

	* the root panel is now GanttPresenterPanel instead of Grid.

* The styles of the GanttGroupHeaderContainer are not in use anymore. To style the Tree elements you should use the TreeCellContainer or SimpleTreeCellContainer classes.

* The GanttViewSplitter is deleted and replaced with the GanttPresenterSplitter control.

* The GanttDragVisualCue is changed to GanttDragResizeVisualCue.

*   Changed the GanttDragResizeVisualCue's Datacontext to bind to:  

	* TargetItem.Title instead of Task.Title;

	* DestinationSlot.Start instead of Start;

	* DestinationSlot.End instead of End.

* EventProxy's (the DataContext of the EventContainer) Subject property is renamed to Title.

### Clean-up

All classes, properties and methods which are not intended to be used outside of the GanttView control are made internal/private.

Some classes and properties are renamed in order to have consistent and self-documenting API.

The following table lists the changed properties and methods:

Before	|	Now
---	|	---
<b>RadGanttView class<b/>	|	
GanttDragDropBehavior DragDropBehavior	|	ISchedulingDragDropBehavior DragDropBehavior
GanttResizeBehavior ResizeBehavior	|	ISchedulingResizeBehavior ResizeBehavior
IEnumerable TasksSource	|	IEnumerable TasksSource
	|	
<b>ColumnDefinition class<b/>	|	
RelationType Type	|	DependencyType Type
	|	
<b>Scheduling<b/>	|	
SchedulingDragDropBehavior DragDropBehavior	|	ISchedulingDragDropBehavior DragDropBehavior
SchedulingResizeBehavior ResizeBehavior	|	ISchedulingResizeBehavior ResizeBehavior
	|	
<b>Rendering<b/>	|	
TimeRulerContainerGenerator	|	DefaultTimeRulerContainerSelector
TimeLineContainerGenerator	|	DefaultTimeLineContainerSelector

## Q2 2012

* __Relations__ property of the __GanttTask__ / __IGanttTask__ is removed and __Dependencies__ property is added instead.

	The Relation class is changed and used for other purposes. A Dependency class is added which defines the relation in the opposite manner. For example if you have two tasks – A and B, in the old implementation A.Relations.Add(new Relation { Task = B }) means A -> B (or B depends on A) and in the new one its equivalent is B.Dependencies.Add(new Dependency { FromTask = A }) (or B depends on A).

	You can check [here]({%slug radganttview-features-items-relations%}) for more details about setting a relation between the tasks.

* __RadGanttView.SelectionBehavior__ property is not public anymore – it is protected.

* __IGanttTask__ and __GanttTask__ APIs changes:

	* GanttTask class now has Children and Dependencies properties of type IList and IList which are not settable, and support adding/removing items; the non-generic collections Children and Dependencies are implemented explicitly;

	* IGanttTask is changed – the GetSubItems method is removed, the Children property (as part of the IHierarchical interface) and the Depndencies properties are added;

		An example how to add children to a task can be found [here]({%slug radganttview-features-items-addremove%}).