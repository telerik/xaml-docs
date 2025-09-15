---
title: Edit Modes
page_title: Edit Modes
description: Check our &quot;Edit Modes&quot; documentation article for the RadComboBox {{ site.framework_name }} control.
slug: radcombobox-features-edit-modes
tags: edit,modes
published: True
position: 1
---

# Edit Modes

__RadComboBox__ can be editable, allowing the user to type in its text box, or non-editable, where the text box is hidden. In addition, you could make the text box read-only, in order to keep the editable look, and in the same time to prevent the user from typing. The __RadComboBox__'s API exposes several properties, allowing you to configure these modes.

This topic contains the following sections:

* [Editable\Non-Editable RadComboBox](#editable\non-editable-radcombobox)

* [Editable and read-only RadComboBox](#editable-and-read-only-radcombobox)

* [StaysOpenOnEdit](#staysopenonedit)

* [Disable the keyboard selection when in edit mode](#disable-the-keyboard-selection-when-in-edit-mode)

>tipBefore reading this tutorial you should get familiar with the [Visual Structure]({%slug radcombobox-general-information-visual-structure%}) of the __RadComboBox__ control.

## Editable\Non-Editable RadComboBox

In order to make your __RadComboBox__ editable, you should set its __IsEditable__ property to __True__.

#### __XAML__

```XAML
	<telerik:RadComboBox x:Name="radComboBox" IsEditable="True"/>
```


>tipWhen making your __RadComboBox__ editable, you could better distinguish the benefit of the [AutoComplete]({%slug radcombobox-features-autocomplete%}). 

By default, the __RadComboBox__ is non-editable. Which means that its __Input Area__ is hidden.

>tipIf your __RadComboBox__ is non-editable, you could still benefit from the [AutoComplete]({%slug radcombobox-features-autocomplete%}) feature, but instead of autocomplete your items will be auto-selected.

>When your __RadComboBox__ is editable and has ItemTemplate defined, you should set the [telerik:TextSearch.TextPath]({%slug radcombobox-features-selection%}) property to point to the required property of the bussiness object which will be shown in the input field.

## Editable and Read-Only RadComboBox

You have the ability to make your __RadComboBox__ __editable__, but its __text box__ to be __read-only__. Thus you will keep the editable look, but will prevent the user from typing. The only thing you should do is to set both of the properties __IsEditable__ and __IsReadOnly__ to __True__.

{% if site.framework_name == 'WPF' %}
> The RadComboBox does not have a visual _readonly_ state. In fact, it will have its normal look when the __IsReadOnly__ property is __True__. Additionally, setting the ReadOnlyBackgroundColor and ReadOnlyBorderColor, available in all themes released after [Office2016]({%slug common-styling-appearance-office2016-theme%}#readonlybackgroundbrush-and-readonlyborderbrush), will have no effect on the control.
{% endif %}

__Example 1: Setting the IsEditable and IsReadOnly to True__

```XAML
	<telerik:RadComboBox x:Name="radComboBox" IsEditable="True" IsReadOnly="True"/>
```

>tipSetting the __RadComboBox__'s __IsReadOnly__ property to __True__ will affect the __RadComboBox__ only when it is __editable__.

## StaysOpenOnEdit

The __RadComboBox__ exposes a boolean property named __StaysOpenOnEdit__. When this property is set to __True__, a __RadComboBox__ that is opened and displays a drop-down control will remain open when the user clicks the __TextBox__ (__InputArea__).

__Example 2: Setting the StaysOpenOnEdit to True__

```XAML
	<telerik:RadComboBox x:Name="radComboBox" IsEditable="True" StaysOpenOnEdit="True"/>
```

>It is important to remember, that setting the __RadComboBox__'s __StaysOpenOnEdit__ to __True__ will affect the __RadComboBox__ only when it is __editable__.

## Disable the keyboard selection when in edit mode

When the __IsEditable__ property is set to __True__ and the DropDown is opened, navigating with the keyboard actually changes the selection. This is not the behavior when the __IsEditable__ is __False__. By setting the __CanKeyboardNavigationSelectItems__ to __False__ the keyboard navigation will not change the selection when the __IsEditable__ is __True__.

__Example 3: Setting the CanKeyboardNavigationSelectItems to False__

```XAML 
	<telerik:RadComboBox x:Name="radComboBox" IsEditable="True" CanKeyboardNavigationSelectItems="False"/>
```

## See Also  

 * [Selection]({%slug radcombobox-features-selection%})
 * [Filtering]({%slug radcombobox-features-filtering%})
