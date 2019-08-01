---
title: Overview
page_title: Overview
description: Overview
slug: radcombobox-events-overview
tags: overview
published: True
position: 0
---

# Overview

This topic lists the events specific for the __RadComboBox__ control and it shows how to subscribe to an event.

## Subscribing to Event

Subcribing to an event can be done in Xaml or in code behind.

#### __[XAML] Example 1: Subscribing to an event in Xaml__
{{region radcombobox-events-overview-0}}	
	<telerik:RadComboBox x:Name="radComboBox" DropDownOpened="RadComboBox_DropDownOpened" />
{{endregion}}

#### __[C#] Example 2: Subscribing to an event in code__
{{region radcombobox-events-overview-1}}
	 this.radComboBox.DropDownOpened += RadComboBox_DropDownOpened;
{{endregion}}

## Events

* __DropDownOpened__: Occurs when the drop-down list of the combobox opens. 

	#### __[C#] Example 3: DropDownOpened event handler__
	{{region radcombobox-events-overview-2}}
		private void RadComboBox_DropDownOpened(object sender, EventArgs e)
        {
            var radComboBox = (RadComboBox)sender;
        }
	{{endregion}}

* __DropDownClosed__: Occurs when the drop-down list of the combobox closes. 

	#### __[C#] Example 4: DropDownClosed event handler__
	{{region radcombobox-events-overview-3}}
		private void RadComboBox_DropDownClosed(object sender, EventArgs e)
        {
            var radComboBox = (RadComboBox)sender;
        }
	{{endregion}}

* __SelectionChanged__: Occurs when the selected item is changed. The event arguments are of type __SelectionChangedEventArgs__ and expose the __AddedItems__ and __RemovedItems__ properties which contain the newly selected and the unselected items.

	#### __[C#] Example 5: SelectionChanged event handler__
	{{region radcombobox-events-overview-4}}
		private void RadComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var radComboBox = (RadComboBox)sender;
            IList selectedItems = e.AddedItems;
            IList unselectedItems = e.RemovedItems;
        }
	{{endregion}}

## See Also
 * [Visual Structure]({%slug radcombobox-general-information-visual-structure%})
 * [Getting Started]({%slug radcombobox-getting-started%})
