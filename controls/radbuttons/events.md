---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadButtons {{ site.framework_name }} control.
slug: radbuttons-events
tags: events
published: True
position: 5
---

# Events

The __RadButtons__ raise the following specific events:

__Common__

* __Click__: Occurs each time when the button gets clicked. The event handler receives two arguments: 
    * The sender argument contains the button. This argument is of type object, but can be cast to the respective button type.
    * A System.Windows.__RoutedEventArgs__ object.    

* __Activate__: Occurs each time when the button gets clicked. The event handler receives two arguments: 
    * The sender argument contains the button. This argument is of type object, but can be cast to the respective button type.
    * A Telerik.Windows.__RoutedEventArgs__ object.

__RadDropDownButton__

* __DropDownClosed__: Occurs when the drop down area gets closed. The event handler receives two arguments: 
    * The sender argument contains the button. This argument is of type object, but can be cast to the __RadDropDownButton__ type.
    * A System.Windows.__RoutedEventArgs__ object.

* __DropDownOpened__: Occurs when the drop down area gets opened. The event handler receives two arguments: 
    * The sender argument contains the button. This argument is of type object, but can be cast to the __RadDropDownButton__ type.
    * A System.Windows.__RoutedEventArgs__ object.

* __DropDownOpening__: Occurs before the drop down area gets opened. The event handler receives two arguments: 
    * The sender argument contains the button. This argument is of type object, but can be cast to the __RadDropDownButton__ type.
    * A System.Windows.__RoutedEventArgs__ object.

__RadRadioButton__

* __Checked__: Occurs when the button gets checked. The event handler receives two arguments: 
    * The sender argument contains the button. This argument is of type object, but can be cast to the __RadRadioButton__ type.
    * A System.Windows.__RoutedEventArgs__ object.

* __Unchecked__: Occurs when the button gets unchecked. The event handler receives two arguments: 
    * The sender argument contains the button. This argument is of type object, but can be cast to the __RadRadioButton__ type.
    * A System.Windows.__RoutedEventArgs__ object.

__RadSplitButton__

* __Checked__: Occurs when the button gets checked. The event handler receives two arguments: 
    * The sender argument contains the button. This argument is of type object, but can be cast to the __RadSplitButton__ type.
    * A System.Windows.__RoutedEventArgs__ object.

* __Unchecked__: Occurs when the button gets unchecked. The event handler receives two arguments: 
    * The sender argument contains the button. This argument is of type object, but can be cast to the __RadSplitButton__ type.
    * A System.Windows.__RoutedEventArgs__ object.

* __DropDownClosed__: Occurs when the drop down area gets closed. The event handler receives two arguments: 
    * The sender argument contains the button. This argument is of type object, but can be cast to the __RadSplitButton__ type.
    * A System.Windows.__RoutedEventArgs__ object.

* __DropDownOpened__: Occurs when the drop down area gets opened. The event handler receives two arguments: 
    * The sender argument contains the button. This argument is of type object, but can be cast to the __RadSplitButton__ type.
    * A System.Windows.__RoutedEventArgs__ object.

* __DropDownOpening__: Occurs before the drop down area gets opened. The event handler receives two arguments: 
    * The sender argument contains the button. This argument is of type object, but can be cast to the __RadSplitButton__ type.
    * A System.Windows.__RoutedEventArgs__ object.

__RadToggleButton and RadToggleSwitchButton__

* __Checked__: Occurs when the button gets checked. The event handler receives two arguments: 
    * The sender argument contains the button. This argument is of type object, but can be cast to the __RadToggleButton__ type.
    * A System.Windows.__RoutedEventArgs__ object.

* __Indeterminate__: Occurs when the button goes in the Indeterminate state (if the button is in the three state mode). The event handler receives two arguments: 
    * The sender argument contains the button. This argument is of type object, but can be cast to the __RadToggleButton__ type.
    * A System.Windows.__RoutedEventArgs__ object.

* __Unchecked__: Occurs when the button gets unchecked. The event handler receives two arguments: 
    * The sender argument contains the button. This argument is of type object, but can be cast to the __RadToggleButton__ type.
    * A System.Windows.__RoutedEventArgs__ object.

## See Also
 * [Visual Structure]({%slug radbuttons-visual-structure%})
 * [Getting Started]({%slug radbuttons-getting-started%})
 * [Commands]({%slug radbuttons-features-commands%})