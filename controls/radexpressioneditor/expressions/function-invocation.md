---
title: Function Invocation
page_title: Function Invocation
description: Function Invocation
slug: radexpressioneditor-expressions-function-invocation
tags: function,invocation
published: True
position: 2
---

# Function Invocation



## 

__RadExpressionEditor__ allows you to benefit from the built-in functions as well. So, you may easily invoke __Distinct([List])__ like: 

#### __XAML__

{{region radexpressioneditor-expressions-function-invocation_0}}

	“Distinct(Tasks)”
{{endregion}}



In this case __"Tasks"__ property should be of type __IEnumerable__. Distinct expression will return a list of the unique items in __"Tasks"__ collection. 

![](images/RadExpressionEditor_DistinctExpression.png)



In the example above the __Result preview__ displays the count of the distinct values in the __"Tasks"__ collection. 

However, it is also possible to call methods on values in the expression. For instance, the expression __“StartingDate.AddDays(3)”__ calls the __AddDays()__ method of the __DateTime__ value of the __StartingDate__ property:
         

![](images/RadExpressionEditor_CallMethods.png)



In this case the __Result preview__ displays the result after the method has been executed.
 
