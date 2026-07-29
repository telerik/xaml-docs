---
title: Always focus the first cell on insert 
page_title: Always focus the first cell on insert 
description: Read this article showing how to always have the first column focused when a new item is about to be inserted in RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-how-to-focus-first-cell-insert
tags: always,focus,the,first,cell,on,insert,
published: True
position: 4
---

# Always focus the first cell on insert 

When you insert a new item (via the Insert key or the insert row) RadGridView will check which is your current column and focus that column in the newly added and probably blank row. This picture explains it better:

![Telerik UI for {{ site.framework_name }} RadGridView inserting a new row with focus initially placed in the current column instead of the first cell](images/how_to_focus_first_cell.png)

This article shows how to make always the first column be focused when a new item is about to be inserted. You need to subscribe to the __AddingNewDataItem__ event of the RadGridView and set the current column in its event handler:



<snippet id='radgridview-managing-data-how-to-focus-first-cell-insert-block_1-cs' />

<snippet id='radgridview-managing-data-how-to-focus-first-cell-insert-block_1-vb' />


Now, no matter which is the current column, when you insert a new item - the first cell will always get the focus. 


