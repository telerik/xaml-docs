---
title: Member Access
page_title: Member Access
description: Member Access
slug: radexpressioneditor-expressions-member-access
tags: member,access
published: True
position: 1
---

# Member Access



## 

You may access each member just as you do in C# and VB.NET.

A simple expression such as “Salary> 2500” will try to resolve the Salary property on the parameter of the generated LambdaExpression:




         
      ![](images/RadExpressionEditor_MemberAccess.png)



Nested member access is also possible. For instance, “Tasks.Count” will access the Count property of the value of the Tasks property in the expression’s parameter:




         
      ![](images/RadExpressionEditor_NestedMemberAccess.png)


