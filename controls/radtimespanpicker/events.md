---
title: Events
page_title: Events
description: Events
slug: radtimespanpicker-events-overview
tags: Events
published: True
position: 4
---

# Events

This topic covers the specific events exposed by __RadTimeSpanPicker__ control.

__RadTimeSpanPicker__ control raises the following specific events:

* __ValueChanged__ - occurs when the __Value__ property is changed.

	* The sender argument is an instance of __RadTimeSpanPicker__, thus can be cast to RadTimeSpanPicker type.

	* A __ValueChangedEventArgs__ object - the event arguments that contain the OldValue and the NewValue (both of type TimeSpan).

* __DropDownClosed__ - occurs when the __DropDownButton__ is closed.

* __DropDownOpend__ - occurs when the __DropDownButton__ is opened.

	Both events receive two arguments:

	* Again the sender argument is an instance of __RadTimeSpanPicker__, thus can be cast to __RadTimeSpanPicker__ type

	* A __RoutedEventArgs__ object.

# See Also

 * [Getting Started]({%slug radtimespanpicker-getting-started%})
 
 * [Visual Structure]({%slug radtimespanpicker-visual-structure%})