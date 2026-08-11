---
title: Insert New Row on Tab of Last Cell
page_title: Insert New Row on Tab of Last Cell
description: Check out our example of how to insert a new row when you are at the last column of the last row in RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-add-new-row-on-tab-last-cell
tags: insert,new,row,tab,last,cell,column,row
published: True
position: 14
---

# Insert New Row on Tab of Last Cell

This article will show you how to insert a new row when you are at the **last column** of the **last row** and press the **Tab** key.

In order to achieve the desired behavior, you should create a [custom KeyboardCommandProvider]({%slug gridview-commands-keyboardcommandprovider%}) and override its **ProvideCommandsForKey** method.

**Example 1** shows how this can be done:

__Example 1: Handling the Tab key__

<snippet id='radgridview-how-to-add-new-row-on-tab-last-cell-example_1_handling_the_tab_key-cs' />

<snippet id='radgridview-how-to-add-new-row-on-tab-last-cell-example_1_handling_the_tab_key-vb' />


## See Also

* [Custom KeyboardCommandProvider]({%slug gridview-commands-keyboardcommandprovider%})
