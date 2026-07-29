---
title: Handle SelectionChanged for GridViewComboBoxColumn
page_title: SelectionChanged for ComboBoxColumn
description: Learn how to handle the SelectionChanged event in case you need it to implement additional logic for the ComboBoxColumn in Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-columns-howto-selectionchanged-comboboxcolumn
tags: handle,selectionchanged,gridviewcomboboxcolumn
published: True
position: 7
---

# Handle SelectionChanged for GridViewComboBoxColumn

**GridViewComboBoxColumn** does not expose a **SelectionChanged** event itself. In case you need such an event to implement your additional logic, you can handle the SelectionChanged event of its editing element (**RadComboBox**). For example the code to do so is available bellow:

{% if site.site_name == 'WPF' %}
__Example 1: Add a handler for the SelectionChanged event__

<snippet id='radgridview-columns-how-to-selectionchanged-comboboxcolumn-example_1_add_a_handler_for_the_selectionchanged_event-cs' />

<snippet id='radgridview-columns-how-to-selectionchanged-comboboxcolumn-example_1_add_a_handler_for_the_selectionchanged_event-vb' />


__Example 2: Handle the SelectionChanged event__

<snippet id='radgridview-columns-how-to-selectionchanged-comboboxcolumn-example_2_handle_the_selectionchanged_event-cs' />

<snippet id='radgridview-columns-how-to-selectionchanged-comboboxcolumn-example_2_handle_the_selectionchanged_event-vb' />

{% endif %}
{% if site.site_name == 'Silverlight' %}
__Example 1: Add a handler for the SelectionChanged event__

<snippet id='radgridview-columns-how-to-selectionchanged-comboboxcolumn-example_1_add_a_handler_for_the_selectionchanged_event-cs' />

<snippet id='radgridview-columns-how-to-selectionchanged-comboboxcolumn-example_1_add_a_handler_for_the_selectionchanged_event-vb' />


__Example 2: Handle the SelectionChanged event__

<snippet id='radgridview-columns-how-to-selectionchanged-comboboxcolumn-example_2_handle_the_selectionchanged_event-cs' />

<snippet id='radgridview-columns-how-to-selectionchanged-comboboxcolumn-example_2_handle_the_selectionchanged_event-vb' />

{% endif %}

You can see that with the code snippet above I check if there are any items being unselected (through the RemovedItems.Count). This ensures the event will not be handled on initial loading when a default item has been selected. 

## See Also

* [ComboBox Column]({%slug radgridview-columns-column-types-combobox-column%})
* [Empty Cells in Combobox column]({%slug gridview-troubleshooting-blank-cells%})
* [Number of clicks in the ComboBox column]({%slug gridview-combobox-column-clicks%})
