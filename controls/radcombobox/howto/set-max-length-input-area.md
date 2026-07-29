---
title: Set MaxLength Property of the Input Area
page_title: Set MaxLength Property of the Input Area
description: Check our &quot;Set MaxLength Property of the Input Area&quot; documentation article for the RadComboBox {{ site.framework_name }} control.
slug: radcombobox-howto-set-max-length-input-area
tags: set,maxlength,property,of,the,input,area
published: True
position: 7
---

# Set MaxLength Property of the Input Area

The purpose of this tutorial is to show you how to set the __MaxLength__ property of the [InputArea]({%slug radcombobox-general-information-visual-structure%}) of [editable]({%slug radcombobox-features-edit-modes%}) __RadComboBox__ (__RadComboBox__'s __IsEditable__ property is set to __True__).

It is possible to set the MaxLength property of the InputArea using the following approaches: 

* [By using the TextBoxStyle property](#using-the-textboxstyle-property)

* [By using the controls resources](#using-the-control-resources)

* [By using an attached property](#using-an-attached-property)

## Using the TextBoxStyle property

As of Q2 2014 release __RadComboBox__ provides [TextBoxStyle property]({%slug radcombobox-features-textboxstyle%}) which makes it easy to customize the TextBox part of the control. Just create a custom Style with TargetType set to TextBox and set the MaxLength to the needed value as shown below:


 
<snippet id='radcombobox-howto-set-max-length-input-area-block_1-xaml' />


If you are using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}) to style the controls, you would need to base that Style to the default __TextBoxStyle__ of __RadComboBox__ named _ComboBoxTextBoxStyle_.



<snippet id='radcombobox-howto-set-max-length-input-area-block_2-xaml' />


Then, set the created Style as __TextBoxStyle__ of __RadComboBox__:


 
<snippet id='radcombobox-howto-set-max-length-input-area-block_3-xaml' />


## Using the control Resources

By accessing the ComboBox resources it is possible to modify the Style of the TextBox in the control and set its MaxLength property.

The next code snippet shows how to set the MaxLength property of the TextBox in the control using its resources:



<snippet id='radcombobox-howto-set-max-length-input-area-block_4-xaml' />


## Using an Attached property

The idea in this case is to create a new __Attached Property__ in a helper class.



<snippet id='radcombobox-howto-set-max-length-input-area-block_5-cs' />

<snippet id='radcombobox-howto-set-max-length-input-area-block_5-vb' />


In the __OnMaxLengthChanged()__ event handler you should perform the following step.

* Get the target combobox.

* Get the __PART_EditableTextBox__ element from its template.

* The __PART_EditableTextBox__ is a __TextBox__ and you can easily set its __MaxLength__ property.



<snippet id='radcombobox-howto-set-max-length-input-area-block_6-cs' />

<snippet id='radcombobox-howto-set-max-length-input-area-block_6-vb' />


Finally set the property in XAML:



<snippet id='radcombobox-howto-set-max-length-input-area-block_7-xaml' />


>tip Note that you have to set the __RadComboBox__'s __IsEditable__ property to __True__.

## See Also  
 * [Enable\Disable RadComboBoxItems]({%slug radcombobox-howto-enable-disable-radcombobox-items%})
 * [Open the DropDown When the Control Gets Focus]({%slug radcombobox-howto-open-dropdown-get-focus%}) 