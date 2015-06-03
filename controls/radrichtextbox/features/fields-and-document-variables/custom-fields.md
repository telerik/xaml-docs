---
title: Custom Fields
page_title: Custom Fields
description: Custom Fields
slug: radrichtextbox-features-custom-fields
tags: custom,fields
published: True
position: 2
---

# Custom Fields



Fields are a convenient way to show non-static data in the document. In this way, you could present different data to the end-user without actually changing the document content.
      

For a description of the supported out of the box field types, please refer to [this article]({%slug radrichtextbox-features-fields%}).
      

This topic will explain how custom fields can be created in order to suit application-specific purposes. It contains the following sections:

* [Creating a Custom Field](#create-custom-field)

* [Adding Properties](#adding-properties)

* [Integrating with UpdateAllFields Operation](#integrating-with-updateallfields-operation)


## Create Custom Field

In some cases, it is convenient to extend the currently available fields to suit application-specific scenarios. This can be done by inheriting from __CodeBasedField__ or (if the functionality of the new field will be closely connected to Mail Merge) from __MergeField__.
        

This topic will list the steps for creating such a custom field.

1. Have your class inherit from MergeField or CodeBasedField:

	#### __C#__
	
	{{region radrichtextbox-features-custom-fields_0}}
		    public class CustomField : CodeBasedField
	{{endregion}}


1. Give a FieldTypeName to instances of your field:

	#### __C#__
	{{region radrichtextbox-features-custom-fields_1}}
	    private static readonly string FieldType = "CUSTOMFIELD";
	    public override string FieldTypeName
	    {
	        get
	        {
	            return CustomField.FieldType;
	        }
	    }
	{{endregion}}

    The field type is shown when the field is in code mode, just after the opening curly bracket. If you toggle the field to Code mode and modify this first word, the type of the field will also change. That is why it is important to give a meaningful name to the field.

1. Register your custom field type in the factory that RadDocument uses. It is convenient to use the static constructor of the class for that purpose:

	#### __C#__
	
	{{region radrichtextbox-features-custom-fields_2}}
	    static CustomField()
	    {
	        CodeBasedFieldFactory.RegisterFieldType(CustomField.FieldType, () => new CustomField());
	    }
	{{endregion}}
	
	The function passed as a second parameter essentially tells the document how it could create a new instance of the field. This is required because fields have to be created internally when you copy/paste or even when you toggle field modes.

1. Override the CreateInstance() method to return a new instance of your custom field:
	
	#### __C#__
	
	{{region radrichtextbox-features-custom-fields_3}}
	    public override Field CreateInstance()
	    {
	        return new CustomField();
	    }
	{{endregion}}


1. If you have inherited from CodeBasedField or you would like to customize the way the field appears in the document in ResultMode, override GetResultFragment method. In short, it will return a DocumentFragment with the content that should be shown when the field is updated and its mode is changed to Result.


That is all that needs to be done in order to be able to get your custom field working, insert it in documents, serialize and deserialize it.

## Adding Properties

If you would like to add some properties to this field, similar to the PropertyPath field of MergeFields, you can do so following the steps bellow:

1. Create a readonly FieldProperty:

	#### __C#__
	
	{{region radrichtextbox-features-custom-fields_4}}
	    private readonly FieldProperty myProperty;
	{{endregion}}

1. Add a public CLR property. Properties of type string can be set and retrieved from the FieldProperty directly. No other types are accepted, as it would not be possible to convert them correctly to text for the purpose of field evaluation when inserted in the document. Therefore, if you would like to have non-string properties, you would have to make the conversion to/from string yourself:

	#### __C#__
	
	{{region radrichtextbox-features-custom-fields_5}}
	    [XamlSerializable]
	    public string MyProperty
	    {
	        get
	        {
	            return this.myProperty.GetValue();
	        }
	        set
	        {
	            if (!this.myProperty.IsNestedField && this.myProperty.GetValue() == value)
	            {
	                return;
	            }
	
	            this.myProperty.SetValue(value);
	            this.InvalidateCode();
	        }
	    }
	{{endregion}}
	
	The XamlSerializable attribute ensures that this property will be exported and imported to/from XAML when XamlFormatProvider is used. The other part of the code ensures that the field will be reset only if the new value is different and that the code will be invalidated, so as to be correctly updated on the next pass.

1. Declare a static FieldPropertyDefinition wired to your property:

	#### __C#__
	
	{{region radrichtextbox-features-custom-fields_6}}
	    public static readonly FieldPropertyDefinition MyPropertyProperty = new FieldPropertyDefinition("MyProperty");
	{{endregion}}


1. Make sure to initialize the FieldProperty in the constructor of your field:
	
	#### __C#__
	
	{{region radrichtextbox-features-custom-fields_7}}
	    public CustomField()
	    {
	        this.myProperty = new FieldProperty(this, CustomField.MyPropertyProperty);
	    }
	{{endregion}}


1. Ensure that your custom property is copied along with the other field properties:

	#### __C#__
	
	{{region radrichtextbox-features-custom-fields_8}}
	    protected override void CopyPropertiesFromCodeExpression(FieldCodeExpression fieldCodeExpression)
	    {
	        base.CopyPropertiesFromCodeExpression(fieldCodeExpression);
	        this.myProperty.SetValue(fieldCodeExpression.FieldArgumentNode);
	    }
	{{endregion}}
	
	This method is used when a field is created from field fragment.  This happens when you update a field and is what enables changing the property path of a merge field by typing in the editor or even changing a PageField to a DateField. As the type of the new field is inferred from the text in the document, it is required that the field be created anew and the respective properties must be copied as well.

	#### __C#__
	
	{{region radrichtextbox-features-custom-fields_9}}
	    protected override void BuildCodeOverride()
	    {
	        base.BuildCodeOverride();
	        this.CodeBuilder.SetFieldArgument(this.myProperty);
	    }
	
	{{endregion}}
	
	This method is invoked when the CodeFragment of the field is requested. In it, the field arguments and switches must be added, so that they are properly included in the field.
	
	#### __C#__
	
	{{region radrichtextbox-features-custom-fields_10}}
		        public override void CopyPropertiesFrom(Field fromField)
		        {
		            base.CopyPropertiesFrom(fromField);
		            CustomField customField = (CustomField)fromField;
		            this.myProperty.CopyPropertiesFrom(customField.myProperty);
		        }
		{{endregion}}
	
	As field ranges are copyable, this method must be overridden in order to ensure that the added properties will also be copied.

1. If you like, you can also customize the fragment that is returned when the ResultFragment is requested. This is done by overriding the GetResultFragment method. Here is an example:

	#### __C#__
	
	{{region radrichtextbox-features-custom-fields_11}}
	    protected override DocumentFragment GetResultFragment()
	    {
	        return DocumentFragment.CreateFromInline(new Span(this.MyProperty));
	    }
	{{endregion}}


## Integrating with UpdateAllFields Operation

Updating all field in document (by calling __UpdateAllFields__ method) is common operation for documents containing multiple fields. The field types can have multiple dependencies between them (result of updating one field depends on updating other field) – e.g. update result may differ depending on the update order.

To change the default update order and behavior, additional update information can be registered for a field type using the __FieldsUpdateManager__ static class:

#### __C#__

{{region radrichtextbox-features-custom-fields_12}}

	FieldsUpdateManager.RegisterFieldUpdateInfo(typeof(CustomField), new FieldTypeUpdateInfo() { Priority = -1000 });

{{endregion}}

The properties influencing the update operation are grouped in __FieldTypeUpdateInfo__ class:

* __Priority__: Determines update priority. Each field type has update priority which determines when they should be updated during the UpdateAllField operation. Fields with larger priority are updated first. The default value is 0.

	The fields with non-default priority are listed in the following table:
	<table>

	<tr>
	<th>Priority (greater updates first)</th>
	<th> Field Type</th>
	</tr>

	<tr>
	<td>1000</td>
	<td>TableOfContentsField</td>
	</tr>

	<tr>
	<td>0</td>
	<td> &lt; Default priority. All fields are set to this value by default&gt;</td>
	</tr>
	
	<tr>
	<td>-900</td>
	<td>PageReferenceField</td>
	</tr>
	
	<tr>
	<td>-900</td>
	<td>NumPagesField</td>
	</tr>
	
	<tr>
	<td>-900</td>
	<td>PageField</td>
	</tr>
	
	<tr>
	<td>-1000</td>
	<td>ReferenceField</td>
	</tr>
	
	</table>
	
	Changing the priority is needed in case a field depends on the evaluated value of another field to be properly evaluated.

* __NeedsPagination__: Determines whether the field needs the document to be paginated during the update. The default value is false. 
	
	For performance reasons, the document is not always paginated during the UpdateAllFields operation, which may lead to incorrect field values for some fields, for example ones using current page number or total number of pages in section/document. In these cases, you can set NeedsPagination property to true. 

# See Also

 * [Fields]({%slug radrichtextbox-features-fields%})

 * [Mail Merge]({%slug radrichtextbox-features-mail-merge%})
 
 * [CustomField SDK example](https://github.com/telerik/xaml-sdk/tree/master/RichTextBox/CustomField)
