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

RadGridView supports few differen gestures that trigger the cell edit action. The default gestures are click on the current cell, press F2 on the keyboard and start typining when the current cell is focused.

The edit start actions are defined with the `GridViewEditTriggers` enum that is assigned to the `EditTriggers` property of the GridView or the column objects The enum provides the following set of values:

* `Default`&mdash;The default setting which combines the `CurrentCellClick`, `F2` and `TextInput` values.

* `CellClick`&mdash;A single click will put the cell into edit mode.

* `CurrentCellClick`&mdash;A click on the current cell will put it into edit mode.

* `F2`&mdash;Pressing F2 on a cell will put it into edit mode.

* `None`&mdash;No action will put the cell in edit mode.

* `TextInput`&mdash;Any text input will put the current cell into edit mode.

To change the edit triggers for all cells in the `RadGridView` instance, set its `EditTriggers` property.

#### __[XAML] Setting RadGridView EditTriggers property__
{{region gridview-edittriggers-0}}
	<telerik:RadGridView EditTriggers="F2"/>
{{endregion}}

To change the edit triggers per column, set the `EditTriggers` property of the associated [GridViewColumn]({%slug radgridview-columns-column-types-boundcolumnbase%}) object.

#### __[XAML] Setting GridViewColumn EditTriggers property__
{{region gridview-edittriggers-1}}
	<telerik:RadGridView.Columns>
		<telerik:GridViewDataColumn EditTriggers="F2" />
	</telerik:RadGridView.Columns>
{{endregion}}

The `GridViewEditTriggers` is a flag enum which means that you can combine multiple values, thus allowing multiple triggers.

#### __[XAML] Setting the EditTriggers property to multiple values in XAML__
{{region gridview-edittriggers-2}}
	<telerik:RadGridView.Columns>
		<telerik:GridViewDataColumn EditTriggers="CurrentCellClick,F2,TextInput" />
	</telerik:RadGridView.Columns>
{{endregion}}

#### __[C#] Setting the EditTriggers property to multiple values in code__
{{region gridview-edittriggers-3}}
	this.gridView.EditTriggers = GridViewEditTriggers.CellClick | GridViewEditTriggers.F2;
{{endregion}}

To disable the editing, set the `EditTriggers` property to `None`.

#### __[XAML] Disabling editing by using the UI__
{{region gridview-edittriggers-4}}
	<telerik:RadGridView EditTriggers="None"/>	
{{endregion}}