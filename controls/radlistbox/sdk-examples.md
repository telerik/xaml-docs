---
title: SDK Examples
page_title: SDK Examples
description: SDK Examples
slug: radlistbox-sdk-examples
tags: sdk,examples
published: True
position: 3
---

# SDK Examples

The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadListBox__.

## List of all RadListBox SDK examples:

{% if site.site_name == 'WPF' %}

* __[Custom drag visual style](https://github.com/telerik/xaml-sdk/tree/master/ListBox/CustomDragVisualStyle)__ - This example demonstrates how to create a custom DragVisualProvider in order to change its Foreground, Background, BorderBrush and Template for Silverlight and WPF.
* __[Custom drop cue with wrap panel](https://github.com/telerik/xaml-sdk/tree/master/ListBox/CustomDropCueWithWrapPanel)__ - This example demonstrates how to customize the LinearDropVisualProvider of RadListBox. In the example you can notice that when dragging an item in the ListBox the DropVisual is different.
* __[Custom list box drag drop behavior](https://github.com/telerik/xaml-sdk/tree/master/ListBox/CustomListBoxDragDropBehavior)__ - This example demonstrates how to customize ListBoxDragDropBehavior of RadListBox. In the example the right ListBox control has the custom MyListBoxDragDropBehavior and when items are dragged/dropped from/in it an Alert massage is shown with the items details.
* __[Differently Colored Unfocused SelectedItems](https://github.com/telerik/xaml-sdk/tree/master/ListBox/DifferentlyColoredUnfocusedSelectedItems)__ - 
This sample project demonstates how to change the background color of RadListBoxItems when RadListBox loses the focus.
* __[Data conversion between two RadListBox controls](https://github.com/telerik/xaml-sdk/tree/master/ListBox/DragDropDataConversion)__ - 
This example demonstrates how to convert data when using drag and drop between two RadListBox controls. The left RadListBox control is bound to a collection of Customer object and the right one is bound to a collection of Project objects. The conversion is handled by two custom DataConverters.
* __[Drag and drop with ScheduleView](https://github.com/telerik/xaml-sdk/tree/master/ListBox/DragDropWithScheduleView)__ - This example demonstrates how to achieve drag and drop functionality between RadListBox and RadScheduleView by creating AppointmentToCustomerConverter and CustomScheduleViewDragDropBehaviorfor Silverlight and WPF.
* __[Modified ListBoxDragVisualStyle](https://github.com/telerik/xaml-sdk/tree/master/ListBox/ModifyListBoxDragVisualStyle)__ - 
This example demonstrates how to create a modified ListBoxDragVisualStyle in order to remove the before and after specifiers for Silverlight and WPF.
* __[Create attached property for SelectedItems](https://github.com/telerik/xaml-sdk/tree/master/ListBox/SelectedItems)__ - IMPORTANT: With the release of Telerik UI for WPF Q1 2015 there is a new functionality for achieving MVVM scenarios where the SelectedItems of the RadListBox should be bound to a collection from the view model. More details can be found in our online documentation: - For WPF here: http://docs.telerik.com/devtools/wpf/controls/radlistbox/features/selecteditemssource- For Silverlight here: http://docs.telerik.com/devtools/silverlight/controls/radlistbox/features/selecteditemssource This example demonstrates how to create an attached property that could be used in order to bind a collection of objects to the control and use it as a collection of selected items for Silverlight and WPF.
* __[How to bind SelectedItems in MVVM](https://github.com/telerik/xaml-sdk/tree/master/ListBox/SelectedItemsSource)__ - 
This example demonstrates how to use the built-in ListBoxSelectedItemsBehavior of the RadListBox control in order to bind a collection of objects which will be two way synced with the control's SelectedItems collection.
{% endif %}
{% if site.site_name == 'Silverlight' %}
* __[Custom drag visual style](https://github.com/telerik/xaml-sdk/tree/master/ListBox/CustomDragVisualStyle)__ - This example demonstrates how to create a custom DragVisualProvider in order to change its Foreground, Background, BorderBrush and Template for Silverlight and WPF.
* __[Custom drop cue with wrap panel](https://github.com/telerik/xaml-sdk/tree/master/ListBox/CustomDropCueWithWrapPanel)__ - This example demonstrates how to customize the LinearDropVisualProvider of RadListBox. In the example you can notice that when dragging an item in the ListBox the DropVisual is different.
* __[Custom list box drag drop behavior](https://github.com/telerik/xaml-sdk/tree/master/ListBox/CustomListBoxDragDropBehavior)__ - This example demonstrates how to customize ListBoxDragDropBehavior of RadListBox. In the example the right ListBox control has the custom MyListBoxDragDropBehavior and when items are dragged/dropped from/in it an Alert massage is shown with the items details.
* __[Differently Colored Unfocused SelectedItems](https://github.com/telerik/xaml-sdk/tree/master/ListBox/DifferentlyColoredUnfocusedSelectedItems)__ - 
This sample project demonstates how to change the background color of RadListBoxItems when RadListBox loses the focus.
* __[Data conversion between two RadListBox controls](https://github.com/telerik/xaml-sdk/tree/master/ListBox/DragDropDataConversion)__ - 
This example demonstrates how to convert data when using drag and drop between two RadListBox controls. The left RadListBox control is bound to a collection of Customer object and the right one is bound to a collection of Project objects. The conversion is handled by two custom DataConverters.
* __[Drag and drop with ScheduleView](https://github.com/telerik/xaml-sdk/tree/master/ListBox/DragDropWithScheduleView)__ - This example demonstrates how to achieve drag and drop functionality between RadListBox and RadScheduleView by creating AppointmentToCustomerConverter and CustomScheduleViewDragDropBehaviorfor Silverlight and WPF.
* __[Modified ListBoxDragVisualStyle](https://github.com/telerik/xaml-sdk/tree/master/ListBox/ModifyListBoxDragVisualStyle)__ - 
This example demonstrates how to create a modified ListBoxDragVisualStyle in order to remove the before and after specifiers for Silverlight and WPF.
* __[Create attached property for SelectedItems](https://github.com/telerik/xaml-sdk/tree/master/ListBox/SelectedItems)__ - IMPORTANT: With the release of Telerik UI for WPF Q1 2015 there is a new functionality for achieving MVVM scenarios where the SelectedItems of the RadListBox should be bound to a collection from the view model. More details can be found in our online documentation: - For WPF here: http://docs.telerik.com/devtools/wpf/controls/radlistbox/features/selecteditemssource- For Silverlight here: http://docs.telerik.com/devtools/silverlight/controls/radlistbox/features/selecteditemssource This example demonstrates how to create an attached property that could be used in order to bind a collection of objects to the control and use it as a collection of selected items for Silverlight and WPF.
* __[How to bind SelectedItems in MVVM](https://github.com/telerik/xaml-sdk/tree/master/ListBox/SelectedItemsSource)__ - 
This example demonstrates how to use the built-in ListBoxSelectedItemsBehavior of the RadListBox control in order to bind a collection of objects which will be two way synced with the control's SelectedItems collection.
{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).