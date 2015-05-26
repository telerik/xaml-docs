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

In order to have the validation rules defined through the IDataErrorInfo interface, you will have to implement additional code which sets the __ValidatesOnDataErrors__ and __NotifyOnValidationError__ properties of the Binding to __"true"__. Please note, that the default binding generated for auto-generated PropertyDefinition have those properties set to __"false"__. 

#### __[C#]Example 1: Setting ValidatesOnDataErrors and NotifyOnValidationError of the Binding__


	{{region radpropertygrid-features-validation_1}}
	void rpg_AutoGeneratingPropertyDefinition(object sender, Telerik.Windows.Controls.Data.PropertyGrid.AutoGeneratingPropertyDefinitionEventArgs e)
	{
 	   (e.PropertyDefinition.Binding as Binding).ValidatesOnDataErrors = true;
 	   (e.PropertyDefinition.Binding as Binding).NotifyOnValidationError = true;
	}
	{{endregion}}

You can define the validation rules like so:

#### __[C#]Example 2: Defining validation rules__

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

In order to have the validation rules defined through DataAnnotations respected, you will have to set the ValidatesOnExceptions property of the Binding to true. Please note, that the default binding generated for auto-generated PropertyDefinition does not have this property set to true. 

#### __[C#]Example 3: Setting ValidatesOnExceptions of Binding__

	{{region radpropertygrid-features-validation_3}}
	void rpg_AutoGeneratingPropertyDefinition(object sender, Telerik.Windows.Controls.Data.PropertyGrid.AutoGeneratingPropertyDefinitionEventArgs e)
	{
	    (e.PropertyDefinition.Binding as Binding).ValidatesOnExceptions = true;
	}
	{{endregion}}

For example you can define the Required DataAnnotations attribute like so:

#### __[C#]Example 4: Defining DataAnnotations Attribute__

	{{region radpropertygrid-features-validation_4}}
	[Required(ErrorMessage = "This field is Required.")]
	public string RequiredField
	{
	    get { return requiredField; }
	    set
	    {
	        requiredField = value;
	        ValidateProperty("RequiredField", value);
	        this.OnPropertyChanged("RequiredField");
	    }
	}

	{{endregion}}


You may notice that there is a call to a ValidateProperty method. You will have to define such method like this:

#### __[C#]Example 5: Defining ValidateProperty method__

	{{region radpropertygrid-features-validation_4}}
	public void ValidateProperty(string propName, object value)
	{
	    var result = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
	    Validator.TryValidateProperty(value, new ValidationContext(this, null, null) { MemberName = propName }, result);
	
	    if (result.Count > 0)
	    {
	        throw new ValidationException(result[0].ErrorMessage);
	    }
	}
	{{endregion}}


