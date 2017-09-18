---
title: Scrolling
page_title: Scrolling
description: Scrolling
slug: virtualgrid-scrolling
tags: scrolling
published: True
position: 4
---

# Scrolling

__RadVirtualGrid__ exposes a scrolling mechanism which can be utilized through the following methods. As they are processed asynchronously, the scrollFinishedCallback and scrollFailedCallback callbacks can be used when certain actions are required once the scrolling has finished or failed.

* __ScrollIndexIntoViewAsync(int rowIndex, int columnIndex, Action scrollFinishedCallback, Action scrollFailedCallback)__

#### __[C#] Example 1: Calling the ScrollIndexIntoViewAsync method__

{{region radvirtualgrid-features_scrolling_0}}
	 this.VirtualGrid.ScrollIndexIntoViewAsync(40, 20,
            new Action(() =>
            {
                MessageBox.Show("Finished!");
            }),
            new Action(() =>
            {
                MessageBox.Show("Failed!");
            }));
{{endregion}}

* __ScrollRowIndexIntoViewAsync(int rowIndex, Action scrollFinishedCallback, Action scrollFailedCallback)__

#### __[C#] Example 2: Calling the ScrollRowIndexIntoViewAsync method__

{{region radvirtualgrid-features_scrolling_1}}
	this.VirtualGrid.ScrollRowIndexIntoViewAsync(40,
                new Action(() =>
                {
                    MessageBox.Show("Finished!");
                }),
            new Action(() =>
            {
                MessageBox.Show("Failed!");
            }));
{{endregion}}

* __ScrollColumnIndexIntoViewAsync(int columnIndex, Action scrollFinishedCallback, Action scrollFailedCallback)__

#### __[C#] Example 2: Calling the ScrollColumnIndexIntoViewAsync method__

{{region radvirtualgrid-features_scrolling_2}}
	this.VirtualGrid.ScrollColumnIndexIntoViewAsync(40,
                new Action(() =>
                {
                    MessageBox.Show("Finished!");
                }),
            new Action(() =>
            {
                MessageBox.Show("Failed!");
            }));
{{endregion}}

## See Also 

* [Editing]({%slug virtualgrid-editing%})

* [Insert and Remove Data]({%slug virtualgrid-insert-data-and-remove-data%})