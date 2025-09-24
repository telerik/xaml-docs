---
title: Formatting
page_title: Formatting
description: Check our &quot;Formatting&quot; documentation article for the RadNumericUpDown {{ site.framework_name }} control.
slug: radnumericupdown-formatting
tags: formatting
published: True
position: 1
---

# Formatting

This article will explain in details the different formatting option of __RadNumericUpDown__.

## Using ValueFormat      

RadNumericUpDown has the ability to format its value in three different formats specified by the __ValueFormat__ property.

Here is a brief description of each value in the ValueFormat enumerator property.

* __Numeric__ - used for numeric values without specific formatting, the default value is taken from the current culture of Windows. The specific Numeric format is described by all members of __NumberFormatInfo__ starting with __Numeric__ prefix.

* __Currency -__ used for currency values, the default currency formatting is taken from the current culture of Windows. The specific Currency format is described by all members of __NumberFormatInfo__ starting with __Currency__ prefix.

* __Percentage__ - used for percentage values, the default percentage value is taken from the current culture of Windows. The specific Percentage format is described by all members of __NumberFormatInfo__ starting with __Percentage__ prefix.

The following examples shows how to use ValueFormat and __NumberFormatInfo__ properties to achieve the deserved format:        

* __ValueFormat set to Numeric__



```C#
	private RadNumericUpDown TestMethod()
	{
	    RadNumericUpDown numeric = new RadNumericUpDown();
	    numeric.Value = 15.50;
	    numeric.ValueFormat = ValueFormat.Numeric;
	    numeric.NumberFormatInfo = new NumberFormatInfo() { NumberDecimalDigits = 0 };
	    //ContentText is "16"
	    return numeric;
	}
```



```VB.NET
	Private Function TestMethod() As RadNumericUpDown
	    Dim numeric As RadNumericUpDown = New RadNumericUpDown
	    numeric.Value = 15.5
	    numeric.ValueFormat = ValueFormat.Numeric
	    numeric.NumberFormatInfo = New NumberFormatInfo() With {
	      .NumberDecimalDigits = 0
	    }
	    'the display result is "16"
	
	    Return numeric
	End Function
```



```XAML
	<UserControl xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	             xmlns:global="clr-namespace:System.Globalization;assembly=mscorlib">
	    <Grid>
	        <telerik:RadNumericUpDown ValueFormat="Numeric">
	            <telerik:RadNumericUpDown.NumberFormatInfo>
	                <global:NumberFormatInfo NumberDecimalDigits="0"/>
	            </telerik:RadNumericUpDown.NumberFormatInfo>
	        </telerik:RadNumericUpDown>
	    </Grid>
	</UserControl>
```

* __ValueFormat set to Currency__



```C#
	private RadNumericUpDown TestMethod()
	{
	    RadNumericUpDown numeric = new RadNumericUpDown();
	    numeric.Value = 15.50;
	    numeric.ValueFormat = ValueFormat.Currency;
	    numeric.NumberFormatInfo = new NumberFormatInfo() { CurrencyDecimalDigits = 2 };
	    //ContentText is "$15.50"
	    return numeric;
	}
```



```VB.NET
	Private Function TestMethod() As RadNumericUpDown
	    Dim numeric As RadNumericUpDown = New RadNumericUpDown
	    numeric.Value = 15.5
	    numeric.ValueFormat = ValueFormat.Currency
	    numeric.NumberFormatInfo = New NumberFormatInfo() With {
	      .CurrencyDecimalDigits = 2
	    }
	    'the display result is "$15.50"
	
	    Return numeric
	End Function
```



```XAML
	<UserControl xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	             xmlns:global="clr-namespace:System.Globalization;assembly=mscorlib">
	    <Grid>
	        <telerik:RadNumericUpDown ValueFormat="Currency">
	            <telerik:RadNumericUpDown.NumberFormatInfo>
	                <global:NumberFormatInfo CurrencyDecimalDigits="2"/>
	            </telerik:RadNumericUpDown.NumberFormatInfo>
	        </telerik:RadNumericUpDown>
	    </Grid>
	</UserControl>
```

* __ValueFormat set to Percentage__



```C#
	private RadNumericUpDown TestMethod()
	{
	    RadNumericUpDown numeric = new RadNumericUpDown();
	    numeric.Value = 15.50;
	    numeric.ValueFormat = ValueFormat.Percentage;
	    numeric.NumberFormatInfo = new NumberFormatInfo() { PercentDecimalDigits = 1 };
	    //ContentText is "%1500.5"
	    return numeric;
	}
```



```VB.NET
	Private Function TestMethod() As RadNumericUpDown
	    Dim numeric As RadNumericUpDown = New RadNumericUpDown
	    numeric.Value = 15.5
	    numeric.ValueFormat = ValueFormat.Percentage
	    numeric.NumberFormatInfo = New NumberFormatInfo() With {
	        .PercentDecimalDigits = 1
	    }
	    'the display result is "%1500.5"
	
	    Return numeric
	End Function
```



```XAML
	<UserControl xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	             xmlns:global="clr-namespace:System.Globalization;assembly=mscorlib">
	    <Grid>
	        <telerik:RadNumericUpDown ValueFormat="Percentage">
	            <telerik:RadNumericUpDown.NumberFormatInfo>
	                <global:NumberFormatInfo PercentDecimalDigits="1"/>
	            </telerik:RadNumericUpDown.NumberFormatInfo>
	        </telerik:RadNumericUpDown>
	    </Grid>
	</UserControl>
```

For custom formatting __RadNumericUpDown__ exposes additional property that is only used with the __Numeric__ value of __ValueFormat__. __CustomUnit__ is used to customize your formatting in case all the others type of formatting don't meet your needs.

Here is a simple example of how to use __CustomUnit__ property:        



```C#
	private RadNumericUpDown TestMethod()
	{
	    RadNumericUpDown numeric = new RadNumericUpDown();
	    numeric.Value = 10;
	    numeric.ValueFormat = ValueFormat.Numeric;
	    numeric.NumberFormatInfo = new NumberFormatInfo() { NumberDecimalDigits = 2 };
	    numeric.CustomUnit = "meters";
	    //the display result is "10.00 meters"
	    return numeric;
	}
```



```VB.NET
	Private Function TestMethod() As RadNumericUpDown
	    Dim numeric As RadNumericUpDown = New RadNumericUpDown
	    numeric.Value = 10
	    numeric.ValueFormat = ValueFormat.Numeric
	    numeric.NumberFormatInfo = New NumberFormatInfo() With {
	      .NumberDecimalDigits = 2
	    }
	    numeric.CustomUnit = "meters"
	    'the display result is "10.00 meters"
	    Return numeric
	End Function
```

## Using CustomUnit      

By design when the __ValueFormat__ property of the RadNumericUpDown control is set to __Percentage__ the input is parsed as follows:
        
Input	|	Parsed value
---	|	---
1	|	100.00%
45	|	4 500,00 %

The above parsing is correct and useful when using the value of the RadNumericUpDown to solve percentage of other values. In many other cases the desired parsing would be to show the input value directly as percentages. Meaning that entering 1 would lead to 1% not 100%. In order to achieve this parsing all that is needed is to set the __Minimum__, __Maximum__ and __CustomUnit__ properties of the control as follows:
        



```XAML
	<telerik:RadNumericUpDown Minimum="0"
	                          Maximum="100"
	                          CustomUnit="%"/>
```

The next table show examples of the input parsing when setting the above properties:
       
Input	|	Parsed value
---	|	---
1	|	1.00%
45	|	45,00 %

>When using the described approach and want to solve the percentages of other values using the value of the RadNumericUpDown make sure to divide it by 100 first.

## Hide Trailing Zeros    

__RadNumericUpDown__ provides property named __HideTrailingZeros__ which removes the digits after the decimal separator when they are all zeros. For example if you have the following __RadNumericUpDown__ with two decimal digits and value set to 42:        



```XAML
	<telerik:RadNumericUpDown NumberDecimalDigits="2" Value="42" />
```

It will look the following way:

![Rad Numeric Up Down Features Formatting 01](images/RadNumericUpDown_Features_Formatting_01.png)

If you set the __HideTrailingZeros__ property to True as shown below:       



```XAML
	<telerik:RadNumericUpDown NumberDecimalDigits="2" Value="42" HideTrailingZeros="True" />
```

This will be result:

![Rad Numeric Up Down Features Formatting 02](images/RadNumericUpDown_Features_Formatting_02.png)

>The default value of the property is __False__ - if there are trailing zeros they would be visible.         
