---
title: MultiColumnComboBox Column
page_title: MultiColumnComboBox Column
description: The MultiColumnComboBox column is represented by a standard TextBlock in view mode, and with RadMultiColumnComboBox control in edit mode.
slug: radgridview-columns-column-types-multicolumncombobox-column
tags: multicolumncombobox,column
published: True
position: 12
---

# MultiColumnComboBox Column

__GridViewMultiColumnComboBoxColumn__ derives from [GridViewBoundColumnBase]({%slug radgridview-columns-column-types-boundcolumnbase%}). In view mode it is represented by a standard TextBlock, whereas in edit mode the [RadMultiColumnComboBox]({%slug multicolumncombobox-overview%}) component is used. Here is a list of its most important properties:

* __DataMemberBinding__: Allows you to specify the binding to the property, whose value you want to display in the column. 

* __ItemsSource__: Specifies the data source for the __RadMultiColumnComboBox__ editor.

* __ItemsSourceBinding__: Allows binding editor's __ItemsSource__ to a member of the bound data item.

* __DisplayMemberPath__: Member path to display. It points to a field in the  assigned __ItemsSource__.

* __SelectedValuePath__: Used in conjunction with __DisplayMemberPath__ in the process of translation of a value to display as content. It also tells the __RadMultiColumnComboBox__ editor which property to use as a Value when the user makes selection. 

* __NullText__: Allows you to set a string which will be displayed in both view mode and edit mode when the __RadMultiColumnComboBox__ editor does not have a selected item.

#### __[XAML] Example 1: Defining the GridViewMultiColumnComboBoxColumn__
{{region radmulticolumncombobox-dropdown-properties_01}}
	 <telerik:RadGridView Name="clubsGrid" 
                             ItemsSource="{Binding Clubs}"
                             AutoGenerateColumns="False"
                             GroupRenderMode="Flat"
                             Margin="5">
            <telerik:RadGridView.Columns>
                <telerik:GridViewMultiColumnComboBoxColumn DataMemberBinding="{Binding Name}"
                                                           ItemsSource="{Binding Clubs}" 
                                                           DisplayMemberPath="Name"
                                                           SelectedValuePath="Name"
                                                           SelectionMode="Multiple"
                                                           NullText="Please select an item"
                                                           MinWidth="300"/>
            </telerik:RadGridView.Columns>
        </telerik:RadGridView>
{{endregion}}

#### __Figure 1: GridViewMultiColumnComboBoxColumn example__
![Defining the GridViewMultiColumnComboBoxColumn](images/RadGridView_ColumnTypes_MultiColumnComboBox_01.png)