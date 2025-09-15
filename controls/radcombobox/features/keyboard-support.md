---
title: Keyboard Support
page_title: Keyboard Support
description: Check our &quot;Keyboard Support&quot; documentation article for the RadComboBox {{ site.framework_name }} control.
slug: radcombobox-features-keyboard-support
tags: keyboard,support
published: True
position: 5
---

# Keyboard Support

This article explains the keyboard shortcuts present in __RadComboBox__ as well as the properties can be used for the keyboard navigation.

## Keyboard Shortcuts

Using the keyboard you can perform some of the most common tasks. This section describes the keyboard shortcuts used by the __RadComboBox__.

* __F4__ - pressing the F4 key will open the dropdown of __RadComboBox__ when it is closed. Respectively, if your __RadComboBox__'s dropdown is opened, pressing again the F4 key will __submit the selection__ and __close the dropdown__. 

* __Up\Down__ - the __Up__ and __Down Arrow__ keys have two functions depending on the state of the dropdown: 

	* When the dropdown of the __RadComboBox__ is __opened__, then pressing __Up\Down Arrows__ will change the __highlighted item__ in the list. 

	* When the dropdown of the __RadComboBox__ is __closed__, then pressing __Up\Down Arrows__ will change the [SelectedItem](#Using_the_SelectedItem). 

* __Left\Right__ - the __Left__ and __Right Arrow__ keys have the same functions as the __Up__ and __Down__. However, they will affect the selected\highlighted item only when the __RadComboBox__ is __not editable__ (the __IsEditable__ property is set to __False__). 

* __Enter__ - pressing the __Enter__ key will take effect only when the dropdown is __opened__. It does two things: commits the selection and closes the dropdown of the __RadComboBox__. 

* __Esc__ - pressing the __Esc__ key will take effect only when the dropdown is __opened__. It does two things: cancels the selection and closes the dropdown of the __RadComboBox__. 

* __Home\End__ - pressing the __Home\End__ keys will take effect only when the __RadComboBox__ is __not editable__ (the __IsEditable__ property is set to __False__). These keys have two functions depending on the dropdown state: 

	* When the dropdown of the __RadComboBox__ is __opened__, then pressing the __Home\End__ keys will change the __highlighted item__ to the first\last item in the list. 

	* When the dropdown of the __RadComboBox__ is __closed__, then pressing the __Home\End__ keys will change the __selected item__ to the first\last item in the list. 

>tipPressing the __Home\End__ keys will affect the __selected\highlighted__ item only when the __IsEditable__ property is set to __False__.

* __PageUp\PageDown__ - the __PageUp__ and __PageDown__ keys have one main function: pressing __PageUp__ or __PageDown__ will open the dropdown when it is __closed__. If the dropdown of the __RadComboBox__ is __opened__, then pressing any of these keys will change the __highlighted item__. 

>Note that all shortcuts will affect the __selected\highlighted__ item only when the __RadComboBox__ is focused.

## Properties

* __TabNavigationExtensions.IsTabStop__ attached property indicates whether editable RadComboBox (__IsEditable__ property is set to __True__) is included in the tab navigation cycle. __Example 1__ illustrates how to set that property in order to exclude the control from the tab navigation. The property is available since R3 2016.

	__Example 1: RadComboBox with TabNavigationExtensions.IsTabStop__

	```XAML
		<telerik:RadComboBox IsEditable="True" telerik:TabNavigationExtensions.IsTabStop="False" />
	```

* The __TabIndex__ property defines the index of the control in the tab navigation cycle. The lower the number is, the earlier the control will be focused while navigating using the Tab key. 

* __IsDropDownTabNavigationEnabled__ (introduced with Q1 2016) is a property of type bool that indicates whether the tab navigating inside the drop down portion of the control will be enabled. If the property is set to False the navigation between the items when Tab key gets pressed will be disabled - the default value is True. 

>__IsDropDownTabNavigationEnabled__ affects only non-editable RadComboBoxes.

## See Also

 * [Selection]({%slug radcombobox-features-selection%})

 * [Filtering]({%slug radcombobox-features-filtering%})
