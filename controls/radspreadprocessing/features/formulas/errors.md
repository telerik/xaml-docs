---
title: Errors
page_title: Errors
description: Errors
slug: radspreadprocessing-features-formulas-errors
tags: errors
published: True
position: 4
---

# Errors



In some cases formula values may return errors. For example, it might have happened that you entered an invalid algebraic expression, or maybe you are referencing a cell that does not exist. The specific error value which is returned can hint the cause of the issue and, therefore, facilitate the process of finding a solution.
      

## 

The following table contains information about all supported errors.
        
<table><tr><td>

#DIV/0!
              </td><td>

<b>Divide by Zero Error</b> occurs when the formula contains an expression that results in division by zero. For example, such
                error is produced when the following expression is calculated: <i>=5/0</i>.
              </td></tr><tr><td>

#VALUE!
              </td><td>

<b>Error in Value</b> occurs when an argument is not of the correct type. For example, passing the ABS function (ABS function
                returns the absolute value of a number) a text value as an argument (which is not a text number representation, such as "5") produces the
                #VALUE! error: <i>=ABS("string")</i>.
              </td></tr><tr><td>

#REF!
              </td><td>

<b>Reference Error</b> implies that the referenced cell does not exist (e.g. <i>ABCDE1</i>) or has been
                deleted.
              </td></tr><tr><td>

#NAME?
              </td><td>

<b>Invalid Name Error</b> indicates that the cell value contains a name of an unknown function or variable. For example, attempt
                to use a function that is not in the built-in functions list will produce the #NAME? error: <i>=ABCDEF()</i>. Another case
                that will produce the error is use of undefined name.
              </td></tr><tr><td>

#NUM!
              </td><td>

<b>Number Error</b> indicates that the number does not meet function requirements. For example, passing the LN function (LN
                function returns the natural logarithm of a number) a negative number as argument produces #NUM! error: <i>=LN(-10)</i>.
              </td></tr><tr><td>

#N/A
              </td><td>

<b>Value Not Available Error</b> occurs when a function cannot produce a valid output. For example, passing the MODE function
                (MODE function returns the most frequently occurring or repetitive value in an array or range of data) the arguments 1, 2, 3 will cause the #N/A
                error because each of the numbers appears exactly once and, therefore, the set of numbers does not have a mode: <i>=MODE(1,2,3)</i>.
              </td></tr><tr><td>

#NULL
              </td><td>

<b>Null Error</b> occurs when the two cell ranges passed to an intersection operator do not intersect. For example, the value
                =A1:A2 B1:B2 returns null error since the two ranges to not have cells in common.
              </td></tr></table>
