---
title: Display Custom Error Message in RadMaskedInput
description: Implement custom validation by adding a ValidationError in code.
type: how-to
page_title: Implement Custom Validation Mechanism
slug: kb-maskedinput-manual-validation
position: 0
tags: maskedinput, validation, custom, error, message, mechanism
ticketid: 1514901
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadMaskedInput for WPF</td>
	</tr>
</table>

## Description

Implement custom validation by adding a ValidationError in code.

## Solution

If you want to mark the state of the control as invalid and display an error message in the RadMaskedInput controls and you do not want to [throw validation exceptions]({%slug radmaskedinput-features-validation%}) or use [data annotations]({%slug radmaskedinput-validation-regex%}), you can manually set a validation error in code by using the **ValidationError** class and the **Validation.MarkInvalid** method.


```C#
    private void MaskedInput_ValueChanged(object sender, Telerik.Windows.RadRoutedEventArgs e)
    {
        var input = sender as RadMaskedTextInput;
        if (input.Value == "123")
        {
            var rule = new ExceptionValidationRule();

            ValidationError validationError = new ValidationError(rule, this.MaskedInput.GetBindingExpression(RadMaskedTextInput.ValueProperty));
            validationError.ErrorContent = "The input is invalid!";

            Validation.MarkInvalid(this.MaskedInput.GetBindingExpression(RadMaskedTextInput.ValueProperty), validationError);
        }
        else
        {
            Validation.ClearInvalid(this.MaskedInput.GetBindingExpression(RadMaskedTextInput.ValueProperty));
        }
    }
```

You can notice that the **Validation.ClearInvalid** method can be used if the state of the binding should be marked as valid.

>importantFor this approach to work as expected, a binding to the **Value** property of the control needs to be set.

## See Also

* [Throw Validation Exceptions]({%slug radmaskedinput-features-validation%})
* [Validation through Data Annotations]({%slug radmaskedinput-validation-regex%})