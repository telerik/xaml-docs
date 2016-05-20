---
title: Functions
page_title: Functions
description: Functions
slug: radspreadprocessing-features-formulas-functions
tags: functions
published: True
position: 3
---

# Functions



The document model provides a number of built-in functions that you can use in formula values.
      

The model offers functions in the following categories: Date and Time, Financial, Information, Logical, Lookup and Reference, Math and Trigonometry, Statistical, and Text. To use a predefined function in a formula, enter its name followed by opening bracket. Further, if the function has parameters, list the arguments separated by the current culture list separator. Finally, add the closing bracket.
      

For example, the formula *=SUM(1, A2)* adds one to the value of cell A2. Note that if the function does not have parameters, you still have to place the opening and closing brackets after its name, e.g. *=PI()*. Functions can be used as standalone values, operands and arguments of other functions.
      

## Supported Functions

The document model supports the following functions:
        
<table><tr><th>

Date and Time Functions</th><th></th></tr><tr><td>

DATE</td><td>

Returns the serial number of a particular date</td></tr><tr><td>

DATEVALUE</td><td>

Converts a date in the form of text to a serial number</td></tr><tr><td>

DAY</td><td>

Converts a serial number to a day of the month</td></tr><tr><td>

HOUR</td><td>

Converts a serial number to an hour</td></tr><tr><td>

MINUTE</td><td>

Converts a serial number to a minute</td></tr><tr><td>

MONTH</td><td>

Converts a serial number to a month</td></tr><tr><td>

SECOND</td><td>

Converts a serial number to a second</td></tr><tr><td>

TIME</td><td>

Returns the serial number of a particular time</td></tr><tr><td>

TIMEVALUE</td><td>

Converts a time in the form of text to a serial number</td></tr><tr><td>

TODAY</td><td>

Returns the serial number of today's date</td></tr><tr><td>

YEAR</td><td>

Converts a serial number to a year</td></tr></table>
<table><tr><th>

Engineering Functions</th><th></th></tr><tr><td>

BESSELI</td><td>

Returns the modified Bessel function In(x)</td></tr><tr><td>

BESSELJ</td><td>

Returns the Bessel function Jn(x)</td></tr><tr><td>

BESSELK</td><td>

Returns the modified Bessel function Kn(x)</td></tr><tr><td>

BESSELY</td><td>

Returns the Bessel function Yn(x)</td></tr><tr><td>

BIN2DEC</td><td>

Converts a binary number to decimal</td></tr><tr><td>

BIN2HEX</td><td>

Converts a binary number to hexadecimal</td></tr><tr><td>

BIN2OCT</td><td>

Converts a binary number to octal</td></tr><tr><td>

BITAND</td><td>

Returns a 'Bitwise And' of two numbers</td></tr><tr><td>

BITLSHIFT</td><td>

Returns a value number shifted left by shift_amount bits</td></tr><tr><td>

BITOR</td><td>

Returns a bitwise OR of 2 numbers</td></tr><tr><td>

BITRSHIFT</td><td>

Returns a value number shifted right by shift_amount bits</td></tr><tr><td>

BITXOR</td><td>

Returns a bitwise 'Exclusive Or' of two numbers</td></tr><tr><td>

COMPLEX</td><td>

Converts real and imaginary coefficients into a complex number</td></tr><tr><td>

CONVERT</td><td>

Converts a number from one measurement system to another</td></tr><tr><td>

DEC2BIN</td><td>

Converts a decimal number to binary</td></tr><tr><td>

DEC2HEX</td><td>

Converts a decimal number to hexadecimal</td></tr><tr><td>

DEC2OCT</td><td>

Converts a decimal number to octal</td></tr><tr><td>

DELTA</td><td>

Tests whether two values are equal</td></tr><tr><td>

ERF</td><td>

Returns the error function</td></tr><tr><td>

ERF.PRECISE</td><td>

Returns the error function</td></tr><tr><td>

ERFC</td><td>

Returns the complementary error function</td></tr><tr><td>

ERFC.PRECISE</td><td>

Returns the complementary ERF function integrated between x and infinity</td></tr><tr><td>

GESTEP</td><td>

Tests whether a number is greater than a threshold value</td></tr><tr><td>

HEX2BIN</td><td>

Converts a hexadecimal number to binary</td></tr><tr><td>

HEX2DEC</td><td>

Converts a hexadecimal number to decimal</td></tr><tr><td>

HEX2OCT</td><td>

Converts a hexadecimal number to octal</td></tr><tr><td>

IMABS</td><td>

Returns the absolute value (modulus) of a complex number</td></tr><tr><td>

IMAGINARY</td><td>

Returns the imaginary coefficient of a complex number</td></tr><tr><td>

IMARGUMENT</td><td>

Returns the argument theta, an angle expressed in radians</td></tr><tr><td>

IMCONJUGATE</td><td>

Returns the complex conjugate of a complex number</td></tr><tr><td>

IMCOS</td><td>

Returns the cosine of a complex number</td></tr><tr><td>

IMCOSH</td><td>

Returns the hyperbolic cosine of a complex number</td></tr><tr><td>

IMCOT</td><td>

Returns the cotangent of a complex number</td></tr><tr><td>

IMCSC</td><td>

Returns the cosecant of a complex number</td></tr><tr><td>

IMCSCH</td><td>

Returns the hyperbolic cosecant of a complex number</td></tr><tr><td>

IMDIV</td><td>

Returns the quotient of two complex numbers</td></tr><tr><td>

IMEXP</td><td>

Returns the exponential of a complex number</td></tr><tr><td>

IMLN</td><td>

Returns the natural logarithm of a complex number</td></tr><tr><td>

IMLOG10</td><td>

Returns the base-10 logarithm of a complex number</td></tr><tr><td>

IMLOG2</td><td>

Returns the base-2 logarithm of a complex number</td></tr><tr><td>

IMPOWER</td><td>

Returns a complex number raised to an integer power</td></tr><tr><td>

IMPRODUCT</td><td>

Returns the product of from 2 to 255 complex numbers</td></tr><tr><td>

IMREAL</td><td>

Returns the real coefficient of a complex number</td></tr><tr><td>

IMSEC</td><td>

Returns the secant of a complex number</td></tr><tr><td>

IMSECH</td><td>

Returns the hyperbolic secant of a complex number</td></tr><tr><td>

IMSIN</td><td>

Returns the sine of a complex number</td></tr><tr><td>

IMSINH</td><td>

Returns the hyperbolic sine of a complex number</td></tr><tr><td>

IMSQRT</td><td>

Returns the square root of a complex number</td></tr><tr><td>

IMSUB</td><td>

Returns the difference between two complex numbers</td></tr><tr><td>

IMSUM</td><td>

Returns the sum of complex numbers</td></tr><tr><td>

IMTAN</td><td>

Returns the tangent of a complex number</td></tr><tr><td>

OCT2BIN</td><td>

Converts an octal number to binary</td></tr><tr><td>

OCT2DEC</td><td>

Converts an octal number to decimal</td></tr><tr><td>

OCT2HEX</td><td>

Converts an octal number to hexadecimal</td></tr></table>
<table><tr><th>

Financial Functions</th><th></th></tr><tr><td>

ACCRINTM</td><td>

Returns the accrued interest for a security that pays interest at maturity</td></tr><tr><td>

AMORDEGRC</td><td>

Returns the depreciation for each accounting period by using a depreciation coefficient</td></tr><tr><td>

AMORLINC</td><td>

Returns the depreciation for each accounting period</td></tr><tr><td>

COUPDAYBS</td><td>

Returns the number of days from the beginning of the coupon period to the settlement date</td></tr><tr><td>

COUPDAYS</td><td>

Returns the number of days in the coupon period that contains the settlement date</td></tr><tr><td>

COUPDAYSNC</td><td>

Returns the number of days from the settlement date to the next coupon date</td></tr><tr><td>

COUPNCD</td><td>

Returns the next coupon date after the settlement date</td></tr><tr><td>

COUPNUM</td><td>

Returns the number of coupons payable between the settlement date and maturity date</td></tr><tr><td>

COUPPCD</td><td>

Returns the previous coupon date before the settlement date</td></tr><tr><td>

CUMIPMT</td><td>

Returns the cumulative interest paid between two periods</td></tr><tr><td>

CUMPRINC</td><td>

Returns the cumulative principal paid on a loan between two periods</td></tr><tr><td>

DB</td><td>

Returns the depreciation of an asset for a specified period by using the fixed-declining balance method</td></tr><tr><td>

DISC</td><td>

Returns the discount rate for a security</td></tr><tr><td>

DOLLARDE</td><td>

Converts a dollar price, expressed as a fraction, into a dollar price, expressed as a decimal number</td></tr><tr><td>

DOLLARFR</td><td>

Converts a dollar price, expressed as a decimal number, into a dollar price, expressed as a fraction</td></tr><tr><td>

DURATION</td><td>

Returns the annual duration of a security with periodic interest payments</td></tr><tr><td>

EFFECT</td><td>

Returns the effective annual interest rate</td></tr><tr><td>

FV</td><td>

Returns the future value of an investment</td></tr><tr><td>

INTRATE</td><td>

Returns the interest rate for a fully invested security</td></tr><tr><td>

IPMT</td><td>

Returns the interest payment for an investment for a given period</td></tr><tr><td>

ISPMT</td><td>

Calculates the interest paid during a specific period of an investment</td></tr><tr><td>

MDURATION</td><td>

Returns the Macauley modified duration for a security with an assumed par value of $100</td></tr><tr><td>

NOMINAL</td><td>

Returns the annual nominal interest rate</td></tr><tr><td>

NPER</td><td>

Returns the number of periods for an investment</td></tr><tr><td>

NPV</td><td>

Returns the net present value of an investment based on a series of periodic cash flows and a discount rate</td></tr><tr><td>

ODDFPRICE</td><td>

Returns the price per $100 face value of a security with an odd first period</td></tr><tr><td>

ODDFYIELD</td><td>

Returns the yield of a security with an odd first period</td></tr><tr><td>

ODDLPRICE</td><td>

Returns the price per $100 face value of a security with an odd last period</td></tr><tr><td>

ODDLYIELD</td><td>

Returns the yield of a security with an odd last period</td></tr><tr><td>

PDURATION</td><td>

Returns the number of periods required by an investment to reach a specified value</td></tr><tr><td>

PMT</td><td>

Returns the periodic payment for an annuity</td></tr><tr><td>

PPMT</td><td>

Returns the payment on the principal for an investment for a given period</td></tr><tr><td>

PRICE</td><td>

Returns the price per $100 face value of a security that pays periodic interest</td></tr><tr><td>

PRICEDISC</td><td>

Returns the price per $100 face value of a discounted security</td></tr><tr><td>

PV</td><td>

Returns the present value of an investment</td></tr><tr><td>

RATE</td><td>

Returns the interest rate per period of an annuity</td></tr><tr><td>

RECEIVED</td><td>

Returns the amount received at maturity for a fully invested security</td></tr><tr><td>

RRI</td><td>

Returns an equivalent interest rate for the growth of an investment</td></tr><tr><td>

SLN</td><td>

Returns the straight-line depreciation of an asset for one period</td></tr><tr><td>

SYD</td><td>

Returns the sum-of-years' digits depreciation of an asset for a specified period</td></tr><tr><td>

TBILLEQ</td><td>

Returns the bond-equivalent yield for a Treasury bill</td></tr><tr><td>

TBILLPRICE</td><td>

Returns the price per $100 face value for a Treasury bill</td></tr><tr><td>

TBILLYIELD</td><td>

Returns the yield for a Treasury bill</td></tr><tr><td>

VDB</td><td>

Returns the depreciation of an asset for a specified or partial period by using a declining balance method</td></tr><tr><td>

YIELD</td><td>

Returns the yield on a security that pays periodic interest</td></tr><tr><td>

YIELDDISC</td><td>

Returns the annual yield for a discounted security; for example, a Treasury bill</td></tr><tr><td>

YIELDMAT</td><td>

Returns the annual yield of a security that pays interest at maturity</td></tr></table>
<table><tr><th>

Information Functions</th><th></th></tr><tr><td>

ERROR.TYPE</td><td>

Returns a number corresponding to an error type</td></tr><tr><td>

ISBLANK</td><td>

Returns TRUE if the value is blank</td></tr><tr><td>

ISERR</td><td>

Returns TRUE if the value is any error value except #N/A</td></tr><tr><td>

ISERROR</td><td>

Returns TRUE if the value is any error value</td></tr><tr><td>

ISEVEN</td><td>

Returns TRUE if the number is even</td></tr><tr><td>

ISFORMULA</td><td>

Returns TRUE if there is a reference to a cell that contains a formula</td></tr><tr><td>

ISLOGICAL</td><td>

Returns TRUE if the value is a logical value</td></tr><tr><td>

ISNA</td><td>

Returns TRUE if the value is the #N/A error value</td></tr><tr><td>

ISNONTEXT</td><td>

Returns TRUE if the value is not text</td></tr><tr><td>

ISNUMBER</td><td>

Returns TRUE if the value is a number</td></tr><tr><td>

ISODD</td><td>

Returns TRUE if the number is odd</td></tr><tr><td>

ISREF</td><td>

Returns TRUE if the value is a reference</td></tr><tr><td>

ISTEXT</td><td>

Returns TRUE if the value is text</td></tr><tr><td>

N</td><td>

Returns a value converted to a number</td></tr><tr><td>

NA</td><td>

Returns the error value #N/A</td></tr><tr><td>

TYPE</td><td>

Returns a number indicating the data type of a value</td></tr></table>
<table><tr><th>

Logical Functions</th><th></th></tr><tr><td>

AND</td><td>

Returns TRUE if all of its arguments are TRUE</td></tr><tr><td>

FALSE</td><td>

Returns the logical value FALSE</td></tr><tr><td>

IF</td><td>

Specifies a logical test to perform</td></tr><tr><td>

NOT</td><td>

Reverses the logic of its argument</td></tr><tr><td>

OR</td><td>

Returns TRUE if any argument is TRUE</td></tr><tr><td>

TRUE</td><td>

Returns the logical value TRUE</td></tr><tr><td>

XOR</td><td>

Returns a logical exclusive OR of all arguments</td></tr></table>
<table><tr><th>

Lookup and Reference Functions</th><th></th></tr><tr><td>

HYPERLINK</td><td>

Creates a shortcut or jump that opens a document stored on a network server, an intranet, or the Internet</td></tr><tr><td>

INDEX</td><td>

Uses an index to choose a value from a reference or array</td></tr><tr><td>

LOOKUP</td><td>

Looks up values in a vector or array</td></tr>

<tr><td>
INDIRECT</td><td>

Returns the cell reference specified by a text string. The references are evaluated immediately to display their values. The text string, passed as an argument could be a reference to a cell that contains an A1-style reference, a name defined as a reference, or a reference to a cell as a text string</td></tr>

</table>
<table><tr><th>

Math and Trigonometry Functions</th><th></th></tr><tr><td>

ABS</td><td>

Returns the absolute value of a number</td></tr><tr><td>

ACOS</td><td>

Returns the arccosine of a number</td></tr><tr><td>

ACOSH</td><td>

Returns the inverse hyperbolic cosine of a number</td></tr><tr><td>

ACOT</td><td>

Returns the arccotangent of a number</td></tr><tr><td>

ACOTH</td><td>

Returns the hyperbolic arccotangent of a number</td></tr><tr><td>

ASIN</td><td>

Returns the arcsine of a number</td></tr><tr><td>

ASINH</td><td>

Returns the inverse hyperbolic sine of a number</td></tr><tr><td>

ATAN</td><td>

Returns the arctangent of a number</td></tr><tr><td>

ATAN2</td><td>

Returns the arctangent from x- and y-coordinates</td></tr><tr><td>

ATANH</td><td>

Returns the inverse hyperbolic tangent of a number</td></tr><tr><td>

CEILING</td><td>

Rounds a number to the nearest integer or to the nearest multiple of significance</td></tr><tr><td>

CEILING.MATH</td><td>

Rounds a number up, to the nearest integer or to the nearest multiple of significance</td></tr><tr><td>

CEILING.PRECISE</td><td>

Rounds a number the nearest integer or to the nearest multiple of significance. Regardless of the sign of the number, the number is rounded up.</td></tr><tr><td>

COMBIN</td><td>

Returns the number of combinations for a given number of objects</td></tr><tr><td>

COS</td><td>

Returns the cosine of a number</td></tr><tr><td>

COSH</td><td>

Returns the hyperbolic cosine of a number</td></tr><tr><td>

COT</td><td>

Returns the cotangent of an angle</td></tr><tr><td>

COTH</td><td>

Returns the hyperbolic cotangent of a number</td></tr><tr><td>

CSC</td><td>

Returns the cosecant of an angle</td></tr><tr><td>

CSCH</td><td>

Returns the hyperbolic cosecant of an angle</td></tr><tr><td>

DEGREES</td><td>

Converts radians to degrees</td></tr><tr><td>

EVEN</td><td>

Rounds a number up to the nearest even integer</td></tr><tr><td>

EXP</td><td>

Returns e raised to the power of a given number</td></tr><tr><td>

FACT</td><td>

Returns the factorial of a number</td></tr><tr><td>

FACTDOUBLE</td><td>

Returns the double factorial of a number</td></tr><tr><td>

FLOOR</td><td>

Rounds a number down, toward zero</td></tr><tr><td>

FLOOR.MATH</td><td>

Rounds a number down, to the nearest integer or to the nearest multiple of significance</td></tr><tr><td>

FLOOR.PRECISE</td><td>

Rounds a number down to the nearest integer or to the nearest multiple of significance. Regardless of the sign of the number, the number is rounded down.</td></tr><tr><td>

GCD</td><td>

Returns the greatest common divisor</td></tr><tr><td>

INT</td><td>

Rounds a number down to the nearest integer</td></tr><tr><td>

ISO.CEILING</td><td>

Returns a number that is rounded up to the nearest integer or to the nearest multiple of significance</td></tr><tr><td>

LCM</td><td>

Returns the least common multiple</td></tr><tr><td>

LN</td><td>

Returns the natural logarithm of a number</td></tr><tr><td>

LOG</td><td>

Returns the logarithm of a number to a specified base</td></tr><tr><td>

LOG10</td><td>

Returns the base-10 logarithm of a number</td></tr><tr><td>

MOD</td><td>

Returns the remainder from division</td></tr><tr><td>

MROUND</td><td>

Returns a number rounded to the desired multiple</td></tr><tr><td>

MULTINOMIAL</td><td>

Returns the multinomial of a set of numbers</td></tr><tr><td>

ODD</td><td>

Rounds a number up to the nearest odd integer</td></tr><tr><td>

PI</td><td>

Returns the value of pi</td></tr><tr><td>

POWER</td><td>

Returns the result of a number raised to a power</td></tr><tr><td>

PRODUCT</td><td>

Multiplies its arguments</td></tr><tr><td>

QUOTIENT</td><td>

Returns the integer portion of a division</td></tr><tr><td>

RADIANS</td><td>

Converts degrees to radians</td></tr><tr><td>

ROUND</td><td>

Rounds a number to a specified number of digits</td></tr><tr><td>

ROUNDDOWN</td><td>

Rounds a number down, toward zero</td></tr><tr><td>

ROUNDUP</td><td>

Rounds a number up, away from zero</td></tr><tr><td>

SEC</td><td>

Returns the secant of an angle</td></tr><tr><td>

SECH</td><td>

Returns the hyperbolic secant of an angle</td></tr><tr><td>

SIGN</td><td>

Returns the sign of a number</td></tr><tr><td>

SIN</td><td>

Returns the sine of the given angle</td></tr><tr><td>

SINH</td><td>

Returns the hyperbolic sine of a number</td></tr><tr><td>

SQRT</td><td>

Returns a positive square root</td></tr><tr><td>

SQRTPI</td><td>

Returns the square root of (number * pi)</td></tr><tr><td>

SUM</td><td>

Adds its arguments</td></tr><tr><td>

SUMIF</td><td>

Adds the cells specified by a given criteria</td></tr><tr><td>

SUMSQ</td><td>

Returns the sum of the squares of the arguments</td></tr><tr><td>

TAN</td><td>

Returns the tangent of a number</td></tr><tr><td>

TANH</td><td>

Returns the hyperbolic tangent of a number</td></tr><tr><td>

TRUNC</td><td>

Truncates a number to an integer</td></tr></table>
<table><tr><th>

Statistical Functions</th><th></th></tr><tr><td>

AVERAGE</td><td>

Returns the average of its arguments</td></tr><tr><td>

AVERAGEA</td><td>

Returns the average of its arguments, including numbers, text, and logical values</td></tr><tr><td>

COUNTIF</td><td>

Counts the number of cells within a range that meet the given criteria</td></tr><tr><td>

MAX</td><td>

Returns the maximum value in a list of arguments</td></tr><tr><td>

MAXA</td><td>

Returns the maximum value in a list of arguments, including numbers, text, and logical values</td></tr><tr><td>

MEDIAN</td><td>

Returns the median of the given numbers</td></tr><tr><td>

MIN</td><td>

Returns the minimum value in a list of arguments</td></tr><tr><td>

MINA</td><td>

Returns the smallest value in a list of arguments, including numbers, text, and logical values</td></tr><tr><td>

MODE</td><td>

Returns the most common value in a data set</td></tr><tr><td>

STDEV</td><td>

Estimates standard deviation based on a sample</td></tr><tr><td>

STDEVA</td><td>

Estimates standard deviation based on a sample, including numbers, text, and logical values</td></tr><tr><td>

STDEVP</td><td>

Calculates standard deviation based on the entire population</td></tr><tr><td>

STDEVPA</td><td>

Calculates standard deviation based on the entire population, including numbers, text, and logical values</td></tr></table>
<table><tr><th>

Text Functions</th><th></th></tr><tr><td>

CHAR</td><td>

Returns the character specified by the code number</td></tr><tr><td>

CODE</td><td>

Returns a numeric code for the first character in a text string</td></tr><tr><td>

CONCATENATE</td><td>

Joins several text items into one text item</td></tr><tr><td>

EXACT</td><td>

Checks to see if two text values are identical</td></tr><tr><td>

FIND</td><td>

Finds one text value within another (case-sensitive)</td></tr><tr><td>

LEFT</td><td>

Returns the leftmost characters from a text value</td></tr><tr><td>

LEN</td><td>

Returns the number of characters in a text string</td></tr><tr><td>

LOWER</td><td>

Converts text to lowercase</td></tr><tr><td>

REPT</td><td>

Repeats text a given number of times</td></tr><tr><td>

RIGHT</td><td>

Returns the rightmost characters from a text value</td></tr><tr><td>

SEARCH</td><td>

Finds one text value within another (not case-sensitive)</td></tr><tr><td>

UPPER</td><td>

Converts text to uppercase</td></tr></table>
