---
title: Stop Showing the Unfocused State
page_title: Stop Showing the Unfocused State
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to stop showing the unfocused state for the selected row.
slug: gridview-selection-unfocused-state
tags: stop,showing,the,unfocused,state
published: True
position: 1
---

# Stop Showing the Unfocused State

When the `RadGridView` and `RadTreeListView` controls lost the focus, their selected visual items (`GridViewRow` and `TreeListViewRow`) enter an __unfocused__ state which tones down their color (usually the color is changed to light gray). This makes it more clear that the control doesn't have the focus.

![Telerik UI for {{ site.framework_name }} RadGridView showing the unfocused visual state for a selected row](images/RadGridView_Selection_UnfocusedState_01.PNG)

To disable this and keep the selection color that is displayed when the control is focused, set the `EnableLostFocusSelectedState` property to `False`.


<snippet id='radgridview-selection-how-to-unfocused-state-block_1-xaml' />


![Telerik UI for {{ site.framework_name }} RadGridView keeping the focused selection color after the control loses focus](images/RadGridView_Selection_UnfocusedState_02.PNG)
