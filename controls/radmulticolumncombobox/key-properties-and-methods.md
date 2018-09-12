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

* [Delaying the Text Change](#delay-the-text-change)
* [Disable Items Highlighting](#disable-items-highlighting)
* [Setting Text for an Empty Selection](#setting-text-for-an-empty-selection)
* [Programmatically Closing the DropDown](#programmatically-closing-the-dropdown)

## Delaying the Text Change

The default behavior of __RadMultiColumnComboBox__ for reacting to a text change will be triggered immediately. In case when a delay of the update is needed, the __DeferTextChange__ property can be set to __True__.

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

## Programmatically Closing the DropDown

In order to close the already opened DropDown at given state, the __CloseDropDown__ method can be called.

#### __[C#] Example 2: Calling the CloseDropDown method__
{{region radmulticolumncombobox-key_properties_1}}
	this.multiColumnComboBox.CloseDropDown();
{{endregion}}

## See Also

* [Getting Started]({%slug multicolumncombobox-getting-started%})
* [DropDown Properties]({%slug multicolumncombobox-dropdown-properties%})