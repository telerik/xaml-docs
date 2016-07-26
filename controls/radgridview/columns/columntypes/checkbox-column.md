---
title: CheckBox Column
page_title: CheckBox Column
description: CheckBox Column
slug: gridview-checkbox-column
tags: checkbox,column
published: True
position: 3
---

# CheckBox Column

__GridViewCheckBoxColumn__ derives from __GridViewBoundColumnBase__ class and its content is represented by a CheckBox for each row. The difference between it and __GridViewSelectColumn__ is that this one is meant to bind to data. As opposed, __GridViewSelectColumn__ allows you to select the row via the CheckBox in it.

#### __[XAML] Example 1: Declare a column of type GridViewCheckBoxColumn.__

{{region xaml-gridview-checkbox-column_0}}

	<telerik:RadGridView x:Name="radGridView"
	                        AutoGenerateColumns="False">
	   <telerik:RadGridView.Columns>
	       <telerik:GridViewCheckBoxColumn DataMemberBinding="{Binding IsActive}" />
	   </telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}


>tipUse this column for __better performance__ when you know that the underlying data is of a __boolean type__.

One property existing only in this type of column is __AutoSelectOnEdit__ - when set to True the CheckBox is automatically toggled on editing the cell thus decreasing the number of clicks you need to take to change the boolean value. 
Here are the possible cases:

1. __Default__ (AutoSelectOnEdit="False", EditTriggers="Default") - three clicks are needed to change the value of the checkbox - two clicks to enter the edit mode and one click to toggle the checkbox state.

2. __AutoSelectOnEdit="True"__, __EditTriggers="Default"__ - two clicks are needed to change the value of the checkbox - the clicks to enter the edit mode.

3. __AutoSelectOnEdit="True"__, __EditTriggers="CellClick"__ - only one click is needed to change the value of the checkbox. 

# See Also

 * [Clicks in GridViewCheckBoxColumn]({%slug gridview-checkbox-column-clicks%}) 

 * [Styling GridViewCheckBoxColumn]({%slug gridview-columns-styling-checkboxcolumn%})

 * [GridViewSelectColumn]({%slug radgridview-columns-column-types-select-column%})
