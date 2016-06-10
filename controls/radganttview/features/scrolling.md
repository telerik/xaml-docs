---
title: Scrolling
page_title: Scrolling
description: Scrolling
slug: radganttview-scrolling
tags: scrolling, auto-scrolling
published: True
position: 5
---

# Scrolling

This topic explains how you could set up __RadGanttView__, so that the view is scrolled to a specified location. The location could be a particular GanttTask, DateTime inside the TimeRuler or even a column inside the Grid part.

Additionally, with the official R2 2016 release of UI for WPF __RadGanttView__ provides the option to customize its auto-scrolling functionality.

We will go through the following sections:

* [Scrolling methods](#scrolling-methods)

* [Customizing auto-scrolling functionality](#customizing-auto-scrolling-functionality)

## Scrolling methods

__RadGanttView__ scrolling functionality can be modified using its __ScrollingService__ property. This property is of type GanttScrollingService and provides multiple methods for scroll navigation:

* [ScrollIntoView (object param)](#scrollintoview-object-item)

* [ScrollIntoView (object item, ScrollSettings settings)](#scrollintoview-object-item-scrollsettings-settings)

* [ScrollToDateTime(DateTime dateTime)](#scrolltodatetimedatetime-datetime)

* [ScrollToColumn(int columnIndex) / ScrollToColumn(ColumnDefinitionBase columnDefinition)](#scrolltocolumnint-columnindex--scrolltocolumncolumndefinitionbase-columndefinition)

* [ScrollToRow(int rowIndex)] (#scrolltorowint-rowindex)

* [ScrollHorizontalTo (double offset, GanttScrollArea ganttArea)] (#scrollhorizontalto-double-offset-ganttscrollarea-ganttarea)

* [ScrollVerticalTo(double offset) / ScrollVerticalWith(double offset)] (#scrollverticaltodouble-offset--scrollverticalwithdouble-offset)

### ScrollIntoView (object item)

This method is used to scroll the view horizontally and vertically, so that a particular GanttTask is in the currently visible area. __Example 1__ shows how you can use ScrollIntoView method.

#### __[C#] Example 1: Calling ScrollIntoView method__

{{region radganttview-scrolling_0}}
	GanttView.ScrollingService.ScrollIntoView(task);
{{endregion}}

__Figure 1__ illustrates how the view is scrolled vertically and TimeRuler part - horizontally when the code from __Example 1__ is executed for “task 4”.

#### __Figure 1: GanttView before and after calling ScrollIntoView for “task 4"__

![](images/ganttview_scrolling_01.png)

### ScrollIntoView (object item, ScrollSettings settings)

ScrollIntoView method has an overload with an additional parameter of type __ScrollSettings__.

__ScrollSettings__ object helps configure the scrollbars alignment through its HorizontalScrollPosition and VericalScrollPosition properties when navigating to a certain task. Sometimes, exact alignment is not possible, in that case, the view is scrolled to a position nearest to the required.

>ScrollPosition properties of the ScrollSettings are of enum type and can receive the following values:
>
>HorizontalScrollPosition – Left, Center, Right, Anywhere, None;
>VerticalScrollPosition – Top, Center, Bottom, Anywhere, None.

__Example 2__ demonstrates how ScrollIntoView could be used with ScrollSettings applied for “task 4”.

#### __[C#] Example 2: Calling ScrollIntoView method with ScrollSettings__

{{region radganttview-scrolling_1}}
	var settings = new ScrollSettings() { HorizontalScrollPosition = HorizontalScrollPosition.Right, VerticalScrollPosition = VerticalScrollPosition. Anywhere};
	GanttView.ScrollingService.ScrollIntoView(task4, settings);
{{endregion}}

__Figure 2__ shows the result.

#### __Figure 2: GanttView before and after calling ScrollIntoView for “task 4” with ScrollingSettings applied__

![](images/ganttview_scrolling_02.png)

### ScrollToDateTime(DateTime dateTime)

This method is used to scroll horizontally the TimeRuler part, so that a specific time from the current VisibleRange is inside the visible area. __Example 3__ shows how it could be used in order to move the TimeRuler with 3 days, for example.

#### __[C#] Example 3: Calling ScrollToDateTime method__

{{region radganttview-scrolling_2}}
	GanttView.ScrollingService.ScrollToDateTime(DateTime.Today.AddDays(3));
{{endregion}}

You could see the result in __Figure 3__.

#### __Figure 3: GanttView before and after calling ScrollToDateTime method__

![](images/ganttview_scrolling_03.png)

### ScrollToColumn(int columnIndex) / ScrollToColumn(ColumnDefinitionBase columnDefinition)

Both methods are used to scroll the Grid part of RadGanttView horizontally, so that a specific column is visible. __Example 4__ demonstrates how ScrollToColumn could be used to scroll to the third column inside the Grid.

#### __[C#] Example 4: Calling ScrollToColumn method__

{{region radganttview-scrolling_3}}
	GanttView.ScrollingService.ScrollToColumn(2);
{{endregion}}

#### __Figure 4: GanttView before and after calling ScrollToColumn method__

![](images/ganttview_scrolling_04.png)

### ScrollToRow(int rowIndex)

Used to scroll the view vertically, so that the specified Row is visible. __Example 5__ illustrates how to scroll to the third row.

#### __[C#] Example 5: Calling ScrollToRow method__

{{region radganttview-scrolling_4}}
	GanttView.ScrollingService.ScrollToRow(2);
{{endregion}}

#### __Figure 5: GanttView before and after calling ScrollToRow method__

![](images/ganttview_scrolling_05.png)

### ScrollHorizontalTo (double offset, GanttScrollArea ganttArea)

This method is used to scroll either Grid or TimeLine area (set as a second parameter) horizontally with specified offset (in pixels). __Example 6__ demonstrates how you could scroll the TimeLine area with 100px offset.

#### __[C#] Example 6: Calling ScrollHorizontalTo method__

{{region radganttview-scrolling_5}}
	GanttView.ScrollingService.ScrollHorizontalTo(100, GanttScrollArea.TimeLineArea);
{{endregion}}

#### __Figure 6: GanttView before and after calling ScrollHorizontalTo method__

![](images/ganttview_scrolling_06.png)

### ScrollVerticalTo(double offset) / ScrollVerticalWith(double offset)

Both methods are used to scroll vertically the view with the specified offset (in pixels). ScrollVerticalTo scrolls from the initial Scroll position, while ScrollVerticalWith scrolls from the current Scroll position. __Example 7__ shows how you could scroll the view with 50px offset from the initial scroll position.

#### __[C#] Example 7: Calling ScrollVerticalTo method__

{{region radganttview-scrolling_6}}
	GanttView.ScrollingService.ScrollVerticalTo(50);
{{endregion}}

#### __Figure 7: GanttView before and after calling ScrollVerticalTo method__

![](images/ganttview_scrolling_07.png)

## Customizing auto-scrolling functionality

By default, when a GanttTask is selected inside the Grid part of the GanttView, the TimeRuler part is auto-scrolled to bring the representation of the Task into view. You could customize this behavior by setting the __ScrollSettings__ of the __ScrollingService__ as shown in __Example 8__.

#### __[C#] Example 8: Setting ScrollSettings__

{{region radganttview-scrolling_7}}
	GanttView.ScrollingService.ScrollSettings.HorizontalScrollPosition = HorizontalScrollPosition.Right;
	GanttView.ScrollingService.ScrollSettings.VerticalScrollPosition = VerticalScrollPosition.Anywhere;
{{endregion}}

__Figure 8__ shows the result when selecting “task 4”.

#### __Figure 8: Default and customized auto-scrolling behavior__ 

![](images/ganttview_scrolling_08.png)

>tip In order to disable the auto-scrolling behavior, you will need to set HorizontalSrollPosition and VerticalScrollPosition properties of the ScrollSettings to “None” as shown in __Example 9__.

#### __[C#] Example 9: Disable auto-scrolling__

{{region radganttview-scrolling_8}}
	GanttView.ScrollingService.ScrollSettings.HorizontalScrollPosition = HorizontalScrollPosition.None;
	GanttView.ScrollingService.ScrollSettings.VerticalScrollPosition = VerticalScrollPosition.None;
{{endregion}}

