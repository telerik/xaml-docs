---
title: Set CharacterCasing Property of the Input Area
page_title: Set CharacterCasing Property of the Input Area
description: Check our &quot;Set CharacterCasing Property of the Input Area&quot; documentation article for the RadComboBox {{ site.framework_name }} control.
slug: radcombobox-howto-set-character-casing
tags: set,charactercasing,property,of,the,input,area
published: True
position: 8
site_name: WPF
---

# Set CharacterCasing Property of the Input Area

The purpose of this tutorial is to show you how to set the __CharacterCasing__ property of the [InputArea]({%slug radcombobox-general-information-visual-structure%}) of an [editable]({%slug radcombobox-features-edit-modes%}) __RadComboBox__(__RadComboBox__'s __IsEditable__ property is set to __True__).

The idea in this case is to create a new __Attached Property__ in a helper class.



<snippet id='radcombobox-howto-set-character-casing-block_1-cs' />

<snippet id='radcombobox-howto-set-character-casing-block_1-vb' />


In the __OnCharacterCasingChanged()__ event handler you should perform the following step.

* Get the target combobox.

* Get the __PART_EditableTextBox__ element from its template.

* The __PART_EditableTextBox__ is a __TextBox__ and you can easily set its __CharacterCasing__ property.



<snippet id='radcombobox-howto-set-character-casing-block_2-cs' />


Finally set the property in XAML.



<snippet id='radcombobox-howto-set-character-casing-block_3-xaml' />


>tip Note that you have to set the __RadComboBox__'s __IsEditable__ property to __True__.
