---
title: Error Handling
page_title: Error Handling
description: Check out the documentation article for handling errors in the RadExpressionEditor {{ site.framework_name }} control.
slug: radexpressioneditor-error-handling
tags: expressionerror, errors, expressioneditor
published: True
position: 0
---

# Error Handling

As of **R3 2021** the RadExpressionEditor exposes an **ExpressionError** event which is fired when an error occurs while parsing an expression. In addition, an **Errors** property was introduced which holds a collection of the errors from a failed parsing operation.

__Example 1: Handling the ExpressionError event__
```XAML
    this.expressionEditor.ExpressionError += (s, e) =>
    {
        var errors = string.Join("\n", this.expressionEditor.Errors.Select(er => er.Message));

        // display the errors to the user
    };
```

The Errors collection holds instances of the **ExpressionParserError** class which exposes the following members:

* **Start**: The start location of the error message. It is of type **ExpressionLocation** and holds the line and column where the errors starts.
* **End**: The end location of the error message. It is of type **ExpressionLocation** and holds the line and column where the errors ends.
* **Message**: The error message.

You can use this information to present the errors in a user-friendly manner.

## See also

* [Function Invocation]({%slug radexpressioneditor-expressions-function-invocation%})
* [Custom Categories and Functions]({%slug radexpressioneditor-expressions-custom-functions-and-categories%})
* [Function Invocation]({%slug radexpressioneditor-expressions-function-invocation%})
