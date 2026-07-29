---
title: Data Validation
page_title: Data Validation
description: The article describes the data validation feature of RadCardView.
slug: radcardview-features-validation
tags: editing,cardview
published: True
position: 8
---

# Data Validation

The data fields of the RadCardView control support data validation of the user input. 

The feature provides visual feedback when an invalid value is entered. This article shows how to implement custom validation logic.

## Using Validation Events

The RadCardView control provides few events that are raised whenever the data is changed using the UI - __CardValidating__, __CardDataFieldValidating__ and __CardDataFieldValidated__.

The __CardDataFieldValidating__ and __CardDataFieldValidated__ events are raised when a data field exits its edit mode. If the card loses the focus when a data field exits edit mode, then the __CardValidating__ event is raised.

__CardDataFieldValidating__ can be used to validate the associated value and determine the validation state of the data field.

__Example 1: Validating a data field__
<snippet id='radcardview-features-validation-example_1_validating_a_data_field-cs' />

## Using ValidationException

The validation can be implemented in the view model. If the updated value is invalid, a `ValidationException` can be thrown in the corresponding property setter. To enable the visual feedback in the UI, set the __ValidatesOnExceptions__ and __NotifyOnValidationError__ properties of the DataMemberBinding to __True__.

__Example 2: Implementing validation logic in the view model__
<snippet id='radcardview-features-validation-example_2_implementing_validation_logic_in_the_view_model-cs' />

__Example 3: Enabling visual feedback using the data binding properties__
<snippet id='radcardview-features-validation-example_3_enabling_visual_feedback_using_the_data_binding_properties-xaml' />

#### Figure 1: Data validation visual feedback
![{{ site.framework_name }} RadCardView Data validation visual feedback](images/radcardview-features-validation-0.png)

## Using Data Annotations

The data binding validation can be enabled also by using the data annotation attributes.

__Example 4: Using data annotations in the view model__
<snippet id='radcardview-features-validation-example_4_using_data_annotations_in_the_view_model-cs' />

__Example 5: Data binding the view model property__
<snippet id='radcardview-features-validation-example_5_data_binding_the_view_model_property-xaml' />

In order to see the error visual when using data annotations, press the __Enter key__. This will add the error in the list at the bottom of the card.

#### Figure 2: Data validation visual feedback when using data annotations
![{{ site.framework_name }} RadCardView Data validation visual feedback when using data annotations](images/radcardview-features-validation-1.png)

## See Also
* [Getting Started]({%slug radcardview-getting-started%})
* [Events]({%slug radcardview-events%})
* [Visual Structure]({%slug radcardview-visual-structure%})

