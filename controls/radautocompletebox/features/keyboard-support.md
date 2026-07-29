---
title: Keyboard Support
page_title: Keyboard Support
description: Check our &quot;Keyboard Support&quot; documentation article for the RadAutoCompleteBox {{ site.framework_name }} control.
slug: radautocompletebox-features-keyboard-support
tags: keyboard,support
published: True
position: 4
---

# Keyboard Support

Using the keyboard you can perform some of the most common tasks. 

## Keyboard Shortcuts

This section describes the keyboard shortcuts used by RadAutoCompleteBox.

* __Up__: Navigates up through the items in the DropDown portion of the control.

* __Down__: Navigates down through the items in the DropDown portion of the control.

* __Tab__: Selects the highlighted item and loses the focus. If there is no suggested item just loses the focus.

* __Enter__: Closes the DropDown if it is open and selects the currently highlighted item.

* __Escape__: Closes the DropDown and deletes the last entered text which has not been autocompleted.

>When an item is selected with the keyboard, it should be scrolled into the viewport and made visible.

## Customize Shortcuts

As of **R2 2016 SP1** the **HandleKeyDown** method can be overridden in order to customize the keys' default behavior or handle other keys. The method returns **True** if the **KeyDown** event should be handled, and **False** otherwise.

A possible scenario would be to select the highlighted item and move the focus to the next control once the user presses **Tab**. Example 1 demonstrates how this can be achieved.

__Example 1: Overriding the HandleKeyDown method__

<snippet id='radautocompletebox-features-keyboard-support-example_1_overriding_the_handlekeydown_method-cs' />
<snippet id='radautocompletebox-features-keyboard-support-example_1_overriding_the_handlekeydown_method-vb' />


## HighlightedIndex

With the **2020.3.817** version of the controls the RadAutoCompleteBox exposes a new **HighlightedIndex** property which you can use to manually change the highlighted item. This property can be used along with the **HandleKeyDown** method to allow navigation using the **Page Up** and **Page Down** keys, for example.

__Example 2: Using the HighlightedIndex property in the HandleKeyDown method__

<snippet id='radautocompletebox-features-keyboard-support-example_2_using_the_highlightedindex_property_in_the_handlekeydown_method-cs' />
<snippet id='radautocompletebox-features-keyboard-support-example_2_using_the_highlightedindex_property_in_the_handlekeydown_method-vb' />


## Tab Navigation

__TabNavigationExtensions.IsTabStop__ attached property indicates whether RadAutoCompleteBox is included in the tab navigation cycle. __Example 1__ illustrates how to set that property in order to exclude the control from the tab navigation. The property is available since **R3 2016**.

__Example 3: RadAutoCompleteBox with TabNavigationExtensions.IsTabStop__

<snippet id='radautocompletebox-features-keyboard-support-example_3_radautocompletebox_with_tabnavigationextensions_istabstop-xaml' />

## See Also

* [Key Properties]({%slug radautocompletebox-features-key-properties%})
* [Filtering Behavior]({%slug radautocompletebox-features-filteringbehavior%})
