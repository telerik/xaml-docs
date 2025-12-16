---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadDateTimePicker {{ site.framework_name }} control.
slug: raddatetimepicker-events
tags: events
published: True
position: 7
---

# Events

This article provides more detailed information about the events exposed by the __RadDateTimePicker__ control. As it inherits from the **Control** class, it also inherits all of its public events. A full list of the inherited events can be found [here](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.control#events). In addition, the RadDateTimePicker exposes a few useful events.
        
## ParseDateTimeValue

The __ParseDateTimeValue__ event is raised in the following cases:            

* When the control loses focus.

* When you select a value from the drop-down pane.

* When you type a character in the control's input box.

The **ParseDateTimeEventHandler** receives two arguments:            

* The sender argument contains the __RadDateTimePicker__ control.

* A {% if site.site_name == 'Silverlight' %}[ParseDateTimeEventArgs](https://docs.telerik.com/devtools/silverlight/api/telerik.windows.controls.parsedatetimeeventargs){% endif %}{% if site.site_name == 'WPF' %}[ParseDateTimeEventArgs](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.parsedatetimeeventargs){% endif %} object.

>Whenever you set the __IsParsingSuccessful's__ value to False, the __ErrorTooltip__ will appear. The __Result__ value will be displayed in the __TooltipContent__ appearing while you type in text in the control's input box.  

<!-- -->

>tip See an example of implementing custom parsing logic in your __RadDateTimePicker__ control by using the ParseDateTimeValue event [here]({%slug raddatetimepicker-how-to-implement-custom-parsing%}).

## SelectionChanged

The __SelectionChanged__ event is raised in the following cases:            

* When the control loses focus.

* When you  select a value from the drop-down pane.

* When you enter some text, which can be successfully parsed and hit the Enter key on your keyboard.

>tip If the text you enter in the input box can be successfully parsed, the [Preview Tooltip]({%slug raddatetimepicker-features-preview-tooltip%}) is shown. Hitting **Enter** in this case will set the RadDateTimePicker's __SelectedValue__ property to the content visible in the tooltip. If the input cannot be parsed, the content set as the __ErrorTooltipContent__ is displayed and the value is cleared upon pressing the Enter key.

The event handler receives two arguments:

* The sender argument contains the __RadDateTimePicker__ control.

* A __SelectionChangedEventArgs__ object.

## DropDownClosed

__DropDownClosed__ occurs each time the drop-down pane gets hidden. The event handler receives two arguments:

* The sender argument contains the __RadDateTimePicker__ control.

* A __RoutedEventArgs__ object.
              
## DropDownOpened

__DropDownOpened__ occurs each time the drop-down pane gets shown. The event handler receives two arguments:

* The sender argument contains the __RadDateTimePicker__ control.

* A __RoutedEventArgs__ object.

## See Also

 * [Overview]({%slug raddatetimepicker-overview%})
 * [Visual Structure]({%slug raddatetimepicke-visual-structure%})
 * [Getting Started]({%slug raddatetimepicke-getting-started%})
 * [How to implement custom parsing]({%slug raddatetimepicker-how-to-implement-custom-parsing%})
 * [How to hide/show the pop-up pane in code]({%slug raddatetimepicker-how-to-hide-show-pop-up-in-code%})
