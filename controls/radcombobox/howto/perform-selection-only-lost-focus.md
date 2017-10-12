---
title: Perform Selection Only On Lost Focus or Enter Key Press
page_title: Perform Selection Only On Lost Focus or Enter Key Press
description: Perform Selection Only On Lost Focus or Enter Key Press
slug: radcombobox-how-to-perform-selection-only-lost-focus
tags: how,to,perform,selection,only,lost,focus,enter,key
published: True
position: 0
---

# Perform Selection Only On Lost Focus or Enter Key Press

By default, when an item is matched by the text entered in an editable RadComboBox, it will instantaneously be set as the **SelectedItem** of the control. The same result is observed when navigating through the items with the keyboard. Setting the **UpdateSelectionOnLostFocus** property to **True** overrides this behavior and the selection will only be updated when the focus is moved out of the control or the **Enter** key is pressed.

>important The property affects only an editable RadComboBox with single selection.

#### __[XAML] Example 1: Set the UpdateSelectionOnLostFocus property__

{{region xaml-radcombobox-how-to-perform-selection-only-lost-focus_0}}
	<telerik:RadComboBox IsEditable="True" UpdateSelectionOnLostFocus="True">
		<telerik:RadComboBoxItem Content="Item 1" />
		<telerik:RadComboBoxItem Content="Item 2" />
		<telerik:RadComboBoxItem Content="Item 3" />
	</telerik:RadComboBox>
{{endregion}}

>You can have a look at the **Configurator** demo from the [{{ site.framework_name }} Controls Samples]({% if site.framework_name == 'Silverlight' %}https://demos.telerik.com/silverlight/#ComboBox/Configurator{% else %}https://demos.telerik.com/wpf{% endif %}) to get a better understanding of how the **UpdateSelectionOnLostFocus** property works.

## See Also

* [AutoComplete]({%slug radcombobox-features-autocomplete%})
* [Edit Modes]({%slug radcombobox-features-edit-modes%})
{% if site.framework_name == 'WPF' %}* [Multiple Selection]({%slug radcombobox-features-multiple-selection%}){% endif %}