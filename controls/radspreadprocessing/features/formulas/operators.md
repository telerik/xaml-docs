---
title: Operator
page_title: Operator
description: Operator
slug: radspreadprocessing-features-formulas-operators
tags: operator
published: True
position: 1
---

# Operator



This article lists and explains all supported operators.
      

## Supported Operators

The document model supports four groups of operators: arithmetic, comparison, text and reference.
        
<table><tr><th>

Arithmetic Operators</th><th></th></tr><tr><td>

+ (Plus sign)</td><td>

Addition (1+2)</td></tr><tr><td>

- (Minus sign)</td><td>

Subtraction (2-1) or negation (-1)</td></tr><tr><td>

* (Asterisk)</td><td>

Multiplication (2*2)</td></tr><tr><td>

/ (Forward slash)</td><td>

Division (5/2)</td></tr><tr><td>

% (Percent sign)</td><td>

Percent (10%)</td></tr><tr><td>

^ (Caret)</td><td>

Exponentiation (5^2)</td></tr></table>
<table>
<tr>
<th>

Comparison Operators
</th>
<th></th>
</tr>
</th>
<tr>
<td>

=</td><td>

Equal to (A1=3)</td></tr><tr><td>

>
</td><td>

Greater than (A1>4)</td></tr><tr><td>

&lt;
</td><td>

Less than (A1<5)</td></tr><tr><td>

>=</td><td>

Greater than or equal to (A1>=6)</td></tr><tr><td>

&lt;=</td><td>

Less than or equal to (A1<=7)</td></tr><tr><td>

&lt;></td><td>

Not equal to (A1<>8)</td></tr></table>
<table><tr><th>

Concatenation Operator</th><th></th></tr><tr><td>

& (Ampersand)</td><td>

Concatenates text values ("Rad"&"Spreadsheet")</td></tr></table>
<table><tr><th>

Reference Operator</th><th></th></tr><tr><td>

: (Colon)</td><td>

Produces a reference to a range of cells between two specified cells, including these two cells. (A1:C3)</td></tr><tr><td>

, (Space)</td><td>

Intersection operator. Returns a reference to the cells that two ranges have in common. (A1:C3 B2:C2)</td></tr></table>

## Operator Precedence

If you combine multiple operators in a single formula, the expression is evaluated in order determined by the precedence of the operators. If two operators have equal precedence, they are evaluated from left to right. The following table contains all operators sorted by precedence in descending order:
        
<table><tr><td>

: (Colon) , (Space)</td><td>

Reference Operators</td></tr><tr><td>

- (Minus)</td><td>

Negation (-2)</td></tr><tr><td>

^ (Caret)</td><td>

Exponentiation</td></tr><tr><td>

* (Asterisk) / (Forward slash)</td><td>

Multiplication and division</td></tr><tr><td>

+ (Plus sign) - (Minus sign)</td><td>

Addition and subtraction</td></tr><tr><td>

& (Ampersand)</td><td>

Concatenates two strings</td></tr><tr><td>

= (Equal) <br />

> (Greater than) <br />

&lt; (Less than) <br />

>= (Greater than or equal to) <br />

&lt;= (Less than or equal to)  <br />

&lt;> (Not equal)</td><td>

Comparison operators</td></tr></table>

The order of operations within an expression can be changed through applying parenthesis.
