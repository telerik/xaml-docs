---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadExpressionEditor {{ site.framework_name }} control.
slug: radexpressioneditor-expressions-overview
tags: overview
published: True
position: 0
---

# Overview

The engine that powers __RadExpressionEditor__ enables us to parse a string into a __LINQ expression__, which can be consumed by any __API__ accepting a __LINQ expression__.

__RadExpressionEditor__ always generates a __LambdaExpression__ with one parameter. The type of the parameter is inferred from the value of the Item property of __RadExpressionEditor__ instance. For more information on lambdas, please refer to the [Lambdas help topic]({%slug radexpressioneditor-expressions-lambdas%}).

Once the Expression is available, you can also compile it manually like so:

#### __C#__
```C#
	var expr = (LambdaExpression)ExpressionEditor.Expression;
    if (expr != null)
    {
        var newBody = System.Linq.Expressions.Expression.Convert(expr.Body, typeof(int));
        var expr2 = System.Linq.Expressions.Expression.Lambda(newBody, expr.Parameters) as Expression<Func<Club, int>>;
        var func = expr2.Compile();
    }
```

Here are the basic concepts of the expression engine: 

* [Member Access]({%slug radexpressioneditor-expressions-member-access%})
* [Function Invocation]({%slug radexpressioneditor-expressions-function-invocation%})
* [Constants]({%slug radexpressioneditor-expressions-constants%})
* [Lambdas]({%slug radexpressioneditor-expressions-lambdas%})
