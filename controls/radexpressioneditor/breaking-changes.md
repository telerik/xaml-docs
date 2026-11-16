---
title: Breaking Changes
page_title: WPF RadExpressionEditor Breaking Changes - Expression Function Registration
description: Review WPF RadExpressionEditor breaking changes; functions must be registered with ExpressionFunctionRegistry before expressions are parsed or evaluated.
components: ["expressioneditor"]
slug: radexpressioneditor-breaking-changes
tags: RadExpressionEditor, expression editor, breaking changes, expression evaluation, expression function registry, custom functions, function registration, migration
published: True
position: 4
---

# Breaking Changes

This article lists behavior changes that can require updates to existing `RadExpressionEditor` applications.

## Registering Functions for Expression Evaluation

Expression evaluation now invokes only functions explicitly registered with an `ExpressionFunctionRegistry`. Register custom functions in the active expression function context before parsing or evaluating expressions.

For details, see [Custom Categories and Functions]({%slug radexpressioneditor-expressions-custom-functions-and-categories%}).

## See Also

* [Parsing Expressions]({%slug radexpressioneditor-expression-parser%})
* [Invoking Functions]({%slug radexpressioneditor-expressions-function-invocation%})
* [Custom Categories and Functions]({%slug radexpressioneditor-expressions-custom-functions-and-categories%})
