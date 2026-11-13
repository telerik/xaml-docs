---
title: Expression Column
page_title: Expression Column
description: Display calculated values in the Telerik UI for WPF RadGridView with GridViewExpressionColumn and configure expressions in XAML or code.
components: ["gridview"]
slug: gridview-expression-column
tags: expression,column
tag: updated
published: True
position: 7
---

# Expression Column

`GridViewExpressionColumn` derives from the [`GridViewColumn`]({%slug radgridview-columns-column-types-basic-column%}) class and displays calculated values in `RadGridView`. You can sort and group the expression column like other column types.

Before using these examples, configure `RadGridView` as described in [Getting Started]({%slug gridview-getting-started2%}). For guidance on binding its `ItemsSource` to a data collection, see [Configure the Data Bindings]({%slug gridview-configuring-the-databindings%}).

Use the data model and viewmodel defined in Examples 1 and 2.

**Example 1: The `Product` class**

<snippet id='radgridview-columns-columntypes-expression-column-example_1_the_product_class-cs' />

<snippet id='radgridview-columns-columntypes-expression-column-example_1_the_product_class-vb' />

**Example 2: The viewmodel**

<snippet id='radgridview-columns-columntypes-expression-column-example_2_the_viewmodel-cs' />

<snippet id='radgridview-columns-columntypes-expression-column-example_2_the_viewmodel-vb' />

Use the data model and viewmodel from Examples 1 and 2 to define a `GridViewExpressionColumn` as shown in Example 3.

**Example 3: Define `GridViewExpressionColumn` in XAML**

<snippet id='radgridview-columns-columntypes-expression-column-example_3_define_gridviewexpressioncolumn_in_xaml-xaml' />

Set the `Expression` property to define the calculation. You can also set it in code-behind when the expression is too complex to express in XAML, as shown in Example 4. For background on C# syntax, see Microsoft's [Lambda expressions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions).

**Example 4: Set `Expression` for `GridViewExpressionColumn` in code**

<snippet id='radgridview-columns-columntypes-expression-column-example_4_set_expression_for_gridviewexpressioncolumn_in_code-cs' />

<snippet id='radgridview-columns-columntypes-expression-column-example_4_set_expression_for_gridviewexpressioncolumn_in_code-vb' />

> The values displayed in `GridViewExpressionColumn` update automatically when a property used by the expression changes on the data item.

For data items that implement `INotifyPropertyChanged`, raise the `PropertyChanged` event whenever a property value changes. See the [data model guidance]({%slug gridview-getting-started2%}#populating-with-data) for details.

## Function Calls in GridView Expressions

When you set `GridViewExpressionColumn.Expression` from a string, the expression converter passes it to the shared expression runtime. Calls can resolve Telerik's built-in functions and registered custom functions. Register custom functions through `ExpressionFunctionContext.Context.FunctionRegistry` before the grid parses or evaluates the expression. See [Custom Categories and Functions]({%slug radexpressioneditor-expressions-custom-functions-and-categories%}) for registration and migration details.

The same function-call rules apply to string expressions supplied to `RuleBase.Condition`, including rules used by `ConditionalStyleSelector` and `ConditionalDataTemplateSelector`. Function allowlisting does not remove expression member or property access.

## See Also

* [Expression Parser]({%slug radexpressioneditor-expression-parser%})
* [Custom Categories and Functions]({%slug radexpressioneditor-expressions-custom-functions-and-categories%})
* [Row Style Selector]({%slug gridview-rowstyleselector%})
* [Row Details Template Selector]({%slug radgridview-row-details-templateselector%})
