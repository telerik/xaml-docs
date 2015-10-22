---
title: SDK Examples
page_title: SDK Examples
description: SDK Examples
slug: radautocompletebox-sdk-examples
tags: sdk,examples
published: True
position: 2
---

# SDK Examples

The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadAutoCompleteBox__.

## List of all RadAutoCompleteBox SDK examples:

{% if site.site_name == 'WPF' %}

* __[Add new items with button](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/AddNewItemsWithButton)__ - This example demonstrates how to add new Items to the ItemsSource collection of the control with the use of a simple Button.
* __[How to enable asynchronous Filtering](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/AsynchronousFiltering)__ - 
This example demonstrates how to enable the RadAutoCompleteBox control's asynchronous FilteringBehavior. For demonstration the left RadAutoCompleteBox uses the normal FilteringBehavior and the right RadAutoCompleteBox uses the AsyncFilteringBehavior. Notice the delayed filtering of the asynchronous behavior. Both controls are bound to a collection of 100000 similar items. This behavior is designed to work with a big source set to the ItemsSource of the control.
* __[Custom drop down item template](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/CustomDropDownItemTemplate)__ - This example demonstrates how to create a custom DropDownItemTemplate for the RadAutoCompleteBox control in Silverlight and WPF.
* __[Custom HighlightBehavior](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/CustomHighlightBehavior)__ - 
This example demonstrates how to implement a custom HighlightBehavior which is always highlighting the last of the matching items unless there is an exact match.
* __[Highlight matching items text](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/HighlightMatchingItemsText_WPF)__ - This example demonstrates how to achieve highlighting of the matched items text in the RadAutoCompleteBox control's drop down portion.
* __[MinimumPopulateDelay example](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/MinimumPopulateDelay)__ - 
This example demonstrates how to implement minimum delay before the built-in filtering of the control is triggered. For better user experience a RadBusyIndicator is added in order to give feedback that the delay is triggered and is running.
When deleting the inputted text by pressing the 'Backspace' keyboard key the DropDown of the control is immediately closed and the populating (filtering) is terminated. In those scenarios if a populate (filtering) with the current SearchText should be triggered all that is needed is for the 'Enter' keyboard key to be pressed.
* __[Differently colored selected boxes example](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/MultiColorBoxesItems)__ - This example demonstrates how to achieve different appearance of the selected AuctoCompleteItems using BoxesItemTemplate property and RadAutoCompleteBoxItem style.
* __[No match filtering behavior](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/NoMatchFilteringBehavior)__ - This example demonstrates how to customize the FilteringBehavior of the cotnrol for Silverlight and WPF. With the custom filtering behavior if the control has the focus or there isn't a matched item when typing in the control  the drop down portion of the control will be populated with the entire ItemsSource collection. Try typing in for example  'London', the drop down will be populated no matter that there isn't a matched item.
* __[Open with drop down button](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/OpenWithDropDownButton)__ - This example demonstrates how to create a button that will populate the drop down portion of the RadAutoCompleteBox control for Silverlight and WPF.
* __[Single SelectionMode with clear button](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/SingleSelectionModeWithClearButton)__ - 
This example demonstates how to add a button that clears the current SelectedItem in Single SelectionMode.
* __[Two properties filtering behavior](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/TwoPropertiesFilteringBehavior)__ - This example demonstrates how to customize the FilteringBehavior of the control for Silverlight and WPF. For example type U (for United States) then ',' and then W (for Washington, D.C.), this will generate  Unites States in the drop down portion of the control.
* __[With DataForm](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/WithDataForm)__ - This example demonstrates how to use RadAutoCompleteBox inside RadDataForm by creating a custom ReadOnlyTemplate, EditTemplateand NewItemTemplate for Silverlight and WPF.
* __[With GridView](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/WithGridView)__ - This example shows how to add RadAutoCompleteBox insize GridViewDataColumn for Silverlight and WPF. The 'Country' column in the RadGridView uses the AutoCompleteBox control."
{% endif %}
{% if site.site_name == 'Silverlight' %}
* __[Add new items with button](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/AddNewItemsWithButton)__ - This example demonstrates how to add new Items to the ItemsSource collection of the control with the use of a simple Button.
* __[How to enable asynchronous Filtering](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/AsynchronousFiltering)__ - 
This example demonstrates how to enable the RadAutoCompleteBox control's asynchronous FilteringBehavior. For demonstration the left RadAutoCompleteBox uses the normal FilteringBehavior and the right RadAutoCompleteBox uses the AsyncFilteringBehavior. Notice the delayed filtering of the asynchronous behavior. Both controls are bound to a collection of 100000 similar items. This behavior is designed to work with a big source set to the ItemsSource of the control.
* __[Custom drop down item template](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/CustomDropDownItemTemplate)__ - This example demonstrates how to create a custom DropDownItemTemplate for the RadAutoCompleteBox control in Silverlight and WPF.
* __[Custom HighlightBehavior](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/CustomHighlightBehavior)__ - 
This example demonstrates how to implement a custom HighlightBehavior which is always highlighting the last of the matching items unless there is an exact match.
* __[Highlight matching items text](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/HighlightMatchingItemsText_SL)__ - This example demonstrates how to achieve highlighting of the matched items text in the RadAutoCompleteBox control's drop down portion.
* __[MinimumPopulateDelay example](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/MinimumPopulateDelay)__ - 
This example demonstrates how to implement minimum delay before the built-in filtering of the control is triggered. For better user experience a RadBusyIndicator is added in order to give feedback that the delay is triggered and is running.
When deleting the inputted text by pressing the 'Backspace' keyboard key the DropDown of the control is immediately closed and the populating (filtering) is terminated. In those scenarios if a populate (filtering) with the current SearchText should be triggered all that is needed is for the 'Enter' keyboard key to be pressed.
* __[Differently colored selected boxes example](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/MultiColorBoxesItems)__ - 
This example demonstrates how to achieve different appearance of the selected AuctoCompleteItems using BoxesItemTemplate property and RadAutoCompleteBoxItem style.

* __[No match filtering behavior](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/NoMatchFilteringBehavior)__ - This example demonstrates how to customize the FilteringBehavior of the cotnrol for Silverlight and WPF. With the custom filtering behavior if the control has the focus or there isn't a matched item when typing in the control  the drop down portion of the control will be populated with the entire ItemsSource collection. Try typing in for example  'London', the drop down will be populated no matter that there isn't a matched item.
* __[Open with drop down button](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/OpenWithDropDownButton)__ - This example demonstrates how to create a button that will populate the drop down portion of the RadAutoCompleteBox control for Silverlight and WPF.
* __[Single SelectionMode with clear button](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/SingleSelectionModeWithClearButton)__ - 
This example demonstates how to add a button that clears the current SelectedItem in Single SelectionMode.
* __[Two properties filtering behavior](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/TwoPropertiesFilteringBehavior)__ - This example demonstrates how to customize the FilteringBehavior of the control for Silverlight and WPF. For example type U (for United States) then ',' and then W (for Washington, D.C.), this will generate  Unites States in the drop down portion of the control.
* __[With DataForm](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/WithDataForm)__ - This example demonstrates how to use RadAutoCompleteBox inside RadDataForm by creating a custom ReadOnlyTemplate, EditTemplateand NewItemTemplate for Silverlight and WPF.
* __[With GridView](https://github.com/telerik/xaml-sdk/tree/master/AutoCompleteBox/WithGridView)__ - This example shows how to add RadAutoCompleteBox insize GridViewDataColumn for Silverlight and WPF. The 'Country' column in the RadGridView uses the AutoCompleteBox control."
{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).