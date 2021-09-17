---
title: Validation Error Template
page_title: Validation Error Template | Telerik WPF
description: This article shows general information for ValidationErrorTemplate accros our controls.
slug: validaton-error-template
tags: validaton,error,datatemplate
position: 15
---

# Validation Error Template

When the control has validation errors, the border around the control will turn red and a little element will appear in the upper right corner of the control. When you hover over the element you can read the validation message. The visual appereance of the validation error comes from the __Validation.ErrorTemplate__ attached property. Most of our controls have a predefined template for this property. The visual appearance of the error is defined inside the default template of the controls. 

If you want to modify the default one, you can extract the default __Validation.ErrorTemplate__ for the specified control and modify it per your needs. You can check the [Editing Control Templates]({%slug styling-apperance-editing-control-templates%}) help article which describes how you can get the template of our controls.

In a case, you want to create your own error template, you can create custom __ControlTemplate__ and assign it to the __Validation.ErrorTemplate__ attached property.

#### __[XAML] Example 1: Custom ControlTemplate__
{{region xaml-validaton-error-template-0}}
	<ControlTemplate x:Key="CustomErrorTemplate">
		<!-- define whatever UI needed here -->
	</ControlTemplate>
{{endregion}}

#### __[XAML] Example 2: Custom ControlTemplate__
{{region xaml-validaton-error-template-1}}
	<telerik:RadMaskedNumericInput Validation.ErrorTemplate="{StaticResource CustomErrorTemplate}" />
{{endregion}}

## ValidationErrorTemplateHelper

By default, the validation error tooltip message will appear only when the mouse is over this element. To make the validation message appears when the control is focused, you can set the __ValidationErrorTemplateHelper.ShowWhenFocused__ attached property to true. Its default value is false.

#### __[XAML] Example 3: Show Validation Message on Focus__
{{region xaml-radwatermarktextbox-validation-helper_1}}
	<telerik:RadWatermarkTextBox telerik:ValidationErrorTemplateHelper.ShowWhenFocused="True" />
{{endregion}}


## See Also 
* [Introduction]({%slug introduction%})
* [Getting Started with XAML]({%slug common-faq%})
* [Adding Telerik UI to an Application]({%slug installation-adding-to-application-create-application-and-adding-control%})
