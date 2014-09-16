---
title: Changes
page_title: Changes
description: Changes
slug: radmaskedinput-changes
tags: changes
publish: True
position: 1
---

# Changes



This article describes the release history of the RadMaskedInput controls

## Q1 2014

### What's Fixed

* Fixed: Delete key does not place the caret in the right place in no-mask scenarios (Mask="")

## Q2 2013

### What's Fixed

* Fixed: CurrencyInput loses precision when working with 17 digits

* Fixed: In Windows8Touch theme the ReadOnly VisualState sets the BorderBrush of the focused border twice 

* Fixed: Numeric and Currency Inputs's Value should become positive when pressing "+"

* Fixed: Setting the value of negative MaskedNumericInput to null doesn't remove the minus

### What's New

* Feature: In Currency/Numeric Input, provide a way to remove the negative sign when setting 0 via keyboard or programmatically/binding
				

## Q1 2013

### What's Fixed

* Fixed: Changing the Mask property to "" (no mask) makes the control work incorrectly

* Fixed: Paste in NoMasked TextInput with UpdateValueEvent=LostFocus does not work in Q3 2012 SP

* Fixed: Pasted value is not preserved when using application paste command

* Fixed: Pasted value in MaskedTextInput is not validated (coerced).  Same issue when value is set via code

* Fixed: In a MaskedTextInput control using the 'no-mask' feature and PlainText TextMode, entering a capital letter raises an exception

* Fixed: Delete and Backspace do not work when 'no-mask' and UpdateValueEvent is LostFocus

* Fixed: Backspace does not work in No-MaskTexdInput when selection is performed.

* Fixed: ClearButton is disabled when IsReadOnly is set initialy to True and then changed to False.

* Fixed: Cannot use OneWay binding to read-only properties

## Q2 2012

### What's Fixed

* Fixed: MaskedNumericInput Value isn't properly updated in en-US culture

* Fixed: Don't allow an invalid value input

* Fixed: Incorrect initial input

* Fixed: The Tab key isn't properly handled after tabbing away from a GridView in edit mode

* Fixed: The MaskedInput controls in Silverlight can't detect the Validation.Errors collection changes

* Fixed: In WPF the DataAnnotations validation doesn't work

* Fixed: When the MaskedInputExtensions.Minimum value is 0, you can still enter the minus sign when the control's current value is 0 or null

* Fixed: The ErrorMessageTemplate Foreground setting should be updated in the different themes

* Fixed: The 'OemMinus' Key is handled in MaskedTextInput

### What's New

* Feature: Allow masked input controls to have no mask ([Read More](6423C290-4198-48A9-A19B-8937AAE46FCB#NoMask))
				

## Q1 2012

### What's Fixed

* Fixed: TabNavigation with Tab Key over several MaskedInput controls leads to endless focus loop

* Fixed: When the MaskedInput controls are in a RadWindow/ChildWindow and the window is moved, the user can no longer click in them

* Fixed: Cannot focus control when used in Cell template of GridView

* Fixed: Most of  the F-keys are handled by default and cannot be used

* Fixed: The Mask isn't properly applied when the MaskedDateTimeInput control is used in the ControlTemplate of a CustomControl

* Fixed: When using >aX or <aX Mask in MaskedTextInput, the bound property is not properly updated

* Fixed: Unnecessary red border appears in certain validation scenarios with IDataErrorInfo

* Fixed: If the value of the masked control is changed while the control is disabled, the values isn't rendered properly

* Fixed: Don't allow an invalid value input

* Fixed: The Culture.NumberFormat.Percent Patterns aren't properly applied in the MaskedNumeric/CurrenyInput controls

* Fixed: If the MaskedNumeric/CurrencyInput value is selected and '-' is entered, the old value isn't cleared

* Fixed: Entering negative values when the MaskedInputExtensions.Minimum property is set 0 causes unexpected behavior

* Fixed: Error message is empty when AllowInvalidValues is set to true

* Fixed: The validation error is not displayed before MouseOver the control

* Fixed: ValidationTooltip does not show the first time the error occurs

* Fixed: IndexOutOfRange exception occurs in NumericInput

### What's New

* Feature: Expose a property to control whether null is acceptable value in MaskedInput controls

>You can examine the Q1 2012 release history in
				{% if site.site_name == 'Silverlight' %}[our site](http://www.telerik.com/products/silverlight/whats-new/release_notes/q1-2012-version-2012-1-215-271395503.aspx){% endif %}{% if site.site_name == 'WPF' %}[our site](http://www.telerik.com/products/wpf/whats-new/release-history/q1-2012-version-2012-1-215-1506305735.aspx){% endif %}.
			  

# See Also
