---
title: Selection
page_title: Selection
description: Selection
slug: multicolumncombobox-selection
tags: selection
published: True
position: 1
---

# Selection

__RadMultiColumnComboBox__ would perform its selection based on the property that is set to be its __DisplayMemberPath__. 

#### Figure 1: Default Selection
![Default Selection](images/MultiColumnComboBox_Selection_01.png)

Furthermore, the control exposes the following properties and events for handling the user selection.

 * __SelectedItem__: gets or sets the data item that is selected.
 * __SelectedItems__: gets the data items that participate in the selection. It is useful in case multiple selection is used.
 * __SelectedValue__: gets or sets the selected property value.
 * __SelectedValueMemberPath__: gets or sets the property path of the property used for the selected value.

## Multiple Selection

By default, __RadMultiColumnComboBox__ will perform a single selection. In order to enable a multiple selection, the __SelectionMode__ of the control can be set to __Multiple__.

#### __[XAML] Example 1: Setting the SelectionMode to Multiple__
{{region radmulticolumncombobox-features_selection_0}}
	<telerik:RadMultiColumnComboBox VerticalAlignment="Top" DisplayMemberPath="Name" SelectionMode="Multiple">
            <telerik:RadMultiColumnComboBox.ItemsSourceProvider>
                <telerik:GridViewItemsSourceProvider ItemsSource="{Binding Clubs, Source={StaticResource MyViewModel}}"/>
            </telerik:RadMultiColumnComboBox.ItemsSourceProvider>
        </telerik:RadMultiColumnComboBox>
{{endregion}}

#### Figure 2: Multiple Selection
![Multiple Selection](images/MultiColumnComboBox_Selection_02.png)

## SelectionChanged event

Each time a select or deselect operation is applied, the __SelectionChanged__ event will be fired.

#### __[XAML] Example 2: Handling the SelectionChanged event__
{{region radmulticolumncombobox-features_selection_1}}
		private void RadMultiColumnComboBox_SelectionChanged(object sender, SelectionChangeEventArgs e)
        {
            
        }
{{endregion}}

The event arguments expose the following collections.

* __AddedItems__: a collection of the item(s) that has/have been added to the selection
* __RemovedItems__: a collection of the item(s) that has/have been removed from the selection

## See Also

* [AutoComplete]({%slug multicolumncombobox-autocomplete%})