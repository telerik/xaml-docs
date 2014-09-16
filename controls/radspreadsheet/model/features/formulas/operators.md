---
title: Operators
page_title: Operators
description: Operators
slug: radspreadsheet-features-formulas-operators
tags: operators
publish: False
position: 0
---

# Operators



This article lists and explains all supported by __RadSpreadsheet__ operators.
      

## Supported Operators

__RadSpreadsheet__ supports four groups of operators: arithmetic, comparison, text and reference.
        
<table><th><tr><td>

Arithmetic Operators</td><td></td></tr></th><tr><td>

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
<table><th><tr><td>

Comparison Operators</td><td></td></tr></th><tr><td>

=</td><td>

Equal to (A1=3)</td></tr><tr><td>

></td><td>

Greater than (A1>4)</td></tr><tr><td>

<</td><td>

Less than (A1<5)</td></tr><tr><td>

>=</td><td>

Greater than or equal to (A1>=6)</td></tr><tr><td>

<=</td><td>

Less than or equal to (A1<=7)</td></tr><tr><td>

<></td><td>

Not equal to (A1<>8)</td></tr></table>
<table><th><tr><td>

Concatenation Operator</td><td></td></tr></th><tr><td>

& (Ampersand)</td><td>

Concatenates text values ("Rad"&"Spreadsheet")</td></tr></table>
<table><th><tr><td>

Reference Operator</td><td></td></tr></th><tr><td>

: (Colon)</td><td>

Produces a reference to a range of cells between two specified cells, including these two cells. (A1:C3)</td></tr><tr><td>

, (Space)</td><td>

Intersection operator. Returns a reference to the cells that two ranges have in common. (A1:C3 B2:C2)</td></tr></table>

## Operator Precedence

If you combine multiple operators in a single formula, __RadSpreadsheet__ will evaluate the expression in order determined by the
          precedence of its operators. If two operators have equal precedence, they will be evaluated from left to right. The following table contains all
          operators sorted by precedence in descending order:
        
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

= (Equal)

> (Greater than)

< (Less than)

>= (Greater than or equal to)

<= (Less than or equal to)

<> (Not equal)</td><td>

Comparison operators</td></tr></table>

The order of operations within an expression can be changed through applying parenthesis.

# See Also
