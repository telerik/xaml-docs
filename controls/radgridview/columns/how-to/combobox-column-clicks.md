---
title: Number of Clicks to Open ComboBox in GridViewComboBoxColumn
page_title: Number of Clicks to Open ComboBox in GridViewComboBoxColumn
description: Check out how you can control the number of clicks needed to change the value of the ComboBox Column within RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-combobox-column-clicks
tags: number,of,clicks,in,combobox,column
published: True
position: 3
---

# Number of Clicks in the ComboBox Column

If you have a __GridViewComboBoxColumn__ in your RadGridView, then by default, you need to click three times to show the dropdown - the first click selects the current cell, the second enters edit mode and the last one opens the dropdown.

The following solutions allow you to control the number of clicks needed to change the value of the combobox column.

## 2 Clicks Solution

By configuring __EditTriggers="CellClick"__ property of GridViewComboBoxColumn the cells will enter edit mode with a single click only. Now you will need one more click to show the drop-down and select a value.

## 1 Click Solution

In addition to configuring the __EditTriggers__ property, you can set __OpenDropDownOnFocus__ property of the RadComboBox editor. 

This could be done in __XAML__ by applying a Style targeting the RadComboBox element as an **EditorStyle** of the column. **Example 1** demonstrates how this can be done.

__Example 1: Setting the OpenDropDownOnFocus through the EditorStyle property__

<snippet id='radgridview-columns-how-to-combobox-column-clicks-example_1_setting_the_opendropdownonfocus_through_the_editorstyle_property-xaml' />


>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you need to base your style on the __RadComboBoxStyle__.

You can also achieve this in code-behind by handling the [PreparingCellForEdit]({%slug gridview-events-edit%}#preparingcellforedit-event) event of the RadGridView control, as shown in **Example 2**.

__Example 2: Handling the PreparingCellForEdit event__

<snippet id='radgridview-columns-how-to-combobox-column-clicks-example_2_handling_the_preparingcellforedit_event-cs' />

<snippet id='radgridview-columns-how-to-combobox-column-clicks-example_2_handling_the_preparingcellforedit_event-vb' />


## Single-click Selection

In addition, you can have the cell leave edit mode when a selection in the dropdown is made by handling the **SelectionChanged** event of the combobox. To do so, you need to attach to the [PreparedCellForEdit]({%slug gridview-events-edit%}#preparedcellforedit-event) event of the RadGridView control. **Example 3** demonstrates a possible approach.

__Example 3: Handling the PreparedCellForEdit event__

<snippet id='radgridview-columns-how-to-combobox-column-clicks-example_3_handling_the_preparedcellforedit_event-cs' />

<snippet id='radgridview-columns-how-to-combobox-column-clicks-example_3_handling_the_preparedcellforedit_event-vb' />


## See Also

* [ComboBox Column]({%slug radgridview-columns-column-types-combobox-column%}) 
* [Edit Events]({%slug gridview-events-edit%})
