---
title: Visual Structure
page_title: Visual Structure
description: The article demonstrates the visual structure of the RadCardView component.
slug: radcardview-visual-structure
tags: visual, structure, cardview
published: True
position: 1
---

# {{ site.framework_name }} RadCardView Visual Structure

This section defines terms and concepts used in the scope of the __RadCardView__ control with which you have to get familiar before you continue to read its documentation. They can also be helpful when contacting our support service in order to describe your issue better.

![{{ site.framework_name }} RadCardView Visual Structure](images/radcardview-visual-structure-0.png)

* __Card__: An element representing an item from the __ItemsSource__ of the control.

* __Card Header__: Displays the header of the card.

* __Card Expander Button__: Displays a button that allows you to expand or collapse the card.

* __Data Field__: Displays a label (left text) and a value presenter (right text) representing the corresponding property from the underlying data items. 

* __Data Field Editor__: Displays an editor control when the __Data Field__ is in edit mode.

* __Group__: Hosts __Card__ elements which share the same data group.

* __Group Header__: Displays the header of the group.

* __Group Expander Button__:  Displays a button that allows you to expand or collapse the group.

* __Group Member Button__: Displays the name of the property used for grouping. Also, clicking on it allows you to sort the groups. 

* __Group Panel__: Hosts __Group Member Buttons__ and the __Data Field Descriptors Button__. Also, you can drop data field descriptors from the drop down list to the group panel.

* __Filters Button__: A button that opens a popup with the available filters for the corresponding data field descriptor.

* __Data Field Descriptor__: Displays the property name, the sort state and filters of the associated data field descriptor object.

* __Sort Button__: Sorts the items by the associated data field descriptor's __DataMemberBinding__.

* __Filtering Control__: Displays a popup with the filters available for the corresponding data field descriptor.

>tip Get started with the control with its [Getting Started]({%slug radcardview-getting-started%}) help article that shows how to use it in a basic scenario.

## See Also  
* [Getting Started]({%slug radcardview-getting-started%})
* [Filtering]({%slug radcardview-features-filtering%})
* [Grouping]({%slug radcardview-features-grouping%})
* [Sorting]({%slug radcardview-features-sorting%})
