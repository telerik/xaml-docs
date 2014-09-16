---
title: Validation Support
page_title: Validation Support
description: Validation Support
slug: radpropertygrid-features-validation
tags: validation,support
published: True
position: 14
---

# Validation Support



RadPropertyGrid supports validation through IDataErrorInfo and through DataAnnotations.

## Validating through IDataErrorInfo

In order to have the validation rules defined through the IDataErrorInfo interface, you will have to implement additional code which sets the ValidatesOnDataErrors and NotifyOnValidationError properties of the Binding to true. Please note that the default binding generated for auto-generated PropertyDefinition have those properties set to false. 

#### __C#__





You can define the validation rules like so:

#### __C#__

{{region radpropertygrid-features-validation_2}}
	        public string this[string columnName]
	        {
	            get
	            {
	                if (columnName == "IntProp")
	                {
	                    return this.IntProp < 100 && this.IntProp > 0 ? string.Empty : "Value should be in the range of (0, 100)";
	                }
	                if (columnName == "StringProp")
	                {
	                    return this.StringProp != null && Regex.IsMatch(this.StringProp, @"^[0-9]+[\p{L}]*") ? string.Empty : @"Value should math the regex: ^[0-9]+[\p{L}]*";
	                }
	                if (columnName == "DateTimeProp")
	                {
	                    return this.DateTimeProp.Year > 1900 ? string.Empty : "Date should be after 1/1/1900";
	                }
	                return string.Empty;
	            }
	        }
	{{endregion}}



## Validating through DataAnnotations

In order to have the validation rules defined through DataAnnotations respected, you will have to set the ValidatesOnExceptions property of the Binding to true. Please note that the default binding generated for auto-generated PropertyDefinition does not have this property set to true. 

#### __C#__





For example you can define the Required DataAnnotations attribute like so:

#### __C#__





You may notice that there is a call to a ValidateProperty method. You will have to define such a method like this:

#### __C#__





# See Also
