---
title: Edit Modes
page_title: Edit Modes
description: Edit Modes
slug: radcombobox-features-edit-modes
tags: edit,modes
published: True
position: 1
---

# Edit Modes

The __RadComboBox__ can be editable, allowing the user to type in its text box, or non-editable, where the text box is hidden. In addition, you could make the text box read-only, in order to keep the editable look, and in the same time to prevent the user from typing. The __RadComboBox__'s API exposes several properties, allowing you to configure these modes.

This topic contains the following sections:

* [Editable\Non-Editable RadComboBox](#editable\non-editable-radcombobox)

* [Editable and read-only RadComboBox](#editable-and-read-only-radcombobox)

* [StaysOpenOnEdit](#staysopenonedit)

>tipBefore reading this tutorial you should get familiar with the [Visual Structure]({%slug radcombobox-general-information-visual-structure%}) of the __RadComboBox__ control.

## Editable\Non-Editable RadComboBox

In order to make your __RadComboBox__ editable, you should set its __IsEditable__ property to __True__.

#### __XAML__

{{region radcombobox-features-edit-modes_0}}
	<telerik:RadComboBox x:Name="radComboBox" IsEditable="True"/>
{{endregion}}


>tipWhen making your __RadComboBox__ editable, you could better distinguish the benefit of the [AutoComplete]({%slug radcombobox-features-autocomplete%}). 

By default, the __RadComboBox__ is non-editable. Which means that its __Input Area__ is hidden.

>tipIf your __RadComboBox__ is non-editable, you could still benefit from the [AutoComplete]({%slug radcombobox-features-autocomplete%}) feature, but instead of autocomplete your items will be auto-selected.

>When your __RadComboBox__ is editable and has ItemTemplate defined, you should set the [telerik:TextSearch.TextPath]({%slug radcombobox-features-selection%}) property to point to the required property of the bussiness object which will be shown in the input field.

## Editable and Read-Only RadComboBox

You have the ability to make your __RadComboBox__ __editable__, but its __text box__ to be __read-only__. Thus you will keep the editable look, but will prevent the user from typing. The only thing you should do is to set both of the properties __IsEditable__ and __IsReadOnly__ to __True__.

#### __XAML__

{{region radcombobox-features-edit-modes_1}}
	<telerik:RadComboBox x:Name="radComboBox" IsEditable="True" IsReadOnly="True"/>
{{endregion}}

>tipSetting the __RadComboBox__'s __IsReadOnly__ property to __True__ will affect the __RadComboBox__ only when it is __editable__.

## StaysOpenOnEdit

The __RadComboBox__ exposes a boolean property named __StaysOpenOnEdit__. When this property is set to __True__, a __RadComboBox__ that is opened and displays a drop-down control will remain open when the user clicks the __TextBox__ (__InputArea__).

#### __XAML__

{{region radcombobox-features-edit-modes_2}}
	<telerik:RadComboBox x:Name="radComboBox" IsEditable="True" StaysOpenOnEdit="True"/>
{{endregion}}

>It is important to remember, that setting the __RadComboBox__'s __StaysOpenOnEdit__ to __True__ will affect the __RadComboBox__ only when it is __editable__.

# See Also

 * [Selection]({%slug radcombobox-features-selection%})

 * [DataBinding]({%slug radcombobox-features-databinding%})

 * [Filtering]({%slug radcombobox-features-filtering%})
