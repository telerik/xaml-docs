---
title: Key Properties
page_title: Key Properties
description: Key Properties
slug: radautocompletebox-features-key-properties
tags: key,properties
published: True
position: 0
---

# Key Properties

The purpose of this help article is to show you the key properties of __RadAutoCompleteBox__ control. The topic includes the following properties:

* [Setting the ItemsSource](#setting-the-itemssource)

* [Changing the TextSearchMode](#changing-the-textsearchmode)

* [Changing the SelectionMode](#changing-the-selectionmode)

* [Setting the TextBoxStyle, BoxesItemTemplate, DropDownItemTemplate properties](#setting-the-style-and-template-properties)

* [Other properties](#other-properties)

## Setting the ItemsSource

The ItemsSource property of __RadAutoCompleteBox__ could be set to any collection of items. However, it is recommended to set it to an ObservableCollection. Read [more]({%slug radautocompletebox-populating-with-data-binding-to-object%}).

## Changing the TextSearchMode

The __TextSearchMode__ property represents the behavior by which items in the ItemsSource will be filtered. This property can be set to four values - __Contains__, __ContainsCaseSensitive__, __StartsWith__, __StartsWithCaseSensitive__. By default the TextSearchMode property is set to StartsWith.

## Changing the SelectionMode

The __SelectionMode__ property represents the behavior by which items will be selected in RadAutoCompleteBox control. This property can be set to two values - __Single__, __Multiple__. By default the SelectionMode property is set to Multiple.

## Setting the Style and Template properties

It is possible to customize the way items in the DropDown portion of the control, the TextBox and the selected Items appear by customizing the __DropDownItemTemplate__, __TextBoxStyle__ and __BoxesItemTemplate__.

## Other properties

There are some other key properties in RadAutoCompleteBox:

* __MaxDropDownHeight__ - Gets or sets the maximum height of the dropdown portion of the AutoCompleteBox control.

* __TextSearchPath__ - Gets or sets the property path that is used to get the autocomplete text to filter items.

* __SelectedItem__ - Gets or sets the currently selected item into RadAutoCompleteBox.

* __SelectedItems__ - Gets or sets a collection containing the currently selected items into RadAutoCompleteBox.
