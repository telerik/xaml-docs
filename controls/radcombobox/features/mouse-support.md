---
title: Mouse Support
page_title: Mouse Support
description: Check our &quot;Mouse Support&quot; documentation article for the RadComboBox {{ site.framework_name }} control.
slug: radcombobox-features-mouse-support
tags: mouse,support
published: True
position: 6
---

# Mouse Support

This article explains the mouse support of the control.

## Using MouseWheel

__RadComboBox__ responses to the mouse wheel scrolling. There are two possible cases:

* When the dropdown of the __RadComboBox__ is __closed__, then rotating the mouse wheel will __change__ the selected item.

* When the dropdown of the __RadComboBox__ is __opened__, then rotating the mouse wheel will __not change__ the highlighted item.

>Note that in order for the __RadComboBox__ to response to the mouse wheel scrolling, the mouse cursor should be __over__ the __combo box__.

## Disable MouseWheel Scrolling

In order to disable the mouse wheel scrolling, you should set the __RadComboBox__'s __IsMouseWheelEnabled__ property to __False__.

#### __XAML__

```XAML
	<telerik:RadComboBox x:Name="radComboBox" IsMouseWheelEnabled="False"/>
```

## See Also

 * [Edit Modes]({%slug radcombobox-features-edit-modes%})

 * [AutoComplete]({%slug radcombobox-features-autocomplete%})

 * [Selection]({%slug radcombobox-features-selection%})
