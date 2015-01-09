---
title: Events
page_title: Events
description: Events
slug: radoutlookbar-events
tags: events
published: True
position: 1
---

# Events

## Events list

__RadOutlookBar__ exposes the following events:

* __SelectionChanged__ - raised when the selected item is changed. The __SelectionChanged__ event handler receives two arguments:
	* The sender argument contains the __RadOutlookBar__.
	* The second argument is __RadSelectionChangedEventArgs__ containing all additional information about the event:
		* __AddedItems__ - an __IList__ collection of the selected items
		* __RemovedItems__ - an __IList__ collection of the unselected items 

* __PreviewSelectionChanged__ - raised before the selected item is change allowing the user to cancel the selection. The arguments of the PreviewSelectionChanged handler are the same as for the SelectionChanged

* __ItemPositionChanged__ - raised when item has changed its position - for example when an item goes to the Minimized area from the Active area. The __ItemPositionChanged__ event handler receives two arguments:
	* The sender argument contains the __RadOutlookBar__.
	* The second argument is __PositionChangedEventArgs__ containing all additional information about the event:
		* __OldPosition__ - an __OutlookBarItemPosition__ enum value containing the old position 
		* __NewPosition__- an __OutlookBarItemPosition__ enum value containing the new position

* __DropDownOpened__ - raised when the overflow dropdown has been opened. The __DropDownOpened__ event handler receives two arguments:
	* The sender argument contains the __RadOutlookBar__.
	* The second argument is __Telerik.Windows.Controls.DropDownEventArgs__ containing all additional information about the event:
		* __DropDownItemsSource__ - an __IList__ collection of the items in the drop down                  

* __DropDownClosed__  - raised when the overflow dropdown has been closed. The __DropDownClosed__ event handler receives two arguments:
	* The sender argument contains the __RadOutlookBar__.
	* The second argument is __Telerik.Windows.Controls.DropDownEventArgs__ containing all additional information about the event:
		* __DropDownItemsSource__ - an __IList__ collection of the items in the drop down

* __Minimized__ - raised when the RadOutlookBar is minimized. The __Minimized__ event handler receives two arguments:
	* The sender argument contains the __RadOutlookBar__.
	* The second argument is __RoutedEventArgs__ containing all additional information about the event

* __Restored__ - raised when the RadOutlookBar is maximized (restored). The __Restored__ event handler receives two arguments:
	* The sender argument contains the __RadOutlookBar__.
	* The second argument is __RoutedEventArgs__ containing all additional information about the event