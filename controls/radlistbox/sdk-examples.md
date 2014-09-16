---
title: SDK Examples
page_title: SDK Examples
description: SDK Examples
slug: radlistbox-sdk-examples
tags: sdk,examples
publish: True
position: 3
---

# SDK Examples



The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadListBox__.

## List of all RadListBox SDK examples:{% if site.site_name == 'WPF' %}

* __Custom drag visual style__ - This example demonstrates how to create a custom DragVisualProvider in order to change its Foreground, Background, BorderBrush and Template for Silverlight and WPF.

* __Custom drop cue with wrap panel__ - This example demonstrates how to customize the LinearDropVisualProvider of RadListBox. In the example you can notice that when dragging an item in the ListBox the DropVisual is different.

* __Custom list box drag drop behavior__ - This example demonstrates how to customize ListBoxDragDropBehavior of RadListBox. In the example the right ListBox control has the custom MyListBoxDragDropBehavior and when items are dragged/dropped from/in it an Alert massage is shown with the items details.

* __Data conversion between two RadListBox controls__ - 
This example demonstrates how to convert data when using drag and drop between two RadListBox controls. The left RadListBox control is bound to a collection of Customer object and the right one is bound to a collection of Project objects. The conversion is handled by two custom DataConverters.

* __Drag and drop with ScheduleView__ - This example demonstrates how to achieve drag and drop functionality between RadListBox and RadScheduleView by creating AppointmentToCustomerConverter and CustomScheduleViewDragDropBehaviorfor Silverlight and WPF.

* __Modified ListBoxDragVisualStyle__ - 
This example demonstrates how to create a modified ListBoxDragVisualStyle in order to remove the before and after specifiers for Silverlight and WPF.

* __Selected items__ - This example demonstrates how to create an attached property that could be used in order to bind a collection of objects to the control  and use it as a collection of selected items for Silverlight and WPF.{% endif %}{% if site.site_name == 'Silverlight' %}

* __Custom drag visual style__ - This example demonstrates how to create a custom DragVisualProvider in order to change its Foreground, Background, BorderBrush and Template for Silverlight and WPF.

* __Custom drop cue with wrap panel__ - This example demonstrates how to customize the LinearDropVisualProvider of RadListBox. In the example you can notice that when dragging an item in the ListBox the DropVisual is different.

* __Custom list box drag drop behavior__ - This example demonstrates how to customize ListBoxDragDropBehavior of RadListBox. In the example the right ListBox control has the custom MyListBoxDragDropBehavior and when items are dragged/dropped from/in it an Alert massage is shown with the items details.

* __Data conversion between two RadListBox controls__ - 
This example demonstrates how to convert data when using drag and drop between two RadListBox controls. The left RadListBox control is bound to a collection of Customer object and the right one is bound to a collection of Project objects. The conversion is handled by two custom DataConverters.

* __Drag and drop with ScheduleView__ - This example demonstrates how to achieve drag and drop functionality between RadListBox and RadScheduleView by creating AppointmentToCustomerConverter and CustomScheduleViewDragDropBehaviorfor Silverlight and WPF.

* __Modified ListBoxDragVisualStyle__ - 
This example demonstrates how to create a modified ListBoxDragVisualStyle in order to remove the before and after specifiers for Silverlight and WPF.

* __Selected items__ - This example demonstrates how to create an attached property that could be used in order to bind a collection of objects to the control  and use it as a collection of selected items for Silverlight and WPF.{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).

# See Also
