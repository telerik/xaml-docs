---
title: Perform Selection Only On Lost Focus or Enter Key Press
page_title: Perform Selection Only On Lost Focus or Enter Key Press
description: Check our &quot;Perform Selection Only On Lost Focus or Enter Key Press&quot; documentation article for the RadComboBox {{ site.framework_name }} control.
slug: radcombobox-how-to-perform-selection-only-lost-focus
tags: how,to,perform,selection,only,lost,focus,enter,key
published: True
position: 0
---

# Perform Selection Only On Lost Focus or Enter Key Press

By default, when an item is matched by the text entered in an editable RadComboBox, it will instantaneously be set as the **SelectedItem** of the control. The same result is observed when navigating through the items with the keyboard. Setting the **UpdateSelectionOnLostFocus** property to **True** overrides this behavior and the selection will only be updated when the focus is moved out of the control or the **Enter** key is pressed.

>important The property affects only an editable RadComboBox with single selection.

__Example 1: Set the UpdateSelectionOnLostFocus property__

```XAML
	<telerik:RadComboBox IsEditable="True" UpdateSelectionOnLostFocus="True">
		<telerik:RadComboBoxItem Content="Item 1" />
		<telerik:RadComboBoxItem Content="Item 2" />
		<telerik:RadComboBoxItem Content="Item 3" />
	</telerik:RadComboBox>
```

When the __UpdateSelectionOnLostFocus__ property is set to true, you have to take into account the following scenarios when the control loses focus or the __Enter__ key is pressed:

* __When SelectedItem/SelectedValue property is null__: When the typed text matches any of the items in the RadComboBox, the **SelectedItem/SelectedValue** property will be set to the first item.

* __When SelectedItem/SelectedValue property is null__: When the typed text does not match any of the items in the RadComboBox, the **SelectedItem/SelectedValue** property will be **null**, and the **Text** property of the control will hold the typed text.

* __When SelectedItem/SelectedValue property is not null__ : When the typed text does not match any of the items in the RadComboBox, the **SelectedItem/SelectedValue** property will be set to **null**, and the **Text** property of the control will be cleared.

## UpdateSelectionOnLostFocus and UpdateTextOnLostFocus

With the __2021 R1 LIB 322__ version of our controls, we have introduced the __UpdateTextOnLostFocus__ property to control whether the __Text__ property should be updated when the control loses focus. The default value of this property is __True__.

When the __UpdateSelectionOnLostFocus__ property is set to true and __UpdateTextOnLostFocus__ property is set to false, you have to take into account the following scenarios when the control loses focus or the __Enter__ key is pressed:

* __When SelectedItem/SelectedValue property is null__: When the typed text matches any of the items in the RadComboBox, the **SelectedItem/SelectedValue** property will be set to the first item. The **Text** property will hold the text of the selected item.

* __When SelectedItem/SelectedValue property is null__: When the typed text does not match any of the items in the RadComboBox, the **SelectedItem/SelectedValue** property will be **null**, and the **Text** property of the control will hold the typed text.

* __When SelectedItem/SelectedValue property is not null__: When the typed text does not match any of the items in the RadComboBox, the **SelectedItem/SelectedValue** property will be set to **null**, and the **Text** property of the control will hold the typed text.


>You can have a look at the **Configurator** demo from the [{{ site.framework_name }} Controls Samples]({% if site.framework_name == 'Silverlight' %}https://demos.telerik.com/silverlight/#ComboBox/Configurator{% else %}https://demos.telerik.com/wpf{% endif %}) to get a better understanding of how the **UpdateSelectionOnLostFocus** property works.

## See Also

* [AutoComplete]({%slug radcombobox-features-autocomplete%})
* [Edit Modes]({%slug radcombobox-features-edit-modes%})
{% if site.framework_name == 'WPF' %}* [Multiple Selection]({%slug radcombobox-features-multiple-selection%}){% endif %}
