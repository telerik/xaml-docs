---
title: AutoComplete
page_title: AutoComplete
description: AutoComplete
slug: multicolumncombobox-autocomplete
tags: autocomplete
published: True
position: 0
---

# AutoComplete

__RadMultiColumnComboBox__ provides a built-in set of auto-completion options. The control exposes the __AutoCompleteMode__ property for setting them. It is an enumeration that has the __Append, Search, Suggest and SuggestAppend__ values. This topic will go through each one of them.

>The case sensitivity of the user's input can be controlled through the __MatchCase__ boolean property. Its default value is __False__ meaning that the input will be case insensitive. Respectively, when set to __True__ it will be case sensitive.

>important The __Append, Suggest and SuggestAppend __ modes by default use a __StartsWith__ operator for a string data type.

* __Append__: Finds the matching items without filtering the source collection. In this mode the control auto-completes the text with the property value of the first found item.

#### __[XAML]: Example 1: Setting the AutoCompleteMode to Append__
{{region radmulticolumncombobox-features_autocomplete_01}}
	<telerik:RadMultiColumnComboBox VerticalAlignment="Top" AutoCompleteMode="Append" MatchCase="True">
            <telerik:RadMultiColumnComboBox.ItemsSourceProvider>
                <telerik:GridViewItemsSourceProvider ItemsSource="{Binding Clubs, Source={StaticResource MyViewModel}}"/>
            </telerik:RadMultiColumnComboBox.ItemsSourceProvider>
        </telerik:RadMultiColumnComboBox>
{{endregion}}

#### __Figure 1: Setting the AutoCompleteMode to Append__
![Setting the AutoCompleteMode to Append](images/MultiColumnComboBox_AutoComplete_01.png)

* __Search__: Filters and highlights the data. For a __string__ property a __Contains__ operator will be applied, whereas for any other types an __IsEqualTo__ will be used. This is basically the [Search as you type]({%slug radgridview-search-as-you-type%}) mechanism of RadGridView.

#### __Figure 2: Setting the AutoCompleteMode to Search__
![Setting the AutoCompleteMode to Search](images/MultiColumnComboBox_AutoComplete_02.png)
 
* __Suggest__: Filters the data but does not auto-complete.

#### __Figure 3: Setting the AutoCompleteMode to Suggest__
![Setting the AutoCompleteMode to Sugggest](images/MultiColumnComboBox_AutoComplete_03.png)

* __SuggestAppend__: Both filtering and auto-completion is applied.

#### __Figure 4: Setting the AutoCompleteMode to SuggestAppend__
![Setting the AutoCompleteMode to Suggest](images/MultiColumnComboBox_AutoComplete_04.png)

## See Also

* [Getting Started]({%slug multicolumncombobox-getting-started%})
* [DropDown Properties]({%slug multicolumncombobox-dropdown-properties%})