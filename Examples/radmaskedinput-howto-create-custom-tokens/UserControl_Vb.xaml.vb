#Region "radmaskedinput-howto-create-custom-tokens-0"
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

