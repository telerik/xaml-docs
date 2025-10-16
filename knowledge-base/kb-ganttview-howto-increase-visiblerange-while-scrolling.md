---
title: How to Have Infinite Horizontal Scrolling
description: How to increase VisibleRange while scrolling the TimeRuler part.
type: how-to
page_title: Add to the VisibleRange While Scrolling
slug: kb-ganttview-howto-increase-visiblerange-while-scrolling
position: 0
tags: ganttview, infinite, scrolling, timeruler, horizontal
ticketid: 1426000
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product</td>
			<td>RadGanttView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to achieve infinite horizontal scrolling in the TimeRuler part. 

## Solution

Handle the __Loaded__ event of the RadGanttView and obtain a reference to the ScrollBar in the EventsPanel inside the RadGanttView. Then you can handle its __Scroll__ event and increase the __VisibleRange__ of the RadGanttView, if the __Value__ of the ScrollBar is approaching the __ExtentWidth__ of the EventsPanel. 


```C#
	private LogicalCanvasPanel eventsPanel;

    private void RadGanttView_Loaded(object sender, RoutedEventArgs e)
    {
        var ganttView = sender as RadGanttView;
        this.eventsPanel = ganttView.ChildrenOfType<LogicalCanvasPanel>().First(p => p.Name == "EventsPanel");
        var eventsPanelScrollbar = ganttView.ChildrenOfType<ScrollBar>().Skip(1).FirstOrDefault();

        eventsPanelScrollbar.Scroll += Scrollbar_Scroll;
    }

    private void Scrollbar_Scroll(object sender, ScrollEventArgs e)
    {
        var scrollBar = sender as ScrollBar;

        if (scrollBar.Value + 100 > this.eventsPanel.ExtentWidth)
        {
            var currentVisibleRange = this.ganttView.VisibleRange;
            this.ganttView.VisibleRange = new DateRange(currentVisibleRange.Start, currentVisibleRange.End.AddDays(50));
        }
    }
```

## See also

* [ChildreOfTypeExtensions]({%slug common-visual-tree-helpers%}#childrenoftypeextensions)
