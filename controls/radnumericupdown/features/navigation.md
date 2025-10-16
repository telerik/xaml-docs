---
title: Keyboard Support
page_title: Keyboard Support
description: Check our &quot;Keyboard Support&quot; documentation article for the RadNumericUpDown {{ site.framework_name }} control.
slug: radnumericupdown-navigation
tags: keyboard,navigation
published: True
position: 2
---

# Keyboard Support

This article explains the keyboard shortcuts present in __RadNumericUpDown__ as well as the properties that can be used for keyboard navigation.

## Keyboard Shortcuts

In order to change the value without clicking on the repeat buttons of the control, you can also use the following keyboard shortcuts:

* __MouseWheel__: whenever a RadNumericUpDown is focused you can change its value by using the mouse wheel. The step change will be equal to the value of __SmallChange__.

* __PageUp__: increments the value by one step equal to __LargeChange__.

* __PageDown__: decrements the value by one step equal to __LargeChange__.

* __Up__: increments the value by one step equal to __SmallChange__.

* __Down__: decrements the value by one step equal to __SmallChange__.

## Tab Navigation

__TabNavigationExtensions.IsTabStop__ attached property indicates whether RadNumericUpDown is included in the tab navigation cycle. __Example 1__ illustrates how to set that property in order to exclude the control from the tab navigation. The property is available since R3 2016.

__Example 1: RadNumericUpDown with TabNavigationExtensions.IsTabStop__

```XAML
	<telerik:RadNumericUpDown telerik:TabNavigationExtensions.IsTabStop="False" />
```
