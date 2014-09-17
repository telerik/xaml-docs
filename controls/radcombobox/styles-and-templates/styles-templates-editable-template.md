---
title: EditableTemplate
page_title: EditableTemplate
description: EditableTemplate
slug: radcombobox-styles-templates-editable-template
tags: editabletemplate
published: False
position: 5
---

# EditableTemplate



The __Editable__ template is used by the __RadComboBox__ when the __RadComboBox__ is in editable mode. This happens when its __IsEditable__ property is set to __True__. To learn more about the __Editable____RadComboBox__ read [here]({%slug radcombobox-features-edit-modes%}).

This topic will give an answer to the following questions:

* [How to modify the default Editable template?](#Modifying_the_Default_Editable_Template)

* [Which property to use in order to set it?](#Setting_the_Editable_Template)

>tipTo learn more about the structure of the __Editable__ template read here.

## Modifying the Default Editable Template

To copy the __Editable__ template, load your project in Expression Blend and open the User Control that holds the __RadComboBox__which you want to template. Select it and from the menu choose *Object -> Edit Additional Templates -> Edit EditableTemplate -> Edit a copy*.

You will be prompted for the name of the __ControlTemplate__ and where to be placed.



>tipIf you choose to define the template in Application, it would be available for the entire application. This allows you to define a template only once and then reuse it where needed.

After clicking 'OK', Expression Blend will generate the default __Editable__ template and will bring you into editing it.

Take a look at the 'Objects and timeline' pane where you can see the controls that are part of the __Editable__template.



>tipTo learn more about the structure of the __Editable__ template read here.

You can modify the parts of the __Editable__template in order to change its appearance or to add/remove some visual elements.

>Child controls marked with the prefix "PART_" in their names in the control's template are usually used in the program part of the control. Removing them may cause the whole control to malfunction!

## Setting the Editable Template

>If you are using Expression Blend to modify the default __Editable__ template, it will automatically set the generated template to the __EditableTemplate__ property.

In order to set the __Editable__ template you have to set the desired template to the __EditableTemplate__ property. This can be done in-line:

#### __XAML__

{{region radcombobox-styles-templates-editable-template_0}}
	Type your example code here. It will be automatically colorized when you switch to Preview or build the help system.
	{{endregion}}



or by defining the __ControlTemplate__ as a resource.

#### __XAML__

{{region radcombobox-styles-templates-editable-template_1}}
	Type your example code here. It will be automatically colorized when you switch to Preview or build the help system.
	{{endregion}}


