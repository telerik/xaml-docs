---
title: CheckBox Column
page_title: CheckBox Column
description: Find out how you can display a checkbox for each grid row using the CheckBox column in RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-checkbox-column
tags: checkbox,column
published: True
position: 3
---

# CheckBox Column

__GridViewCheckBoxColumn__ derives from __GridViewBoundColumnBase__ class and its content is represented by a __CheckBox__ for each row. The difference between it and __GridViewSelectColumn__ is that this one is meant to be bound. As opposed, __GridViewSelectColumn__ allows you to select the row through the CheckBox that it utilizes.

__Example 1: Declare a column of type GridViewCheckBoxColumn__

<snippet id='radgridview-columns-columntypes-checkbox-column-example_1_declare_a_column_of_type_gridviewcheckboxcolumn-xaml' />


#### __Figure 1: Declared CheckBox Column.__
![Telerik UI for {{ site.framework_name }} RadGridView GridViewCheckBoxColumn showing a bound checkbox in each row](images/RadGridView_Columns_CheckBoxColumn_01.png)

>tip Use this column for __better performance__ when you know that the underlying data is of __boolean type__.

__GridViewCheckBoxColumn__ provides a property that is not present in any other column: __AutoSelectOnEdit__. When set to __True__ the __CheckBox__ is automatically toggled on editing the cell thus decreasing the number of clicks you need to take to change the boolean value of the bound property. 

Here are the possible cases:

1. __Default__ (AutoSelectOnEdit="False", EditTriggers="Default") - three clicks are needed to change the value of the __CheckBox__ - two clicks to enter the edit mode and one click to toggle the __CheckBox__ state.

2. __AutoSelectOnEdit="True"__, __EditTriggers="Default"__ - two clicks are needed to change the value of the __CheckBox__ - the clicks to enter the edit mode.

3. __AutoSelectOnEdit="True"__, __EditTriggers="CellClick"__ - only one click is needed to change the value of the __CheckBox__. 

__Example 2: Change the value of the CheckBox with one click__

<snippet id='radgridview-columns-columntypes-checkbox-column-example_2_change_the_value_of_the_checkbox_with_one_click-xaml' />


> Since the __GridViewCheckBoxColumn__ is specially designed to dispay checkboxes, setting its __CellTemplate__, __CellEditTemplate__, __CellTemplateSelector__ and __CellEditTemplateSelector__ is not supported. For such requirements, you can use a [GridViewDataColumn]({%slug radgridview-columns-column-types-data-column%}). How to style the templates is [described here](https://docs.telerik.com/devtools/wpf/controls/radgridview/styles-and-templates/columns-styling-checkboxcolumn).

## See Also

 * [Clicks in GridViewCheckBoxColumn]({%slug gridview-checkbox-column-clicks%}) 

 * [Styling GridViewCheckBoxColumn]({%slug gridview-columns-styling-checkboxcolumn%})

 * [GridViewSelectColumn]({%slug radgridview-columns-column-types-select-column%})
