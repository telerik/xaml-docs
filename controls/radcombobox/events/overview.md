---
title: Overview
page_title: Overview
description: This topic lists the events specific for the __RadComboBox__ control and it shows how to subscribe to an event.
slug: radcombobox-events-overview
tags: overview
published: True
position: 0
---

# Overview

This topic lists the events specific for the __RadComboBox__ control and it shows how to subscribe to an event.

## Subscribing to Event

Subcribing to an event can be done in Xaml or in code behind.

__Example 1: Subscribing to an event in Xaml__
<snippet id='radcombobox-events-overview-example_1_subscribing_to_an_event_in_xaml-xaml' />


__Example 2: Subscribing to an event in code__
<snippet id='radcombobox-events-overview-example_2_subscribing_to_an_event_in_code-cs' />


## Events

* __DropDownOpened__: Occurs when the drop-down list of the combobox opens. 

	__Example 3: DropDownOpened event handler__
	<snippet id='radcombobox-events-overview-example_3_dropdownopened_event_handler-cs' />


* __DropDownClosed__: Occurs when the drop-down list of the combobox closes. 

	__Example 4: DropDownClosed event handler__
	<snippet id='radcombobox-events-overview-example_4_dropdownclosed_event_handler-cs' />


* __SelectionChanged__: Occurs when the selected item is changed. The event arguments are of type __SelectionChangedEventArgs__ and expose the __AddedItems__ and __RemovedItems__ properties which contain the newly selected and the unselected items.

	__Example 5: SelectionChanged event handler__
	<snippet id='radcombobox-events-overview-example_5_selectionchanged_event_handler-cs' />


>The __SelectionChanged__ event is inherited from the [Selector](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.primitives.selector?view=net-5.0) class. 

## See Also
 * [Visual Structure]({%slug radcombobox-general-information-visual-structure%})
 * [Getting Started]({%slug radcombobox-getting-started%})
