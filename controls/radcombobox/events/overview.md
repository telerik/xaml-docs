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
```XAML	
	<telerik:RadComboBox x:Name="radComboBox" DropDownOpened="RadComboBox_DropDownOpened" />
```

__Example 2: Subscribing to an event in code__
```C#
	 this.radComboBox.DropDownOpened += RadComboBox_DropDownOpened;
```

## Events

* __DropDownOpened__: Occurs when the drop-down list of the combobox opens. 

	__Example 3: DropDownOpened event handler__
	```C#
		private void RadComboBox_DropDownOpened(object sender, EventArgs e)
        {
            var radComboBox = (RadComboBox)sender;
        }
	```

* __DropDownClosed__: Occurs when the drop-down list of the combobox closes. 

	__Example 4: DropDownClosed event handler__
	```C#
		private void RadComboBox_DropDownClosed(object sender, EventArgs e)
        {
            var radComboBox = (RadComboBox)sender;
        }
	```

* __SelectionChanged__: Occurs when the selected item is changed. The event arguments are of type __SelectionChangedEventArgs__ and expose the __AddedItems__ and __RemovedItems__ properties which contain the newly selected and the unselected items.

	__Example 5: SelectionChanged event handler__
	```C#
		private void RadComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var radComboBox = (RadComboBox)sender;
            IList selectedItems = e.AddedItems;
            IList unselectedItems = e.RemovedItems;
        }
	```

>The __SelectionChanged__ event is inherited from the [Selector](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.primitives.selector?view=net-5.0) class. 

## See Also
 * [Visual Structure]({%slug radcombobox-general-information-visual-structure%})
 * [Getting Started]({%slug radcombobox-getting-started%})
