---
title: How to Create Custom Mask Tokens
page_title: How to Create Custom Mask Tokens
description: Check our &quot;How to Create Custom Mask Tokens&quot; documentation article for the RadMaskedInput {{ site.framework_name }} control.
slug: radmaskedinput-howto-create-custom-token
tags: how,to,create,custom,mask,tokens
published: True
position: 3
---

# How to Create Custom Mask Tokens

This article shows how to implement a custom mask token.

Find a list of all built-in mask tokens that can be used with the __RadMaskedInput__ controls in the [Mask Tokens]({%slug radmaskedinput-features-mask-tokens%}) article. 

To create a custom token, you should implement the [ITokenValidationRule](https://www.telerik.com/products/wpf/documentation/api/telerik.windows.controls.maskedinput.tokens.itokenvalidationrule) interface.

__Example 1: Creating custom class which inherits ITokenValidationRule interface__
```C#
	using System.Linq;
	using Telerik.Windows.Controls.MaskedInput.Tokens;

	public class CustomToken : ITokenValidationRule
	{
		public bool IsRequired
		{
			get { throw new NotImplementedException(); }
		}

		public bool IsValid(char ch)
		{
			throw new NotImplementedException();
		}

		public char Token
		{
			get { throw new NotImplementedException(); }
		}

		public TokenTypes Type
		{
			get { throw new NotImplementedException(); }
		}

		public string ValidChars
		{
			get { throw new NotImplementedException(); }
		}
	}
```
```VB.NET
	Public Class CustomToken
        Implements ITokenValidationRule

        Public ReadOnly Property IsRequired() As Boolean Implements ITokenValidationRule.IsRequired
            Get
                Throw New NotImplementedException()
            End Get
        End Property

        Public Function IsValid(ByVal ch As Char) As Boolean Implements ITokenValidationRule.IsValid

            Throw New NotImplementedException()
        End Function

        Public ReadOnly Property Token() As Char Implements ITokenValidationRule.Token
            Get
                Throw New NotImplementedException()
            End Get
        End Property

        Public ReadOnly Property Type() As TokenTypes Implements ITokenValidationRule.Type
            Get
                Throw New NotImplementedException()
            End Get
        End Property

        Public ReadOnly Property ValidChars() As String Implements ITokenValidationRule.ValidChars
            Get
                Throw New NotImplementedException()
            End Get
        End Property
    End Class
```	

Then you can start configuring the custom token through the following properties:					

* __IsRequired__- this property is of type __bool__ and it defines if the value that the token represents is a required input.						

* __Token__ - this property is of type __char__ and it keeps the char that represents the custom mask token.						

* __Type__ - this property is an enumeration of type __TokenTypes__ and it represents the type of the token. The __TokenTypes__ enumeration exposes the following values:							
	* __AlphaNumeric__ - tokens that represent a combination of alphabetic and numeric characters;
	* __Date__ - tokens that represent __DateTime__ values;
	
* __Modifier__ - characters that modify the entered input.								

* __ValidChars__ - this property is of type __string__ and it holds the string of characters that the mask token will represent.						

__Example 2: Create CustomToken class__
```C#
	public class CustomToken : ITokenValidationRule
	{
		public bool IsRequired
		{
			get { return false; }
		}
		public bool IsValid(char ch)
		{
			throw new NotImplementedException();
		}
		public char Token
		{
			get { return '$'; }
		}
		public TokenTypes Type
		{
			get { return TokenTypes.AlphaNumeric; }
		}
		private string myValidChars = "0123456789#*";
		public string ValidChars
		{
			get { return myValidChars; }
		}
	}
```
```VB.NET
	Public Class CustomToken
		Implements ITokenValidationRule
		Public ReadOnly Property IsRequired() As Boolean Implements ITokenValidationRule.IsRequired
			Get
				Return False
			End Get
		End Property
		Public Function IsValid(ByVal ch As Char) As Boolean Implements ITokenValidationRule.IsValid
			Throw New NotImplementedException()
		End Function
		Public ReadOnly Property Token() As Char Implements ITokenValidationRule.Token
			Get
				Return "$"c
			End Get
		End Property
		Public ReadOnly Property Type() As TokenTypes Implements ITokenValidationRule.Type
			Get
				Return TokenTypes.AlphaNumeric
			End Get
		End Property
		Private myValidChars As String = "0123456789#*"
		Public ReadOnly Property ValidChars() As String Implements ITokenValidationRule.ValidChars
			Get
				Return myValidChars
			End Get
		End Property
	End Class
```	
When you define the properties that describe the custom token, you need to implement a logic that controls whether the entered character is valid for that custom token. This logic should be placed in the __IsValid()__ method, that should validate the user input to return a bool value.				

__Example 3: Validating the entered character__
```C#
	public bool IsValid(char ch)
	{
		return ValidChars.Contains(ch);
	}
```
```VB.NET
	Public Function IsValid(ByVal ch As Char) As Boolean
		Return ValidChars.Contains(ch)
	End Function
```

Finally our custom token will have the following dеfinition: 

__Example 4: Final custom token definition__
```C#
	public class CustomToken : ITokenValidationRule
	{
		public bool IsRequired
		{
			get { return false; }
		}
		public bool IsValid(char character)
		{
			return ValidChars.Contains(character);
		}
		public char Token
		{
			get { return '$'; }
		}
		public TokenTypes Type
		{
			get { return TokenTypes.AlphaNumeric; }
		}
		private string myValidChars = "0123456789#*";
		public string ValidChars
		{
			get { return myValidChars; }
		}
	}
```
```VB.NET
	Public Class CustomToken
		Implements ITokenValidationRule
		Public ReadOnly Property IsRequired() As Boolean Implements ITokenValidationRule.IsRequired
			Get
				Return False
			End Get
		End Property
		Public Function IsValid(ByVal ch As Char) As Boolean Implements ITokenValidationRule.IsValid
			Return ValidChars.Contains(ch)
		End Function
		Public ReadOnly Property Token() As Char Implements ITokenValidationRule.Token
			Get
				Return "$"c
			End Get
		End Property
		Public ReadOnly Property Type() As TokenTypes Implements ITokenValidationRule.Type
			Get
				Return TokenTypes.AlphaNumeric
			End Get
		End Property
		Private myValidChars As String = "0123456789#*"
		Public ReadOnly Property ValidChars() As String Implements ITokenValidationRule.ValidChars
			Get
				Return myValidChars
			End Get
		End Property
	End Class
```	

To use this custom token in the __MaskedInput__ controls, add it in the __MaskedInput.Tokens__ using the `AddCustomValidationRule` method of the [TokenLocator](https://www.telerik.com/products/wpf/documentation/api/telerik.windows.controls.maskedinput.tokens.tokenlocator) class.

After the custom token is added in the Tokens collection of the __RadMaskedInput__ controls, you can use it in the __RadMaskedTextInput__ control definition:

__Example 5:  Defining RadMaskedTextInput control in XAML__
```XAML
	<Grid Background="White">
	    <telerik:RadMaskedTextInput Width="200" 
	                                Margin="20 20 20 10"
	                                HorizontalAlignment="Center"
	                                VerticalAlignment="Center"
	                                Mask="$$-$$$$-$$$$" />
	</Grid>
```

![radmaskedinput-howto-create-custom-token](images/radmaskedinput-howto-create-custom-token.png)

## See Also
 * [Getting Started]({%slug radmaskedinput-getting-started%})
 * [Common Features]({%slug radmaskedinput-features-common%})
 * [How to Define Consecutive Input]({%slug radmaskedinput-howto-allow-skip-placeholders%})
 * [How to Remove the Thousands Separator]({%slug radmaskedinput-howto-number-groups-separator%})
 * [How to Enter Only Positive Numbers]({%slug radmaskedinput-howto-enter-positive-values%})
