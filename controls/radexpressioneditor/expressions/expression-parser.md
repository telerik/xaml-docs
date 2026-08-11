---
title: Expression Parser
page_title: Expression Parser
description: Check out the documentation article for the RadExpressionParser {{ site.framework_name }} control.
slug: radexpressioneditor-expression-parser
tags: expression, parser
published: True
position: 0
---

# Expression Parser

In some scenarios, you do not need the graphical user interface of the RadExpressionEditor, but would rather just require its parsing logic for a given expression.

As of **R3 2021**, you can use the new **RadExpressionParser** class to achieve this requirement.

It exposes the following methods which you can use to parse your expressions:

* **LambdaExpression Parse(string expression)**
* **Task<LambdaExpression> ParseAsync(string expression)**
* **Task<LambdaExpression> ParseAsync(string expression, CancellationToken cancellationToken)**
* **bool TryParse(string expression, out LambdaExpression lambda)**

{% if site.site_name == 'WPF' %}
>Check out the [ExpressionParser](https://demos.telerik.com/wpf) online demo to see the RadExpressionParser in action.
{% else %}
>Check out the [ExpressionParser](https://demos.telerik.com/silverlight/#ExpressionEditor/ExpressionParser) online demo to see the RadExpressionParser in action.
{% endif %}

## Parse

You can use the **Parse** method to try to directly parse the expression and return a LambdaExpression if successfully parsed. Please note, however, that an **ExpressionParserException** will be thrown if the expression cannot be parsed.

__Example 1: Using the Parse method__

<snippet id='radexpressioneditor-expressions-expression-parser-example_1_using_the_parse_method-cs' />


## ParseAsync

The two overloads of the **ParseAsync** method operate in the same manner as the Parse method, with the difference being that they are performed **asynchronously**. In the second overload, aside from the expression to be parsed, you can pass a cancellation token that will be assigned to the new task.

## TryParse

The **TryParse** method tries to convert the string representation of an expression to its LambdaExpression equivalent. The returned value indicates whether the conversion succeeded or failed. The **out** parameter will contain **null** if the parsing was unsuccessful.

__Example 2: Using the TryParse method__

<snippet id='radexpressioneditor-expressions-expression-parser-example_2_using_the_tryparse_method-cs' />


## Item

You can use the **Item** property to be able to access the public members of the passed object.

__Example 3: Setting the Item property__

<snippet id='radexpressioneditor-expressions-expression-parser-example_3_setting_the_item_property-cs' />


Note that when using the generated expression, you would then need to pass the same item as the parameter as shown in **Example 4**.

__Example 4: Passing the Item as a parameter of the expression__

<snippet id='radexpressioneditor-expressions-expression-parser-example_4_passing_the_item_as_a_parameter_of_the_expression-cs' />


## See also

* [Function Invocation]({%slug radexpressioneditor-expressions-function-invocation%})
* [Custom Categories and Functions]({%slug radexpressioneditor-expressions-custom-functions-and-categories%})
* [Function Invocation]({%slug radexpressioneditor-expressions-function-invocation%})
