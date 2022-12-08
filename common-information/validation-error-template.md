---
title: Validation Error Visual
page_title: Validation Error Visual - Telerik WPF
description: This article shows general information for ValidationErrorTemplate accros our controls.
slug: validaton-error-template
tags: validaton,error,datatemplate
position: 15
---

# Validation Error Visual

{% if site.site_name == 'WPF' %}
The Telerik controls that support text input provide a validation error visual that is displayed when an error occurs. Examples of such controls are `RadMaskedTextInput`, editable `RadComboBox`, `RadWatermarkTextBox`, `TextBox` (when styled with our custom styles) and more.

When the control has validation errors, the border around the control turns red and an error message is visualized. 

![WPF Validation Error Template](images/validaton-error-template-0.png)

The message visualization can vary based on the applied display mode.

## Display Modes 

The Telerik validation error template supports few different visualizations. To change between the visualizations, set the `ValidationErrorTemplateHelper.DisplayMode` attached property on the corresponding input control. 

#### __[XAML] Setting the display mode__
{{region xaml-validaton-error-template-0}}
	<telerik:RadMaskedTextInput telerik:ValidationErrorTemplateHelper.DisplayMode="Static" />
{{endregion}}

The property supports the following modes:

* `ToolTip`&mdash;Little ribbon element appears in the upper right corner of the control. When the ribbon gets hovered the validation message is displayed in a tooltip. This is the default behavior in most Telerik themes.

* `Static`&mdash;The red rectangle that shows the error message is displayed as a static element, next to the validated control.

* `StaticOnFocus`&mdash;The red rectangle that shows the error message is displayed as a static element, next to the validated control. This happens only when the input control is focused. The error message disappears when the focus is lost.

* `Default`&mdash;This mode behaves as ToolTip or Static, based on the applied Telerik theme. Most themes use the ToolTip behavior.

## Error Template

The validation error visual is defined using the [Validation.ErrorTemplate](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.validation.errortemplate?view=windowsdesktop-6.0) attached property. Telerik uses this API to define the error's appearance for most input components.

The default visual can be modified by setting a custom template using the `Validation.ErrorTemplate` property. The default template can be found in the `Telerik.Windows.Controls.xaml` file. See how to get the file the [Editing Control Templates]({%slug styling-apperance-editing-control-templates%}) article.

The following example shows how to create a custom error template and assign it via the `Validation.ErrorTemplate` property.

#### __[XAML] Defining custom ControlTemplate__
{{region xaml-validaton-error-template-1}}
	<ControlTemplate x:Key="CustomErrorTemplate">
		<!-- define whatever UI needed here -->
	</ControlTemplate>
{{endregion}}

#### __[XAML] Setting the custom template__
{{region xaml-validaton-error-template-2}}
	<telerik:RadMaskedNumericInput Validation.ErrorTemplate="{StaticResource CustomErrorTemplate}" />
{{endregion}}
{% else %}

When the control has validation errors, the border around the control will turn red and a little element will appear in the upper right corner of the control. When you hover over the element you can read the validation message. The visual appereance of the validation error comes from the __Validation.ErrorTemplate__ attached property. Most of our controls have a predefined template for this property. The visual appearance of the error is defined inside the default template of the controls. 

If you want to modify the default one, you can extract the default __Validation.ErrorTemplate__ for the specified control and modify it per your needs. You can check the [Editing Control Templates]({%slug styling-apperance-editing-control-templates%}) help article which describes how you can get the template of our controls.

In a case, you want to create your own error template, you can create custom __ControlTemplate__ and assign it to the __Validation.ErrorTemplate__ attached property.

#### __[XAML] Example 1: Custom ControlTemplate__
{{region xaml-validaton-error-template-3}}
	<ControlTemplate x:Key="CustomErrorTemplate">
		<!-- define whatever UI needed here -->
	</ControlTemplate>
{{endregion}}

#### __[XAML] Example 2: Custom ControlTemplate__
{{region xaml-validaton-error-template-4}}
	<telerik:RadMaskedNumericInput Validation.ErrorTemplate="{StaticResource CustomErrorTemplate}" />
{{endregion}}

## ValidationErrorTemplateHelper

By default, the validation error tooltip message will appear only when the mouse is over this element. To make the validation message appears when the control is focused, you can set the __ValidationErrorTemplateHelper.ShowWhenFocused__ attached property to true. Its default value is false.

#### __[XAML] Show Validation Message on Focus__
{{region xaml-radwatermarktextbox-validation-helper-5}}
	<telerik:RadWatermarkTextBox telerik:ValidationErrorTemplateHelper.ShowWhenFocused="True" />
{{endregion}}	
{% endif %}

## See Also 
* [Introduction]({%slug introduction%})
* [Getting Started with XAML]({%slug common-faq%})
* [Adding Telerik UI to an Application]({%slug installation-adding-to-application-create-application-and-adding-control%})
