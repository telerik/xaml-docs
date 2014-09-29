---
title: Events
page_title: Events
description: Events
slug: raddatetimepicker-events
tags: events
published: True
position: 7
---

# Events

Here is more detailed information about the events exposed by the __RadDateTimePicker__ control:
        
## ParseDateTimeValue

The __ParseDateTimeValue__ event is raised in the following cases:            

* On lost focus

* When you select a value from the drop-down pane

* When you type a character in the control's input box

The event handler receives two arguments:            

* The sender argument contains the __RadDateTimePicker__ control.

* A {% if site.site_name == 'Silverlight' %}[ParseDateTimeEventArgs](http://www.telerik.com/help/silverlight/allmembers_t_telerik_windows_controls_parsedatetimeeventargs.html){% endif %}{% if site.site_name == 'WPF' %}[ParseDateTimeEventArgs](http://www.telerik.com/help/wpf/allmembers_t_telerik_windows_controls_parsedatetimeeventargs.html){% endif %} object.

>Whenever you set the __IsParsingSuccessful's__ value to False, the __ErrorTooltip__ will appear. The __Result__ value will be displayed in the __TooltipContent__ appearing while you type in text in the control's input box.  

<!-- -->

>tipSee an example of having a custom parsing logic in your __RadDateTimePicker__ control [here]({%slug raddatetimepicker-how-to-implement-custom-parsing%}).

## SelectionChanged

The __SelectionChanged__ event is raised in the following cases:            

* On lost focus

* When you  select a value from the drop-down pane

* When you enter some text, which can be successfully parsed and hit the Enter key on your keyboard.

>tip The text you enter in the input box can be successfully parsed any time except when you see the __ErrorTooltip__. Hitting Enter in this cases will set the __RadDateTimePicker's SelectedValue__ property to the content visible in the [Preview Tooltip.]({%slug raddatetimepicker-features-preview-tooltip%})

The event handler receives two arguments:

* The sender argument contains the __RadDateTimePicker__ control.

* A __SelectionChangedEventArgs__ object.

## DropDownClosed

__DropDownClosed__ occurs each time the drop-down pane gets hidden. The event handler receives two arguments:

* The sender argument contains the __RadDateTimePicker__ control.

* A __RoutedEventArgs__ object
              
## DropDownOpened

__DropDownOpened__ occurs each time the drop-down pane gets shown. The event handler receives two arguments:

* The sender argument contains the __RadDateTimePicker__ control.

* A __RoutedEventArgs__ object

# See Also

 * [Overview]({%slug raddatetimepicker-overview%})

 * [Visual Structure]({%slug raddatetimepicke-visual-structure%})

 * [Getting Started]({%slug raddatetimepicke-getting-started%})

 * [How to implement custom parsing]({%slug raddatetimepicker-how-to-implement-custom-parsing%})

 * [How to hide/show the pop-up pane in code]({%slug raddatetimepicker-how-to-hide-show-pop-up-in-code%})
