---
title: Handle SelectionChanged for GridViewComboBoxColumn
page_title: SelectionChanged for ComboBoxColumn
description: Learn how to handle the SelectionChanged event in case you need it to implement additional logic for the ComboBoxColumn in Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-columns-howto-selectionchanged-comboboxcolumn
tags: handle,selectionchanged,gridviewcomboboxcolumn
published: True
position: 7
---

# {{ site.framework_name }} RadGridView Handle SelectionChanged for GridViewComboBoxColumn

**GridViewComboBoxColumn** does not expose a **SelectionChanged** event itself. In case you need such an event to implement your additional logic, you can handle the SelectionChanged event of its editing element (**RadComboBox**). For example the code to do so is available bellow:

{% if site.site_name == 'WPF' %}
#### __[C#] Example 1: Add a handler for the SelectionChanged event__

{{region cs-gridview-columns-howto-selectionchanged-comboboxcolumn_1}}
	this.radGridView.AddHandler(RadComboBox.SelectionChangedEvent, new System.Windows.Controls.SelectionChangedEventHandler(OnSelectionChanged));
{{endregion}}

#### __[VB.NET] Example 1: Add a handler for the SelectionChanged event__

{{region vb-gridview-columns-howto-selectionchanged-comboboxcolumn_1}}
	Me.radGridView.AddHandler(RadComboBox.SelectionChangedEvent, New System.Windows.Controls.SelectionChangedEventHandler(AddressOf OnSelectionChanged))
{{endregion}}

#### __[C#] Example 2: Handle the SelectionChanged event__

{{region cs-gridview-columns-howto-selectionchanged-comboboxcolumn_2}}
	private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.RemovedItems.Count > 0)
            {
                //your code here
            }
        }
{{endregion}}

#### __[VB.NET] Example 2: Handle the SelectionChanged event__

{{region vb-gridview-columns-howto-selectionchanged-comboboxcolumn_2}}
	Private Sub OnSelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
	    If e.RemovedItems.Count > 0 Then
	        'your code here
	    End If
	End Sub
{{endregion}}
{% endif %}
{% if site.site_name == 'Silverlight' %}
#### __[C#] Example 1: Add a handler for the SelectionChanged event__

{{region cs-gridview-columns-howto-selectionchanged-comboboxcolumn_1}}
	this.radGridView.AddHandler(RadComboBox.SelectionChangedEvent, new Telerik.Windows.Controls.SelectionChangedEventHandler(OnSelectionChanged));
{{endregion}}

#### __[VB.NET] Example 1: Add a handler for the SelectionChanged event__

{{region vb-gridview-columns-howto-selectionchanged-comboboxcolumn_1}}
	Me.radGridView.AddHandler(RadComboBox.SelectionChangedEvent, New Telerik.Windows.Controls.SelectionChangedEventHandler(AddressOf OnSelectionChanged))
{{endregion}}

#### __[C#] Example 2: Handle the SelectionChanged event__

{{region cs-gridview-columns-howto-selectionchanged-comboboxcolumn_2}}
	private void OnSelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (e.RemovedItems.Count > 0)
            {
                //your code here
            }
        }
{{endregion}}

#### __[VB.NET] Example 2: Handle the SelectionChanged event__

{{region vb-gridview-columns-howto-selectionchanged-comboboxcolumn_2}}
	Private Sub OnSelectionChanged(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.SelectionChangedEventArgs)
	    If e.RemovedItems.Count > 0 Then
	        'your code here
	    End If
	End Sub
{{endregion}}
{% endif %}

You can see that with the code snippet above I check if there are any items being unselected (through the RemovedItems.Count). This ensures the event will not be handled on initial loading when a default item has been selected. 

## See Also

* [ComboBox Column]({%slug radgridview-columns-column-types-combobox-column%})
* [Empty Cells in Combobox column]({%slug gridview-troubleshooting-blank-cells%})
* [Number of clicks in the ComboBox column]({%slug gridview-combobox-column-clicks%})
