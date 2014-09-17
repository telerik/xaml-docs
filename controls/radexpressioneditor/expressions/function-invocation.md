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

RadExpressionEditor allows you to benefit from the built-in functions as well. So, you may easily invoke Distinct([List]) like: 

#### __XAML__

{{region radexpressioneditor-expressions-function-invocation_0}}
	“Distinct(Tasks)”
	{{endregion}}



In this case "Tasks" property should be of type IEnumerable. Distinct expression will return a list of the unique items in "Tasks" collection. 




         
      ![](images/RadExpressionEditor_DistinctExpression.png)



In the example above the Result preview displays the count of the distinct values in the "Tasks" collection. 

However, it is also possible to call methods on values in the expression. For instance, the expression “StartingDate.AddDays(3)” calls the AddDays() method of the DateTime value of the StartingDate property:




         
      ![](images/RadExpressionEditor_CallMethods.png)



In this case the Result preview displays the result after the method has been executed.
 
