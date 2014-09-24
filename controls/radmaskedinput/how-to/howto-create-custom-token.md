---
title: How to Create Custom Mask Tokens
page_title: How to Create Custom Mask Tokens
description: How to Create Custom Mask Tokens
slug: radmaskedinput-howto-create-custom-token
tags: how,to,create,custom,mask,tokens
published: True
position: 3
---

# How to Create Custom Mask Tokens



You can find a list of all built-in mask tokens that you can use when defining the mask of the __RadMaskedInput__ controls
				in the
				[Mask Tokens]({%slug radmaskedinput-features-mask-tokens%}) article. However, when your scenario requirements cannot be implemented using the built-in tokens, you can create a custom mask token to better fit your needs.
			

## 

In order to create a custom mask token, you need to define a new class that should implement the
					{% if site.site_name == 'Silverlight' %}[ ITokenValidationRule](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_maskedinput_tokens_itokenvalidationrule.html){% endif %}{% if site.site_name == 'WPF' %}[ ITokenValidationRule](http://www.telerik.com/help/wpf/t_telerik_windows_controls_maskedinput_tokens_itokenvalidationrule.html){% endif %} interface.
				

#### __C#__

{{region radmaskedinput-howto-create-custom-tokens-0}}
	using System.Linq;
	using Telerik.Windows.Controls.MaskedInput.Tokens;
	
	public class CustomToken : ITokenValidationRule
	{
	
		#region ITokenValidationRule Members
	
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
	
	{{endregion}}



#### __VB.NET__

{{region radmaskedinput-howto-create-custom-tokens-0}}
	Imports System.Linq
	Imports Telerik.Windows.Controls.MaskedInput.Tokens
	
	Public Class CustomToken
		Implements ITokenValidationRule
	
	#Region "ITokenValidationRule Members"
	
		Public ReadOnly Property IsRequired() As Boolean
			Get
				Throw New NotImplementedException()
			End Get
		End Property
	
		Public Function IsValid(ByVal ch As Char) As Boolean
			Throw New NotImplementedException()
		End Function
	
		Public ReadOnly Property Token() As Char
			Get
				Throw New NotImplementedException()
			End Get
		End Property
	
		Public ReadOnly Property Type() As TokenTypes
			Get
				Throw New NotImplementedException()
			End Get
		End Property
	
		Public ReadOnly Property ValidChars() As String
			Get
				Throw New NotImplementedException()
			End Get
		End Property
	
	#End Region
	End Class
	#End Region
	
	#Region "radmaskedinput-howto-create-custom-tokens-1"
	Imports System.Linq
	Imports Telerik.Windows.Controls.MaskedInput.Tokens
	
	Public Class CustomToken
		Implements ITokenValidationRule
	#Region "ITokenValidationRule Members"
	
		Public ReadOnly Property IsRequired() As Boolean
			Get
				Return False
			End Get
		End Property
	
		Public Function IsValid(ByVal ch As Char) As Boolean
			Throw New NotImplementedException()
		End Function
	
		Public ReadOnly Property Token() As Char
			Get
				Return "$"c
			End Get
		End Property
	
		Public ReadOnly Property Type() As TokenTypes
			Get
				Return TokenTypes.AlphaNumeric
			End Get
		End Property
	
		Private myValidChars As String = "0123456789#*"
		Public ReadOnly Property ValidChars() As String
			Get
				Return myValidChars
			End Get
		End Property
	
	#End Region
	End Class
	#End Region
	
	#Region "radmaskedinput-howto-create-custom-tokens-2"
	Public Function IsValid(ByVal ch As Char) As Boolean
		Return ValidChars.Contains(ch)
	End Function
	#End Region
	
	#Region "radmaskedinput-howto-create-custom-tokens-3"
	Imports System.Linq
	Imports Telerik.Windows.Controls.MaskedInput.Tokens
	
	Public Class CustomToken
		Implements ITokenValidationRule
	#Region "ITokenValidationRule Members"
	
		Public ReadOnly Property IsRequired() As Boolean
			Get
				Return False
			End Get
		End Property
	
		Public Function IsValid(ByVal ch As Char) As Boolean
			Return ValidChars.Contains(ch)
		End Function
	
		Public ReadOnly Property Token() As Char
			Get
				Return "$"c
			End Get
		End Property
	
		Public ReadOnly Property Type() As TokenTypes
			Get
				Return TokenTypes.AlphaNumeric
			End Get
		End Property
	
		Private myValidChars As String = "0123456789#*"
		Public ReadOnly Property ValidChars() As String
			Get
				Return myValidChars
			End Get
		End Property
	
	#End Region
	End Class
	#End Region
	
	#Region "radmaskedinput-howto-create-custom-tokens-4"
	Imports System.Windows.Controls
	Imports Telerik.Windows.Controls.MaskedInput.Tokens
	
	Namespace MaskedInputSample
		Partial Public Class MainPage
			Inherits UserControl
			Public Sub New()
				TokenLocator.AddCustomValidationRule(New CustomToken())
				InitializeComponent()
			End Sub
		End Class
	End Namespace
	#End Region
	
	#Region "radmaskedinput-howto-create-custom-tokens-5"
	Imports System.Windows.Controls
	Imports Telerik.Windows.Controls.MaskedInput.Tokens
	
	Namespace MaskedInputSample
		Partial Public Class MainWindow
			Inherits Window
			Public Sub New()
				TokenLocator.AddCustomValidationRule(New CustomToken())
				InitializeComponent()
			End Sub
		End Class
	End Namespace
	#End Region
	



Then you can start configuring the custom token through the following properties:
					

* __IsRequired__- this property is of type __bool__
							and it defines if the value that the token represents is a required input.
						

* __Token__ - this property is of type __char__ and it keeps the char that represents the custom mask token.
						

* __Type__ - this property is an enumeration of type __TokenTypes__ and it represents the type of the token. The __TokenTypes__ enumeration exposes the following values:
							

* __AlphaNumeric__ - tokens that represent a combination of alphabetic and numeric characters;
								

* __Date__ - tokens that represent __DateTime__ values;
							

* __Modifier__ - characters that modify the entered input.
								

* __ValidChars__ - this property is of type __string__ and it holds the string of characters that the mask token will represent.
						

#### __C#__

{{region radmaskedinput-howto-create-custom-tokens-1}}
	using System.Linq;
	using Telerik.Windows.Controls.MaskedInput.Tokens;
	
	public class CustomToken : ITokenValidationRule
	{
		#region ITokenValidationRule Members
	
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
	
	{{endregion}}



#### __VB.NET__

{{region radmaskedinput-howto-create-custom-tokens-1}}
	Imports System.Linq
	Imports Telerik.Windows.Controls.MaskedInput.Tokens
	
	Public Class CustomToken
		Implements ITokenValidationRule
	#Region "ITokenValidationRule Members"
	
		Public ReadOnly Property IsRequired() As Boolean
			Get
				Return False
			End Get
		End Property
	
		Public Function IsValid(ByVal ch As Char) As Boolean
			Throw New NotImplementedException()
		End Function
	
		Public ReadOnly Property Token() As Char
			Get
				Return "$"c
			End Get
		End Property
	
		Public ReadOnly Property Type() As TokenTypes
			Get
				Return TokenTypes.AlphaNumeric
			End Get
		End Property
	
		Private myValidChars As String = "0123456789#*"
		Public ReadOnly Property ValidChars() As String
			Get
				Return myValidChars
			End Get
		End Property
	
	#End Region
	End Class
	#End Region
	
	#Region "radmaskedinput-howto-create-custom-tokens-2"
	Public Function IsValid(ByVal ch As Char) As Boolean
		Return ValidChars.Contains(ch)
	End Function
	#End Region
	
	#Region "radmaskedinput-howto-create-custom-tokens-3"
	Imports System.Linq
	Imports Telerik.Windows.Controls.MaskedInput.Tokens
	
	Public Class CustomToken
		Implements ITokenValidationRule
	#Region "ITokenValidationRule Members"
	
		Public ReadOnly Property IsRequired() As Boolean
			Get
				Return False
			End Get
		End Property
	
		Public Function IsValid(ByVal ch As Char) As Boolean
			Return ValidChars.Contains(ch)
		End Function
	
		Public ReadOnly Property Token() As Char
			Get
				Return "$"c
			End Get
		End Property
	
		Public ReadOnly Property Type() As TokenTypes
			Get
				Return TokenTypes.AlphaNumeric
			End Get
		End Property
	
		Private myValidChars As String = "0123456789#*"
		Public ReadOnly Property ValidChars() As String
			Get
				Return myValidChars
			End Get
		End Property
	
	#End Region
	End Class
	#End Region
	
	#Region "radmaskedinput-howto-create-custom-tokens-4"
	Imports System.Windows.Controls
	Imports Telerik.Windows.Controls.MaskedInput.Tokens
	
	Namespace MaskedInputSample
		Partial Public Class MainPage
			Inherits UserControl
			Public Sub New()
				TokenLocator.AddCustomValidationRule(New CustomToken())
				InitializeComponent()
			End Sub
		End Class
	End Namespace
	#End Region
	
	#Region "radmaskedinput-howto-create-custom-tokens-5"
	Imports System.Windows.Controls
	Imports Telerik.Windows.Controls.MaskedInput.Tokens
	
	Namespace MaskedInputSample
		Partial Public Class MainWindow
			Inherits Window
			Public Sub New()
				TokenLocator.AddCustomValidationRule(New CustomToken())
				InitializeComponent()
			End Sub
		End Class
	End Namespace
	#End Region
	



When you define the properties that describe the custom token, you need to implement a logic that controls whether the entered character is valid for that custom token. This logic should be placed in the __IsValid()__ method, that should validate the user input to return a bool value.
				

#### __C#__

{{region radmaskedinput-howto-create-custom-tokens-2}}
	public bool IsValid(char ch)
	{
		return ValidChars.Contains(ch);
	}
	{{endregion}}



#### __VB.NET__

{{region radmaskedinput-howto-create-custom-tokens-2}}
	Public Function IsValid(ByVal ch As Char) As Boolean
		Return ValidChars.Contains(ch)
	End Function
	#End Region
	
	#Region "radmaskedinput-howto-create-custom-tokens-3"
	Imports System.Linq
	Imports Telerik.Windows.Controls.MaskedInput.Tokens
	
	Public Class CustomToken
		Implements ITokenValidationRule
	#Region "ITokenValidationRule Members"
	
		Public ReadOnly Property IsRequired() As Boolean
			Get
				Return False
			End Get
		End Property
	
		Public Function IsValid(ByVal ch As Char) As Boolean
			Return ValidChars.Contains(ch)
		End Function
	
		Public ReadOnly Property Token() As Char
			Get
				Return "$"c
			End Get
		End Property
	
		Public ReadOnly Property Type() As TokenTypes
			Get
				Return TokenTypes.AlphaNumeric
			End Get
		End Property
	
		Private myValidChars As String = "0123456789#*"
		Public ReadOnly Property ValidChars() As String
			Get
				Return myValidChars
			End Get
		End Property
	
	#End Region
	End Class
	#End Region
	
	#Region "radmaskedinput-howto-create-custom-tokens-4"
	Imports System.Windows.Controls
	Imports Telerik.Windows.Controls.MaskedInput.Tokens
	
	Namespace MaskedInputSample
		Partial Public Class MainPage
			Inherits UserControl
			Public Sub New()
				TokenLocator.AddCustomValidationRule(New CustomToken())
				InitializeComponent()
			End Sub
		End Class
	End Namespace
	#End Region
	
	#Region "radmaskedinput-howto-create-custom-tokens-5"
	Imports System.Windows.Controls
	Imports Telerik.Windows.Controls.MaskedInput.Tokens
	
	Namespace MaskedInputSample
		Partial Public Class MainWindow
			Inherits Window
			Public Sub New()
				TokenLocator.AddCustomValidationRule(New CustomToken())
				InitializeComponent()
			End Sub
		End Class
	End Namespace
	#End Region
	



Finally our custom token will have the following dfinition: 

#### __C#__

{{region radmaskedinput-howto-create-custom-tokens-3}}
	using System.Linq;
	using Telerik.Windows.Controls.MaskedInput.Tokens;
	
	public class CustomToken : ITokenValidationRule
	{
		#region ITokenValidationRule Members
	
		public bool IsRequired
		{
			get { return false; }
		}
	
		public bool IsValid(char ch)
		{
			return ValidChars.Contains(ch);
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
	
	{{endregion}}



#### __VB.NET__

{{region radmaskedinput-howto-create-custom-tokens-3}}
	Imports System.Linq
	Imports Telerik.Windows.Controls.MaskedInput.Tokens
	
	Public Class CustomToken
		Implements ITokenValidationRule
	#Region "ITokenValidationRule Members"
	
		Public ReadOnly Property IsRequired() As Boolean
			Get
				Return False
			End Get
		End Property
	
		Public Function IsValid(ByVal ch As Char) As Boolean
			Return ValidChars.Contains(ch)
		End Function
	
		Public ReadOnly Property Token() As Char
			Get
				Return "$"c
			End Get
		End Property
	
		Public ReadOnly Property Type() As TokenTypes
			Get
				Return TokenTypes.AlphaNumeric
			End Get
		End Property
	
		Private myValidChars As String = "0123456789#*"
		Public ReadOnly Property ValidChars() As String
			Get
				Return myValidChars
			End Get
		End Property
	
	#End Region
	End Class
	#End Region
	
	#Region "radmaskedinput-howto-create-custom-tokens-4"
	Imports System.Windows.Controls
	Imports Telerik.Windows.Controls.MaskedInput.Tokens
	
	Namespace MaskedInputSample
		Partial Public Class MainPage
			Inherits UserControl
			Public Sub New()
				TokenLocator.AddCustomValidationRule(New CustomToken())
				InitializeComponent()
			End Sub
		End Class
	End Namespace
	#End Region
	
	#Region "radmaskedinput-howto-create-custom-tokens-5"
	Imports System.Windows.Controls
	Imports Telerik.Windows.Controls.MaskedInput.Tokens
	
	Namespace MaskedInputSample
		Partial Public Class MainWindow
			Inherits Window
			Public Sub New()
				TokenLocator.AddCustomValidationRule(New CustomToken())
				InitializeComponent()
			End Sub
		End Class
	End Namespace
	#End Region
	



In order to use this custom token in the __MaskedInput__ controls, you have to add it in the __MaskedInput.Tokens__ using the 
					{% if site.site_name == 'Silverlight' %}[ TokenLocator](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_maskedinput_tokens_tokenlocator.html){% endif %}{% if site.site_name == 'WPF' %}[ TokenLocator](http://www.telerik.com/help/wpf/t_telerik_windows_controls_maskedinput_tokens_tokenlocator.html){% endif %} class
					{% if site.site_name == 'Silverlight' %}[ AddCustomValidationRule()](http://www.telerik.com/help/silverlight/m_telerik_windows_controls_maskedinput_tokens_tokenlocator_addcustomvalidationrule.html){% endif %}{% if site.site_name == 'WPF' %}[ AddCustomValidationRule()](http://www.telerik.com/help/wpf/m_telerik_windows_controls_maskedinput_tokens_tokenlocator_addcustomvalidationrule.html){% endif %} method. This method takes as an argument an object of type __ITokenValidationRule__ so you can pass the custom token.
				

After the custom token is added in the Tokens collection of the __RadMaskedInput__ controls, you can use it in the __RadMaskedTextInput__ control definition:

#### __XAML__

{{region radmaskedinput-howto-create-custom-tokens-0}}
	<Grid Background="White">
	    <telerik:RadMaskedTextInput Width="200" 
	                                Margin="20 20 20 10"
	                                HorizontalAlignment="Center"
	                                VerticalAlignment="Center"
	                                Mask="$$-$$$$-$$$$" />
	</Grid>
	{{endregion}}

![radmaskedinput-howto-create-custom-token](images/radmaskedinput-howto-create-custom-token.png)

# See Also

 * [Getting Started]({%slug radmaskedinput-getting-started%})

 * [Common Features]({%slug radmaskedinput-features-common%})

 * [How to Define Consecutive Input]({%slug radmaskedinput-howto-allow-skip-placeholders%})

 * [How to Remove the Thousands Separator]({%slug radmaskedinput-howto-number-groups-separator%})

 * [How to Enter Only Positive Numbers]({%slug radmaskedinput-howto-enter-positive-values%})
