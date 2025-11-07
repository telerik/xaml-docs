---
title: Key Properties and Methods
page_title: Key Properties and Methods
description: Check our &quot;Key Properties and Methods&quot; documentation article for the RadMultiColumnComboBox WPF control.
slug: multicolumncombobox-dropdown-key-properties-and-methods
tags: key, properties, methods
published: True
position: 6
---

# Key Properties and Methods

The article lists the most important properties and methods of `RadMultiColumnComboBox`.

## Text Change Without Delay

By default, the reaction of RadMultiColumnComboBox to a text change will be deferred. In case when updating needs to be done immediately, the `DeferTextChange` property can be set to __False__.

## Disable Items Highlighting 

With all settings for its AutoCompleteMode, RadMultiColumnComboBox will highlight its items. This can be switched off by setting the `HighlightMatches` property to __False__.

## Setting Text for an Empty Selection

When there is no selection applied, the control will display an empty AutoCompleteBox. In case a custom text needs to be displayed in it, the `NullText` property comes in handy.

__Setting the NullText property__
```XAML
	<telerik:RadMultiColumnComboBox VerticalAlignment="Top" DisplayMemberPath="Name" 
                                         NullText="Please enter input">
            <telerik:RadMultiColumnComboBox.ItemsSourceProvider>
                <telerik:GridViewItemsSourceProvider ItemsSource="{Binding Clubs, Source={StaticResource MyViewModel}}"/>
            </telerik:RadMultiColumnComboBox.ItemsSourceProvider>
        </telerik:RadMultiColumnComboBox>
```

__MultiColumnComboBox with NullText set__

![MultiColumnComboBox with NullText set](images/MultiColumnComboBox_KeyProperties_01.png)

## Open,Close and Toggle the DropDown

The following set of methods is provided for manipulating the visibility of the DropDown.

* `OpenDropDown`&mdash;Opens the DropDown if it is closed.
* `CloseDropDown`&mdash;Closes the DropDown if it is opened.
* `ToggleDropDown`&mdash;Toggles the opened/closed state of the DropDown.

## Drop Down Element Style

RadMultiColumnComboBox exposes the `DropDownElementStyle` property. Through it, you can get or set a Style that will be applied to the dropdown element.

> The TargetType of the Style should match the type of the dropdown element.

## Search Mode

The RadMultiColumnComboBox exposes a new `SearchMode` property which allows you to control how items are matched when search is executed. It has the following two possible values:

* `MatchAnyTerm`&mdash;Items match the search operation when they fulfill any of the search terms. For example, if `John Terry` is inputted, items containing __any__ of the terms "John" and "Terry" in any of their properties will be matched. This is the default value.
* `MatchAllTerms`&mdash;Items match the search operation only when they fulfill all of the search terms. Continuing with the previous example, if `John Terry` is entered as the search text, only items which contain __both__ terms ("John" and "Terry") in any of their properties will be matched.

>important The SearchMode property takes effect only if the `AutoCompleteMode` of the control is `Search`.

## Selection On Focus

The RadMultiColumnComboBox control exposes the `SelectionOnFocus` property, which allows you to specify what will happen with the cursor when the control gets focus. 

> This property is respected when the `SelectionBoxesVisibility` property is set to `Collapsed`.

The values for the SelectionOnFocus property are predefined in the `SelectionOnFocus` enumeration. It exposes the following members:				

* `SelectAll`&mdash;Once the control is focused, it will select its whole text. 				
* `CaretToBeginning`&mdash;Once the control is focused, the cursor will be positioned at its beginning.		
* `CaretToEnd`&mdash;Once the control is focused, the cursor will be positioned at its end.
* `Unchanged`&mdash;Once the control is focused, the cursor's position won't be changed. This is the default value for the SelectionOnFocus property.
* `Default`&mdash;Once the control is focused, the cursor will be positioned at its end.
* `DefaultSelectAll`&mdash;This property changes the SelectionOnFocus behavior of the control depending on the source of the focus. If the control is focused on mouse click, the Default SelectionOnFocus behavior will be used. If, on the other hand, the control is focused using the __Tab__ key, the SelectAll SelectionOnFocus behavior will be used.

## Clear Selection On Delete Or Back Key

The RadMultiColumnComboBox control provides the ability to control if the selected item/s will be removed when pressing the Delete or Back key when typing into the input box. This is done via the `ClearSelectionOnDeleteOrBackKey` property and its default value is __True__. Setting it to __False__ will prevent the removal of selected items when pressing the  into the input box

__Setting the ClearSelectionOnDeleteOrBackKey property__
```XAML
	<telerik:RadMultiColumnComboBox ClearSelectionOnDeleteOrBackKey="False"/>
```

## See Also

* [Getting Started]({%slug multicolumncombobox-getting-started%})
* [DropDown Properties]({%slug multicolumncombobox-dropdown-properties%})
