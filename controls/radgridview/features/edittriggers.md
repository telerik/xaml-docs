---
title: Editing Start Triggers
page_title: Editing Start Triggers - GridView
description: RadGridView supports a set of few different triggers that start the cell editing, like mouse click, typing, F2 key press and more.
slug: gridview-edittriggers
tags: edittriggers,triggers,editing,f2
published: True
position: 16
---

# Editing Start Triggers

RadGridView supports few different gestures that trigger the cell edit action. The default gestures are clicking on the current cell, pressing F2 on the keyboard, and starting typing when the current cell is focused.

The edit start actions are defined with the `GridViewEditTriggers` enum that is assigned to the `EditTriggers` property of the GridView or the column objects. The enum provides the following set of values:

* `Default`&mdash;The default setting which combines the `CurrentCellClick`, `F2` and `TextInput` values.

* `CellClick`&mdash;A single click will put the cell into edit mode.

* `CurrentCellClick`&mdash;A click on the current cell will put it into edit mode.

* `F2`&mdash;Pressing F2 on a cell will put it into edit mode.

* `None`&mdash;No action will put the cell in edit mode.

* `TextInput`&mdash;Any text input will put the current cell into edit mode.

To change the edit triggers for all cells in the `RadGridView` instance, set its `EditTriggers` property.

__Setting RadGridView EditTriggers property__
<snippet id='radgridview-features-edittriggers-setting_radgridview_edittriggers_property-xaml' />


To change the edit triggers per column, set the `EditTriggers` property of the associated [GridViewColumn]({%slug radgridview-columns-column-types-boundcolumnbase%}) object.

__Setting GridViewColumn EditTriggers property__
<snippet id='radgridview-features-edittriggers-setting_gridviewcolumn_edittriggers_property-xaml' />


The `GridViewEditTriggers` is a flag enum which means that you can combine multiple values, thus allowing multiple triggers.

__Setting the EditTriggers property to multiple values in XAML__
<snippet id='radgridview-features-edittriggers-setting_the_edittriggers_property_to_multiple_values_in_xaml-xaml' />


__Setting the EditTriggers property to multiple values in code__
<snippet id='radgridview-features-edittriggers-setting_the_edittriggers_property_to_multiple_values_in_code-cs' />


To disable the editing, set the `EditTriggers` property to `None`.

__Disabling editing by using the UI__
<snippet id='radgridview-features-edittriggers-disabling_editing_by_using_the_ui-xaml' />

