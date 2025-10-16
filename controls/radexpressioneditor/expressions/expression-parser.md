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

```C#
    try
    {
        var lambdaExpression = expressionParser.Parse(expression);
        var result = lambdaExpression.Compile().DynamicInvoke().ToString();
    }
    catch (ExpressionParserException ex)
    {
        var errorMessages = string.Join("\n", ex.Errors.Select(er => er.Message));
    }
```

## ParseAsync

The two overloads of the **ParseAsync** method operate in the same manner as the Parse method, with the difference being that they are performed **asynchronously**. In the second overload, aside from the expression to be parsed, you can pass a cancellation token that will be assigned to the new task.

## TryParse

The **TryParse** method tries to convert the string representation of an expression to its LambdaExpression equivalent. The returned value indicates whether the conversion succeeded or failed. The **out** parameter will contain **null** if the parsing was unsuccessful.

__Example 2: Using the TryParse method__

```C#
    LambdaExpression lambdaExpression;
    var isExpressionValid = expressionParser.TryParse(expression, out lambdaExpression);
    if (isExpressionValid)
    {
        var result = lambdaExpression.Compile().DynamicInvoke().ToString();
    }
    else
    {
        // display an error message
    }
```

## Item

You can use the **Item** property to be able to access the public members of the passed object.

__Example 3: Setting the Item property__

```C#
    this.expressionParser.Item = this.ProductsGridView.SelectedItem;
```

Note that when using the generated expression, you would then need to pass the same item as the parameter as shown in **Example 4**.

__Example 4: Passing the Item as a parameter of the expression__

```C#
    var lambdaExpression = this.expressionParser.Parse(expression);
    string result;
    if (lambdaExpression.Parameters.Count == 1)
    {
        result = lambdaExpression.Compile().DynamicInvoke(this.expressionParser.Item).ToString();
    }
    else
    {
        result = lambdaExpression.Compile().DynamicInvoke().ToString();
    }
```

## See also

* [Function Invocation]({%slug radexpressioneditor-expressions-function-invocation%})
* [Custom Categories and Functions]({%slug radexpressioneditor-expressions-custom-functions-and-categories%})
* [Function Invocation]({%slug radexpressioneditor-expressions-function-invocation%})
