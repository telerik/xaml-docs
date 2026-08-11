---
title: Events
page_title: Events
description: This article lists and explains the events exposed by the RadCallout control.
slug: radcallout-events
tags: radcallout, events
published: True
position: 3
---

# Events

This article lists the events of the RadCallout control when placed inside a Popup. Subscribing to the events of the control can be achieved through the __CalloutPopupService__ class. The service exposes several methods to add/remove event handlers for the RadCallout control events. 

> The following events are related only for the placement target element.

## Subscribe to RadCallout Events in XAML

You can subscribe to the placement target element events of the Popup holding the RadCallout, using the CalloutPopupService.

__Example 1: Add event handler to PopupOpening in XAML__
<snippet id='radcallout-features-popupusage-events-example_1_add_event_handler_to_popupopening_in_xaml-cs' />

## Subscribe to RadCallout Events in Code Behind

* **PopupOpening**: Occurs before the RadCallout is shown. Through the __CancelRoutedEventArgs__, you can access the following property:

	* **Cancel**: A boolean property that can be used to cancel the control from appearing. 

	__Example 2: Add event handler to PopupOpening__
<snippet id='radcallout-features-popupusage-events-example_1_add_event_handler_to_popupopening_in_xaml-cs' />

* **PopupOpened**: Occurs after the RadCallout is shown.

	__Example 3: Add event handler to PopupOpened__
<snippet id='radcallout-features-popupusage-events-example_1_add_event_handler_to_popupopening_in_xaml-cs' />
		
* **PopupClosing**: Occurs before the RadCallout is closed. Through the __CancelRoutedEventArgs__, you can access the following property:

	* **Cancel**: A boolean property that can be used to cancel the RadCallout control from closing. 

	__Example 4: Add event handler to PopupClosing__
<snippet id='radcallout-features-popupusage-events-example_1_add_event_handler_to_popupopening_in_xaml-cs' />

* **PopupClosed**: Occurs after the RadCallout is closed.

	__Example 5: Add event handler to PopupClosed__
<snippet id='radcallout-features-popupusage-events-example_1_add_event_handler_to_popupopening_in_xaml-cs' />
		
## Unsubscribe from RadCallout Events

The __CalloutPopupService__ class expose several methods to remove the events handlers.

__Example 6: Remove event handlers__
<snippet id='radcallout-features-popupusage-events-example_6_remove_event_handlers-cs' />

## See Also

* [Getting Started]({%slug radcallout-getting-started%})
* [Key Properties]({%slug radcallout-key-properties%})
* [Animations]({%slug radcallout-features-animations%})
