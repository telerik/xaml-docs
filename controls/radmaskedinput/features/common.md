---
title: Common
page_title: Common
description: Common
slug: radmaskedinput-features-common
tags: common
published: True
position: 1
---

# Common



The __RadMaskedInput__ controls allow controlled user's input by implementing masking elements. Moreover, they expose the following properties that allow further customization of the masking behavior:
	  

## No-Mask Functionality

You can take advantage of the 'no-mask' functionality of the __RadMaskedTextInput,RadMaskedNumericInput__ and the __RadMaskedCurrenyInput__ controls by setting the __Mask__ property to __""__ like so:
		

	
<telerik:RadMaskedTextInput  Mask=""/>
<telerik:RadMaskedCurrencyInput  Mask=""/>
<telerik:RadMaskedDateTimeInput  Mask=""/>
<telerik:RadMaskedNumericInput Mask=""/>		  
		  



This feature creates __RadMaskedInput__ controls that allow unlimited input. And as the __Mask__ property is empty, the controls won't expect a certain number of characters and this is why they will automatically update to fit the user input.
	  

>tipThe 'no-mask' functionality will remove the restrictions usually applied by the __Mask__ property on the type and the number of input characters in each of the controls. Still you can set the __FormatString__ property to control the input in the __RadMaskedInput__ controls when they don't specify a __Mask__. For example you can use the
			[Standard Numeric Format Strings](
				http://msdn.microsoft.com/en-us/library/dwhawy9k.aspx
			  ) and [Custom Numeric Format Strings](
				http://msdn.microsoft.com/en-us/library/0c899ak8.aspx
			  ) 
			to control the input in the __RadMaskedNumericInput__ and the __RadMaskedCurrencyInput__.
			This means that if you need to restrict the number of digits after the decimal point to 2 in a __RadMaskedNumericInput__, you can set its __FormatString__ property to __"n2"__:
		  

	
<telerik:RadMaskedNumericInput Mask="" FormatString="n2"/>		  
		  



## Input Behavior

The __RadMaskedInput__ controls allow you to specify the characters input behavior using the
		  __InputBehavior__ property. The property is an enumeration of type __InputBehavior__ and exposes the following values:
		

* __Replace__ - input characters on right of the current caret position
		  

* __Insert__ - inserts characters before the caret's current position for as long as there are empty positions to fill. When there are no empty positions to fill on left of the caret, then the characters are added on right of the caret.
		  

>You can change the __InputBehavior__ using the __Insert__ key.
			Also please keep in mind that the __InputBehavior__ reflects the behavior of the __Backspace__ and __Delete__ keys
		  

## Text and TextMode properties

The __RadMaskedInput__ controls expose a __Text__ property that gets the value displayed in the control when it isn't focused. The value of this property depends on the __TextMode__ enumeration, that exposed the following values:
		

* __MaskedText__ - if a __RadMaskedInput__ control's __TextMode__ property is set to __MaskedText__, its __Text__ value represents the formatted __Value__including the placeholder characters.
		  

* __PlainText__- if a __RadMaskedInput__ control's __TextMode__ property is set to __PlainText__, its __Text__ value will hold the formatted __Value__ but without the placeholder characters.____

#### __XAML__

{{region radmaskedinput-features-common_0}}
	        <StackPanel HorizontalAlignment="Center" VerticalAlignment="Center">
	            <TextBlock Margin="10, 10, 10, 0" 
	                       FontWeight="Bold"
	                       Text="TextMode: MaskedText" />
	            <telerik:RadMaskedNumericInput Margin="10, 10, 10, 0" 
	                                           Mask="#6.2"
	                                           TextMode="MaskedText"
	                                           Value="123" />
	            <TextBlock Margin="10, 10, 10, 0" 
	                       FontWeight="Bold"
	                       Text="TextMode: PlainText" />
	            <telerik:RadMaskedNumericInput Margin="10, 10, 10, 0" 
	                                           Mask="#6.2"
	                                           TextMode="PlainText"
	                                           Value="123" />
	        </StackPanel>
	{{endregion}}



![](images/radmaskedinput_features_text_mode.png)

## ValueToTextConverter

The __RadMaskedInput__ controls allow you to set an __IValueConverter__ to change the __Text__ property depending on the __Value__. The following example will illustrate a sample implementation of the ValueToTextConverter property.
		

Let's start by defining an __IValueConverter__:
		

#### __C#__

{{region radmaskedinput-features-common_1}}
	public class NumericValueToTextConverter : IValueConverter
	{
	 public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
	 {
	  if (value != null)
	  {
	   double doubleValue = 0d;
	   decimal decimalValue = 0m;
	   if (double.TryParse(value.ToString(), System.Globalization.NumberStyles.Number, culture, out doubleValue))
	   {
	    return "Double Value: " + doubleValue.ToString("n4");
	   }
	   else if (decimal.TryParse(value.ToString(), System.Globalization.NumberStyles.Any, culture, out decimalValue))
	   {
	    return "Decimal Value: " + decimalValue.ToString("c4");
	   }
	   else return value.ToString();
	  }
	  else
	  {
	   return value;
	  }
	 }
	 public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
	 {
	  throw new NotImplementedException();
	 }
	}
	{{endregion}}



#### __VB.NET__

{{region radmaskedinput-features-common_2}}
	Public Class NumericValueToTextConverter
		Implements IValueConverter
		Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object
			If value IsNot Nothing Then
				Dim doubleValue As Double = 0.0
				Dim decimalValue As Decimal = 0D
				If Double.TryParse(value.ToString(), System.Globalization.NumberStyles.Number, culture, doubleValue) Then
					Return "Double Value: " & doubleValue.ToString("n4")
				ElseIf Decimal.TryParse(value.ToString(), System.Globalization.NumberStyles.Any, culture, decimalValue) Then
					Return "Decimal Value: " & decimalValue.ToString("c4")
				Else
					Return value.ToString()
				End If
			Else
				Return value
			End If
		End Function
	
		Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object
			Throw New NotImplementedException()
		End Function
	End Class
	{{endregion}}



Now we can define the __NumericValueToTextConverter__ as a resource in our application and apply it to the __RadMaskedNumericInput__properties.
		

#### __XAML__

{{region radmaskedinput-features-common_3}}
	        <StackPanel HorizontalAlignment="Center" VerticalAlignment="Center">
	            <StackPanel.Resources>
	                 <local:NumericValueToTextConverter x:Key="numericValueToTextConverter" />  
	            </StackPanel.Resources>
	            <telerik:RadMaskedNumericInput Grid.Row="0" 
	                                           Width="220"
	                                           Margin="10, 10, 10, 0"
	                                           IsClearButtonVisible="False"
	                                           TextMode="PlainText"
	                                           ValueToTextConverter="{StaticResource numericValueToTextConverter}"
	                                           Value="123.45" />
	        </StackPanel>
	{{endregion}}



![](images/radmaskedinput_features_converter.png)

## Add/Remove the ClearButton

The default __Template__ of the __RadMaskedInput__ controls defines a __ClearButton__ that allows the user to clear the input. You can hide this button by setting the __IsClearButtonVisible__property to __False:__

____

#### __XAML__

{{region radmaskedinput-features-common_4}}
	        <StackPanel HorizontalAlignment="Center" VerticalAlignment="Center">
	            <TextBlock FontWeight="Bold" Text="IsClearButtonVisible='True'" />
	            <telerik:RadMaskedTextInput Margin="10" 
	                                        Mask="llll"
	                                        Value="abcd" />
	            <TextBlock FontWeight="Bold" Text="IsClearButtonVisible='False'" />
	            <telerik:RadMaskedTextInput Margin="10" 
	                                        IsClearButtonVisible="False"
	                                        Mask="llll"
	                                        Value="abcd" />
	        </StackPanel>
	{{endregion}}





![](images/radmaskedinput_features_clear_button.png)

## IsLastPositionEditable

The __IsLastPositionEditable__ property defines if the last position in the __RadMaskedInput__ controls
		  can be modified. If the property is set to __True__, the user will be able to edit the value in the last available position of the control. This is the default behavior of the __RadMaskedInput__ controls. However, if you need to restrict the user from changing this value, you can set the __IsLastPositionEditable__ property to __False__.
		

# See Also

 * [MaskedNumericInput]({%slug radmaskedinput-features-controls-numeric%})

 * [MaskedCurrencyInput]({%slug radmaskedinput-features-controls-currency%})

 * [MaskedTextInput]({%slug radmaskedinput-features-controls-text%})

 * [MaskedDateTimeInput]({%slug radmaskedinput-features-controls-datetime%})

 * [Mask Tokens]({%slug radmaskedinput-features-mask-tokens%})
