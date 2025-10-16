---
title: Lambdas
page_title: Lambdas
description: Check our &quot;Lambdas&quot; documentation article for the RadExpressionEditor {{ site.framework_name }} control.
slug: radexpressioneditor-expressions-lambdas
tags: lambdas
published: True
position: 4
---

# Lambdas

__RadExpressionEditor__ allows you to benefit from the __Lambda expressions__ as well. However, in this case the syntax is slightly different.  

While the C# Lambda looks like __item => item.Salary__, the equivalent expression in __RadExpressionEditor__ should be defined like: __Salary__.
 
![{{ site.framework_name }} RadExpressionEditor Salary Lambda](images/RadExpressionEditor_Lambda.png)

The __Result preview__ displays the result of the expression.

Furthermore, you may also define __nested Lambdas__. For example the __LINQ expression__:



```C#

	item => item.Tasks.Where(param0 => param0.SubTasks.Count > 2)
```


is equivalent to:



```XAML

	Tasks.Where(SubTasks.Count > 20)
```


![{{ site.framework_name }} RadExpressionEditor Nested Lambda Expression](images/RadExpressionEditor_NestedLambda.png)

In the example above each __Employee__ has a property __Tasks__ and each __Task__ on its own has a property of __SubTasks__. The __Result preview__ displays the count of the __SubTasks__ properties which has more than one items.

>The __Where__ function in this example is actually the __Enumerable.Where(source, predicate)__ extension method. Because the predicate parameter is a lambda, __RadExpressionEditor__ automatically creates a second, nested, lambda from the string expression when parsing. This is valid for all __RadExpressionEditor__ functions which take a lambda parameter.


