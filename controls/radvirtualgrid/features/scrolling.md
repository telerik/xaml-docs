---
title: Scrolling
page_title: Scrolling
description: Check our &quot;Scrolling&quot; documentation article for the RadVirtualGrid {{ site.framework_name }} control.
slug: virtualgrid-scrolling
tags: scrolling
published: True
position: 4
---

# Scrolling

__RadVirtualGrid__ exposes a scrolling mechanism which can be utilized through the following methods. As they are processed asynchronously, the scrollFinishedCallback and scrollFailedCallback callbacks can be used when certain actions are required once the scrolling has finished or failed.

* __ScrollIndexIntoViewAsync(int rowIndex, int columnIndex, Action scrollFinishedCallback, Action scrollFailedCallback)__

__Example 1: Calling the ScrollIndexIntoViewAsync method__

```C#
	 this.VirtualGrid.ScrollIndexIntoViewAsync(40, 20,
            new Action(() =>
            {
                MessageBox.Show("Finished!");
            }),
            new Action(() =>
            {
                MessageBox.Show("Failed!");
            }));
```

* __ScrollRowIndexIntoViewAsync(int rowIndex, Action scrollFinishedCallback, Action scrollFailedCallback)__

__Example 2: Calling the ScrollRowIndexIntoViewAsync method__

```C#
	this.VirtualGrid.ScrollRowIndexIntoViewAsync(40,
                new Action(() =>
                {
                    MessageBox.Show("Finished!");
                }),
            new Action(() =>
            {
                MessageBox.Show("Failed!");
            }));
```

* __ScrollColumnIndexIntoViewAsync(int columnIndex, Action scrollFinishedCallback, Action scrollFailedCallback)__

__Example 2: Calling the ScrollColumnIndexIntoViewAsync method__

```C#
	this.VirtualGrid.ScrollColumnIndexIntoViewAsync(40,
                new Action(() =>
                {
                    MessageBox.Show("Finished!");
                }),
            new Action(() =>
            {
                MessageBox.Show("Failed!");
            }));
```

## See Also 

* [Editing]({%slug virtualgrid-editing%})

* [Insert and Remove Data]({%slug virtualgrid-insert-data-and-remove-data%})