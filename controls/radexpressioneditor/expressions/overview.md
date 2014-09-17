---
title: Overview
page_title: Overview
description: Overview
slug: radexpressioneditor-expressions-overview
tags: overview
published: True
position: 0
---

# Overview



## 

The engine that powers RadExpressionEditor enables us to parse a string into a LINQ expression, which can be consumed by any API accepting a LINQ expression.

RadExpressionEditor always generates a LambdaExpression with one parameter. The type of the parameter is inferred from the value of the Item property of RadExpressionEditor instance. For more information on lambdas, please refer to the [Lambdas help topic]({%slug radexpressioneditor-expressions-lambdas%}).
Here are the basic concepts of the expression engine: 

* [Member Access]({%slug radexpressioneditor-expressions-member-access%})

* [Function Invocation]({%slug radexpressioneditor-expressions-function-invocation%})

* [Constants]({%slug radexpressioneditor-expressions-constants%})

* [Lambdas]({%slug radexpressioneditor-expressions-lambdas%})
