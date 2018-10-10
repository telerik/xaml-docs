---
title: Key Properties and Methods
page_title: Key Properties and Methods
description: Key Properties and Methods
slug: multicolumncombobox-dropdown-key-properties-and-methods
tags: key, properties, methods
published: True
position: 3
---

# Key Properties and Methods

The article lists the most important properties and methods of __RadMultiColumnComboBox__.

* [Text Change Without Delay](#text-change-without-delay)
* [Disable Items Highlighting](#disable-items-highlighting)
* [Setting Text for an Empty Selection](#setting-text-for-an-empty-selection)
* [Open,Close and Toggle the DropDown](#open,close-and-toggle-the-dropdown)

## Text Change Without Delay

By default, the reaction of __RadMultiColumnComboBox__ to a text change will be deferred. In case when updating needs to be done immediately, the __DeferTextChange__ property can be set to __False__.

## Disable Items Highlighting 

With all settings for its __AutoCompleteMode, RadMultiColumnComboBox__ will highlight its items. This can be switched off by setting the __HighlightMatches__ property to __False__.

## Setting Text for an Empty Selection

When there is no selection applied, the control will display an empty AutoCompleteBox. In case a custom text needs to be displayed in it, the __NullText__ property comes in handy.

#### __[XAML] Example 1: Setting the NullText property__
{{region radmulticolumncombobox-key_properties_0}}
	<telerik:RadMultiColumnComboBox VerticalAlignment="Top" DisplayMemberPath="Name" 
                                         NullText="Please enter input">
            <telerik:RadMultiColumnComboBox.ItemsSourceProvider>
                <telerik:GridViewItemsSourceProvider ItemsSource="{Binding Clubs, Source={StaticResource MyViewModel}}"/>
            </telerik:RadMultiColumnComboBox.ItemsSourceProvider>
        </telerik:RadMultiColumnComboBox>
{{endregion}}

#### __Figure 1: MultiColumnComboBox with NullText set__
![MultiColumnComboBox with NullText set](images/MultiColumnComboBox_KeyProperties_01.png)

## Open,Close and Toggle the DropDown

The following set of methods is provided for manipulating the visibility of the DropDown.

* __OpenDropDown__: Opens the DropDown if it is closed.
* __CloseDropDown__: Closes the DropDown if it is opened.
* __ToggleDropDown__: Toggles the opened/closed state of the DropDown.

## See Also

* [Getting Started]({%slug multicolumncombobox-getting-started%})
* [DropDown Properties]({%slug multicolumncombobox-dropdown-properties%})