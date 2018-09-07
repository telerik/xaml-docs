---
title: DropDown Properties
page_title: DropDown Properties
description: DropDown Properties
slug: multicolumncombobox-dropdown-properties
tags: dropdown,properties
published: True
position: 2
---

# DropDown Properties

This article describes the set of properties that can be used for manipulating the DropDown of __RadMultiColumnComobBox__.

## Height of the DropDown

The Height of the DropDown element can be set through the __DropDownHeight__ property.

#### __[XAML] Example 1: Setting the DropDownHeight property__
{{region radmulticolumncombobox-dropdown-properties_01}}
	 <telerik:RadMultiColumnComboBox DisplayMemberPath="Name" DropDownHeight="200">
            <telerik:RadMultiColumnComboBox.ItemsSourceProvider>
                <telerik:GridViewItemsSourceProvider ItemsSource="{Binding Orders, Source={StaticResource ViewModel}}" />
            </telerik:RadMultiColumnComboBox.ItemsSourceProvider>
        </telerik:RadMultiColumnComboBox>
{{endregion}}

#### __Figure 1: Setting the DropDownHeight property__
![Setting the DropDownHeight property](images/MultiColumnComboBox_DropDown_Properties_01.png)

## Width of the DropDown

The Width of the DropDown element can be set through the __DropDownWidth__ property.

## Setting Max Height or Width of the DropDown

The maximum Width or Height space that the DropDown can take can be controled by the __DropDownMaxHeight__ and __DropDownMaxWidth__ properties.

## Position of the DropDown

__RadMultiColumnComboBox__ provides a predefined set of options for setting the position of the DropDown. They are exposed through the __DropDownPlacement__ property. It is a [PlacementMode enumaration](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.primitives.placementmode?view=netframework-4.7.2) and has the following values.

* __Absolute__
* __AbsolutePoint__
* __Bottom__
* __Center__
* __Left__
* __Mouse__
* __MousePoint__
* __Relative__
* __RelativePoint__
* __Right__
* __Top__

## See Also

* [Getting Started]({%slug multicolumncombobox-getting-started%})
* [AutoComplete]({%slug multicolumncombobox-autocomplete%})

