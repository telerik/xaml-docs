---
title: Filter a Custom Type
page_title: Filter a Custom Type
description: Get started with the filtering functionality of Telerik's {{ site.framework_name }} DataGrid and learn how to filter a custom type.
slug: gridview-filtering-howto-filter-a-custom-type
tags: filter,a,custom,type
published: True
position: 11
---

# Filter a Custom Type

If you want to filter a column that is data-bound to a custom type, you need to make sure that your custom type meets certain criteria. We will use the type **Person** as an example.

__Example 1: The Person class__

<snippet id='radgridview-filtering-how-to-howto-filter-a-custom-type-example_1_the_person_class-cs' />

<snippet id='radgridview-filtering-how-to-howto-filter-a-custom-type-example_1_the_person_class-vb' />


The first thing that you need to do is implement the generic **IEquatable** interface. It has a single method called **Equals**. Next, you need to override **Object.Equals(Object)** and **Object.GetHashCode**. MSDN states that if you implement generic **IEquatable**, you have to also override the base class implementations of Object.Equals(Object) and Object.GetHashCode so that their behavior is consistent with that of the generic IEquatable.Equals method.

## Implement IEquatable

__Example 2: IEquatable implementation__

<snippet id='radgridview-filtering-how-to-howto-filter-a-custom-type-example_2_iequatable_implementation-cs' />

<snippet id='radgridview-filtering-how-to-howto-filter-a-custom-type-example_2_iequatable_implementation-vb' />


## Override Object.Equals(Object) and Object.GetHashCode

If you do override Object.Equals(Object), your overridden implementation is also called in calls to the static Equals(System.Object, System.Object) method on your class. This ensures that all invocations of the Equals method return consistent results. Furthermore, the GetHashCode method will be used by the framework when the distinct values need to be discovered.

__Example 3: Equals and GetHashCode overrides__

<snippet id='radgridview-filtering-how-to-howto-filter-a-custom-type-example_3_equals_and_gethashcode_overrides-cs' />

<snippet id='radgridview-filtering-how-to-howto-filter-a-custom-type-example_3_equals_and_gethashcode_overrides-vb' />


## Override ToString

Next, you need to override the **ToString** method of your type so that distinct values and grid cells display a friendly representation of your class. Here is what the class might look like:

__Example 4: ToString override__

<snippet id='radgridview-filtering-how-to-howto-filter-a-custom-type-example_4_tostring_override-cs' />

<snippet id='radgridview-filtering-how-to-howto-filter-a-custom-type-example_4_tostring_override-vb' />


## Define a TypeConverter for String Conversions

Next you will need to define a **TypeConverter** for string conversions. When RadGridView encounters a custom type it will use a plain TextBox for the field filter editors. The strings that user enters have to be converted to your custom type and vice versa. This can be achieved by specifying a TypeConverter on your class.

__Example 5: Custom TypeConverter__

<snippet id='radgridview-filtering-how-to-howto-filter-a-custom-type-example_5_custom_typeconverter-cs' />

<snippet id='radgridview-filtering-how-to-howto-filter-a-custom-type-example_5_custom_typeconverter-vb' />


Do not forget to add the **TypeConverter** attribute on your class definition and point it to the custom TypeConverter that you just created.

__Example 6: Adding the TypeConverter attribute__

<snippet id='radgridview-filtering-how-to-howto-filter-a-custom-type-example_6_adding_the_typeconverter_attribute-cs' />

<snippet id='radgridview-filtering-how-to-howto-filter-a-custom-type-example_6_adding_the_typeconverter_attribute-vb' />


If the plain TextBox does not suit your needs, you can provide your own field filter editor by overriding the **GridViewDataColumn.CreateFieldFilterEditor** method as described [here]({%slug gridview-filtering-howto-create-a-custom-field-filter-editor%}). You will no longer need a TypeConverter if your custom field filter editor is able to produce instances of your custom type.

## Override the Comparison Operators (Optional)

If you want to see the comparison filter operators (**Is Less Than**, etc.) you should override your custom type's comparison operators.

__Example 7: Comparison operators override__

<snippet id='radgridview-filtering-how-to-howto-filter-a-custom-type-example_7_comparison_operators_override-cs' />

<snippet id='radgridview-filtering-how-to-howto-filter-a-custom-type-example_7_comparison_operators_override-vb' />


## See Also

* [Basic Filtering]({%slug gridview-filtering-basic%})
* [Create a Custom Field Filter Editor]({%slug gridview-filtering-howto-create-a-custom-field-filter-editor%})
* [Customize the Default Field Filter Editor]({%slug gridview-filtering-howto-customize-the-default-field-filter-editor%})