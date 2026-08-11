---
title: Expression Column
page_title: Expression Column
description: Find out how you can display various calculations in the grid itself using the Expression column in RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-expression-column
tags: expression,column
published: True
position: 7
---

# Expression Column

__GridViewExpressionColumn__ derives from the [GridViewColumn]({%slug radgridview-columns-column-types-basic-column%}) class and allows you to display various calculations in RadGridView itself. The __GridViewExpressionColumn__ can be sorted and grouped like any other type of column.

For the purposes of this example, we will use the objects and viewmodel defined in **examples 1 and 2**.

__Example 1: The Product class__

<snippet id='radgridview-columns-columntypes-expression-column-example_1_the_product_class-cs' />

<snippet id='radgridview-columns-columntypes-expression-column-example_1_the_product_class-vb' />


__Example 2: The viewmodel__

<snippet id='radgridview-columns-columntypes-expression-column-example_2_the_viewmodel-cs' />

<snippet id='radgridview-columns-columntypes-expression-column-example_2_the_viewmodel-vb' />


With this data setup, we can bind the GridViewExpressionColumn as shown in **Example 3**.

__Example 3: Define GridViewExpressionColumn in XAML__

<snippet id='radgridview-columns-columntypes-expression-column-example_3_define_gridviewexpressioncolumn_in_xaml-xaml' />


The most important property to be set is the [Expression](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/lambda-expressions) property. It can also be set in code-behind, for example, if the expression is too complex to be translated in XAML.

__Example 4: Set Expression for GridViewExpressionColumn in code.__

<snippet id='radgridview-columns-columntypes-expression-column-example_4_set_expression_for_gridviewexpressioncolumn_in_code-cs' />

<snippet id='radgridview-columns-columntypes-expression-column-example_4_set_expression_for_gridviewexpressioncolumn_in_code-vb' />


> The values displayed in GridViewExpressionColumn will be updated automatically when a concerned property on the data item changes.

More information about expressions could be found [here](http://www.telerik.com/help/silverlight/radexpressioneditor-expressions-overview.html).
