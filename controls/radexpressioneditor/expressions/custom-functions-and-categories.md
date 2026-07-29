---
title: Custom Categories and Functions
page_title: Custom Categories and Functions
description: Check our &quot;Custom Categories and Functions&quot; documentation article for the RadExpressionEditor {{ site.framework_name }} control.
slug: radexpressioneditor-expressions-custom-functions-and-categories
tags: custom,functions,categories
published: True
position: 5
---

# Custom Categories and Functions

As of **R1 2019**, the RadExpressionEditor control allows users to add custom categories and functions to its UI as well as remove some of the already defined ones.

To do so, you have to create a custom implementation of the **ExpressionEditorViewModel** and override its virtual methods.

#### [C#] Example 1: The ExpressionEditorViewModel overrides

<snippet id='radexpressioneditor-expressions-custom-functions-and-categories-block_1-cs' />


To assign the custom viewmodel to the RadExpressionEditor control, you have to set its **ViewModel** property.

#### [C#] Example 2: Set RadExpressionEditor's ViewModel

<snippet id='radexpressioneditor-expressions-custom-functions-and-categories-block_2-cs' />


## Custom Categories

To add custom categories as well as remove certain predefined categories, you need to override the **GenerateCategories** method.

#### [C#] Example 3: Add custom categories

<snippet id='radexpressioneditor-expressions-custom-functions-and-categories-block_3-cs' />


**Example 3** adds a **Favorites** category with two subcategories - **Math** and **DateTime**. Each of the categories contains some static methods of the respective class. The results before and after respectively can be observed in **Figure 1**.

__Custom category__

![Telerik UI for WPF RadExpressionEditor custom categories showing Favorites with Math and DateTime subcategories](images/custom-category.png)

## Custom Functions

If you want to add your custom non-static functions to the control you need to set the **ExpressionFunctionContext.Context** property to an instance of the **ExpressionFunctionContext** class.

#### [C#] Example 4: Custom ExpressionFunctionContext

<snippet id='radexpressioneditor-expressions-custom-functions-and-categories-custom_category-cs' />


**Example 4** defines two custom instance functions which we can now pass to the ExpressionParser as show in **Example 5**.

#### [C#] Example 5: Set the ExpressionFunctionContext.Context

<snippet id='radexpressioneditor-expressions-custom-functions-and-categories-custom_category-cs' />


You can then add these functions in the **GetFunctionsItemModels** override as well as remove some of the predefined functions.

#### [C#] Example 6: Add custom functions

<snippet id='radexpressioneditor-expressions-custom-functions-and-categories-custom_category-cs' />


**Example 6** adds the two custom functions defined in Example 4 to the **Other** subcategory. The results before and after respectively are illustrated in **Figure 2**. 

__Custom functions__

![Telerik UI for WPF RadExpressionEditor custom functions showing OnePlus and TwoPlus in the Other category](images/custom-functions.png)

## Further Customizations

You can further customize the control by overriding the **GetFieldsItemModels**, **GetOperatorsItemModels**, **GetConstantsItemModels** and **GetFieldsCategory** methods.

#### [C#] Example 7: Remove operators, constants and fields and add subcategories to the Fields category

<snippet id='radexpressioneditor-expressions-custom-functions-and-categories-custom_functions-cs' />


The example above removes some of the operators, constants and the **Discontinued** field from the RadExpressionEditor. It also creates a subcategory for the Fields category which holds the **Car** field of the bound object.

## See Also

* [Lambdas]({%slug radexpressioneditor-expressions-lambdas%})

