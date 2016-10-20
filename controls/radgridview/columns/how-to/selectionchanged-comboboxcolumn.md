---
title: Handle SelectionChanged for GridViewComboBoxColumn
page_title: Handle SelectionChanged for GridViewComboBoxColumn
description: Handle SelectionChanged for GridViewComboBoxColumn
slug: gridview-columns-howto-selectionchanged-comboboxcolumn
tags: handle,selectionchanged,gridviewcomboboxcolumn
published: True
position: 7
---

# Handle SelectionChanged for GridViewComboBoxColumn

**GridViewComboBoxColumn** does not expose a **SelectionChanged** event itself. In case you need such an event to implement your additional logic, you can handle the SelectionChanged event of its editing element (**RadComboBox**). For example the code to do so is available bellow:

#### __[C#] Example 1: Add a handler for the SelectionChanged event__

{{region cs-gridview-columns-howto-selectionchanged-comboboxcolumn_1}}
	this.AddHandler(RadComboBox.SelectionChangedEvent, new System.Windows.Controls.SelectionChangedEventHandler(OnSelectionChanged));
{{endregion}}

#### __[VB.NET] Example 1: Add a handler for the SelectionChanged event__

{{region vb-gridview-columns-howto-selectionchanged-comboboxcolumn_1}}
	Me.AddHandler(RadComboBox.SelectionChangedEvent, New System.Windows.Controls.SelectionChangedEventHandler(AddressOf OnSelectionChanged))
{{endregion}}

#### __[C#] Example 2: Handle the SelectionChanged event__

{{region cs-gridview-columns-howto-selectionchanged-comboboxcolumn_2}}
	Private Sub OnSelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
	    If e.RemovedItems.Count > 0 Then
	        'your code here
	    End If
	End Sub
{{endregion}}

#### __[VB.NET] Example 2: Handle the SelectionChanged event__

{{region vb-gridview-columns-howto-selectionchanged-comboboxcolumn_2}}
	Private Sub OnSelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
	    If e.RemovedItems.Count > 0 Then
	        'your code here
	    End If
	End Sub
{{endregion}}

You can see that with the code snippet above I check if there are any items being unselected (through the RemovedItems.Count). This ensures the event will not be handled on initial loading when a default item has been selected. 

# See Also

 * [ComboBox Column]({%slug radgridview-columns-column-types-combobox-column%})

 * [Empty Cells in Combobox column]({%slug gridview-troubleshooting-blank-cells%})

 * [Number of clicks in the ComboBox column]({%slug gridview-combobox-column-clicks%})
