---
title: SDK Examples
page_title: SDK Examples
description: SDK Examples
slug: radtoolbar-sdk-examples
tags: sdk,examples
published: True
position: 1
---

# SDK Examples

The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadToolBar__.

## List of all RadToolBar SDK examples:

{% if site.site_name == 'WPF' %}

* __[Tool bar custom styled elements](https://github.com/telerik/xaml-sdk/tree/master/ToolBar/ToolBarCustomStyledElements)__ - The ToolBarCustomStyledElements project demonstrates the correct approach for settinga custom style on element palced in RadToolbar.
The toolbar has predefined styles for radbutton, textblock, raddropdownbutton, etc. In order to edit and use successfully these styles / or to use custom styles for the elements in the toolbar you have to override the ToolBarContainerStyleSelector of the RadToolbar. Add a ContainerStyle targetting the specific control, add its predefined style and add/edit/override the properties you need.
Setting directy style on the elements in the toolbar is not correct, does not work in WPF and works partially in Silverlight.
* __[ToolBar MVVM](https://github.com/telerik/xaml-sdk/tree/master/ToolBar/ToolBarMVVM)__ - 
The  sample demonstrates the following features and custommization techniques in the RadToolBar:
	
	1) DataBinding the RadToolBar to collection of ViewModels.
	2) DataTemplaceSelector which decides what type of control to add in the toolbar depending on the ViewModel's type.
	3) Custom Styles that upgrade the predefined styles in the RadToolBar.
	
Notes: The predefined styles are located in Resources.xaml. 
	   The custom styles are located in Example.xamla and are based on the predefined ones.
	   The ColorPicker uses the predefined RadSplitButtonStyle to achieve consistency when used in Toolbar. 
	   Otherwise it will have borders, non-transparent background etc. because Toolbar does not have predefined style for RadColorPicker.
* __[Tool bar right aligned items](https://github.com/telerik/xaml-sdk/tree/master/ToolBar/ToolBarRightAlignedItems)__ - The RightAlignedItems examples demontrates the use of the RadToolBar.ItemAlignment property.
With it, you are able to position the items in the toolbar on right in horizontal toolbars and on bottom in vertical toolbars.
Please also note the use of the RadToolBar.OverflowMode property which controls whether and how the item should go into overflow area.
{% endif %}
{% if site.site_name == 'Silverlight' %}
* __[Tool bar custom styled elements](https://github.com/telerik/xaml-sdk/tree/master/ToolBar/ToolBarCustomStyledElements)__ - The ToolBarCustomStyledElements project demonstrates the correct approach for settinga custom style on element palced in RadToolbar.
The toolbar has predefined styles for radbutton, textblock, raddropdownbutton, etc. In order to edit and use successfully these styles / or to use custom styles for the elements in the toolbar you have to override the ToolBarContainerStyleSelector of the RadToolbar. Add a ContainerStyle targetting the specific control, add its predefined style and add/edit/override the properties you need.
Setting directy style on the elements in the toolbar is not correct, does not work in WPF and works partially in Silverlight.
* __[ToolBar MVVM](https://github.com/telerik/xaml-sdk/tree/master/ToolBar/ToolBarMVVM)__ - 
The  sample demonstrates the following features and custommization techniques in the RadToolBar:
	
	1) DataBinding the RadToolBar to collection of ViewModels.
	2) DataTemplaceSelector which decides what type of control to add in the toolbar depending on the ViewModel's type.
	3) Custom Styles that upgrade the predefined styles in the RadToolBar.
	
Notes: The predefined styles are located in Resources.xaml. 
	   The custom styles are located in Example.xamla and are based on the predefined ones.
	   The ColorPicker uses the predefined RadSplitButtonStyle to achieve consistency when used in Toolbar. 
	   Otherwise it will have borders, non-transparent background etc. because Toolbar does not have predefined style for RadColorPicker.
* __[Tool bar right aligned items](https://github.com/telerik/xaml-sdk/tree/master/ToolBar/ToolBarRightAlignedItems)__ - The RightAlignedItems examples demontrates the use of the RadToolBar.ItemAlignment property.
With it, you are able to position the items in the toolbar on right in horizontal toolbars and on bottom in vertical toolbars.
Please also note the use of the RadToolBar.OverflowMode property which controls whether and how the item should go into overflow area.
{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).